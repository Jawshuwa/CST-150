namespace T6_A14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Generating a streamreader instance, and a random instance for generation
            StreamReader input = new StreamReader(@"SS_Quotes.txt");
            Random random = new Random();

            // Reading random quote from input file
            string quote = string.Empty;
            int line = random.Next(1, 19);
            for (int i = 0; i < line; i++)
            {
                quote = input.ReadLine();
            }

            // Font choice
            string fontChoice = fontChoiceBox.GetItemText(fontChoiceBox.SelectedItem);

            // Font size
            int fontSize = 8;
            if (fontSize1.Checked) { fontSize = 12; }
            else if (fontSize2.Checked) { fontSize = 16; }

            // Getting time and date if checked
            var dateTime = DateTime.Now;
            string date = String.Empty;  string time = String.Empty;
            if (Date.Checked) { date = dateTime.ToShortDateString() + " "; }
            if (Time.Checked) { time = dateTime.ToShortTimeString(); }

            // Inputing quote and formatting textbox with selected values
            quoteBox.Font = new Font(fontChoice, fontSize);

            if (Time.Checked || Date.Checked)
            {
                quoteBox.Text = quote + " " + date + time;
            }
            else
            {
                quoteBox.Text = quote;
            }
        }
    }
}