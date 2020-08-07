'V 1.0.1
Public Class level5
    Dim scores As Integer
    Dim randomwarna As Integer
    Dim gue As Integer
    Dim lagimarah As Integer
    Dim randomobstacle As Integer
    Dim a As Integer = 270
    Dim b = 590
    Dim jalan1 As Integer
    Dim jalan2 As Integer
    Dim pembatas As New Button
    Dim x As Double = 450
    Dim y As Double = 570
    Dim yawal As Integer = 570
    Dim ypojokatas As Integer = 42
    Dim xpojokkanan As Integer = 600
    Dim xawal As Integer = 41
    Dim movex As Boolean = True
    Dim movey As Boolean = True
    Dim yminus As Double = 3
    Dim yplus As Double = 3
    Dim xminus As Double = 3
    Dim xplus As Double = 3
    Dim lokasia As Double
    Dim lokasib As Double
    Dim jumlahobstacle As Integer = 10
    Dim coorx(100, 100) As Integer
    Dim coory(100, 100) As Integer
    Dim lebar As Integer = 124
    Dim bagi5 As Integer = lebar / 5

    Dim livenya As Integer = 2

    Dim gerakan As Integer = 15

    Dim penentucek2 As Integer = 0

    Dim win As Integer
    Dim winner As Integer = 110

    Dim cekred As Boolean = False
    Dim isired As String
    Dim isiredx As Integer
    Dim isiredy As Integer
    Dim coorred As String
    Dim redbutton As Button

    Dim cekgray As Boolean = False
    Dim isigrayx As Integer
    Dim isigrayy As Integer
    Dim isigray As String
    Dim coorgray As String
    Dim graybutton As Button

    Dim cekgreen As Boolean = False
    Dim isigreenx As Integer
    Dim isigreeny As Integer
    Dim isigreen As String
    Dim coorgreen As String
    Dim greenbutton As Button

    Dim cekblue As Boolean = False
    Dim isibluex As Integer
    Dim isibluey As Integer
    Dim isiblue As String
    Dim coorblue As String
    Dim bluebutton As Button

    Dim cekyellow As Boolean = False
    Dim isiyellowx As Integer
    Dim isiyellowy As Integer
    Dim isiyellow As String
    Dim cooryellow As String
    Dim yellowbutton As Button

    Dim cekblack As Boolean = False
    Dim isiblackx As Integer
    Dim isiblacky As Integer
    Dim isiblack As String
    Dim coorblack As String
    Dim blackbutton As Button

    Dim warnaaneh As Integer

    Dim cek1 As Integer
    Dim cek11 As Integer
    Dim cek2 As Integer
    Dim cek22 As Integer
    Dim cek3 As Integer
    Dim cek33 As Integer
    Dim cek4 As Integer
    Dim cek44 As Integer
    Dim cek5 As Integer
    Dim cek55 As Integer
    Dim batasku As Integer = 1000

    Private Sub level1_keydown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Menentukan Behaviour Key D ke Kanan dan Key A ke Kiri       
        If e.KeyCode = Keys.D Then
            If a < 494 Then
                a += gerakan
                pantulanbar.Location = New Point(a, b)
            End If
        ElseIf e.KeyCode = Keys.A Then
            If a > 44 Then
                a -= gerakan
                pantulanbar.Location = New Point(a, b)
            End If
        End If
        If e.KeyCode = Keys.P Then
            If jalan.Enabled = True Then
                jalan.Enabled = False
            Else
                jalan.Enabled = True
            End If
        End If
        If e.KeyCode = Keys.Space Then
            win = 109
        End If
    End Sub

    Private Sub jalan_Tick(sender As Object, e As EventArgs) Handles jalan.Tick
        warnaaneh += 1
        If warnaaneh < 100 Then
            Me.BackColor = Color.Black
            Lives.ForeColor = Color.White
            score.ForeColor = Color.White
        ElseIf warnaaneh < 200 Then
            Me.BackColor = Color.Khaki
            Lives.ForeColor = Color.White
            score.ForeColor = Color.White
        ElseIf warnaaneh < 300 Then
            Me.BackColor = Color.Gray
            Lives.ForeColor = Color.Black
            score.ForeColor = Color.Black
        ElseIf warnaaneh < 400 Then
            Me.BackColor = Color.Chocolate
            Lives.ForeColor = Color.White
            score.ForeColor = Color.White
        ElseIf warnaaneh < 500 Then
            Me.BackColor = Color.Maroon
            Lives.ForeColor = Color.White
            score.ForeColor = Color.White
        ElseIf warnaaneh = 500 Then
            warnaaneh = 0
        End If
        'Command untuk bonus items
        If cek1 = 1 Then
            cek11 += 10
            xplus = 8
            xminus = 8
            If cek11 = batasku Then
                cek1 = 0
            End If
        End If
        If cek2 = 1 Then
            cek22 += 10
            penentucek2 = 1
            If cek22 = batasku + 1000 Then
                cek2 = 0
                penentucek2 = 0
            End If
        End If
        If cek3 = 1 Then
            cek33 += 10
            yplus = 8
            yminus = 8
            If cek33 = batasku Then
                cek3 = 0
            End If
        End If
        If cek4 = 1 Then
            cek44 += 10
            gerakan = 20
            If cek44 = batasku Then
                cek4 = 0
                gerakan = 15
            End If
        End If
        If cek5 = 1 Then
            cek55 += 10
            jalan.Interval = 30
            If cek55 = batasku Then
                cek5 = 0
                jalan.Interval = 10
            End If
        End If
        'Pergerakan Kanan kiri
        If x < xpojokkanan And movex = True Then
            x += xplus
        ElseIf x >= xpojokkanan Then
            movex = False
        End If
        If x > xawal And movex = False Then
            x -= xminus
        ElseIf x <= xawal Then
            movex = True
        End If

        'Pergerakan Atas Bawah dan pembatas menang kalah
        If y > ypojokatas And movey = True Then
            y -= yminus
        ElseIf y <= ypojokatas Then
            movey = False
        End If

        If y >= yawal And y <= yawal + 23 And x >= a And x <= a + 124 Then
            movey = True
            pantulanbarsound()
            'Sudut berubah ketika kena pantulan bar
            If a + 0 <= x And x <= a + bagi5 Then
                xplus = 4
                xminus = 4
                movex = False
            ElseIf a + bagi5 <= x And x <= a + (bagi5 * 2) Then
                xplus = 3
                xminus = 3
            ElseIf a + (bagi5 * 2) <= x And x <= a + (bagi5 * 3) Then
                xplus = 2
                xminus = 2
            ElseIf a + (bagi5 * 3) <= x And x <= a + (bagi5 * 4) Then
                xplus = 3
                xminus = 3
            ElseIf a + (bagi5 * 4) <= x And x <= a + (bagi5 * 5) Then
                xplus = 4
                xminus = 4
                movex = True
            End If
        ElseIf y < yawal + 400 And movey = False Then
            y += yplus
            If y > yawal + 350 And a + 124 < x Then
                gameover()
                Me.Close()
                MessageBox.Show("Gini aja ga bisa", "Sori men lu cupu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf y > yawal + 350 And x < a Then
                gameover()
                Me.Close()
                MessageBox.Show("Gini aja ga bisa", "Sori men lu cupu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If y > yawal + 30 Then
            If livenya > 1 Then
                If movey = True Then
                    movey = False
                Else
                    movey = True
                End If
                livenya -= 1
                Lives.Text = "Lives : " & livenya
            Else
                bola.Visible = False
                pantulanbar.Visible = False
                Lives.Text = "Lives : 0, Game Over!"
            End If
        End If
        bola.Location = New Point(x, y)

        'Cek kena kotak yang sudah dibuat
        For i = 0 To jumlahobstacle
            For j = 0 To jumlahobstacle
                If coorx(i, j) <= x And x <= coorx(i, j) + 50 Then
                    If coory(i, j) <= y And y <= coory(i, j) + 20 Then
                        If coorx(i, j) = x Then
                            coorx(i, j) = 0
                            coory(i, j) = 0
                            removeobstacle(i & "_" & j)
                            If penentucek2 = 0 Then
                                movex = False
                                If coory(i, j) = y Then
                                    movey = True
                                ElseIf coory(i, j) + 20 = y Then
                                    movey = False
                                End If
                            End If
                        ElseIf coorx(i, j) + 50 = x Then
                            coorx(i, j) = 0
                            coory(i, j) = 0
                            removeobstacle(i & "_" & j)
                            If penentucek2 = 0 Then
                                movex = True
                                If coory(i, j) = y Then
                                    movey = True
                                ElseIf coory(i, j) + 20 = y Then
                                    movey = False
                                End If
                            End If
                        Else
                            coorx(i, j) = 0
                            coory(i, j) = 0
                            removeobstacle(i & "_" & j)
                            If penentucek2 = 0 Then
                                If movey = True Then
                                    movey = False
                                ElseIf movey = False Then
                                    movey = True
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Next

    End Sub
    Sub removeobstacle(obstacles As String)
        scores += 100
        score.Text = "Score : " & scores
        Randomize()
        win += 1
        Dim rndm As Integer
        Dim tombol As Button
        tombol = Me.Controls(obstacles)
        If tombol.BackColor = Color.Red Then
            rndm = Rnd() * 9 + 1
            If rndm <= 2 Then
                isiredx = tombol.Location.X
                isiredy = tombol.Location.Y
                cekred = True
                coorred = tombol.Name
                redbutton = New Button
                gue = CInt(tombol.Name.Substring(0, tombol.Name.IndexOf("_")))
                lagimarah = CInt(tombol.Name.Substring(tombol.Name.IndexOf("_") + 1, tombol.Name.Length - tombol.Name.IndexOf("_") - 1))
                With redbutton
                    .Parent = Me
                    .Width = 20
                    .Height = 20
                    .Location = New Point(isiredx, isiredy)
                    .BackColor = Color.Red
                    .Name = gue & "r" & lagimarah
                End With
                Me.Controls.Add(redbutton)
            End If
        End If
        If tombol.BackColor = Color.Gray Then
            rndm = Rnd() * 9 + 1
            If rndm <= 2 Then
                isigrayx = tombol.Location.X
                isigrayy = tombol.Location.Y
                cekgray = True
                coorgray = tombol.Name
                graybutton = New Button
                gue = CInt(tombol.Name.Substring(0, tombol.Name.IndexOf("_")))
                lagimarah = CInt(tombol.Name.Substring(tombol.Name.IndexOf("_") + 1, tombol.Name.Length - tombol.Name.IndexOf("_") - 1))
                With graybutton
                    .Parent = Me
                    .Width = 20
                    .Height = 20
                    .Location = New Point(isigrayx, isigrayy)
                    .BackColor = Color.Gray
                    .Name = gue & "a" & lagimarah
                End With
                Me.Controls.Add(graybutton)
            End If
        End If
        If tombol.BackColor = Color.Blue Then
            rndm = Rnd() * 9 + 1
            If rndm <= 2 Then
                isibluex = tombol.Location.X
                isibluey = tombol.Location.Y
                cekblue = True
                coorblue = tombol.Name
                bluebutton = New Button
                gue = CInt(tombol.Name.Substring(0, tombol.Name.IndexOf("_")))
                lagimarah = CInt(tombol.Name.Substring(tombol.Name.IndexOf("_") + 1, tombol.Name.Length - tombol.Name.IndexOf("_") - 1))
                With bluebutton
                    .Parent = Me
                    .Width = 20
                    .Height = 20
                    .Location = New Point(isibluex, isibluey)
                    .BackColor = Color.Blue
                    .Name = gue & "b" & lagimarah
                End With
                Me.Controls.Add(bluebutton)
            End If
        End If
        If tombol.BackColor = Color.Green Then
            rndm = Rnd() * 9 + 1
            If rndm <= 2 Then
                isigreenx = tombol.Location.X
                isigreeny = tombol.Location.Y
                cekgreen = True
                coorgreen = tombol.Name
                greenbutton = New Button
                gue = CInt(tombol.Name.Substring(0, tombol.Name.IndexOf("_")))
                lagimarah = CInt(tombol.Name.Substring(tombol.Name.IndexOf("_") + 1, tombol.Name.Length - tombol.Name.IndexOf("_") - 1))
                With greenbutton
                    .Parent = Me
                    .Width = 20
                    .Height = 20
                    .Location = New Point(isigreenx, isigreeny)
                    .BackColor = Color.Green
                    .Name = gue & "e" & lagimarah
                End With
                Me.Controls.Add(greenbutton)
            End If
        End If
        If tombol.BackColor = Color.Yellow Then
            rndm = Rnd() * 9 + 1
            If rndm <= 2 Then
                isiyellowx = tombol.Location.X
                isiyellowy = tombol.Location.Y
                cekyellow = True
                cooryellow = tombol.Name
                yellowbutton = New Button
                gue = CInt(tombol.Name.Substring(0, tombol.Name.IndexOf("_")))
                lagimarah = CInt(tombol.Name.Substring(tombol.Name.IndexOf("_") + 1, tombol.Name.Length - tombol.Name.IndexOf("_") - 1))
                With yellowbutton
                    .Parent = Me
                    .Width = 20
                    .Height = 20
                    .Location = New Point(isiyellowx, isiyellowy)
                    .BackColor = Color.Yellow
                    .Name = gue & "y" & lagimarah
                End With
                Me.Controls.Add(yellowbutton)
            End If
        End If
        If tombol.BackColor = Color.Black Then
            rndm = Rnd() * 9 + 1
            If rndm <= 2 Then
                isiblackx = tombol.Location.X
                isiblacky = tombol.Location.Y
                cekblack = True
                coorblack = tombol.Name
                blackbutton = New Button
                gue = CInt(tombol.Name.Substring(0, tombol.Name.IndexOf("_")))
                lagimarah = CInt(tombol.Name.Substring(tombol.Name.IndexOf("_") + 1, tombol.Name.Length - tombol.Name.IndexOf("_") - 1))
                With blackbutton
                    .Parent = Me
                    .Width = 20
                    .Height = 20
                    .Location = New Point(isiblackx, isiblacky)
                    .BackColor = Color.Black
                    .Name = gue & "p" & lagimarah
                End With
                Me.Controls.Add(blackbutton)
            End If
        End If
        Me.Controls.Remove(tombol)
        If win = winner Then
            finished()
            Me.Close()
            MsgBox("WIN")
        End If
    End Sub
    Sub finished()
        Try
            My.Computer.Audio.Play("C:\Users\user\Desktop\Bounce Ball SFX\Finish.wav", AudioPlayMode.Background)
        Catch ex As Exception

        End Try
    End Sub
    Sub pantulanbarsound()
        Try
            My.Computer.Audio.Play("C:\Users\user\Desktop\Bounce Ball SFX\HitPantul.wav", AudioPlayMode.Background)
        Catch ex As Exception

        End Try
    End Sub
    Sub gameover()
        Try
            My.Computer.Audio.Play("C:\Users\user\Desktop\Bounce Ball SFX\GameOver.wav", AudioPlayMode.Background)
        Catch ex As Exception

        End Try
    End Sub
    Sub bgm()
        Try
            Dim player As New Media.SoundPlayer
            player.SoundLocation = "C:\Users\user\Desktop\Bounce Ball SFX\ThreeCards.wav"
            player.Play()
        Catch ex As Exception

        End Try
        'My.Computer.Audio.Play("C:\Users\user\Desktop\Bounce Ball SFX\BGM.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub level5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Lives.Text = "Lives : " & livenya
        bgm()
        Dim why As Integer
        why = pantulanbar.Width
        Randomize()
        'Border Level 1
        For i = 0 To 30
            jalan2 += 20
            jalan1 = 0
            For j = 0 To 30
                jalan1 += 20
                If j = 0 Or j = 30 Then
                    pembatas = New Button
                    With pembatas
                        .Parent = Me
                        .Height = 20
                        .Width = 20
                        .Location = New Point(jalan1, jalan2)
                        .BackColor = Color.Black
                    End With
                    Me.Controls.Add(pembatas)
                End If
                If i = 0 Or i = 30 Then
                    pembatas = New Button
                    With pembatas
                        .Parent = Me
                        .Height = 20
                        .Width = 20
                        .Location = New Point(jalan1, jalan2)
                        .BackColor = Color.Black
                    End With
                    Me.Controls.Add(pembatas)
                End If
            Next
        Next

        'Ukuran
        Me.Width = 700
        Me.Height = 700

        'Location Awal Bar Pantul
        pantulanbar.Location = New Point(a, b)

        'Location kotak obstacle yang ada
        For i = 0 To jumlahobstacle
            lokasib += 20
            lokasia = 0
            For j = 0 To jumlahobstacle
                lokasia += 50
                randomwarna = 0
                randomwarna = Rnd() * 11 + 1
                pembatas = New Button
                coorx(i, j) = lokasia
                coory(i, j) = lokasib
                With pembatas
                    .Parent = Me
                    .Height = 20
                    .Width = 50
                    .Name = i & "_" & j
                    .Location = New Point(lokasia, lokasib)
                End With
                Me.Controls.Add(pembatas)
                If randomwarna < 3 Then
                    pembatas.BackColor = Color.Red
                ElseIf randomwarna < 5 Then
                    pembatas.BackColor = Color.Blue
                ElseIf randomwarna < 7 Then
                    pembatas.BackColor = Color.Yellow
                ElseIf randomwarna < 9 Then
                    pembatas.BackColor = Color.Green
                ElseIf randomwarna < 11 Then
                    pembatas.BackColor = Color.Gray
                ElseIf randomwarna < 13 Then
                    pembatas.BackColor = Color.Black
                End If
            Next
        Next
    End Sub

    Private Sub itemdrop_Tick(sender As Object, e As EventArgs) Handles itemdrop.Tick
        If cekred = True Then
            isireds(coorred.Substring(0, coorred.IndexOf("_")) & "r" & coorred.Substring(coorred.IndexOf("_") + 1, coorred.Length - coorred.IndexOf("_") - 1))
        End If
        If cekblue = True Then
            isiblues(coorblue.Substring(0, coorblue.IndexOf("_")) & "b" & coorblue.Substring(coorblue.IndexOf("_") + 1, coorblue.Length - coorblue.IndexOf("_") - 1))
        End If
        If cekgray = True Then
            isigrays(coorgray.Substring(0, coorgray.IndexOf("_")) & "a" & coorgray.Substring(coorgray.IndexOf("_") + 1, coorgray.Length - coorgray.IndexOf("_") - 1))
        End If
        If cekgreen = True Then
            isigreens(coorgreen.Substring(0, coorgreen.IndexOf("_")) & "e" & coorgreen.Substring(coorgreen.IndexOf("_") + 1, coorgreen.Length - coorgreen.IndexOf("_") - 1))
        End If
        If cekyellow = True Then
            isiyellows(cooryellow.Substring(0, cooryellow.IndexOf("_")) & "y" & cooryellow.Substring(cooryellow.IndexOf("_") + 1, cooryellow.Length - cooryellow.IndexOf("_") - 1))
        End If
        If cekblack = True Then
            isiblacks(coorblack.Substring(0, coorblack.IndexOf("_")) & "p" & coorblack.Substring(coorblack.IndexOf("_") + 1, coorblack.Length - coorblack.IndexOf("_") - 1))
        End If
    End Sub
    Sub isireds(start As String)
        Dim what As Button
        what = Me.Controls(start)
        isiredy += 5
        what.Location = New Point(isiredx, isiredy)
        If isiredy > yawal + 100 Then
            cekred = False
            Me.Controls.Remove(what)
        End If
        If isiredy >= yawal And isiredy <= yawal + 23 Then
            If isiredx >= a And isiredx <= a + 124 Then
                what.Visible = False
                Me.Controls.Remove(what)
                cekred = False
                cek1 = 1
                cek11 = 0
            End If
        End If
    End Sub
    Sub isigreens(start As String)
        Dim what As Button
        what = Me.Controls(start)
        isigreeny += 5
        what.Location = New Point(isigreenx, isigreeny)
        If isigreeny > yawal + 100 Then
            cekgreen = False
            Me.Controls.Remove(what)
        End If
        If isigreeny >= yawal And isigreeny <= yawal + 25 Then
            If isigreenx >= a And isigreenx <= a + 124 Then
                what.Visible = False
                Me.Controls.Remove(what)
                cekgreen = False
                cek2 = 1
                cek22 = 0
            End If
        End If
    End Sub
    Sub isiblues(start As String)
        Dim what As Button
        what = Me.Controls(start)
        isibluey += 5
        what.Location = New Point(isibluex, isibluey)
        If isibluey > yawal + 100 Then
            cekblue = False
            Me.Controls.Remove(what)
        End If
        If isibluey >= yawal And isibluey <= yawal + 25 Then
            If isibluex >= a And isibluex <= a + 124 Then
                what.Visible = False
                Me.Controls.Remove(what)
                cekblue = False
                cek3 = 1
                cek33 = 0
            End If
        End If
    End Sub
    Sub isigrays(start As String)
        Dim what As Button
        what = Me.Controls(start)
        isigrayy += 5
        what.Location = New Point(isigrayx, isigrayy)
        If isigrayy > yawal + 100 Then
            cekgray = False
            Me.Controls.Remove(what)
        End If
        If isigrayy >= yawal And isigrayy <= yawal + 25 Then
            If isigrayx >= a And isigrayx <= a + 124 Then
                what.Visible = False
                Me.Controls.Remove(what)
                cekgray = False
                cek4 = 1
                cek44 = 0
            End If
        End If
    End Sub
    Sub isiyellows(start As String)
        Dim what As Button
        what = Me.Controls(start)
        isiyellowy += 5
        what.Location = New Point(isiyellowx, isiyellowy)
        If isiyellowy > yawal + 100 Then
            cekyellow = False
            Me.Controls.Remove(what)
        End If
        If isiyellowy >= yawal And isiyellowy <= yawal + 23 Then
            If isiyellowx >= a And isiyellowx <= a + 124 Then
                what.Visible = False
                Me.Controls.Remove(what)
                cekyellow = False
                cek5 = 1
                cek55 = 0
            End If
        End If
    End Sub
    Sub isiblacks(start As String)
        Dim what As Button
        what = Me.Controls(start)
        isiblacky += 5
        what.Location = New Point(isiblackx, isiblacky)
        If isiblacky > yawal + 100 Then
            cekblack = False
            Me.Controls.Remove(what)
        End If
        If isiblacky >= yawal And isiblacky <= yawal + 23 Then
            If isiblackx >= a And isiblackx <= a + 124 Then
                what.Visible = False
                Me.Controls.Remove(what)
                cekblack = False
                livenya += 1
                Lives.Text = "Lives : " & livenya
            End If
        End If
    End Sub
End Class