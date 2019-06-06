<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Settings))
        Me.gb_keys = New System.Windows.Forms.GroupBox()
        Me.cb_MoveImg = New System.Windows.Forms.ComboBox()
        Me.lbl_MoveImg = New System.Windows.Forms.Label()
        Me.cb_AutoUpdate = New System.Windows.Forms.CheckBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cb_language = New System.Windows.Forms.ComboBox()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.gb_general = New System.Windows.Forms.GroupBox()
        Me.lbl_updates = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.gb_keys.SuspendLayout()
        Me.gb_general.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_keys
        '
        Me.gb_keys.Controls.Add(Me.cb_MoveImg)
        Me.gb_keys.Controls.Add(Me.lbl_MoveImg)
        Me.gb_keys.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_keys.ForeColor = System.Drawing.Color.White
        Me.gb_keys.Location = New System.Drawing.Point(12, 150)
        Me.gb_keys.Name = "gb_keys"
        Me.gb_keys.Size = New System.Drawing.Size(298, 87)
        Me.gb_keys.TabIndex = 2
        Me.gb_keys.TabStop = False
        Me.gb_keys.Text = "Key Assignment"
        '
        'cb_MoveImg
        '
        Me.cb_MoveImg.BackColor = System.Drawing.Color.Gray
        Me.cb_MoveImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_MoveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_MoveImg.ForeColor = System.Drawing.Color.White
        Me.cb_MoveImg.FormattingEnabled = True
        Me.cb_MoveImg.Location = New System.Drawing.Point(9, 45)
        Me.cb_MoveImg.Name = "cb_MoveImg"
        Me.cb_MoveImg.Size = New System.Drawing.Size(148, 23)
        Me.cb_MoveImg.TabIndex = 1
        '
        'lbl_MoveImg
        '
        Me.lbl_MoveImg.AutoSize = True
        Me.lbl_MoveImg.Location = New System.Drawing.Point(6, 25)
        Me.lbl_MoveImg.Name = "lbl_MoveImg"
        Me.lbl_MoveImg.Size = New System.Drawing.Size(151, 15)
        Me.lbl_MoveImg.TabIndex = 0
        Me.lbl_MoveImg.Text = "Move images up and down"
        '
        'cb_AutoUpdate
        '
        Me.cb_AutoUpdate.AutoSize = True
        Me.cb_AutoUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_AutoUpdate.ForeColor = System.Drawing.Color.White
        Me.cb_AutoUpdate.Location = New System.Drawing.Point(19, 100)
        Me.cb_AutoUpdate.Name = "cb_AutoUpdate"
        Me.cb_AutoUpdate.Size = New System.Drawing.Size(127, 19)
        Me.cb_AutoUpdate.TabIndex = 0
        Me.cb_AutoUpdate.Text = "Updates on Startup"
        Me.cb_AutoUpdate.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Gray
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Location = New System.Drawing.Point(231, 267)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "btn_ok"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Gray
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(150, 267)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "btn_cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'cb_language
        '
        Me.cb_language.BackColor = System.Drawing.Color.Gray
        Me.cb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_language.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_language.ForeColor = System.Drawing.Color.White
        Me.cb_language.FormattingEnabled = True
        Me.cb_language.Location = New System.Drawing.Point(19, 43)
        Me.cb_language.Name = "cb_language"
        Me.cb_language.Size = New System.Drawing.Size(148, 23)
        Me.cb_language.TabIndex = 4
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_language.ForeColor = System.Drawing.Color.White
        Me.lbl_language.Location = New System.Drawing.Point(6, 24)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(59, 15)
        Me.lbl_language.TabIndex = 3
        Me.lbl_language.Text = "Language"
        '
        'gb_general
        '
        Me.gb_general.Controls.Add(Me.lbl_updates)
        Me.gb_general.Controls.Add(Me.cb_language)
        Me.gb_general.Controls.Add(Me.cb_AutoUpdate)
        Me.gb_general.Controls.Add(Me.lbl_language)
        Me.gb_general.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_general.ForeColor = System.Drawing.Color.White
        Me.gb_general.Location = New System.Drawing.Point(12, 12)
        Me.gb_general.Name = "gb_general"
        Me.gb_general.Size = New System.Drawing.Size(294, 132)
        Me.gb_general.TabIndex = 5
        Me.gb_general.TabStop = False
        Me.gb_general.Text = "General"
        '
        'lbl_updates
        '
        Me.lbl_updates.AutoSize = True
        Me.lbl_updates.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_updates.ForeColor = System.Drawing.Color.White
        Me.lbl_updates.Location = New System.Drawing.Point(6, 82)
        Me.lbl_updates.Name = "lbl_updates"
        Me.lbl_updates.Size = New System.Drawing.Size(50, 15)
        Me.lbl_updates.TabIndex = 5
        Me.lbl_updates.Text = "Updates"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Gray
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl.Location = New System.Drawing.Point(0, 260)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(318, 37)
        Me.pnl.TabIndex = 6
        '
        'form_Settings
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(318, 297)
        Me.Controls.Add(Me.gb_general)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.gb_keys)
        Me.Controls.Add(Me.pnl)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_Settings"
        Me.gb_keys.ResumeLayout(False)
        Me.gb_keys.PerformLayout()
        Me.gb_general.ResumeLayout(False)
        Me.gb_general.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents cb_AutoUpdate As CheckBox
    Friend WithEvents gb_keys As GroupBox
    Friend WithEvents cb_MoveImg As ComboBox
    Friend WithEvents lbl_MoveImg As Label
    Friend WithEvents cb_language As ComboBox
    Friend WithEvents lbl_language As Label
    Friend WithEvents gb_general As GroupBox
    Friend WithEvents lbl_updates As Label
    Friend WithEvents pnl As Panel
End Class
