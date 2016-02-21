Public Class Form1

    Private Declare Sub mouse_event Lib "user32" (ByVal deflags As Long, ByVal dx As Long, ByVal clouttons As Long, ByVal rlly As Long, ByVal deExtraInfo As Long)

    Private Const mouse_upclick = 4
    Private Const mouse_downclick = 2
    'officialtest,gonnarevertbacktooriginalafterthissucceeds
    Dim test As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer1.Interval = TrackBar1.Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        test = test + 1
        TextBox1.Text = test

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mouse_event(mouse_upclick, 0, 0, 0, 0)
        mouse_event(mouse_downclick, 0, 0, 0, 0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Stop()
        TextBox1.Text = test
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Maximum = 2000
        TrackBar1.Minimum = 1
    End Sub
End Class
