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
    Dim nilaiS(200, 200) As Double
    Dim nilaiSLama(200, 200) As Double
    Dim nilaiALama(200, 200) As Double
    Dim nilaiA(200, 200) As Double
    Dim nilaiHitung(100) As String
    'nilai m
    Dim nilaiMX(100) As Double
    Dim nilaiMA(100) As Double
    Dim nilaiMS(100) As Double
    Dim nilaiMXLama(100) As Double
    Dim nilaiMALama(100) As Double
    Dim nilaiMSLama(100) As Double
    Dim posisiMA(100) As Integer
    Dim totalS As Integer
    Dim totalA As Integer
    'berhubungan dengan cek minus
    Dim nilaiSortirkolom As Double
    Dim nilaiMinus As Integer
    Dim nilaiCekMs As Integer
    Dim cekUlangX As Integer
    'berhubungan dengan table rasio

    Dim SortirKolom As Integer
    Dim sortirKolomS As Integer
    Dim nilaiSortirRasio As Double
    Dim SortirRasio As Integer
    Dim angkakunci(100) As Integer
    Dim rasio(100) As Double

    'menentukan kolom variable
    Dim nilaisama As Integer
    Dim Iterasi As Integer
    Dim nilaiXCOcok(100, 100) As Integer
    Private Sub aturFormat()
        If data.Value = 0 Then
            x1.Value = 4
            x2.Value = 1
            solusi.Value = 0

        ElseIf data.Value = 1 Then
            x1.Value = 3
            x2.Value = 1
            samadengan.Text = "="
            solusi.Value = 3

        ElseIf data.Value = 2 Then
            x1.Value = 4
            x2.Value = 3
            samadengan.Text = "=>"
            solusi.Value = 6
        ElseIf data.Value = 3 Then
            x1.Value = 1
            x2.Value = 2
            samadengan.Text = "=<"
            solusi.Value = 4


        End If

    End Sub
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
        'kolom s
        For i = 1 To batasbaris
            For j = 1 To totalS
                If nilaiS(i, j) = nilaiSLama(i, j) Then

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
        For i = 1 To batasbaris
            For j = 1 To totalA
                If nilaiA(i, j) = nilaiALama(i, j) Then

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
        nilaiSortirkolom = 10000000000
        nilaiCekMs = -1000
        sortirKolomS = 0

        For loopCari = 0 To kolomS - 1



            If nilaix(0, loopCari) < nilaiSortirkolom Then
                If nilaix(0, loopCari) <> 0 Then
                    nilaiSortirkolom = nilaix(0, loopCari)
                    SortirKolom = loopCari
                    nilaiMinus = 1
                End If
            Else
                cekUlangX = cekUlangX + 1


            End If
        Next


        For loopcari = 0 To totalS
            If nilaiS(0, loopcari) <> 0 Then
                If nilaiS(0, loopcari) < nilaiSortirkolom Then
                    nilaiSortirkolom = nilaiS(0, loopcari)
                    sortirKolomS = loopcari
                    nilaiMinus = 1

                End If
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
    Private Sub setwarna(ByVal baris As Integer, ByVal kolom As Integer, ByVal kolomSKe As String)
        If sortirKolomS = 0 Then
            If kolom = SortirKolom And baris = SortirRasio And kolomSKe <> "y" Then
                isi = isi & "<td style='background-color: red'>"
            ElseIf kolom = SortirKolom And kolomSKe <> "y" Then
                isi = isi & "<td style='background-color: yellow'>"
            ElseIf baris = SortirRasio Then
                isi = isi & "<td style='background-color: blue'>"

            Else
                isi = isi & "<td>"
            End If
        Else
            If kolom = sortirKolomS And baris = SortirRasio And kolomSKe = "y" Then
                isi = isi & "<td style='background-color: red'>"
            ElseIf kolom = sortirKolomS And kolomSKe = "y" Then
                isi = isi & "<td style='background-color: yellow'>"
            ElseIf baris = SortirRasio Then
                isi = isi & "<td style='background-color: blue'>"

            Else
                isi = isi & "<td>"
            End If
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
                    isi = "z = "
                    isi = isi & nilaix(looping1, loopj) & "x" & (loopj)
                ElseIf looping1 <> 0 And loopj = 0 Then
                    isi = isi & nilaix(looping1, loopj) & "x" & (loopj)
                    'cek untuk menentukan letak solusi
                ElseIf loopj <> 0 And loopj < kolomS Then
                    isi = isi & "+" & nilaix(looping1, loopj) & "x" & (loopj) & " "

                ElseIf loopj = bataskolom Then


                    If looping1 = 0 Then
                        isi = isi & vbCrLf
                    Else
                        isi = isi & nilaiHitung(looping1)
                        isi = isi & nilaix(looping1, loopj) & vbCrLf
                    End If


                End If

            Next
        Next

        output = "<pre>" & isi & "</pre>" & "<br>"
    End Sub
    Private Sub tampilM(ByVal AngkaM As Double)
        If AngkaM = 0 Then
            isi = isi & "</td>"

        ElseIf AngkaM > 0 Then
            If AngkaM = 1 Then
                isi = isi & " + M </td>"
            Else
                isi = isi & " + " & AngkaM & "M </td>"
            End If
        ElseIf AngkaM < 0 Then
            If AngkaM = -1 Then
                isi = isi & "- M" & "</td>"
            Else
                isi = isi & AngkaM & "M </td>"
            End If

       

        End If


    End Sub
    Private Sub tabelrasio()
        'nilaiminus = False
        'nilaisortirkolom = 0
        'SortirKolom = 0
        SortirRasio = 1
        'cek  minus pada kolom z



        'mencari nilai rasio/ menentukan nilai rasio
        nilaiSortirRasio = 10000000000

        For cariRasio = 1 To batasbaris

            'If nilaix(cariRasio, SortirKolom) <> 0 Then

            If sortirKolomS = 0 Then
                rasio(cariRasio) = nilaix(cariRasio, bataskolom) / nilaix(cariRasio, SortirKolom)
            Else
                rasio(cariRasio) = nilaix(cariRasio, bataskolom) / nilaiS(cariRasio, sortirKolomS)
            End If



            ' End If



            If (rasio(cariRasio) < nilaiSortirRasio) And rasio(cariRasio) > -1 Then
                nilaiSortirRasio = rasio(cariRasio)
                SortirRasio = cariRasio
            End If


        Next
        'cek iterasi

        'lihat tabel rasio
        'isi = isi & "<p> tabel awal</p>"
        '
        isi = "<table border='1'>" & vbCrLf & "<tr><th>variable</th>"
        For loopingth = 0 To bataskolom
            If loopingth < kolomS Then
                isi = isi & "<th>x" & loopingth & "</th>"
            ElseIf loopingth = bataskolom Then
                For i = 1 To totalS
                    isi = isi & "<th>s" & i & "</th>"
                Next
                For i = 1 To totalA
                    isi = isi & "<th>A" & i & "</th>"
                Next
                isi = isi & "<th>solusi</th>"

            ElseIf loopingth < bataskolom Then
                isi = isi & "<th>s" & (loopingth - JumlahX.Value) & "</th>"
            End If
        Next
        isi = isi & "<th>rasio</th></tr>"

        '==============menentukan isi table

        For looping1 = 0 To batasbaris
            'style="background-color: yellow">
            For loopj = 0 To bataskolom
                'menentukan data tujuan
                'pada data 0
                If looping1 = 0 And loopj = 0 Then
                    isi = isi & "<tr><td>" & "z </td>"
                    '============isi = isi & "<td>"
                    setwarna(looping1, loopj, "")

                    isi = isi & nilaix(looping1, loopj)
                    Call tampilm(nilaiMX(loopj))

                    'if nilaimx(loopj) <> 0 then
                    '    isi = isi & " + " & nilaimx(loopj) & "m</td>"
                    'else
                    '    isi = isi & "</td>"
                    'end if
                ElseIf looping1 = 0 And loopj <> 0 And loopj <> bataskolom Then

                    'isi = isi & "<td>"
                    setwarna(looping1, loopj, "")

                    isi = isi & nilaix(looping1, loopj)
                    Call tampilm(nilaiMX(loopj))

                    'If nilaiMX(loopj) <> 0 Then
                    '    isi = isi & " + " & nilaiMX(loopj) & "M</td>"
                    'Else
                    '    isi = isi & "</td>"
                    'End If

                    'menentukan  table jika data bukan tujuan
                ElseIf looping1 <> 0 And loopj = 0 Then
                    'isi = isi & "<tr><td>s " & looping1 & "</td>"
                    'isi = isi & "<td>"


                    ' setkolomvariable(looping1, loopj)
                    setKolomVariable(looping1)
                    ' isi = isi & looping1 & "</td><td>" & nilaix(looping1, loopj) & "</td>"
                    setwarna(looping1, loopj, "")
                    isi = isi & nilaix(looping1, loopj) & "</td>"
                    'cek menentukan letak solusi pembatas s dan solusi
                ElseIf loopj <> 0 And loopj < kolomS Then
                    'isi = isi & "<td>"
                    setwarna(looping1, loopj, "")
                    isi = isi & nilaix(looping1, loopj) & "</td>"

                ElseIf loopj = bataskolom Then
                    'jika data tujuan

                    If looping1 = 0 Then

                        For masukS = 1 To totalS
                            setwarna(looping1, masukS, "y")
                            isi = isi & nilaiS(looping1, masukS)
                            'isi = isi & nilaiMS(masukS) & "</td>"
                            Call tampilm(nilaiMS(masukS))
                        Next
                        For masukA = 1 To totalA

                            isi = isi & "<td>" & nilaiA(looping1, masukA)
                            'isi = isi & "||" & nilaiMA(masukA) & "</td>"

                            Call tampilm(nilaiMA(masukA))
                        Next

                        isi = isi & "<td>" & nilaix(looping1, loopj)
                        Call tampilm(nilaiMX(loopj))
                        isi = isi & "<td>-</td> </tr>"
                        
                        
                        'jika bukan data tujuan
                    Else
                        For masukS = 1 To totalS
                            setwarna(looping1, masukS, "y")
                            ' setWarnaS(masukS, loopj)
                            isi = isi & nilaiS(looping1, masukS) & "</td>"
                        Next
                        For masukA = 1 To totalA
                            'setWarnaS(totalS + 1, loopj)
                            setwarna(looping1, loopj, "")
                            isi = isi & nilaiA(looping1, masukA) & "</td>"
                            ' isi = isi & "<th>A" & totalS & "</th>"
                        Next
                        isi = isi & "<td>" & nilaix(looping1, loopj) & "</td><td>"

                        If rasio(looping1) > -1 Then
                            isi = isi & rasio(looping1) & "</td></tr>"
                        Else
                            isi = isi & "-</td></tr>"
                        End If

                        isi = isi & rasio(looping1) & "</td></tr>"
                    End If


                Else


                    setwarna(looping1, loopj, "")
                    isi = isi & nilaix(looping1, loopj) & "</td>"

                End If


            Next
        Next
        isi = isi & "</table>"
        'menentukan angka kunci

        'menentukan nilaixlama nilai a lama dan nilai 
        For nilailamabaris = 0 To batasbaris
            '=======nilai x lama
            For nilailamakolom = 0 To bataskolom
                nilaiXLama(nilailamabaris, nilailamakolom) = nilaix(nilailamabaris, nilailamakolom)
            Next
            'nilai s lama
            For nilailamakolom = 1 To totalS
                nilaiSLama(nilailamabaris, nilailamakolom) = nilaiS(nilailamabaris, nilailamakolom)
            Next
            'nilai a lama
            For nilailamakolom = 1 To totalA
                nilaiALama(nilailamabaris, nilailamakolom) = nilaiA(nilailamabaris, nilailamakolom)
            Next
            'nilaim lama

        Next

        '========menentukan nilaimx lama , nilai ma lama dan nilai ms lama
        For i = 0 To bataskolom
            nilaiMXLama(i) = nilaiMX(i)
        Next
        For i = 1 To totalA
            nilaiMALama(i) = nilaiMA(i)
        Next
        For i = 1 To totalS
            nilaiMSLama(i) = nilaiMS(i)
        Next
        'lihat isi nilaixlama


        'output = output & "<pre>" & isi & "</pre>" & "<br>"
        

        'atur nilai kolom variable di kolom awal
        If sortirKolomS = 0 Then
            kolomVariable(SortirRasio) = "x" & SortirKolom
        Else
            kolomVariable(SortirRasio) = "s" & sortirKolomS
        End If

    End Sub
    Public Sub tabelLanjut()
        '=========menentukan entry baru pada baris yang diasir
        'entry pada nilai x

        '1)jika sortir kolom pada x
        If sortirKolomS = 0 Then
            For entrybaru = 0 To bataskolom
                nilaix(SortirRasio, entrybaru) = nilaiXLama(SortirRasio, entrybaru) / nilaiXLama(SortirRasio, SortirKolom)
            Next
            'nilai a
            For entrybaru = 1 To totalA
                nilaiA(SortirRasio, entrybaru) = nilaiALama(SortirRasio, entrybaru) / nilaiXLama(SortirRasio, SortirKolom)
            Next
            'nilai s
            For entrybaru = 1 To totalS
                nilaiS(SortirRasio, entrybaru) = nilaiSLama(SortirRasio, entrybaru) / nilaiXLama(SortirRasio, SortirKolom)
            Next


            '=======menentukan nilai entry baru pada baris yg tidak diasir
            For barisBaru = 0 To batasbaris
                If barisBaru <> SortirRasio Then
                    'menentukan nilai x
                    For KolomBaru = 0 To bataskolom

                        nilaix(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))

                    Next
                    'menentukan nilai s
                    For KolomBaru = 1 To totalS
                        'entry lama - (entry *new)
                        ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                        nilaiS(barisBaru, KolomBaru) = nilaiSLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) _
                                                        * nilaiS(SortirRasio, KolomBaru))

                    Next
                    'menentukan nilai a
                    For KolomBaru = 1 To totalA
                        'entry lama - (entry *new)
                        ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                        nilaiA(barisBaru, KolomBaru) = nilaiALama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) _
                                                        * nilaiA(SortirRasio, KolomBaru))

                    Next


                End If

            Next


            '=======mencari nilai m baru
            'nilai mx
            For KolomBaru = 0 To bataskolom
                'entry lama - (entry *new)

                'nilaiA(barisBaru, KolomBaru) = nilaiALama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) _
                ' * nilaiA(SortirRasio, KolomBaru))

                nilaiMX(KolomBaru) = nilaiMXLama(KolomBaru) - (nilaiMXLama(SortirKolom) _
                                                * nilaix(SortirRasio, KolomBaru))

            Next

            'nilai ms
            For KolomBaru = 1 To totalS
                'entry lama - (entry *new)
                ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                nilaiMS(KolomBaru) = nilaiMSLama(KolomBaru) - (nilaiMXLama(SortirKolom) _
                                                * nilaiS(SortirRasio, KolomBaru))

            Next

            'nilai ma

            For KolomBaru = 1 To totalA
                'entry lama - (entry *new)
                ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                nilaiMA(KolomBaru) = nilaiMALama(KolomBaru) - (nilaiMXLama(SortirKolom) _
                                                * nilaiA(SortirRasio, KolomBaru))

            Next


            '2)======================>jika kolom yang disortir adalah kolom s
        Else
            'penentuan nilai s
            For entrybaru = 0 To bataskolom
                nilaix(SortirRasio, entrybaru) = nilaiXLama(SortirRasio, entrybaru) / nilaiSLama(SortirRasio, sortirKolomS)
            Next
            'nilai a
            For entrybaru = 1 To totalA
                nilaiA(SortirRasio, entrybaru) = nilaiALama(SortirRasio, entrybaru) / nilaiSLama(SortirRasio, sortirKolomS)
            Next
            'nilai s
            For entrybaru = 1 To totalS
                nilaiS(SortirRasio, entrybaru) = nilaiSLama(SortirRasio, entrybaru) / nilaiSLama(SortirRasio, sortirKolomS)
            Next


            '=======menentukan nilai entry baru pada baris yg tidak diasir
            For barisBaru = 0 To batasbaris
                If barisBaru <> SortirRasio Then
                    'menentukan nilai x
                    For KolomBaru = 0 To bataskolom

                        nilaix(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiSLama(barisBaru, sortirKolomS) _
                                                        * nilaix(SortirRasio, KolomBaru))

                    Next
                    'menentukan nilai s
                    For KolomBaru = 1 To totalS
                        'entry lama - (entry *new)
                        ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                        nilaiS(barisBaru, KolomBaru) = nilaiSLama(barisBaru, KolomBaru) - (nilaiSLama(barisBaru, sortirKolomS) _
                                                        * nilaiS(SortirRasio, KolomBaru))

                    Next
                    'menentukan nilai a
                    For KolomBaru = 1 To totalA
                        'entry lama - (entry *new)
                        ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                        nilaiA(barisBaru, KolomBaru) = nilaiALama(barisBaru, KolomBaru) - (nilaiSLama(barisBaru, sortirKolomS) _
                                                        * nilaiA(SortirRasio, KolomBaru))

                    Next


                End If

            Next


            '=======mencari nilai m baru
            'nilai mx
            For KolomBaru = 0 To bataskolom
                'entry lama - (entry *new)

                'nilaiA(barisBaru, KolomBaru) = nilaiALama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) _
                ' * nilaiA(SortirRasio, KolomBaru))

                nilaiMX(KolomBaru) = nilaiMXLama(KolomBaru) - (nilaiMSLama(sortirKolomS) _
                                                * nilaix(SortirRasio, KolomBaru))

            Next

            'nilai ms
            For KolomBaru = 1 To totalS
                'entry lama - (entry *new)
                ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                nilaiMS(KolomBaru) = nilaiMSLama(KolomBaru) - (nilaiMSLama(sortirKolomS) _
                                                * nilaiS(SortirRasio, KolomBaru))

            Next

            'nilai ma

            For KolomBaru = 1 To totalA
                'entry lama - (entry *new)
                ' nilaiS(barisBaru, KolomBaru) = nilaiXLama(barisBaru, KolomBaru) - (nilaiXLama(barisBaru, SortirKolom) * nilaix(SortirRasio, KolomBaru))
                nilaiMA(KolomBaru) = nilaiMALama(KolomBaru) - (nilaiMSLama(sortirKolomS) _
                                                * nilaiA(SortirRasio, KolomBaru))

            Next
        End If 'akhir penentuan nilai sotir x atau sortir s
    End Sub

    Private Sub tabelAkhir()
        '=======================looping tabel awal====================
        'loop tabel atas
        'Dim loopingth = 0 to As Integer
        isi = "<table border='1'>" & vbCrLf & "<tr><th>variable</th>"
        For loopingth = 0 To bataskolom
            If loopingth < kolomS Then
                isi = isi & "<th>x" & loopingth & "</th>"
            ElseIf loopingth = bataskolom Then
                For i = 1 To totalS
                    isi = isi & "<th>s" & i & "</th>"
                Next
                For i = 1 To totalA
                    isi = isi & "<th>A" & i & "</th>"
                Next
                isi = isi & "<th>solusi</th></tr>"

                'ElseIf loopingth < bataskolom Then
                '    isi = isi & "<th>s" & (loopingth - JumlahX.Value) & "</th>"
            End If
        Next
        'isi = isi & "<th>rasio</th>"

        '==============menentukan isi table

        For looping1 = 0 To batasbaris
            'style="background-color: yellow">
            For loopj = 0 To bataskolom
                'menentukan data tujuan
                'pada data 0
                If looping1 = 0 And loopj = 0 Then
                    isi = isi & "<tr><td>" & "z </td>"
                    '============isi = isi & "<td>"
                    'setwarna(looping1, loopj, "")
                    isi = isi & "<td>"
                    isi = isi & nilaix(looping1, loopj)
                    Call tampilm(nilaiMX(loopj))

                    'if nilaimx(loopj) <> 0 then
                    '    isi = isi & " + " & nilaimx(loopj) & "m</td>"
                    'else
                    '    isi = isi & "</td>"
                    'end if
                ElseIf looping1 = 0 And loopj <> 0 And loopj <> bataskolom Then

                    'isi = isi & "<td>"
                    ' setwarna(looping1, loopj, "")
                    isi = isi & "<td>"
                    isi = isi & nilaix(looping1, loopj)
                    Call tampilm(nilaiMX(loopj))

                    'If nilaiMX(loopj) <> 0 Then
                    '    isi = isi & " + " & nilaiMX(loopj) & "M</td>"
                    'Else
                    '    isi = isi & "</td>"
                    'End If

                    'menentukan  table jika data bukan tujuan
                ElseIf looping1 <> 0 And loopj = 0 Then
                    'isi = isi & "<tr><td>s " & looping1 & "</td>"
                    'isi = isi & "<td>"


                    ' setkolomvariable(looping1, loopj)
                    setKolomVariable(looping1)
                    ' isi = isi & looping1 & "</td><td>" & nilaix(looping1, loopj) & "</td>"
                    'setwarna(looping1, loopj, "")
                    isi = isi & "<td>"
                    isi = isi & nilaix(looping1, loopj) & "</td>"
                    'cek menentukan letak solusi pembatas s dan solusi
                ElseIf loopj <> 0 And loopj < kolomS Then
                    'isi = isi & "<td>"
                    'setwarna(looping1, loopj, "")
                    isi = isi & "<td>"
                    isi = isi & nilaix(looping1, loopj) & "</td>"

                ElseIf loopj = bataskolom Then
                    'jika data tujuan

                    If looping1 = 0 Then

                        For masukS = 1 To totalS

                            isi = isi & "<td>" & nilaiS(looping1, masukS)
                            'isi = isi & nilaiMS(masukS) & "</td>"
                            Call tampilm(nilaiMS(masukS))
                        Next
                        For masukA = 1 To totalA

                            isi = isi & "<td>" & nilaiA(looping1, masukA)
                            ' isi = isi & nilaiMA(masukA) & "</td>"

                            Call tampilm(nilaiMA(masukA))
                        Next

                        isi = isi & "<td>" & nilaix(looping1, loopj)
                        Call tampilm(nilaiMX(loopj))
                        isi = isi & " </tr>"
                        

                        'jika bukan data tujuan
                    Else
                        For masukS = 1 To totalS
                            ' setwarna(looping1, loopj, "")
                            isi = isi & "<td>"
                            isi = isi & nilaiS(looping1, masukS) & "</td>"
                        Next
                        For masukA = 1 To totalA
                            ' setwarna(looping1, loopj, "")
                            isi = isi & "<td>"
                            isi = isi & nilaiA(looping1, masukA) & "</td>"
                            ' isi = isi & "<th>A" & totalS & "</th>"
                        Next
                        isi = isi & "<td>" & nilaix(looping1, loopj) & "</td></tr>"
                    End If


                Else


                    setwarna(looping1, loopj, "")
                    isi = isi & nilaix(looping1, loopj) & "</td>"

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
        ' bataskolom = syarat.Value + JumlahX.Value + 1
        bataskolom = JumlahX.Value + 1
        'ReDim Preserve nilaix(batasbaris, bataskolom)





    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        Call hapusOutput()



        isi = ""
        '==================data ditambah ke aray==========================

        nilaiHitung(data.Value) = samadengan.Text
        nilaix(data.Value, 0) = x1.Value
        nilaix(data.Value, 1) = x2.Value

        'nilai solusi
        nilaix(data.Value, bataskolom) = solusi.Value

        If data.Value < 1 Then
            nilaix(data.Value, bataskolom) = 0
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
        Call aturFormat()
        If syarat.Value < data.Value Then
            data.Value = syarat.Value
        End If

        If data.Value = 0 Then
            solusi.Enabled = False
        Else
            solusi.Enabled = True
        End If
        'Call aturFormat()

        


    End Sub

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        nilaisama = 0
        'hapus output
        Iterasi = 0
        'Call hapusOutput()
        'My.Computer.FileSystem.DeleteFile("D:\output.html")
        'save data
        totalA = 0
        totalS = 0
        'mereset nilai a s dll ke 0 
        For i = 0 To 200
            For j = 0 To 200
                nilaiA(i, j) = 0
                nilaiS(i, j) = 0
                nilaiALama(i, j) = 0
                nilaiSLama(i, j) = 0




            Next

        Next
        'mereset nilai m ke 0
        For i = 0 To 100
            nilaiMA(i) = 0
            nilaiMS(i) = 0
            nilaiMX(i) = 0
            posisiMA(i) = 0
            nilaiMALama(i) = 0
            nilaiMSLama(i) = 0
            nilaiMXLama(i) = 0
        Next
        'menentukan nilai a dan s yang terisi
        For i = 1 To batasbaris
            ' samadengan.Items.Add("=")
            'samadengan.Items.Add("=<")
            'samadengan.Items.Add("=>")
            If nilaiHitung(i) = "=" Then
                totalA = totalA + 1
                nilaiA(i, totalA) = 1
                kolomVariable(i) = "A" & totalA
                posisiMA(i) = i
            ElseIf nilaiHitung(i) = "=<" Then
                totalS = totalS + 1
                nilaiS(i, totalS) = 1
                kolomVariable(i) = "S" & totalS
            Else
                totalA = totalA + 1
                totalS = totalS + 1
                nilaiS(i, totalS) = -1
                nilaiA(i, totalA) = 1
                kolomVariable(i) = "A" & totalA
                posisiMA(i) = i
            End If


        Next

        '=====mencari nilai m pada x
        For j = 0 To bataskolom
            For i = 1 To batasbaris

                If posisiMA(i) <> 0 Then
                    nilaiMX(j) = nilaiMX(j) + nilaix(i, j)
                End If

            Next
        Next
        For j = 1 To totalS
            For i = 1 To batasbaris

                If posisiMA(i) <> 0 Then
                    nilaiMS(j) = nilaiMS(j) + nilaiS(i, j)
                End If

            Next
        Next
        'For j = 1 To totalA
        '    For i = 1 To batasbaris

        '        If posisiMA(i) <> 0 Then
        '            nilaiMA(j) = nilaiMA(j) + nilaiA(i, j)
        '        End If

        '    Next
        'Next
        For i = 0 To bataskolom - 1
            nilaix(0, i) = nilaix(0, i) * -1
        Next
        output = "<br>"

        '===================buat tabel sekarang dan ulangi
        
        For loopcari = 0 To batasbaris - 1 Or nilaisama = True

            'For loopcari = 0 To 1
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

        variable.Text = kolomS


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
        
    End Sub

    Private Sub x1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x1.ValueChanged
        
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

    Private Sub samadengan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles samadengan.SelectedIndexChanged

        ' samadengan.Items.Add("=")
        'samadengan.Items.Add("=<")
        'samadengan.Items.Add("=>")

      

    End Sub
End Class
