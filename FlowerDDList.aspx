<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlowerDDList.aspx.cs" Inherits="FlowerDDList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <LINK href="CSS/Style.css" type="text/css" rel="stylesheet">
</head> 
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" style="border-collapse:collapse;border:1px solid #C4E2FF;background:#E8FBFF; width: 758px;">
            <tr>
                <td colspan="3" style="text-align: right; height: 23px;" align="right">
                    <asp:Button ID="Button1" runat="server" Text="返回" CssClass="button" OnClick="Button1_Click"  /></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center; height: 16px;">
                    <strong>订单列表</strong></td>
            </tr>
            <tr>
                <td colspan="3" >
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="99%" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="Ddbh" OnRowCommand="GridView1_RowCommand" >
                        <Columns>
                            <asp:BoundField DataField="Ddbh" HeaderText="订单编号" Visible="False" >
                            </asp:BoundField>
                                                        <asp:BoundField DataField="kh" HeaderText="会员名称" >
                            </asp:BoundField>
                                                        <asp:BoundField DataField="Sl" HeaderText="总数量" >
                            </asp:BoundField>
                                                        <asp:BoundField DataField="Je" HeaderText="总金额" >
                            </asp:BoundField>
                                                        <asp:BoundField DataField="Jkfs" HeaderText="交款方式" >
                                                        
                            </asp:BoundField>
                                                        <asp:BoundField DataField="Fkzh" HeaderText="付款帐号" >
                            </asp:BoundField>
                                                        <asp:BoundField DataField="Ddrq" HeaderText="订单日期" >
                            </asp:BoundField>
                                                        <asp:BoundField DataField="Qrdd" HeaderText="确认订单" >
                            </asp:BoundField>
                            <asp:ButtonField CommandName="See" HeaderText="操作" Text="查看订单" >
                                <ItemStyle Width="60px" />
                            </asp:ButtonField>
                            <asp:ButtonField CommandName="Del" HeaderText="操作" Text="删除" />
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
