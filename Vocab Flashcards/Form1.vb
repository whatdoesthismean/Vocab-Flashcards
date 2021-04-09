Public Class Form1

    Dim R As IO.StreamReader
    Dim intSub As Integer 'works with list item count to select card order
    Dim rand As New Random
    Dim intRand As Integer 'works with list item count to select random card
    Dim intKeep As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        lstNihongo.Items.Clear() 'clear the list boxes so old list items aren't duplicated
        lstEng.Items.Clear()
        lstRand.Items.Clear()

        If rdoAdj.Checked Then

            R = New IO.StreamReader("nihongo.txt") 'read japanese vocabulary list from text file
            While (R.Peek() > -1)
                lstNihongo.Items.Add(R.ReadLine)
            End While
            R.Close()


            R = New IO.StreamReader("eng.txt") 'read english vocabulary list from text file
            While (R.Peek() > -1)
                lstEng.Items.Add(R.ReadLine)
            End While
            R.Close()

        ElseIf rdoNouns.Checked Then

            R = New IO.StreamReader("nihongoNouns.txt") 'read japanese vocabulary list from text file
            While (R.Peek() > -1)
                lstNihongo.Items.Add(R.ReadLine)
            End While
            R.Close()


            R = New IO.StreamReader("engNouns.txt") 'read english vocabulary list from text file
            While (R.Peek() > -1)
                lstEng.Items.Add(R.ReadLine)
            End While
            R.Close()

        Else

            R = New IO.StreamReader("nihongoVerbs.txt") 'read japanese vocabulary list from text file
            While (R.Peek() > -1)
                lstNihongo.Items.Add(R.ReadLine)
            End While
            R.Close()


            R = New IO.StreamReader("engVerbs.txt") 'read english vocabulary list from text file
            While (R.Peek() > -1)
                lstEng.Items.Add(R.ReadLine)
            End While
            R.Close()

        End If

        If rdoRandom.Checked Then

            If lstRand.Items.Count = lstNihongo.Items.Count Then
                lstRand.Items.Clear()
                intRand = rand.Next(lstNihongo.Items.Count) 'chooses random card
            Else
                intRand = rand.Next(lstNihongo.Items.Count)
            End If

            Do While lstRand.Items.Contains(intRand) 'makes sure all cards are used before repeating any card

                intRand = rand.Next(lstNihongo.Items.Count)

            Loop

            lblKana.Text = lstNihongo.Items(intRand).ToString   'display randomly chosen card
            lblEng.Text = lstEng.Items(intRand).ToString

            lstRand.Items.Add(intRand) 'stores index of currently displayed random card

        Else

            lblKana.Text = lstNihongo.Items(intSub).ToString   'load next flashcard into form labels
            lblEng.Text = lstEng.Items(intSub).ToString

        End If

        If rdoNihongo.Checked Then 'select which side of flashcard shows first based on radio button selection
            lblKana.Visible = True
            lblEng.Visible = False
        Else
            lblKana.Visible = False
            lblEng.Visible = True
        End If

        btnFlip.Visible = True 'make user controls appear
        btnNext.Visible = True
        btnPrev.Visible = True
        grpNihongo.Visible = True
        grpEng.Visible = True
        picStart.Visible = False

        btnFlip.Focus()

    End Sub

    Private Sub rdoAdj_CheckedChanged(sender As Object,
      e As EventArgs) Handles rdoAdj.CheckedChanged
        btnFlip.Visible = False 'make user controls disappear
        btnNext.Visible = False
        btnPrev.Visible = False
        grpNihongo.Visible = False
        grpEng.Visible = False
        picStart.Visible = True
    End Sub

    Private Sub rdoNouns_CheckedChanged(sender As Object,
      e As EventArgs) Handles rdoNouns.CheckedChanged
        btnFlip.Visible = False 'make user controls disappear
        btnNext.Visible = False
        btnPrev.Visible = False
        grpNihongo.Visible = False
        grpEng.Visible = False
        picStart.Visible = True
    End Sub

    Private Sub rdoVerbs_CheckedChanged(sender As Object,
      e As EventArgs) Handles rdoVerbs.CheckedChanged
        btnFlip.Visible = False 'make user controls disappear
        btnNext.Visible = False
        btnPrev.Visible = False
        grpNihongo.Visible = False
        grpEng.Visible = False
        picStart.Visible = True
    End Sub

    Private Sub rdoRandom_CheckedChanged(sender As Object,
      e As EventArgs) Handles rdoRandom.CheckedChanged
        btnFlip.Visible = False 'make user controls disappear
        btnNext.Visible = False
        btnPrev.Visible = False
        grpNihongo.Visible = False
        grpEng.Visible = False
        picStart.Visible = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If rdoRandom.Checked Then

            If lstRand.Items.Count = lstNihongo.Items.Count Then
                lstRand.Items.Clear()
                intRand = rand.Next(lstNihongo.Items.Count) 'chooses random card
            Else
                intRand = rand.Next(lstNihongo.Items.Count)
            End If

            Do While intRand = intKeep

                intRand = rand.Next(lstNihongo.Items.Count)

            Loop

            Do While lstRand.Items.Contains(intRand) 'makes sure all cards are used before repeating any card

                intRand = rand.Next(lstNihongo.Items.Count)

            Loop

            lblKana.Text = lstNihongo.Items(intRand).ToString   'display randomly chosen card
            lblEng.Text = lstEng.Items(intRand).ToString

            lstRand.Items.Add(intRand) 'stores index of currently displayed random card
            intKeep = intRand

        ElseIf rdoOrdered.Checked Then

            If intSub < lstNihongo.Items.Count - 1 Then  'cycle through cards, after last card on list, return to first card
                intSub += 1
                lblKana.Text = lstNihongo.Items(intSub).ToString   ' load next flashcard into form labels
                lblEng.Text = lstEng.Items(intSub).ToString
            Else
                intSub = 0
                lblKana.Text = lstNihongo.Items(intSub).ToString   'load next flashcard into form labels
                lblEng.Text = lstEng.Items(intSub).ToString
            End If

        End If




        If rdoNihongo.Checked Then  ' select which side of flashcard shows first
            lblKana.Visible = True
            lblEng.Visible = False
        Else
            lblKana.Visible = False
            lblEng.Visible = True
        End If

        btnFlip.Focus()      'return focus to flip button

    End Sub

    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click

        If rdoNihongo.Checked Then          'flip the flashcard
            If lblEng.Visible = False Then
                lblEng.Visible = True
            Else
                lblEng.Visible = False
            End If
        Else
            If lblKana.Visible = False Then
                lblKana.Visible = True
            Else
                lblKana.Visible = False
            End If
        End If

        btnNext.Focus()     'return focus to next button

    End Sub


    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click

        If rdoRandom.Checked Then       'display flashcards in random order

            If lstRand.Items.Count = lstNihongo.Items.Count Then
                lstRand.Items.Clear()
                intRand = rand.Next(lstNihongo.Items.Count) 'chooses random card
            Else
                intRand = rand.Next(lstNihongo.Items.Count)
            End If

            Do While lstRand.Items.Contains(intRand) 'makes sure all cards are used before repeating any card

                intRand = rand.Next(lstNihongo.Items.Count)

            Loop

            lblKana.Text = lstNihongo.Items(intRand).ToString   'display randomly chosen card
            lblEng.Text = lstEng.Items(intRand).ToString

            lstRand.Items.Add(intRand) 'stores index of currently displayed random card

        ElseIf rdoOrdered.Checked Then

            If intSub > 0 Then          'cycle through flashcards in reverse order

                intSub -= 1

                lblKana.Text = lstNihongo.Items(intSub).ToString
                lblEng.Text = lstEng.Items(intSub).ToString

            Else

                intSub = lstNihongo.Items.Count - 1

                lblKana.Text = lstNihongo.Items(intSub).ToString
                lblEng.Text = lstEng.Items(intSub).ToString

            End If

        End If

        If rdoNihongo.Checked Then  'determine which side of flashcard to show first
            lblKana.Visible = True
            lblEng.Visible = False
        Else
            lblKana.Visible = False
            lblEng.Visible = True
        End If

        btnFlip.Focus()     'return focus to flip button

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()  'close the program

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        lstNihongo.Items.Clear()    'clear list items so old list items aren't duplicated
        lstEng.Items.Clear()
        lstRand.Items.Clear()

        If rdoAdj.Checked Then

            R = New IO.StreamReader("nihongo.txt") 'read japanese adjective vocabulary list from text file
            While (R.Peek() > -1)
                lstNihongo.Items.Add(R.ReadLine)
            End While
            R.Close()


            R = New IO.StreamReader("eng.txt") 'read english adjective vocabulary list from text file
            While (R.Peek() > -1)
                lstEng.Items.Add(R.ReadLine)
            End While
            R.Close()

            Form2.lblType.Text = "Adjectives"

        ElseIf rdoNouns.Checked Then

            R = New IO.StreamReader("nihongoNouns.txt") 'read japanese noun vocabulary list from text file
            While (R.Peek() > -1)
                lstNihongo.Items.Add(R.ReadLine)
            End While
            R.Close()


            R = New IO.StreamReader("engNouns.txt") 'read english noun vocabulary list from text file
            While (R.Peek() > -1)
                lstEng.Items.Add(R.ReadLine)
            End While
            R.Close()

            Form2.lblType.Text = "Nouns"

        Else

            R = New IO.StreamReader("nihongoVerbs.txt") 'read japanese verb vocabulary list from text file
            While (R.Peek() > -1)
                lstNihongo.Items.Add(R.ReadLine)
            End While
            R.Close()

            R = New IO.StreamReader("engVerbs.txt") 'read english verb vocabulary list from text file
            While (R.Peek() > -1)
                lstEng.Items.Add(R.ReadLine)
            End While
            R.Close()

            Form2.lblType.Text = "Verbs"

        End If

        btnFlip.Visible = False 'make user controls disappear
        btnNext.Visible = False
        btnPrev.Visible = False
        grpNihongo.Visible = False
        grpEng.Visible = False
        picStart.Visible = True

        Form2.Show()        'show [add new card] form

    End Sub
End Class

