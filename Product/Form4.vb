Imports System.Data.SqlClient
Public Class Form4
    Dim connection As New SqlConnection("server=DESKTOP-VE5V42R; Database=brsDB; Integrated Security=True")
    Dim da As New SqlDataAdapter("SELECT * FROM members", connection)
    Dim ds As New DataSet("users")
    Dim n As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        da.Fill(ds)
        If ds.Tables(0).Rows.Count >= 0 Then
            With ds.Tables(0).Rows(0)
                Txtid.Text = .Item("id")
                Txtname.Text = .Item("name")
                Txtusername.Text = .Item("username")
                Txtpassword.Text = .Item("password")
                Datetime.Value = .Item("dob")

            End With
        End If
    End Sub
    Private Sub Btncl_Click(sender As Object, e As EventArgs) Handles Btncl.Click
        Txtid.Clear()
        Txtname.Clear()
        Txtusername.Clear()
        Txtpassword.Clear()
        Btnpr.Enabled = False
        Btnnx.Enabled = False
        Btnup.Enabled = False
        Btnrm.Enabled = False
        Btnbk.Enabled = True
        Btncn.Enabled = False
        Btnad.Enabled = True
    End Sub

    Private Sub Btncn_Click(sender As Object, e As EventArgs) Handles Btncn.Click
        Btnup.Enabled = True
        Btnrm.Enabled = True
        Btnpr.Enabled = True
        Btnnx.Enabled = True
        Btnbk.Enabled = True
        Btnad.Enabled = False
        Btncl.Enabled = False
    End Sub

    Private Sub Btnup_Click(sender As Object, e As EventArgs) Handles Btnup.Click
        connection.Open()
        Dim cmsql As New SqlCommand
        cmsql.CommandText = "UPDATE members set name= '" & Txtname.Text & "', username= '" & Txtusername.Text & "', password= '" & Txtpassword.Text & "', dob= '" & Datetime.Value & "'    WHERE id = " & Val(Txtid.Text) & ""
        cmsql.Connection = connection
        cmsql.ExecuteNonQuery()
        MessageBox.Show("Successfully updated")
        da.Fill(ds)
        connection.Close()

        Call action()
    End Sub

    Private Sub Btnpr_Click(sender As Object, e As EventArgs) Handles Btnpr.Click
        If Not n = 0 Then
            n = n - 1
            With ds.Tables(0).Rows(n)
                Txtid.Text = .Item("id")
                Txtname.Text = .Item("name")
                Txtusername.Text = .Item("username")
                Txtpassword.Text = .Item("password")
                Datetime.Value = .Item("dob")
            End With
        End If
    End Sub

    Private Sub Btnnx_Click(sender As Object, e As EventArgs) Handles Btnnx.Click
        If Not n = ds.Tables(0).Rows.Count - 1 Then
            n = n + 1
            With ds.Tables(0).Rows(n)
                Txtid.Text = .Item("id")
                Txtname.Text = .Item("name")
                Txtusername.Text = .Item("username")
                Txtpassword.Text = .Item("password")
                Datetime.Value = .Item("dob")
            End With
        End If
    End Sub

    Private Sub Btnad_Click(sender As Object, e As EventArgs) Handles Btnad.Click
        connection.Open()
        Dim cmsql As New SqlCommand
        cmsql.Connection = connection
        cmsql.CommandText = "INSERT INTO members VALUES('" & Txtname.Text & "','" & Txtusername.Text & "','" & Txtpassword.Text & "','" & Datetime.Value.Date & "')"
        cmsql.ExecuteNonQuery()

        MessageBox.Show("Successfully added")

        da.Fill(ds)
        connection.Close()

        Call action()
    End Sub

    Private Sub Btnrm_Click(sender As Object, e As EventArgs) Handles Btnrm.Click
        connection.Open()
        Dim cmsql As New SqlCommand
        cmsql.CommandText = "DELETE FROM members WHERE id = " & Val(Txtid.Text)
        cmsql.ExecuteNonQuery()
        MessageBox.Show("Successfully deleted")
        da.Fill(ds)
        connection.Close()

        Call action()
    End Sub

    Private Sub Btnbk_Click(sender As Object, e As EventArgs) Handles Btnbk.Click
        Me.Close()
        Main.Show()
    End Sub
    Public Function action()
        Btnpr.Enabled = True
        Btnnx.Enabled = True
        Btnup.Enabled = True
        Btnrm.Enabled = True
        Btnbk.Enabled = True
        Btncn.Enabled = True
        Btnad.Enabled = True
    End Function

End Class