Public Class TicketForm

    Private _firstname As String
    Private _lastname As String
    Private _address As String
    Private _totalBalance As Integer

    Sub New(ByVal firstname As String, ByVal lastname As String, ByVal address As String, ByVal totalBalance As Integer)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _firstname = firstname
        _lastname = lastname
        _address = address
        _totalBalance = totalBalance
    End Sub

    Private Sub TicketForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxFirstname.Text = _firstname.ToString
        TextBoxLastname.Text = _lastname.ToString
        TextBoxAddress.Text = _address
        TextBoxTotal.Text = _totalBalance

    End Sub

    Private Sub BtnPurchaseAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPurchaseAgain.Click
        Me.Hide()
        OrderForm.Show()

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Hide()
        ThankYouForm.Show()

    End Sub
End Class