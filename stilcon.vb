Imports System.IO

Public Class stilcon

    Private Sub st_apri_Click(sender As Object, e As EventArgs) Handles st_apri.Click
        'st_apri.Click
        If ofd.ShowDialog = DialogResult.OK Then
            'true
            Dim getinfo As Image

            sfd.FileName = Path.GetFileName(ofd.FileName) & "_stilicon"
            st_gb_ai_icon.Image = Icon.ExtractAssociatedIcon(ofd.FileName).ToBitmap
            getinfo = st_gb_ai_icon.Image

            st_gb_ii_name_label.Text = "Nome origine icona: " & Split(ofd.FileName, "\").First & "\...\" & Path.GetFileName(ofd.FileName)
            st_gb_ii_size_label.Text = "Dimensioni icona: " & getinfo.Width & "px; " & getinfo.Height & "px"
            st_gb_ii_resolution_label.Text = "Risoluzione icona: " & getinfo.HorizontalResolution & "; " & getinfo.VerticalResolution
            st_gb_ii_type_label.Text = "Formato icona: " & getinfo.RawFormat.Guid.ToString
            st_gb_ii_truesize_label.Text = "Dimensioni fisiche: " & getinfo.PhysicalDimension.Width & "px; " & getinfo.PhysicalDimension.Height & "px"
            st_gb_ii_px_label.Text = "Formato pixel: " & getinfo.PixelFormat
            st_gb_ii_palette_label.Text = "Palette: " & getinfo.Palette.Flags
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
