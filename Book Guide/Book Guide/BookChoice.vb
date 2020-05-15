' Application:  Book Guide
' Class:        BookChoice
' Author:       Hope Simmons
' Date:         11 May 2020
' Purpose:      This application allows the user to choose an age group. Then upon selecting an age group
'               shows the user what books are appropriate for a certain age group on a different form.


Public Class BookChoice
    Public frm2 As String
    Private Sub BookChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm2 = BookGuide.filereader
        rchBookChoices.Text = frm2

        Select Case BookGuide.frm1
            Case "0-4"
                picNum1.Image = Image.FromFile("brownbear.jpg")
                picNum2.Image = Image.FromFile("animalkissed.jpg")
                picNum3.Image = Image.FromFile("wildthings.jpg")
            Case "5-9"
                picNum1.Image = Image.FromFile("placesyougo.png")
                picNum2.Image = Image.FromFile("fallingup.jpg")
                picNum3.Image = Image.FromFile("pigeonbus.jpg")
            Case "10-12"
                picNum1.Image = Image.FromFile("circusmirandus.jpg")
                picNum2.Image = Image.FromFile("princessacademy.jpg")
                picNum3.Image = Image.FromFile("stargirl.png")
            Case "13-17"
                picNum1.Image = Image.FromFile("harrypotter.jpg")
                picNum2.Image = Image.FromFile("lordoftherings.jpg")
                picNum3.Image = Image.FromFile("speak.jpg")
            Case "18+"
                picNum1.Image = Image.FromFile("bricksthatbuilt.jpg")
                picNum2.Image = Image.FromFile("theassistants.jpg")
                picNum3.Image = Image.FromFile("girlsonfire1.jpg")
        End Select
        BookGuide.Show()
    End Sub
End Class
