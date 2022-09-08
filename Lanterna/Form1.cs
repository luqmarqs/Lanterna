namespace Lanterna
{
    public partial class Form1 : Form
    {
        private Lanterna Lanterna{ get; set; }
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Lanterna = new Lanterna();
        }

        private void btn_on_off_Click(object sender, EventArgs e)
        {
            Lanterna.ligaDesliga();
            if (Lanterna.Status)
                lbl_status.Text = "Ligado";
            else
                lbl_status.Text = "Desligado";
        }

        private void btn_bateria_Click(object sender, EventArgs e)
        {
            Lanterna.trocaBateria();
            lbl_bateria.Text = $"{Lanterna.Bateria.Carga}%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Lanterna.Status)
            {
                Lanterna.Bateria.atualizaCarga();
                lbl_bateria.Text = $"{Lanterna.Bateria.Carga}%";
                if (Lanterna.Bateria.Carga == 0)
                {
                    Lanterna.ligaDesliga();
                    lbl_status.Text = "Desligado";
                }
                    
            }
        }
    }
}