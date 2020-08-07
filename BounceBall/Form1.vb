Public Class Form1

    Private Sub startbutton_Click(sender As Object, e As EventArgs) Handles startbutton.Click
        If updownnya.Value = 1 Then
            level1.Show()
        ElseIf updownnya.Value = 2 Then
            level2.Show()
        ElseIf updownnya.Value = 3 Then
            level3.Show()
        ElseIf updownnya.Value = 4 Then
            level4.Show()
        ElseIf updownnya.Value = 5 Then
            level5.Show()
        End If
    End Sub
End Class
