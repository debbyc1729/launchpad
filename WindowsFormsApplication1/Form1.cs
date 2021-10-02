using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static Random R = new Random();
        Random ans = new Random();

        //SoundPlayer pp = new SoundPlayer();
        //MediaElement();

        int r=R.Next(0,255);
        int g = R.Next(0, 255);
        int b = R.Next(0, 255);
        int c = R.Next(0, 255);

        //int number = 5;
        int m = 0;
        int n = 4;
        //int mc;

        int second;

        string song;

        Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            this.listBox1.Items.Add("命ばっかり ver luz");
            this.listBox1.Items.Add("米津玄師 MV「LOSER」");
            this.listBox1.Items.Add("amazarashi - 僕が死のうと思ったのは");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 500;


        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            second = 30;

            create();

            buttons[0].Click += new EventHandler(this.Buttons_TClick_0);
            buttons[1].Click += new EventHandler(this.Buttons_TClick_1);
            buttons[2].Click += new EventHandler(this.Buttons_TClick_2);
            buttons[3].Click += new EventHandler(this.Buttons_TClick_3);
            buttons[4].Click += new EventHandler(this.Buttons_TClick_4);
            buttons[5].Click += new EventHandler(this.Buttons_TClick_5);
            buttons[6].Click += new EventHandler(this.Buttons_TClick_6);
            buttons[7].Click += new EventHandler(this.Buttons_TClick_7);
            buttons[8].Click += new EventHandler(this.Buttons_TClick_8);
            buttons[9].Click += new EventHandler(this.Buttons_TClick_9);
            buttons[10].Click += new EventHandler(this.Buttons_TClick_10);
            buttons[11].Click += new EventHandler(this.Buttons_TClick_11);
            buttons[12].Click += new EventHandler(this.Buttons_TClick_12);
            buttons[13].Click += new EventHandler(this.Buttons_TClick_13);
            buttons[14].Click += new EventHandler(this.Buttons_TClick_14);
            buttons[15].Click += new EventHandler(this.Buttons_TClick_15);
        }

        private void choose_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems.Count > 0)
            {
                song = this.listBox1.SelectedItem.ToString();
                //pp.SoundLocation =  song + ".wav";
                //pp.Load();
                axWindowsMediaPlayer1.URL = song + ".wav";
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                
            }
            else
            {
                MessageBox.Show("沒選歌喔");
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            //pp.Play();
            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //pp.Stop();
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        void Music_Play(object sender, EventArgs e)
        {
            //pp.SoundLocation = @"https://www.youtube.com/watch?v=Dx_fKPBPYUI.wav";
            //pp.Load();
            //pp.Play();
        }

        void Buttons_Click(object sender, EventArgs e)
        {

        }

        void Buttons_TClick(object sender, EventArgs e)
        {

        }

        void Buttons_TClick_0(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 0";
            
            int se=second+2;
            //label1.Text = se.ToString();
            //this.buttons[0].BackColor = Color.FromArgb(102, 255, 230);
            if(se==second)
            {
                //create();
                //this.buttons[0].BackColor = Color.FromArgb(245, 245, 245);
            }
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "1.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"1.wav";
            pp.Load();
            pp.Play();*/
            //MessageBox.Show("0");
        }

        void Buttons_TClick_1(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 1"; 
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "2.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"2.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_2(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 2";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "3.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"3.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_3(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 3";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "4.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"4.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_4(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 4";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "5.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"5.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_5(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 5";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "6.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"6.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_6(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 6";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "7.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"7.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_7(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 7";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "8.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"8.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_8(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 8";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "9.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"9.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_9(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 9";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "10.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"10.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_10(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 10";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "11.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"11.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_11(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 11"; int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "11.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"11.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_12(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 12";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "11.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"11.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_13(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 13";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "11.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"11.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_14(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 14";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "11.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"11.wav";
            pp.Load();
            pp.Play();*/
        }

        void Buttons_TClick_15(object sender, EventArgs e)
        {
            label2.Text = "按鍵: 15";
            int se = second + 1;
            
            var pp1 = new WMPLib.WindowsMediaPlayer();
            pp1.URL = "11.wav";
            /*SoundPlayer pp = new SoundPlayer();
            pp.SoundLocation = @"11.wav";
            pp.Load();
            pp.Play();*/
        }


        void clear()
        {
                for (int i = 0; i < n * n; i++)
                {
                    this.Controls.Remove(buttons[i]);

                }
        }

        void create()
        {
            r = R.Next(0, 255);
            g = R.Next(0, 255);
            b = R.Next(0, 255);

            c = 30;

            //if (number == n)
            //{
                

                buttons = new Button[n * n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        buttons[i * n + j] = new Button();
                        buttons[i * n + j].Name = "button" + (i * n + j);
                        buttons[i * n + j].Text = "";
                        buttons[i * n + j].Size = new Size(400 / n, 400 / n);
                        buttons[i * n + j].BackColor = Color.FromArgb(245, 245, 245);
                        buttons[i * n + j].Location = new Point(100 + j * (400 / n), i * (400 / n));
                        buttons[i * n + j].Click += new EventHandler(Buttons_Click);
                    }
                }
                this.Controls.AddRange(buttons);

                
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            //time.Text = second.ToString();
            /*
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    buttons[i * n + j].BackColor = Color.FromArgb(245, 245, 245);
                }
            }*/

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D4)
            {
                buttons[0].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_0(sender, e);
            }
            if (e.KeyData == Keys.D5)
            {
                buttons[1].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_1(sender, e);
            }
            if (e.KeyData == Keys.D6)
            {
                buttons[2].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_2(sender, e);
            }
            if (e.KeyData == Keys.D7)
            {
                buttons[3].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_3(sender, e);
            }

            if (e.KeyData == Keys.E)
            {
                buttons[4].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_4(sender, e);
            }
            if (e.KeyData == Keys.R)
            {
                buttons[5].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_5(sender, e);
            }
            if (e.KeyData == Keys.T)
            {
                buttons[6].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_6(sender, e);
            }
            if (e.KeyData == Keys.Y)
            {
                buttons[7].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_7(sender, e);
            }

            if (e.KeyData == Keys.D)
            {
                buttons[8].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_8(sender, e);
            }
            if (e.KeyData == Keys.F)
            {
                buttons[9].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_9(sender, e);
            }
            if (e.KeyData == Keys.G)
            {
                buttons[10].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_10(sender, e);
            }
            if (e.KeyData == Keys.H)
            {
                buttons[11].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_11(sender, e);
            }

            if (e.KeyData == Keys.C)
            {
                buttons[12].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_12(sender, e);
            }
            if (e.KeyData == Keys.V)
            {
                buttons[13].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_13(sender, e);
            }
            if (e.KeyData == Keys.B)
            {
                buttons[14].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_14(sender, e);
            }
            if (e.KeyData == Keys.N)
            {
                buttons[15].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_15(sender, e);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D4)
            {
                buttons[0].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.D5)
            {
                buttons[1].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.D6)
            {
                buttons[2].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.D7)
            {
                buttons[3].BackColor = Color.FromArgb(245, 245, 245);
            }

            if (e.KeyData == Keys.E)
            {
                buttons[4].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.R)
            {
                buttons[5].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.T)
            {
                buttons[6].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.Y)
            {
                buttons[7].BackColor = Color.FromArgb(245, 245, 245);
            }

            if (e.KeyData == Keys.D)
            {
                buttons[8].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.F)
            {
                buttons[9].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.G)
            {
                buttons[10].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.H)
            {
                buttons[11].BackColor = Color.FromArgb(245, 245, 245);
            }

            if (e.KeyData == Keys.C)
            {
                buttons[12].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.V)
            {
                buttons[13].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.B)
            {
                buttons[14].BackColor = Color.FromArgb(245, 245, 245);
            }
            if (e.KeyData == Keys.N)
            {
                buttons[15].BackColor = Color.FromArgb(245, 245, 245);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (e.KeyData == Keys.D4)
            {
                buttons[0].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_0(sender, e);
            }
            if (e.KeyData == Keys.D5)
            {
                buttons[1].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_1(sender, e);
            }
            if (e.KeyData == Keys.D6)
            {
                buttons[2].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_2(sender, e);
            }
            if (e.KeyData == Keys.D7)
            {
                buttons[3].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_3(sender, e);
            }

            if (e.KeyData == Keys.E)
            {
                buttons[4].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_4(sender, e);
            }
            if (e.KeyData == Keys.R)
            {
                buttons[5].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_5(sender, e);
            }
            if (e.KeyData == Keys.T)
            {
                buttons[6].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_6(sender, e);
            }
            if (e.KeyData == Keys.Y)
            {
                buttons[7].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_7(sender, e);
            }

            if (e.KeyData == Keys.D)
            {
                buttons[8].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_8(sender, e);
            }
            if (e.KeyData == Keys.F)
            {
                buttons[9].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_9(sender, e);
            }
            if (e.KeyData == Keys.G)
            {
                buttons[10].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_10(sender, e);
            }
            if (e.KeyData == Keys.H)
            {
                buttons[11].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_11(sender, e);
            }

            if (e.KeyData == Keys.C)
            {
                buttons[12].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_12(sender, e);
            }
            if (e.KeyData == Keys.V)
            {
                buttons[13].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_13(sender, e);
            }
            if (e.KeyData == Keys.B)
            {
                buttons[14].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_14(sender, e);
            }
            if (e.KeyData == Keys.N)
            {
                buttons[15].BackColor = Color.FromArgb(102, 255, 230);
                Buttons_TClick_15(sender, e);
            }*/
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
