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
        Label1 = New Label()
        LblEnterMarks = New Label()
        LblGrade = New Label()
        TxtEnterMarks = New TextBox()
        TxtGrade = New TextBox()
        BtnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Segoe UI", 15.75F)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(248, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 30)
        Label1.TabIndex = 1
        Label1.Text = "GRADING SCALE CALCULATER"
        ' 
        ' LblEnterMarks
        ' 
        LblEnterMarks.AutoSize = True
        LblEnterMarks.Location = New Point(232, 80)
        LblEnterMarks.Name = "LblEnterMarks"
        LblEnterMarks.Size = New Size(78, 17)
        LblEnterMarks.TabIndex = 2
        LblEnterMarks.Text = "Enter Marks"
        ' 
        ' LblGrade
        ' 
        LblGrade.AutoSize = True
        LblGrade.Location = New Point(232, 124)
        LblGrade.Name = "LblGrade"
        LblGrade.Size = New Size(44, 17)
        LblGrade.TabIndex = 3
        LblGrade.Text = "Grade"
        ' 
        ' TxtEnterMarks
        ' 
        TxtEnterMarks.Location = New Point(326, 72)
        TxtEnterMarks.Name = "TxtEnterMarks"
        TxtEnterMarks.Size = New Size(167, 25)
        TxtEnterMarks.TabIndex = 4
        ' 
        ' TxtGrade
        ' 
        TxtGrade.Location = New Point(326, 121)
        TxtGrade.Name = "TxtGrade"
        TxtGrade.Size = New Size(167, 25)
        TxtGrade.TabIndex = 5
        ' 
        ' BtnEvaluate
        ' 
        BtnEvaluate.BackColor = SystemColors.Highlight
        BtnEvaluate.Location = New Point(280, 209)
        BtnEvaluate.Name = "BtnEvaluate"
        BtnEvaluate.Size = New Size(198, 66)
        BtnEvaluate.TabIndex = 0
        BtnEvaluate.Text = "Evaluate"
        BtnEvaluate.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(800, 450)
        Controls.Add(TxtGrade)
        Controls.Add(TxtEnterMarks)
        Controls.Add(LblGrade)
        Controls.Add(LblEnterMarks)
        Controls.Add(Label1)
        Controls.Add(BtnEvaluate)
        Name = "Form1"
        Text = "Grade Calculater"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents LblEnterMarks As Label
    Friend WithEvents LblGrade As Label
    Friend WithEvents TxtEnterMarks As TextBox
    Friend WithEvents TxtGrade As TextBox
    Friend WithEvents BtnEvaluate As Button

End Class
