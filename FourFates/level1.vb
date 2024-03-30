Public Class level1

    Dim gameOver As Boolean
    Dim moveUp As Boolean
    Dim moveDown As Boolean
    Dim moveLeft As Boolean
    Dim moveRight As Boolean
    Dim velocity As Integer = 10
    Dim borderX As Integer
    Dim borderY As Integer
    Dim pMoveable As Boolean = False
    Dim playerHealth As Integer = 100


    Public Sub New()
        InitializeComponent()
        back.Controls.Add(playerChar)
        playerChar.Location = New Point(544, 519)
        playerChar.BackColor = Color.Transparent
    End Sub

    Private Sub gameSetup() 'setting up the game
        gameOver = False
        pMoveable = True

    End Sub
    Private Sub playerChar_Move(sender As Object, e As EventArgs) Handles playerChar.Move
        'Left Border
        If playerChar.Left < 0 Then
            playerChar.Location = New Point(0, playerChar.Top)
        End If
        'Top Border
        If playerChar.Top < 0 Then
            playerChar.Location = New Point(playerChar.Left, 0)
        End If
        'Right Border
        If (playerChar.Left + playerChar.Width) > Me.Width Then
            playerChar.Location = New Point(Me.Width - playerChar.Width, playerChar.Top)
        End If
        'Bottom Border
        If (playerChar.Top + playerChar.Height) > Me.Height Then
            playerChar.Location = New Point(playerChar.Left, Me.Height - playerChar.Height)
        End If
    End Sub




    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If pMoveable = True Then

            Select Case e.KeyCode
            ' Move to Up
                Case Keys.W

                    moveUp = True

            ' Move to Down
                Case Keys.S

                    moveDown = True

            ' Move to Right
                Case Keys.D

                    moveRight = True

             ' Move to Left
                Case Keys.A

                    moveLeft = True


            End Select
        End If
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            ' Move to Up
            Case Keys.W

                moveUp = False

            ' Move to Down
            Case Keys.S

                moveDown = False

            ' Move to Right
            Case Keys.D

                moveRight = False

             ' Move to Left
            Case Keys.A

                moveLeft = False


        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles moveTimer.Tick 'Make a timer(name:moveTimer)
        If moveUp Then

            playerChar.Top -= velocity

        End If

        If moveDown Then

            playerChar.Top += velocity

        End If

        If moveLeft Then

            playerChar.Left -= velocity

        End If

        If moveRight Then

            playerChar.Left += velocity

        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gameSetup()

        moveTimer.Start()
    End Sub




End Class