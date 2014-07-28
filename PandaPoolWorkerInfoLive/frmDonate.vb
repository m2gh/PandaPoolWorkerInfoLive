Public Class frmDonate

    Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub frmDonate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Donate {0}", ApplicationTitle)
        txtInfo.Text = "Please consider a donation to support further development of this project." & vbCrLf & "Thank You!!!"
        txtBTC.Text = "125rZmAmcdtp1LEbAJkDuu9CtL2Mfs2Dyu"
        txtLTC.Text = "LWjSspZQhNW2TgypDRy8Q9dN99c4PvwJjK"
        txtPND.Text = "PHJSHGXGnxQLaJmhAjxCV5GAG9xZrKghXD"
    End Sub

    Private Sub txtBTC_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBTC.TextChanged

    End Sub

    Private Sub btnCopyBTC_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyBTC.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(Me.txtBTC.Text)

    End Sub

    Private Sub btnCopyLTC_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyLTC.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(Me.txtLTC.Text)
    End Sub

    Private Sub btnCopyPND_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyPND.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(Me.txtPND.Text)
    End Sub
End Class