Public Class StartMenu
    Dim Difficulty As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End 'Ends the game
    End Sub

    Private Sub startBoard(sender As Object, e As EventArgs) Handles RadEasy.CheckedChanged, RadMedium.CheckedChanged, RadHard.CheckedChanged, RadExtreme.CheckedChanged
        'Create a select case statement based on the 4 radio buttons and their difficulty with the speed of the snake
        Select Case CType(sender, RadioButton).Checked
            Case RadEasy.Checked
                Difficulty = 80
            Case RadMedium.Checked
                Difficulty = 50
            Case RadHard.Checked
                Difficulty = 20
            Case RadExtreme.Checked
                Difficulty = 8
        End Select


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Creates new game board and starts it and brings to front
        Dim gameBoard As New GameBoard
        gameBoard.Show()
        gameBoard.BringToFront()
        gameBoard.Activate()
        'Set the difficulty to the gameboard based on user input
        gameBoard.SetDifficulty(Difficulty)
        'Timer doesn't work yet
        'Timer1.Start()

    End Sub
End Class