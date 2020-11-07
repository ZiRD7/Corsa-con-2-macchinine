using Macchinine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Macchinine
{
    // Driza Enes - Corsa V.0.1
    // Note: -------

    public partial class frmMain : Form
    {
        BackgroundWorker bgwMacchinaNera, bgwMacchinaRossa;

        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            pcbMacchinaNera.BackColor = Color.Black;
            pcbMacchinaRossa.BackColor = Color.Black;

            pcbMacchinaNera.Left = Globals.x;
            pcbMacchinaRossa.Left = Globals.x;

            lblTesto.Text = "";

            btnStop.Enabled = false;
            btnReset.Enabled = false;
        }


        private void btnAvvia_Click(object sender, EventArgs e)
        {
            // abilito il tasto reset e disabilito il tasto avvia
            btnAvvia.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = true;

            bgwMacchinaNera = new BackgroundWorker();
            bgwMacchinaNera.WorkerReportsProgress = true;
            bgwMacchinaNera.WorkerSupportsCancellation = true;
            bgwMacchinaNera.DoWork += backgroundWorker_DoWork;
            bgwMacchinaNera.ProgressChanged += bgw_ProgressChanged;
            bgwMacchinaNera.RunWorkerCompleted += bgw_RunWorkerCompleted;

            bgwMacchinaRossa = new BackgroundWorker();
            bgwMacchinaRossa.WorkerReportsProgress = true;
            bgwMacchinaRossa.WorkerSupportsCancellation = true;
            bgwMacchinaRossa.DoWork += backgroundWorker_DoWork;
            bgwMacchinaRossa.ProgressChanged += bgw_ProgressChanged;
            bgwMacchinaRossa.RunWorkerCompleted += bgw_RunWorkerCompleted;

            // faccio partire i worker con le rispettive pictureBox
            bgwMacchinaNera.RunWorkerAsync(pcbMacchinaNera);
            bgwMacchinaRossa.RunWorkerAsync(pcbMacchinaRossa);
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            bgwMacchinaNera.CancelAsync();
            bgwMacchinaRossa.CancelAsync();

            btnAvvia.Enabled = true;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            bgwMacchinaNera.CancelAsync();
            bgwMacchinaRossa.CancelAsync();

            pcbMacchinaNera.Left = Globals.x;
            pcbMacchinaRossa.Left = Globals.x;

            btnAvvia.Enabled = true;
            btnStop.Enabled = false;
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            PictureBox img = e.Argument as PictureBox;

            while (img.Right < pcbBackground.Right) // finchè non arrivo alla fine
            {
                Thread.Sleep(100); // piccola pausa
                bgw.ReportProgress(pcbBackground.Right - img.Right, img); // riporto la distanza dal finale e la pictureBox

                if(bgw.CancellationPending)
                {
                    e.Result = (false, "NO"); // no perchè evo passare una stringa per la tupla
                    return;
                }
            }
            bgw.CancelAsync();
            e.Result = (true, img.AccessibleName); // ho concluso il mio lavoro (true) e nome del vincitore
        }


        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox img = e.UserState as PictureBox;
            Random random = new Random();

            var avanzamento = random.Next(50);
            img.Left += avanzamento;
        }


        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Tupla
            var (completato, vincitore) = (ValueTuple<bool, string>)e.Result;

            // stampo il vincitore
            if(completato && lblTesto.Text == "")
                lblTesto.Text = vincitore;
        }

    }
}
