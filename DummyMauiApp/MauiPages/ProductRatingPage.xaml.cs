using System.Diagnostics;

namespace DummyMauiApp.MauiPages;

public partial class ProductRatingPage : ContentPage
{

	public ProductRatingPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Debug.WriteLine("Product rating: " + rating.Value);
		Navigation.PopModalAsync();
    }
}