Imports System.ComponentModel

Public Class locked
    Private Sub locked_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not run = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub locked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Timer2.Enabled = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Label1.Text = "An illegal word was typed. Get your parent to unlock the computer and check the log."
    End Sub

    Dim run As Boolean = True
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = Form1.password Then
            Form1.Timer2.Enabled = True
            Form1.Timer2.Enabled = True
            run = False
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Control.ModifierKeys & Keys.Alt = Keys.Alt Then
            MessageBox.Show("Alt catched!")
        End If
    End Sub
End Class