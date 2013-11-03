using Android.App;
using Android.Widget;
using Android.OS;
using XamarinPlayground.Lib;

namespace XamarinPlayground.Android
{
	[Activity(Label = "XamarinPlayground.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : Activity
	{

		private Calculator calculator;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			this.calculator = new Calculator();

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.MyButton);
			EditText edit1 = FindViewById<EditText>(Resource.Id.editText1);
			EditText edit2 = FindViewById<EditText>(Resource.Id.editText2);
			TextView text1 = FindViewById<TextView>(Resource.Id.textView1);

			button.Click += delegate
				{
					int a = edit1.Text.ToIntOrNull() ?? 0;
					int b = edit2.Text.ToIntOrNull() ?? 0;
					int answer = calculator.Add(a, b);
					text1.Text = answer.ToString();
				};
		}
	}
}
