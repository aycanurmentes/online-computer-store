using TabbedPages.DataTranscations;

namespace TabbedPages;

public partial class App : Application
{
	public static DBTrans DBTrans { get; set; }
	public App(DBTrans dbtrans)
	{
		InitializeComponent();

		MainPage = new AppShell();
		DBTrans = dbtrans;
	}
}

