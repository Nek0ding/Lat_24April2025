Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Komik Tin Tin")
        ListBox1.Items.Add("Majalah Tempo")
        ListBox1.Items.Add("Tabloid Nova")
        ListBox1.Items.Add("Buku Matematika")
    End Sub

    Private Sub btn_pilih_Click(sender As Object, e As EventArgs) Handles btn_pilih.Click
        Dim pilihan, harga, total, jumlah
        pilihan = ListBox1.Text
        If IsNumeric(input_jumlah.Text) Then
            jumlah = Int(input_jumlah.Text)
            Select Case pilihan
                Case "Komik Tin Tin"
                    harga = 25000
                    total = harga * jumlah
                    label_nama.Text = pilihan
                    label_harga.Text = "Harga Rp. 25.000"
                    label_total.Text = "Total Harga : Rp. " + Str(total)
                Case "Majalah Tempo"
                    harga = 35000
                    total = harga * jumlah
                    label_nama.Text = pilihan
                    label_harga.Text = "Harga Rp. 35.000"
                    label_total.Text = "Total Harga : Rp. " + Str(total)
                Case "Tabloid Nova"
                    harga = 15000
                    label_nama.Text = pilihan
                    total = harga * jumlah
                    label_harga.Text = "Harga Rp. 15.000"
                    label_total.Text = "Total Harga : Rp. " + Str(total)
                Case "Buku Matematika"
                    harga = 85000
                    label_nama.Text = pilihan
                    total = harga * jumlah
                    label_harga.Text = "Harga Rp. 85.000"
                    label_total.Text = "Total Harga : Rp. " + Str(total)
            End Select
        Else
            MsgBox("Masukkan Jumlah!")

        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Close()
    End Sub
End Class
