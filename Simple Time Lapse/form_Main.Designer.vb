<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.lbl_timeline = New System.Windows.Forms.Label()
        Me.lbl_preview = New System.Windows.Forms.Label()
        Me.dl_ImportPictures = New System.Windows.Forms.OpenFileDialog()
        Me.bw_Rendering = New System.ComponentModel.BackgroundWorker()
        Me.gb_PictureEdit = New System.Windows.Forms.GroupBox()
        Me.ms = New System.Windows.Forms.MenuStrip()
        Me.ms_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ms_file_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_about_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_about_update = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ms_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.bw_Importing = New System.ComponentModel.BackgroundWorker()
        Me.btn_MultiSelect = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_MoveDwn = New System.Windows.Forms.Button()
        Me.btn_MoveUp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_drop = New System.Windows.Forms.Button()
        Me.lbl_drop = New System.Windows.Forms.Label()
        Me.lb_pictures = New System.Windows.Forms.ListBox()
        Me.pb_preview = New System.Windows.Forms.PictureBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.ms_file_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_file_new_project = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_file_new_window = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_file_import = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_about_credits = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_about_settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_help_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_help_SupportUs = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_PictureEdit.SuspendLayout()
        Me.ms.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pb_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_timeline
        '
        Me.lbl_timeline.AutoSize = True
        Me.lbl_timeline.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lbl_timeline.ForeColor = System.Drawing.Color.White
        Me.lbl_timeline.Location = New System.Drawing.Point(7, 30)
        Me.lbl_timeline.Name = "lbl_timeline"
        Me.lbl_timeline.Size = New System.Drawing.Size(56, 17)
        Me.lbl_timeline.TabIndex = 5
        Me.lbl_timeline.Text = "Timeline"
        '
        'lbl_preview
        '
        Me.lbl_preview.AutoSize = True
        Me.lbl_preview.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lbl_preview.ForeColor = System.Drawing.Color.White
        Me.lbl_preview.Location = New System.Drawing.Point(177, 30)
        Me.lbl_preview.Name = "lbl_preview"
        Me.lbl_preview.Size = New System.Drawing.Size(52, 17)
        Me.lbl_preview.TabIndex = 6
        Me.lbl_preview.Text = "Preview"
        '
        'dl_ImportPictures
        '
        Me.dl_ImportPictures.FileName = "OpenFileDialog1"
        Me.dl_ImportPictures.Multiselect = True
        Me.dl_ImportPictures.Title = "Bilder auswählen..."
        '
        'bw_Rendering
        '
        Me.bw_Rendering.WorkerReportsProgress = True
        Me.bw_Rendering.WorkerSupportsCancellation = True
        '
        'gb_PictureEdit
        '
        Me.gb_PictureEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_PictureEdit.Controls.Add(Me.btn_MultiSelect)
        Me.gb_PictureEdit.Controls.Add(Me.btn_del)
        Me.gb_PictureEdit.Controls.Add(Me.btn_MoveDwn)
        Me.gb_PictureEdit.Controls.Add(Me.btn_MoveUp)
        Me.gb_PictureEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gb_PictureEdit.ForeColor = System.Drawing.Color.White
        Me.gb_PictureEdit.Location = New System.Drawing.Point(180, 504)
        Me.gb_PictureEdit.Name = "gb_PictureEdit"
        Me.gb_PictureEdit.Size = New System.Drawing.Size(668, 60)
        Me.gb_PictureEdit.TabIndex = 7
        Me.gb_PictureEdit.TabStop = False
        Me.gb_PictureEdit.Text = "Edit Picture"
        '
        'ms
        '
        Me.ms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_file, Me.ms_about, Me.ms_help})
        Me.ms.Location = New System.Drawing.Point(0, 0)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(984, 24)
        Me.ms.TabIndex = 8
        Me.ms.Text = "MenuStrip1"
        '
        'ms_file
        '
        Me.ms_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_file_new, Me.ms_file_import, Me.ToolStripSeparator2, Me.ms_file_exit})
        Me.ms_file.Name = "ms_file"
        Me.ms_file.Size = New System.Drawing.Size(37, 20)
        Me.ms_file.Text = "File"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(148, 6)
        '
        'ms_file_exit
        '
        Me.ms_file_exit.Name = "ms_file_exit"
        Me.ms_file_exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ms_file_exit.Size = New System.Drawing.Size(151, 22)
        Me.ms_file_exit.Text = "Exit"
        '
        'ms_about
        '
        Me.ms_about.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_about_about, Me.ms_about_credits, Me.ms_about_update, Me.ToolStripSeparator1, Me.ms_about_settings})
        Me.ms_about.Name = "ms_about"
        Me.ms_about.Size = New System.Drawing.Size(52, 20)
        Me.ms_about.Text = "About"
        '
        'ms_about_about
        '
        Me.ms_about_about.Name = "ms_about_about"
        Me.ms_about_about.Size = New System.Drawing.Size(158, 22)
        Me.ms_about_about.Text = "About"
        '
        'ms_about_update
        '
        Me.ms_about_update.Name = "ms_about_update"
        Me.ms_about_update.Size = New System.Drawing.Size(158, 22)
        Me.ms_about_update.Text = "Update"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'ms_help
        '
        Me.ms_help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_help_help, Me.ms_help_SupportUs})
        Me.ms_help.Name = "ms_help"
        Me.ms_help.Size = New System.Drawing.Size(44, 20)
        Me.ms_help.Text = "Help"
        '
        'bw_Importing
        '
        Me.bw_Importing.WorkerReportsProgress = True
        Me.bw_Importing.WorkerSupportsCancellation = True
        '
        'btn_MultiSelect
        '
        Me.btn_MultiSelect.AutoEllipsis = True
        Me.btn_MultiSelect.BackColor = System.Drawing.Color.Gray
        Me.btn_MultiSelect.Enabled = False
        Me.btn_MultiSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MultiSelect.Image = CType(resources.GetObject("btn_MultiSelect.Image"), System.Drawing.Image)
        Me.btn_MultiSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_MultiSelect.Location = New System.Drawing.Point(354, 18)
        Me.btn_MultiSelect.Name = "btn_MultiSelect"
        Me.btn_MultiSelect.Size = New System.Drawing.Size(115, 31)
        Me.btn_MultiSelect.TabIndex = 4
        Me.btn_MultiSelect.Text = "Multiselect"
        Me.btn_MultiSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MultiSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MultiSelect.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.AutoEllipsis = True
        Me.btn_del.BackColor = System.Drawing.Color.Gray
        Me.btn_del.Enabled = False
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(238, 18)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(110, 31)
        Me.btn_del.TabIndex = 2
        Me.btn_del.Text = "Delete"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_MoveDwn
        '
        Me.btn_MoveDwn.AutoEllipsis = True
        Me.btn_MoveDwn.BackColor = System.Drawing.Color.Gray
        Me.btn_MoveDwn.Enabled = False
        Me.btn_MoveDwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MoveDwn.Image = CType(resources.GetObject("btn_MoveDwn.Image"), System.Drawing.Image)
        Me.btn_MoveDwn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_MoveDwn.Location = New System.Drawing.Point(122, 18)
        Me.btn_MoveDwn.Name = "btn_MoveDwn"
        Me.btn_MoveDwn.Size = New System.Drawing.Size(110, 31)
        Me.btn_MoveDwn.TabIndex = 1
        Me.btn_MoveDwn.Text = "Move Down"
        Me.btn_MoveDwn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MoveDwn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MoveDwn.UseVisualStyleBackColor = False
        '
        'btn_MoveUp
        '
        Me.btn_MoveUp.AutoEllipsis = True
        Me.btn_MoveUp.BackColor = System.Drawing.Color.Gray
        Me.btn_MoveUp.Enabled = False
        Me.btn_MoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MoveUp.Image = CType(resources.GetObject("btn_MoveUp.Image"), System.Drawing.Image)
        Me.btn_MoveUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_MoveUp.Location = New System.Drawing.Point(6, 18)
        Me.btn_MoveUp.Name = "btn_MoveUp"
        Me.btn_MoveUp.Size = New System.Drawing.Size(110, 31)
        Me.btn_MoveUp.TabIndex = 0
        Me.btn_MoveUp.Text = "Move Up"
        Me.btn_MoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MoveUp.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lb_pictures)
        Me.Panel1.Location = New System.Drawing.Point(1, 46)
        Me.Panel1.MinimumSize = New System.Drawing.Size(175, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 523)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_drop)
        Me.Panel2.Controls.Add(Me.lbl_drop)
        Me.Panel2.Location = New System.Drawing.Point(9, 175)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 84)
        Me.Panel2.TabIndex = 4
        '
        'btn_drop
        '
        Me.btn_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_drop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_drop.ForeColor = System.Drawing.Color.White
        Me.btn_drop.Location = New System.Drawing.Point(31, 48)
        Me.btn_drop.Name = "btn_drop"
        Me.btn_drop.Size = New System.Drawing.Size(89, 27)
        Me.btn_drop.TabIndex = 3
        Me.btn_drop.Text = "Browse"
        Me.btn_drop.UseVisualStyleBackColor = True
        '
        'lbl_drop
        '
        Me.lbl_drop.AllowDrop = True
        Me.lbl_drop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_drop.ForeColor = System.Drawing.Color.White
        Me.lbl_drop.Location = New System.Drawing.Point(3, 2)
        Me.lbl_drop.Name = "lbl_drop"
        Me.lbl_drop.Size = New System.Drawing.Size(151, 43)
        Me.lbl_drop.TabIndex = 2
        Me.lbl_drop.Text = "Drop your Images here or browse for files"
        Me.lbl_drop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_pictures
        '
        Me.lb_pictures.AllowDrop = True
        Me.lb_pictures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_pictures.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_pictures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lb_pictures.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lb_pictures.ForeColor = System.Drawing.Color.White
        Me.lb_pictures.FormattingEnabled = True
        Me.lb_pictures.IntegralHeight = False
        Me.lb_pictures.ItemHeight = 17
        Me.lb_pictures.Location = New System.Drawing.Point(11, 10)
        Me.lb_pictures.Name = "lb_pictures"
        Me.lb_pictures.Size = New System.Drawing.Size(151, 497)
        Me.lb_pictures.TabIndex = 0
        '
        'pb_preview
        '
        Me.pb_preview.BackColor = System.Drawing.Color.Gray
        Me.pb_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_preview.Location = New System.Drawing.Point(180, 51)
        Me.pb_preview.Name = "pb_preview"
        Me.pb_preview.Size = New System.Drawing.Size(795, 447)
        Me.pb_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_preview.TabIndex = 2
        Me.pb_preview.TabStop = False
        '
        'btn_start
        '
        Me.btn_start.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_start.Enabled = False
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.White
        Me.btn_start.Image = CType(resources.GetObject("btn_start.Image"), System.Drawing.Image)
        Me.btn_start.Location = New System.Drawing.Point(854, 511)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(121, 52)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start"
        Me.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'ms_file_new
        '
        Me.ms_file_new.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_file_new_project, Me.ms_file_new_window})
        Me.ms_file_new.Image = CType(resources.GetObject("ms_file_new.Image"), System.Drawing.Image)
        Me.ms_file_new.Name = "ms_file_new"
        Me.ms_file_new.Size = New System.Drawing.Size(151, 22)
        Me.ms_file_new.Text = "New"
        '
        'ms_file_new_project
        '
        Me.ms_file_new_project.Image = CType(resources.GetObject("ms_file_new_project.Image"), System.Drawing.Image)
        Me.ms_file_new_project.Name = "ms_file_new_project"
        Me.ms_file_new_project.Size = New System.Drawing.Size(127, 22)
        Me.ms_file_new_project.Text = "Project..."
        '
        'ms_file_new_window
        '
        Me.ms_file_new_window.Image = CType(resources.GetObject("ms_file_new_window.Image"), System.Drawing.Image)
        Me.ms_file_new_window.Name = "ms_file_new_window"
        Me.ms_file_new_window.Size = New System.Drawing.Size(127, 22)
        Me.ms_file_new_window.Text = "Window..."
        '
        'ms_file_import
        '
        Me.ms_file_import.Image = CType(resources.GetObject("ms_file_import.Image"), System.Drawing.Image)
        Me.ms_file_import.Name = "ms_file_import"
        Me.ms_file_import.Size = New System.Drawing.Size(151, 22)
        Me.ms_file_import.Text = "Import Images"
        '
        'ms_about_credits
        '
        Me.ms_about_credits.Image = CType(resources.GetObject("ms_about_credits.Image"), System.Drawing.Image)
        Me.ms_about_credits.Name = "ms_about_credits"
        Me.ms_about_credits.Size = New System.Drawing.Size(158, 22)
        Me.ms_about_credits.Text = "Credits"
        '
        'ms_about_settings
        '
        Me.ms_about_settings.Image = CType(resources.GetObject("ms_about_settings.Image"), System.Drawing.Image)
        Me.ms_about_settings.Name = "ms_about_settings"
        Me.ms_about_settings.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ms_about_settings.Size = New System.Drawing.Size(158, 22)
        Me.ms_about_settings.Text = "Settings"
        '
        'ms_help_help
        '
        Me.ms_help_help.Image = CType(resources.GetObject("ms_help_help.Image"), System.Drawing.Image)
        Me.ms_help_help.Name = "ms_help_help"
        Me.ms_help_help.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ms_help_help.Size = New System.Drawing.Size(132, 22)
        Me.ms_help_help.Text = "Help"
        '
        'ms_help_SupportUs
        '
        Me.ms_help_SupportUs.Image = CType(resources.GetObject("ms_help_SupportUs.Image"), System.Drawing.Image)
        Me.ms_help_SupportUs.Name = "ms_help_SupportUs"
        Me.ms_help_SupportUs.Size = New System.Drawing.Size(132, 22)
        Me.ms_help_SupportUs.Text = "Support Us"
        '
        'form_main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 576)
        Me.Controls.Add(Me.gb_PictureEdit)
        Me.Controls.Add(Me.lbl_preview)
        Me.Controls.Add(Me.lbl_timeline)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pb_preview)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.ms)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ms
        Me.MinimumSize = New System.Drawing.Size(1000, 615)
        Me.Name = "form_main"
        Me.Text = "Simple Time Lapse"
        Me.gb_PictureEdit.ResumeLayout(False)
        Me.ms.ResumeLayout(False)
        Me.ms.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pb_preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents lb_pictures As ListBox
    Friend WithEvents pb_preview As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_drop As Label
    Friend WithEvents btn_drop As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_timeline As Label
    Friend WithEvents lbl_preview As Label
    Friend WithEvents dl_ImportPictures As OpenFileDialog
    Friend WithEvents bw_Rendering As System.ComponentModel.BackgroundWorker
    Friend WithEvents gb_PictureEdit As GroupBox
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_MoveDwn As Button
    Friend WithEvents btn_MoveUp As Button
    Friend WithEvents ms As MenuStrip
    Friend WithEvents ms_about As ToolStripMenuItem
    Friend WithEvents ms_about_settings As ToolStripMenuItem
    Friend WithEvents btn_MultiSelect As Button
    Friend WithEvents ms_about_update As ToolStripMenuItem
    Friend WithEvents ms_about_credits As ToolStripMenuItem
    Friend WithEvents bw_Importing As System.ComponentModel.BackgroundWorker
    Friend WithEvents ms_file As ToolStripMenuItem
    Friend WithEvents ms_help As ToolStripMenuItem
    Friend WithEvents ms_about_about As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ms_file_new As ToolStripMenuItem
    Friend WithEvents ms_file_import As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ms_file_exit As ToolStripMenuItem
    Friend WithEvents ms_file_new_project As ToolStripMenuItem
    Friend WithEvents ms_file_new_window As ToolStripMenuItem
    Friend WithEvents ms_help_help As ToolStripMenuItem
    Friend WithEvents ms_help_SupportUs As ToolStripMenuItem
End Class
