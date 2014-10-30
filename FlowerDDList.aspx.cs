using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class FlowerDDList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            //显示所有的鲜花列表
            if (Session["User"].ToString() != "admin")
            {
                GridView1.DataSource = DataControl.GetDataTable("select * from XHDD where kh ='"+ Session["User"].ToString() +"'");
                GridView1.DataBind();
                this.GridView1.Columns[9].Visible = false;
            }
            else
            {
                GridView1.DataSource = DataControl.GetDataTable("select * from XHDD  ");
                GridView1.DataBind();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("MainOut.aspx");
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string Key = this.GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)]["Ddbh"].ToString();
        if (e.CommandName == "See")
        {
            //传递修改的标志 跳转页面
            Session["bh"] = Key;
            Response.Redirect("FlowerDDSee.aspx");
        }
        else if (e.CommandName == "Del")
        {
            //删除当前的鲜花订单信息
            DataControl.ExecSql("delete from XHDD where ddbh='" + Key  + "'");
            GridView1.DataSource = DataControl.GetDataTable("select * from XHDD");
            GridView1.DataBind();
        }

    }
}
