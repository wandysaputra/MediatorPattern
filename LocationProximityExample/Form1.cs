namespace LocationProximityExample
{
    public partial class Form1 : Form
    {
        private MarkerMediator mediator = new MarkerMediator();
        private Button addButton;
        public Form1()
        {
            InitializeComponent();
            this.addButton = new Button();
            this.addButton.Click += AddButtonOnClick;
            this.addButton.Text = "Add Marker";
            this.addButton.Dock = DockStyle.Bottom;
            this.addButton.AutoSize = true;
            this.Controls.Add(addButton);
        }

        private void AddButtonOnClick(object? sender, EventArgs e)
        {
            var marker = this.mediator.CreateMarker();
            this.Controls.Add(marker);
        }
    }
}