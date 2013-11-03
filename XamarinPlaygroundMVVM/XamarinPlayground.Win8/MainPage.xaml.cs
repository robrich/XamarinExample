using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamarinPlayground.Lib;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace XamarinPlayground.Win8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, IGuiView
    {

		public MainPage()
        {
            this.InitializeComponent();
			new GuiModel(this);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

		private void CalculateButton_Click(object sender, RoutedEventArgs e)
		{
			if (this.CalculatePushed != null)
			{
				this.CalculatePushed(this, EventArgs.Empty);
			}
		}

	    public string Input1 { 
			get { return this.TextBox1.Text; }
			set { this.TextBox1.Text = value; }
		}
	    public string Input2 {
			get { return this.TextBox2.Text; }
			set { this.TextBox2.Text = value; }
		}
	    public string Answer {
			get { return this.AnswerBlock.Text; }
			set { this.AnswerBlock.Text = value; }
		}
	    public event EventHandler CalculatePushed;
    }
}
