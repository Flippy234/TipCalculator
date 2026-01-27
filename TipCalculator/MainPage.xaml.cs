namespace TipCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Title = "Tip Calculator";
    }

    private void FifteenPercentTip_OnClicked(object sender, EventArgs e)
    {
        
        //Work on this
        //Multiply bill amount by percent tip
        double dblBillAmount;
        Double.TryParse(txtBillAmount.Text, out dblBillAmount);
        double tipRate = 0.15;
        double dblTipAmount = dblBillAmount * tipRate;
        double dblTotalAmount = dblBillAmount + dblTipAmount;

        lblTipAmount.Text = $"15% Tip: ${dblTipAmount}";
        lblTotalAmount.Text = $"${dblTotalAmount}";
    }

    private void TwentyPercentTip_OnClicked(object sender, EventArgs e)
    {
        double dblBillAmount;
        Double.TryParse(txtBillAmount.Text, out dblBillAmount);
        double tipRate = 0.20;
        double dblTipAmount = dblBillAmount * tipRate;
        double dblTotalAmount = dblBillAmount + dblTipAmount;

        lblTipAmount.Text = $"20% Tip: ${dblTipAmount}";
        lblTotalAmount.Text = $"${dblTotalAmount}";
    }

    private void TwentyFivePercentTip_OnClicked(object sender, EventArgs e)
    {
        double dblBillAmount;
        Double.TryParse(txtBillAmount.Text, out dblBillAmount);
        double tipRate = 0.25;
        double dblTipAmount = dblBillAmount * tipRate;
        double dblTotalAmount = dblBillAmount + dblTipAmount;

        lblTipAmount.Text = $"25% Tip: ${dblTipAmount}";
        lblTotalAmount.Text = $"${dblTotalAmount}";
    }
    
}