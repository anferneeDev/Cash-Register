Public Class Form2
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If sender Is back Then
            Form1.Show()

        ElseIf sender Is back Then
            Me.Hide()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        'Close tformkkkkkkkkss'
    End Sub
End Class