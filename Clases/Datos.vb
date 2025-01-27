Imports System.Data.OleDb

Public Class Datos

  Private cx As OleDbConnection
  Private instruccion As String
  Private comando As New OleDbCommand

  Public Sub New()
    cx = New OleDbConnection("Provider = SQLOLEDB.1; Password = ; Persist Security Info = True; User ID = sa; Initial Catalog = AudyBase; Data Source = localhost")
  End Sub

  Public Function entrar(ByVal login As String, ByVal password As String) As Boolean
    Try
      cx.Open()
      instruccion = "select Login, Password from Usuarios where Login = '" & login & "' and Password = '" & password & "'"
      comando = New OleDbCommand(instruccion, cx)
      Dim setDeDatos As OleDbDataReader
      setDeDatos = comando.ExecuteReader()
      If setDeDatos.Read Then
        Return True
      Else
        Return False
      End If
      cx.Close()
    Catch e As Exception
      Return False
      cx.Close()
    End Try
  End Function

  Public Function insertarUsuario(ByVal login As String, ByVal password As String, ByVal nombre As String, ByVal cedula As String, ByVal sexo As String, ByVal direccion As String) As Boolean
    Try
      cx.Open()
      instruccion = "insert into Usuarios values('" & login & "', '" & password & "', '" & nombre & "', '" & cedula & "', '" & sexo & "', '" & direccion & "')"
      comando = New OleDbCommand(instruccion, cx)
      comando.ExecuteNonQuery()
      Return True
      cx.Close()
    Catch e As Exception
      Return False
      cx.Close()
    End Try
  End Function

  Public Function abrir(ByVal emisor As String) As RecordSet
    Dim rs = New RecordSet
    Try
      cx.Open()
      instruccion = "select Fecha, Titulo, Texto, Id from Auditorias where Emisor = '" & emisor & "'"
      comando = New OleDbCommand(instruccion, cx)
      Dim setDeDatos As OleDbDataReader
      setDeDatos = comando.ExecuteReader()
      While setDeDatos.Read()
        rs.insertar(setDeDatos.Item("Fecha"), setDeDatos.Item("Titulo"), setDeDatos.Item("Texto"), setDeDatos.Item("Id"))
      End While
      Return rs
      cx.Close()
    Catch e As Exception
      Return Nothing
      cx.Close()
    End Try
  End Function

  Public Function cargar(ByVal id As Integer) As String
    Try
      cx.Open()
      instruccion = "select Texto from Auditorias where Id = '" & id & "'"
      comando = New OleDbCommand(instruccion, cx)
      Dim setDeDatos As OleDbDataReader
      setDeDatos = comando.ExecuteReader()
      If setDeDatos.Read() Then
        Return setDeDatos.Item("Texto")
      Else
        Return Nothing
      End If
      cx.Close()
    Catch e As Exception
      Return Nothing
      cx.Close()
    End Try
  End Function

  Public Function guardar(ByVal emisor As String, ByVal titulo As String, ByVal fecha As String, ByVal texto As String) As Boolean
    Try
      cx.Open()
      'Eliminacion de datos anteriormente guardados'
      instruccion = "delete From Auditorias Where Emisor = '" & "wil" & "' and Titulo = '" & "algo" & "'"
      comando = New OleDbCommand(instruccion, cx)
      comando.ExecuteNonQuery()
      'Almacenamiento de nuevos datos'
      instruccion = "insert into Auditorias values('" & emisor & "', '" & fecha & "', '" & titulo & "', '" & texto & "')"
      comando = New OleDbCommand(instruccion, cx)
      comando.ExecuteNonQuery()
      Return True
      cx.Close()
    Catch e As Exception
      Return False
      cx.Close()
    End Try
  End Function

End Class
