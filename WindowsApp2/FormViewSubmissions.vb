Imports System.Net.Http
Imports Newtonsoft.Json
Imports WindowsApp2.WindowsApp2

Public Class FormViewSubmissions
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)
    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={currentIndex}")
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(response)
            submissions = New List(Of Submission) From {submission} ' Wrap the single submission in a list
            DisplaySubmission()
        End Using
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(0) ' Always the first element in the list
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithub.Text = submission.GithubLink
            txtStopwatch.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmissions()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < GetTotalSubmissions() - 1 Then
            currentIndex += 1
            LoadSubmissions()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function GetTotalSubmissions() As Integer
        ' Implement logic to get the total number of submissions
        ' This might involve another API call to get the count of submissions
        Return 10 ' Placeholder value; replace with actual logic
    End Function


End Class