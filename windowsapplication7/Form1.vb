Public Class Form1
    Public copy As String
    Public total As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total As String
        total = copy
        Try

            Clipboard.SetText("<script language=javascript>document.write(unescape('%" + TextBox1.Text + "'))</script>")
        Catch ex As Exception
            MsgBox("INVALID")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox1.Text = "%"
        Dim txt As String
        Dim Str2 As String
        Dim TestChar As String
        Dim i As Integer = 1
        Dim copy As String = ""
        Dim total As String
        txt = TextBox2.Text
        Dim textlength As Integer
        Try
            textlength = txt.Length
            Str2 = Hex(Asc(txt))
            While (i <= textlength)
                TestChar = GetChar(txt, i)
                Str2 = Hex(Asc(TestChar))
                If (Str2 = "D") Then
                    Str2 = ""

                ElseIf (Str2 = "A") Then
                    Str2 = "0A"
                    copy += Str2 + "%"
                ElseIf (Str2 = "9") Then
                    Str2 = "09"
                    copy += Str2 + "%"
                Else
                    copy += Str2 + "%"
                End If
                i += 1
            End While
            total = copy
            TextBox1.Text = copy
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Panel1.Hide()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
