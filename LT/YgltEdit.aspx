<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YgltEdit.aspx.cs" Inherits="YGLT_YgltEdit" %>

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
				<TABLE id="Table1" style="BORDER-RIGHT: #7f7f7f 2px dotted; BORDER-TOP: #7f7f7f 2px dotted; Z-INDEX: 101; LEFT: 8px; BORDER-LEFT: #7f7f7f 2px dotted; BORDER-BOTTOM: #7f7f7f 2px dotted; POSITION: absolute; TOP: 8px"
					cellSpacing="3" cellPadding="8" width="728" align="center">
					<TBODY>
						<TR>
						</TR>
						<TR>
							<TD class="smallText" colSpan="3" id="TZtbt" align="center" runat="server"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" id="Tyhm" align="left" colSpan="3" runat="server"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" id="Tztnr" align="left" colSpan="3" runat="server"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" id="Tfbsj" align="left" colSpan="3" runat="server"><FONT face="宋体"></FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" style="HEIGHT: 18px" vAlign="middle" align="center" colSpan="3"><FONT face="宋体">回复内容</FONT></TD>
						</TR>
						<TR>
							<TD class="smallText" style="HEIGHT: 18px" vAlign="middle" align="left" colSpan="3"><FONT face="宋体">
									<TABLE id="Table2" style="WIDTH: 696px; HEIGHT: 43px" height="43" cellSpacing="1" cellPadding="1"
										width="696" border="1">
										<% =strHfList%>
									</TABLE>
								</FONT>
							</TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" colSpan="3"><FONT face="宋体">
									<asp:LinkButton id="LinkButton1" runat="server" ForeColor="Highlight" onclick="LinkButton1_Click">【发表回复】</asp:LinkButton>
									<asp:LinkButton id="LinkButton2" runat="server" ForeColor="Highlight" onclick="LinkButton2_Click">【返回】</asp:LinkButton></FONT></TD>
						</TR>
						<TR>
						</TR>
					</TBODY>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
