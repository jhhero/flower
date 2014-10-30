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

public partial class RegUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //判断注册信息是否正确
        if (this.TextBox1.Text.Trim() == "" || this.Textbox8.Text == "" || Textbox9.Text =="" )
        {
            this.TErr.InnerHtml = "<font color='red'>客户昵称、付款帐号或真实姓名不能为空</font>";
            return;
        }
        if (this.Textbox5.Text.Trim() != this.Textbox6.Text.Trim())
        {
            this.TErr.InnerHtml = "<font color='red'>密码不一致!</font>";
            return;
        }
        if (this.Textbox5.Text.Length < 6)
        {
            this.TErr.InnerHtml = "<font color='red'>密码长度不能小于6位!</font>";
            return; 
        }
        try
        {
            Int32  dt = Convert.ToInt32(TextBox3.Text);
        }
        catch
        {
            this.TErr.InnerHtml = "<font color='red'>电话号码必须为数字;</font>";
            return;
        }
        finally
        {

        }
        try
        {
            DateTime dt = Convert.ToDateTime(TextBox4.Text );
        }
        catch
        {
            this.TErr.InnerHtml = "<font color='red'>日期输入不正确;</font>";
            return;
        }
        finally
        {
 
        }
        DataTable tmpda = new DataTable();
        tmpda = DataControl.GetDataTable("select * from YHXX where Kh='" + this.TextBox1.Text.Trim() + "'");
        if (tmpda.Rows.Count > 0)
        {
            this.TErr.InnerHtml = "<font color='red'>客户昵称重复!</font>";
            return;
        }
        tmpda = DataControl.GetDataTable("select * from YHXX where Email='" + this.Textbox7.Text.Trim() + "'");
        if (tmpda.Rows.Count > 0)
        {
            this.TErr.InnerHtml = "<font color='red'>邮箱已经存在!</font>";
            return;
        }
        //添加注册的用户信息到数据库中
        DataControl.ExecSql("insert into YHXX(kh,mm,lxdz,dh,sr,Email,IDCount,真实姓名) values('" + this.TextBox1.Text.Trim() + "','" + this.Textbox5.Text.Trim() + "','" + this.Textbox2.Text.Trim() + "','" + this.TextBox3.Text.Trim() + "','" + this.TextBox4.Text.Trim() + "','" + this.Textbox7.Text.Trim() + "','" + this.Textbox8.Text.Trim() + "','"+  Textbox9.Text  +"')");
        Session["User"] = this.TextBox1.Text.Trim();
        Response.Redirect("MainOut.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("MainIn.aspx");
    }
}
