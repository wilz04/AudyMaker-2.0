Public Class Soluciones
    Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

    'El Dise�ador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents form As System.Web.UI.HtmlControls.HtmlForm
  Protected WithEvents cb_1 As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents cb_2 As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents cb_3 As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents taSoluciones As System.Web.UI.HtmlControls.HtmlTextArea
  Protected WithEvents taComentario As System.Web.UI.HtmlControls.HtmlTextArea
  Protected WithEvents sEnviar As System.Web.UI.HtmlControls.HtmlInputButton

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
    Session("solucion") = taSoluciones.Value + Chr(10) + Chr(10) + taComentario.Value
  End Sub

End Class
