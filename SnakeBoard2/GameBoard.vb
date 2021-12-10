﻿Public Class GameBoard
    Dim pb As New PictureBox
    Dim MyMin As Integer = 20
    Dim MyMaxX As Integer = 750
    Dim MyMaxY As Integer = 550
    Dim Generator As System.Random = New System.Random()
    Dim change As Boolean = False
    Dim Difficulty As Integer = 80
    Dim currentX, currentY As Double
    Dim xLimitC, yLimitC, xLimitUpperC, xLimitLowerC, yLimitUpperC, yLimitLowerC As Double
    Dim grow As New List(Of Boolean)
    Dim snakecount As Integer = 0
    Dim prevhor, prevert As Integer
    Dim bodytest As New List(Of PictureBox)


    Dim vert As Integer = 197 'Snake head location vertial
    Dim hor As Integer = 375   'Snake head location Horizontal
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pb.Width = 10
        pb.Height = 10
        pb.Top = 50
        pb.Left = 50
        pb.BackColor = Color.Red
        pb.Visible = True
        Me.Controls.Add(pb)
        Timer1.Start() 'unused. Thread event used instead
        grow.Clear()
        'Set a boolean array for checking growth
        For i = 0 To 99
            grow.Add(False)
        Next


        'Dim menu As New StartMenu
        'menu.Show()
        'menu.BringToFront()

    End Sub

    Public Function SetDifficulty(sender As Integer)
        'set the difficulty equal to the sender as an integer
        Difficulty = sender
    End Function


    Private Sub moveApple() 'Food the snake eats
        pb.Location = New Point(Generator.Next(MyMin, MyMaxX), Generator.Next(MyMin, MyMaxY))
    End Sub

    Private Sub growSnake()
        grow(snakecount) = True
        'Adds in a new body segment and positions it
        For i = 0 To snakecount + 1
            bodytest.Add(New PictureBox)
            bodytest(snakecount).Width = 13
            bodytest(snakecount).Height = 13
            bodytest(snakecount).BackColor = Color.Blue
            bodytest(snakecount).Visible = True
            Me.Controls.Add(bodytest(snakecount))
            bodytest(snakecount).Location = New Point(prevhor, prevert)
        Next

        snakecount += 1

    End Sub


    Public Sub eat()

        'define current posistion of snake head
        currentX = pctSnake.Location.X
        currentY = pctSnake.Location.Y

        'define border that represents apple
        xLimitUpperC = pb.Location.X + 10
        xLimitLowerC = pb.Location.X - 10
        yLimitUpperC = pb.Location.Y + 10
        yLimitLowerC = pb.Location.Y - 10

        'check posisiton vs apple for collision
        If currentX < xLimitUpperC And currentX > xLimitLowerC And currentY < yLimitUpperC And currentY > yLimitLowerC Then
            moveApple()
            lblcount.Text = Val(lblcount.Text) + 1
            growSnake()

        End If
    End Sub

    Private Sub moveBody()
        'checks the boolean array and moves the segments that are flagged true
        For i = 0 To 99
            If grow(i) = True Then
                Dim temp As Integer = bodytest(i).Location.X
                Dim temp2 As Integer = bodytest(i).Location.Y
                bodytest(i).Location = New Point(prevhor, prevert)
                prevhor = temp
                prevert = temp2
            End If
        Next

    End Sub
    Private Sub moveSnake(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        eat() 'Not needed
        change = False
        Select Case e.KeyCode
            Case Keys.Right
                While change = False
                    My.Application.DoEvents()
                    prevhor = hor
                    prevert = vert
                    hor = hor + 13
                    pctSnake.Location = New Point(hor, vert)
                    moveBody()
                    If checkColl() Then
                        GameOver()
                        Exit While
                    End If
                    'declare eat method based on key movement
                    eat()
                    System.Threading.Thread.Sleep(Difficulty)
                End While
            Case Keys.Left
                While change = False
                    My.Application.DoEvents()
                    prevhor = hor
                    prevert = vert
                    hor = hor - 13
                    pctSnake.Location = New Point(hor, vert)
                    moveBody()
                    If checkColl() Then
                        GameOver()
                        Exit While
                    End If
                    eat()
                    System.Threading.Thread.Sleep(Difficulty)
                End While
            Case Keys.Up
                While change = False
                    My.Application.DoEvents()
                    prevhor = hor
                    prevert = vert
                    vert = vert - 13
                    pctSnake.Location = New Point(hor, vert)
                    moveBody()
                    If checkColl() Then
                        GameOver()
                        Exit While
                    End If
                    eat()
                    System.Threading.Thread.Sleep(Difficulty)
                End While
            Case Keys.Down
                While change = False
                    My.Application.DoEvents()
                    prevhor = hor
                    prevert = vert
                    vert = vert + 13
                    pctSnake.Location = New Point(hor, vert)
                    moveBody()
                    If checkColl() Then
                        GameOver()
                        Exit While
                    End If
                    eat()
                    System.Threading.Thread.Sleep(Difficulty)
                End While
        End Select

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Then
            change = True
        End If

    End Sub

    Private Function checkColl() As Boolean

        If pctSnake.Location.X > 760 Or pctSnake.Location.X < 10 Then
            'MessageBox.Show("Collision")
            change = True
            'GameOver()
            Return True
        ElseIf pctSnake.Location.Y > 550 Or pctSnake.Location.Y < 10 Then
            'MessageBox.Show("Collision")
            change = True
            'GameOver()
            Return True
        ElseIf snakecount > 0 Then
            'checks if the head has collided with a body segment
            For i = 0 To snakecount
                If pctSnake.Location.X = bodytest(i).Location.X And pctSnake.Location.Y = bodytest(i).Location.Y Then
                    change = True
                    Return True
                End If
            Next
        Else
            Return False
        End If
    End Function

    Private Sub GameOver()
        MessageBox.Show("Game Over! Final Score: " & lblcount.Text)
        lblcount.Text = 0
        hor = 375
        vert = 197
        pctSnake.Location = New Point(hor, vert)
        bodytest.Clear()
        grow.Clear()
        For i = 0 To 99
            grow.Add(False)
        Next
        snakecount = 0
        Application.Restart()
    End Sub
End Class