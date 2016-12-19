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
        Me.PausingHorizontalScrollButton = New System.Windows.Forms.Button()
        Me.CharacterShiftScrollButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.VerticalScrollButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PausingHorizontalScrollButton
        '
        Me.PausingHorizontalScrollButton.Location = New System.Drawing.Point(79, 26)
        Me.PausingHorizontalScrollButton.Name = "PausingHorizontalScrollButton"
        Me.PausingHorizontalScrollButton.Size = New System.Drawing.Size(176, 23)
        Me.PausingHorizontalScrollButton.TabIndex = 0
        Me.PausingHorizontalScrollButton.Text = "&Horizontal Scroll (with Pause) Effect"
        Me.PausingHorizontalScrollButton.UseVisualStyleBackColor = True
        '
        'CharacterShiftScrollButton
        '
        Me.CharacterShiftScrollButton.Location = New System.Drawing.Point(79, 55)
        Me.CharacterShiftScrollButton.Name = "CharacterShiftScrollButton"
        Me.CharacterShiftScrollButton.Size = New System.Drawing.Size(176, 23)
        Me.CharacterShiftScrollButton.TabIndex = 1
        Me.CharacterShiftScrollButton.Text = "&Character Shift Scroll Effect"
        Me.CharacterShiftScrollButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(79, 113)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(176, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'VerticalScrollButton
        '
        Me.VerticalScrollButton.Location = New System.Drawing.Point(79, 84)
        Me.VerticalScrollButton.Name = "VerticalScrollButton"
        Me.VerticalScrollButton.Size = New System.Drawing.Size(176, 23)
        Me.VerticalScrollButton.TabIndex = 3
        Me.VerticalScrollButton.Text = "&Vertical Scroll Effect"
        Me.VerticalScrollButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 162)
        Me.Controls.Add(Me.VerticalScrollButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CharacterShiftScrollButton)
        Me.Controls.Add(Me.PausingHorizontalScrollButton)
        Me.Name = "MainForm"
        Me.Text = "Select the effect you would like to see"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PausingHorizontalScrollButton As Button
    Friend WithEvents CharacterShiftScrollButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents VerticalScrollButton As Button
End Class
