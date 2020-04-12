Public Class PurchaseForm

    Private _totalBalance As Integer
    Dim lastname As String
    Dim address As String
    Dim firstname As String

    Sub New(ByVal totalBalance As Integer)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _totalBalance = totalBalance
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        Me.Hide()
        OrderForm.Show()
    End Sub

    Private Sub PurchaseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBoxTotal.Text = _totalBalance.ToString

        If TextBoxFirstname.Focused Then
            TextBoxFirstname.Clear()

        End If

        If TextBoxLastname.Focused Then
            TextBoxLastname.Clear()
        End If

        If TextBoxCreditcard.Focused Then
            TextBoxCreditcard.Clear()
        End If

    End Sub

    Public Sub BtnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPurchase.Click

        firstname = TextBoxFirstname.Text
        lastname = TextBoxLastname.Text
        address = TextBoxAddress.Text
        Dim creditcard = TextBoxCreditcard.Text

        If firstname = "" Or lastname = "" Or address = "" Or creditcard = "" Then
            LblErrorMsg.Text = "One or More input field is required"
        ElseIf TextBoxCreditcard.Text.Length < 16 Then
            LblErrorMsg.Text = ""
            LblErrorMsg.Text = "Credit Card Number is less than 16 characters"
        Else
            LblErrorMsg.Text = ""

            'pass data to ticket form
            'Dim gotoTicket As New TicketForm(firstname, lastname, address, _totalBalance)

            SuccessForm.Show()
            TimerGoTicket.Enabled = True

            'Me.Hide()

            'PurchaseForm.Show()
            'gotoTicket.Show()

        End If

    End Sub

    Private Sub TextBoxCreditcard_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCreditcard.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    'Private Sub TimerShowSuccess_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerShowSuccess.Tick
    ''Me.Hide()
    '   SuccessForm.Show()
    'End Sub

    Private Sub TimerGoTicket_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGoTicket.Tick
        Dim gotoTicket As New TicketForm(firstname, lastname, address, _totalBalance)
        Me.Hide()
        'PurchaseForm.Show()
        'stop timer
        TimerGoTicket.Enabled = False
        gotoTicket.Show()

    End Sub
End Class