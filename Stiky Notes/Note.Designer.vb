<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Note
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> '_
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
    '<System.Diagnostics.DebuggerStepThrough()> '_
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Note))
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tEna = New System.Windows.Forms.ToolStripMenuItem
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ForeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtMain = New System.Windows.Forms.TextBox
        Me.tb1 = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnl1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl1.BackColor = System.Drawing.Color.White
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.PictureBox3)
        Me.pnl1.Controls.Add(Me.PictureBox2)
        Me.pnl1.Controls.Add(Me.PictureBox1)
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(230, 25)
        Me.pnl1.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ContextMenuStrip = Me.cms
        Me.PictureBox3.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tEna, Me.AlwaysOnTopToolStripMenuItem, Me.ShowButtonToolStripMenuItem, Me.ToolStripSeparator1, Me.ForeColorToolStripMenuItem, Me.BackColorToolStripMenuItem, Me.FontToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem, Me.TestToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(155, 214)
        '
        'tEna
        '
        Me.tEna.Checked = True
        Me.tEna.CheckOnClick = True
        Me.tEna.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tEna.Name = "tEna"
        Me.tEna.Size = New System.Drawing.Size(154, 22)
        Me.tEna.Text = "Editable"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Checked = True
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always On Top"
        '
        'ShowButtonToolStripMenuItem
        '
        Me.ShowButtonToolStripMenuItem.Name = "ShowButtonToolStripMenuItem"
        Me.ShowButtonToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ShowButtonToolStripMenuItem.Text = "Show Button"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'ForeColorToolStripMenuItem
        '
        Me.ForeColorToolStripMenuItem.Name = "ForeColorToolStripMenuItem"
        Me.ForeColorToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ForeColorToolStripMenuItem.Text = "ForeColor"
        '
        'BackColorToolStripMenuItem
        '
        Me.BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        Me.BackColorToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.BackColorToolStripMenuItem.Text = "BackColor"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(151, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TestToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(183, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 17)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(210, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(14, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtMain
        '
        Me.txtMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMain.BackColor = System.Drawing.Color.Yellow
        Me.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMain.CausesValidation = False
        Me.txtMain.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMain.Location = New System.Drawing.Point(0, 24)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(230, 170)
        Me.txtMain.TabIndex = 3
        '
        'tb1
        '
        Me.tb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb1.BackColor = System.Drawing.Color.Lime
        Me.tb1.Location = New System.Drawing.Point(0, 200)
        Me.tb1.Maximum = 100
        Me.tb1.Minimum = 10
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(230, 45)
        Me.tb1.TabIndex = 4
        Me.tb1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tb1.Value = 75
        Me.tb1.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(209, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "m"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(15, 126)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" & _
            ""
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(15, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "^"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(0, 171)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(15, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "v"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Timer2
        '
        '
        'Note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(230, 230)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.txtMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Note"
        Me.Opacity = 0.75
        Me.ShowInTaskbar = False
        Me.Text = "Stiky Notes"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.pnl1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tEna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tb1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ShowButtonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
