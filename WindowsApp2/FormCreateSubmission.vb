Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports WindowsApp2.WindowsApp2

Public Class FormCreateSubmission
    Private stopwatch As New Stopwatch()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If

        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GithubLink = txtGithub.Text,
            .StopwatchTime = txtStopwatch.Text
        }

        Using client As New HttpClient()
            Dim content = New StringContent(JsonConvert.SerializeObject(submission), Encoding.UTF8, "application/json")
            Await client.PostAsync("http://localhost:3000/submit", content)
        End Using
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            btnToggleStopwatch.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub FormCreateSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
