<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Credits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Credits))
        Me.lbl_icons_head = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.lbl_icons_desc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_ffmpeg_desc = New System.Windows.Forms.Label()
        Me.lbl_ffmpeg_head = New System.Windows.Forms.Label()
        Me.lbl_translators_desc = New System.Windows.Forms.Label()
        Me.lbl_translators_head = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_icons_head
        '
        Me.lbl_icons_head.AutoSize = True
        Me.lbl_icons_head.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_icons_head.ForeColor = System.Drawing.Color.White
        Me.lbl_icons_head.Location = New System.Drawing.Point(9, 120)
        Me.lbl_icons_head.Name = "lbl_icons_head"
        Me.lbl_icons_head.Size = New System.Drawing.Size(65, 21)
        Me.lbl_icons_head.TabIndex = 0
        Me.lbl_icons_head.Text = "UI Icons"
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Location = New System.Drawing.Point(226, 7)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "btn_ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'lbl_icons_desc
        '
        Me.lbl_icons_desc.BackColor = System.Drawing.Color.Gray
        Me.lbl_icons_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_icons_desc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_icons_desc.Location = New System.Drawing.Point(10, 150)
        Me.lbl_icons_desc.Name = "lbl_icons_desc"
        Me.lbl_icons_desc.Size = New System.Drawing.Size(290, 60)
        Me.lbl_icons_desc.TabIndex = 3
        Me.lbl_icons_desc.Text = "Lucy G." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Free Basic UI Elements" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "www.flaticon.com/packs/free-basic-ui-elements"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 342)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 36)
        Me.Panel1.TabIndex = 4
        '
        'lbl_ffmpeg_desc
        '
        Me.lbl_ffmpeg_desc.BackColor = System.Drawing.Color.Gray
        Me.lbl_ffmpeg_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_ffmpeg_desc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ffmpeg_desc.Location = New System.Drawing.Point(10, 40)
        Me.lbl_ffmpeg_desc.Name = "lbl_ffmpeg_desc"
        Me.lbl_ffmpeg_desc.Size = New System.Drawing.Size(290, 60)
        Me.lbl_ffmpeg_desc.TabIndex = 5
        Me.lbl_ffmpeg_desc.Text = "This software uses libraries from the FFmpeg project under the LGPLv2.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "www.ffmp" &
    "eg.org/"
        '
        'lbl_ffmpeg_head
        '
        Me.lbl_ffmpeg_head.AutoSize = True
        Me.lbl_ffmpeg_head.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ffmpeg_head.ForeColor = System.Drawing.Color.White
        Me.lbl_ffmpeg_head.Location = New System.Drawing.Point(9, 10)
        Me.lbl_ffmpeg_head.Name = "lbl_ffmpeg_head"
        Me.lbl_ffmpeg_head.Size = New System.Drawing.Size(66, 21)
        Me.lbl_ffmpeg_head.TabIndex = 6
        Me.lbl_ffmpeg_head.Text = "FFmpeg"
        '
        'lbl_translators_desc
        '
        Me.lbl_translators_desc.BackColor = System.Drawing.Color.Gray
        Me.lbl_translators_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_translators_desc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_translators_desc.Location = New System.Drawing.Point(10, 260)
        Me.lbl_translators_desc.Name = "lbl_translators_desc"
        Me.lbl_translators_desc.Size = New System.Drawing.Size(290, 60)
        Me.lbl_translators_desc.TabIndex = 8
        Me.lbl_translators_desc.Text = "Portuguese translations by: Arménio Barão"
        '
        'lbl_translators_head
        '
        Me.lbl_translators_head.AutoSize = True
        Me.lbl_translators_head.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_translators_head.ForeColor = System.Drawing.Color.White
        Me.lbl_translators_head.Location = New System.Drawing.Point(9, 230)
        Me.lbl_translators_head.Name = "lbl_translators_head"
        Me.lbl_translators_head.Size = New System.Drawing.Size(86, 21)
        Me.lbl_translators_head.TabIndex = 7
        Me.lbl_translators_head.Text = "Translators"
        '
        'form_Credits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(313, 378)
        Me.Controls.Add(Me.lbl_translators_desc)
        Me.Controls.Add(Me.lbl_translators_head)
        Me.Controls.Add(Me.lbl_ffmpeg_head)
        Me.Controls.Add(Me.lbl_ffmpeg_desc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_icons_desc)
        Me.Controls.Add(Me.lbl_icons_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Credits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_Credits"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_icons_head As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents lbl_icons_desc As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_ffmpeg_desc As Label
    Friend WithEvents lbl_ffmpeg_head As Label
    Friend WithEvents lbl_translators_desc As Label
    Friend WithEvents lbl_translators_head As Label
End Class
