Imports Clases

Public Class Abrir
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

  Private Sub PageOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Introducir aquí el código de usuario para inicializar la página
  End Sub

  Public Sub diagramacion()
    Dim hay As Boolean
    Dim id As Integer
    Dim datos = New Datos
    Dim rs As RecordSet
    rs = datos.abrir(Session("Auditor"))
    While Not rs.EOF
      hay = True
      Response.Write("<tr>")
      Response.Write("<td align='right' height='40'>&nbsp;")

      '<!-- fecha -->'
      Response.Write("<label>" & rs.item("fecha") & "</label>")

      Response.Write("<hr>")
      Response.Write("</td>")
      Response.Write("<td height='40'>")
      Response.Write("&nbsp; <a href='Pagina.aspx?id=" & rs.item("id") & "'>")

      '<!-- título -->'
      Response.Write(rs.item("titulo"))

      Response.Write("</a>")
      Response.Write("<hr>")
      Response.Write("</td>")
      Response.Write("</tr>")
      rs.moveNext()
    End While
    If hay = False Then
      Response.Write("No hay Auditorias disponibles para ti")
      Response.Write("<br><br><br><br>")
    End If
  End Sub

  Private Sub lAuditoriaOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Response.Write("<script language='VBScript' type='text/VBScript'>")
    Response.Write("<!--")
    Response.Write("VBScript: call close()")
    Response.Write("-->")
    Response.Write("</script>")
  End Sub

End Class
