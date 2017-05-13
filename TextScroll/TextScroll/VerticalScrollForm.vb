' TextScroll - A simple text scroll example for Visual Basic.NET applications.
' Initial Developer: Trevor D. Brown.

' This code is distributed under the MIT License. Please distribute as you wish.

' VerticalScrollForm -  This form demonstrates a scroll effect that takes a block of text, and shift it upwards. It is much like the Pausing
'                       Horizontal Scroll effect, except without pauses.

Public Class VerticalScrollForm

    ' Declare variables to be used throughout the form.
    Const TickRate As Integer = 50              ' Constant Integer to represent the rate in which the timer ticks (1 = 1 millisecond)

    ' VericalScrollForm_Load - the event handler for when the form initially loads.
    Private Sub VerticalScrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Loads the specified string into the text field of the label.
        ' Note: ControlChars.NewLine allows you to break a line of text in a large "explicit" body of text.
        TextLabel.Text = MainForm.GetText()
        TextLabel.Location = New System.Drawing.Point(0, 0)    ' Positions the text label in the top-left corner of the form.
        UpdateTimer.Interval = TickRate     ' Sets the tick rate of the update timer.
        UpdateTimer.Start()     ' Starts the update timer.
    End Sub

    ' UpdateTimer_Tick - the event handler for when the timer ticks.
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        ' Scroll conditions.
        If (TextLabel.Bottom >= 0) Then
            ' If the bottom of the text label is visible,
            ' shift the text up by 1 pixel.
            TextLabel.Top -= 1
        ElseIf (TextLabel.Bottom < 0) Then
            ' If the bottom of the text label is not visible,
            ' position the label at the bottom of the form.
            TextLabel.Top = Me.Height
        End If
    End Sub
End Class