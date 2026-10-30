namespace IncompleteApp
{
    public partial class Form1 : Form
    {
        private readonly float RUN_SPEED = 10f;
        private readonly float RUN_DISTANCE = 300f;
        private string calcTrue = "";

        public Form1()
        {
            InitializeComponent();
            //runTimer.Start();
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = Cursor.Position;

            float dx = Location.X + Width / 2f - cursor.X;
            float dy = Location.Y + Height / 2f - cursor.Y;

            float length = MathF.Sqrt(dx * dx + dy * dy);
            if (length > RUN_DISTANCE) return;

            Location = new Point(
                Location.X + (int)(dx / length * RUN_SPEED * (RUN_DISTANCE / length)),
                Location.Y + (int)(dy / length * RUN_SPEED * (RUN_DISTANCE / length))
            );
        }

        private void buttonValued_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
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
    }
}
