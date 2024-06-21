<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateSubmission
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
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(233, 148)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(215, 22)
        Me.txtPhone.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(233, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(215, 22)
        Me.txtName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(233, 88)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(215, 22)
        Me.txtEmail.TabIndex = 2
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(233, 211)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(215, 22)
        Me.txtGithub.TabIndex = 3
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.SystemColors.Info
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(12, 275)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(279, 32)
        Me.btnToggleStopwatch.TabIndex = 4
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(50, 354)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(387, 39)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "SUBMIT (CTRL +S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(47, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(47, 94)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(47, 154)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(77, 16)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(47, 214)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(139, 16)
        Me.lblGithub.TabIndex = 9
        Me.lblGithub.Text = "Github Link For Task 2"
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(313, 280)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.Size = New System.Drawing.Size(135, 22)
        Me.txtStopwatch.TabIndex = 10
        '
        'FormCreateSubmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPhone)
        Me.Name = "FormCreateSubmission"
        Me.Text = "Sandep, Slidely Task 2 - Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents txtStopwatch As TextBox
End Class
