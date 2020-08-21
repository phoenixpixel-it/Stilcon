Imports System.IO

Public Class stilcon

    Private Sub st_apri_Click(sender As Object, e As EventArgs) Handles st_apri.Click
        'st_apri.Click
        If ofd.ShowDialog = DialogResult.OK Then
            'true
            Dim getzise As Image
            sfd.FileName = Path.GetFileName(ofd.FileName) & "_stilicon"
            st_gb_ai_icon.Image = Icon.ExtractAssociatedIcon(ofd.FileName).ToBitmap
            getzise = st_gb_ai_icon.Image
            st_gb_ii_name.Text = "Nome origine icona: " & ofd.FileName
            st_gb_ii_size.Text = "Dimensioni icona: " & getzise.Width & "x" & getzise.Height
            st_gb_ii_type.Text = "Tipo icona: Bitmap"
            st_gb_ruba.Enabled = True
        End If
    End Sub

    Private Sub st_gb_ruba_Click(sender As Object, e As EventArgs) Handles st_gb_ruba.Click
        'st_gb_ruba.Click
        If sfd.ShowDialog = DialogResult.OK Then
            'true
            st_gb_ai_icon.Image.Save(sfd.FileName)
            Process.Start(Path.GetDirectoryName(sfd.FileName))
        End If
    End Sub

End Class
