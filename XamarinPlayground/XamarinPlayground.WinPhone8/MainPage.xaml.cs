using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using XamarinPlayground.Lib;
using XamarinPlayground.WinPhone8.Resources;

namespace XamarinPlayground.WinPhone8
{
	public partial class MainPage : PhoneApplicationPage
	{

		private Calculator calculator;

		public MainPage()
		{
			InitializeComponent();
			this.calculator = new Calculator();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			int a = this.Edit1.Text.ToIntOrNull() ?? 0;
			int b = this.Edit2.Text.ToIntOrNull() ?? 0;
			int answer = this.calculator.Add(a, b);
			this.AnswerBlock.Text = answer.ToString();
		}

	}
}
