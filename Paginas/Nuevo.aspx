<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Nuevo.aspx.vb" Inherits="AudyMaker.Nuevo"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
  <head>
    <title>Nueva Cuenta
		</title>
    <link href="Styles.css" rel=stylesheet>
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name="vs_defaultClientScript" content="VBScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
  </head>
  <body background="BackGround.gif">
    <form id="form" method="post" runat="server">
			<center>
				<span class="title">
					Bienvenido a AudyMaker!
					<br>
				</span>
				<span class="text">
					Datos Personales
				</span>
				<br>
				<br>
				<table class="iFrame" bgColor="#638dbb" width="300">
					<tr>
					</tr>
					<tr>
						<td align="right" height="30">
							<label>
								ID: &nbsp;
							</label>
						</td>
						<td height="30">
							&nbsp; <input name="tLogin" type="text" size="30" class=tLogin id=tLogin runat="server">
						</td>
					</tr>
					<tr>
						<td align="right" height="30">
							<label>
								Password: &nbsp;
							</label>
						</td>
						<td height="30">
							&nbsp; <input name="tPassword" type="password" size="30" id=tPassword runat="server">
						</td>
					</tr>
					<tr>
						<td align="right" height="30">
							<label>
								Nombre: &nbsp;
							</label>
						</td>
						<td height="30">
							&nbsp; <input name="tNombre" type="text" size="30" id=tNombre runat="server">
						</td>
					</tr>
					<tr>
						<td align="right" height="30">
							<label>
								cedula: &nbsp;
							</label>
						</td>
						<td height="30">
							&nbsp; <input name="tCedula" type="text" size="30" id=tCedula runat="server">
						</td>
					</tr>
					<tr>
						<td align="right" height="30">
							<label>
								sexo: &nbsp;
							</label>
						</td>
						<td height="30">
							&nbsp;
							<select name="sSexo" id=sSexo runat="server">
							  <option value="1" selected>
									masculino
							  </option>
							  <option value="0">
									femenino
							  </option>
						  </select>
						</td>
					</tr>
					<tr>
						<td align="right" height="30">
							<label>
								dirección: &nbsp;
							</label>
						</td>
						<td height="30">
							&nbsp; <input name="tDireccion" type="text" size="30" id=tDireccion runat="server">
						</td>
					</tr>
					<tr>
					</tr>
				</table>
				<br>
				<input type="submit" name="sEnviar" value="Enviar" id="sEnviar" runat="server">
			</center>
    </form>
  </body>
</html>
