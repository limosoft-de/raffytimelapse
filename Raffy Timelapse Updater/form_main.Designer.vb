<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.Picb_Icon = New System.Windows.Forms.PictureBox()
        Me.Pb_Progress = New System.Windows.Forms.ProgressBar()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.Bw_GetUrl = New System.ComponentModel.BackgroundWorker()
        Me.Lbl_RaffyVersion = New System.Windows.Forms.Label()
        Me.Lbl_UpdaterVersion = New System.Windows.Forms.Label()
        CType(Me.Picb_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picb_Icon
        '
        Me.Picb_Icon.Image = CType(resources.GetObject("Picb_Icon.Image"), System.Drawing.Image)
        Me.Picb_Icon.Location = New System.Drawing.Point(18, 48)
        Me.Picb_Icon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Picb_Icon.Name = "Picb_Icon"
        Me.Picb_Icon.Size = New System.Drawing.Size(840, 150)
        Me.Picb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picb_Icon.TabIndex = 0
        Me.Picb_Icon.TabStop = False
        '
        'Pb_Progress
        '
        Me.Pb_Progress.Location = New System.Drawing.Point(18, 304)
        Me.Pb_Progress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Pb_Progress.Name = "Pb_Progress"
        Me.Pb_Progress.Size = New System.Drawing.Size(840, 34)
        Me.Pb_Progress.TabIndex = 1
        '
        'Lbl_Title
        '
        Me.Lbl_Title.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(18, 213)
        Me.Lbl_Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(840, 38)
        Me.Lbl_Title.TabIndex = 2
        Me.Lbl_Title.Text = "Raffy Timelapse Updater"
        Me.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_Status
        '
        Me.Lbl_Status.Location = New System.Drawing.Point(14, 344)
        Me.Lbl_Status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(844, 34)
        Me.Lbl_Status.TabIndex = 3
        Me.Lbl_Status.Text = "Checking internet connection..."
        '
        'Lbl_RaffyVersion
        '
        Me.Lbl_RaffyVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RaffyVersion.Location = New System.Drawing.Point(14, 254)
        Me.Lbl_RaffyVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_RaffyVersion.Name = "Lbl_RaffyVersion"
        Me.Lbl_RaffyVersion.Size = New System.Drawing.Size(840, 38)
        Me.Lbl_RaffyVersion.TabIndex = 4
        Me.Lbl_RaffyVersion.Text = "Version: 0.0.0.0"
        Me.Lbl_RaffyVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_RaffyVersion.Visible = False
        '
        'Lbl_UpdaterVersion
        '
        Me.Lbl_UpdaterVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_UpdaterVersion.AutoSize = True
        Me.Lbl_UpdaterVersion.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UpdaterVersion.Location = New System.Drawing.Point(798, 382)
        Me.Lbl_UpdaterVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_UpdaterVersion.Name = "Lbl_UpdaterVersion"
        Me.Lbl_UpdaterVersion.Size = New System.Drawing.Size(61, 19)
        Me.Lbl_UpdaterVersion.TabIndex = 5
        Me.Lbl_UpdaterVersion.Text = "v 1.0.0.0"
        '
        'form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(876, 414)
        Me.Controls.Add(Me.Lbl_UpdaterVersion)
        Me.Controls.Add(Me.Lbl_RaffyVersion)
        Me.Controls.Add(Me.Lbl_Status)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.Pb_Progress)
        Me.Controls.Add(Me.Picb_Icon)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Raffy Timelapse Updater"
        CType(Me.Picb_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picb_Icon As PictureBox
    Friend WithEvents Pb_Progress As ProgressBar
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Lbl_Status As Label
    Friend WithEvents Bw_GetUrl As System.ComponentModel.BackgroundWorker
    Friend WithEvents Lbl_RaffyVersion As Label
    Friend WithEvents Lbl_UpdaterVersion As Label
End Class
