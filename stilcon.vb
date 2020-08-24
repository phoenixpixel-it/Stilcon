Imports System.IO

Public Class stilcon
    'Vars
    Public args As String()

    Private Sub stilcon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MyBase.Load
        If Environment.GetCommandLineArgs().Count > 1 Then
            'true
            Try
                'try
                args = Environment.GetCommandLineArgs()

                Dim getinfo As Image

                Me.Text = "Stilcon 1.1 - " & Chr(34) & "Rubando icone" & Chr(34) & " - " & Path.GetFileName(args(1))
                st_gb_ai_icon.Image = Icon.ExtractAssociatedIcon(args(1)).ToBitmap
                getinfo = st_gb_ai_icon.Image

                st_gb_ii_name_label.Text = "Nome origine icona: " & Split(Path.GetDirectoryName(args(1)), "\").First & "\...\" & Path.GetFileName(args(1))
                st_gb_ii_size_label.Text = "Dimensioni icona: " & getinfo.Width * getinfo.Height & "px"
                st_gb_ii_size_w_label.Text = "Lunghezza icona: " & getinfo.Width & "px"
                st_gb_ii_size_h_label.Text = "Altezza icona: " & getinfo.Height & "px"
                st_gb_ii_resolution_label.Text = "Risoluzione icona: " & getinfo.HorizontalResolution * getinfo.VerticalResolution & "px"
                st_gb_ii_resolution_w_label.Text = "Lunghezza icona: " & getinfo.HorizontalResolution & "px"
                st_gb_ii_resolution_h_label.Text = "Altezza icona: " & getinfo.VerticalResolution & "px"
                st_mn_panel_ruba.Enabled = True
                st_mn_panel_chiudi.Enabled = True
            Catch ex As Exception
                'ex
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            'false
            Try
                'try
                args = Environment.GetCommandLineArgs()

                Dim getinfo As Image

                Me.Text = "Stilcon 1.1 - " & Chr(34) & "Rubando icone" & Chr(34) & " - " & "Stilcon 1.1.exe"
                st_gb_ai_icon.Image = Icon.ExtractAssociatedIcon("Stilcon 1.1.exe").ToBitmap
                getinfo = st_gb_ai_icon.Image

                st_gb_ii_name_label.Text = "Nome origine icona: " & Split(Application.StartupPath, "\").First & "\...\" & Path.GetFileName("Stilcon 1.1.exe")
                st_gb_ii_size_label.Text = "Dimensioni icona: " & getinfo.Width * getinfo.Height & "px"
                st_gb_ii_size_w_label.Text = "Lunghezza icona: " & getinfo.Width & "px"
                st_gb_ii_size_h_label.Text = "Altezza icona: " & getinfo.Height & "px"
                st_gb_ii_resolution_label.Text = "Risoluzione icona: " & getinfo.HorizontalResolution * getinfo.VerticalResolution & "px"
                st_gb_ii_resolution_w_label.Text = "Lunghezza icona: " & getinfo.HorizontalResolution & "px"
                st_gb_ii_resolution_h_label.Text = "Altezza icona: " & getinfo.VerticalResolution & "px"
                st_mn_panel_ruba.Enabled = True
                st_mn_panel_chiudi.Enabled = True
            Catch ex As Exception
                'ex
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub st_mn_panel_apri_Click(sender As Object, e As EventArgs) Handles st_mn_panel_apri.Click
        'st_mn_panel_apri.Click
        If ofd.ShowDialog = DialogResult.OK Then
            'true
            Try
                'try
                Dim getinfo As Image

                Me.Text = "Stilcon 1.1 - " & Chr(34) & "Rubando icone" & Chr(34) & " - " & ofd.SafeFileName
                sfd.FileName = Path.GetFileName(ofd.FileName) & "_stilicon"
                st_gb_ai_icon.Image = Icon.ExtractAssociatedIcon(ofd.FileName).ToBitmap
                getinfo = st_gb_ai_icon.Image

                st_gb_ii_name_label.Text = "Nome origine icona: " & Split(ofd.FileName, "\").First & "\...\" & Path.GetFileName(ofd.FileName)
                st_gb_ii_size_label.Text = "Dimensioni icona: " & getinfo.Width * getinfo.Height & "px"
                st_gb_ii_size_w_label.Text = "Lunghezza icona: " & getinfo.Width & "px"
                st_gb_ii_size_h_label.Text = "Altezza icona: " & getinfo.Height & "px"
                st_gb_ii_resolution_label.Text = "Risoluzione icona: " & getinfo.HorizontalResolution * getinfo.VerticalResolution & "px"
                st_gb_ii_resolution_w_label.Text = "Lunghezza icona: " & getinfo.HorizontalResolution & "px"
                st_gb_ii_resolution_h_label.Text = "Altezza icona: " & getinfo.VerticalResolution & "px"
                st_mn_panel_ruba.Enabled = True
                st_mn_panel_chiudi.Enabled = True
            Catch ex As Exception
                'ex
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub


    Private Sub st_mn_panel_chiudi_Click(sender As Object, e As EventArgs) Handles st_mn_panel_chiudi.Click
        'st_mn_panel_chiudi.Click
        Me.Text = "Stilcon 1.1"
        st_gb_ai_icon.Image = Nothing

        st_gb_ii_name_label.Text = "Nome origine icona: " & "n/A"
        st_gb_ii_size_label.Text = "Dimensioni icona: " & "n/A"
        st_gb_ii_resolution_label.Text = "Risoluzione icona: " & "n/A"
        st_gb_ii_size_w_label.Text = "Lunghezza icona: " & "n/A"
        st_gb_ii_size_h_label.Text = "Altezza icona: " & "n/A"
        st_gb_ii_resolution_w_label.Text = "Lunghezza icona: " & "n/A"
        st_gb_ii_resolution_h_label.Text = "Altezza icona: " & "n/A"
        st_mn_panel_ruba.Enabled = False
        st_mn_panel_chiudi.Enabled = False
    End Sub

    Private Sub st_mn_panel_Click(sender As Object, e As EventArgs) Handles st_mn_panel_ruba.Click
        'st_mn_panel_ruba.Click
        If sfd.ShowDialog = DialogResult.OK Then
            'true
            Try
                'try
                st_gb_ai_icon.Image.Save(sfd.FileName)
                Process.Start(Path.GetDirectoryName(sfd.FileName))
            Catch ex As Exception
                'ex
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub st_ref_panel_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles st_ref_panel_link.LinkClicked
        'st_ref_panel_link.LinkClicked
        Process.Start("https://phoenixpixel.it/")
    End Sub

    Private Sub st_gb_ai_tb_Scroll(sender As Object, e As EventArgs) Handles st_gb_ai_tb.Scroll
        'st_gb_ai_tb.Scroll
        If st_gb_ai_tb.Value = 1 Then
            'true
            st_gb_ai_icon.SizeMode = PictureBoxSizeMode.CenterImage
        Else
            'false
            st_gb_ai_icon.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

End Class
