Imports System.Data.SqlClient
Public Class Form6
    Dim connection As New SqlConnection("server=DESKTOP-VE5V42R; Database=brsDB; Integrated Security=True")
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main

        Call LoadDataSource()
    End Sub

    Function LoadDataSource()
        Dim command As New SqlCommand("select * from books", connection)

        Dim adapter As New SqlDataAdapter(command)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        BindingSource1.DataSource = dt
        DataGridView1.DataSource = BindingSource1
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Function
End Class