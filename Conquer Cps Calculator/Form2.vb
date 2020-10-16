Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CpsTxt.Text = My.Settings.CpsV
        GoldTxt.Text = My.Settings.GoldV

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.CpsV = CpsTxt.Text
        My.Settings.GoldV = GoldTxt.Text

        My.Settings.Save()
        MsgBox("נשמר בהצלחה!")
        Form1.Refresh()
        Me.Close()

    End Sub
End Class