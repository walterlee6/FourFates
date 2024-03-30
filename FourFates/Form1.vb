Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        levelSelect.Show()
    End Sub

    Private Sub btnHow_Click(sender As Object, e As EventArgs) Handles btnHow.Click
        Me.Hide()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        level1.Show()
    End Sub
End Class
