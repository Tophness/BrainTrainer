Public Class Form1
    Dim stagesperround As Integer = 10

    Dim round As Integer = 1
    Dim direction As String = "left"
    Dim count As Integer = 0
    Dim pressed As String = ""
    Dim score As Integer = 0
    Dim maxscore As Integer = 0
    Dim score2 As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        round = 1
        direction = "left"
        count = 0
        pressed = ""
        score = 0
        maxscore = 0
        score2 = 0

        Label1.Visible = False
        Button1.Hide()
        Start()
    End Sub

    Public Sub Start()
        Dim lr As Integer = GetRandom(0, 100)
        If (lr < 50) Then
            direction = "left"
        Else
            direction = "right"
        End If
        bottomimg.ImageLocation = Application.StartupPath & "\round" & round & "_" & direction & ".gif"
        pressed = ""
    End Sub

    Public Function check()
        If (round < 10) Then
            If (count <= stagesperround) Then
                Dim longround As Integer = 6282 / round
                Dim lr As Integer = GetRandom(0, 100)
                If (lr < 50) Then
                    direction = "left"
                Else
                    direction = "right"
                End If
                count += 1
                bottomimg.ImageLocation = Application.StartupPath & "\round" & round & "_" & direction & ".gif"
                pressed = "default"
                Timer1.Interval = GetRandom(Int(longround / 2), longround)
                Timer1.Start()
            Else
                maxscore += stagesperround
                Label1.Visible = True
                Label1.Text = "Score: " & score2 & " ( " & Int((score / maxscore) * 100) & "%)"
                Timer3.Interval = 3145
                Timer3.Start()
                Timer1.Stop()
                round += 1
                direction = "left"
                count = 0
                pressed = ""
                Start()
            End If
        Else
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            topimg.Visible = False
            bottomimg.ImageLocation = Application.StartupPath & "\finished.jpg"
            Label1.Visible = True
            Label1.Text = "Final Score: " & score2 & " ( " & Int((score / maxscore) * 100) & "%)"
            Button1.Show()
        End If
    End Function

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Left) Then
            If (direction = "left") Then
                pressed = "correct"
            Else
                pressed = "incorrect"
            End If
        ElseIf msg.WParam.ToInt32() = CInt(Keys.Right) Then
            If (direction = "right") Then
                pressed = "correct"
            Else
                pressed = "incorrect"
            End If
        End If
        Dim longround As Integer = 6282 / round
        If (pressed <> "") Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            topimg.Visible = True
            topimg.ImageLocation = Application.StartupPath & "\" & pressed & ".png"
            Timer2.Interval = longround / 2
            Timer2.Start()
            If (pressed = "correct") Then
                score += 1
                score2 += (1 * (round * 100))
            End If
            check()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        check()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        topimg.Visible = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        Label1.Visible = False
    End Sub
End Class
