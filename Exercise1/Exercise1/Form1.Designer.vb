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
        userName = New Label()
        userAge = New Label()
        userColor = New Label()
        txtuserName = New TextBox()
        txtuserAge = New TextBox()
        txtuserColor = New TextBox()
        btnDisplay = New Button()
        SuspendLayout()
        ' 
        ' userName
        ' 
        userName.AutoSize = True
        userName.Location = New Point(173, 53)
        userName.Name = "userName"
        userName.Size = New Size(59, 25)
        userName.TabIndex = 0
        userName.Text = "Name"
        ' 
        ' userAge
        ' 
        userAge.AutoSize = True
        userAge.Location = New Point(188, 118)
        userAge.Name = "userAge"
        userAge.Size = New Size(44, 25)
        userAge.TabIndex = 1
        userAge.Text = "Age"
        ' 
        ' userColor
        ' 
        userColor.AutoSize = True
        userColor.Location = New Point(173, 199)
        userColor.Name = "userColor"
        userColor.Size = New Size(65, 25)
        userColor.TabIndex = 2
        userColor.Text = "Colour"
        ' 
        ' txtuserName
        ' 
        txtuserName.Location = New Point(294, 47)
        txtuserName.Name = "txtuserName"
        txtuserName.Size = New Size(294, 31)
        txtuserName.TabIndex = 3
        ' 
        ' txtuserAge
        ' 
        txtuserAge.Location = New Point(290, 112)
        txtuserAge.Name = "txtuserAge"
        txtuserAge.Size = New Size(296, 31)
        txtuserAge.TabIndex = 4
        ' 
        ' txtuserColor
        ' 
        txtuserColor.Location = New Point(291, 193)
        txtuserColor.Name = "txtuserColor"
        txtuserColor.Size = New Size(288, 31)
        txtuserColor.TabIndex = 5
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(288, 302)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(300, 49)
        btnDisplay.TabIndex = 6
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(902, 495)
        Controls.Add(btnDisplay)
        Controls.Add(txtuserColor)
        Controls.Add(txtuserAge)
        Controls.Add(txtuserName)
        Controls.Add(userColor)
        Controls.Add(userAge)
        Controls.Add(userName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userName As Label
    Friend WithEvents userAge As Label
    Friend WithEvents userColor As Label
    Friend WithEvents txtuserName As TextBox
    Friend WithEvents txtuserAge As TextBox
    Friend WithEvents txtuserColor As TextBox
    Friend WithEvents btnDisplay As Button

End Class
