''' <summary>
''' Program: Average Units Shipped
''' Author: Benjamin Priebe - 100437762
''' Description: This program takes an input of one week 
''' of units skjhkjhkjhkhjkhjkjh jgjhghg jmh. lkj. ()
'''
''' </summary>

Option Strict On    'Turn strict on
Public Class frmAverageUnitsShipped

    Shared employeeCounter As Integer = 0
    'CONSTANTS
    Dim InputLowerLimit As Integer = 0  'Constant inputLowerLimit as 0
    Dim InputUpperLimit As Integer = 1001   'Constant inputUpperLimit as 1001

    'VARIABLES
    Dim userInput As String = String.Empty  'Create empty string for user input
    Dim userInputInteger As Integer = 0     'Create variable for the TryParse to output sanitized number to
    Dim array(6) As Integer                 'Create array with 7 spaces
    Dim index As Integer = 0                'Create integer to use as index counter 
    Dim sum As Integer = 0                   'Create integer to use as sum in average calculations
    Dim average As Double = 0         'Create integer to use as result of the average

    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDayNumber.Text = "Day 1" 'On form load, print "Day 1"
    End Sub
    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        userInput = tbInput.Text    'Save the text in the input textbox to the userInput string variable

        If Not (Integer.TryParse(userInput, userInputInteger)) Then 'Check if userInput parses, userInputInteger is a throwaway number
            'because the parse needs an overload

            MsgBox("ERROR: Input must be a whole number!")  'Show error to user in MessageBox
            index -= 1  'Set the index counter back one, go again
            tbInput.SelectAll() 'If invalid, select all text to write over
            tbInput.Focus()     'Reset focus to input box after each entry
        Else
            'Convert the userInput to an int, if it is less than the input's lowerLimit or higher than the upperLimit,
            'run the error message below - ELSE, continue with processing
            If Not (userInputInteger < InputLowerLimit Or userInputInteger >= InputUpperLimit) Then

                lblDayNumber.Text = "Day " & (index + 2)    'Updates the running day counter, adds an extra one so that
                'form displays day user in entering for, not that day previously entered

                array(index) = (userInputInteger)    'Store userInput in the current space in the array

                tbSoldHolder.AppendText(array(index) & vbCrLf)  'Print the userInput to the next line in tbSoldHolder
                tbInput.Text = ""   'If valid, blank the input textbox for new entry
                tbInput.Focus()     'Reset focus to input box after each entry

                If index = array.Length - 1 Then 'If we have hit the end of our week, do the following (processing)

                    array(index) = userInputInteger   'Save userInput into the current index in the array
                    tbInput.Enabled = False     'Disable the input textbox, at end of entry cycle
                    btnEnter.Enabled = False    'Disable the Enter button, at end of entry cycle

                    For Each element In array   'Loop to calculate sum of array
                        sum += element  'For every 'element' in the array, add it into the sum (total)
                    Next

                    averageResult = (sum / array.Length)    'Determine the average from sum
                    averageResult = Math.Round((averageResult), 2)    'Round the average to two decimals
                    lblAverage.Text = "The average sales per day is " & averageResult  'Print to user in output label
                    lblDayNumber.Text = "Complete!" 'Change the lblDayNumber text property to "Complete!" signifying end of entry cycle
                    tbInput.Text = ""   'Blank the input textbox
                End If
            Else
                MsgBox("ERROR: Input must be between 0 and 1000!")  'Show error to user in MessageBox
                index -= 1  'Set the index counter back one, go again
                tbInput.SelectAll() 'Highlight all text in box, so you can write over it easily
                tbInput.Focus()     'Reset focus to input box after each entry
            End If
        End If
        index += 1      'Advance the index counter by one
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetMethod()   'Call what is contained in the resetmethod()
    End Sub
    Private Sub ResetMethod()

        index = 0   'Set index back to 0
        sum = 0     'Empty the sum variable
        averageResult = 0 'Reset the average variable to 0
        tbInput.Focus() 'Set focus to input textbox
        lblAverage.Text = String.Empty    'Empty the lblAverage
        tbSoldHolder.Text = ""  'Empty the textbox which holds inputs
        lblDayNumber.Text = "Day " & (index + 1) 'Set day label back to one
        tbInput.Enabled = True  'Disable the input textbox
        btnEnter.Enabled = True 'Disable the enter button
        userInput = String.Empty    'Reset userInput to empty string
        userInputInteger = 0        'Reset the TryParse output integer for userInput to 0
        tbInput.Text = ""   'Empty text in input textbox

        For index As Integer = 0 To array.Length - 1    'Instructions inside
            'loop through array by the index, using the 7th element (6)
            array(index) = 0 'and set each to zero
        Next index  'Go to next index, loop again
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()  'Close currently open form
    End Sub
End Class
