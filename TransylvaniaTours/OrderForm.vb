Public Class OrderForm

    Private Sub OrderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim coachTypes(2) As Integer
        coachTypes(0) = 12
        coachTypes(1) = 21
        coachTypes(2) = 55

        Dim coachCostPerDay(2) As Integer
        coachCostPerDay(0) = 150
        coachCostPerDay(1) = 100
        coachCostPerDay(2) = 70

        Dim tourLength(2) As Integer
        tourLength(0) = 3
        tourLength(1) = 7
        tourLength(2) = 10

        Dim sightSeeing(3) As String
        sightSeeing(0) = "Bran Castle"
        sightSeeing(1) = "Liberty Sanctuary"
        sightSeeing(2) = "Peles Castle"
        sightSeeing(3) = "Turda Salt Mine"

        Dim sightSeeingPrice(3) As Integer
        sightSeeingPrice(0) = 25
        sightSeeingPrice(1) = 40
        sightSeeingPrice(2) = 30
        sightSeeingPrice(3) = 20

        'populating coach type
        For ct = 0 To 2
            CoachTypeDrop.Items.Add(coachTypes(ct))
        Next

        'populating tour length
        For tl = 0 To 2
            TourLengthDrop.Items.Add(tourLength(tl))
        Next

        '
    End Sub

    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        Dim ctSelected = CoachTypeDrop.SelectedItem
        Dim tlSelected = TourLengthDrop.SelectedItem

        'checkbox bran
        Dim checkBran = CheckBoxBran.Checked
        Dim cbCheck As Integer

        If checkBran = True Then
            cbCheck = 25
        Else
            cbCheck = 0
        End If

        'checkbox liberty
        Dim checkLiberty = CheckBoxLiberty.Checked
        Dim clCheck As Integer

        If checkLiberty = True Then
            clCheck = 40
        Else
            clCheck = 0
        End If

        'checkbox peles
        Dim checkPeles = CheckBoxPeles.Checked
        Dim cpCheck As Integer

        If checkPeles = True Then
            cpCheck = 30
        Else
            cpCheck = 0
        End If

        'checkbox turda
        Dim checkTurda = CheckBoxTurda.Checked
        Dim ctCheck As Integer

        If checkTurda = True Then
            ctCheck = 20
        Else
            ctCheck = 0
        End If

        'multiplying coach type by price per person per day
        Dim ctTotal As integer
        Select Case ctSelected
            Case 12
                ctTotal = 12 * 150
            Case 21
                ctTotal = 21 * 100
            Case 55
                ctTotal = 55 * 70
        End Select

        Dim total = ctTotal + tlSelected + cbCheck + clCheck + cpCheck + ctCheck
        TextBoxTotal.Text = total

        'enabling purchase button
        If TextBoxTotal.Text <= 0 Then
            'BtnPurchase.Enabled = False
            'do nothing
        Else
            BtnPurchase.Enabled = True
        End If

    End Sub

    Private Sub BtnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPurchase.Click
        Dim totalBalance As Integer = TextBoxTotal.Text
        Dim gotoPurchase As New PurchaseForm(totalBalance)
        Me.Hide()
        'PurchaseForm.Show()
        gotoPurchase.Show()

    End Sub

End Class