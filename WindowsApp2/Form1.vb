Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Settings1.Default.Title
        Label1.Text = Settings1.Default.test1
        Label2.Text = Settings1.Default.test2
        Label3.Text = Settings1.Default.test3
    End Sub
End Class
