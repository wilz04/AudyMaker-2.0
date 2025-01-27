<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Inicio.aspx.vb" Inherits="AudyMaker.Inicio"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
  <head>
    <title>AudyMaker
    </title>
    <link href="Styles.css" rel=stylesheet>
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name="vs_defaultClientScript" content="VBScript">
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
  </head>
  <body background="BackGround.gif">
    <form id="form" method="post" runat="server">
			<center>
				<br><br><br><br><br><br>
				<fieldSet>
					<legend>
						Inicio
					</legend>	
					<br>
					<table class="iFrame" bgColor="#638dbb" width="300">
						<tr>
						</tr>
						<tr>
							<td>
								<label>
									Login:
								</label>
							</td>
							<td>
							<input id="tLogin" type="text" name="tLogin" runat="server">
							</td>
							</tr>
						<tr>
							<td>
								<label>
									Password: 
								</label>
							</td>
							<td>
								<input id="tPassword" type="password" name="tPassword" runat="server">
							</td>
						</tr>
						<tr>
						</tr>
					</table>
					<br><br>
					<input id="sEnviar" type="submit" value="Entrar" name="sEnviar" runat="server"> 
					<br><br>
				</fieldSet>
				<br><br>
				<label>
					Si aun no tienes cuenta has ckick aquí
				</label>
				<br><br>
				<input id="bCuenta" type="button" value="Nueva cuenta" name="bCuenta" runat="server"> 
			</center>
    </form>
  </body>
</html>
