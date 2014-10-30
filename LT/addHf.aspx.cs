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

public partial class YGLT_addHf : System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //将内容显示在相关的控件中
            if (Session["User"] == null)
            {
                this.TUserName.InnerHtml = "临时游客";
            }
            else
            {
                this.TUserName.InnerHtml = Session["User"].ToString();
            }
            this.Tdate.InnerHtml = DateTime.Now.Date.ToShortDateString();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //关闭窗体
        Response.Write("<script>window.close();</script>");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //判断信息是否正确
        if (this.Textbox3.Text.Trim() == "")
        {
            this.TErr.InnerHtml = "<font color='red'>回复信息不能为空</font>";
            return;
        }
        //添加新的回复信息
        DataControl.ExecSql("insert into 论坛回复(主题编号,回复内容,会员帐号,回复时间) values(" + Request.QueryString["ID"] + ",'" + Textbox3.Text + "','" + this.TUserName.InnerHtml + "','" + DateTime.Now.Date.ToShortDateString() + "')");
        Response.Write("<script>window.opener.location.href='YgltEdit.aspx?ID=" + Request.QueryString["ID"] + "';</script>");
        Response.Write("<script>window.close();</script>");
    }
}
