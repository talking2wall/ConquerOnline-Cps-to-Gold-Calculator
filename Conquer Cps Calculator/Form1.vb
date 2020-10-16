Public Class Form1

    Dim CpsValue As String = My.Settings.CpsV
    Dim GoldValue As String = My.Settings.GoldV
    Dim Answer As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Calculation
        If RadioGold2Cps.Checked Then

            Answer = (GoldTxt.Text * CpsValue) / GoldValue
            CpsTxt.Text = Answer

        ElseIf RadioCps2Gold.Checked Then

            Answer = (CpsTxt.Text * GoldValue) / CpsValue
            GoldTxt.Text = Answer

        End If

    End Sub

    Private Sub הגדרותToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles הגדרותToolStripMenuItem.Click

        Form2.Show()

    End Sub

    Private Sub יציאהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles יציאהToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub יוצרהתוכנהToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles יוצרהתוכנהToolStripMenuItem.Click

        MsgBox("Program by Oren A. - JuSTaR.")

    End Sub
End Class
