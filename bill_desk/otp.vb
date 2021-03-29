Imports System.Data.SqlClient

Public Class otpPage

    Dim Connection As New SqlConnection("Server=VIGNESH-LAPTOP\SQLEXPRESS; Database=bill_desk; Integrated Security = True")

    Dim gens As String = "0123456789"
    Dim rand As New Random
    Public otp As String = String.Empty
    Dim temp As String

    Private Sub otpPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        payment.Enabled = False
    End Sub

    Public Sub genOTP()
        Do Until otp.Length = 4
            temp = gens.Substring(rand.Next(0, 9), 1)
            otp &= temp
        Loop
    End Sub

    Private Sub transactNow_Click(sender As Object, e As EventArgs) Handles payment.Click
        If otp = otpcode.Text Then
            Me.Hide()
            bill_desk.Show()
            Call bill_desk.add_transact()
        Else
            MsgBox("Invalid OTP !!!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles otpcode.TextChanged
        If otpcode.TextLength = 4 Then
            payment.Enabled = True
        Else
            payment.Enabled = False
        End If
    End Sub
End Class