Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strHari(6) As String
        Dim x As Integer

        strHari(0) = "Ahad"
        strHari(1) = "Isnin"
        strHari(2) = "Selasa"
        strHari(3) = "Rabu"
        strHari(4) = "Khamis"
        strHari(5) = "Jumaat"
        strHari(6) = "Sabtu"

        Array.Reverse(strHari)

        x = 0
        For x = 0 To 6
            lstPapar.Items.Add(strHari(x))
        Next

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim strHari(6) As String
        strHari(0) = "Ahad"
        strHari(1) = "Isnin"
        strHari(2) = "Selasa"
        strHari(3) = "Rabu"
        strHari(4) = "Khamis"
        strHari(5) = "Jumaat"
        strHari(6) = "Sabtu"
        Label1.Text = strHari(2)
    End Sub
End Class
