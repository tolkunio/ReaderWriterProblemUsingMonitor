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

namespace Cinematix01
{
    public partial class Runner : Form
    {
        private static CinemaHall hall = new CinemaHall(10, 10);
        private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();

        public Runner()
        {
            InitializeComponent();
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            new MainForm(hall,locker).Show();
        }
    }
}
