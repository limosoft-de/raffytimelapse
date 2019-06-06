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
        Me.llbl_mail = New System.Windows.Forms.LinkLabel()
        Me.gb_support = New System.Windows.Forms.GroupBox()
        Me.lbl_support = New System.Windows.Forms.Label()
        Me.llbl_support = New System.Windows.Forms.LinkLabel()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.gb_wiki = New System.Windows.Forms.GroupBox()
        Me.llbl_wiki = New System.Windows.Forms.LinkLabel()
        Me.lbl_wiki = New System.Windows.Forms.Label()
        Me.gb_contact.SuspendLayout()
        Me.gb_support.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.gb_wiki.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_contact
        '
        Me.gb_contact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_contact.Controls.Add(Me.lbl_contact)
        Me.gb_contact.Controls.Add(Me.llbl_mail)
        Me.gb_contact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_contact.ForeColor = System.Drawing.Color.White
        Me.gb_contact.Location = New System.Drawing.Point(12, 266)
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
        'llbl_mail
        '
        Me.llbl_mail.ActiveLinkColor = System.Drawing.Color.White
        Me.llbl_mail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llbl_mail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_mail.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llbl_mail.Location = New System.Drawing.Point(7, 48)
        Me.llbl_mail.Name = "llbl_mail"
        Me.llbl_mail.Size = New System.Drawing.Size(303, 32)
        Me.llbl_mail.TabIndex = 10
        Me.llbl_mail.TabStop = True
        Me.llbl_mail.Text = "limosoft@gmx.de"
        Me.llbl_mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_support
        '
        Me.gb_support.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_support.Controls.Add(Me.lbl_support)
        Me.gb_support.Controls.Add(Me.llbl_support)
        Me.gb_support.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_support.ForeColor = System.Drawing.Color.White
        Me.gb_support.Location = New System.Drawing.Point(12, 104)
        Me.gb_support.Name = "gb_support"
        Me.gb_support.Size = New System.Drawing.Size(315, 156)
        Me.gb_support.TabIndex = 1
        Me.gb_support.TabStop = False
        Me.gb_support.Text = "Online Support"
        '
        'lbl_support
        '
        Me.lbl_support.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_support.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_support.Location = New System.Drawing.Point(6, 18)
        Me.lbl_support.Name = "lbl_support"
        Me.lbl_support.Size = New System.Drawing.Size(303, 98)
        Me.lbl_support.TabIndex = 0
        Me.lbl_support.Text = resources.GetString("lbl_support.Text")
        '
        'llbl_support
        '
        Me.llbl_support.ActiveLinkColor = System.Drawing.Color.White
        Me.llbl_support.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llbl_support.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_support.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llbl_support.Location = New System.Drawing.Point(6, 111)
        Me.llbl_support.Name = "llbl_support"
        Me.llbl_support.Size = New System.Drawing.Size(303, 32)
        Me.llbl_support.TabIndex = 9
        Me.llbl_support.TabStop = True
        Me.llbl_support.Text = "Create a ticket"
        Me.llbl_support.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnl.Location = New System.Drawing.Point(0, 371)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(339, 37)
        Me.pnl.TabIndex = 2
        '
        'gb_wiki
        '
        Me.gb_wiki.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_wiki.Controls.Add(Me.llbl_wiki)
        Me.gb_wiki.Controls.Add(Me.lbl_wiki)
        Me.gb_wiki.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_wiki.ForeColor = System.Drawing.Color.White
        Me.gb_wiki.Location = New System.Drawing.Point(12, 12)
        Me.gb_wiki.Name = "gb_wiki"
        Me.gb_wiki.Size = New System.Drawing.Size(315, 86)
        Me.gb_wiki.TabIndex = 10
        Me.gb_wiki.TabStop = False
        Me.gb_wiki.Text = "Online Support"
        '
        'llbl_wiki
        '
        Me.llbl_wiki.ActiveLinkColor = System.Drawing.Color.White
        Me.llbl_wiki.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llbl_wiki.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_wiki.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.llbl_wiki.Location = New System.Drawing.Point(7, 46)
        Me.llbl_wiki.Name = "llbl_wiki"
        Me.llbl_wiki.Size = New System.Drawing.Size(303, 32)
        Me.llbl_wiki.TabIndex = 9
        Me.llbl_wiki.TabStop = True
        Me.llbl_wiki.Text = "Raffy Timelapse Wiki"
        Me.llbl_wiki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_wiki
        '
        Me.lbl_wiki.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_wiki.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wiki.Location = New System.Drawing.Point(6, 19)
        Me.lbl_wiki.Name = "lbl_wiki"
        Me.lbl_wiki.Size = New System.Drawing.Size(303, 37)
        Me.lbl_wiki.TabIndex = 0
        Me.lbl_wiki.Text = "Learn how to get started with Raffy Timelapse in our online Wiki."
        '
        'form_help
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 408)
        Me.Controls.Add(Me.gb_wiki)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.gb_support)
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
        Me.gb_support.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.gb_wiki.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_contact As GroupBox
    Friend WithEvents gb_support As GroupBox
    Friend WithEvents lbl_support As Label
    Friend WithEvents llbl_support As LinkLabel
    Friend WithEvents btn_ok As Button
    Friend WithEvents pnl As Panel
    Friend WithEvents lbl_contact As Label
    Friend WithEvents llbl_mail As LinkLabel
    Friend WithEvents gb_wiki As GroupBox
    Friend WithEvents llbl_wiki As LinkLabel
    Friend WithEvents lbl_wiki As Label
End Class
