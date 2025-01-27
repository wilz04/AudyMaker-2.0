Imports System.Web
Imports System.Web.SessionState

Public Class Global
    Inherits System.Web.HttpApplication

#Region " C�digo generado por el Dise�ador de componentes "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

    End Sub

    'Requerido por el Dise�ador de componentes
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de componentes requiere el siguiente procedimiento
    'Se puede modificar utilizando el Dise�ador de componentes.
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se inicia la aplicaci�n
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se inicia la sesi�n
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al principio de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando ocurre un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando termina la sesi�n
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando termina la aplicaci�n
    End Sub

End Class
