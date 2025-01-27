Imports Clases

Public Class AudyMaker
  Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

  'El Dise�ador de Web Forms requiere esta llamada.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub
  Protected WithEvents bNuevo As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents tReporte As System.Web.UI.HtmlControls.HtmlTextArea
  Protected WithEvents bGuardar As System.Web.UI.HtmlControls.HtmlInputButton
  Protected WithEvents arg As System.Web.UI.HtmlControls.HtmlInputHidden
  Protected WithEvents bActualizar As System.Web.UI.HtmlControls.HtmlInputButton

  'NOTA: el Dise�ador de Web Forms necesita la siguiente declaraci�n del marcador de posici�n.
  'No se debe eliminar o mover.
  Private designerPlaceholderDeclaration As System.Object

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: el Dise�ador de Web Forms requiere esta llamada de m�todo
    'No la modifique con el editor de c�digo.
    InitializeComponent()
  End Sub

#End Region

  Private Sub AudyMakerLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Introducir aqu� el c�digo de usuario para inicializar la p�gina
  End Sub

  Private Sub bNuevoOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.ServerClick
    tReporte.Value = ""
  End Sub

  Private Sub bGuardarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.ServerClick
    Dim datos As New Datos
    Dim guardado As Boolean
    guardado = datos.guardar(Session("Auditor"), Session("Titulo"), Session("Fecha"), tReporte.Value)
    If guardado Then
      Response.Write("Tu auditoria ha sido guardada")
    Else
      Response.Write("Ubo errores al guardar tu auditoria")
    End If
  End Sub

  Private Sub bActualizarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bActualizar.ServerClick
    If Session("Texto") <> "" Then
      tReporte.Value = Session("Texto")
    Else
      If Session("Titulo") <> "" Then
        tReporte.Value = "Auditoria: " + Session("Titulo") + "," + Chr(10) + Chr(10)
      Else
        tReporte.Value = "Auditoria: sin t�tulo" + "," + Chr(10) + Chr(10)
      End If
      If Session("Auditor") <> "" Then
        tReporte.Value += "Nombre del Auditor: " + Session("Auditor") + "," + Chr(10) + Chr(10)
      End If
      If Session("Numero") <> "" Then
        tReporte.Value += "N�mero de oficio: " + Session("Numero") + "," + Chr(10) + Chr(10)
      End If
      If Session("Fecha") <> "" Then
        tReporte.Value += "Fecha: " + Session("Fecha") + "," + Chr(10) + Chr(10)
      Else
        tReporte.Value += "Fecha: " + Now() + "," + Chr(10) + Chr(10)
      End If
      If Session("a") <> "" Then
        tReporte.Value += "Dirigida a: " + Session("a") + "," + Chr(10) + Chr(10)
      End If
      If Session("departamento") <> "" Then
        tReporte.Value += "Realizada al departamento de: " + Session("departamento") + "," + Chr(10) + Chr(10)
      End If
      If Session("solucion") <> "" Then
        tReporte.Value += Session("solucion") + ","
      End If
    End If
  End Sub

End Class
