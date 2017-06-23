using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BLL;
//using Model;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class ProductMetalsCateMage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                Response.Redirect("../login.aspx");
            }
            if (IsPostBack)
                return;
            Deop();
            GetDataBind();
            if (Request["id"] == null)
            {
                btn_add.Visible = true;
                btn_update.Visible = false;
            }
            else
            {
                btn_update.Visible = true;
                btn_add.Visible = false;
                GetModel();
            } 
        }
        //B_ProductMetals bpMetals = new B_ProductMetals();
        //B_PrdeictCate bpcate = new B_PrdeictCate();
        public void Deop()
        {
            //Drop_cateID.DataSource = bpcate.GetALLData();
            //Drop_cateID.DataTextField = "TypeName";
            //Drop_cateID.DataValueField = "ID";
            //Drop_cateID.DataBind();
        }

        public void GetModel()
        {
            //string IDs = Request["id"].ToString();
            //T_ProductMetals model = new T_ProductMetals();
            //model = bpMetals.GetModel(IDs);
            //txt_title.Text = model.Title;
            //Drop_cateID.SelectedValue = model.CID.ToString();

        }

        public void GetDataBind()
        {
            //GridView1.DataSource = bpMetals.GetCateData();
            //GridView1.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
//            T_ProductMetals model = new T_ProductMetals();
//            model.CID = int.Parse(Drop_cateID.SelectedValue);
//            model.Title = txt_title.Text;
//            model.Addtime = DateTime.Now;
//            if (bpMetals.InsertOrUpdateAbount(model) > 0)
//            {
//                Session.Clear();
//                GetDataBind();
//                Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");

//                return;
//            }
//            else
//            {
//                Page.ClientScript.RegisterStartupScript(this.GetType(), "error", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加失败');</script>
//            ");
//            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            //T_ProductMetals model = new T_ProductMetals();
            //int id = int.Parse(Request["id"].ToString());
            //model.ID = id;
            //model.CID = int.Parse(Drop_cateID.SelectedValue);
            //model.Title = txt_title.Text;
            //model.Addtime = DateTime.Now;
            //if (bpMetals.InsertOrUpdateAbount(model) > 0)
            //{
            //    lb_message.Text = "分类修改成功！";
            //    GetDataBind();
            //}
            //else
            //{
            //    lb_message.Text = "分类修改失败！";
            //}
        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string cateid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //int i = bpMetals.Delete(cateid);

            //if (i > 0)
            //{
            //    GetDataBind();
            //}
            //if (i == -1)
            //{
            //    lb_delete.Text = "该分类存在下级分类！不能删除！";
            //}
        }
    }
}