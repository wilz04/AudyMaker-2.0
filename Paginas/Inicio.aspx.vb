Imports Clases

Public Class Inicio
  Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

  'El Dise�ador de Web Forms requiere esta llamada.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents tLogin As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents bCuenta As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents sEnviar As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents tPassword As System.Web.UI.HtmlControls.HtmlInputText

  'NOTA: el Dise�ador de Web Forms necesita la siguiente declaraci�n del marcador de posici�n.
  'No se debe eliminar o mover.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: el Dise�ador de Web Forms requiere esta llamada de m�todo
    'No la modifique con el editor de c�digo.
    InitializeComponent()
  End Sub

#End Region

  Private Sub PageOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Introducir aqu� el c�digo de usuario para inicializar la p�gina
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
