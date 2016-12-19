' TextScroll - A simple text scroll example for Visual Basic.NET applications.
' Initial Developer: Trevor D. Brown.

' This code is distributed under the MIT License. Please distribute as you wish.

' LeftToRightScrollForm -   This form demonstrates a text scroll which moves left to right, and pauses once the text label reaches the left-most
'                           edge of the form. After 100 ticks, the movement continues.

Public Class LeftToRightScrollForm

    ' Declare variables to be used throughout the form.
    Dim CurrentPauseCount As Integer            ' Integer to serve as a counter for the pause count.
    Dim IsPaused As Boolean                     ' Boolean to represent the pause state (True = Paused, False = Not Paused)
    Const MaximumPauseCount As Integer = 100    ' Constant Integer to represent the maximum pause count.
    Const TickRate As Integer = 1               ' Constant Integer to represent the rate in which the timer ticks (1 = 1 millisecond)

    ' LeftToRightScrollForm_Load - The event handler for when the form initially loads.
    Private Sub LeftToRightScrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextLabel.Text = "This text scrolls from left to right, and pauses for 100 timer ticks when the left edge reaches the left side of the form."   ' Sets some text within the label.
        TextLabel.Location = New System.Drawing.Point(0, 0)    ' Positions the text label in the top-left corner of the form.
        CurrentPauseCount = 0   ' Sets the Current Pause Counter to 0.
        IsPaused = True         ' Sets the IsPaused Boolean Flag to True.
        SlideTimer.Interval = TickRate  ' Sets the tick rate of the timer.
        SlideTimer.Start()    ' Starts the text slide timer.
    End Sub

    ' SliderTimer_Tick - The event handler for when the specific timer ticks.
    Private Sub SlideTimer_Tick(sender As Object, e As EventArgs) Handles SlideTimer.Tick
        ' Pause conditions
        If (IsPaused = True And CurrentPauseCount < MaximumPauseCount) Then
            ' If the text slide is paused, and the current count is less than the maximum allowed count,
            ' increment the pause count, and remain paused.
            CurrentPauseCount += 1
        ElseIf (IsPaused = True And CurrentPauseCount >= MaximumPauseCount) Then
            ' If the text slide is paused, and the current count is equal to or exceeds the maximum allowed count,
            ' change the IsPaused flag to False, shift the text label to the left by 1 pixel, and reset the pause count.
            IsPaused = False
            TextLabel.Left -= 1
            CurrentPauseCount = 0
        ElseIf (IsPaused = False And TextLabel.Right > 0 And TextLabel.Left <> 0) Then
            ' If the text slide is not paused, and the label's right-most edge is still visible,
            ' shift the text leabel to the left by 1 pixel.
            TextLabel.Left -= 1
        ElseIf (IsPaused = False And TextLabel.Right <= 0) Then
            ' If the text slide is not paused, and the label's right-most edge is not visible,
            ' reset the position of the text label to the far right of the form.
            TextLabel.Left = Me.Width
        End If
        ' This statement will only evaluate properly when it is separated from the rest of the If-ElseIf statement.
        If (IsPaused = False And TextLabel.Left = 0) Then
            ' If the text slide is not paused, and the label's left-most edge is at X = 0 (relative to the parent form),
            ' change the IsPaused flag to True, increment the pause count, and pause.
            IsPaused = True
            CurrentPauseCount += 1
        End If
    End Sub
End Class
