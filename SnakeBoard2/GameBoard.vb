Public Class GameBoard
    Dim pb As New PictureBox
    Dim MyMin As Integer = 20
    Dim MyMaxX As Integer = 750
    Dim MyMaxY As Integer = 550
    Dim Generator As System.Random = New System.Random()
    Dim direction As Integer = 0
    Dim change As Boolean = False
    Dim exitGame As Boolean = False

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
        Timer1.Start()

        'Dim menu As New StartMenu
        'menu.Show()
        'menu.BringToFront()

    End Sub



    Private Sub moveApple()
        pb.Location = New Point(Generator.Next(MyMin, MyMaxX), Generator.Next(MyMin, MyMaxY))
    End Sub


    Public Sub eat()


        Dim currentX, currentY As Double
        Dim xLimitC, yLimitC, xLimitUpperC, xLimitLowerC, yLimitUpperC, yLimitLowerC As Double



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

        End If
    End Sub
    Private Sub moveSnake(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        eat()
        change = False
        Select Case e.KeyCode
            Case Keys.Right
                While change = False
                    My.Application.DoEvents()
                    hor = hor + 5
                    pctSnake.Location = New Point(hor, vert)
                    checkColl()
                    System.Threading.Thread.Sleep(80)
                End While
                checkColl()
            Case Keys.Left
                While change = False
                    My.Application.DoEvents()
                    hor = hor - 5
                    pctSnake.Location = New Point(hor, vert)
                    checkColl()
                    System.Threading.Thread.Sleep(80)
                End While
            Case Keys.Up
                While change = False
                    My.Application.DoEvents()
                    vert = vert - 5
                    pctSnake.Location = New Point(hor, vert)
                    checkColl()
                    System.Threading.Thread.Sleep(80)
                End While
            Case Keys.Down
                While change = False
                    My.Application.DoEvents()
                    vert = vert + 5
                    pctSnake.Location = New Point(hor, vert)
                    checkColl()
                    System.Threading.Thread.Sleep(80)
                End While
        End Select

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Then
            change = True
        End If

    End Sub

    Private Sub checkColl()
        If pctSnake.Location.X > 760 Or pctSnake.Location.X < 10 Then
            MessageBox.Show("Collision")
        ElseIf pctSnake.Location.Y > 550 Or pctSnake.Location.Y < 10 Then
            MessageBox.Show("Collision")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        exitGame = True
    End Sub
End Class