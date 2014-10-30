using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security; 
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Database 的摘要说明
/// </summary>
public class DataControl
{
    public DataControl()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static SqlConnection createConnection()
    {
        //从webconfig中取得字符串连接方式
        SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["String"].ConnectionString);
        return cnn;
    }
    public static DataTable GetDataTable(string SetStr)
    {
        //定义数据库连接 查询并填充DataSet

        SqlConnection tmpCnn = DataControl.createConnection();
        if (tmpCnn.State != 0)
        {
            tmpCnn.Close();
        }
        tmpCnn.Open();
        SqlDataAdapter cmd = new SqlDataAdapter(SetStr, tmpCnn);
        DataSet tmpDataSet = new DataSet();
        cmd.Fill(tmpDataSet);
        tmpCnn.Close();
        return tmpDataSet.Tables[0];
    }

    public static void ExecSql(string sqlStr)
    {
        //定义数据库连接　　执行数据库的增加　修改和删除数据的功能
        SqlConnection tmpCnn = DataControl.createConnection();
        if (tmpCnn.State != 0)
        {
            tmpCnn.Close();
        }
        tmpCnn.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = sqlStr;
        cmd.Connection = tmpCnn;
        cmd.ExecuteNonQuery();
        tmpCnn.Close();
    }



    public static string initFlowerList(DataTable tmpda, string Dpath)
    {
        //判断记录小于0的话 退出函数
        if (tmpda.Rows.Count <= 0)
        {
            return "";
        }

        string strFlowerList = "";
        if (tmpda.Rows.Count % 5 == 0)
        {
            //当鲜花总数为5的倍数的话  直接用循环显示所有的鲜花信息 
            for (int i = 0; i < tmpda.Rows.Count / 5; i++)
            {
                strFlowerList = strFlowerList + "<tr>";
                string strFlower = "";
                for (int j = 5 * i; j < 5 * i + 5; j++)
                {
                    //利用变量拼Html字符串  将鲜花信息拼接显示
                    strFlower = strFlower + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[j]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[j]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[j]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[j]["Xhjg"] + "<BR><BR></td>";
                }
                strFlowerList = strFlowerList + strFlower + "</tr>";
            }
        }
        else if (tmpda.Rows.Count % 5 == 1)
        {
            //当鲜花取余5等于1  用循环显示总记录数－1的鲜花数
            for (int i = 0; i < (tmpda.Rows.Count - 1) / 5; i++)
            {
                //利用变量拼Html字符串  将鲜花信息拼接显示
                strFlowerList = strFlowerList + "<tr>";
                string strFlower = "";
                for (int j = 5 * i; j < 5 * i + 5; j++)
                {
                    strFlower = strFlower + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[j]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[j]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[j]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[j]["Xhjg"] + "<BR><BR></td>";
                }
                strFlowerList = strFlowerList + strFlower + "</tr>";
            }
            //补足显示剩余的一个鲜花
            strFlowerList = strFlowerList + "<tr>";
            string strFlower1 = "";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 1]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhjg"] + "</td>";
            strFlowerList = strFlowerList + strFlower1 + "</tr>";

        }
        else if (tmpda.Rows.Count % 5 == 2)
        {
            //当鲜花取余5等于2  用循环显示总记录数－2的鲜花数
            for (int i = 0; i < (tmpda.Rows.Count - 2) / 5; i++)
            {
                //利用变量拼Html字符串  将鲜花信息拼接显示
                strFlowerList = strFlowerList + "<tr>";
                string strFlower = "";
                for (int j = 5 * i; j < 5 * i + 5; j++)
                {
                    strFlower = strFlower + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[j]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[j]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[j]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[j]["Xhjg"] + "<BR><BR></td>";
                }
                strFlowerList = strFlowerList + strFlower + "</tr>";
            }
            //补足显示剩余的2个鲜花
            strFlowerList = strFlowerList + "<tr>";
            string strFlower1 = "";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 2]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhjg"] + "</td>";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 1]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhjg"] + "</td>";
            strFlowerList = strFlowerList + strFlower1 + "</tr>";

        }
        else if (tmpda.Rows.Count % 5 == 3)
        {
            //当鲜花取余5等于3  用循环显示总记录数－3的鲜花数
            for (int i = 0; i < (tmpda.Rows.Count - 3) / 5; i++)
            {
                //利用变量拼Html字符串  将鲜花信息拼接显示
                strFlowerList = strFlowerList + "<tr>";
                string strFlower = "";
                for (int j = 5 * i; j < 5 * i + 5; j++)
                {
                    strFlower = strFlower + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[j]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[j]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[j]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[j]["Xhjg"] + "<BR><BR></td>";
                }
                strFlowerList = strFlowerList + strFlower + "</tr>";
            }
            //补足显示剩余的3个鲜花
            strFlowerList = strFlowerList + "<tr>";
            string strFlower1 = "";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 3]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 3]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 3]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 3]["Xhjg"] + "</td>";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 2]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhjg"] + "</td>";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 1]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhjg"] + "</td>";

            strFlowerList = strFlowerList + strFlower1 + "</tr>";

        }
        else if (tmpda.Rows.Count % 5 == 4)
        {
            //当鲜花取余5等于4  用循环显示总记录数－4的鲜花数
            for (int i = 0; i < (tmpda.Rows.Count - 4) / 5; i++)
            {
                //利用变量拼Html字符串  将鲜花信息拼接显示
                strFlowerList = strFlowerList + "<tr>";
                string strFlower = "";
                for (int j = 5 * i; j < 5 * i + 5; j++)
                {
                    strFlower = strFlower + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[j]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[j]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[j]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[j]["Xhjg"] + "<BR><BR></td>";
                }
                strFlowerList = strFlowerList + strFlower + "</tr>";
            }
            //补足显示剩余的4个鲜花
            strFlowerList = strFlowerList + "<tr>";
            string strFlower1 = "";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 4]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 4]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 4]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 4]["Xhjg"] + "</td>";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 3]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 3]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 3]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 3]["Xhjg"] + "</td>";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 2]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 2]["Xhjg"] + "</td>";
            strFlower1 = strFlower1 + "<td class='smallText' oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='center' width='20%' ><a href=FlowerSee.aspx?Xhbh=" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhbh"].ToString() + " target='_blank'><img src=" + Dpath + tmpda.Rows[tmpda.Rows.Count - 1]["Tpwjm"] + " height=100 width=80></a><br><br>名称：" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhmc"].ToString() + "<BR>价格：￥" + tmpda.Rows[tmpda.Rows.Count - 1]["Xhjg"] + "</td>";

            strFlowerList = strFlowerList + strFlower1 + "</tr>";

        }
        return strFlowerList;
    }

}