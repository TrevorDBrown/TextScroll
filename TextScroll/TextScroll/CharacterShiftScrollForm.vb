' TextScroll - A simple text scroll example for Visual Basic.NET applications.
' Initial Developer: Trevor D. Brown.

' This code is distributed under the MIT License. Please distribute as you wish.

' CharacterShiftScrollForm -    This form demonstrates a character shift using and remove and append method. Variables will be used to store
'                               the label's current text, and the current first character. The first character is removed from the label, 
'                               and appended to the end of the label.

Public Class CharacterShiftScrollForm

    ' Declare variables to be used in this example:
    Dim CurrentString As String         ' String for storing the current value in the text label.
    Dim CurrentFirstCharacter As Char   ' Character for storing the first value in the string.
    Const TickRate As Integer = 40      ' Constant Integer to represent the rate in which the timer ticks (1 = 1 millisecond)

    ' CharacterShiftScrollForm_Load - The event handler for when the form initially loads.
    Private Sub CharacterShiftScrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextLabel.Text = "This text scrolls in place, by removing the first element of the string, and adding it to the end.          "   ' Sets some text within the label.
        CurrentString = TextLabel.Text  ' Sets the current string variable to equal the text in the label.
        TextLabel.Location = New System.Drawing.Point(0, 0)    ' Positions the text label in the top-left corner of the form.
        UpdateTimer.Interval = TickRate  ' Sets the tick rate of the timer.
        UpdateTimer.Start()    ' Starts the text slide timer.
    End Sub

    ' UpdateTimer_Tick - The event handler for when the timer ticks.
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        CurrentFirstCharacter = CurrentString.First     ' Store the first character in the current string.

        ' Execute the following code, if the current first character is not null.
        If (CurrentFirstCharacter.ToString <> "") Then
            CurrentString = TextLabel.Text  ' Retreive the entire string from the text label.
            CurrentString = CurrentString.Substring(1)  ' Store the substring, sans the first character.
            CurrentString += CurrentFirstCharacter      ' Append the first character to the end of the string.
            TextLabel.Text = CurrentString              ' Replace the text in the label with the updated string.
        End If
    End Sub
End Class