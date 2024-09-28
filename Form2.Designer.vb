<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TxtEnterMarks = New TextBox()
        LblEnterMarks = New Label()
        BtnEvaluate = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TxtEnterMarks
        ' 
        TxtEnterMarks.Location = New Point(264, 59)
        TxtEnterMarks.Name = "TxtEnterMarks"
        TxtEnterMarks.Size = New Size(167, 25)
        TxtEnterMarks.TabIndex = 9
        ' 
        ' LblEnterMarks
        ' 
        LblEnterMarks.AutoSize = True
        LblEnterMarks.Location = New Point(147, 67)
        LblEnterMarks.Name = "LblEnterMarks"
        LblEnterMarks.Size = New Size(78, 17)
        LblEnterMarks.TabIndex = 7
        LblEnterMarks.Text = "Enter Marks"
        ' 
        ' BtnEvaluate
        ' 
        BtnEvaluate.BackColor = SystemColors.Highlight
        BtnEvaluate.Location = New Point(233, 166)
        BtnEvaluate.Name = "BtnEvaluate"
        BtnEvaluate.Size = New Size(198, 66)
        BtnEvaluate.TabIndex = 6
        BtnEvaluate.Text = "Evaluate"
        BtnEvaluate.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(219, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 17)
        Label1.TabIndex = 11
        Label1.Text = "GRADING SCALE CALCULATER"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(TxtEnterMarks)
        Controls.Add(LblEnterMarks)
        Controls.Add(BtnEvaluate)
        Name = "Form2"
        Text = "GRADE CULCULATER"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TxtEnterMarks As TextBox
    Friend WithEvents LblEnterMarks As Label
    Friend WithEvents BtnEvaluate As Button
    Friend WithEvents Label1 As Label
End Class
