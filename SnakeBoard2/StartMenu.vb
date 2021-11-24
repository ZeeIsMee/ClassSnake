Public Class StartMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim gameBoard As New GameBoard
        gameBoard.Show()
        gameBoard.BringToFront()
        gameBoard.Activate()

        Timer1.Start()

    End Sub
End Class