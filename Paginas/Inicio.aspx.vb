Imports Clases

Public Class Inicio
  Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

  'El Diseñador de Web Forms requiere esta llamada.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tLogin As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents bCuenta As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents sEnviar As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents tPassword As System.Web.UI.HtmlControls.HtmlInputText

  'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
  'No se debe eliminar o mover.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
    'No la modifique con el editor de código.
    InitializeComponent()
  End Sub

#End Region

  Private Sub PageOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Introducir aquí el código de usuario para inicializar la página
  End Sub

  Private Sub sEnviarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sEnviar.ServerClick
    Dim datos As New Datos
    Dim entrar As Boolean
    entrar = datos.entrar(tLogin.Value, tPassword.Value)
    If entrar Then
      Session("Auditor") = tLogin.Value
      Response.Redirect("AudyMaker.aspx")
    Else
      Response.Write("Usuario inexistente!")
    End If
  End Sub

  Private Sub bCuentaOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCuenta.ServerClick
    Response.Redirect("Nuevo.aspx")
  End Sub

End Class
