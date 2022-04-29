Public Class Form1
    Dim Rock As Integer = 1
    Dim Scissors As Integer = 2
    Dim Paper As Integer = 3

    Dim PlayerScore As Integer = 0
    Dim CompScore As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function GetRandom() As Integer
        Dim random As New Random
        Dim Rand As Integer = random.Next(3) + 1
        Return Rand
    End Function

    Private Sub Winner(ByVal PlayerChoice As Integer)
        Dim Computer As Integer = GetRandom()
        If Computer = Rock Then
            picComp.ImageLocation = ("C:\Users\USER\Downloads\ROCK.jpg")
            picComp.Load()
        ElseIf Computer = Paper Then
            picComp.ImageLocation = ("C:\Users\USER\Downloads\paper.jpg")
            picComp.Load()
        Else
            picComp.ImageLocation = ("C:\Users\USER\Downloads\scissors.jpg")
            picComp.Load()
        End If

        If PlayerChoice = Rock And Computer = Scissors Then
            lbl1.Text = "Player is the winner!"
            PlayerScore += 1
        ElseIf PlayerChoice = Paper And Computer = Rock Then
            lbl1.Text = "Player is the winner!"
            PlayerScore += 1
        ElseIf PlayerChoice = Scissors And Computer = Paper Then
            lbl1.Text = "Player is the winner!"
            PlayerScore += 1
        End If

        If Computer = Rock And PlayerChoice = Scissors Then
            lbl1.Text = "Computer is the winner!"
            CompScore += 1
        ElseIf Computer = Paper And PlayerChoice = Rock Then
            lbl1.Text = "Computer is the winner!"
            CompScore += 1
        ElseIf Computer = Scissors And PlayerChoice = Paper Then
            lbl1.Text = "Computer is the winner!"
            CompScore += 1
        End If

        If PlayerChoice = Computer Then
            lbl1.Text = "Ties"
        End If

        lblPoints.Text = "Player: " & PlayerScore & " Computer: " & CompScore
    End Sub

    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Winner(CInt(btnRock.Text))
    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        Winner(Scissors)
    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        Dim PlayerChoice As Integer = CInt(btnPaper.Text)
        Winner(PlayerChoice)
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        picComp.Image = Nothing
        CompScore = 0
        PlayerScore = 0
        lbl1.Text = Nothing
    End Sub
End Class
