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
	public partial class MainPage : PhoneApplicationPage, IGuiView
	{

		public MainPage()
		{
			InitializeComponent();
			new GuiModel(this);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (this.CalculatePushed != null)
			{
				this.CalculatePushed(this, EventArgs.Empty);
			}
		}

		public string Input1 {
			get { return this.Edit1.Text; }
			set { this.Edit1.Text = value; }
		}
		public string Input2
		{
			get { return this.Edit2.Text; }
			set { this.Edit2.Text = value; }
		}
		public string Answer
		{
			get { return this.AnswerBlock.Text; }
			set { this.AnswerBlock.Text = value; }
		}
		public event EventHandler CalculatePushed;
	}
}
