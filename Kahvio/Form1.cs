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
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 v�lituntisin \n";
            MeistaLB.Text += "9:00 - 14:30 joka p�iv� maanantaista torstaihin ja perjantaisin \n";
            MeistaLB.Text += "9:00 - 12:30. {\n\n Keudan oppilaskunnan kahvilasta saa l�mpimien \n";
            MeistaLB.Text += "juomien lis�ksi virvokkeita sek� pient� purtavaa ja makeisia \n";
            MeistaLB.Text += "Tervetuloa tutustumaan! \n";
            MeistaLB.Font = new Font("Arial", 12);
        }
    }
}
