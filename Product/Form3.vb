Imports System.Data.SqlClient
Public Class Form3
    Dim connection As New SqlConnection("server=DESKTOP-VE5V42R; Database=brsDB; Integrated Security=True")
    Dim da As New SqlDataAdapter("SELECT * FROM books", connection)
    Dim ds As New DataSet("books")
    Dim n As Integer
    Function ClearTextBoxes()
        Txtbid.Clear()
        Txtbname.Clear()
        Txtpri.Clear()
        Txtqunt.Clear()

        If Cmbcat.SelectedIndex <> -1 Then
            Cmbcat.SelectedIndex = 0
        End If
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        da.Fill(ds)
        If ds.Tables(0).Rows.Count >= 0 Then
            With ds.Tables(0).Rows(0)
                Txtbid.Text = .Item("bid")
                Txtbname.Text = .Item("bname")
                Cmbcat.SelectedItem = .Item("category")
                Txtpri.Text = .Item("price")
                Txtqunt.Text = .Item("quntity")

            End With
        End If
    End Sub

    Private Sub Btnclr_Click(sender As Object, e As EventArgs) Handles Btnclr.Click
        Txtbid.Clear()
        Txtbname.Clear()
        Cmbcat.Items.Clear()
        Txtpri.Clear()
        Txtqunt.Clear()
        Btnprv.Enabled = False
        Btnnxt.Enabled = False
        Btnupdt.Enabled = False
        Btnrmv.Enabled = False
        Btnbk.Enabled = True
        Btnchng.Enabled = False
        Btnadd.Enabled = True
        Call cmb()
    End Sub

    Private Sub Btnupdt_Click(sender As Object, e As EventArgs) Handles Btnupdt.Click
        connection.Open()
        Dim cmsql As New SqlCommand
        cmsql.CommandText = "UPDATE books set bname= '" & Txtbname.Text & "',  category= '" & Cmbcat.SelectedItem.ToString() & "', price= " & Val(Txtpri.Text) & ", quntity= " & Val(Txtqunt.Text) & "    WHERE bid = " & Val(Txtbid.Text) & ""
        cmsql.Connection = connection
        cmsql.ExecuteNonQuery()
        MessageBox.Show("Successfully updated")
        da.Fill(ds)
        connection.Close()

        Call Action()
    End Sub

    Private Sub Btnchng_Click(sender As Object, e As EventArgs) Handles Btnchng.Click
        Btnprv.Enabled = True
        Btnnxt.Enabled = True
        Btnupdt.Enabled = True
        Btnrmv.Enabled = True
        Btnbk.Enabled = True
        Btnadd.Enabled = False
        Btnclr.Enabled = False
    End Sub

    Public Function action()
        Btnprv.Enabled = True
        Btnnxt.Enabled = True
        Btnupdt.Enabled = True
        Btnrmv.Enabled = True
        Btnbk.Enabled = True
        Btnchng.Enabled = True
        Btnadd.Enabled = True
    End Function

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        connection.Open()
        Dim cmsql As New SqlCommand
        cmsql.Connection = connection
        cmsql.CommandText = "INSERT INTO books VALUES('" & Txtbname.Text & "','" & Cmbcat.SelectedItem.ToString() & "', " & Val(Txtpri.Text) & "," & Val(Txtqunt.Text) & ")"
        cmsql.ExecuteNonQuery()

        MessageBox.Show("Successfully added")

        da.Fill(ds)
        connection.Close()

        Call action()
    End Sub

    Private Sub Btnrmv_Click(sender As Object, e As EventArgs) Handles Btnrmv.Click
        connection.Open()
        Dim cmsql As New SqlCommand
        cmsql.CommandText = "DELETE FROM books WHERE id = " & Val(Txtbid.Text)
        cmsql.ExecuteNonQuery()
        MessageBox.Show("Successfully deleted")
        da.Fill(ds)
        connection.Close()

        Call action()
    End Sub

    Private Sub Btnprv_Click(sender As Object, e As EventArgs) Handles Btnprv.Click
        If Not n = 0 Then
            n = n - 1
            With ds.Tables(0).Rows(n)
                Txtbid.Text = .Item("bid")
                Txtbname.Text = .Item("bname")
                Cmbcat.SelectedItem = .Item("category")
                Txtpri.Text = .Item("price")
                Txtqunt.Text = .Item("quntity")
            End With
        End If
    End Sub

    Private Sub Btnnxt_Click(sender As Object, e As EventArgs) Handles Btnnxt.Click
        If Not n = ds.Tables(0).Rows.Count - 1 Then
            n = n + 1
            With ds.Tables(0).Rows(n)
                Txtbid.Text = .Item("bid")
                Txtbname.Text = .Item("bname")
                Cmbcat.SelectedItem = .Item("category")
                Txtpri.Text = .Item("price")
                Txtqunt.Text = .Item("quntity")
            End With
        End If
    End Sub

    Private Sub Btnbk_Click(sender As Object, e As EventArgs) Handles Btnbk.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Function cmb()
        Cmbcat.Items.Add("Secret")
        Cmbcat.Items.Add("Science")
        Cmbcat.Items.Add("Horror")
        Cmbcat.Items.Add("Love")
        Cmbcat.Items.Add("IQ")
    End Function
End Class
