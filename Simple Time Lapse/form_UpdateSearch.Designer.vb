<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_UpdateSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_UpdateSearch))
        Me.Pb_loading = New System.Windows.Forms.PictureBox()
        Me.lbl_progress = New System.Windows.Forms.Label()
        Me.bw_UpdateSearch = New System.ComponentModel.BackgroundWorker()
        CType(Me.Pb_loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pb_loading
        '
        Me.Pb_loading.BackColor = System.Drawing.SystemColors.Control
        Me.Pb_loading.Image = Global.Raffy_Timelapse.My.Resources.Resources.loading
        Me.Pb_loading.InitialImage = Global.Raffy_Timelapse.My.Resources.Resources.loading
        Me.Pb_loading.Location = New System.Drawing.Point(12, 12)
        Me.Pb_loading.Name = "Pb_loading"
        Me.Pb_loading.Size = New System.Drawing.Size(47, 54)
        Me.Pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_loading.TabIndex = 4
        Me.Pb_loading.TabStop = False
        '
        'lbl_progress
        '
        Me.lbl_progress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_progress.Location = New System.Drawing.Point(65, 12)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(194, 54)
        Me.lbl_progress.TabIndex = 5
        Me.lbl_progress.Text = "Searching for updates..."
        Me.lbl_progress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bw_UpdateSearch
        '
        Me.bw_UpdateSearch.WorkerReportsProgress = True
        Me.bw_UpdateSearch.WorkerSupportsCancellation = True
        '
        'form_UpdateSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(271, 80)
        Me.Controls.Add(Me.lbl_progress)
        Me.Controls.Add(Me.Pb_loading)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_UpdateSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_UpdateSearch"
        CType(Me.Pb_loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pb_loading As PictureBox
    Friend WithEvents lbl_progress As Label
    Friend WithEvents bw_UpdateSearch As System.ComponentModel.BackgroundWorker
End Class
