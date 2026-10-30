using System.Data;

namespace IncompleteApp
{
    public partial class Calc : Form
    {
        private readonly float RUN_SPEED = 20f;
        private readonly int RUN_DISTANCE = 10;
        private string? calcTrue = null;

        public Calc()
        {
            InitializeComponent();
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            Rectangle bounds = equals.RectangleToScreen(equals.ClientRectangle);
            bounds.Inflate(RUN_DISTANCE, RUN_DISTANCE);

            Point cursor = Cursor.Position;
            if (!bounds.Contains(cursor)) return;

            float dx = bounds.Left + bounds.Width / 2f - cursor.X;
            float dy = bounds.Top + bounds.Height / 2f - cursor.Y;

            float length = MathF.Sqrt(dx * dx + dy * dy);
            if (length == 0) return;

            Location = new Point(
                Location.X + (int)(dx / length * RUN_SPEED),
                Location.Y + (int)(dy / length * RUN_SPEED)
            );
        }

        private void buttonValued_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (calcTrue == null)
                {
                    // reset the calculation if the previous result was displayed
                    calcTrue = "";
                    calcMain.Text = "";
                    runTimer.Start();
                }

                switch (clickedButton.Name)
                {
                    case "multiplication":
                        calcTrue += "*";
                        calcMain.Text += "×";
                        break;
                    case "division":
                        calcTrue += "/";
                        calcMain.Text += "÷";
                        break;
                    case "backspace":
                        if (calcTrue.Length > 0)
                        {
                            calcTrue = calcTrue.Substring(0, calcTrue.Length - 1);
                            calcMain.Text = calcMain.Text.Substring(0, calcMain.Text.Length - 1);
                        }
                        break;
                    default:
                        calcTrue += clickedButton.Text;
                        calcMain.Text += clickedButton.Text;
                        break;
                }
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (calcTrue == null || calcTrue == "")
                return;
            double result;

            runTimer.Stop();

            try
            {
                result = Convert.ToDouble(new DataTable().Compute(calcTrue, null));
            }
            catch
            {
                result = double.NaN;
            }

            calcMain.Text = result.ToString("0.####");
            calcTrue = null; // used to reset the calculation after displaying the result
        }
    }
}
