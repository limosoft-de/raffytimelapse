<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_update
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_update))
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_LocalVersionNr = New System.Windows.Forms.Label()
        Me.lbl_NewestVersionNr = New System.Windows.Forms.Label()
        Me.lbl_changelog = New System.Windows.Forms.Label()
        Me.rtb_changelog = New System.Windows.Forms.RichTextBox()
        Me.lbl_NewestVersion = New System.Windows.Forms.Label()
        Me.lbl_LocalVersion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bw_UpdateDetails = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(195, 7)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "btn_update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(276, 7)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "btn_cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lbl_LocalVersionNr
        '
        Me.lbl_LocalVersionNr.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_LocalVersionNr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LocalVersionNr.ForeColor = System.Drawing.Color.White
        Me.lbl_LocalVersionNr.Location = New System.Drawing.Point(119, 18)
        Me.lbl_LocalVersionNr.Name = "lbl_LocalVersionNr"
        Me.lbl_LocalVersionNr.Size = New System.Drawing.Size(153, 21)
        Me.lbl_LocalVersionNr.TabIndex = 2
        Me.lbl_LocalVersionNr.Text = "lbl_LocalVersionNr"
        '
        'lbl_NewestVersionNr
        '
        Me.lbl_NewestVersionNr.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_NewestVersionNr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewestVersionNr.ForeColor = System.Drawing.Color.White
        Me.lbl_NewestVersionNr.Location = New System.Drawing.Point(119, 38)
        Me.lbl_NewestVersionNr.Name = "lbl_NewestVersionNr"
        Me.lbl_NewestVersionNr.Size = New System.Drawing.Size(153, 21)
        Me.lbl_NewestVersionNr.TabIndex = 3
        Me.lbl_NewestVersionNr.Text = "lbl_NewestVersionNr"
        '
        'lbl_changelog
        '
        Me.lbl_changelog.AutoSize = True
        Me.lbl_changelog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_changelog.ForeColor = System.Drawing.Color.White
        Me.lbl_changelog.Location = New System.Drawing.Point(12, 89)
        Me.lbl_changelog.Name = "lbl_changelog"
        Me.lbl_changelog.Size = New System.Drawing.Size(88, 17)
        Me.lbl_changelog.TabIndex = 4
        Me.lbl_changelog.Text = "lbl_changelog"
        '
        'rtb_changelog
        '
        Me.rtb_changelog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_changelog.BackColor = System.Drawing.Color.Gray
        Me.rtb_changelog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_changelog.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtb_changelog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_changelog.Location = New System.Drawing.Point(15, 109)
        Me.rtb_changelog.Name = "rtb_changelog"
        Me.rtb_changelog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtb_changelog.Size = New System.Drawing.Size(336, 248)
        Me.rtb_changelog.TabIndex = 5
        Me.rtb_changelog.Text = ""
        '
        'lbl_NewestVersion
        '
        Me.lbl_NewestVersion.AutoSize = True
        Me.lbl_NewestVersion.ForeColor = System.Drawing.Color.White
        Me.lbl_NewestVersion.Location = New System.Drawing.Point(6, 38)
        Me.lbl_NewestVersion.Name = "lbl_NewestVersion"
        Me.lbl_NewestVersion.Size = New System.Drawing.Size(101, 17)
        Me.lbl_NewestVersion.TabIndex = 1
        Me.lbl_NewestVersion.Text = "Newest Version:"
        '
        'lbl_LocalVersion
        '
        Me.lbl_LocalVersion.AutoSize = True
        Me.lbl_LocalVersion.ForeColor = System.Drawing.Color.White
        Me.lbl_LocalVersion.Location = New System.Drawing.Point(6, 18)
        Me.lbl_LocalVersion.Name = "lbl_LocalVersion"
        Me.lbl_LocalVersion.Size = New System.Drawing.Size(83, 17)
        Me.lbl_LocalVersion.TabIndex = 0
        Me.lbl_LocalVersion.Text = "Your version:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbl_NewestVersion)
        Me.GroupBox1.Controls.Add(Me.lbl_NewestVersionNr)
        Me.GroupBox1.Controls.Add(Me.lbl_LocalVersion)
        Me.GroupBox1.Controls.Add(Me.lbl_LocalVersionNr)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 65)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'bw_UpdateDetails
        '
        Me.bw_UpdateDetails.WorkerReportsProgress = True
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Gray
        Me.pnl.Controls.Add(Me.btn_cancel)
        Me.pnl.Controls.Add(Me.btn_update)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl.Location = New System.Drawing.Point(0, 363)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(363, 37)
        Me.pnl.TabIndex = 8
        '
        'form_update
        '
        Me.AcceptButton = Me.btn_update
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(363, 400)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rtb_changelog)
        Me.Controls.Add(Me.lbl_changelog)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_update"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lbl_LocalVersionNr As Label
    Friend WithEvents lbl_NewestVersionNr As Label
    Friend WithEvents lbl_changelog As Label
    Friend WithEvents rtb_changelog As RichTextBox
    Friend WithEvents lbl_LocalVersion As Label
    Friend WithEvents lbl_NewestVersion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bw_UpdateDetails As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnl As Panel
End Class
