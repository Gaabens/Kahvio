namespace Kahvio
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            MeistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin \n";
            MeistaLB.Text += "9:00 - 12:30. {\n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            MeistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa ja makeisia \n";
            MeistaLB.Text += "Tervetuloa tutustumaan! \n";
            MeistaLB.Font = new Font("Arial", 12);
        }
    }
}
