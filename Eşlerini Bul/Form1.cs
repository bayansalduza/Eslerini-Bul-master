using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eşlerini_Bul
{
    public partial class Form1 : Form
    {
        EsBul es = new EsBul();
        List<Image> il = new List<Image>();
        int syc2 = 0;
        int syc = 0;
        List<PictureBox> pbl = new List<PictureBox>();
        List<Button> btl = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            il.Add(Properties.Resources.facebook);
            il.Add(Properties.Resources.instagram);
            il.Add(Properties.Resources.linkedin);
            il.Add(Properties.Resources.netflix);
            il.Add(Properties.Resources.twitch);
            il.Add(Properties.Resources.twitter);
            il.Add(Properties.Resources.udemy);
            il.Add(Properties.Resources.youtube);
            es.pcbdo(this, pbl);
            es.butdo(this, btl);
            bool[] d = new bool[pbl.Count];
            es.bodl(true, d);
            es.pictdol(pbl, d, il);
            es.vispb(pbl, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3],(PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0],(Button) li[1],(PictureBox) li[2],(PictureBox) li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox1.Visible = true;
                button1.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox2.Visible = true;
                button2.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox3.Visible = true;
                button3.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox4.Visible = true;
                button4.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox5.Visible = true;
                button5.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox6.Visible = true;
                button6.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox7.Visible = true;
                button7.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox8.Visible = true;
                button8.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox9.Visible = true;
                button9.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox10.Visible = true;
                button10.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox11.Visible = true;
                button11.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox12.Visible = true;
                button12.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox13.Visible = true;
                button13.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox14.Visible = true;
                button14.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox15.Visible = true;
                button15.Visible = false;
            }
            if (syc2 == 7)
           es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            syc++;
            if (syc > 2)
            {
                syc = 0;
                List<object> li = es.bandp(btl, pbl);
                if (es.karsi((PictureBox)li[3], (PictureBox)li[2]))
                {
                    es.dgrscm(this, (Button)li[0], (Button)li[1], (PictureBox)li[2], (PictureBox)li[3]);
                    syc2++;
                }
                es.rest(pbl, btl);
            }
            else
            {
                pictureBox16.Visible = true;
                button16.Visible = false;
            }
            if (syc2 == 7)
                es.finish(this, pbl, btl, Properties.Resources.congratulation_free_download_png_congratulations_png_2360_1777, "Tebrikler");
        }

    }
}
