Imports System.Data.SqlClient
Public Class Child

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not inputvldt()) Then
            Return
        End If
        Dim connection As New SqlConnection("server=DESKTOP-VE5V42R; Database=brsDB; Integrated Security=True")
        Dim command As New SqlCommand("select * from members where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", connection)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() >= 0 Then
            Me.Close()
            Main.MenuStrip1.Enabled = True
        Else
            MessageBox.Show("Username or Password Invalid")
        End If


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Function inputvldt() As Boolean
        If (TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty) Then
            MessageBox.Show("Fill out All Fields")
            Return False
        End If
        Return True
    End Function
End Class
