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
        Me.cb_fps.Location = New System.Drawing.Point(225, 79)
        Me.cb_fps.Name = "cb_fps"
        Me.cb_fps.Size = New System.Drawing.Size(200, 21)
        Me.cb_fps.TabIndex = 0
        '
        'lbl_SaveTo
        '
        Me.lbl_SaveTo.AutoSize = True
        Me.lbl_SaveTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaveTo.ForeColor = System.Drawing.Color.White
        Me.lbl_SaveTo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_SaveTo.Name = "lbl_SaveTo"
        Me.lbl_SaveTo.Size = New System.Drawing.Size(53, 13)
        Me.lbl_SaveTo.TabIndex = 1
        Me.lbl_SaveTo.Text = "Save to..."
        '
        'lbl_fps
        '
        Me.lbl_fps.AutoSize = True
        Me.lbl_fps.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fps.ForeColor = System.Drawing.Color.White
        Me.lbl_fps.Location = New System.Drawing.Point(222, 63)
        Me.lbl_fps.Name = "lbl_fps"
        Me.lbl_fps.Size = New System.Drawing.Size(131, 13)
        Me.lbl_fps.TabIndex = 2
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
        Me.tb_destination.TabIndex = 3
        '
        'lbl_resolution
        '
        Me.lbl_resolution.AutoSize = True
        Me.lbl_resolution.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resolution.ForeColor = System.Drawing.Color.White
        Me.lbl_resolution.Location = New System.Drawing.Point(12, 63)
        Me.lbl_resolution.Name = "lbl_resolution"
        Me.lbl_resolution.Size = New System.Drawing.Size(63, 13)
        Me.lbl_resolution.TabIndex = 5
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
        Me.cb_res.Size = New System.Drawing.Size(200, 21)
        Me.cb_res.TabIndex = 4
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(350, 169)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 6
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
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "Abbrechen"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(350, 27)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse.TabIndex = 8
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
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
        Me.lbl_quality.TabIndex = 9
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
        Me.cb_quality.TabIndex = 13
        '
        'form_ProjectSettings
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(434, 202)
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
End Class
