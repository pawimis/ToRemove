using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToRemove;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Debug.WriteLine("Test");
        Debug.WriteLine(Navigation.NavigationStack);
        Navigation.PopAsync();
    }
}