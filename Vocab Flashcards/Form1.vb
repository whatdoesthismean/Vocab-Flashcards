Public Class Form1

    Dim R As IO.StreamReader
    Dim intSub As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click


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


        lblKana.Text = lstNihongo.Items(intSub).ToString 'put first vocabulary words into form labels
        lblEng.Text = lstEng.Items(intSub).ToString

        If rdoNihongo.Checked Then
            lblKana.Visible = True
            lblEng.Visible = False
        Else
            lblKana.Visible = False
            lblEng.Visible = True
        End If

        btnFlip.Visible = True
        btnNext.Visible = True
        btnPrev.Visible = True

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If intSub < lstNihongo.Items.Count - 1 Then
            intSub += 1
        Else
            intSub = 0
        End If


        lblKana.Text = lstNihongo.Items(intSub).ToString
        lblEng.Text = lstEng.Items(intSub).ToString

        If rdoNihongo.Checked Then
            lblKana.Visible = True
            lblEng.Visible = False
        Else
            lblKana.Visible = False
            lblEng.Visible = True
        End If

        btnFlip.Focus()

    End Sub

    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click



        If rdoNihongo.Checked Then
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

        btnFlip.Focus()

    End Sub


    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click




        If intSub > 0 Then
            intSub -= 1
            lblKana.Text = lstNihongo.Items(intSub).ToString
            lblEng.Text = lstEng.Items(intSub).ToString
        Else
            intSub = lstNihongo.Items.Count - 1
            lblKana.Text = lstNihongo.Items(intSub).ToString
            lblEng.Text = lstEng.Items(intSub).ToString
        End If

        If rdoNihongo.Checked Then
            lblKana.Visible = True
            lblEng.Visible = False
        Else
            lblKana.Visible = False
            lblEng.Visible = True
        End If

        btnFlip.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        lstNihongo.Items.Clear()
        lstEng.Items.Clear()

        R = New IO.StreamReader("nihongo.txt")
        While (R.Peek() > -1)
            lstNihongo.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("eng.txt")
        While (R.Peek() > -1)
            lstEng.Items.Add(R.ReadLine)
        End While
        R.Close()

        Form2.Show()

    End Sub
End Class
