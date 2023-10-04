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
        btnCheck = New Button()
        btnClose = New Button()
        txtNumber = New TextBox()
        lblNumber = New Label()
        lblHeading = New Label()
        SuspendLayout()
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(348, 276)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(94, 29)
        btnCheck.TabIndex = 0
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(348, 345)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(445, 153)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(125, 27)
        txtNumber.TabIndex = 1
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Location = New Point(284, 161)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(113, 20)
        lblNumber.TabIndex = 2
        lblNumber.Text = "Enter a Number"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.BackColor = SystemColors.GradientActiveCaption
        lblHeading.Font = New Font("Viner Hand ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblHeading.ForeColor = SystemColors.Highlight
        lblHeading.Location = New Point(41, 46)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(725, 45)
        lblHeading.TabIndex = 2
        lblHeading.Text = "Check if the number is Even or Odd and Prime or not"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(800, 450)
        Controls.Add(lblHeading)
        Controls.Add(lblNumber)
        Controls.Add(txtNumber)
        Controls.Add(btnClose)
        Controls.Add(btnCheck)
        Name = "Form1"
        Text = "Even/Odd and Prime or not"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblHeading As Label
End Class
