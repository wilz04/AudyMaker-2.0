Public Class Soluciones
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents form As System.Web.UI.HtmlControls.HtmlForm
  Protected WithEvents cb_1 As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents cb_2 As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents cb_3 As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents taSoluciones As System.Web.UI.HtmlControls.HtmlTextArea
  Protected WithEvents taComentario As System.Web.UI.HtmlControls.HtmlTextArea
  Protected WithEvents sEnviar As System.Web.UI.HtmlControls.HtmlInputButton

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
    Session("solucion") = taSoluciones.Value + Chr(10) + Chr(10) + taComentario.Value
  End Sub

End Class
