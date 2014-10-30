<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YgltList.aspx.cs" Inherits="YGLT_YgltList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<HTML>
	<HEAD>
		<title></title>
    <LINK href="../CSS/Style.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<P> 
			<FONT face="宋体">
				<FORM id="Form1" method="post" runat="server">
					<br>
					<TABLE id="Table1" cellSpacing="0" cellPadding="3" align="center" border="1" style="Z-INDEX: 101; LEFT: 0px; WIDTH: 737px; POSITION: absolute; TOP: 0px;">
						<TR>
							<TD style="HEIGHT: 17px" align="left" colSpan="7" runat="server" id="TErr" background="image/title.jpg"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD colSpan="7" align="center" style="HEIGHT: 37px"><FONT face="宋体" style="FONT-SIZE: medium" color="dimgray">欢迎使用友爱鲜花论坛</FONT></TD>
						</TR>
						<TR>
							<TD colSpan="7" style="HEIGHT: 17px" align="right"><FONT face="宋体">
                                <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Highlight" OnClick="LinkButton1_Click">【返回】</asp:LinkButton>&nbsp;
									<asp:LinkButton id="LinkButton2" runat="server" ForeColor="Highlight" onclick="LinkButton2_Click">【新主题】</asp:LinkButton>
									</FONT></TD>
						</TR>
						<TR align="center">
							<TD colSpan="7"><FONT face="宋体">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="主题编号"
                                    OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                                    <Columns>
                                        <asp:BoundField DataField="主题编号" HeaderText="主题编号" Visible="False" />
                                        <asp:BoundField DataField="主题标题" HeaderText="主题标题" />
                                        <asp:BoundField DataField="会员帐号" HeaderText="会员帐号">
                                            <ItemStyle Width="80px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="发布时间" HeaderText="发布时间">
                                            <ItemStyle Width="80px" />
                                        </asp:BoundField>
                                        <asp:ButtonField CommandName="See" HeaderText="操作" Text="查看">
                                            <ControlStyle Width="30px" />
                                            <ItemStyle Width="36px" />
                                        </asp:ButtonField>
                                        <asp:ButtonField CommandName="Del" HeaderText="操作" Text="删除">
                                            <ControlStyle Width="30px" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="36px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <EditRowStyle BackColor="#999999" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                </asp:GridView>
                            </FONT></TD>
						</TR>
						</TABLE>
				</FORM>
			</FONT>
		</P>
	</body>
</HTML>
