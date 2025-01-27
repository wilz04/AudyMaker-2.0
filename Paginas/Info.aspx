<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Info.aspx.vb" Inherits="AudyMaker.Info"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
  <head>
    <title>Información básica
		</title>
		<link href="Styles.css" rel=stylesheet>
		<meta content="Visual Basic .NET 7.1" name=CODE_LANGUAGE>
		<meta content=VBScript name=vs_defaultClientScript>
		<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema>
  </head>
	<body background="BackGround.gif">
		<center>
			<form id="form" action="AudyMaker.aspx" method="POST" runat="server">
				<table cellSpacing="2" cellPadding="2" width="300" border="2">
					<tr>
						<td>
							<label>
								Título:
							</label>
						</td>
						<td>
						<input id="tTitulo" type="text" name="tTitulo" runat="server">
						</td>
					</tr>
					<tr>
						<td>
							<label>
								Auditor:
							</label>
						</td>
						<td>
						<input id="tAuditor" type="text" name="tAuditor" runat="server" readonly>
						</td>
					</tr>
					<tr>
						<td>
							<label>
								Numero de oficio: 
							</label>
						</td>
						<td>
							<input id="tNumero" type="text" name="tNumero" runat="server">
						</td>
					</tr>
					<tr>
						<td>
							<label>
								Fecha:
							</label>
						</td>
						<td>
							<input id="tFecha" type="text" runat="server">
						</td>
					</tr>
					<tr>
						<td>
							<label>
								Tipo de auditoria:
							</label>
						</td>
						<td>
							<select id=sTipo name=sTipo runat="server">
								<option value="0" selected>
									de calidad
								</option>
								<option value="1">
									financiera contable
								</option>
							</select>
						</td>
					</tr>
				</table>
				<br>
				<input id="sEnviar" onclick="VBScript: call close()" type="submit" value="Enviar" name="sEnviar" runat="server"> 
			</form>
		</center>
  </body>
</html>
