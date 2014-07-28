Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class frmMain
    Dim intTotalKHS As Integer

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSetting(My.Application.Info.ProductName, "Options", "Window Position Left", Me.Left)
        SaveSetting(My.Application.Info.ProductName, "Options", "Window Position Top", Me.Top)
        SaveSetting(My.Application.Info.ProductName, "Options", "txtUserAddress.Text", txtUserAddress.Text)
        SaveSetting(My.Application.Info.ProductName, "Options", "chkbAutoupdate.Checked", chkbAutoupdate.Checked)
        SaveSetting(My.Application.Info.ProductName, "Options", "rdbScrypt.Checked", rdbScrypt.Checked)
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Application.Info.Title <> "" Then Me.Text = My.Application.Info.Title
        Me.Left = GetSetting(My.Application.Info.ProductName, "Options", "Window Position Left", Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width / 2)
        Me.Top = GetSetting(My.Application.Info.ProductName, "Options", "Window Position Top", Screen.PrimaryScreen.Bounds.Height / 2 - Me.Height / 2)
        txtUserAddress.Text = GetSetting(My.Application.Info.ProductName, "Options", "txtUserAddress.Text", "")
        rdbScrypt.Checked = GetSetting(My.Application.Info.ProductName, "Options", "rdbScrypt.Checked", True)
        If rdbScrypt.Checked = False Then rdbX11.Checked = True

        chkbAutoupdate.Checked = GetSetting(My.Application.Info.ProductName, "Options", "chkbAutoupdate.Checked", False) 'must be last
        If Timer1.Enabled = True Then Get_Pandapool_JSON()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Get_Pandapool_JSON()
    End Sub

    Private Sub Get_Pandapool_JSON()
        'Console.Clear()
        lstvUserInfo.Items.Clear()


        Console.WriteLine("hmm1")


        Dim tmpResponseFromServer As String
        Dim tmpQuery As String
        tmpQuery = "&user=" & txtUserAddress.Text
        If rdbX11.Checked = True Then tmpQuery += "&algo=x11"

        tmpResponseFromServer = JSON_GET("http://multi.pandapool.info/api.php?q=userinfo&" & tmpQuery)
        tmpResponseFromServer = Replace(tmpResponseFromServer, "error", "xerror")
        'txtTmp.Text = tmpResponseFromServer
        Try
            Dim rootobject As RootObject = JsonConvert.DeserializeObject(Of RootObject)(tmpResponseFromServer)
            If rootobject.xerror = 1 Then
                Timer1.Enabled = False
                chkbAutoupdate.Checked = False
                MsgBox("Something wrong was happend. Autoupdate is disabled." & vbCrLf & "Error message from server : " & rootobject.msg, vbCritical)

                Exit Sub
            ElseIf rootobject.xerror = 0 Then
                Try

                    Console.WriteLine(rootobject.result.workers.Length)
                Catch
                    Timer1.Enabled = False
                    chkbAutoupdate.Checked = False
                    MsgBox("No live data for workers. Check Address, pool selections or check workers. Autoupdate is disabled.", vbCritical)
                    Exit Sub
                End Try

            End If


            Console.WriteLine(rootobject.result.workers.Length)
            Console.WriteLine(rootobject.result.workers(0)(0))

            Dim Items As New List(Of ListViewItem)
            Dim Item(rootobject.result.workers.Length - 1) As ListViewItem
            lstvUserInfo.BeginUpdate()
            intTotalKHS = 0
            For i = 0 To rootobject.result.workers.Length - 1
                Item(i) = New ListViewItem

                For o = 0 To rootobject.result.workers(i).Length - 1
                    'TextBox2.AppendText(account.Roles.Item(i) & vbCrLf)
                    'Console.Write(rootobject.result.workers(i)(o))
                    If o = 0 Then Item(i).Text = rootobject.result.workers(i)(o) Else Item(i).SubItems.Add(rootobject.result.workers(i)(o))

                    'If o < rootobject.result.workers(i).Length - 1 Then Console.Write(", ")
                    If o = 2 Then intTotalKHS += rootobject.result.workers(i)(o)
                Next
                Items.Add(Item(i))
                lstvUserInfo.Items.AddRange(Items.ToArray)
                Items.Clear()
                'lstvUserInfo.Items.
                'Console.Write(vbCrLf)
            Next
            lstvUserInfo.EndUpdate()
            lblTotalKHS.Text = "Total hashrate : " & intTotalKHS & " kH/s"

            'For Each item As RootObject In rootobject.result.workers.
            '    Console.WriteLine() '+ "-" + item("car").ToString)
            'Next

        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try

        Console.WriteLine("hmm2")
        Console.WriteLine()
        'Console.WriteLine(rootobject.result.history.payout.ToString)

        'For Each item As RootObject In rootobject
        '    Console.WriteLine(item.result.workers.Length.ToString) '+ "-" + item("car").ToString)
        'Next
        ''txtTmp.Text = rootobject.Item
        'Dim market_summary As New List(Of Market_Summary)
        'market_summary = JsonConvert.DeserializeObject(Of List(Of Market_Summary))(txtTmp.Text)

    End Sub

    Private Sub txtUserAddress_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserAddress.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            chkbAutoupdate.Checked = True

        End If
    End Sub

    Private Sub chkbAutoupdate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbAutoupdate.CheckedChanged
        If chkbAutoupdate.Checked = True Then
            chkbAutoupdate.Text = "Enabled"
            Timer1.Enabled = True
            Get_Pandapool_JSON()
        Else
            chkbAutoupdate.Text = "Disabled"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DonateToolStripMenuItem.Click
        frmDonate.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub rdbX11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbX11.CheckedChanged

    End Sub

    Private Sub rdbScrypt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbScrypt.CheckedChanged

    End Sub

    Private Sub lnklblPandapool_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblPandapool.LinkClicked
        System.Diagnostics.Process.Start("http://multi.pandapool.info/")
    End Sub

    Private Sub lnklblBitcointalk_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblBitcointalk.LinkClicked
        System.Diagnostics.Process.Start("https://bitcointalk.org/index.php?topic=568529.0")
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles lblDetail.Click
        If lblDetail.Text = "˄" Then
            lblDetail.Text = "˅"
            Me.Height = 165
            lstvUserInfo.Visible = False

        Else
            lblDetail.Text = "˄"
            Me.Height = 310
            lstvUserInfo.Visible = True
        End If

        
    End Sub

    Private Sub txtUserAddress_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUserAddress.TextChanged

    End Sub
End Class




Public Class History
    Private roundx As Integer
    Public Property round As Integer
        Get
            Return roundx
        End Get
        Set(value As Integer)
            roundx = value
        End Set
    End Property
    Dim payoutx As Double
    Public Property payout As Double
        Get
            Return payoutx
        End Get
        Set(value As Double)
            payoutx = value
        End Set
    End Property
    Private workersx As Object()()
    Public Property workers As Object()()
        Get
            Return workersx
        End Get
        Set(value As Object()())
            workersx = value
        End Set
    End Property
End Class
Public Class Result
    Private workersx As String()()
    Public Property workers As String()()
        Get
            Return workersx
        End Get
        Set(value As String()())
            workersx = value
        End Set
    End Property

    'Private historyx
    'Public Property history As History
    '    Get
    '        Return historyx
    '    End Get
    '    Set(value As History)
    '        historyx = value
    '    End Set
    'End Property
End Class
Public Class RootObject
    Private errorx As Integer
    Public Property xerror As Integer
        Get
            Return errorx
        End Get
        Set(value As Integer)
            errorx = value
        End Set
    End Property
    Public Property result As Result
    '    Get
    '        Return resultx
    '    End Get
    '    Set(value As Result)
    '        resultx = value
    '    End Set
    'End Property
    Private msgx As String
    Public Property msg As String
        Get
            Return msgx
        End Get
        Set(value As String)
            msgx = value
        End Set
    End Property
End Class



Public Class PP_UserInfo
    Private p_coin As String
    Private p_code As String
    Public Property coin As String
        Get
            Return p_coin
        End Get
        Set(value As String)
            p_coin = value
        End Set
    End Property
    Public Property code As String
        Get
            Return p_code
        End Get
        Set(value As String)
            p_code = value
        End Set
    End Property
End Class
