using System;
using Android.App;
using Android.Widget;
using Android.OS;
using XamarinPlayground.Lib;

namespace XamarinPlayground.Android
{
	[Activity(Label = "XamarinPlayground.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : Activity, IGuiView
	{

		private Button calculateButton;
		private EditText edit1;
		private EditText edit2;
		private TextView text1;
		
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			calculateButton = FindViewById<Button>(Resource.Id.MyButton);
			edit1 = FindViewById<EditText>(Resource.Id.editText1);
			edit2 = FindViewById<EditText>(Resource.Id.editText2);
			text1 = FindViewById<TextView>(Resource.Id.textView1);

			calculateButton.Click += delegate
				{
					if (this.CalculatePushed != null)
					{
						this.CalculatePushed(this, EventArgs.Empty);
					}
				};

			new GuiModel(this);
		}

		public string Input1 {
			get { return this.edit1.Text; }
			set { this.edit1.Text = value; }
		}
		public string Input2
		{
			get { return this.edit2.Text; }
			set { this.edit2.Text = value; }
		}
		public string Answer {
			get { return this.text1.Text; }
			set { this.text1.Text = value; }
		}
		public event EventHandler CalculatePushed;

	}
}
