Imports System
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.Win32
Imports System.Linq
Public Class Form1
    Dim myDictionary As New Dictionary(Of String, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim registry = My.Computer.Registry
        Dim mainkey = registry.CurrentUser.OpenSubKey("Software\MPC-HC\MPC-HC\MediaHistory")
        For Each keyname As String In mainkey.GetSubKeyNames
            Dim History = mainkey.OpenSubKey(keyname).GetValue("Filename")
            Dim lastopen = mainkey.OpenSubKey(keyname).GetValue("LastOpened")
            myDictionary.Add(lastopen, History)

        Next
        Dim sortedDictionary = myDictionary.OrderByDescending(Function(kvp) DateTime.Parse(kvp.Key)).ToDictionary(Function(kvp) kvp.Key, Function(kvp) kvp.Value)
        For Each kvp In sortedDictionary
            ListBox1.Items.Add(kvp.Value)
        Next
        HistoryCountLBL.Text = $"All :{ListBox1.Items.Count}"
        mainkey.Close()
    End Sub



    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        If ListBox1.SelectedItems.Count > 0 Then
            Dim registry = My.Computer.Registry
            Dim mainkey = registry.CurrentUser.OpenSubKey("Software\MPC-HC\MPC-HC\MediaHistory", True)
            For Each keyname As String In mainkey.GetSubKeyNames
                Dim History = mainkey.OpenSubKey(keyname)
                Dim filename As String = History.GetValue("Filename")
                If ListBox1.SelectedItems.Contains(filename) Then

                    mainkey.DeleteSubKey(keyname)
                    ListBox1.Items.Remove(filename)
                    ListBox1.Refresh()
                End If
            Next

            mainkey.Close()
        Else
            MsgBox("Select Itesm to be removed from History")
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        SelectedLBL.Text = $"Selected items: {ListBox1.SelectedItems.Count}"
        HistoryCountLBL.Text = $"All :{ListBox1.Items.Count}"
    End Sub
End Class
