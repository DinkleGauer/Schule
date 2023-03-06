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

        private void Felder_Leeren()
        {
            textBezugspreis.Clear();
            textLieferRabatt.Clear();
            textFirma.Clear();
            textLieferSkonto.Clear();
            textListenPreis.Clear();
            textSonstRabatt.Clear();
        }

        

        private string Inhalt_pruefen(string Inhalt, string Aufruf)
        {
            int Ergebnis;
            bool success = int.TryParse(Inhalt, out Ergebnis);
            if (success)
            {
                if (Ergebnis > 100 && (Aufruf == textSonstRabatt.Name || Aufruf == textLieferRabatt.Name || Aufruf == textLieferSkonto.Name))
                {
                    Felder_Leeren();
                    System.Windows.Forms.MessageBox.Show("Ungueltige Eingabe oder mehr als 100%");
                    return "0";
                }
                return Inhalt;
            }
            Felder_Leeren();
            System.Windows.Forms.MessageBox.Show("Ungueltige Eingabe oder mehr als 100%");
            return "0";
        }

        Angebot[] AngebotNEU = new Angebot[1];
        private void Erstellen_click(object sender, EventArgs e)
        {
            // Daten bekommen
            for (int i = AngebotNEU.Length-1; i < AngebotNEU.Length; i++)
            {
                AngebotNEU[i] = new Angebot
                {
                    Firma = textFirma.Text,
                    Bezugspreis = int.Parse(textBezugspreis.Text),
                    Lieferskonto = int.Parse(Inhalt_pruefen(textLieferSkonto.Text, textLieferSkonto.Name)),
                    Listeneinkaufspreis = int.Parse(textListenPreis.Text),
                    Lieferrabatt = int.Parse(Inhalt_pruefen(textLieferRabatt.Text, textLieferRabatt.Name)),
                    SonstRabatt = int.Parse(Inhalt_pruefen(textSonstRabatt.Text, textSonstRabatt.Name))
                };


                // F�llen der Tabelle            
                BindingSource binding = new BindingSource();
                binding.DataSource = AngebotNEU;
                dataGridView1.DataSource = binding;
            }
            System.Windows.Forms.MessageBox.Show("Angebot angelegt");
            Felder_Leeren();
            Array.Resize(ref AngebotNEU, AngebotNEU.Length +1);
        }

        private void Vergleichen_Click(object sender, EventArgs e)
        {

        }
    }
}