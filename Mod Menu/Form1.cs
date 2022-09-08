using Memory;
using System.Runtime.InteropServices;

namespace Mod_Menu
{
    public partial class Form1 : Form
    {
        public static bool start, allowPlace, allowBreak, allowMag;
        public static bool[] buttons = new bool[25];
        public static int ItemID;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        private void button25_Click(object sender, EventArgs e)
        {
            buttons[24] = !buttons[24];
            if (buttons[24])
            {
                button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button25.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buttons[23] = !buttons[23];
            if (buttons[23])
            {
                button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button24.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttons[22] = !buttons[22];
            if (buttons[22])
            {
                button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button23.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttons[21] = !buttons[21];
            if (buttons[21])
            {
                button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button22.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttons[20] = !buttons[20];
            if (buttons[20])
            {
                button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button21.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttons[19] = !buttons[19];
            if (buttons[19])
            {
                button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button20.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttons[18] = !buttons[18];
            if (buttons[18])
            {
                button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button19.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttons[17] = !buttons[17];
            if (buttons[17])
            {
                button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button18.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttons[16] = !buttons[16];
            if (buttons[16])
            {
                button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button17.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttons[15] = !buttons[15];
            if (buttons[15])
            {
                button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button16.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttons[14] = !buttons[14];
            if (buttons[14])
            {
                button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button15.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttons[13] = !buttons[13];
            if (buttons[13])
            {
                button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button14.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttons[12] = !buttons[12];
            if (buttons[12])
            {
                button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button13.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttons[11] = !buttons[11];
            if (buttons[11])
            {
                button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button12.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttons[10] = !buttons[10];
            if (buttons[10])
            {
                button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button11.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttons[9] = !buttons[9];
            if (buttons[9])
            {
                button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button10.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttons[8] = !buttons[8];
            if (buttons[8])
            {
                button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button9.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttons[7] = !buttons[7];
            if (buttons[7])
            {
                button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button8.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttons[6] = !buttons[6];
            if (buttons[6])
            {
                button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button7.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttons[5] = !buttons[5];
            if (buttons[5])
            {
                button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button6.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttons[4] = !buttons[4];
            if (buttons[4])
            {
                button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button5.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttons[3] = !buttons[3];
            if (buttons[3])
            {
                button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button4.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttons[2] = !buttons[2];
            if (buttons[2])
            {
                button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button3.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttons[1] = !buttons[1];
            if (buttons[1])
            {
                button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button2.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttons[0] = !buttons[0];
            if (buttons[0])
            {
                button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }

            else
            {
                button1.BackColor = System.Drawing.Color.Transparent;
            }
        }

        
        public static void Farm()
        {
            while (start)
            {
                if (allowPlace)
                {
                    if (allowMag)
                    {
                        Utility.LocalPlayer.CurrentItem(5640);
                        Modes.Place.Start(TargetCoords());
                    }

                    else
                    {
                        Utility.LocalPlayer.CurrentItem(ItemID);
                        Modes.Place.Start(TargetCoords());
                    }
                    
                }
                if (allowBreak)
                {
                    //Console.WriteLine("Breaking");
                    Utility.LocalPlayer.CurrentItem(18);
                    Modes.Break.Start(TargetCoords());
                }
                //Console.Clear();
                TargetCoords().ForEach(Console.WriteLine);
                Thread.Sleep(100);
            }
            World2Screen.Click.TargetBlock(0, 0);
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            start = !start;
            Thread farm = new Thread(Farm);
            if (start)
            {
                StartButton.Text = "STOP";
                farm.Start();
            }

            else
            {
                StartButton.Text = "START";
                World2Screen.Click.TargetBlock(0, 0);
            }
        }

        private void breakblock_CheckedChanged(object sender, EventArgs e)
        {
            if (breakblock.Checked)
            {
                allowBreak = true;
            }

            else
            {
                allowBreak = false;
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            ItemID = Int32.Parse(id.Text);
        }

        private void Magplant_CheckedChanged(object sender, EventArgs e)
        {
            if (placeblock.Checked)
            {
                allowMag = true;
            }

            else
            {
                allowMag = false;
            }
        }

        private void placeblock_CheckedChanged(object sender, EventArgs e)
        {
            if (placeblock.Checked)
            {
                allowPlace = true;
            }

            else
            {
                allowPlace = false;
            }
        }
        public static List<Utility.Vector2> TargetCoords()
        {
            List<Utility.Vector2> TargetBlocks = new List<Utility.Vector2>();
            for (int i = 0; i < 25; i++)
            {
                if (buttons[i])
                {
                    if (i >= 0 && i < 5)
                    {
                        TargetBlocks.Add(new Utility.Vector2(-2 + i, -2));
                    }

                    if (i >= 5 && i < 10)
                    {
                        TargetBlocks.Add(new Utility.Vector2(-7 + i, -1));
                    }

                    if (i >= 10 && i < 15)
                    {
                        TargetBlocks.Add(new Utility.Vector2(-12 + i, 0));
                    }

                    if (i >= 15 && i < 20)
                    {
                        TargetBlocks.Add(new Utility.Vector2(-17 + i, 1));
                    }

                    if (i >= 20 && i < 25)
                    {
                        TargetBlocks.Add(new Utility.Vector2(-22 + i, 2));
                    }
                }
            }
            return TargetBlocks;
        }
    }
}