<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ProjectSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_ProjectSettings))
        Me.cb_fps = New System.Windows.Forms.ComboBox()
        Me.lbl_SaveTo = New System.Windows.Forms.Label()
        Me.lbl_fps = New System.Windows.Forms.Label()
        Me.tb_destination = New System.Windows.Forms.TextBox()
        Me.lbl_resolution = New System.Windows.Forms.Label()
        Me.cb_res = New System.Windows.Forms.ComboBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.dl_SaveMovie = New System.Windows.Forms.SaveFileDialog()
        Me.lbl_quality = New System.Windows.Forms.Label()
        Me.cb_quality = New System.Windows.Forms.ComboBox()
        Me.lbl_advancedMode = New System.Windows.Forms.LinkLabel()
        Me.num_fps = New System.Windows.Forms.NumericUpDown()
        Me.num_res_width = New System.Windows.Forms.NumericUpDown()
        Me.num_res_height = New System.Windows.Forms.NumericUpDown()
        Me.lbl_resolutionX = New System.Windows.Forms.Label()
        CType(Me.num_fps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_res_width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_res_height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_fps
        '
        Me.cb_fps.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_fps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_fps.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_fps.ForeColor = System.Drawing.Color.Black
        Me.cb_fps.FormattingEnabled = True
        Me.cb_fps.Items.AddRange(New Object() {"24", "25", "30", "50", "60"})
        Me.cb_fps.Location = New System.Drawing.Point(286, 79)
        Me.cb_fps.Name = "cb_fps"
        Me.cb_fps.Size = New System.Drawing.Size(139, 21)
        Me.cb_fps.TabIndex = 4
        '
        'lbl_SaveTo
        '
        Me.lbl_SaveTo.AutoSize = True
        Me.lbl_SaveTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaveTo.ForeColor = System.Drawing.Color.White
        Me.lbl_SaveTo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_SaveTo.Name = "lbl_SaveTo"
        Me.lbl_SaveTo.Size = New System.Drawing.Size(53, 13)
        Me.lbl_SaveTo.TabIndex = 50
        Me.lbl_SaveTo.Text = "Save to..."
        '
        'lbl_fps
        '
        Me.lbl_fps.AutoSize = True
        Me.lbl_fps.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fps.ForeColor = System.Drawing.Color.White
        Me.lbl_fps.Location = New System.Drawing.Point(283, 63)
        Me.lbl_fps.Name = "lbl_fps"
        Me.lbl_fps.Size = New System.Drawing.Size(131, 13)
        Me.lbl_fps.TabIndex = 52
        Me.lbl_fps.Text = "Frames per Second (FPS)"
        '
        'tb_destination
        '
        Me.tb_destination.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tb_destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_destination.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_destination.ForeColor = System.Drawing.Color.Black
        Me.tb_destination.Location = New System.Drawing.Point(15, 27)
        Me.tb_destination.Name = "tb_destination"
        Me.tb_destination.Size = New System.Drawing.Size(329, 22)
        Me.tb_destination.TabIndex = 1
        '
        'lbl_resolution
        '
        Me.lbl_resolution.AutoSize = True
        Me.lbl_resolution.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resolution.ForeColor = System.Drawing.Color.White
        Me.lbl_resolution.Location = New System.Drawing.Point(12, 63)
        Me.lbl_resolution.Name = "lbl_resolution"
        Me.lbl_resolution.Size = New System.Drawing.Size(63, 13)
        Me.lbl_resolution.TabIndex = 51
        Me.lbl_resolution.Text = "Resolution"
        '
        'cb_res
        '
        Me.cb_res.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_res.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_res.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_res.ForeColor = System.Drawing.Color.Black
        Me.cb_res.FormattingEnabled = True
        Me.cb_res.Location = New System.Drawing.Point(15, 79)
        Me.cb_res.Name = "cb_res"
        Me.cb_res.Size = New System.Drawing.Size(265, 21)
        Me.cb_res.TabIndex = 3
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(350, 169)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 31
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(269, 169)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 30
        Me.btn_cancel.Text = "Abbrechen"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(350, 27)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 22)
        Me.btn_browse.TabIndex = 2
        Me.btn_browse.Text = "Durchsuchen"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'dl_SaveMovie
        '
        Me.dl_SaveMovie.Title = "Speicherort auswählen"
        '
        'lbl_quality
        '
        Me.lbl_quality.AutoSize = True
        Me.lbl_quality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quality.ForeColor = System.Drawing.Color.White
        Me.lbl_quality.Location = New System.Drawing.Point(12, 115)
        Me.lbl_quality.Name = "lbl_quality"
        Me.lbl_quality.Size = New System.Drawing.Size(137, 13)
        Me.lbl_quality.TabIndex = 53
        Me.lbl_quality.Text = "Quality/Processing Speed"
        '
        'cb_quality
        '
        Me.cb_quality.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_quality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_quality.ForeColor = System.Drawing.Color.Black
        Me.cb_quality.FormattingEnabled = True
        Me.cb_quality.Location = New System.Drawing.Point(15, 131)
        Me.cb_quality.Name = "cb_quality"
        Me.cb_quality.Size = New System.Drawing.Size(410, 21)
        Me.cb_quality.TabIndex = 21
        '
        'lbl_advancedMode
        '
        Me.lbl_advancedMode.ActiveLinkColor = System.Drawing.Color.White
        Me.lbl_advancedMode.AutoSize = True
        Me.lbl_advancedMode.LinkColor = System.Drawing.Color.Black
        Me.lbl_advancedMode.Location = New System.Drawing.Point(12, 174)
        Me.lbl_advancedMode.Name = "lbl_advancedMode"
        Me.lbl_advancedMode.Size = New System.Drawing.Size(85, 13)
        Me.lbl_advancedMode.TabIndex = 40
        Me.lbl_advancedMode.TabStop = True
        Me.lbl_advancedMode.Text = "Advanced mode"
        Me.lbl_advancedMode.VisitedLinkColor = System.Drawing.Color.Black
        '
        'num_fps
        '
        Me.num_fps.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.num_fps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_fps.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.num_fps.Location = New System.Drawing.Point(286, 78)
        Me.num_fps.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_fps.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_fps.Name = "num_fps"
        Me.num_fps.Size = New System.Drawing.Size(139, 22)
        Me.num_fps.TabIndex = 12
        Me.num_fps.Value = New Decimal(New Integer() {25, 0, 0, 0})
        Me.num_fps.Visible = False
        '
        'num_res_width
        '
        Me.num_res_width.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.num_res_width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_res_width.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.num_res_width.Location = New System.Drawing.Point(15, 78)
        Me.num_res_width.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_res_width.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_res_width.Name = "num_res_width"
        Me.num_res_width.Size = New System.Drawing.Size(120, 22)
        Me.num_res_width.TabIndex = 10
        Me.num_res_width.Value = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.num_res_width.Visible = False
        '
        'num_res_height
        '
        Me.num_res_height.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.num_res_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_res_height.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.num_res_height.Location = New System.Drawing.Point(147, 78)
        Me.num_res_height.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_res_height.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_res_height.Name = "num_res_height"
        Me.num_res_height.Size = New System.Drawing.Size(120, 22)
        Me.num_res_height.TabIndex = 11
        Me.num_res_height.Value = New Decimal(New Integer() {1080, 0, 0, 0})
        Me.num_res_height.Visible = False
        '
        'lbl_resolutionX
        '
        Me.lbl_resolutionX.AutoSize = True
        Me.lbl_resolutionX.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lbl_resolutionX.ForeColor = System.Drawing.Color.White
        Me.lbl_resolutionX.Location = New System.Drawing.Point(135, 82)
        Me.lbl_resolutionX.Name = "lbl_resolutionX"
        Me.lbl_resolutionX.Size = New System.Drawing.Size(12, 13)
        Me.lbl_resolutionX.TabIndex = 18
        Me.lbl_resolutionX.Text = "x"
        Me.lbl_resolutionX.Visible = False
        '
        'form_ProjectSettings
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(434, 202)
        Me.Controls.Add(Me.lbl_resolutionX)
        Me.Controls.Add(Me.num_res_height)
        Me.Controls.Add(Me.num_res_width)
        Me.Controls.Add(Me.num_fps)
        Me.Controls.Add(Me.lbl_advancedMode)
        Me.Controls.Add(Me.cb_quality)
        Me.Controls.Add(Me.lbl_quality)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.lbl_resolution)
        Me.Controls.Add(Me.cb_res)
        Me.Controls.Add(Me.tb_destination)
        Me.Controls.Add(Me.lbl_fps)
        Me.Controls.Add(Me.lbl_SaveTo)
        Me.Controls.Add(Me.cb_fps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_ProjectSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Einstellungen"
        CType(Me.num_fps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_res_width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_res_height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_fps As ComboBox
    Friend WithEvents lbl_SaveTo As Label
    Friend WithEvents lbl_fps As Label
    Friend WithEvents tb_destination As TextBox
    Friend WithEvents lbl_resolution As Label
    Friend WithEvents cb_res As ComboBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_browse As Button
    Friend WithEvents dl_SaveMovie As SaveFileDialog
    Friend WithEvents lbl_quality As Label
    Friend WithEvents cb_quality As ComboBox
    Friend WithEvents lbl_advancedMode As LinkLabel
    Friend WithEvents num_fps As NumericUpDown
    Friend WithEvents num_res_width As NumericUpDown
    Friend WithEvents num_res_height As NumericUpDown
    Friend WithEvents lbl_resolutionX As Label
End Class
