<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.LeftToRightScrollButton = New System.Windows.Forms.Button()
        Me.CharacterShiftScrollButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LeftToRightScrollButton
        '
        Me.LeftToRightScrollButton.Location = New System.Drawing.Point(79, 14)
        Me.LeftToRightScrollButton.Name = "LeftToRightScrollButton"
        Me.LeftToRightScrollButton.Size = New System.Drawing.Size(176, 23)
        Me.LeftToRightScrollButton.TabIndex = 0
        Me.LeftToRightScrollButton.Text = "&Left to Right Scroll Effect"
        Me.LeftToRightScrollButton.UseVisualStyleBackColor = True
        '
        'CharacterShiftScrollButton
        '
        Me.CharacterShiftScrollButton.Location = New System.Drawing.Point(79, 43)
        Me.CharacterShiftScrollButton.Name = "CharacterShiftScrollButton"
        Me.CharacterShiftScrollButton.Size = New System.Drawing.Size(176, 23)
        Me.CharacterShiftScrollButton.TabIndex = 1
        Me.CharacterShiftScrollButton.Text = "&Character Shift Scroll Effect"
        Me.CharacterShiftScrollButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(79, 73)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(176, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 117)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CharacterShiftScrollButton)
        Me.Controls.Add(Me.LeftToRightScrollButton)
        Me.Name = "MainForm"
        Me.Text = "Select the effect you would like to see"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftToRightScrollButton As Button
    Friend WithEvents CharacterShiftScrollButton As Button
    Friend WithEvents ExitButton As Button
End Class
