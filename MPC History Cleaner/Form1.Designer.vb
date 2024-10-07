<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ClearBtn = New Button()
        ListBox1 = New ListBox()
        SelectedLBL = New Label()
        HistoryCountLBL = New Label()
        SuspendLayout()
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ClearBtn.Location = New Point(384, 326)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(75, 23)
        ClearBtn.TabIndex = 3
        ClearBtn.Text = "Clean"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBox1.FormattingEnabled = True
        ListBox1.HorizontalScrollbar = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 20)
        ListBox1.Name = "ListBox1"
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        ListBox1.Size = New Size(447, 289)
        ListBox1.TabIndex = 4
        ' 
        ' SelectedLBL
        ' 
        SelectedLBL.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SelectedLBL.AutoSize = True
        SelectedLBL.Location = New Point(12, 330)
        SelectedLBL.Name = "SelectedLBL"
        SelectedLBL.Size = New Size(95, 15)
        SelectedLBL.TabIndex = 5
        SelectedLBL.Text = "Selected items: 0"
        ' 
        ' HistoryCountLBL
        ' 
        HistoryCountLBL.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        HistoryCountLBL.AutoSize = True
        HistoryCountLBL.Location = New Point(138, 330)
        HistoryCountLBL.Name = "HistoryCountLBL"
        HistoryCountLBL.Size = New Size(27, 15)
        HistoryCountLBL.TabIndex = 6
        HistoryCountLBL.Text = "All :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(471, 361)
        Controls.Add(HistoryCountLBL)
        Controls.Add(SelectedLBL)
        Controls.Add(ListBox1)
        Controls.Add(ClearBtn)
        MaximizeBox = False
        MinimumSize = New Size(300, 200)
        Name = "Form1"
        Text = "MPC History"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SelectedLBL As Label
    Friend WithEvents HistoryCountLBL As Label

End Class
