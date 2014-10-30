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

public partial class YGLT_YgltList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!Page.IsPostBack)
        {
            //显示所有的系统论坛记录列表
            GridView1.DataSource = DataControl.GetDataTable("select * from 系统论坛");
            GridView1.DataBind();
            if (Session["User"] == null)
            {
                LinkButton2.Visible = false;
                GridView1.Columns[5].Visible = false;
            }
            else if (Session["User"].ToString() != "admin")
            {
                GridView1.Columns[5].Visible = false;
            }

        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("addFb.aspx");
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string PID = this.GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
        if (e.CommandName == "See")
        {
            //传递 编号 跳转页面
            Response.Write("<script>window.open('YgltEdit.aspx?ID=" + PID + "'); </script>");
        }
        else if (e.CommandName == "Del")
        {
            //删除当前的主题记录 和主题回复记录
            DataControl.ExecSql("delete from 论坛回复 where 主题编号=" + PID + "");
            DataControl.ExecSql("delete from 系统论坛 where 主题编号=" + PID + "");
            GridView1.DataSource = DataControl.GetDataTable("select * from 系统论坛"); 
            GridView1.DataBind();
        }
    }
      protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex >= 0)
        {
            //格式化显示日期
            e.Row.Cells[3].Text = Convert.ToDateTime(e.Row.Cells[3].Text).Date.ToShortDateString();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //根据登陆权限 返回到不同的页面
        Response.Redirect("../MainOut.aspx");

    }
}
