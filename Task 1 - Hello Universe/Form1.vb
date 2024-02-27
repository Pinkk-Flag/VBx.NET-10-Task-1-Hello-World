Public Class Form1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        txtOut.Text = "Hello, Universe"
    End Sub

    Private Sub btnGoodbye_Click(sender As Object, e As EventArgs) Handles btnGoodbye.Click
        txtOut.Text = "Goodbye, Universe :("
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOut.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
