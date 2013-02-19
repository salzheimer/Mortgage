
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub btnPerformCalculation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPerformCalculations.Click

        'Specify constant values'

        Const INTEREST_CALCS_PER_YEAR As Integer = 12
        Const PAYMENTS_PER_YEAR As Integer = 12

        'Create variables to hold the values entered by user
        Dim principal As Decimal = txtPrincipalAmount.Text
        Dim rate As Decimal = txtInterestRate.Text
        Dim time As Decimal = txtMortgageLength.Text

        Dim ratePerPeriod As Decimal
        ratePerPeriod = rate / INTEREST_CALCS_PER_YEAR

        Dim payPeriods As Integer
        payPeriods = time * PAYMENTS_PER_YEAR

        Dim annualRate As Decimal
        annualRate = Math.Exp(INTEREST_CALCS_PER_YEAR * Math.Log(1 + ratePerPeriod)) - 1

        Dim intPerPayment As Decimal
        intPerPayment= (Math.Exp(Math.Log(annualRate+1)/payPeriods)-1 *)) payPeriods
        'Now compute the total cost of loan
        Dim intPerMonth As Decimal = intPerMonth / PAYMENTS_PER_YEAR

        Dim costPerMonth As Decimal
        costPerMonth = principal * intPerMonth / (1 - Math.Pow(intPerMonth + 1, -payPeriods))

        'Display the results in the results label
        lblResults.Text = "Your Mortgage payment per month is $" & costPerMonth.ToString("#,###.##")
    End Sub
End Class
