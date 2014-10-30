<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlowDDSee.aspx.cs" Inherits="FlowDDSee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<HTML  xmlns="http://www.w3.org/1999/xhtml">
	<head id="Head1" runat="server">
		<LINK href="CSS/Style.css" type="text/css" rel="stylesheet"/>
		<base target="_self">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" style="border-collapse:collapse;border:1px solid #C4E2FF;background:#E8FBFF; width: 516px;"
					cellSpacing="0" cellPadding="0" align="center">
					<TBODY> 
						<TR>
							<TD  id="TErr" align="center" colSpan="4" runat="server"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD  align="center" colSpan="4" style="height: 54px">查看用户订单</TD>
						</TR>
						<TR>
							<TD  align="center" style="width: 83px; height: 40px">订单编号：</TD>
							<TD style="width: 187px; height: 40px" ><FONT face="宋体">
									<asp:TextBox id="TextBox1" runat="server" Width="157px" Enabled="False"></asp:TextBox></FONT></TD>
							<TD  align="center" style="width: 96px; height: 40px">用户名：</TD>
							<TD style="height: 40px" ><FONT face="宋体">
									<asp:TextBox id="TextBox2" runat="server" Width="158px" Enabled="False"></asp:TextBox></FONT></TD>
						</TR>
						<TR>
							<TD  align="center" style="width: 83px; height: 36px">总数量：</TD>
							<TD style="width: 187px; height: 36px" ><FONT face="宋体">
									<asp:TextBox id="TextBox3" runat="server" Width="157px" Enabled="False"></asp:TextBox></FONT></TD>
							<TD  align="center" style="width: 96px; height: 36px">总金额：</TD>
							<TD  vAlign="middle" style="height: 36px">
								<asp:TextBox id="TextBox4" runat="server" Width="157px" Enabled="False"></asp:TextBox></TD>
						</TR>
						<TR>
							<TD  align="center" style="width: 83px; height: 31px">交款方式：</TD>
							<TD style="width: 187px; height: 31px" ><FONT face="宋体">
									<asp:DropDownList id="DropDownList1" runat="server" Width="159px" AutoPostBack="True" Enabled="False">
										<asp:ListItem Value="当面交款">当面交款</asp:ListItem>
										<asp:ListItem Value="付款帐号">付款帐号</asp:ListItem>
									</asp:DropDownList></FONT></TD>
							<TD  align="center" style="width: 96px; height: 31px">付款帐号：</TD>
							<TD style="height: 31px" ><FONT face="宋体">
									<asp:TextBox id="TextBox5" runat="server" Width="157px" Enabled="False"></asp:TextBox></FONT></TD>
						</TR>
						<TR>
							<TD  align="center" style="width: 83px"><FONT face="宋体">订单日期：</FONT></TD>
							<TD style="width: 187px" >
								<asp:TextBox id="TextBox6" runat="server" Width="157px" Enabled="False"></asp:TextBox></TD>
							<TD  align="center" style="width: 96px"></TD>
							<TD ></TD>
						</TR>
						<TR>
							<TD  align="center" colSpan="4" style="height: 115px"><FONT face="宋体">
									</FONT>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                    DataKeyNames="Ddbh" ForeColor="#333333" GridLines="None" 
                                    Width="99%">
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="Xhbh" HeaderText="鲜花编号" Visible="False" />
                                        <asp:BoundField DataField="Xhmc" HeaderText="鲜花名称" />
                                        <asp:BoundField DataField="Sjrq" HeaderText="上架日期" />
                                        <asp:BoundField DataField="Xhjg" HeaderText="鲜花价格" />
                                        <asp:BoundField DataField="Sl" HeaderText="购买数量" />
                                        <asp:BoundField DataField="Je" HeaderText="购买金额" />
                                    </Columns>
                                    <RowStyle BackColor="#EFF3FB" />
                                    <EditRowStyle BackColor="#2461BF" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <AlternatingRowStyle BackColor="White" />
                                </asp:GridView>
                            </TD>
						</TR>
						<TR>
							<TD  align="center" colSpan="4" style="height: 43px">
			</FONT>
            <asp:Button ID="Button1" runat="server" CssClass="button" 
                Text="同意预定" />
            <asp:Button ID="Button2" runat="server" CssClass="button"
                Text="返回" />
		</form>
	</body>
</HTML>
