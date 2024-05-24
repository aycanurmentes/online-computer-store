using TabbedPages.Models;

namespace TabbedPages;

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();
        lblTotal.Text = TotalInfo.Price.ToString();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
        MemBtnMin.IsEnabled = false;
        StrBtnMin.IsEnabled = false;
        MonBtnMin.IsEnabled = false;
    }

    void MemBtnMin_Clicked(System.Object sender, System.EventArgs e)
    {
        int meminus;
        int.TryParse(lblMem.Text, out meminus);
        if (meminus == 4)
        {
            meminus = 0;
            lblMem.Text = "0";
            TotalInfo.Price -= 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (meminus == 8)
        {
            meminus = 4;
            lblMem.Text = "4";
            MemBtnMin.IsEnabled = false;
            TotalInfo.Price -= 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (meminus == 12)
        {
            meminus = 8;
            lblMem.Text = "8";
            TotalInfo.Price -= 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (meminus == 16)
        {
            meminus = 12;
            lblMem.Text = "12";
            MemBtnMax.IsEnabled = true;
            TotalInfo.Price -= 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
    }

    void MemBtnMax_Clicked(System.Object sender, System.EventArgs e)
    {
        int memplus;
        int.TryParse(lblMem.Text, out memplus);
        if (memplus == 0)
        {
            memplus = 4;
            lblMem.Text = "";
            MemBtnMin.IsEnabled = true;
            TotalInfo.Price -= 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (memplus == 4)
        {
            memplus = 8;
            lblMem.Text = "8";
            TotalInfo.Price += 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (memplus == 8)
        {
            memplus = 12;
            lblMem.Text = "12";
            TotalInfo.Price += 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (memplus == 12)
        {
            memplus = 16;
            lblMem.Text = "16";
            MemBtnMax.IsEnabled = false;
            TotalInfo.Price += 150;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
    }

    void MonBtnMin_Clicked(System.Object sender, System.EventArgs e)
    {
        int monmin;
        int.TryParse(lblMon.Text, out monmin);
        if (monmin == 17)
        {
            monmin = 0;
            lblMon.Text = "0";
            MonBtnMin.IsEnabled = false;
            TotalInfo.Price -= 450;
            lblTotal.Text = TotalInfo.Price.ToString();

        }
        else if (monmin == 20)
        {
            monmin = 17;
            lblMon.Text = "17";
            TotalInfo.Price -= 450;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (monmin == 23)
        {
            monmin = 20;
            lblMon.Text = "20";
            TotalInfo.Price -= 450;
            MonBtnMax.IsEnabled = true;
            lblTotal.Text = TotalInfo.Price.ToString();
        }

    }

    void MonBtnMax_Clicked(System.Object sender, System.EventArgs e)
    {
        int monmax;
        int.TryParse(lblMon.Text, out monmax);
        if (monmax == 0)
        {
            monmax = 17;
            lblMon.Text = "17";
            MonBtnMin.IsEnabled = true;
            TotalInfo.Price += 450;
            lblTotal.Text = TotalInfo.Price.ToString();

        }
        else if (monmax == 17)
        {
            monmax = 20;
            lblMon.Text = "20";
            TotalInfo.Price += 450;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
        else if (monmax == 20)
        {
            monmax = 23;
            lblMon.Text = "23";
            TotalInfo.Price += 450;
            MonBtnMax.IsEnabled = false;
            lblTotal.Text = TotalInfo.Price.ToString();
        }
    }

    void StrBtnMin_Clicked(System.Object sender, System.EventArgs e)
    {
        int strmin;
        int.TryParse(lblStr.Text, out strmin);

        if (strmin == 500)
        {
            strmin = 0;
            lblStr.Text = "0";
            StrBtnMin.IsEnabled = false;

            if (TotalInfo.StType == 1)
            {
                TotalInfo.Price -= 500;
                lblTotal.Text = TotalInfo.Price.ToString();

            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price -= 300;
                lblTotal.Text = TotalInfo.Price.ToString();
            }
        }
        else if (strmin == 1000)
        {
            strmin = 500;
            lblStr.Text = "500";
            StrBtnMax.IsEnabled = true;
            if (TotalInfo.StType == 1)
            {
                TotalInfo.Price -= 500;
                lblTotal.Text = TotalInfo.Price.ToString();

            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price -= 300;
                lblTotal.Text = TotalInfo.Price.ToString();
            }
        }
    }

    void StrBtnMax_Clicked(System.Object sender, System.EventArgs e)
    {
        int strmax;
        int.TryParse(lblStr.Text, out strmax);

        if (strmax == 0)
        {
            strmax = 500;
            lblStr.Text = "500";
            StrBtnMin.IsEnabled = true;

            if (TotalInfo.StType == 1)
            {
                TotalInfo.Price += 500;
                lblTotal.Text = TotalInfo.Price.ToString();

            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price += 300;
                lblTotal.Text = TotalInfo.Price.ToString();
            }
        }
        else if (strmax == 500)
        {
            strmax = 1000;
            lblStr.Text = "1000";
            StrBtnMax.IsEnabled = false;
            if (TotalInfo.StType == 1)
            {
                TotalInfo.Price += 500;
                lblTotal.Text = TotalInfo.Price.ToString();

            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price += 300;
                lblTotal.Text = TotalInfo.Price.ToString();
            }
        }
    }
}