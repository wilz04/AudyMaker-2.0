Imports Clases

Public Class Pagina
  Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

  'El Diseñador de Web Forms requiere esta llamada.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub

  'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
  'No se debe eliminar o mover.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
    'No la modifique con el editor de código.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Introducir aquí el código de usuario para inicializar la página
    Dim datos As New Datos
    Dim texto As String
    Dim i As Integer
    texto = datos.cargar(Request.QueryString("id"))
    For i = 0 To texto.Length - 1
      Response.Write(texto.Chars(i))
      If texto.Chars(i) = "," Then
        Response.Write("<br><br>")
      End If
    Next
  End Sub

End Class
