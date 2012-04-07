''programmers :
'' Muhammad al-Syrwan 
'' Muhammad Al-jebory
'' Muhammad Yamman Al-Turh
'' see other details in about box


'' this program is presented as opensource program.
'' the main programmers of this Code are not responsible of the content of this prograqm or the use of it.

''هذا البرنامج مفتوح المصدر 
''المبرمجون الرئيسيون المذكورون أعلاه غير مسؤولين عن المحتوى البرمجي او أي استخدام له


Public Class Note
    Private mClicked As Boolean = False
    Private BPoint As Point
    Private Deleted As Boolean = False
    Private WithEvents tm As New Timer
    Private tminc As Double
    Public tmopacity As Double
    Private leaving As Boolean = False
    Private firstmove As Boolean = False
    Public IsHide As Boolean = False
    Public UpClick As Boolean = False
    Public Wid, Hei As Integer

#Region "MoveNote"
    Private Sub pnl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnl1.MouseDown
        mClicked = True
        BPoint = Me.PointToClient(MousePosition)
    End Sub

    Private Sub pnl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnl1.MouseMove
        If mClicked Then
            Me.Location = MousePosition - BPoint
        End If

    End Sub

    Private Sub pnl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnl1.MouseUp
        mClicked = False
    End Sub
#End Region

#Region "Properties"
    Public Property Content() As String
        Get
            Return Me.txtMain.Text
        End Get
        Set(ByVal value As String)
            txtMain.Text = value
        End Set
    End Property
    Public Property ContentFont() As Font
        Get
            Return Me.txtMain.Font
        End Get
        Set(ByVal value As Font)
            Me.txtMain.Font = value
        End Set
    End Property
    Public Property ContentFore() As Color
        Get
            Return Me.txtMain.ForeColor
        End Get
        Set(ByVal value As Color)
            Me.txtMain.ForeColor = value
        End Set
    End Property
    Public Property ContentBack() As Color
        Get
            Return Me.txtMain.BackColor
        End Get
        Set(ByVal value As Color)
            Me.txtMain.BackColor = value
            'tb1.BackColor = value
            Label2.BackColor = value
        End Set
    End Property
#End Region

#Region "Color and Font"
    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackColorToolStripMenuItem.Click, ForeColorToolStripMenuItem.Click
        Dim cd As New ColorDialog
        If sender Is ForeColorToolStripMenuItem Then
            cd.Color = txtMain.ForeColor
        Else
            cd.Color = txtMain.BackColor
        End If

        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If sender.text = "BackColor" Then
                Me.ContentBack = cd.Color
            Else
                Me.ContentFore = cd.Color
            End If

        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click

        Dim fd As New FontDialog
        fd.Font = Me.txtMain.Font
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtMain.Font = fd.Font
        End If

    End Sub

#End Region

#Region "Saving"
    Private Sub lblNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        My.Application.CreateNote().Show()
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Deleted = True
        My.Application.RemoveNote(Me)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub





    Private Sub Note_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Deleted Then My.Application.save()
    End Sub
#End Region

#Region "Interface"
    Private Sub tEna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tEna.Click
        txtMain.ReadOnly = Not tEna.Checked
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'cms.Show(Label1, Label1.Location)
        tb1.Visible = Not tb1.Visible
        'Label2.Top = Label2.Top + tb1.Height
    End Sub
    Private Sub AlwaysOnTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = sender.checked
    End Sub
    Private Sub tb1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb1.Scroll
        tmopacity = tb1.Value / 100
        Me.Opacity = tmopacity

    End Sub
    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        My.Application.save()
    End Sub
#End Region

#Region "Resizing"

    Private Sub Label2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        Me.mClicked = True
        Me.ResizeRedraw = True
        Wid = Me.Width
        Hei = Me.Height
    End Sub

    Private Sub Label2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseUp
        Me.mClicked = False
        Me.firstmove = False
        If Me.Width < 125 Or Me.Height < 125 Then
            'Me.Width = 130
            'Me.Height = 130
            Me.Width = Wid
            Me.Height = Hei
            Button1.Height = Me.Height - pnl1.Height - tb1.Height - Button2.Height - Button3.Height + 10
            Button1.Location = New Point(0, Button1.Location.Y)
        End If
    End Sub
    Private Sub Label2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        If Me.mClicked Then
            Me.OnResize(e)
            Me.ResizeRedraw = True
        End If
    End Sub

    Private Sub Note_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.mClicked Then
            Me.Size = MousePosition - Me.Location + New Size((Label2.Width / 2), Me.tb1.Height)
            Button1.Height = Me.Height - pnl1.Height - tb1.Height - Button2.Height - Button3.Height + 10
        End If
    End Sub
#End Region

#Region "Fading"

    Private Sub Note_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter, txtMain.MouseEnter, tb1.MouseEnter, pnl1.MouseEnter, Label2.MouseEnter
        leaving = False
        tm.Stop()
        tminc = 0.01
        tm.Start()

    End Sub

    Private Sub tm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tm.Tick
        If (Me.Opacity = 1 And Not leaving) Or ((Me.Opacity - tmopacity < 0.1) And leaving) Then tm.Stop()
        Me.Opacity = Me.Opacity + tminc

    End Sub

    Private Sub Note_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave, txtMain.MouseLeave, tb1.MouseLeave, pnl1.MouseLeave, Label2.MouseLeave
        leaving = True
        tm.Stop()


        tminc = -0.01

        tm.Start()
    End Sub

    Private Sub Note_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.BackColor = Me.txtMain.BackColor 'Fixz
        tb1.Value = Me.Opacity * 100
        tmopacity = Me.Opacity
        tm.Interval = 5
    End Sub
#End Region

#Region "Fixes"
    Private Sub Note_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtMain.DeselectAll()
    End Sub
#End Region

#Region "HideNote"
    Private Sub ShowButtonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButtonToolStripMenuItem.Click
        ShowButtonToolStripMenuItem.Checked = Not (ShowButtonToolStripMenuItem.Checked)
        Button1.Visible = ShowButtonToolStripMenuItem.Checked
        Button2.Visible = ShowButtonToolStripMenuItem.Checked
        Button3.Visible = ShowButtonToolStripMenuItem.Checked
        If ShowButtonToolStripMenuItem.Checked Then
            txtMain.Width -= Button1.Width
            txtMain.Left = Button1.Width
        Else
            txtMain.Width = Me.Width
            txtMain.Left = 0
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not IsHide Then
            While (Me.Left < (My.Computer.Screen.Bounds.Width - (Button1.Width)))
                Me.Left = Me.Left + 1
            End While
            Button1.Text = "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<"
            IsHide = True
            Timer1.Enabled = False
        Else
            While (Me.Left > (My.Computer.Screen.Bounds.Width - (Me.Width + 20)))
                Me.Left = Me.Left - 1
            End While
            Button1.Text = ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
            IsHide = False
            Timer1.Enabled = False
        End If
    End Sub
#End Region

#Region "Change Postion"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Enabled = True
        UpClick = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer2.Enabled = True
        UpClick = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If UpClick Then
            While ((Me.Top) <> 0)
                Me.Top = Me.Top - 1
            End While
            Timer2.Enabled = False
        Else
            While ((Me.Top) < (My.Computer.Screen.Bounds.Height) - Me.Height)
                Me.Top = Me.Top + 1
            End While
            Timer2.Enabled = False
        End If
    End Sub
#End Region

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim msg As String = ""
        Dim sb As New System.Text.StringBuilder(msg)
        sb.AppendLine("محمد السيروان    محمد الجبوري    يمان الطرح")
        sb.AppendLine("كلية الهندسة المعلوماتية    جامعة دمشق")
        sb.AppendLine()
        sb.AppendLine("Muhammad Alsyrwan - Muhammad AlJobory - Yman AlTurh")
        sb.AppendLine("ITE College University of Damascus")
        sb.AppendLine()
        sb.AppendLine("3MDsoft 2010 freeware")
        sb.AppendLine()
        sb.AppendLine("mhd1991@live.com")
        sb.AppendLine("sniper13891@hotmail.com")
        sb.AppendLine("m.y.t-91@hotmail.com")

        MessageBox.Show(sb.ToString, "3MDsoft Stiky Notes", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    
    
End Class
