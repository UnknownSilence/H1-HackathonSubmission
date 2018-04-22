Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton2.Checked = True
        Button2.Focus()
    End Sub
    Dim letterlist() As String
    Public log As String = ""
    Dim p As String = ""
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer2.Enabled = True Then
            letterlist = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}

            For i As Integer = 65 To 90
                If GetAsyncKeyState(i) Then
                    log = log & (letterlist(i - 65))
                End If
            Next
        End If
    End Sub
    Dim path As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        setpath()
    End Sub

    Public Sub setpath()
        Try
            Dim dialog As New FolderBrowserDialog()
            dialog.RootFolder = Environment.SpecialFolder.Desktop
            dialog.SelectedPath = "C:\"
            dialog.Description = "Select Application Configeration Files Path"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                path = dialog.SelectedPath & "\" & "log.txt"
                My.Computer.FileSystem.WriteAllText(path, log, False)
                TextBox1.Text = path
                TextBox1.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error, You do not have access to this file path.")
        End Try
    End Sub
    Public ruleword As String
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        My.Computer.FileSystem.WriteAllText(path, log, False)
        If RadioButton1.Checked = True Then
            For Each item In ListBox1.Items
                If log.Contains(item) Then
                    ruleword = item
                    ruleword.ToLower()
                    log = log.Replace(ruleword, "")
                    Dim letters() As Char = ruleword.ToCharArray
                    Dim splitword As String = ""
                    For i As Integer = 0 To letters.Count - 1
                        splitword = splitword & letters(i) & "."
                    Next
                    locked.Show()
                    log = log & "An illegal word was typed."
                    Timer2.Enabled = False
                End If
            Next
        Else

            For Each item In ListBox2.Items
                If log.Contains(item) Then
                    ruleword = item
                    ruleword.ToLower()
                    log = log.Replace(ruleword, "")
                    Dim letters() As Char = ruleword.ToCharArray
                    Dim splitword As String = ""
                    For i As Integer = 0 To letters.Count - 1
                        splitword = splitword & letters(i) & "."
                    Next
                    locked.Show()
                    log = log & "An illegal word was typed."
                    Timer2.Enabled = False
                End If
            Next
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This Program was created In the Klein Hacks competition With the goal Of allowing parents To track their children's computer activity and make sure they do not search for inapropriate subject-matter.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not TextBox2.Text = Nothing Then
            If TextBox2.TextLength < 3 Then
                MessageBox.Show("Make a longer word")
                TextBox2.Text = ""
                TextBox2.Focus()
                Exit Sub
            End If
            For Each i As String In ListBox1.Items
                If i = TextBox2.Text Then
                    MessageBox.Show("Item already added.")
                    TextBox2.Text = ""
                    TextBox2.Focus()
                    Exit Sub
                End If
            Next
            ListBox1.Items.Add(TextBox2.Text)
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Public password As String

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox3.Text = Nothing Then
            MessageBox.Show("Error, no password in textbox.", "Error")
            Exit Sub
        End If
        TextBox3.UseSystemPasswordChar = True
        password = TextBox3.Text
        TextBox3.Enabled = False
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not password = Nothing Then
            If path = Nothing Then
                MessageBox.Show("Click on the path icon")
                Exit Sub
            End If
            Timer1.Enabled = True
            Timer2.Enabled = True
            Me.Hide()
        Else
            MessageBox.Show("You forgot to set a password!")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.AcceptButton = Button3
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        hidepanel.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        hidepanel.Visible = True 'Banned word list 
    End Sub
    Private Sub AdvancedModeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AdvancedModeToolStripMenuItem.Click
        My.Computer.FileSystem.CopyFile(Application.ExecutablePath, "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\" & Application.ProductName & ".exe")
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        MessageBox.Show("Select the folder icon to choose the path destination for the word log. You can open this log upon activation of the program to view any words typed by the user. You have the option of adding your own custom words to block or use our expansive pre-fefined database of blocked keywords. To force terminate the program after it has been activated, restart your computer or use the task manager to end the process. The password you enter in the field will be used to reactivate your child's computer. if it a banned word is searched. In the event you forget your password, restart your computer. Contact jhat0490@students.kleinisd.net for updated software or more advanced options.")
    End Sub
End Class
