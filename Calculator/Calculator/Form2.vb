Public Class Form2


    Dim str As String
        Dim str1 As Double
    Dim str2 As Double

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        textBox1.Text += "1"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox1.Text += "2"
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        textBox1.Text += "3"
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        textBox1.Text += "4"
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        textBox1.Text += "5"
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        textBox1.Text += "6"
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        textBox1.Text += "7"
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        textBox1.Text += "8"
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        textBox1.Text += "9"
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click

        str1 = Val(textBox1.Text)
        textBox1.Text = ""
        str = button10.Text
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        textBox1.Text += "0"
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        str1 = Val(textBox1.Text)
        textBox1.Text = ""
        str = button11.Text
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        str1 = Val(textBox1.Text)
        textBox1.Text = ""
        str = button13.Text
    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        str2 = Val(textBox1.Text)
        If str = "+" Then
            textBox1.Text = str1 + str2
        Else
            str2 = Val(textBox1.Text)

            If str = "-" Then
                textBox1.Text = str1 - str2
            Else
                str2 = Val(textBox1.Text)

                If str = "*" Then
                    textBox1.Text = str1 * str2
                Else
                    str2 = Val(textBox1.Text)

                    If str = "/" Then
                        textBox1.Text = str1 / str2
                    Else
                        str2 = Val(textBox1.Text)

                    End If
                End If
            End If
        End If






    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        str1 = Val(textBox1.Text)
        textBox1.Text = ""
        str = button15.Text
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        textBox1.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form1.Close()


    End Sub


End Class
