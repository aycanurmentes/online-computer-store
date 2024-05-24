using TabbedPages.Models;

namespace TabbedPages;

public partial class StorePage : ContentPage
{
	public StorePage()
	{
		InitializeComponent();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
    }

   private void RBi3_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
	{
		if (RBi3.IsChecked)
		{
            TotalInfo.CPU += 1;
		}
		else if(RBi5.IsChecked)
		{
            TotalInfo.CPU += 2;
        }
        else if (RBi7.IsChecked)
        {
            TotalInfo.CPU += 3;
        }
        else if (RBi9.IsChecked)
        {
            TotalInfo.CPU += 4;
        }
        if (TotalInfo.CPU == 1)
        {
            TotalInfo.Price = 1500;
        }
        else if(TotalInfo.CPU == 2)
        {
            TotalInfo.Price = 1700;
        }
        else if (TotalInfo.CPU == 3)
        {
            TotalInfo.Price = 2000;
        }
        else if (TotalInfo.CPU == 4)
        {
            TotalInfo.Price = 2500;
        }
    }

   private void RBssd_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        if(RBssd.IsChecked)
        {
            TotalInfo.StType += 1;
        }
        else if (RBhhd.IsChecked)
        {
            TotalInfo.StType += 2;
        }
    }

    
}
