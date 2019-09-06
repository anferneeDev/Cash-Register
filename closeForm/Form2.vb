Public Class Form2
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide() 'Hide form but not close'
        Dim f1 As New Form1
        Dim f2 As New Form2

        ' Size the form to be 300 pixels in height and width.
        'f1.Size = New Size(300, 300)'

        ' Display the form in the center of the screen.
        If f1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

        End If

        Me.Close() 'Close the formsssss '
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        'Close form'
    End Sub
End Class