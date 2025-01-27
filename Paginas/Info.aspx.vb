Public Class Info
  Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

    'El Dise�ador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents form As System.Web.UI.HtmlControls.HtmlForm
  Protected WithEvents sEnviar As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents tAuditor As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents tNumero As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents tFecha As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents tTitulo As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents FIELDSET1 As System.Web.UI.HtmlControls.HtmlGenericControl
  Protected WithEvents rbCalidad As System.Web.UI.HtmlControls.HtmlInputRadioButton
  Protected WithEvents rbFinanciera As System.Web.UI.HtmlControls.HtmlInputRadioButton
  Protected WithEvents sTipo As System.Web.UI.HtmlControls.HtmlSelect

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
    tFecha.Value = Now()
    tAuditor.Value = Session("Auditor")
  End Sub

  Private Sub sEnviarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sEnviar.ServerClick
    Session("Titulo") = tTitulo.Value
    Session("Numero") = tNumero.Value
    Session("Fecha") = tFecha.Value
    If sTipo.Value = 0 Then
      Session("Tipo") = "Calidad"
    Else
      Session("Tipo") = "Financiera contable"
    End If

  End Sub

End Class
