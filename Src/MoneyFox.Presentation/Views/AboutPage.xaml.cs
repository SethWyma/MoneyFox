﻿using MoneyFox.Foundation.Resources;
using Xamarin.Forms.Xaml;

namespace MoneyFox.Presentation.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
		    Title = Strings.AboutTitle;
		}
	}
}