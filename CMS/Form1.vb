Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        umar.Text = ""
        umar.Text = "Click Here"
        MsgBox("Sucessfully Added", MsgBoxStyle, Exclamation)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If AcceptButton Then
            TextBox
            " Succesfully added"
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub umar_TextChanged(sender As Object, e As EventArgs) Handles umar.TextChanged

    End Sub
End Class
