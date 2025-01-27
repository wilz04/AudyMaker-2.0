<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Abrir.aspx.vb" Inherits="AudyMaker.Abrir"%>
<!docType HTML public "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
  <head>
    <title>Abrir
		</title>
		<link href="Styles.css" rel=stylesheet >
		<meta content="Visual Basic .NET 7.1" name=CODE_LANGUAGE>
		<meta content="VBScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema">
  </head>
	<body background="BackGround.gif">
		<form id="form" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td>
						<label>
							Abrir auditoria 
						</label>
						<center>
							<br>
							<table cellSpacing="2" cellPadding="2" width="75%" border="0">
								<tr>
									<th scope="col" align="right" width="25%" height="30">
										Fecha &nbsp;
										<hr>
									</th>
									<th scope="col" align="left" height="30">&nbsp; 
										Auditoria 
										<hr>
									</th>
								</tr>
								<%
									call diagramacion() 
								%>
							</table>
							<hr width="75%" size="10">
							<br>
						</center>
					</td>
				</tr>
			</table>
			<center>
				<input type="button" value="Cancelar" id="bCancelar" name="bCancelar" onclick="VBScript: call close()">
			</center>
		</form>
  </body>
</html>
