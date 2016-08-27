Public Class Form1
    Dim clr As Color = Color.AliceBlue
    Dim count As Int32 = 0
    Dim total As Int32 = 40
    Dim abs As Int32 = 40

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Button1.BackColor <> DefaultBackColor) Then
            Button1.BackColor = DefaultBackColor
            count = count - 1
        Else
            count = count + 1
            Button1.BackColor = clr
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Button2.BackColor <> DefaultBackColor) Then
            Button2.BackColor = DefaultBackColor
            count = count - 1
        Else
            count = count + 1
            Button2.BackColor = clr
        End If

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        abs = total - count
        Label2.Text = "Present Today : " + count.ToString
        Label1.Text = "Abscent Today : " + abs.ToString

    End Sub
End Class
