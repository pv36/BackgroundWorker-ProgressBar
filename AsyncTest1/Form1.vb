Imports System.ComponentModel
Imports System.Threading
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub another_procedure_btn_Click(sender As Object, e As EventArgs) Handles another_procedure_btn.Click
        output_tb.AppendText("Another procedure executed" + Environment.NewLine)

    End Sub



    Private Sub sendMail_btn_Click(sender As Object, e As EventArgs) Handles sendMail_btn.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i = 0 To 100
            Thread.Sleep(40)
            BackgroundWorker1.ReportProgress(i)
        Next

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        output_tb.AppendText("Email is send baby :)" + Environment.NewLine)
    End Sub
End Class
