Public Class RecordSet

  Public top As Nodo

  Public Sub New()
    top = Nothing
  End Sub

  Public Sub insertar(ByVal fecha As String, ByVal titulo As String, ByVal texto As String, ByVal id As Integer)
    Dim n = New Nodo(fecha, titulo, texto, id)
    If top Is Nothing Then
      top = n
    Else
      Dim temp = top
      While Not temp.siguiente Is Nothing
        temp = temp.siguiente
      End While
      temp.siguiente = n
    End If
  End Sub

  Public Function item(ByVal s As String) As String
    Select Case s
      Case "fecha"
        Return top._fecha
      Case "titulo"
        Return top._titulo
      Case "texto"
        Return top._texto
      Case "id"
        Return top._id
    End Select
  End Function

  Public Sub moveNext()
    top = top.siguiente
  End Sub

  Public Function EOF() As Boolean
    If Not top Is Nothing Then
      Return False
    Else
      Return True
    End If
  End Function

  Public Sub vaciar()
    top = Nothing
  End Sub

End Class
