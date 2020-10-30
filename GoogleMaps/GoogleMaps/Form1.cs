using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMaps
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        Graphics shortest_path;
        public int odabrani_cvor,odabrani_ispisi_liniju;
        public int broj_cvorova;
        public int cvor_start=-1, cvor_kraj=-1;
        public float margin_left,margin_right,margin_up,margin_down;
        public List<List<double>> graf_povezanosti;//tezinski graf
        public List<List<List<string>>> graf_sadrzaja;
        public List<Podaci> cvorovi;
        public List<Button> botuni;
        public double visina_max, visina_min, sirina_max, sirina_min;
        int pronadiNajbliziCvor(double x, double y, int poz)
        {
            int index = -1;
            double minValue = double.MaxValue;
            if(poz==cvor_start)
                for (int i = 0; i < broj_cvorova; i++)
                {
                    if (i == poz || i == cvor_kraj || !cvorovi[i].isReal) continue;
                    double pom = Math.Sqrt(Math.Pow(x - cvorovi[i].x, 2) + Math.Pow(y - cvorovi[i].y, 2));
                    if (pom < minValue)
                    {
                        minValue = pom;
                        index = i;
                    }
                }
            if(poz==cvor_kraj)
                for (int i = 0; i < broj_cvorova; i++)
                {
                    if (i == poz || i == cvor_start || !cvorovi[i].isReal) continue;
                    double pom = Math.Sqrt(Math.Pow(x - cvorovi[i].x, 2) + Math.Pow(y - cvorovi[i].y, 2));
                    if (pom < minValue)
                    {
                        minValue = pom;
                        index = i;
                    }
                }
            return index;
        }
        void prosiri_graf()
        {
            graf_povezanosti.Add(new List<double>());
            for (int i = 0; i < broj_cvorova; i++)
            {
                graf_povezanosti[i].Add(0);
                if (i == broj_cvorova - 1)
                {
                    for (int j = 0; j < broj_cvorova; j++)
                        graf_povezanosti[i].Add(0);
                }
            }
            graf_sadrzaja.Add(new List<List<string>>());
            for (int i = 0; i < broj_cvorova; i++)
            {
                graf_sadrzaja[i].Add(new List<string>());
                if (i == broj_cvorova - 1)
                {
                    for (int j = 0; j < broj_cvorova; j++)
                        graf_sadrzaja[i].Add(new List<string>());
                }
            }
            
        }
        void koordinate_novog_cvora(int cvor1, int cvor2, double udaljenost1, double udaljenost2, ref double x3, ref double y3,ref char ok)
        {
            double x1 = cvorovi[cvor1].x;
            double y1 = cvorovi[cvor1].y;
            double x2 = cvorovi[cvor2].x;
            double y2 = cvorovi[cvor2].y;
            double udaljenost = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (udaljenost1 + udaljenost2 < udaljenost)
            {
                ok = '-';
                return;//ne postoji trokut takav
            }
                
            double kut1 = Math.Atan2(2 * (y2 - y1), 2 * (x2 - x1));
            double kut2 = Math.Acos((udaljenost * udaljenost + udaljenost1 * udaljenost1 - udaljenost2 * udaljenost2)/(2*udaljenost*udaljenost1));
            x3 = x1 + udaljenost1 * Math.Cos(kut1 + kut2);
            y3 = y1 + udaljenost1 * Math.Sin(kut1 + kut2);
        }
        void dodaj_koordinate(double x,double y,string karakteristike)
        {
            
            if (karakteristike=="Start")
            {
                if(cvor_start!=-1 )
                {
                    //ponisti sve spojeve
                    for(int i=0;i<broj_cvorova;i++)
                    {
                        graf_povezanosti[cvor_start][i] = graf_povezanosti[i][cvor_start] = 0;
                        graf_sadrzaja[cvor_start][i] = graf_sadrzaja[i][cvor_start] = new List<string>();
                    }
                    cvorovi[cvor_start].x = x;
                    cvorovi[cvor_start].y = y;
                    int najblizi = pronadiNajbliziCvor(x, y, cvor_start);
                    dodaj_liniju(cvor_start, najblizi, karakteristike);
                    dodaj_liniju(najblizi, cvor_start, karakteristike);
                }
                else if(broj_cvorova>0)
                {
                    int najblizi=pronadiNajbliziCvor(x, y, cvor_start);
                    cvorovi.Add(new Podaci(x, y, karakteristike,false));
                    cvor_start = broj_cvorova;
                    broj_cvorova++;
                    prosiri_graf();
                    dodaj_liniju(cvor_start, najblizi, karakteristike);
                    dodaj_liniju(najblizi, cvor_start, karakteristike);
                    botuni.Add(new Button());
                }
                return;
            }
            if(karakteristike == "Kraj")
            {
                if (cvor_kraj != -1)
                {
                    //ponisti sve spojeve
                    for (int i = 0; i < broj_cvorova; i++)
                    {
                        graf_povezanosti[cvor_kraj][i] = graf_povezanosti[i][cvor_kraj] = 0;
                        graf_sadrzaja[cvor_kraj][i] = graf_sadrzaja[i][cvor_kraj] = new List<string>();
                    }
                    cvorovi[cvor_kraj].x = x;
                    cvorovi[cvor_kraj].y = y;
                    int najblizi = pronadiNajbliziCvor(x, y, cvor_kraj);
                    dodaj_liniju(najblizi, cvor_kraj,  karakteristike);
                    dodaj_liniju(cvor_kraj, najblizi, karakteristike);
                }
                else if(broj_cvorova > 0)
                {
                    int najblizi=pronadiNajbliziCvor(x, y, cvor_kraj);
                    cvorovi.Add(new Podaci(x, y, karakteristike,false));
                    cvor_kraj = broj_cvorova;
                    broj_cvorova++;
                    prosiri_graf();
                    dodaj_liniju(najblizi, cvor_kraj, karakteristike);
                    dodaj_liniju(cvor_kraj, najblizi, karakteristike);
                    botuni.Add(new Button());
                }
                return;
            } 

            Button botun = new Button();
            botun.Height = 20;
            botun.Width = 20;
            botun.Visible = false;
            botun.Enabled = false;
            botun.ForeColor = Color.Yellow;
            botun.BackColor = Color.Yellow;
            botun.Name = "botun" + broj_cvorova.ToString();
            botun.Click += new EventHandler(button_Click);
            botuni.Add(botun);
            cvorovi.Add(new Podaci(x, y, karakteristike,true));
            broj_cvorova++;
            prosiri_graf();
        }
        void button_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            int poz = Convert.ToInt32(name.Remove(0, 5));
            string s="";
            for(int i =0;i<cvorovi[poz].podaci.Count;i++)
            {

                s += cvorovi[poz].podaci[i];
                s += "\n";
            }
            if(odabrani_cvor!=-1)
            {
                string str = "";
                for (int i = 0; i < listBox_karakteristike.SelectedItems.Count; i++)
                {

                    str += listBox_karakteristike.SelectedItems[i] as string;
                    str += "\n";
                }
                double polovisteX,polovisteY;
                polovisteX = (cvorovi[odabrani_cvor].x + cvorovi[poz].x) / 2;
                polovisteY = (cvorovi[odabrani_cvor].y + cvorovi[poz].y) / 2;
                double udaljenost = Math.Sqrt(Math.Pow(cvorovi[poz].x - polovisteX, 2) + Math.Pow(cvorovi[poz].y - polovisteY, 2));
                dodaj_udaljenost(odabrani_cvor, poz, udaljenost, udaljenost, str ,false);
                dodaj_liniju(odabrani_cvor, broj_cvorova - 1, str);
                dodaj_liniju( broj_cvorova - 1, poz, str);
                if (checkBox_dvosmjerna.Checked==true)
                {
                    dodaj_liniju(poz, broj_cvorova - 1, str);
                    dodaj_liniju(broj_cvorova - 1, odabrani_cvor, str);
                }
                draw_lines();
                odabrani_cvor = -1;
            }
            if(odabrani_ispisi_liniju!=-1)
            {
                //ispisi karakteristike linije
                double polovisteX, polovisteY;
                polovisteX = (cvorovi[odabrani_ispisi_liniju].x + cvorovi[poz].x) / 2;
                polovisteY = (cvorovi[odabrani_ispisi_liniju].y + cvorovi[poz].y) / 2;
                for(int i =0;i<broj_cvorova;i++)
                {
                    if(cvorovi[i].x== polovisteX && cvorovi[i].y==polovisteY)
                    {
                        s = "";
                        for(int j=0;j<cvorovi[i].podaci.Count;j++)
                        {
                            s += cvorovi[i].podaci[j];
                            s +="\n";
                        }
                        break;
                    }

                }
                odabrani_ispisi_liniju = -1;
            }

            DialogResult result= MessageBox.Show(s , "Detalji", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if(result==DialogResult.Yes)
            {
                odabrani_cvor = poz;
            }
            else if(result==DialogResult.No)
            {
                odabrani_ispisi_liniju = poz;
            }
            else if(result ==DialogResult.Cancel)
            {
                cvorovi[poz].podaci.Clear();
                for(int i =0; i<listBox_karakteristike.SelectedItems.Count;i++)
                {
                    cvorovi[poz].podaci.Add(listBox_karakteristike.SelectedItems[i].ToString());
                }
            }
                  


        }
        void dodaj_udaljenost(int cvor1, int cvor2, double udaljenost1, double udaljenost2, string karakteristike, bool pravi)
        {
            double x3 = 0, y3 = 0;
            char ok = '+';
            koordinate_novog_cvora(cvor1,cvor2,udaljenost1,udaljenost2,ref x3,ref y3,ref ok);
            if (ok == '-')
                return;
            cvorovi.Add(new Podaci(x3, y3, karakteristike, pravi));
            Button botun = new Button();
            botun.Size = new Size(20, 20);
            botun.Visible = false;
            botun.Enabled = false;
            botun.ForeColor = Color.Yellow;
            botun.BackColor = Color.Yellow;
            botun.Name = "botun" + broj_cvorova.ToString();
            botun.Click += new EventHandler(button_Click);
            botuni.Add(botun);
            broj_cvorova++;
            prosiri_graf();
        }
        void dodaj_liniju(int cvor1, int cvor2, string karakteristike)
        {
            if (cvor1 >= broj_cvorova || cvor2 >= broj_cvorova)
                return;//nema tih cvorova
            double duljina = Math.Sqrt(Math.Pow(cvorovi[cvor1].x - cvorovi[cvor2].x, 2) +
                            Math.Pow(cvorovi[cvor1].y - cvorovi[cvor2].y, 2));
            graf_povezanosti[cvor1][cvor2] = duljina;
            graf_sadrzaja[cvor1][cvor2] = karakteristike.Split('\n', ' ', ',').ToList<string>();
        }
        void izracunaj_prozor()
        {
            if (broj_cvorova == 0)
                return;
            visina_max = visina_min = cvorovi[0].y;
            sirina_max = sirina_min = cvorovi[0].x;
            for(int i=1;i<broj_cvorova;i++)
            {
                if (cvorovi[i].y < visina_min)
                    visina_min=cvorovi[i].y;
                if (cvorovi[i].y > visina_max)
                    visina_max = cvorovi[i].y;
                if (cvorovi[i].x < sirina_min)
                    sirina_min = cvorovi[i].x;
                if (cvorovi[i].x > sirina_max)
                    sirina_max = cvorovi[i].x;
            }

        }
        void izracunaj_relativne_pozicije()
        {
            izracunaj_prozor();
            double sirina = sirina_max - sirina_min;
            double visina = visina_max - visina_min;
            for (int i = 0; i < broj_cvorova; i++)
            {
                float pozx, pozy;
                if (sirina > 0 && visina > 0)
                {
                    pozx = 5 + (margin_right - margin_left) * (float)(cvorovi[i].x - sirina_min) / (float)sirina;
                    pozy = 5 + (margin_down - margin_up) * (float)(cvorovi[i].y - visina_min) / (float)visina;
                }
                else if (sirina > 0)
                {
                    pozx = 5 + (margin_right - margin_left) * (float)(cvorovi[i].x - sirina_min) / (float)sirina;
                    pozy = 5 + (margin_down - margin_up) / 2;
                }
                else if (visina > 0)
                {
                    pozx = 5 + (margin_right - margin_left) / 2;
                    pozy = 5 + (margin_down - margin_up) * (float)(cvorovi[i].y - visina_min) / (float)visina;
                }
                else
                {
                    pozx = 5 + (margin_right - margin_left) / 2;
                    pozy = 5 + (margin_down - margin_up) / 2;
                }
                cvorovi[i].rel_x = pozx;
                cvorovi[i].rel_y = pozy;
            }

        }
        void draw_lines()
        {
            izracunaj_relativne_pozicije();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.FromArgb(50,20,20,20),3f);
            SolidBrush brush = new SolidBrush(Color.Blue);
            for (int i = 0; i < broj_cvorova; i++)
            {
                int flag2 = 0;
                if (cvorovi[i].podaci.Count == 1 && cvorovi[i].podaci[0] == "Kraj")
                {
                    PictureBox pbox = new PictureBox();
                    Image q;
                    pbox.Image = Image.FromFile("C:/Users/Goran/source/repos/GoogleMaps/finish.png");
                    q = pbox.Image;
                    pbox.BackgroundImageLayout = ImageLayout.Stretch;
                    pbox.Size = new Size(10, 10);
                    g.DrawImage(pbox.Image, new PointF((float)(cvorovi[i].rel_x - 10f), (float)(cvorovi[i].rel_y - 10f)));
                    flag2 = 1;
                }
                else if(cvorovi[i].podaci.Count == 1 && cvorovi[i].podaci[0] == "Start")
                {
                    PictureBox pbox = new PictureBox();
                    Image q;
                    pbox.Image = Image.FromFile("C:/Users/Goran/source/repos/GoogleMaps/Pocetna.png");
                    q = pbox.Image;
                    pbox.BackgroundImageLayout = ImageLayout.Stretch;
                    pbox.Size = new Size(10, 10);
                    g.DrawImage(pbox.Image,new PointF((float)(cvorovi[i].rel_x - 10f), (float)(cvorovi[i].rel_y - 10f)));
                    flag2 = 1;
                }
                if(flag2==0 && cvorovi[i].isReal)
                {
                    pictureBox.Controls.Add(botuni[i]);
                    botuni[i].Visible = true;
                    botuni[i].Enabled = true;
                    botuni[i].Location = new Point((int)cvorovi[i].rel_x - 7, (int)cvorovi[i].rel_y - 7);
                }              


                for (int j = 0; j < broj_cvorova; j++)
                {
                    if (graf_povezanosti[i][j] != 0)
                    {
                        g.DrawLine(pen, (float)cvorovi[i].rel_x, (float)cvorovi[i].rel_y, (float)cvorovi[j].rel_x, (float)cvorovi[j].rel_y);
                    }
                }
            }
        }
        
        void crtaj_najkraci_put(int start, int kraj)
        {         
            float[] dashValues = { 1,2 };
            Pen pen = new Pen(Color.Blue, 7f);
            pen.DashPattern = dashValues;
            Djikstra dj = new Djikstra(broj_cvorova);
            
            if(dj.djikstraAlgorithm(graf_povezanosti, start, kraj)== false)
            {
                MessageBox.Show("Nema trazenog puta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            for(int i=0;i<dj.path.Count-1;i++)
            {
                shortest_path.DrawLine(pen, (float)cvorovi[dj.path[i]].rel_x, (float)cvorovi[dj.path[i]].rel_y,
                    (float)cvorovi[dj.path[i + 1]].rel_x, (float)cvorovi[dj.path[i + 1]].rel_y);
            }

        }
        public Form1()
        {
            InitializeComponent();
            broj_cvorova = 0;
            visina_max = visina_min = sirina_max = sirina_min = 0;
            graf_povezanosti = new List<List<double>>();
            graf_sadrzaja = new List<List<List<string>>>();
            cvorovi = new List<Podaci>();
            margin_left = pictureBox.Location.X+10;
            margin_right = pictureBox.Location.X + pictureBox.Size.Width-10;
            margin_up = pictureBox.Location.Y+10;
            margin_down = pictureBox.Location.Y+ pictureBox.Size.Height-10;
            g = pictureBox.CreateGraphics();
            shortest_path = pictureBox.CreateGraphics();
            botuni = new List<Button>();
            odabrani_cvor= odabrani_ispisi_liniju = -1;
        }

        private void textbox_dodaj_koordinata_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_dodaj_koordinata_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_dodaj_cvor_Click(object sender, EventArgs e)
        {

        }

        private void button_dodaj_cvor_koordinate_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(textbox_dodaj_koordinata_x.Text);
                Convert.ToDouble(textbox_dodaj_koordinata_y.Text);
            }
            catch
            {
                textbox_dodaj_koordinata_x.Text = "";
                textbox_dodaj_koordinata_y.Text = "";
                return;
            }
            string s = "";
            for (int i = 0; i < listBox_karakteristike.SelectedItems.Count; i++)
            {

                s += listBox_karakteristike.SelectedItems[i] as string;
                s += "\n";
            }
            dodaj_koordinate(Convert.ToDouble(textbox_dodaj_koordinata_x.Text), Convert.ToDouble(textbox_dodaj_koordinata_y.Text),s);
            draw_lines();
            textbox_dodaj_koordinata_x.Text = "";
            textbox_dodaj_koordinata_y.Text = "";
            listBox_karakteristike.ClearSelected();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (radioButton_mojaPoz.Checked == true)
            {
                g.Clear(Color.White);
                int pozx = (e as MouseEventArgs).Location.X;
                int pozy = (e as MouseEventArgs).Location.Y;
                textbox_moja_pozicija_x.Text = pozx.ToString();
                textbox_moja_pozicija_y.Text = pozy.ToString();
                double x, y;
                x = (pozx-5) * (sirina_max - sirina_min) / (margin_right - margin_left) + sirina_min;
                y = (pozy-5) * (visina_max - visina_min) / (margin_down - margin_up) + visina_min;
                dodaj_koordinate(x, y, "Start");
                draw_lines();
                radioButton_mojaPoz.Checked = false;
            }
            else if (radioButton_finalPoz.Checked == true)
            {
                g.Clear(Color.White);
                int pozx = (e as MouseEventArgs).Location.X;
                int pozy = (e as MouseEventArgs).Location.Y;
                textbox_final_pozicija_x.Text = pozx.ToString();
                textbox_final_pozicija_y.Text = pozy.ToString();
                double x, y;
                x = (pozx - 5) * (sirina_max - sirina_min) / (margin_right - margin_left) + sirina_min;
                y = (pozy - 5) * (visina_max - visina_min) / (margin_down - margin_up) + visina_min;
                dodaj_koordinate(x, y, "Kraj");
                draw_lines();
                radioButton_finalPoz.Checked = false;
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            shortest_path.Clear(Color.White);
            graf_povezanosti.Clear();
            graf_sadrzaja.Clear();
            broj_cvorova = 0;
            botuni.Clear();            
            cvorovi.Clear();
            cvor_start = cvor_kraj = odabrani_cvor = -1;
        }

        private void radioButton_mojaPoz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(750 + Size.Width - MinimumSize.Width, 500 + Size.Height - MinimumSize.Height);
            margin_right = pictureBox.Location.X + pictureBox.Size.Width - 10;
            margin_down = pictureBox.Location.Y + pictureBox.Size.Height - 10;
            g = pictureBox.CreateGraphics();
            shortest_path = pictureBox.CreateGraphics();
            draw_lines();
        }

        private void listBox_karakteristike_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_iscrtaj_sve_karakteristike_Click(object sender, EventArgs e)
        {
            button_Clear_Click(sender, e);
            if(listBox_posao.SelectedItems.Count!=0)
            for(int i=0;i<broj_cvorova;i++)
            {
                if (cvorovi[i].podaci.Contains(listBox_posao.SelectedItem.ToString()))
                {
                    //oznaci vrh
                    if (!cvorovi[i].isReal)
                    {
                        SolidBrush brush = new SolidBrush(Color.Red);
                        g.FillEllipse(brush, (float)cvorovi[i].rel_x - 10f, (float)cvorovi[i].rel_y - 10f, 20f, 20f);
                    }
                    else
                    {
                        botuni[i].ForeColor = Color.Red;
                        botuni[i].BackColor = Color.Red;
                    }
                }
            }
            listBox_posao.SelectedItems.Clear();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            shortest_path.Clear(Color.White);
            draw_lines();
            for (int i = 0; i < broj_cvorova; i++)
            {
                botuni[i].ForeColor = Color.Yellow;
                botuni[i].BackColor = Color.Yellow;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)//bottun_dodaj_udaljenosti
        {
            try
            {
                Convert.ToInt32(textbox_dodaj_cvor1.Text);
                Convert.ToInt32(textbox_dodaj_cvor2.Text);
                Convert.ToDouble(textbox_dodaj_udaljenost1.Text);
                Convert.ToDouble(textbox_dodaj_udaljenost2.Text);
            }
            catch
            {
                return;
            }
            string s = "";
            for (int i = 0; i < listBox_karakteristike.SelectedItems.Count; i++)
            {

                s += listBox_karakteristike.SelectedItems[i] as string;
                s += "\n";
            }
            dodaj_udaljenost(Convert.ToInt32(textbox_dodaj_cvor1.Text),Convert.ToInt32(textbox_dodaj_cvor2.Text),Convert.ToDouble(textbox_dodaj_udaljenost1.Text),Convert.ToDouble(textbox_dodaj_udaljenost2.Text),s, true);
            draw_lines();
            textbox_dodaj_cvor1.Text = "";
            textbox_dodaj_cvor2.Text = "";
            textbox_dodaj_udaljenost1.Text = "";
            textbox_dodaj_udaljenost2.Text = "";
            listBox_karakteristike.ClearSelected();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox_dvosmjerna.Checked = true;
            MessageBoxManager.OK = "OK";
            MessageBoxManager.Cancel = "Promijeni";
            MessageBoxManager.Yes = "Spoji cvorove";
            MessageBoxManager.No = "Detalji linije";
            MessageBoxManager.Register();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_putanja_Click(object sender, EventArgs e)
        {
            shortest_path.Clear(Color.White);
            draw_lines();
            double mpozx, mpozy, fpozx, fpozy;
            try
            {
                mpozx = Convert.ToDouble(textbox_moja_pozicija_x.Text);
                mpozy = Convert.ToDouble(textbox_moja_pozicija_y.Text);
                fpozx = Convert.ToDouble(textbox_final_pozicija_x.Text);
                fpozy = Convert.ToDouble(textbox_final_pozicija_y.Text);
            }
            catch
            {
                return;
            }

            if (textbox_moja_pozicija_x.Text.Length != 0 && textbox_moja_pozicija_y.Text.Length != 0 && textbox_final_pozicija_x.Text.Length != 0
                 && textbox_final_pozicija_y.Text.Length != 0 && listBox_posao.SelectedItems.Count == 0)
            {
                double mx, my, fx, fy;
                mx = (mpozx - 5) * (sirina_max - sirina_min) / (margin_right - margin_left) + sirina_min;
                my = (mpozy - 5) * (visina_max - visina_min) / (margin_down - margin_up) + visina_min;
                fx = (fpozx - 5) * (sirina_max - sirina_min) / (margin_right - margin_left) + sirina_min;
                fy = (fpozy - 5) * (visina_max - visina_min) / (margin_down - margin_up) + visina_min;
                dodaj_koordinate(mx, my, "Start");
                dodaj_koordinate(fx, fy, "Kraj");
                crtaj_najkraci_put(cvor_start, cvor_kraj);
            }

            else if (listBox_posao.SelectedItems.Count > 0)
            {
                string posao = listBox_posao.SelectedItem.ToString();
                Djikstra dj = new Djikstra(broj_cvorova);
                dj.djikstraAlgorithm(graf_povezanosti, cvor_start, cvor_kraj);
                int minIndex = -1;
                double minValue = double.MaxValue;
                for (int i = 0; i < broj_cvorova; i++)
                {
                    if(cvorovi[i].podaci.Contains(posao) == true && dj.path.Contains(i))
                    {
                        minIndex = i;
                        break;
                    }
                    if (cvorovi[i].podaci.Contains(posao) == true && dj.dist[i] < minValue)
                    {
                        minValue = dj.dist[i];
                        minIndex = i;
                    }
                }
                if (minIndex == -1)
                {
                    MessageBox.Show("Nema trazenog posla u blizini.\nPrikazujemo put do odredista", "Info", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    crtaj_najkraci_put(cvor_start, cvor_kraj);
                }
                else
                {
                    crtaj_najkraci_put(cvor_start, minIndex);
                    crtaj_najkraci_put(minIndex, cvor_kraj);
                    SolidBrush brush = new SolidBrush(Color.Red);
                    g.FillEllipse(brush, (float)cvorovi[minIndex].rel_x - 10f, (float)cvorovi[minIndex].rel_y - 10f, 20f, 20f);
                }
            }
            listBox_posao.SelectedItems.Clear();
        }
        void inicijalni_grad()
        {
            dodaj_koordinate(1, 1, "Benzinska Trgovina");//0
            dodaj_koordinate(3, 2, "Tisak Trg Banka Posta");//1
            dodaj_koordinate(5, 2, "Skola");//2
            dodaj_koordinate(4, 1, "Fakultet");//3
            dodaj_koordinate(6, 1, "Dvorana");//4
            dodaj_koordinate(5, 4, "Trg");//5
            dodaj_koordinate(2, 4, "Banka Posta");//6
            dodaj_koordinate(4, 5, "Trg Trgovina");//7
            dodaj_koordinate(6, 5, "Kuca");//8
            dodaj_liniju(0, 1, "");
            dodaj_liniju(1, 0, "");
            dodaj_liniju(1, 2, "");
            dodaj_liniju(2, 3, "Trgovina");
            dodaj_liniju(3, 1, "Fakultet");
            dodaj_liniju(3, 4, "");
            dodaj_liniju(4, 3, "");
            dodaj_liniju(4, 5, "Kolodvor Tisak"); 
            dodaj_liniju(5, 4, "Kolodvor Tisak");
            dodaj_liniju(5, 6, "Benzinska");
            dodaj_liniju(6, 5, "Benzinska");
            dodaj_liniju(7, 6, "Faks");
            dodaj_liniju(6, 7, "Trg Trgovina");


        }
    }
    public class Podaci
    {
        //koordinate
        public double x;
        public double y;
        public double rel_x,rel_y;
        public List<string> podaci;
        public bool isReal;
        public Podaci(double a, double b, string s, bool pravi)
        {
            x = a;
            y = b;
            podaci = new List<string>();
            podaci = s.Split('\n', ' ', ',').ToList<string>();
            rel_x = rel_y = 0;
            isReal = pravi;
        }
    }
}
