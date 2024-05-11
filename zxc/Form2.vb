Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user_1;Data Source=DESKTOP-UI0SLR3\SQLEXPRESS")
    Dim cmd As New SqlCommand("select * from pharmacy", con)
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter(cmd)
    Dim df As New SqlCommandBuilder(da)
    Dim mx As Double = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If con.State = Data.ConnectionState.Closed Then con.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("الرجاء تعبئة الحقول")
            Exit Sub
        End If
        Dim cmd As New SqlCommand("insert into pharmacy values(" & Val(TextBox1.Text) & ",'" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("تم الحفظ")
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Closed Then con.Open()

        Dim b As Boolean = False
        Dim cmd As New SqlCommand("select * from recip where id=" & Val(TextBox1.Text) & "", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            TextBox2.Text = dr(1)
            TextBox3.Text = dr(2)
            TextBox4.Text = dr(3)
            b = True
        End While
        dr.Close()
        If b = False Then
            MsgBox("البيانات غير موجودة")
        End If
    End Sub
End Class