Public Class Form2
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide() 'Hide form but not close'
        Dim sf As New Form1
        If sf.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        Me.Close() 'Close the form '
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        'Close tformkkkkkkkskss'
        'aver'
    End Sub
End Class