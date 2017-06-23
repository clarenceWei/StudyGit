using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Nevron.UI.WinForm.Controls;

namespace Nui.MallInfo.Utility
{
    public class AutoUser
    {
        /// <summary>
        /// 绑定根节点
        /// </summary>
        /// <param name="dt">数据table</param>
        /// <param name="ntreeView">控件</param> 
        public static void BindRoot(DataTable dt, NTreeView ntreeView)
        {
            DataRow[] rows = dt.Select("M_ParentId=0");//取根     
            foreach (DataRow dRow in rows)
            {
                TreeNode rootNode = new TreeNode();
                rootNode.Tag = dRow;
                rootNode.Checked = true;
                rootNode.Text = dRow["M_Name"].ToString();
                ntreeView.Nodes.Add(rootNode);
                BindChildAreas(rootNode, dt);
            }

            ntreeView.ExpandAll();
        }

        /// <summary>
        /// 递归绑定子区域
        /// </summary>
        /// <param name="fNode">子节点</param>
        /// <param name="dt">数据table</param>  
        public static void BindChildAreas(TreeNode fNode, DataTable dt)
        {
            DataRow dr = (DataRow)fNode.Tag;
            //父节点数据关联的数据行           
            int fid = Convert.ToInt32(dr["ModuleId"]);
            //父节点ID           
            DataRow[] rows = dt.Select("M_ParentId=" + fid + "");//子区域        
            if (rows.Length == 0)  //递归终止，区域不包含子区域时          
            { return; }
            foreach (DataRow dRow in rows)
            {
                TreeNode node = new TreeNode();
                node.Tag = dRow;
                if (dRow["RoleId"] != DBNull.Value)
                {
                    node.Checked = true;
                }

                node.Name = dRow["ModuleId"].ToString();
                node.Text = dRow["M_Name"].ToString(); //添加子点              
                fNode.Nodes.Add(node);                //递归              
                BindChildAreas(node, dt);
            }
        }

        //设置标志，防止死循环
        public static bool check = false;

        //设置子节点状态
        public static void SetChild(TreeNode node)
        {
            try
            {
                foreach (TreeNode child in node.Nodes)
                {
                    child.Checked = node.Checked;

                }
                check = true;
            }
            catch { check = true; }
        }


        //设置父节点状态
        public static void SetParent(TreeNode node)
        {
            if (node.Parent != null)
            {
                if (node.Checked)
                {
                    node.Parent.Checked = node.Checked;

                }
            }
        }

        public static StringBuilder nodesTag;//容器

        /// <summary>
        /// 获取treeview选中项
        /// </summary>
        /// <param name="parent"></param>
        public static void TraversNodes(TreeNode parent)
        {
            TreeNode node = parent;
            if (node != null)
            {
                if (node.Checked == true)
                    nodesTag.AppendFormat(node.Text + ",");

                if (node.FirstNode != null)////如果node节点还有子节点则进入遍历
                {
                    TraversNodes(node.FirstNode);
                }
                if (node.NextNode != null)////如果node节点后面有同级节点则进入遍历
                {
                    TraversNodes(node.NextNode);
                }
            }
        }
    }
}
