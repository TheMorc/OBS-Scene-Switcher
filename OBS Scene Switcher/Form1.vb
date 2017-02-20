Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Visible = True
            TextBox1.Text = My.Settings.b1
            Button1.Text = My.Settings.b1
            TextBox2.Visible = True
            TextBox2.Text = My.Settings.b2
            Button2.Text = My.Settings.b2
            TextBox3.Visible = True
            TextBox3.Text = My.Settings.b3
            Button3.Text = My.Settings.b3
            TextBox4.Visible = True
            TextBox4.Text = My.Settings.b4
            Button4.Text = My.Settings.b4
            TextBox5.Visible = True
            TextBox5.Text = My.Settings.b5
            Button5.Text = My.Settings.b5
            TextBox6.Visible = True
            TextBox6.Text = My.Settings.b6
            Button6.Text = My.Settings.b6
            TextBox7.Visible = True
            TextBox7.Text = My.Settings.b7
            Button7.Text = My.Settings.b7
        Else
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = TextBox1.Text
        Button1.Text = TextBox1.Text
        My.Settings.b1 = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Text = TextBox2.Text
        Button2.Text = TextBox2.Text
        My.Settings.b2 = TextBox2.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Text = TextBox7.Text
        Button7.Text = TextBox7.Text
        My.Settings.b7 = TextBox7.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Text = TextBox6.Text
        Button6.Text = TextBox6.Text
        My.Settings.b6 = TextBox6.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Text = TextBox5.Text
        Button5.Text = TextBox5.Text
        My.Settings.b5 = TextBox5.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Text = TextBox4.Text
        Button4.Text = TextBox4.Text
        My.Settings.b4 = TextBox4.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Text = TextBox3.Text
        Button3.Text = TextBox3.Text
        My.Settings.b3 = TextBox3.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
        CheckBox1_CheckedChanged(sender, e)
        CheckBox1.Checked = False
        CheckBox1_CheckedChanged(sender, e)
    End Sub
End Class
