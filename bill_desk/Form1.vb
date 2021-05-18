Imports System.Data.SqlClient
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Public Class bill_desk
    Dim Connection As New SqlConnection("")

    Dim str As String
    Dim no As Integer

    Dim trantime As String
    Dim frm_card_no As String
    Dim frm_name As String
    Dim cvv As String
    Dim exp_date As String
    Dim amount As String
    Dim to_acc_no As String
    Dim tran_id As String

    Dim fetched_toAcc As String
    Dim fetched_amt As String

    Dim frm_amount As Integer
    Dim frm_phn As String

    Private Sub pay_Click(sender As Object, e As EventArgs) Handles pay.Click

        frm_card_no = crd_no1.Text
        to_acc_no = crd_no2.Text
        trantime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        frm_name = nme.Text
        cvv = cv.Text
        exp_date = mo.SelectedItem + "/" + yr.SelectedItem
        amount = amt.Text

        If mo.SelectedIndex = -1 Or yr.SelectedIndex = -1 Or nme.Text = Nothing Or cv.Text = Nothing Or amt.Text = Nothing Then
            MsgBox("Enter valid values")
        Else
            Connection.Open()
            Dim CheckS As New SqlCommand("select * from user_details where card_no =" + frm_card_no + "", Connection)
            Dim CheckR As New SqlCommand("select * from user_details where acc_no ='" + to_acc_no + "'", Connection)
            Dim fetchS As SqlDataReader
            Dim fetchR As SqlDataReader
            fetchR = CheckR.ExecuteReader
            fetchR.Read()
            Try
                fetched_toAcc = fetchR("acc_no")
                fetched_amt = fetchR("amount")
            Catch ex As Exception
                MsgBox("Invalid To account number")
            End Try

            Connection.Close()

            Connection.Open()
            fetchS = CheckS.ExecuteReader
            fetchS.Read()

            Try
                frm_amount = fetchS("amount")
                frm_phn = fetchS("phn_no")

                If fetchS("card_no") = frm_card_no And fetchS("name") = frm_name And fetchS("cvv") = cvv And fetchS("exp_date") = exp_date And fetchS("amount") > amount And fetched_toAcc = to_acc_no Then
                    otpPage.genOTP()
                    Const accountSid = "enter your twillio account sid"
                    Const authToken = "enter your twillio account authtoken"
                    TwilioClient.Init(accountSid, authToken)
                    Dim toNumber = New PhoneNumber(frm_phn)
                    Dim message = MessageResource.Create(
                        toNumber, from:=New PhoneNumber("enter your twillio phone no"),
                    body:="Your Bill Desk OTP : " + otpPage.otp)
                    Me.Hide()
                    otpPage.Show()
                Else
                    MessageBox.Show("Invalid Credentials. Please Enter the Correct Details")
                End If
            Catch ex As Exception
                MsgBox("Invalid sender details")
            End Try
            Connection.Close()
        End If
    End Sub

    Public Sub add_transact()
        tran_id = "IntBank" + crd_no1.Text.Substring(0, 2) + System.DateTime.Now.ToString("dd/MM/yy-HH:mm:ss")
        tran_id = Replace(tran_id, ":", "")
        tran_id = Replace(tran_id, "-", "")
        tran_id = Replace(tran_id, " ", "")
        Dim Cmd As New SqlCommand("insert into Table_1(tran_id,frm_name,frm_card_no,to_acc_no,amount,trantime) values(@tran_id,@frm_name,@frm_card_no,@to_acc_no,@amount,@trantime)", Connection)

        Cmd.Parameters.Add("@tran_id", SqlDbType.VarChar).Value = tran_id
        Cmd.Parameters.Add("@frm_name", SqlDbType.VarChar).Value = frm_name
        Cmd.Parameters.Add("@frm_card_no", SqlDbType.VarChar).Value = frm_card_no
        Cmd.Parameters.Add("@to_acc_no", SqlDbType.VarChar).Value = to_acc_no
        Cmd.Parameters.Add("@amount", SqlDbType.VarChar).Value = amount
        Cmd.Parameters.Add("@trantime", SqlDbType.VarChar).Value = trantime

        Dim CheckS As New SqlCommand("select * from User_details where card_no =" + frm_card_no + "", Connection)
        Dim CheckR As New SqlCommand("select * from User_details where acc_no ='" + crd_no2.Text + "'", Connection)
        Dim fetchSen As SqlDataReader
        Dim fetchRec As SqlDataReader

        Connection.Open()
        fetchRec = CheckR.ExecuteReader
        fetchRec.Read()
        Dim balSender As String = fetchRec("amount") + amount
        Dim balSenAcc As String = fetchRec("acc_no")
        Dim balSenPh As String = fetchRec("phn_no")
        Connection.Close()

        Connection.Open()
        fetchSen = CheckS.ExecuteReader
        fetchSen.Read()
        Dim balReciever As String = fetchSen("amount") - amount
        Dim balRecAcc As String = fetchSen("acc_no")
        Dim balRecPh As String = fetchSen("phn_no")
        Connection.Close()

        Dim updateS As New SqlCommand("update User_details set amount = " + balSender + "where acc_no = '" + to_acc_no + "'", Connection)
        Dim updateR As New SqlCommand("update User_details set amount = " + balReciever + "where card_no = " + frm_card_no + "", Connection)
        Connection.Open()
        updateR.ExecuteNonQuery()
        Connection.Close()

        Connection.Open()
        updateS.ExecuteNonQuery()
        Connection.Close()

        Connection.Open()
        If updateS.ExecuteNonQuery() = 1 Then

        End If
        Connection.Close()

        Connection.Open()
        If updateS.ExecuteNonQuery() = 1 Then

        End If
        Connection.Close()

        Connection.Open()
        If Cmd.ExecuteNonQuery() = 1 Then
            Call msgRec(balSenAcc:=balSenAcc, balSender:=balSender, balSenPh:=balSenPh, balRecAcc:=balRecAcc)
            Call msgSend(balRecAcc:=balRecAcc, balReciever:=balReciever, balRecPh:=balRecPh, balSenAcc:=balSenAcc)
            MessageBox.Show("Transaction Made Successfully")
            MessageBox.Show("Your Transaction ID : " + tran_id)
        End If
        Connection.Close()
    End Sub

    Private Sub crd_no_TextChanged(sender As Object, e As EventArgs)
        If crd_no1.Text <> Nothing Then
            str = Val(crd_no1.Text)
            str = str.Replace(" ", "")
        End If

        no = str.Substring(0, 1)

        If no = 4 Then
            crd_pic1.Image = My.Resources.visa
        ElseIf no = 5 Then
            crd_pic1.Image = My.Resources.master
        ElseIf no = 3 Then
            crd_pic1.Image = My.Resources.american_exp
        ElseIf no = 6 Then
            crd_pic1.Image = My.Resources.discover
        Else
            crd_pic1.Image = Nothing
        End If
    End Sub

    Private Sub crd_click(sender As Object, e As MouseEventArgs)
        If String.IsNullOrWhiteSpace(crd_no1.Text) Then
            crd_no1.SelectionStart = 0
        End If
    End Sub

    Private Sub crd_click2(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(crd_no2.Text) Then
            crd_no2.SelectionStart = 0
        End If
    End Sub
    Public Sub msgRec(ByVal balSenAcc As String, ByVal balSender As String, ByVal balSenPh As String, ByVal balRecAcc As String)
        Const accountSid = "enter your twillio account sid"
        Const authToken = "enter your twillio authtoken"
        TwilioClient.Init(accountSid, authToken)
        Dim toNumber = New PhoneNumber(balSenPh)
        Dim message = MessageResource.Create(
            toNumber, from:=New PhoneNumber("enter your twillio phn no"),
                        body:="Receiver - Your Account Number : " + balSenAcc.Substring(0, 3) + "XXXXX" + balSenAcc.Substring(7, 2) + " is credited with Rs: " + amt.Text + " by " + balRecAcc.Substring(0, 3) + "XXX" + balRecAcc.Substring(7, 2) + " On " + System.DateTime.Now.ToString("MMM/dd/yyyy HH:mm:ss") + vbNewLine + "Your Account Balance is Rs:" + balSender + "Your Transaction id : " + tran_id)
    End Sub

    Public Sub msgSend(ByVal balRecAcc As String, ByVal balReciever As String, ByVal balRecPh As String, ByVal balSenAcc As String)

        Const accountSid = "enter your twillio account sid"
        Const authToken = "enter your .."
        TwilioClient.Init(accountSid, authToken)
        Dim toNumber = New PhoneNumber(balRecPh)
        Dim message = MessageResource.Create(
                        toNumber, from:=New PhoneNumber("enter your .."),
                        body:="Sender - Your Account Number : " + balRecAcc.Substring(0, 3) + "XXXXX" + balRecAcc.Substring(7, 2) + " is debited by Rs " + amt.Text + " for " + balSenAcc.Substring(0, 3) + "XXX" + balSenAcc.Substring(7, 2) + " On " + System.DateTime.Now.ToString("MMM/dd/yyyy HH:mm:ss") + vbNewLine + "Your Account Balance is Rs: " + balReciever + "Your Transaction id : " + tran_id + vbNewLine + vbNewLine + " If you did not perfom this transaction contact your branch office" + "")
    End Sub

    Private Sub bill_desk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cv.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles hde.Click
        If cv.UseSystemPasswordChar = False Then
            cv.UseSystemPasswordChar = True
            hde.Text = "Show"
        Else
            cv.UseSystemPasswordChar = False
            hde.Text = "Hide"
        End If
    End Sub
End Class

