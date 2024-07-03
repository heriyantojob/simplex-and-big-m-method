Public Class Form1
    'variabele keluaran hasil
    Dim isi As String
    Dim output As String
    'mengatur baris dan kolom
    Dim kolomS As Integer
    Dim bataskolom As Integer
    Dim batasbaris As Integer

    'berhubungan dengan pembuatan table
    Dim nilaix(200, 200) As Double
    Dim nilaiXLama(200, 200) As Double
    Dim kolomVariable(100) As String
    'berhubungan pada tabel rasio
    Dim nilaiSortirkolom As Double
    Dim SortirKolom As Integer
    Dim nilaiSortirRasio As Double
    Dim SortirRasio As Integer
    Dim angkakunci(100) As Integer
    Dim rasio(100) As Double
    Dim nilaiMinus As Integer
    'menentukan kolom variable
    Dim nilaisama As Integer
    Dim Iterasi As Integer
    Dim nilaiXCOcok(100, 100) As Integer
    Private Sub cekSama()
        For i = 0 To batasbaris
            For j = 0 To kolomS - 1

                If nilaix(i, j) = nilaiXLama(i, j) Then

                    'nilaisama = True
                    nilaiXCOcok(i, j) = 1
                Else
                    nilaiXCOcok(i, j) = 0
                End If
                'cek apakah nilainya sama atau engak dengan lihat kecocokan
                If nilaisama = 0 Then
                    If nilaiXCOcok(i, j) = 1 Then
                        nilaisama = True

                    End If
                End If



            Next
        Next
    End Sub

    Private Sub langkah()
        'Call tampiltabel()
        'output = output & isi
        
        Call cekMinuZ()


        
    End Sub

    Private Sub cekMinuZ()
        nilaiMinus = 0
        nilaisortirkolom = 0
        For loopcari = 0 To kolomS - 1
            If nilaix(0, loopcari) < 0 Then
                If nilaix(0, loopcari) < nilaisortirkolom Then
                    nilaisortirkolom = nilaix(0, loopcari)
                    SortirKolom = loopcari
                    nilaiMinus = 1
                
                End If
                variable.Text = "nilai sortir kolom" & SortirKolom & vbCrLf
            End If
        Next
        If nilaiMinus = 1 Then
            If Iterasi = 0 Then
                output = output & "<br>tabel awal<br>"
            Else
                output = output & "<br>iterasi ke- " & Iterasi & "<br>"
            End If
            Call tabelrasio()
            output = output & isi
            Call tabelLanjut()
            Iterasi = Iterasi + 1
            'output = output & isi
            '   ElseIf nilaiminus = False Then
        Else
            isi = isi & ""
        End If


    End Sub
    'Private Sub setKolomVariable(ByVal ceksekali As Integer, ByVal nilaisortir As Integer)
    Private Sub setKolomVariable(ByVal ceksekali As Integer)


        If kolomVariable(ceksekali) = "" Then
            isi = isi & "<tr><td>s " & ceksekali & "</td>"
        Else
            'kolomVariable(ceksekali) = "x" & SortirRasio
            isi = isi & "<tr><td>" & kolomVariable(ceksekali) & "</td>"
        End If

    End Sub
    Private Sub hapusOutput()
        If My.Computer.FileSystem.FileExists("D:\output.html") Then
            My.Computer.FileSystem.DeleteFile("D:\output.html")
        End If
    End Sub
    Private Sub setinganAwal()
        '========================setingan saat jumlah belum dimasukkan=================

        syarat.ReadOnly = False
        JumlahX.ReadOnly = False
        data.ReadOnly = True
        x1.ReadOnly = True
        x2.ReadOnly = True

        syarat.ReadOnly = False

    End Sub
    Private Sub setwarna(ByVal baris, ByVal kolom)

        If kolom = SortirKolom And baris = SortirRasio Then
            isi = isi & "<td style='background-color: red'>"
        ElseIf kolom = SortirKolom Then
            isi = isi & "<td style='background-color: yellow'>"
        ElseIf baris = SortirRasio Then
            isi = isi & "<td style='background-color: blue'>"
    
        Else
            isi = isi & "<td>"
        End If
    End Sub
    Private Sub hitungclik()
        '===========================setingan setelah data dimasukkan======================
        syarat.ReadOnly = True
        JumlahX.ReadOnly = True
        data.ReadOnly = False
        x1.ReadOnly = False
        x2.ReadOnly = False
        'solusi.Enabled = False

    End Sub
    Private Sub tampilDataAwal()
        '=======================looping nilai soal di tujuannnya ditambah ke variable.text====================
        
        For looping1 = 0 To batasbaris
            For loopj = 0 To bataskolom
                If looping1 = 0 And loopj = 0 Then
                    isi = "z || "
                    isi = isi & nilaix(looping1, loopj) & "x" & (loopj)
                ElseIf looping1 <> 0 And loopj = 0 Then
                    isi = isi & "s" & looping1 & "||" & nilaix(looping1, loopj) & "x" & (loopj)
                    'cek untuk menentukan letak solusi
                ElseIf loopj <> 0 And loopj < kolomS Then
                    isi = isi & "+ (" & nilaix(looping1, loopj) & "x" & (loopj) & ")"

                ElseIf loopj = bataskolom Then


                    If looping1 = 0 Then
                        isi = isi & vbCrLf
                    Else
                        isi = isi & "=" & nilaix(looping1, loopj) & vbCrLf
                    End If




                Else
                    'isi = isi & nilaix(looping1, loopj) & "x" & (loopj - JumlahX.Value)
                    isi = isi & "+ (" & nilaix(looping1, loopj) & "s" & (loopj - JumlahX.Value) & ")"
                End If

            Next
        Next

        output = "<pre>" & isi & "</pre>" & "<br>"
    End Sub


    Private Sub tabelrasio()
        'nilaiminus = False
        'nilaisortirkolom = 0
        'SortirKolom = 0
        SortirRasio = 1
        'cek  minus pada kolom z

        
        variable.Text = nilaix(SortirKolom, bataskolom) / nilaix(SortirKolom, 1)
        variable.Text = SortirKolom
        'variable.Text = nilaix(SortirKolom, bataskolom)
        'variable.Text = nilaix(SortirKolom, bataskolom) / nilaix(SortirKolom, 1)
        'variable.Text = SortirKolom
        'mencari nilai rasio
        nilaiSortirRasio = 1000000000
        
        For cariRasio = 1 To batasbaris

            'If nilaix(cariRasio, SortirKolom) <> 0 Then
            rasio(cariRasio) = nilaix(cariRasio, bataskolom) / nilaix(cariRasio, SortirKolom)
            ' End If



            If rasio(cariRasio) < nilaiSortirRasio Then
                nilaiSortirRasio = rasio(cariRasio)
                SortirRasio = cariRasio
            End If

            variable.Text = variable.Text & "nilai rasio" & cariRasio & "adalah" & rasio(cariRasio) & vbCrLf
        Next
        'cek iterasi
        
        'lihat tabel rasio
        'isi = isi & "<p> tabel awal</p>"
        isi = "<table border='1'>" & vbCrLf & "<tr><th>variable</th>"
        For loopingth = 0 To bataskolom
            If loopingth < kolomS Then
                isi = isi & "<th>x" & loopingth & "</th>"
            ElseIf loopingth = bataskolom Then
                isi = isi & "<th>solusi</th>"

            ElseIf loopingth < bataskolom Then
                isi = isi & "<th>s" & (loopingth - JumlahX.Value) & "</th>"
            End If
        Next
        isi = isi & "<th>rasio</th></tr>"


        For looping1 = 0 To batasbaris
            'style="background-color: yellow">
            For loopj = 0 To bataskolom
                If looping1 = 0 And loopj = 0 Then
                    isi = isi & "<tr><td>" & "z </td>"
                    'isi = isi & "<td>"
                    setwarna(looping1, loopj)
                    
                    isi = isi & nilaix(looping1, loopj) & "</td>"
                ElseIf looping1 <> 0 And loopj = 0 Then
                    'isi = isi & "<tr><td>s " & looping1 & "</td>"
                    'isi = isi & "<td>"


                    ' setkolomvariable(looping1, loopj)
                    setKolomVariable(looping1)
                    ' isi = isi & looping1 & "</td><td>" & nilaix(looping1, loopj) & "</td>"
                    setwarna(looping1, loopj)
                    isi = isi & nilaix(looping1, loopj) & "</td>"
                    'cek menentukan letak solusi pembatas s dan solusi
                ElseIf loopj <> 0 And loopj < kolomS Then
                    'isi = isi & "<td>"
                    setwarna(looping1, loopj)
                    isi = isi & nilaix(looping1, loopj) & "</td>"

                ElseIf loopj = bataskolom Then


                    If looping1 = 0 Then
                        isi = isi & "<td>" & nilaix(looping1, loopj) & "</td><td>-</td> </tr>"
                    Else
                        isi = isi & "<td>" & nilaix(looping1, loopj) & "</td><td>" & rasio(looping1) & "</tr>"
                    End If
                    'letak solusi

                Else

                    'isi = isi & "<td>" & nilaix(looping1, loopj) & "</td>"
                    'isi = isi & "<td>"


                    'isi = isi & "<td>"
                    'isi = isi & nilaix(looping1, loopj) & "</td>"

                    setwarna(looping1, loopj)
                    isi = isi & nilaix(looping1, loopj) & "</td>"


                    'setwarna(looping1, loopj)

                End If


            Next
        Next
        isi = isi & "</table>"
        'menentukan angka kunci

        'menentukan nilaixlama
        For nilailamabaris = 0 To batasbaris
            For nilailamakolom = 0 To bataskolom
                nilaiXLama(nilailamabaris, nilailamakolom) = nilaix(nilailamabaris, nilailamakolom)
            Next
        Next
        'lihat isi nilaixlama
        

        'output = output & "<pre>" & isi & "</pre>" & "<br>"
        For i = 0 To batasbaris

            angkakunci(i) = nilaiXLama(i, SortirKolom)
        Next
        'variable.Text = SortirRasio & "||" & SortirKolom & "nilai" & nilaix(SortirRasio, SortirKolom) & "||" & angkakunci
        'atur nilai kolom variable di kolom awal
        kolomVariable(SortirRasio) = "x" & SortirKolom
    End Sub
    Public Sub tabelLanjut()
        For entrybaru = 0 To bataskolom
            nilaix(SortirRasio, entrybaru) = nilaiXLama(SortirRasio, entrybaru) / nilaiXLama(SortirRasio, SortirKolom)
        Next
        For barisBaru = 0 To batasbaris
            If barisBaru <> SortirRasio Then
                For KolomBaru = 0 To bataskolom



                    'nilaix(elemenBaruBaris, elemenBaruKolom) = nilaiXLama(elemenBaruBaris, elemenBaruKolom) ' - (nilaiXLama(BaruBaris, SortirKolom) * nilaix(SortirRasio, elemenBaruKolom))
                    'nilaix(barisBaru, KolomBaru) = nilaiXLama(barisBaru, SortirKolom)

                    'nilaix(barisBaru, KolomBaru) = nilaix(SortirRasio, KolomBaru)
                    'nilaix(barisBaru, KolomBaru) = SortirRasio
                    nilaix(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))

                Next
            End If

        Next
        'tampil tabel akhir
        'tampiltabel()
    End Sub

    Private Sub tabelAkhir()
        '=======================looping tabel awal====================
        'loop tabel atas
        'Dim loopingth = 0 to As Integer
        isi = "<table border='1'><tr><th>variable</th>"
        'isi = "<table border='1'>" & vbCrLf & "<tr><th>variable</th>"
        For loopingth = 0 To bataskolom
            If loopingth < kolomS Then
                isi = isi & "<th>x" & loopingth & "</th>"
            ElseIf loopingth = bataskolom Then
                isi = isi & "<th>solusi</th>"

            ElseIf loopingth < bataskolom Then
                isi = isi & "<th>s" & (loopingth - JumlahX.Value) & "</th>"
            End If
        Next
        isi = isi & "</tr>"

        For looping1 = 0 To batasbaris
            For loopj = 0 To bataskolom
                If looping1 = 0 And loopj = 0 Then
                    isi = isi & "<tr><td>" & "z </td><td>"
                    isi = isi & nilaix(looping1, loopj) & "</td>"
                ElseIf looping1 <> 0 And loopj = 0 Then
                    'isi = isi & "<tr><td>s "
                    'setkolomvariable(looping1, loopj)
                    setKolomVariable(looping1)
                    isi = isi & looping1 & "</td><td>" & nilaix(looping1, loopj) & "</td>"
                    'cek menentukan letak solusi pembatas s dan solusi
                ElseIf loopj <> 0 And loopj < kolomS Then
                    isi = isi & "<td>" & nilaix(looping1, loopj) & "</td>"

                ElseIf loopj = bataskolom Then


                    If looping1 = 0 Then
                        isi = isi & "<td>" & nilaix(looping1, loopj) & "</td> </tr>"
                    Else
                        isi = isi & "<td>" & nilaix(looping1, loopj) & "</td></tr>"
                    End If
                    'letak solusi

                Else
                    'isi = isi & nilaix(looping1, loopj) & "x" & (loopj - JumlahX.Value)
                    isi = isi & "<td>" & nilaix(looping1, loopj) & "</td>"
                End If


            Next
        Next
        isi = isi & "</table>"
    End Sub
    Private Sub tabelNilai()
        isi = "<table border='1'><tr><td></td><td>varable</td><td>solusi</td></tr>"
        For looping1 = 0 To batasbaris

            If looping1 = 0 Then
                isi = isi & "<tr>"
                isi = isi & "<td>z</td>"
                isi = isi & "<td>tujuan</td>"
               isi = isi & "<td>" & nilaix(looping1, bataskolom) & "</td></tr>"
            Else
                'isi = isi & "<table border='1'>"
                setKolomVariable(looping1)
                If kolomVariable(looping1) = "" Then
                    isi = isi & "<td>slack</td>"
                Else
                    isi = isi & "<td>utama</td>"
                End If
                'isi = isi & "<td>"& &"</td>"
                isi = isi & "<td>" & nilaix(looping1, bataskolom) & "</td></tr>"
            End If

        Next
        isi = isi & "</table>"
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call setinganAwal()

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub setbanyak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setbanyak.Click

        'atur dulu kolom variable yang mau disi menjadi kosong
        For i = 0 To syarat.Value
            kolomVariable(i) = ""
        Next


        samadengan.Items.Clear()
        samadengan.Items.Add("=")
        samadengan.Items.Add("=<")
        samadengan.Items.Add("=>")

        Call hitungclik()
        'koloms adalah cari awal kolom s
        kolomS = JumlahX.Value + 1

        batasbaris = syarat.Value
        bataskolom = syarat.Value + JumlahX.Value + 1
        variable.Text = batasbaris & "kolom:" & bataskolom & vbCrLf & "Aaa"
        'ReDim Preserve nilaix(batasbaris, bataskolom)





    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        Call hapusOutput()



        isi = ""
        '==================data ditambah ke aray==========================
        If data.Value < 1 Then
            nilaix(0, 0) = -1 * x1.Value
            nilaix(0, 1) = -1 * x2.Value
            For x = kolomS To bataskolom - 1
                nilaix(0, kolomS) = 0

            Next
            nilaix(0, bataskolom) = solusi.Value
        Else
            nilaix(data.Value, 0) = x1.Value
            nilaix(data.Value, 1) = x2.Value
            For x = kolomS To batasbaris - 1


                'ini merupakan nilai s1 sd sn
                nilaix(data.Value, x) = 0




            Next
            'nilai solusi
            nilaix(data.Value, bataskolom) = solusi.Value
            nilaix(data.Value, kolomS + (data.Value - 1)) = 1
        End If





        ' nilaix(data.Value, batasbaris) = solusi.Value
        Call tampilDataAwal()
        'output = isi
        My.Computer.FileSystem.WriteAllText("D:\output.html", output, True)

        tampilhasil.Navigate("file:///D:/output.html")


        Call hitungclik()
        'tes.Text = nilaix(1, 1)

    End Sub

    Private Sub labelbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub data_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles data.KeyDown



    End Sub

    Private Sub data_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles data.LocationChanged

    End Sub

    Private Sub data_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles data.ValueChanged

        If syarat.Value < data.Value Then
            data.Value = syarat.Value
        End If

        If data.Value = 0 Then
            solusi.Enabled = False
        Else
            solusi.Enabled = True
        End If



    End Sub

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        nilaisama = 0
        'hapus output
        Iterasi = 0
        'Call hapusOutput()
        'My.Computer.FileSystem.DeleteFile("D:\output.html")
        'save data
        output = "<br>"
        ' Call tampilDataAwal()
        'Call langkah()
        For loopcari = 0 To kolomS - 1 Or nilaisama = True

            Call langkah()
            'cari kecocokan

            Call cekSama()

            ' Iterasi = Iterasi + 1



        Next
        output = output & "<br>iterasi ke- " & Iterasi & "<br>"
        Call tabelAkhir()
        output = output & isi
       
        If nilaisama = 1 Then
            output = output & "<br> sori hasil penyelesaian tidak ada"
        Else
            
            Call tabelNilai()
            output = output & isi
        End If
        My.Computer.FileSystem.WriteAllText("D:\output.html", output, True)
        tampilhasil.Navigate("file:///D:/output.html")
        Call setinganAwal()

        'variable.Text = batasbaris

        
    End Sub

    Private Sub syarat_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles syarat.ValueChanged

        If syarat.Value < 1 Then
            syarat.Value = 1
        End If

    End Sub

    Private Sub banyakx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If syarat.Value < 1 Then
            syarat.Value = 1
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call hapusOutput()
        nilaix(data.Value, comboXN.Value) = Xn.Value
        If data.Value < 1 Then
            nilaix(data.Value, comboXN.Value) = -1 * Xn.Value
            nilaix(data.Value, comboXN.Value) = -1 * Xn.Value
        End If
        Call tampilDataAwal()
        ' variable.Text = isi
        'variable.Text = comboXN.Text
        My.Computer.FileSystem.WriteAllText("D:\output.html", output, True)
        tampilhasil.Navigate("file:///D:/output.html")
    End Sub

    Private Sub JumlahX_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JumlahX.ValueChanged
        If JumlahX.Value < 1 Then
            JumlahX.Value = 1
        End If
    End Sub

    Private Sub comboXN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboXN.ValueChanged

        If comboXN.Value < 0 Then
            comboXN.Value = 0
        ElseIf comboXN.Value > JumlahX.Value Then
            comboXN.Value = JumlahX.Value
        End If

    End Sub

    Private Sub x2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x2.ValueChanged
        If x2.Value < 1 Then
            x2.Value = 1
        End If
    End Sub

    Private Sub x1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x1.ValueChanged
        If x1.Value < 1 Then
            x1.Value = 1
        End If
    End Sub

    Private Sub Xn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xn.ValueChanged
        If x1.Value < 1 Then
            x1.Value = 1
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        For i = 0 To 100
            For j = 0 To 100
                nilaix(i, j) = 0
            Next
        Next
        nilaisama = False
    End Sub
End Class
