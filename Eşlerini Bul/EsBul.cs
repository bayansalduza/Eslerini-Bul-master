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
    class EsBul
    {
        public bool karsi (PictureBox a, PictureBox b)
        {
            Bitmap b1 = new Bitmap(a.Image);
            Bitmap b2 = new Bitmap(b.Image);
            Color cl1 = new Color();
            Color cl2 = new Color();
            for (int i = 0; i < b1.Width; i++)
            {
                for (int j = 0; j < b1.Height; j++)
                {
                    cl1 = b1.GetPixel(i, j);
                    cl2 = b2.GetPixel(i, j);
                    if (cl1 != cl2)
                        return false;
                }
            }
            return true;
        }
        public List<PictureBox> pcbdo(Control a,List<PictureBox> b)
        {
            foreach(Control ct in a.Controls)
                if(ct is PictureBox)
                    b.Add((PictureBox)ct);
            return b;
        }
        public List<Button> butdo(Control a,List<Button> b)
        {
            foreach(Control ct in a.Controls)
                if (ct is Button)
                    b.Add((Button)ct);
            return b;
        }
        public bool[] bodl(bool a, bool[] b)
        {
            for(int i =0;i<b.Length;i++)
                b[i] = a;
            return b;
        }
        public void pictdol(List<PictureBox> pbl,bool[] bl,List<Image> il)
        {
            int syc = 0;
            int syc2 = 0;
            Random r = new Random();
            int i = 0;
            while (i<pbl.Count) 
            {
                int s = r.Next(pbl.Count);
                if (bl[s] == true)
                {
                    pbl[s].Image = il[syc2];
                    bl[s] = false;
                    syc++;
                    if (syc == 2)
                    {
                        syc = 0;
                        syc2++;
                        i += 2;
                    }
                }
            }
        }
        public void vispb(List<PictureBox> pbl,bool b)
        {
            foreach(PictureBox pb in pbl)
            {
                pb.Visible = b;
            }
        }
        
        public void dgrscm(Control a,Button b1,Button b2, PictureBox p1,PictureBox p2)
        {
            a.Controls.Remove(b1);
            a.Controls.Remove(b2);
            a.Controls.Remove(p1);
            a.Controls.Remove(p2);
        }
        public void finish(Control a, List<PictureBox> pbl, List<Button> btl, Image im,string s)
        {
            foreach (PictureBox pb in pbl)
                pb.Visible = true;
            foreach (Button b in btl)
                a.Controls.Remove(b);
            MessageBox.Show(s);
            foreach (PictureBox pb in pbl)
                a.Controls.Remove(pb);
            a.BackgroundImage = im;
        }
        public void rest(List<PictureBox> pbl,List<Button> btl)
        {
            foreach (Button bt in btl)
                bt.Visible = true;
            foreach (PictureBox pb in pbl)
                pb.Visible = false;
        }
        public List<Object> bandp(List<Button> btl,List<PictureBox> pbl)
        {
            List<object> li = new List<object>();
            int syc1 = 0;
            int syc2 = 0;
            foreach (Button bt in btl)
            {
                if (bt.Visible == false)
                {
                    if (syc1 == 0)
                    {
                        li.Add(bt);
                        syc1++;
                    }
                    else
                        li.Add(bt);
                }
            }
            foreach (PictureBox pb in pbl)
            {
                if (pb.Visible == true)
                {
                    if (syc2 == 0)
                    {
                        li.Add(pb);
                        syc2++;
                    }
                    else
                        li.Add(pb);
                }
            }
            return li;
        }
    }
}
