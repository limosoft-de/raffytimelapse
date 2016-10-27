<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_participation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_participation))
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_head = New System.Windows.Forms.Label()
        Me.lbl_link = New System.Windows.Forms.LinkLabel()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_desc
        '
        Me.lbl_desc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.Location = New System.Drawing.Point(16, 39)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(263, 141)
        Me.lbl_desc.TabIndex = 0
        Me.lbl_desc.Text = resources.GetString("lbl_desc.Text")
        Me.lbl_desc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_head
        '
        Me.lbl_head.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head.Location = New System.Drawing.Point(12, 9)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(267, 23)
        Me.lbl_head.TabIndex = 1
        Me.lbl_head.Text = "Translate the App"
        Me.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_link
        '
        Me.lbl_link.ActiveLinkColor = System.Drawing.Color.White
        Me.lbl_link.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_link.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_link.Location = New System.Drawing.Point(12, 179)
        Me.lbl_link.Name = "lbl_link"
        Me.lbl_link.Size = New System.Drawing.Size(267, 23)
        Me.lbl_link.TabIndex = 2
        Me.lbl_link.TabStop = True
        Me.lbl_link.Text = "Translate Now!"
        Me.lbl_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_link.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'btn_ok
        '
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Location = New System.Drawing.Point(204, 7)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 3
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.Gray
        Me.pnl.Controls.Add(Me.btn_ok)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl.Location = New System.Drawing.Point(0, 219)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(291, 37)
        Me.pnl.TabIndex = 4
        '
        'form_participation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(291, 256)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.lbl_link)
        Me.Controls.Add(Me.lbl_head)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_participation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_participation"
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_desc As Label
    Friend WithEvents lbl_head As Label
    Friend WithEvents lbl_link As LinkLabel
    Friend WithEvents btn_ok As Button
    Friend WithEvents pnl As Panel
End Class
