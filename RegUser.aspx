<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegUser.aspx.cs" Inherits="RegUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<LINK href="css/style.css" type="text/css" rel="stylesheet">
		<base target="_self">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" style="border-collapse:collapse;border:1px solid #C4E2FF;background:#E8FBFF; "
					cellSpacing="0" cellPadding="0" align="center">
					<TBODY>
						<TR>
							<TD class="smallText" id="TErr" align="left" colSpan="4" runat="server"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" colSpan="4" style="height: 61px"><FONT face="宋体"><FONT face="宋体"><FONT style="FONT-SIZE: medium" face="宋体" color="dimgray">用户注册</FONT></FONT></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="width: 92px; height: 27px">
                                客户昵称：</TD>
							<TD class="smallText" colSpan="3" style="height: 27px"><FONT face="宋体"><asp:textbox id="TextBox1" runat="server" DESIGNTIMEDRAGDROP="98" Width="232px"></asp:textbox>(*)</FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="width: 92px; height: 30px">
                                密码：</TD>
							<TD class="smallText" colSpan="3" style="height: 30px">
								<asp:textbox id="Textbox5" runat="server" Width="232px" DESIGNTIMEDRAGDROP="98" TextMode="Password"></asp:textbox>(6位)</TD>
						</TR>
						<TR> 
							<TD class="smallText" align="center" style="width: 92px; height: 30px"><FONT face="宋体">确认密码：</FONT></TD>
							<TD class="smallText" colSpan="3" style="height: 30px"><FONT face="宋体">
									<asp:textbox id="Textbox6" runat="server" Width="232px" DESIGNTIMEDRAGDROP="98" TextMode="Password"></asp:textbox>(6位)</FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="width: 92px; height: 31px">联系地址：</TD>
							<TD class="smallText" colSpan="3" style="height: 31px"><FONT face="宋体">
									<asp:textbox id="Textbox2" runat="server" Width="232px" DESIGNTIMEDRAGDROP="98"></asp:textbox></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="width: 92px; height: 28px">
                                电话：</TD>
							<TD class="smallText" style="height: 28px"><asp:textbox id="TextBox3" runat="server" DESIGNTIMEDRAGDROP="98" Width="232px"></asp:textbox></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="width: 92px; height: 31px">
                                生日：</TD>
							<TD class="smallText" colSpan="2" style="height: 31px"><FONT face="宋体"><asp:textbox id="TextBox4" runat="server" DESIGNTIMEDRAGDROP="98" Width="236px"></asp:textbox>(yyyy-mm-dd)</FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="width: 92px; height: 26px"><FONT face="宋体">Email：</FONT></TD>
							<TD class="smallText" colSpan="2" style="height: 26px">
								<asp:textbox id="Textbox7" runat="server" Width="236px" DESIGNTIMEDRAGDROP="98"></asp:textbox></TD>
						</TR>
                        <tr>
                            <td align="center" class="smallText" style="width: 92px; height: 25px">
                                真实姓名：</td>
                            <td class="smallText" colspan="2" style="height: 25px">
                                <asp:TextBox ID="Textbox9" runat="server" DESIGNTIMEDRAGDROP="98" Width="236px"></asp:TextBox>(*)</td>
                        </tr>
						<TR>
							<TD class="smallText" align="center" style="width: 92px; height: 25px"><FONT face="宋体">付款帐号：</FONT></TD>
							<TD class="smallText" colSpan="2" style="height: 25px"><FONT face="宋体">
									<asp:textbox id="Textbox8" runat="server" Width="236px" DESIGNTIMEDRAGDROP="98"></asp:textbox>(*)</FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" colSpan="3" style="height: 46px">
			</FONT>&nbsp;<asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click"
                Text="注册" />
            <asp:Button ID="Button2" runat="server" CssClass="button" OnClick="Button2_Click"
                Text="返回" /></form>
	</body>
</HTML>