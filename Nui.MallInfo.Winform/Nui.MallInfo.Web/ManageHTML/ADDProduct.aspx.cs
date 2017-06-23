using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Model;
//using BLL;

namespace Nui.MallInfo.Web.ManageHTML
{
    public partial class ADDProduct : System.Web.UI.Page
    {
        //B_Product bproduct = new B_Product();
        //B_PrdeictCate bcate = new B_PrdeictCate();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(User.Identity.Name))
            //{
            //    Response.Redirect("../login.aspx");
            //}
            if (IsPostBack)
                return;
            Drop(); 
            if (Request["id"] != null)
            {
                GetModel();
            }
        }

        public void Drop() 
        {
            //Drop_cateID.DataSource = bcate.GetALLData();
            //Drop_cateID.DataTextField = "TypeName";
            //Drop_cateID.DataValueField = "ID";
            //Drop_cateID.DataBind();
        }

        public void GetModel() 
        {
            //T_Product model = new T_Product();
            //string IDs = Request["id"].ToString();
            //model = bproduct.GetModel(IDs);
            //txt_ProName.Text = model.Pro_Name;
            //txt_Market.Text = model.IsMarket;
            //Drop_cateID.SelectedValue = model.CID.ToString();
            //Label1.Text = model.ImageUrl;
            //newscontent1.Value = model.DES;
            //newscontent2.Value = model.ContractSize;
            //newscontent3.Value = model.KnowledgeDes;
        }


        protected void btn_ok_Click(object sender, EventArgs e)
        {
//            T_Product model = new T_Product();
//            model.AddTime = DateTime.Now;
//            model.CID = int.Parse(Drop_cateID.SelectedValue);
//            model.IsMarket = txt_Market.Text;
//            model.Pro_Name = txt_ProName.Text;
//            model.DES = Request.Form["newscontent1"];
//            model.ContractSize = Request.Form["newscontent2"];
//            model.KnowledgeDes = Request.Form["newscontent3"];
//            if (Request["id"] == null)
//            {
//                model.ImageUrl = Session["uploadPath1"] == null ? string.Empty : Session["uploadPath1"].ToString();
//                if (bproduct.InsertOrUpdateAbount(model) > 0)
//                {
//                    Session.Clear();
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");

//                    return;
//                }
//                else
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "error", @"
//                    <script type='text/javascript'>window.art.dialog.tips('添加失败');</script>
//            ");
//                }
//            }
//            else
//            {
//                model.ID = int.Parse(Request["id"]);
//                //  model.AttachUrl = Session["uploadPath"] == null ? string.Empty : Session["uploadPath"].ToString();
//                if (Session["uploadPath1"] != null)
//                {
//                    model.ImageUrl = Session["uploadPath1"].ToString();
//                }
//                else
//                {
//                    if (Label1.Text == null)
//                    {
//                        model.ImageUrl = string.Empty;
//                    }
//                    else
//                    {
//                        model.ImageUrl = Label1.Text;
//                    }
//                }

//                if (bproduct.InsertOrUpdateAbount(model) > 0)
//                {
//                    Session.Clear();
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "succes", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改成功');
//                    $(':text').val('');$('textarea').val('');
//                    </script>
//                ");
//                    Response.Redirect("ProductManage.aspx");
//                    return;
//                }
//                else
//                {
//                    Page.ClientScript.RegisterStartupScript(this.GetType(), "error", @"
//                    <script type='text/javascript'>window.art.dialog.tips('修改失败');</script>
//            ");
//                }

//            }
        }
    }
}