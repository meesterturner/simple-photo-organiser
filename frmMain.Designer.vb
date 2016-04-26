<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEXIF = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboPrecision = New System.Windows.Forms.ComboBox()
        Me.lblPrecision = New System.Windows.Forms.Label()
        Me.lblDest = New System.Windows.Forms.Label()
        Me.cmdDest = New System.Windows.Forms.Button()
        Me.txtDest = New System.Windows.Forms.TextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.cmdSource = New System.Windows.Forms.Button()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEXIF
        '
        Me.cmdEXIF.Location = New System.Drawing.Point(365, 302)
        Me.cmdEXIF.Name = "cmdEXIF"
        Me.cmdEXIF.Size = New System.Drawing.Size(102, 26)
        Me.cmdEXIF.TabIndex = 2
        Me.cmdEXIF.Text = "Organise!"
        Me.cmdEXIF.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.Location = New System.Drawing.Point(473, 302)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(102, 26)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPrecision)
        Me.GroupBox1.Controls.Add(Me.lblPrecision)
        Me.GroupBox1.Controls.Add(Me.lblDest)
        Me.GroupBox1.Controls.Add(Me.cmdDest)
        Me.GroupBox1.Controls.Add(Me.txtDest)
        Me.GroupBox1.Controls.Add(Me.lblSource)
        Me.GroupBox1.Controls.Add(Me.cmdSource)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 178)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Organising Options"
        '
        'cboPrecision
        '
        Me.cboPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrecision.FormattingEnabled = True
        Me.cboPrecision.Location = New System.Drawing.Point(31, 129)
        Me.cboPrecision.Name = "cboPrecision"
        Me.cboPrecision.Size = New System.Drawing.Size(147, 21)
        Me.cboPrecision.TabIndex = 17
        '
        'lblPrecision
        '
        Me.lblPrecision.AutoSize = True
        Me.lblPrecision.Location = New System.Drawing.Point(29, 113)
        Me.lblPrecision.Name = "lblPrecision"
        Me.lblPrecision.Size = New System.Drawing.Size(118, 13)
        Me.lblPrecision.TabIndex = 16
        Me.lblPrecision.Text = "Precision of Organising:"
        '
        'lblDest
        '
        Me.lblDest.AutoSize = True
        Me.lblDest.Location = New System.Drawing.Point(29, 74)
        Me.lblDest.Name = "lblDest"
        Me.lblDest.Size = New System.Drawing.Size(92, 13)
        Me.lblDest.TabIndex = 15
        Me.lblDest.Text = "Destination Folder"
        '
        'cmdDest
        '
        Me.cmdDest.Location = New System.Drawing.Point(490, 89)
        Me.cmdDest.Name = "cmdDest"
        Me.cmdDest.Size = New System.Drawing.Size(41, 21)
        Me.cmdDest.TabIndex = 14
        Me.cmdDest.Text = "..."
        Me.cmdDest.UseVisualStyleBackColor = True
        '
        'txtDest
        '
        Me.txtDest.Location = New System.Drawing.Point(32, 90)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(452, 20)
        Me.txtDest.TabIndex = 13
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(29, 28)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(73, 13)
        Me.lblSource.TabIndex = 12
        Me.lblSource.Text = "Source Folder"
        '
        'cmdSource
        '
        Me.cmdSource.Location = New System.Drawing.Point(490, 43)
        Me.cmdSource.Name = "cmdSource"
        Me.cmdSource.Size = New System.Drawing.Size(41, 21)
        Me.cmdSource.TabIndex = 11
        Me.cmdSource.Text = "..."
        Me.cmdSource.UseVisualStyleBackColor = True
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(32, 44)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(452, 20)
        Me.txtSource.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganiseToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OrganiseToolStripMenuItem
        '
        Me.OrganiseToolStripMenuItem.Name = "OrganiseToolStripMenuItem"
        Me.OrganiseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrganiseToolStripMenuItem.Text = "&Organise"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 79)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Progress"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 31)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 339)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdEXIF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Photo Organiser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEXIF As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboPrecision As ComboBox
    Friend WithEvents lblPrecision As Label
    Friend WithEvents lblDest As Label
    Friend WithEvents cmdDest As Button
    Friend WithEvents txtDest As TextBox
    Friend WithEvents lblSource As Label
    Friend WithEvents cmdSource As Button
    Friend WithEvents txtSource As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganiseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblStatus As Label
End Class
