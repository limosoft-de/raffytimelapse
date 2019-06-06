<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_about
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_about))
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_AppName = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.lbl_VersionNr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_logo
        '
        Me.pb_logo.BackgroundImage = CType(resources.GetObject("pb_logo.BackgroundImage"), System.Drawing.Image)
        Me.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_logo.Location = New System.Drawing.Point(20, 34)
        Me.pb_logo.Name = "pb_logo"
        Me.pb_logo.Size = New System.Drawing.Size(110, 110)
        Me.pb_logo.TabIndex = 0
        Me.pb_logo.TabStop = False
        '
        'lbl_AppName
        '
        Me.lbl_AppName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_AppName.AutoSize = True
        Me.lbl_AppName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AppName.ForeColor = System.Drawing.Color.White
        Me.lbl_AppName.Location = New System.Drawing.Point(144, 51)
        Me.lbl_AppName.Name = "lbl_AppName"
        Me.lbl_AppName.Size = New System.Drawing.Size(184, 32)
        Me.lbl_AppName.TabIndex = 1
        Me.lbl_AppName.Text = "Raffy Timelapse"
        '
        'lbl_version
        '
        Me.lbl_version.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_version.ForeColor = System.Drawing.Color.White
        Me.lbl_version.Location = New System.Drawing.Point(149, 94)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(48, 15)
        Me.lbl_version.TabIndex = 2
        Me.lbl_version.Text = "Version:"
        '
        'lbl_close
        '
        Me.lbl_close.ActiveLinkColor = System.Drawing.Color.White
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_close.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_close.Location = New System.Drawing.Point(340, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(23, 25)
        Me.lbl_close.TabIndex = 3
        Me.lbl_close.TabStop = True
        Me.lbl_close.Text = "X"
        Me.lbl_close.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_close.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'lbl_VersionNr
        '
        Me.lbl_VersionNr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_VersionNr.AutoSize = True
        Me.lbl_VersionNr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VersionNr.ForeColor = System.Drawing.Color.White
        Me.lbl_VersionNr.Location = New System.Drawing.Point(203, 94)
        Me.lbl_VersionNr.Name = "lbl_VersionNr"
        Me.lbl_VersionNr.Size = New System.Drawing.Size(40, 15)
        Me.lbl_VersionNr.TabIndex = 4
        Me.lbl_VersionNr.Text = "0.0.0.0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(170, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Made with ❤  by Limosoft"
        '
        'form_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.lbl_close
        Me.ClientSize = New System.Drawing.Size(375, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_VersionNr)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.lbl_AppName)
        Me.Controls.Add(Me.pb_logo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_about"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents lbl_AppName As Label
    Friend WithEvents lbl_version As Label
    Friend WithEvents lbl_VersionNr As Label
    Friend WithEvents Label1 As Label
End Class
