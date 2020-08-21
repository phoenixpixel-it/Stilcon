<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stilcon
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.st_gb = New System.Windows.Forms.GroupBox()
        Me.st_gb_ai = New System.Windows.Forms.GroupBox()
        Me.st_gb_ai_icon = New System.Windows.Forms.PictureBox()
        Me.st_gb_ii = New System.Windows.Forms.GroupBox()
        Me.st_gb_ii_name = New System.Windows.Forms.Label()
        Me.st_gb_ii_type = New System.Windows.Forms.Label()
        Me.st_gb_ii_size = New System.Windows.Forms.Label()
        Me.st_apri = New System.Windows.Forms.Button()
        Me.st_gb_ruba = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.st_gb.SuspendLayout()
        Me.st_gb_ai.SuspendLayout()
        CType(Me.st_gb_ai_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.st_gb_ii.SuspendLayout()
        Me.SuspendLayout()
        '
        'st_gb
        '
        Me.st_gb.Controls.Add(Me.st_gb_ai)
        Me.st_gb.Controls.Add(Me.st_gb_ii)
        Me.st_gb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st_gb.Location = New System.Drawing.Point(12, 12)
        Me.st_gb.Name = "st_gb"
        Me.st_gb.Size = New System.Drawing.Size(685, 220)
        Me.st_gb.TabIndex = 0
        Me.st_gb.TabStop = False
        Me.st_gb.Text = "Stilcon"
        '
        'st_gb_ai
        '
        Me.st_gb_ai.Controls.Add(Me.st_gb_ai_icon)
        Me.st_gb_ai.Location = New System.Drawing.Point(7, 26)
        Me.st_gb_ai.Name = "st_gb_ai"
        Me.st_gb_ai.Size = New System.Drawing.Size(165, 185)
        Me.st_gb_ai.TabIndex = 2
        Me.st_gb_ai.TabStop = False
        Me.st_gb_ai.Text = "Anteprima icona"
        '
        'st_gb_ai_icon
        '
        Me.st_gb_ai_icon.Location = New System.Drawing.Point(7, 26)
        Me.st_gb_ai_icon.Name = "st_gb_ai_icon"
        Me.st_gb_ai_icon.Size = New System.Drawing.Size(150, 150)
        Me.st_gb_ai_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.st_gb_ai_icon.TabIndex = 0
        Me.st_gb_ai_icon.TabStop = False
        '
        'st_gb_ii
        '
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_name)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_type)
        Me.st_gb_ii.Controls.Add(Me.st_gb_ii_size)
        Me.st_gb_ii.Location = New System.Drawing.Point(178, 26)
        Me.st_gb_ii.Name = "st_gb_ii"
        Me.st_gb_ii.Size = New System.Drawing.Size(500, 185)
        Me.st_gb_ii.TabIndex = 1
        Me.st_gb_ii.TabStop = False
        Me.st_gb_ii.Text = "Informazioni icona"
        '
        'st_gb_ii_name
        '
        Me.st_gb_ii_name.AutoSize = True
        Me.st_gb_ii_name.Location = New System.Drawing.Point(6, 23)
        Me.st_gb_ii_name.Name = "st_gb_ii_name"
        Me.st_gb_ii_name.Size = New System.Drawing.Size(172, 20)
        Me.st_gb_ii_name.TabIndex = 1
        Me.st_gb_ii_name.Text = "Nome origine icona: n/A"
        '
        'st_gb_ii_type
        '
        Me.st_gb_ii_type.AutoSize = True
        Me.st_gb_ii_type.Location = New System.Drawing.Point(6, 63)
        Me.st_gb_ii_type.Name = "st_gb_ii_type"
        Me.st_gb_ii_type.Size = New System.Drawing.Size(96, 20)
        Me.st_gb_ii_type.TabIndex = 2
        Me.st_gb_ii_type.Text = "Formato: n/A"
        '
        'st_gb_ii_size
        '
        Me.st_gb_ii_size.AutoSize = True
        Me.st_gb_ii_size.Location = New System.Drawing.Point(6, 43)
        Me.st_gb_ii_size.Name = "st_gb_ii_size"
        Me.st_gb_ii_size.Size = New System.Drawing.Size(115, 20)
        Me.st_gb_ii_size.TabIndex = 3
        Me.st_gb_ii_size.Text = "Dimensioni: n/A"
        '
        'st_apri
        '
        Me.st_apri.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.st_apri.Location = New System.Drawing.Point(12, 238)
        Me.st_apri.Name = "st_apri"
        Me.st_apri.Size = New System.Drawing.Size(280, 40)
        Me.st_apri.TabIndex = 1
        Me.st_apri.Text = "Apri"
        Me.st_apri.UseVisualStyleBackColor = True
        '
        'st_gb_ruba
        '
        Me.st_gb_ruba.Enabled = False
        Me.st_gb_ruba.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.st_gb_ruba.Location = New System.Drawing.Point(297, 238)
        Me.st_gb_ruba.Name = "st_gb_ruba"
        Me.st_gb_ruba.Size = New System.Drawing.Size(400, 40)
        Me.st_gb_ruba.TabIndex = 2
        Me.st_gb_ruba.Text = "Ruba"
        Me.st_gb_ruba.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.DefaultExt = "Tutti i file|*.*"
        Me.ofd.Filter = "Tutti i file|*.*"
        Me.ofd.Title = "Apri"
        '
        'sfd
        '
        Me.sfd.DefaultExt = "File BUTMAP|*.bmp;*.dib"
        Me.sfd.Filter = "File PNG|*.png|File BITMAP|*.bmp;*.dib|File JPEG|*.jpg;*.jpeg;*.jpe;*.jif;*.jfif;" &
    "*.jfi|File ICO|*.ico|File CUR|*.cur|Tutti i file|*.*"
        Me.sfd.Title = "Ruba"
        '
        'stilcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 289)
        Me.Controls.Add(Me.st_gb_ruba)
        Me.Controls.Add(Me.st_apri)
        Me.Controls.Add(Me.st_gb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "stilcon"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stilicon"
        Me.st_gb.ResumeLayout(False)
        Me.st_gb_ai.ResumeLayout(False)
        CType(Me.st_gb_ai_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.st_gb_ii.ResumeLayout(False)
        Me.st_gb_ii.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents st_gb As GroupBox
    Friend WithEvents st_gb_ai_icon As PictureBox
    Friend WithEvents st_gb_ai As GroupBox
    Friend WithEvents st_gb_ii As GroupBox
    Friend WithEvents st_gb_ii_name As Label
    Friend WithEvents st_gb_ii_type As Label
    Friend WithEvents st_gb_ii_size As Label
    Friend WithEvents st_apri As Button
    Friend WithEvents st_gb_ruba As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
End Class
