Public Class Especificaciones
  Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

    'El Dise�ador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents form As System.Web.UI.HtmlControls.HtmlForm
  Protected WithEvents sDepartamento As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents sEnviar As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents cbPresidente As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents cbVice As System.Web.UI.HtmlControls.HtmlInputCheckBox
  Protected WithEvents cbAdministrador As System.Web.UI.HtmlControls.HtmlInputCheckBox

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
  End Sub

  Private Sub sEnviarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sEnviar.ServerClick
    If cbPresidente.Checked Then
      Session("a") = "Presidente, "
    End If
    If cbVice.Checked Then
      Session("a") += "Vicepresidente, "
    End If
    If cbAdministrador.Checked Then
      Session("a") += "Administrador"
    End If

    If sDepartamento.Value = 0 Then
      Session("departamento") = "Gerencia"
    ElseIf sDepartamento.Value = 1 Then
      Session("departamento") = "Soporte t�cnico"
    ElseIf sDepartamento.Value = 2 Then
      Session("departamento") = "Recursos humanos"
    ElseIf sDepartamento.Value = 3 Then
      Session("departamento") = "Relaciones publicas"
    ElseIf sDepartamento.Value = 4 Then
      Session("departamento") = "Administrativo"
    End If
  End Sub
End Class
