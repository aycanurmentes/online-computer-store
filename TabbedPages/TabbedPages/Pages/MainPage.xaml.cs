﻿namespace TabbedPages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
	}

    void Add_Button_Clicked(System.Object sender, System.EventArgs e)
    {
        App.DBTrans.Add(new Models.UserInfo
        {
            Name = Usr_Name.Text
        });
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
    }

}


