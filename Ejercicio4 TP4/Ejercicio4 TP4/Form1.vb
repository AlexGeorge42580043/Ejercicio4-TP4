Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim matriz(10, 8) As Integer
        Dim vector(10) As Integer
        Dim nmenor As Integer
        For f = 1 To 10
            matriz(f, 1) = InputBox("Ingresar valores de la matriz", "Ejercicio 4", 0)
            nmenor = matriz(f, 1)
            For c = 2 To 8
                matriz(f, c) = InputBox("Ingresar valores de la matriz", "Ejercicio 4", 0)
                If nmenor > matriz(f, c) Then
                    nmenor = matriz(f, c)
                End If
            Next
            vector(f) = nmenor
        Next
        For j = 1 To 10
            grMostrarVector.Columns.Add("", "")
        Next
        grMostrarVector.Rows.Add(1)
        For j = 1 To 10
            grMostrarVector.Item(j - 1, 0).Value = vector(j)
        Next
    End Sub
End Class
