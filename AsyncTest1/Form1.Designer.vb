<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.sendMail_btn = New System.Windows.Forms.Button()
        Me.output_tb = New System.Windows.Forms.TextBox()
        Me.another_procedure_btn = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.prog_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'sendMail_btn
        '
        Me.sendMail_btn.Location = New System.Drawing.Point(12, 12)
        Me.sendMail_btn.Name = "sendMail_btn"
        Me.sendMail_btn.Size = New System.Drawing.Size(125, 23)
        Me.sendMail_btn.TabIndex = 0
        Me.sendMail_btn.Text = "Send Mail"
        Me.sendMail_btn.UseVisualStyleBackColor = True
        '
        'output_tb
        '
        Me.output_tb.Location = New System.Drawing.Point(277, 13)
        Me.output_tb.Multiline = True
        Me.output_tb.Name = "output_tb"
        Me.output_tb.Size = New System.Drawing.Size(228, 236)
        Me.output_tb.TabIndex = 1
        '
        'another_procedure_btn
        '
        Me.another_procedure_btn.Location = New System.Drawing.Point(12, 41)
        Me.another_procedure_btn.Name = "another_procedure_btn"
        Me.another_procedure_btn.Size = New System.Drawing.Size(125, 23)
        Me.another_procedure_btn.TabIndex = 2
        Me.another_procedure_btn.Text = "Another Procedure"
        Me.another_procedure_btn.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 225)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(259, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'prog_lbl
        '
        Me.prog_lbl.AutoSize = True
        Me.prog_lbl.Location = New System.Drawing.Point(13, 206)
        Me.prog_lbl.Name = "prog_lbl"
        Me.prog_lbl.Size = New System.Drawing.Size(54, 13)
        Me.prog_lbl.TabIndex = 4
        Me.prog_lbl.Text = "Progress: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Progress: "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(74, 202)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 261)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prog_lbl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.another_procedure_btn)
        Me.Controls.Add(Me.output_tb)
        Me.Controls.Add(Me.sendMail_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sendMail_btn As Button
    Friend WithEvents output_tb As TextBox
    Friend WithEvents another_procedure_btn As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents prog_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
