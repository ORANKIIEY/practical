Public Class Form1
    Private Sub btnPassOrFail_Click(sender As Object, e As EventArgs) Handles btnPassOrFail.Click
        Dim marks As Double


        marks = txtmarks.Text
        If marks < 39 Then
            MsgBox("Failed")
        ElseIf marks >= 40 And marks <= 49 Then
            MsgBox("Supplimentary")
        ElseIf marks >= 50 And marks <= 75 Then
            MsgBox("Pass")
        ElseIf marks > 76 And marks <= 100 Then
            MsgBox("Distinction")
        End If

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim Timespent As Double


        Timespent = txtPeriodTime.Text

        If Timespent >= 0 And Timespent <= 29 Then
            MessageBox.Show("Your packed for " & "" & Timespent & "" & "Mins you must pay: R0")

        ElseIf Timespent >= 30 And Timespent <= 59 Then
            MessageBox.Show("Your packed for " & "" & Timespent & "" & "Mins you must pay: R6.50
")
        ElseIf Timespent >= 60 And Timespent <= 89 Then
            MessageBox.Show("Your packed for " & "" & Timespent & "" & "Mins you must pay: R10.50")
        ElseIf Timespent >= 90 Then
            MessageBox.Show("Your packed for " & "" & Timespent & "" & "Mins you must pay: R250")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim weeks As String
        Dim month As String
        name = txtname.Text
        weeks = cmbDAyWeek.Text
        month = cmbMonth.Text

        If cmbDAyWeek.Text = "Monday" Then
            MsgBox("Hello " & name & " Your birthday is " & "" & month & "and the day of the birthday this year is " & "" & weeks)


        ElseIf cmbDAyWeek.Text = "Tuesday" Then
            MsgBox("Hello " & name & "" & " Your birthday is " & " " & month & " " & "and the day of the birthday this year is " & " " & weeks)
        ElseIf cmbDAyWeek.Text = "Wednesday" Then
            MsgBox("Hello " & name & " " & " Your birthday is " & " " & month & " " & " and the day of the birthday this year is " & "" & weeks)
        ElseIf cmbDAyWeek.Text = "Thursday" Then
            MsgBox("Hello " & name & " " & " Your birthday is " & " " & month & " " & " and the day of the birthday this year is " & "" & weeks)
        ElseIf cmbDAyWeek.Text = "Friday" Then
            MsgBox("Hello " & name & " Your birthday is " & " " & month & " " & "and the day of the birthday this year is " & "" & weeks)
        ElseIf cmbDAyWeek.Text = "Saturday" Then
            MsgBox("Hello " & name & " Your birthday is " & " " & month & " " & "and the day of the birthday this year is " & "" & weeks)
        ElseIf cmbDAyWeek.Text = "Sunday" Then
            MsgBox("Hello " & name & " Your birthday is " & " " & month & " " & "and the day of the birthday this year is " & "" & weeks)
        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim height As Double
        Dim width As Double
        Dim depth As Double
        Dim volume As Double

        height = txtheight.Text
        width = txtwidth.Text
        depth = txtDepth.Text
        volume = (height * width * depth) / 1000

        MsgBox("The tank holds " & " " & volume & " litres of water ")

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPeriodTime.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim form As New Form

        Me.Close()
    End Sub
End Class
