Imports Clases

Public Class Pagina
  Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

  'El Dise�ador de Web Forms requiere esta llamada.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub

  'NOTA: el Dise�ador de Web Forms necesita la siguiente declaraci�n del marcador de posici�n.
  'No se debe eliminar o mover.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: el Dise�ador de Web Forms requiere esta llamada de m�todo
    'No la modifique con el editor de c�digo.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Introducir aqu� el c�digo de usuario para inicializar la p�gina
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
