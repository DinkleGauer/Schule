using System.Data.SqlClient;


namespace AngebotsVergleich
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Erstellen_click(object sender, EventArgs e)
        {
            Angebot AngebotNEU = new Angebot();
            AngebotNEU.Firma = textFirma.Text;
            AngebotNEU.Bezugspreis = int.Parse(textBezugspreis.Text);
            AngebotNEU.Lieferskonto = int.Parse(textLieferSkonto.Text);
            AngebotNEU.Listeneinkaufspreis = int.Parse(textListenPreis.Text);
            AngebotNEU.Lieferrabatt = int.Parse(textLieferRabatt.Text);
        }
    }
}