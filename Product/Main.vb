
Public Class Main
    Dim connection As New SqlClient.SqlConnection
    Dim da As New SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim sqlquery As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MenuStrip1.Enabled = False
        Child.Show()


    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Controls.Clear()
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())
        InitializeComponent()
        Me.MenuStrip1.Enabled = False
        Child.Show()

    End Sub

    Private Sub ManageMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMembersToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub ViewMembersListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMembersListToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub ViewsBookListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewsBookListToolStripMenuItem.Click
        Form6.Show()
    End Sub
End Class