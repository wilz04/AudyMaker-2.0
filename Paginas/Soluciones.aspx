<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Soluciones.aspx.vb" Inherits="AudyMaker.Soluciones"%>
<!doctype html public "-//w3c//dtd html 4.0 transitional//en">
<html>
  <head>
    <title>Soluciones</title>
    <link href="Styles.css" rel="stylesheet">
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
    <meta name=vs_defaultClientScript content="VBScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </head>
  <body background="BackGround.gif">
		<center>
			<form id="form" method="POST" runat="server">
				<fieldset>
					<legend>
						Anomalias
					</legend>
					<br>
					<table cellspacing="2" cellpadding="2" border="2" width="300">
						<tr>
							<td>
								<input type="checkbox" id="cb_1" name=cb_1 runat="server">
								<label>
									Mala administración
								</label>
							</td>
						</tr>
						<tr>
							<td>
								<input type="checkbox" id="cb_2" name=cb_2 runat="server">
								<label>
									Indiciplina
								</label>
							</td>
						</tr>
						<tr>
							<td>
								<input type="checkbox" id="cb_3" name=cb_3 runat="server">
								<label>
									Ocultamiento de informacíon
								</label>
							</td>
						</tr>
					</table>
					<br>
				</fieldset>
				<br>
				<fieldset>
					<legend>
						Solución
					</legend>
					<br>
					<textarea rows="15" cols="60" id=taSoluciones name=taSoluciones runat="server"></textarea>
					<br><br>
					<label>
						Comentario:
					</label>
					<br>
					<textarea rows="5" cols="60" id=taComentario name=taComentario runat="server"></textarea>
					<br><br><br>
				</fieldset>
				<br><br>
				<input type="submit" value="Enviar" onclick="VBScript: call close()" id=sEnviar name=sEnviar runat="server">
			</form>
    </center>
  </body>
</html>
