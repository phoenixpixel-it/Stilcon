Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            'Me.StartupNextInstance
            e.BringToForeground = True
            Dim neww As New stilcon
            neww.Show()
        End Sub

    End Class

End Namespace
