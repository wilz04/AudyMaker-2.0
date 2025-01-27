Public Class Nodo

  Private fecha As String
  Private titulo As String
  Private texto As String
  Private id As Integer

  Public siguiente As Nodo

  Public Sub New(ByVal fecha As String, ByVal titulo As String, ByVal texto As String, ByVal id As Integer)
    Me.fecha = fecha
    Me.titulo = titulo
    Me.texto = texto
    Me.id = id

    siguiente = Nothing
  End Sub

  Public Property _fecha() As String
    Get
      Return fecha
    End Get
    Set(ByVal Value As String)
      fecha = Value
    End Set
  End Property

  Public Property _titulo() As String
    Get
      Return titulo
    End Get
    Set(ByVal Value As String)
      titulo = Value
    End Set
  End Property

  Public Property _texto() As String
    Get
      Return texto
    End Get
    Set(ByVal Value As String)
      texto = Value
    End Set
  End Property

  Public Property _id() As Integer
    Get
      Return id
    End Get
    Set(ByVal Value As Integer)
      id = Value
    End Set
  End Property

End Class
