<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_AutoUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_AutoUpdate))
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_NewestVersion = New System.Windows.Forms.Label()
        Me.lbl_NewestVersionNr = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_MoreInfo = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lbl_info
        '
        Me.lbl_info.BackColor = System.Drawing.Color.White
        Me.lbl_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_info.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(0, 0)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(323, 72)
        Me.lbl_info.TabIndex = 0
        Me.lbl_info.Text = "Es steht eine aktuellere Version von Simple Shot List zur Verfügung. Klicken Sie " &
    "auf 'Update' um das Update jetzt herunterzuladen und zu installieren."
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_NewestVersion
        '
        Me.lbl_NewestVersion.AutoSize = True
        Me.lbl_NewestVersion.BackColor = System.Drawing.Color.White
        Me.lbl_NewestVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewestVersion.Location = New System.Drawing.Point(0, 78)
        Me.lbl_NewestVersion.Name = "lbl_NewestVersion"
        Me.lbl_NewestVersion.Size = New System.Drawing.Size(88, 13)
        Me.lbl_NewestVersion.TabIndex = 1
        Me.lbl_NewestVersion.Text = "Neuste Version:"
        '
        'lbl_NewestVersionNr
        '
        Me.lbl_NewestVersionNr.AutoSize = True
        Me.lbl_NewestVersionNr.BackColor = System.Drawing.Color.White
        Me.lbl_NewestVersionNr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewestVersionNr.Location = New System.Drawing.Point(108, 78)
        Me.lbl_NewestVersionNr.Name = "lbl_NewestVersionNr"
        Me.lbl_NewestVersionNr.Size = New System.Drawing.Size(31, 13)
        Me.lbl_NewestVersionNr.TabIndex = 2
        Me.lbl_NewestVersionNr.Text = "0.0.0"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(236, 121)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Abbrechen"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(155, 121)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_MoreInfo
        '
        Me.lbl_MoreInfo.AutoSize = True
        Me.lbl_MoreInfo.BackColor = System.Drawing.Color.White
        Me.lbl_MoreInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MoreInfo.Location = New System.Drawing.Point(108, 91)
        Me.lbl_MoreInfo.Name = "lbl_MoreInfo"
        Me.lbl_MoreInfo.Size = New System.Drawing.Size(111, 13)
        Me.lbl_MoreInfo.TabIndex = 2
        Me.lbl_MoreInfo.TabStop = True
        Me.lbl_MoreInfo.Text = "Mehr Informationen"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-6, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 123)
        Me.Panel1.TabIndex = 7
        '
        'form_AutoUpdate
        '
        Me.AcceptButton = Me.btn_update
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 151)
        Me.Controls.Add(Me.lbl_MoreInfo)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_NewestVersionNr)
        Me.Controls.Add(Me.lbl_NewestVersion)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_AutoUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_AutoUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_NewestVersion As Label
    Friend WithEvents lbl_NewestVersionNr As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents lbl_MoreInfo As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class
