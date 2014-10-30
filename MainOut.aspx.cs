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

public partial class MainOut : System.Web.UI.Page
{
    public string strXhxx;
    public string strXhlx;
    protected void Page_Load(object sender, EventArgs e)
    {

        // 在此处放置用户代码以初始化页面
        DataTable tmpda = new DataTable();
        tmpda = DataControl.GetDataTable("select * from XHLX order by lxjb");
        string DPath;
        if (Server.MapPath("").Substring(Server.MapPath("").Length - 1, 1) == @"\")
        {
            DPath = Server.MapPath("");
        }
        else
        {
            DPath = Server.MapPath("") + @"\";
        }
        DPath = DPath + @"image\";
        //显示鲜花类型列表 显示方式 如果总记录数%2＝0 则 循环显示全部
        if (tmpda.Rows.Count > 0) 
        {
            if (tmpda.Rows.Count % 2 == 0)
            {
                strXhlx = "";
                for (int i = 0; i < tmpda.Rows.Count / 2; i++)
                {
                    strXhlx = strXhlx + "<tr>";
                    string strTmpLx = "";
                    //如果花的类型时精品花卉 则 加红字体显示
                    if (tmpda.Rows[2 * i]["Lxjb"].ToString() == "精品花卉")
                    {
                        strTmpLx = "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'> <a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i]["lxbh"].ToString() + "><font color='red'>" + tmpda.Rows[2 * i]["Lxmc"].ToString() + "</font></a></td>";
                    }
                    else
                    {
                        strTmpLx = "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'> <a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i]["lxbh"].ToString() + ">" + tmpda.Rows[2 * i]["Lxmc"].ToString() + "</a></td>";
                    }
                    //如果花的类型时精品花卉 则 加红字体显示
                    if (tmpda.Rows[2 * i + 1]["lxjb"].ToString() == "精品花卉")
                    {
                        strTmpLx = strTmpLx + "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'><a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i + 1]["lxbh"].ToString() + "><font color='red'>" + tmpda.Rows[2 * i + 1]["Lxmc"].ToString() + "</font></a></td>";
                    }
                    else
                    {
                        strTmpLx = strTmpLx + "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'><a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i + 1]["lxbh"].ToString() + ">" + tmpda.Rows[2 * i + 1]["Lxmc"].ToString() + "</a></td>";
                    }
                    strXhlx = strXhlx + strTmpLx + "</tr>";

                }
            }
            else
            {
                strXhlx = "";
                //否则 循环显示全部记录－1 在后面补足最后一条记录
                for (int i = 0; i < (tmpda.Rows.Count - 1) / 2; i++)
                {
                    strXhlx = strXhlx + "<tr>";
                    string strTmpLx = "";
                    //如果花的类型时精品花卉 则 加红字体显示
                    if (tmpda.Rows[2 * i]["Lxjb"].ToString() == "精品花卉")
                    {
                        strTmpLx = "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'> <a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i]["lxbh"].ToString() + "><font color='red'>" + tmpda.Rows[2 * i]["Lxmc"].ToString() + "</font></a></td>";
                    }
                    else
                    {
                        strTmpLx = "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'> <a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i]["lxbh"].ToString() + ">" + tmpda.Rows[2 * i]["Lxmc"].ToString() + "</a></td>";
                    }
                    //如果花的类型时精品花卉 则 加红字体显示
                    if (tmpda.Rows[2 * i + 1]["lxjb"].ToString() == "精品花卉")
                    {
                        strTmpLx = strTmpLx + "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'><a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i + 1]["lxbh"].ToString() + "><font color='red'>" + tmpda.Rows[2 * i + 1]["Lxmc"].ToString() + "</font></a></td>";
                    }
                    else
                    {
                        strTmpLx = strTmpLx + "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'><a href=Mainout.aspx?Lxbh=" + tmpda.Rows[2 * i + 1]["lxbh"].ToString() + ">" + tmpda.Rows[2 * i + 1]["Lxmc"].ToString() + "</a></td>";
                    }
                    strXhlx = strXhlx + strTmpLx + "</tr>";

                }
                //拼接最后一条记录
                string strTmpLx1 = "";
                strXhlx = strXhlx + "<tr>";
                strTmpLx1 = "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' >" + "<img src='image/dot.bmp'> <a href=Mainout.aspx?Lxbh=" + tmpda.Rows[tmpda.Rows.Count - 1]["lxbh"].ToString() + ">" + tmpda.Rows[tmpda.Rows.Count - 1]["Lxmc"].ToString() + "</a></td>";
                strXhlx = strXhlx + strTmpLx1 + "</tr>";

            }

        }
        //判断当前登陆人员是不是管理员 屏蔽相应的不可以使用的菜单
        if (!Page.IsPostBack)
        {
            if (Session["User"].ToString() == "admin")
            {
                this.TextBox1.Text = "admin";
                this.TextBox2.Text = "管理员";
                this.Button1.Visible = false;
                this.Button2.Visible = false;
            }
            else
            {
                this.TextBox1.Text = Session["User"].ToString();
                this.TextBox2.Text = "会员";
                this.Button3.Visible = false;
                this.Button4.Visible = false;
                this.Button5.Visible = false;
                this.Button6.Visible = false;
            }
        }
        if (Request.QueryString["Lxbh"] == null || Request.QueryString["lxbh"].ToString() == "0")
        {
            //显示全部的鲜花信息 	
            tmpda = DataControl.GetDataTable("select * from XHXX");
            strXhxx = DataControl.initFlowerList(tmpda, DPath);
        }
        else
        {
            //显示制定类型的鲜花信息
            tmpda = DataControl.GetDataTable("select * from XHXX where lxbh=" + Request.QueryString["lxbh"].ToString());
            strXhxx = DataControl.initFlowerList(tmpda, DPath);
        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("FlowerDDList.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("GwcList.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("FlowerTypeList.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("FlowerXhxxList.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("UserList.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("FlowerDDList.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        //跳转页面
        Session.Remove("User");
        Response.Redirect("Mainin.aspx");
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("FlowerUser.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("LT/YgltList.aspx");
    }
}
