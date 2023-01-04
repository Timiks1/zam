namespace yyyy;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		zam.Text += enter.Text + "\n--------\n";
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		string[] arr = zam.Text.Split("--------");
		zam.Text = "";
		foreach(string a in arr)
		{
			if (a.Contains(request.Text))
			{
				zam.Text += a + "\n--------\n";

            }
		}

    }
}


