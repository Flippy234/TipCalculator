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
        //Multiply bill amount by percent tip
        double dblBillAmount, dblTipAmount, dblTotalAmount;
        Double.TryParse(txtBillAmount.Text, out dblBillAmount);
        //Double.TryParse()
        double tipRate = 0.15;
        dblTipAmount = dblBillAmount * tipRate;
        //dblTotalAmount = dblBillAmount + dblTipAmount;

        lblTipAmount.Text = lblTip1.Text + "" + "$" + dblTipAmount;
        
    }

    private void TwentyPercentTip_OnClicked(object sender, EventArgs e)
    {
       
    }

    private void TwentyFivePercentTip_OnClicked(object sender, EventArgs e)
    {
        
    }
    
}