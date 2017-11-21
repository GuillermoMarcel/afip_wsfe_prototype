Public Class LargeText
    Public Shared Sub mostrarMensaje(s As String)
        Dim f As New LargeText
        f.RichTextBox1.Text = s
        f.ShowDialog()
    End Sub
End Class