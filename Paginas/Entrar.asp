<html>
	<head>
		<title>
			AudyMaker
		</title>
		<%
			dim login
			dim password
			login = session("Login")
			password = session("Password")
			response.write("Login: " + login)
			response.write("Password: " + password)			
			dim connect
			dim rs
		  set connect = server.createObject("ADODB.Connection")
      set rs = server.createobject("ADODB.Recordset")
			connect.open("Provider = 'Microsoft.Jet.OLEDB.4.0'; Data Source = 'C:\Inetpub\wwwroot\wilz04pages\AudyMaker\AudyBase.mdb';")
			if login <> "" and password <> "" then
				set rs = connect.execute("Select * From Usuarios Where Login = '" & login & "' And Password = '" & password & "'")
				if not rs.EOF then
					response.Write("puedes entrar")
				else
					response.Write("no puedes entrar")
					'response.redirect("AudyMaker.aspx")'
				end if
			end if
			connect.close()
    %>
	</head>
	<body>
	</body>
</html>
