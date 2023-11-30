using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToRemove;

public partial class SimpleCalcPage : MetroWindow
{
	public SimpleCalcPage()
	{
		InitializeComponent();
		BindingContext = new ViewModel();

    }

	protected override bool OnBackButtonPressed()
	{
		Debug.WriteLine("back");
		return base.OnBackButtonPressed();
	}
}