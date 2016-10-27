<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Settings))
        Me.tc = New System.Windows.Forms.TabControl()
        Me.tc_general = New System.Windows.Forms.TabPage()
        Me.gb_updates = New System.Windows.Forms.GroupBox()
        Me.cb_AutoUpdate = New System.Windows.Forms.CheckBox()
        Me.tc_interface = New System.Windows.Forms.TabPage()
        Me.cb_language = New System.Windows.Forms.ComboBox()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.tc.SuspendLayout()
        Me.tc_general.SuspendLayout()
        Me.gb_updates.SuspendLayout()
        Me.tc_interface.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc
        '
        Me.tc.Controls.Add(Me.tc_general)
        Me.tc.Controls.Add(Me.tc_interface)
        Me.tc.Dock = System.Windows.Forms.DockStyle.Top
        Me.tc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.Location = New System.Drawing.Point(0, 0)
        Me.tc.Name = "tc"
        Me.tc.SelectedIndex = 0
        Me.tc.Size = New System.Drawing.Size(318, 299)
        Me.tc.TabIndex = 0
        '
        'tc_general
        '
        Me.tc_general.Controls.Add(Me.gb_updates)
        Me.tc_general.Location = New System.Drawing.Point(4, 26)
        Me.tc_general.Name = "tc_general"
        Me.tc_general.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_general.Size = New System.Drawing.Size(310, 269)
        Me.tc_general.TabIndex = 0
        Me.tc_general.Text = "General"
        Me.tc_general.UseVisualStyleBackColor = True
        '
        'gb_updates
        '
        Me.gb_updates.Controls.Add(Me.cb_AutoUpdate)
        Me.gb_updates.Location = New System.Drawing.Point(6, 6)
        Me.gb_updates.Name = "gb_updates"
        Me.gb_updates.Size = New System.Drawing.Size(298, 61)
        Me.gb_updates.TabIndex = 1
        Me.gb_updates.TabStop = False
        Me.gb_updates.Text = "Updates"
        '
        'cb_AutoUpdate
        '
        Me.cb_AutoUpdate.AutoSize = True
        Me.cb_AutoUpdate.Location = New System.Drawing.Point(6, 24)
        Me.cb_AutoUpdate.Name = "cb_AutoUpdate"
        Me.cb_AutoUpdate.Size = New System.Drawing.Size(141, 21)
        Me.cb_AutoUpdate.TabIndex = 0
        Me.cb_AutoUpdate.Text = "Updates on Startup"
        Me.cb_AutoUpdate.UseVisualStyleBackColor = True
        '
        'tc_interface
        '
        Me.tc_interface.Controls.Add(Me.cb_language)
        Me.tc_interface.Controls.Add(Me.lbl_language)
        Me.tc_interface.Location = New System.Drawing.Point(4, 26)
        Me.tc_interface.Name = "tc_interface"
        Me.tc_interface.Padding = New System.Windows.Forms.Padding(3)
        Me.tc_interface.Size = New System.Drawing.Size(310, 269)
        Me.tc_interface.TabIndex = 1
        Me.tc_interface.Text = "Interface"
        Me.tc_interface.UseVisualStyleBackColor = True
        '
        'cb_language
        '
        Me.cb_language.BackColor = System.Drawing.Color.White
        Me.cb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_language.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_language.FormattingEnabled = True
        Me.cb_language.Location = New System.Drawing.Point(8, 28)
        Me.cb_language.Name = "cb_language"
        Me.cb_language.Size = New System.Drawing.Size(294, 23)
        Me.cb_language.TabIndex = 1
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_language.Location = New System.Drawing.Point(3, 8)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(65, 17)
        Me.lbl_language.TabIndex = 0
        Me.lbl_language.Text = "Language"
        '
        'btn_ok
        '
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Location = New System.Drawing.Point(231, 305)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "btn_ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(150, 305)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "btn_cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'form_Settings
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 340)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.tc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_Settings"
        Me.tc.ResumeLayout(False)
        Me.tc_general.ResumeLayout(False)
        Me.gb_updates.ResumeLayout(False)
        Me.gb_updates.PerformLayout()
        Me.tc_interface.ResumeLayout(False)
        Me.tc_interface.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc As TabControl
    Friend WithEvents tc_general As TabPage
    Friend WithEvents tc_interface As TabPage
    Friend WithEvents cb_language As ComboBox
    Friend WithEvents lbl_language As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents cb_AutoUpdate As CheckBox
    Friend WithEvents gb_updates As GroupBox
End Class
