Public Class stilconl

    Private Sub stilconl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MyBase.Load
        Me.Text = My.Application.Info.AssemblyName
        version.Text = "Versione: " & My.Application.Info.Version.ToString
    End Sub

End Class