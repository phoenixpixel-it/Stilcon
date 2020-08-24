<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stilcon
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stilcon))
        Me.st_gb = New System.Windows.Forms.GroupBox()
        Me.st_gb_ai = New System.Windows.Forms.GroupBox()
        Me.st_gb_ai_tb = New System.Windows.Forms.TrackBar()
        Me.st_gb_ai_icon = New System.Windows.Forms.PictureBox()
        Me.st_gb_ii = New System.Windows.Forms.GroupBox()
        Me.st_gb_ii_resolution_h_label = New System.Windows.Forms.Label()
        Me.st_gb_ii_resolution_w_label = New System.Windows.Forms.Label()
        Me.st_gb_ii_size_h_label = New System.Windows.Forms.Label()
        Me.st_gb_ii_size_w_label = New System.Windows.Forms.Label()
        Me.st_gb_ii_resolution_label = New System.Windows.Forms.Label()
        Me.st_gb_ii_name_label = New System.Windows.Forms.Label()
        Me.st_gb_ii_size_label = New System.Windows.Forms.Label()
        Me.st_mn_panel_apri = New System.Windows.Forms.Button()
        Me.st_mn_panel_ruba = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.st_ref_panel = New System.Windows.Forms.Panel()
        Me.st_ref_icon_panel = New System.Windows.Forms.Panel()
        Me.st_ref_icon = New System.Windows.Forms.PictureBox()
        Me.st_ref_panel_label = New System.Windows.Forms.Label()
        Me.st_ref_panel_link = New System.Windows.Forms.LinkLabel()
        Me.st_mn_panel_chiudi = New System.Windows.Forms.Button()
        Me.st_mn = New System.Windows.Forms.Panel()
        Me.st_gb.SuspendLayout()
        Me.st_gb_ai.SuspendLayout()
        CType(Me.st_gb_ai_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.st_gb_ai_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.st_gb_ii.SuspendLayout()
        Me.st_ref_panel.SuspendLayout()
        Me.st_ref_icon_panel.SuspendLayout()
        CType(Me.st_ref_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.st_mn.SuspendLayout()
        Me.SuspendLayout()
        '
        'st_gb
        '
        Me.st_gb.Controls.Add(Me.st_gb_ai)
        Me.st_gb.Controls.Add(Me.st_gb_ii)
        Me.st_gb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st_gb.Location = New System.Drawing.Point(13, 56)
        Me.st_gb.Name = "st_gb"
        Me.st_gb.Size = New System.Drawing.Size(657, 260)
        Me.st_gb.TabIndex = 0
        Me.st_gb.TabStop = False
        Me.st_gb.Text = "Stilcon"
        '
        'st_gb_ai
        '
        Me.st_gb_ai.Controls.Add(Me.st_gb_ai_tb)
        Me.st_gb_ai.Controls.Add(Me.st_gb_ai_icon)
        Me.st_gb_ai.Location = New System.Drawing.Point(10, 26)
        Me.st_gb_ai.Name = "st_gb_ai"
        Me.st_gb_ai.Size = New System.Drawing.Size(180, 225)
        Me.st_gb_ai.TabIndex = 2
        Me.st_gb_ai.TabStop = False
        Me.st_gb_ai.Text = "Anteprima icona"
        '
        'st_gb_ai_tb
        '
        Me.st_gb_ai_tb.Location = New System.Drawing.Point(8, 26)
        Me.st_gb_ai_tb.Maximum = 2
        Me.st_gb_ai_tb.Minimum = 1
        Me.st_gb_ai_tb.Name = "st_gb_ai_tb"
        Me.st_gb_ai_tb.Size = New System.Drawing.Size(165, 56)
        Me.st_gb_ai_tb.TabIndex = 8
        Me.st_gb_ai_tb.Value = 1
        '
        'st_gb_ai_icon
        '
        Me.st_gb_ai_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.st_gb_ai_icon.Location = New System.Drawing.Point(8, 88)
        Me.st_gb_ai_icon.Name = "st_gb_ai_icon"
        Me.st_gb_ai_icon.Size = New System.Drawing.Size(165, 125)
        Me.st_gb_ai_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.st_gb_ai_icon.TabIndex = 0
        Me.st_gb_ai_icon.TabStop = False
        '
        'st_gb_ii
        '
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_resolution_h_label)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_resolution_w_label)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_size_h_label)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_size_w_label)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_resolution_label)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_name_label)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_size_label)
        Me.st_gb_ii.Location = New System.Drawing.Point(196, 26)
        Me.st_gb_ii.Name = "st_gb_ii"
        Me.st_gb_ii.Size = New System.Drawing.Size(450, 225)
        Me.st_gb_ii.TabIndex = 1
        Me.st_gb_ii.TabStop = False
        Me.st_gb_ii.Text = "Informazioni icona"
        '
        'st_gb_ii_resolution_h_label
        '
        Me.st_gb_ii_resolution_h_label.AutoSize = True
        Me.st_gb_ii_resolution_h_label.Location = New System.Drawing.Point(45, 142)
        Me.st_gb_ii_resolution_h_label.Name = "st_gb_ii_resolution_h_label"
        Me.st_gb_ii_resolution_h_label.Size = New System.Drawing.Size(89, 20)
        Me.st_gb_ii_resolution_h_label.TabIndex = 11
        Me.st_gb_ii_resolution_h_label.Text = "Altezza: n/A"
        '
        'st_gb_ii_resolution_w_label
        '
        Me.st_gb_ii_resolution_w_label.AutoSize = True
        Me.st_gb_ii_resolution_w_label.Location = New System.Drawing.Point(45, 122)
        Me.st_gb_ii_resolution_w_label.Name = "st_gb_ii_resolution_w_label"
        Me.st_gb_ii_resolution_w_label.Size = New System.Drawing.Size(110, 20)
        Me.st_gb_ii_resolution_w_label.TabIndex = 10
        Me.st_gb_ii_resolution_w_label.Text = "Lunghezza: n/A"
        '
        'st_gb_ii_size_h_label
        '
        Me.st_gb_ii_size_h_label.AutoSize = True
        Me.st_gb_ii_size_h_label.Location = New System.Drawing.Point(45, 82)
        Me.st_gb_ii_size_h_label.Name = "st_gb_ii_size_h_label"
        Me.st_gb_ii_size_h_label.Size = New System.Drawing.Size(89, 20)
        Me.st_gb_ii_size_h_label.TabIndex = 9
        Me.st_gb_ii_size_h_label.Text = "Altezza: n/A"
        '
        'st_gb_ii_size_w_label
        '
        Me.st_gb_ii_size_w_label.AutoSize = True
        Me.st_gb_ii_size_w_label.Location = New System.Drawing.Point(45, 63)
        Me.st_gb_ii_size_w_label.Name = "st_gb_ii_size_w_label"
        Me.st_gb_ii_size_w_label.Size = New System.Drawing.Size(110, 20)
        Me.st_gb_ii_size_w_label.TabIndex = 8
        Me.st_gb_ii_size_w_label.Text = "Lunghezza: n/A"
        '
        'st_gb_ii_resolution_label
        '
        Me.st_gb_ii_resolution_label.AutoSize = True
        Me.st_gb_ii_resolution_label.Location = New System.Drawing.Point(6, 102)
        Me.st_gb_ii_resolution_label.Name = "st_gb_ii_resolution_label"
        Me.st_gb_ii_resolution_label.Size = New System.Drawing.Size(116, 20)
        Me.st_gb_ii_resolution_label.TabIndex = 4
        Me.st_gb_ii_resolution_label.Text = "Risoluzione: n/A"
        '
        'st_gb_ii_name_label
        '
        Me.st_gb_ii_name_label.AutoSize = True
        Me.st_gb_ii_name_label.Location = New System.Drawing.Point(6, 23)
        Me.st_gb_ii_name_label.Name = "st_gb_ii_name_label"
        Me.st_gb_ii_name_label.Size = New System.Drawing.Size(172, 20)
        Me.st_gb_ii_name_label.TabIndex = 1
        Me.st_gb_ii_name_label.Text = "Nome origine icona: n/A"
        '
        'st_gb_ii_size_label
        '
        Me.st_gb_ii_size_label.AutoSize = True
        Me.st_gb_ii_size_label.Location = New System.Drawing.Point(6, 43)
        Me.st_gb_ii_size_label.Name = "st_gb_ii_size_label"
        Me.st_gb_ii_size_label.Size = New System.Drawing.Size(115, 20)
        Me.st_gb_ii_size_label.TabIndex = 3
        Me.st_gb_ii_size_label.Text = "Dimensioni: n/A"
        '
        'st_mn_panel_apri
        '
        Me.st_mn_panel_apri.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.st_mn_panel_apri.Location = New System.Drawing.Point(12, 10)
        Me.st_mn_panel_apri.Name = "st_mn_panel_apri"
        Me.st_mn_panel_apri.Size = New System.Drawing.Size(100, 30)
        Me.st_mn_panel_apri.TabIndex = 1
        Me.st_mn_panel_apri.Text = "Apri"
        Me.st_mn_panel_apri.UseVisualStyleBackColor = True
        '
        'st_mn_panel_ruba
        '
        Me.st_mn_panel_ruba.Enabled = False
        Me.st_mn_panel_ruba.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.st_mn_panel_ruba.Location = New System.Drawing.Point(225, 10)
        Me.st_mn_panel_ruba.Name = "st_mn_panel_ruba"
        Me.st_mn_panel_ruba.Size = New System.Drawing.Size(445, 30)
        Me.st_mn_panel_ruba.TabIndex = 2
        Me.st_mn_panel_ruba.Text = "Ruba"
        Me.st_mn_panel_ruba.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.DefaultExt = "Tutti i file|*.*"
        Me.ofd.Filter = "Tutti i file|*.*"
        Me.ofd.Title = "Apri"
        '
        'sfd
        '
        Me.sfd.DefaultExt = "File BITMAP|*.bmp;*.dib"
        Me.sfd.Filter = "File BITMAP|*.bmp;*.dib|File PNG|*.png|File JPEG|*.jpg;*.jpeg;*.jpe;*.jif;*.jfif;" &
    "*.jfi|File CUR|*.cur"
        Me.sfd.Title = "Ruba"
        '
        'st_ref_panel
        '
        Me.st_ref_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.st_ref_panel.Controls.Add(Me.st_ref_icon_panel)
        Me.st_ref_panel.Controls.Add(Me.st_ref_panel_label)
        Me.st_ref_panel.Controls.Add(Me.st_ref_panel_link)
        Me.st_ref_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.st_ref_panel.Location = New System.Drawing.Point(0, 0)
        Me.st_ref_panel.Name = "st_ref_panel"
        Me.st_ref_panel.Size = New System.Drawing.Size(682, 50)
        Me.st_ref_panel.TabIndex = 3
        '
        'st_ref_icon_panel
        '
        Me.st_ref_icon_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.st_ref_icon_panel.Controls.Add(Me.st_ref_icon)
        Me.st_ref_icon_panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.st_ref_icon_panel.Location = New System.Drawing.Point(606, 0)
        Me.st_ref_icon_panel.Name = "st_ref_icon_panel"
        Me.st_ref_icon_panel.Size = New System.Drawing.Size(76, 50)
        Me.st_ref_icon_panel.TabIndex = 2
        '
        'st_ref_icon
        '
        Me.st_ref_icon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.st_ref_icon.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.st_ref_icon.Image = Global.Stilcon.My.Resources.Resources.stilcon
        Me.st_ref_icon.Location = New System.Drawing.Point(3, 3)
        Me.st_ref_icon.Name = "st_ref_icon"
        Me.st_ref_icon.Size = New System.Drawing.Size(70, 45)
        Me.st_ref_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.st_ref_icon.TabIndex = 2
        Me.st_ref_icon.TabStop = False
        '
        'st_ref_panel_label
        '
        Me.st_ref_panel_label.AutoSize = True
        Me.st_ref_panel_label.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st_ref_panel_label.Location = New System.Drawing.Point(10, 14)
        Me.st_ref_panel_label.Name = "st_ref_panel_label"
        Me.st_ref_panel_label.Size = New System.Drawing.Size(89, 23)
        Me.st_ref_panel_label.TabIndex = 1
        Me.st_ref_panel_label.Text = "Creato da:"
        '
        'st_ref_panel_link
        '
        Me.st_ref_panel_link.AutoSize = True
        Me.st_ref_panel_link.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st_ref_panel_link.Location = New System.Drawing.Point(102, 14)
        Me.st_ref_panel_link.Name = "st_ref_panel_link"
        Me.st_ref_panel_link.Size = New System.Drawing.Size(111, 23)
        Me.st_ref_panel_link.TabIndex = 0
        Me.st_ref_panel_link.TabStop = True
        Me.st_ref_panel_link.Text = "Phoenix Pixel"
        '
        'st_mn_panel_chiudi
        '
        Me.st_mn_panel_chiudi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.st_mn_panel_chiudi.Location = New System.Drawing.Point(119, 10)
        Me.st_mn_panel_chiudi.Name = "st_mn_panel_chiudi"
        Me.st_mn_panel_chiudi.Size = New System.Drawing.Size(100, 30)
        Me.st_mn_panel_chiudi.TabIndex = 4
        Me.st_mn_panel_chiudi.Text = "Chiudi"
        Me.st_mn_panel_chiudi.UseVisualStyleBackColor = True
        '
        'st_mn
        '
        Me.st_mn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.st_mn.Controls.Add(Me.st_mn_panel_apri)
        Me.st_mn.Controls.Add(Me.st_mn_panel_chiudi)
        Me.st_mn.Controls.Add(Me.st_mn_panel_ruba)
        Me.st_mn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.st_mn.Location = New System.Drawing.Point(0, 333)
        Me.st_mn.Name = "st_mn"
        Me.st_mn.Size = New System.Drawing.Size(682, 50)
        Me.st_mn.TabIndex = 5
        '
        'stilcon
        '
        Me.AcceptButton = Me.st_mn_panel_apri
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 383)
        Me.Controls.Add(Me.st_mn)
        Me.Controls.Add(Me.st_ref_panel)
        Me.Controls.Add(Me.st_gb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "stilcon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stilicon 1.1.0.2"
        Me.st_gb.ResumeLayout(False)
        Me.st_gb_ai.ResumeLayout(False)
        Me.st_gb_ai.PerformLayout()
        CType(Me.st_gb_ai_tb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.st_gb_ai_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.st_gb_ii.ResumeLayout(False)
        Me.st_gb_ii.PerformLayout()
        Me.st_ref_panel.ResumeLayout(False)
        Me.st_ref_panel.PerformLayout()
        Me.st_ref_icon_panel.ResumeLayout(False)
        CType(Me.st_ref_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.st_mn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents st_gb As GroupBox
    Friend WithEvents st_gb_ai_icon As PictureBox
    Friend WithEvents st_gb_ai As GroupBox
    Friend WithEvents st_gb_ii As GroupBox
    Friend WithEvents st_gb_ii_name_label As Label
    Friend WithEvents st_gb_ii_size_label As Label
    Friend WithEvents st_mn_panel_apri As Button
    Friend WithEvents st_mn_panel_ruba As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents st_gb_ii_resolution_label As Label
    Friend WithEvents st_ref_panel As Panel
    Friend WithEvents st_ref_panel_label As Label
    Friend WithEvents st_ref_panel_link As LinkLabel
    Friend WithEvents st_mn_panel_chiudi As Button
    Friend WithEvents st_gb_ai_tb As TrackBar
    Friend WithEvents st_mn As Panel
    Friend WithEvents st_gb_ii_size_h_label As Label
    Friend WithEvents st_gb_ii_size_w_label As Label
    Friend WithEvents st_gb_ii_resolution_h_label As Label
    Friend WithEvents st_gb_ii_resolution_w_label As Label
    Friend WithEvents st_ref_icon As PictureBox
    Friend WithEvents st_ref_icon_panel As Panel
End Class
