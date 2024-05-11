Public Class Form1
    Dim counter As Decimal


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()



        Dim user, pass As String
        user = TextBox1.Text
        pass = TextBox2.Text
        If user = "123" And pass = "zxc" Then
            MsgBox("wolcom to system")
        ElseIf counter = 3 Then
            MsgBox("eror")
            Button1.Enabled = False
        Else

        End If
        counter = counter + 1


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        End

    End Sub
End Class
