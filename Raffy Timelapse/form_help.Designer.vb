<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_help))
        Me.gb_contact = New System.Windows.Forms.GroupBox()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.lbl_mail = New System.Windows.Forms.LinkLabel()
        Me.gb_online = New System.Windows.Forms.GroupBox()
        Me.lbl_online = New System.Windows.Forms.Label()
        Me.lbl_head_general = New System.Windows.Forms.LinkLabel()
        Me.lbl_desc_general = New System.Windows.Forms.Label()
        Me.lbl_head_feature = New System.Windows.Forms.LinkLabel()
        Me.lbl_desc_feature = New System.Windows.Forms.Label()
        Me.lbl_head_bugs = New System.Windows.Forms.LinkLabel()
        Me.lbl_desc_bugs = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.gb_contact.SuspendLayout()
        Me.gb_online.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_contact
        '
        Me.gb_contact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_contact.Controls.Add(Me.lbl_contact)
        Me.gb_contact.Controls.Add(Me.lbl_mail)
        Me.gb_contact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_contact.ForeColor = System.Drawing.Color.White
        Me.gb_contact.Location = New System.Drawing.Point(12, 297)
        Me.gb_contact.Name = "gb_contact"
        Me.gb_contact.Size = New System.Drawing.Size(315, 89)
        Me.gb_contact.TabIndex = 0
        Me.gb_contact.TabStop = False
        Me.gb_contact.Text = "Direct Contact"
        '
        'lbl_contact
        '
        Me.lbl_contact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_contact.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact.Location = New System.Drawing.Point(7, 19)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(303, 32)
        Me.lbl_contact.TabIndex = 10
        Me.lbl_contact.Text = "Please only contact us via mail if the ticket system doesn't meet your request re" &
    "quirements."
        '
        'lbl_mail
        '
        Me.lbl_mail.ActiveLinkColor = System.Drawing.Color.White
        Me.lbl_mail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_mail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mail.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_mail.Location = New System.Drawing.Point(7, 48)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(303, 32)
        Me.lbl_mail.TabIndex = 10
        Me.lbl_mail.TabStop = True
        Me.lbl_mail.Text = "limosoft@users.sourceforge.net"
        Me.lbl_mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_online
        '
        Me.gb_online.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_online.Controls.Add(Me.lbl_online)
        Me.gb_online.Controls.Add(Me.lbl_head_general)
        Me.gb_online.Controls.Add(Me.lbl_desc_general)
        Me.gb_online.Controls.Add(Me.lbl_head_feature)
        Me.gb_online.Controls.Add(Me.lbl_desc_feature)
        Me.gb_online.Controls.Add(Me.lbl_head_bugs)
        Me.gb_online.Controls.Add(Me.lbl_desc_bugs)
        Me.gb_online.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_online.ForeColor = System.Drawing.Color.White
        Me.gb_online.Location = New System.Drawing.Point(12, 12)
        Me.gb_online.Name = "gb_online"
        Me.gb_online.Size = New System.Drawing.Size(315, 276)
        Me.gb_online.TabIndex = 1
        Me.gb_online.TabStop = False
        Me.gb_online.Text = "Online Support"
        '
        'lbl_online
        '
        Me.lbl_online.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_online.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_online.Location = New System.Drawing.Point(6, 18)
        Me.lbl_online.Name = "lbl_online"
        Me.lbl_online.Size = New System.Drawing.Size(303, 58)
        Me.lbl_online.TabIndex = 0
        Me.lbl_online.Text = "The preferred way to get support for 'Simplapse' is to create a ticket online on " &
    "sourceforge.net. We have different ticket systems for different requirements:"
        '
        'lbl_head_general
        '
        Me.lbl_head_general.ActiveLinkColor = System.Drawing.Color.White
        Me.lbl_head_general.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_head_general.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head_general.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_head_general.Location = New System.Drawing.Point(6, 202)
        Me.lbl_head_general.Name = "lbl_head_general"
        Me.lbl_head_general.Size = New System.Drawing.Size(303, 32)
        Me.lbl_head_general.TabIndex = 9
        Me.lbl_head_general.TabStop = True
        Me.lbl_head_general.Text = "General Requests"
        Me.lbl_head_general.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_desc_general
        '
        Me.lbl_desc_general.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_desc_general.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_general.Location = New System.Drawing.Point(6, 234)
        Me.lbl_desc_general.Name = "lbl_desc_general"
        Me.lbl_desc_general.Size = New System.Drawing.Size(303, 31)
        Me.lbl_desc_general.TabIndex = 8
        Me.lbl_desc_general.Text = "If you have a request that doesn't fit in the other categories, create a ticket i" &
    "n this area."
        Me.lbl_desc_general.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_head_feature
        '
        Me.lbl_head_feature.ActiveLinkColor = System.Drawing.Color.White
        Me.lbl_head_feature.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_head_feature.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head_feature.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_head_feature.Location = New System.Drawing.Point(6, 137)
        Me.lbl_head_feature.Name = "lbl_head_feature"
        Me.lbl_head_feature.Size = New System.Drawing.Size(303, 32)
        Me.lbl_head_feature.TabIndex = 7
        Me.lbl_head_feature.TabStop = True
        Me.lbl_head_feature.Text = "Feature Requests"
        Me.lbl_head_feature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_desc_feature
        '
        Me.lbl_desc_feature.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_desc_feature.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_feature.Location = New System.Drawing.Point(6, 169)
        Me.lbl_desc_feature.Name = "lbl_desc_feature"
        Me.lbl_desc_feature.Size = New System.Drawing.Size(303, 33)
        Me.lbl_desc_feature.TabIndex = 6
        Me.lbl_desc_feature.Text = "If you have a feature request, please submit it right here."
        Me.lbl_desc_feature.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_head_bugs
        '
        Me.lbl_head_bugs.ActiveLinkColor = System.Drawing.Color.White
        Me.lbl_head_bugs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_head_bugs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head_bugs.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_head_bugs.Location = New System.Drawing.Point(6, 73)
        Me.lbl_head_bugs.Name = "lbl_head_bugs"
        Me.lbl_head_bugs.Size = New System.Drawing.Size(303, 32)
        Me.lbl_head_bugs.TabIndex = 5
        Me.lbl_head_bugs.TabStop = True
        Me.lbl_head_bugs.Text = "Bugs"
        Me.lbl_head_bugs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_desc_bugs
        '
        Me.lbl_desc_bugs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_desc_bugs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_bugs.Location = New System.Drawing.Point(6, 105)
        Me.lbl_desc_bugs.Name = "lbl_desc_bugs"
        Me.lbl_desc_bugs.Size = New System.Drawing.Size(303, 32)
        Me.lbl_desc_bugs.TabIndex = 1
        Me.lbl_desc_bugs.Text = "If you found a bug in the software, please submit a ticket."
        Me.lbl_desc_bugs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_ok
        '
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Location = New System.Drawing.Point(252, 7)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Gray
        Me.pnl.Controls.Add(Me.btn_ok)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl.Location = New System.Drawing.Point(0, 392)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(339, 37)
        Me.pnl.TabIndex = 2
        '
        'form_help
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 429)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.gb_online)
        Me.Controls.Add(Me.gb_contact)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_help"
        Me.gb_contact.ResumeLayout(False)
        Me.gb_online.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_contact As GroupBox
    Friend WithEvents gb_online As GroupBox
    Friend WithEvents lbl_head_bugs As LinkLabel
    Friend WithEvents lbl_desc_bugs As Label
    Friend WithEvents lbl_online As Label
    Friend WithEvents lbl_head_general As LinkLabel
    Friend WithEvents lbl_desc_general As Label
    Friend WithEvents lbl_head_feature As LinkLabel
    Friend WithEvents lbl_desc_feature As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents pnl As Panel
    Friend WithEvents lbl_contact As Label
    Friend WithEvents lbl_mail As LinkLabel
End Class
