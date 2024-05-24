using TabbedPages.Models;

namespace TabbedPages;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
        lblTotal.Text = TotalInfo.Price.ToString();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
    }
}
