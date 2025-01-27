<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Especificaciones.aspx.vb" Inherits="AudyMaker.Especificaciones"%>
<!doctype html public "-//w3c//dtd html 4.0 transitional//en">
<html>
  <head>
    <title>Especificaciones
		</title>
		<link href="Styles.css" rel=stylesheet >
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="VBScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
  </head>
	<body background="BackGround.gif">
		<center>
			<form id="form" method="POST" runat="server">
				<fieldset>
					<legend>
						Dirigido a 
					</legend>
					<br>
					<table cellSpacing="2" cellPadding="2" width="300" border="2">
						<tr>
							<td>
								<input id="cbPresidente" type="checkbox" name="cbPresidente" runat="server"> 
								<label>
									Presidente
								</label>
							</td>
						<td>
						<label>
							Cod #01 
						</label>
					</td>
				</tr>
					<tr>
						<td>
							<input id="cbVice" type="checkbox" name="cbVice" runat="server">
							<label>
								Viceprecidente 
							</label>
						</td>
						<td>
							<label>
								Cod #02 
							</label>
						</td>
					</tr>
					<tr>
						<td>
							<input id=cbAdministrador type=checkbox name=cbAdministrador runat="server"> 
							<label>
								Administrador
							</label>
						</td>
						<td>
							<label>
								Cod #03 
							</label>
						</td>
					</tr>
				</table>
				<br>
			</fieldset>
			<br><br>
			<table cellSpacing="2" cellPadding="2" width="352" border="2">
				<tr>
					<td>
						<label>
							Departamento: 
						</label>
					</td>
					<td>
						<select id="sDepartamento" name="sTipo" runat="server">
							<option value=0 selected>
								Gerencia
							</option> 
							<option value=1>
								Soporte técnico
							</option> 
							<option value=2>
								Recursos humanos
							</option>
							<option value=3>
								Relaciones públicas
							</option>
							<option value=4>
								Administrativo
							</option>
							</select> 
						</td>
					</tr>
				</table>
				<br><br>
				<input id=sEnviar onclick="VBScript: call close()" type=submit value=Enviar name=sEnviar runat="server"> 
			</form>
		</center>
  </body>
</html>
