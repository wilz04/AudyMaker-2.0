Imports Clases

Public Class Nuevo
  Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

  'El Diseñador de Web Forms requiere esta llamada.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents sEnviar As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents tPassword As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents tNombre As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents tCedula As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents sSexo As System.Web.UI.HtmlControls.HtmlSelect
  Protected WithEvents tLogin As System.Web.UI.HtmlControls.HtmlInputText
  Protected WithEvents tDireccion As System.Web.UI.HtmlControls.HtmlInputText

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
    Dim nuevoUsuario As Boolean
    nuevoUsuario = datos.insertarUsuario(tLogin.Value, tPassword.Value, tNombre.Value, tCedula.Value, sSexo.Value, tDireccion.Value)
    If nuevoUsuario Then
      Response.Redirect("Inicio.aspx")
    Else
      Response.Write("Ubo un error al registrar tu cuenta <br> por favor intentalo de nuevo y llena todos los espacios.")
    End If
  End Sub
End Class
