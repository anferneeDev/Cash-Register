Public Class Form2
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form1.Show()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        'Close tform'
    End Sub
End Class