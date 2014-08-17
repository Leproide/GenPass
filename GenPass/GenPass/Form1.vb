Imports PassGen
Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clipboard.SetDataObject(New DataObject(TextBox1.Text))
        MessageBox.Show("Password copiata negli appunti, verrà rimossa automaticamente tra 60 secondi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TextBox1.Text = ("Password copiata negli appunti, verrà rimossa automaticamente tra 60 secondi")
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Clipboard.SetDataObject(New DataObject("Grazie per aver usato GenPass By Leprechaun!"))
        TextBox1.Text = ""
        MessageBox.Show("Password rimossa dagli appunti", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()
        TextBox1.Text = Generator.GenerateRandomString(NumericUpDown1.Value, CheckBox1.Checked)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            MessageBox.Show("Alcuni siti (Esempio gmail) non accettano alcuni caratteri speciali", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Exit93 si dichiara estraneo alla porcissima grafica che SGOCCIOLA! ZUDUNNA!", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class
