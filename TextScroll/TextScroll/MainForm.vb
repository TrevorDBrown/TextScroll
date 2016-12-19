' TextScroll - A simple text scroll example for Visual Basic.NET applications.
' Initial Developer: Trevor D. Brown.

' This code is distributed under the MIT License. Please distribute as you wish.

' MainForm - the "menu" form of this demo application. This makes it easier to see each example of the scroll code.

Public Class MainForm
    ' MainForm_Load - the event handler for when the form initially loads.
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No actions required yet.
    End Sub

    ' LeftToRightScrollButton_Click - the event handler for when the Left to Right Scroll Example button is clicked.
    Private Sub LeftToRightScrollButton_Click(sender As Object, e As EventArgs) Handles PausingHorizontalScrollButton.Click
        PausingHorizontalScrollForm.Show()    ' Show the Left To Right Scroll Example Form.
    End Sub

    ' CharacterShiftScrollButton_Click - the event handler for when the Character Shift Scroll button is clicked.
    Private Sub CharacterShiftScrollButton_Click(sender As Object, e As EventArgs) Handles CharacterShiftScrollButton.Click
        CharacterShiftScrollForm.Show() ' Show the Character Shift Scroll Example Form.
    End Sub

    ' VerticalScrollButton_Click - the event handler for when the Vertical Scroll button is clicked.
    Private Sub VerticalScrollButton_Click(sender As Object, e As EventArgs) Handles VerticalScrollButton.Click
        VerticalScrollForm.Show()   ' Show the Vertical Scroll Example Form.
    End Sub

    ' ExitButton_Click - the event handler for when the Exit button is clicked.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit() ' Terminate the application.
    End Sub


End Class