Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Settings.conf1
        Label2.Text = WindowsApp1.Settings1.Default.test1
    End Sub
End Class
