using System;

namespace XamarinPlayground.Lib
{
	public interface IGuiView
	{
		string Input1 { get; set; }
		string Input2 { get; set; }
		string Answer { get; set; }
		event EventHandler CalculatePushed;
	}

	public class GuiModel
	{
		public IGuiView View { get; set; }
		public Calculator Calculator;

		public GuiModel(IGuiView View)
		{
			if (View == null)
			{
				throw new ArgumentNullException("View");
			}
			this.View = View;
			this.View.CalculatePushed += DoCalculation;
			this.Calculator = new Calculator();
		}

		private void DoCalculation(object sender, EventArgs e)
		{
			int a = this.View.Input1.ToIntOrNull() ?? 0;
			int b = this.View.Input2.ToIntOrNull() ?? 0;
			int answer = this.Calculator.Add(a, b);
			this.View.Answer = answer.ToString();
		}

	}
}
