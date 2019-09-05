Public Class Form1
    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click
        Me.Hide()

        Dim sf As New Form2
        If sf.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'This code Close the form when form1 is open'
      'pP'
        End If
        Me.Close()
    End Sub

End Class
