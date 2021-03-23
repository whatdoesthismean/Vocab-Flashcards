Public Class Form2
    Dim W As IO.StreamWriter
    Dim R As IO.StreamReader
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        Dim I As Integer


        If Not String.IsNullOrEmpty(txtKanaNew.Text) And Not String.IsNullOrEmpty(txtEngNew.Text) Then

            lblNihongoPlease.Visible = False
            lblEngPlease.Visible = False


            Form1.lstNihongo.Items.Add(txtKanaNew.Text)
            Form1.lstEng.Items.Add(txtEngNew.Text)


            txtKanaNew.Text = ""
            txtEngNew.Text = ""



            W = New IO.StreamWriter("nihongo.txt")
            For I = 0 To Form1.lstNihongo.Items.Count - 1
                W.WriteLine(Form1.lstNihongo.Items.Item(I))
            Next
            W.Close()

            W = New IO.StreamWriter("eng.txt")
            For I = 0 To Form1.lstEng.Items.Count - 1
                W.WriteLine(Form1.lstEng.Items.Item(I))
            Next
            W.Close()

            lblSaved.Visible = True

            txtKanaNew.Focus()

        ElseIf String.IsNullOrEmpty(txtKanaNew.Text) And Not String.IsNullOrEmpty(txtEngNew.Text) Then

            lblNihongoPlease.Visible = True
            lblEngPlease.Visible = False
            lblSaved.Visible = False

        ElseIf String.IsNullOrEmpty(txtEngNew.Text) And Not String.IsNullOrEmpty(txtKanaNew.Text) Then

            lblNihongoPlease.Visible = False
            lblEngPlease.Visible = True
            lblSaved.Visible = False

        Else

            lblNihongoPlease.Visible = True
            lblEngPlease.Visible = True
            lblSaved.Visible = False

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        R = New IO.StreamReader("nihongo.txt")
        While (R.Peek() > -1)
            Form1.lstNihongo.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("eng.txt")
        While (R.Peek() > -1)
            Form1.lstEng.Items.Add(R.ReadLine)
        End While
        R.Close()

        Form1.Show()

        Me.Close()

    End Sub

    Private Sub txtKanaNew_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKanaNew.KeyDown

        If e.KeyCode = Keys.Enter Then

            txtEngNew.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub txtEngNew_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEngNew.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnAddNew.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub txtKanaNew_TextChanged(sender As Object, e As EventArgs) Handles txtKanaNew.TextChanged

        lblSaved.Visible = False
        lblNihongoPlease.Visible = False
        lblEngPlease.Visible = False

    End Sub

    Private Sub txtEngNew_TextChanged(sender As Object, e As EventArgs) Handles txtEngNew.TextChanged

        lblSaved.Visible = False
        lblNihongoPlease.Visible = False
        lblEngPlease.Visible = False

    End Sub
End Class