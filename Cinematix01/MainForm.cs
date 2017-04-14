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
    public partial class MainForm : Form
    {
        private readonly int perRows;
        private readonly int perCols;
        private CinemaHall hall;
        private ReaderWriterLockSlim rwLocker;


        private class Mapper
        {
            public int X { get; set; }
            public int Y { get; set; }
            public SeatState State { get; set; }
        }

        public MainForm(CinemaHall hall,ReaderWriterLockSlim locker)
        {
            rwLocker = locker;

            InitializeComponent();
            perRows = hallGrid.Width / hall._seats.Length;
            perCols = hallGrid.Height / hall._seats[0].Length;
            this.hall = hall;

            InitButtons();
            refreshBtn_Click(null, null);
        }


        private void InitButtons()
        {
            for (int i = 0; i < hall._seats.Length; i++)
            {
                for (int k = 0; k < hall._seats[0].Length; k++)
                {
                    Button button = new Button()
                    {
                        BackColor = Color.Green,
                        Tag = new Mapper()
                        {
                            X = k,
                            Y = i,
                            State = SeatState.Free
                        },
                        Name = string.Format("{0}:{1}", i, k),
                        Text = k.ToString(),
                        Location = new Point
                        {
                            X = k * perRows + 5,
                            Y = i * perCols + 5
                        },
                        Width = 60,
                        Height = 40,
                    };
                    button.Click += Button_Click;
                    hallGrid.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Mapper tag =(btn.Tag as Mapper);

            rwLocker.EnterWriteLock();

            if ( hall._seats[tag.Y][tag.X] == SeatState.Free )
            {
                hall._seats[tag.Y][tag.X] = SeatState.Busy;
                (btn.Tag as Mapper).State = SeatState.Busy;
            }
            else
            {
                MessageBox.Show("Это место уже забронировано!");
                //hall._seats[tag.Y][tag.X] = SeatState.Free;
                //(btn.Tag as Mapper).State = SeatState.Free;
            }

            rwLocker.ExitWriteLock();

            refreshBtn_Click(btn, null);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            rwLocker.EnterReadLock();
            for (int i = 0; i < hall._seats.Length; i++)
            {
                for (int k = 0; k < hall._seats[0].Length; k++)
                {
                    string key = string.Format("{0}:{1}", i, k);
                    Button button = hallGrid.Controls.Find(key, false).FirstOrDefault() as Button;
                    if (hall._seats[i][k] == SeatState.Free)
                    {
                        button.BackColor = Color.Green;
                        (button.Tag as Mapper).State = SeatState.Free;
                    }
                    else
                    {
                        button.BackColor = Color.Red;
                        (button.Tag as Mapper).State = SeatState.Busy;
                    }
                }
            }
            rwLocker.ExitReadLock();
        }
    }
}
