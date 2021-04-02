Public Class Form1

    Dim R As IO.StreamReader
    Dim intSub As Integer 'works with list item count to select cards in order

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        lstNihongo.Items.Clear() 'clear the list boxes so old list items aren't duplicated
        lstEng.Items.Clear()

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

        lblKana.Text = lstNihongo.Items(intSub).ToString 'load first flashcard into form labels
        lblEng.Text = lstEng.Items(intSub).ToString

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

        btnFlip.Focus()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If intSub < lstNihongo.Items.Count - 1 Then  'cycle through cards, after last card on list, return to first card
            intSub += 1
        Else
            intSub = 0
        End If


        lblKana.Text = lstNihongo.Items(intSub).ToString   'load next flashcard into form labels
        lblEng.Text = lstEng.Items(intSub).ToString

        If rdoNihongo.Checked Then  'select which side of flashcard shows first
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




        If intSub > 0 Then      'cycle through flashcards in reverse order
            intSub -= 1
            lblKana.Text = lstNihongo.Items(intSub).ToString
            lblEng.Text = lstEng.Items(intSub).ToString
        Else
            intSub = lstNihongo.Items.Count - 1
            lblKana.Text = lstNihongo.Items(intSub).ToString
            lblEng.Text = lstEng.Items(intSub).ToString
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

        lstNihongo.Items.Clear()    'clear list items so old items aren't duplicated
        lstEng.Items.Clear()

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

            Form2.lblType.Text = "Adjectives"

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

            Form2.lblType.Text = "Nouns"

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

            Form2.lblType.Text = "Verbs"

        End If

        btnFlip.Visible = False 'make user controls disappear
        btnNext.Visible = False
        btnPrev.Visible = False
        grpNihongo.Visible = False
        grpEng.Visible = False

        Form2.Show()        'show [add new card] form

    End Sub
End Class

