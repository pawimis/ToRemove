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

	protected override bool OnBackButtonPressed()
	{
		Debug.WriteLine("back");
		return base.OnBackButtonPressed();
	}
}