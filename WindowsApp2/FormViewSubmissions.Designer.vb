<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormViewSubmissions
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
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.Info
        Me.btnPrevious.Location = New System.Drawing.Point(36, 328)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(183, 36)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNext.Location = New System.Drawing.Point(253, 328)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(157, 36)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(208, 231)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.Size = New System.Drawing.Size(187, 22)
        Me.txtStopwatch.TabIndex = 3
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(208, 176)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.ReadOnly = True
        Me.txtGithub.Size = New System.Drawing.Size(187, 22)
        Me.txtGithub.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(208, 120)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(187, 22)
        Me.txtPhone.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(208, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(187, 22)
        Me.txtEmail.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(208, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(187, 22)
        Me.txtName.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(33, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(33, 67)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(33, 120)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(77, 16)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(33, 176)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(139, 16)
        Me.lblGithub.TabIndex = 11
        Me.lblGithub.Text = "Github Link For Task 2"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(33, 231)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(97, 16)
        Me.lblStopwatch.TabIndex = 12
        Me.lblStopwatch.Text = "Stopwatch time"
        '
        'FormViewSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "FormViewSubmissions"
        Me.Text = "Sandeep, Slidely Task 2 - View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents lblStopwatch As Label
End Class
