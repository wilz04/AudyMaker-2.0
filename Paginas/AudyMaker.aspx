<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AudyMaker.aspx.vb" Inherits="AudyMaker.AudyMaker"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
  <head>
		<title>AudyMaker 2.0
		</title>
		<link href="Styles.css" rel=stylesheet >
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="VBScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
  </head>
	<body background="BackGround.gif">
		<form id="fMain" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" align="center" border="0">
				<tr>
					<th scope="col">
						<table class="menuBar" width="100%">
							<tr>
								<td align="center" width="100%">
									<a>
										Archivo
									</a>
								</td>
							</tr>
						</table>
						<br>
					</th>
					<th scope="col" align="left">
						<table class="menuBar" width="100%">
							<tr>
								<td align="center" width="25%">
									<a hRef="miVentanas.htm" target="MenuItems">
										Ventanas
									</a>
								</td>
								<td align="center" width="25%">
									<a hRef="miAyuda.htm" target="MenuItems">
										Ayuda
									</a>
								</td>
								<td align="center" width="25%">
								</td>
								<td align="center" width="*">
								</td>
							</tr>
						</table>
						<br>
					</th>
				</tr>
				<tr>
					<td class="iFrame" align="center" width="125" bgColor="#638dbb">
						<br>
						<input class="menuItem" id="bNuevo" type="button" value=" Nuevo" name="bNuevo" runat="server"> 
						<input class="menuItem" id="bAbrir" onclick="VBScript: window.open('Abrir.aspx')" type="button" value=" Abrir" name="bAbrir"> 
						<input class="menuItem" id="bGuardar" type="button" value=" Guardar" name="bGuardar" runat="server"> 
						<input class="menuItem" id="bSalir" onclick="VBScript: call close()" type="button" value=" Salir" name="bSalir"> 
					</td>
					<td>
						<textArea id="tReporte" name="tReporte" rows="32" cols="74" runat="server" readonly></textArea> 
					</td>
					<td width="125">
						<iframe name="MenuItems" src="miAyuda.htm" width="100%" scrolling="no" height="394">
						</iframe>
					</td>
				</tr>
			</table>
			<center>
				<br>
				<input type="button" value="Actualizar" id=bActualizar name=bActualizar runat="server">
			</center>
		</form>
	</body>
</html>
