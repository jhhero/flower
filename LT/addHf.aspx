<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addHf.aspx.cs" Inherits="YGLT_addHf" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<HTML>
	<HEAD>
		<title></title>
    <LINK href="../CSS/Style.css" type="text/css" rel="stylesheet">
		<base target="_self"> 
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" style="BORDER-RIGHT: #7f7f7f 2px dotted; BORDER-TOP: #7f7f7f 2px dotted; Z-INDEX: 101; LEFT: 8px; BORDER-LEFT: #7f7f7f 2px dotted; WIDTH: 728px; BORDER-BOTTOM: #7f7f7f 2px dotted; POSITION: absolute; TOP: 8px"
					cellSpacing="3" cellPadding="8" width="728" align="center">
					<TBODY>
						<TR>
							<TD class="smallText" id="TErr" align="left" colSpan="4" runat="server" style="HEIGHT: 17px"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" colSpan="4" style="HEIGHT: 2px"><FONT face="宋体"><FONT face="宋体"><FONT style="FONT-SIZE: medium" face="宋体" color="dimgray">回复内容</FONT></FONT></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="HEIGHT: 25px">
                                会员帐号：</TD>
							<TD class="smallText" colSpan="3" style="HEIGHT: 25px" id="TUserName" runat="server"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="HEIGHT: 66px">
								回复内容：</TD>
							<TD class="smallText" colSpan="3" style="HEIGHT: 66px"><asp:textbox id="Textbox3" runat="server" Width="598px" DESIGNTIMEDRAGDROP="98" Height="72px"
									TextMode="MultiLine"></asp:textbox></TD>
						</TR>
						<TR>
							<TD class="smallText" style="HEIGHT: 1px" align="center">
                                回复时间：</TD>
							<TD class="smallText" style="HEIGHT: 1px" vAlign="middle" colSpan="3" id="Tdate" runat="server">
								<FONT face="宋体"></FONT>
							</TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" colSpan="34" style="height: 34px"><FONT face="宋体"><asp:linkbutton id="LinkButton2" runat="server" ForeColor="Highlight" onclick="LinkButton2_Click">【回复】</asp:linkbutton></FONT><asp:linkbutton id="LinkButton1" runat="server" ForeColor="Highlight" onclick="LinkButton1_Click">【关闭】</asp:linkbutton>
			</FONT></form>
	</body>
</HTML>
