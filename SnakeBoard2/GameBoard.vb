


Public Class GameBoard


    ReadOnly pb As New PictureBox 'the apple
    Dim MyMin As Integer 'minimum outer boundaries for apple locations
  Dim MyMaxX As Integer  'maximum outer boundaries for apple locations horizontally
  Dim MyMaxY As Integer  'maximum outer boundaries for apple locations vertically
    ReadOnly Generator As System.Random = New System.Random() 'generates a random location for the apple after it is eaten
    Dim change As Boolean = False 'boolean that checks for user kepresses
  Dim Difficulty As Integer = 80 'determines the speed the snake travels, defaulted at 80
  Dim currentX, currentY As Double 'the snake head's current coordinates
  Dim xLimitC, yLimitC, xLimitUpperC, xLimitLowerC, yLimitUpperC, yLimitLowerC As Double 'used to determine collision with apple
    ReadOnly grow As New List(Of Boolean) 'variable to generate new portions of the snake
    Dim snakeCount As Integer = 0 'number of segments added to snake
  Dim prevert, prehor As Integer 'the location the snake head prevously occupied before colliding with the apple
    ReadOnly body As New List(Of PictureBox) 'variable for generating new sections of the snake

    Dim vert As Integer = 200 'Snake head location vertial
  Dim hor As Integer = 200   'Snake head location Horizontal
  Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    'generates the apple, checks user resolution, sets snake body generation to limit at 100
    checkresolution()
    pb.AutoSize = True
    pb.Width = 15
    pb.Height = 15
    pb.Top = 100
    pb.Left = 100
        'pb.BackColor = Color.Red
        pb.Image = Image.FromFile("apple.png")
        pb.Visible = True
        Me.Controls.Add(pb)
    pctSnake.Top = 200
    pctSnake.Left = 200
    grow.Clear()
        Timer1.Start() 'unused. Thread event used instead

        MyMin = picbordertop.Location.Y + 15
        MyMaxX = picborderright.Location.X - 15
        MyMaxY = picborderbottom.Location.Y - 15

    For i = 0 To 99
      grow.Add(False)
    Next


    'Dim menu As New StartMenu
    'menu.Show()
    'menu.BringToFront()

  End Sub

  Private Sub checkresolution()
    'checks to make sure user is using proper screen resolution as game does not function correctly on higher resolutions
    Dim resx As Integer = Screen.PrimaryScreen.Bounds.Width 'screen resolution width
    Dim resy As Integer = Screen.PrimaryScreen.Bounds.Height 'screen resolution height
    Dim resolution As String = resx & resy 'combined screen height and width
    Select Case resolution
      Case "19201080", "16801050", "1600900", "12801024", "1280720", "1366768"
      Case Else
        MessageBox.Show("Please set your screen resolution to 1920 by 1080 or lower", "Error: Improper Screen Resolution")
        Application.Restart()
    End Select
  End Sub

  Public Function SetDifficulty(sender As Integer)
    'set the difficulty equal to the sender as an integer
    Difficulty = sender
  End Function



    Private Sub moveApple() 'sets a new location for the apple after it is eaten
    pb.Location = New Point(Generator.Next(MyMin, MyMaxX), Generator.Next(MyMin, MyMaxY))
  End Sub


  Public Sub eat()
    'sub that handles collision between the snake head and the apple

    'define current posistion of snake head
    currentX = pctSnake.Location.X
    currentY = pctSnake.Location.Y

    'define border that represents apple
    xLimitUpperC = pb.Location.X + 15
    xLimitLowerC = pb.Location.X - 15
    yLimitUpperC = pb.Location.Y + 15
    yLimitLowerC = pb.Location.Y - 15

        'check posisiton vs apple for collision
        If currentX < xLimitUpperC AndAlso currentX > xLimitLowerC AndAlso currentY < yLimitUpperC AndAlso currentY > yLimitLowerC Then
            moveApple()
            lblcount.Text = Val(lblcount.Text) + 1
            growSnake()

        End If
    End Sub

  Private Sub growSnake()
    'sub to add new segments to the snake after eating an apple
    grow(snakeCount) = True
    'Adds in a new body segment and positions it
    For i = 0 To snakeCount + 1
      body.Add(New PictureBox)
      body(snakeCount).AutoSize = True
      body(snakeCount).Width = 13
      body(snakeCount).Height = 13
      body(snakeCount).BackColor = Color.ForestGreen
      body(snakeCount).Visible = True
      Me.Controls.Add(body(snakeCount))
      body(snakeCount).Location = New Point(prehor, prevert)
    Next

    snakeCount += 1

  End Sub

  Private Sub moveBody()
    'Checks the boolean array and moves the segments that are true
    For i = 0 To 99
      If grow(i) = True Then
        Dim temp As Integer = body(i).Location.X 'the horizontal locations of each body segment 
        Dim temp2 As Integer = body(i).Location.Y 'the vertical locations of each body segment 
        body(i).Location = New Point(prehor, prevert)
        prehor = temp
        prevert = temp2
      End If
    Next
  End Sub
  Private Sub moveSnake(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
    'sub that moves the snake based on user keypresses and will continue moving in a direction until another kepress is entered
    eat() 'Not needed
    change = False
    Select Case e.KeyCode
      Case Keys.Right
        While change = False
          My.Application.DoEvents()
          prehor = hor
          prevert = vert
                    hor = hor + 13
                    pctSnake.Location = New Point(hor, vert)
          moveBody()
                    If checkCollision() Then
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
          prehor = hor
          prevert = vert
          hor = hor - 13
          pctSnake.Location = New Point(hor, vert)
          moveBody()
                    If checkCollision() Then
                        GameOver()
                        Exit While
                    End If
                    eat()
          System.Threading.Thread.Sleep(Difficulty)
        End While
      Case Keys.Up
        While change = False
          My.Application.DoEvents()
          prehor = hor
          prevert = vert
          vert = vert - 13
          pctSnake.Location = New Point(hor, vert)
          moveBody()
                    If checkCollision() Then
                        GameOver()
                        Exit While
                    End If
                    eat()
          System.Threading.Thread.Sleep(Difficulty)
        End While
      Case Keys.Down
        While change = False
          My.Application.DoEvents()
          prehor = hor
          prevert = vert
          vert = vert + 13
          pctSnake.Location = New Point(hor, vert)
          moveBody()
                    If checkCollision() Then
                        GameOver()
                        Exit While
                    End If
                    eat()
          System.Threading.Thread.Sleep(Difficulty)
        End While
    End Select

        If e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Left Then
            change = True
        End If

    End Sub

    Private Function checkCollision() As Boolean
        'boolean value that states whether or not the snake has collided with either itself or the boundry
        If pctSnake.Location.X > MyMaxX OrElse pctSnake.Location.X < MyMin Then
            'MessageBox.Show("Collision")
            change = True
            'GameOver()
            Return True
        ElseIf pctSnake.Location.Y > MyMaxY OrElse pctSnake.Location.Y < MyMin Then
            'MessageBox.Show("Collision")
            change = True
            'GameOver()
            Return True
        ElseIf snakeCount > 0 Then
            For i = 0 To snakeCount
                If pctSnake.Location.X = body(i).Location.X AndAlso pctSnake.Location.Y = body(i).Location.Y Then
                    change = True
                    Return True
                End If
            Next
        Else
            Return False
        End If
    End Function

    Private Sub GameOver()
        'Notifies the user that the game has ended, resets the nessesary variables and relaunches the game
        MessageBox.Show("Game Over! Final Score: " & lblcount.Text)
        lblcount.Text = 0
        hor = 200
        vert = 200
        pctSnake.Location = New Point(hor, vert)
        body.Clear()
        grow.Clear()
        For i = 0 To 99
            grow.Add(False)
        Next
        snakeCount = 0
        Application.Restart()
    End Sub


End Class


