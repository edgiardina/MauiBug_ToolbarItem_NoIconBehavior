namespace MauiBug_ToolbarItem_NoIconBehavior;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("SubPage", typeof(SubPage));
    }
}
