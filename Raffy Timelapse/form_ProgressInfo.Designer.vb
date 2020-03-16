<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_ProgressInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_ProgressInfo))
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.tm_CheckState = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_errorlog = New System.Windows.Forms.LinkLabel()
        Me.progressbar = New System.Windows.Forms.ProgressBar()
        Me.pb = New System.Windows.Forms.PictureBox()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_status
        '
        Me.lbl_status.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(92, 11)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(385, 57)
        Me.lbl_status.TabIndex = 1
        Me.lbl_status.Text = "..."
        Me.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_ok
        '
        Me.btn_ok.Enabled = False
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Location = New System.Drawing.Point(365, 132)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(112, 35)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(245, 132)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(112, 35)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Abbrechen"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'tm_CheckState
        '
        Me.tm_CheckState.Enabled = True
        '
        'lbl_errorlog
        '
        Me.lbl_errorlog.AutoSize = True
        Me.lbl_errorlog.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_errorlog.Location = New System.Drawing.Point(13, 147)
        Me.lbl_errorlog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_errorlog.Name = "lbl_errorlog"
        Me.lbl_errorlog.Size = New System.Drawing.Size(91, 23)
        Me.lbl_errorlog.TabIndex = 4
        Me.lbl_errorlog.TabStop = True
        Me.lbl_errorlog.Text = "View Log..."
        Me.lbl_errorlog.Visible = False
        '
        'progressbar
        '
        Me.progressbar.Location = New System.Drawing.Point(92, 71)
        Me.progressbar.Name = "progressbar"
        Me.progressbar.Size = New System.Drawing.Size(385, 37)
        Me.progressbar.TabIndex = 5
        '
        'pb
        '
        Me.pb.Image = Global.Raffy_Timelapse.My.Resources.Resources.loading
        Me.pb.Location = New System.Drawing.Point(12, 38)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(70, 70)
        Me.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb.TabIndex = 6
        Me.pb.TabStop = False
        '
        'form_ProgressInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 174)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.progressbar)
        Me.Controls.Add(Me.lbl_errorlog)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.lbl_status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_ProgressInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verarbeitung"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_status As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents tm_CheckState As Timer
    Friend WithEvents lbl_errorlog As LinkLabel
    Friend WithEvents progressbar As ProgressBar
    Friend WithEvents pb As PictureBox
End Class
