using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace ZPLSend
{
    public partial class Form1 : Form
    {
        string yy, mm, dd, ww, yyyy;
        string icEtiket_eu_asya, disEtiket_eu_asya;

        string IP, ID, DocNo, VerNo, W, H;
        string[] bolum;
        int k = 12;
        int int_w, int_h;
        int a, b;
        public Form1()
        {
            InitializeComponent();
            textBox6.Text = "163";
            textBox7.Text = "186";
            textBox5.Text = "10.90.21.172";
             
        }

        public void date()
        {
            DateTime now = DateTime.Now;
            CultureInfo ci = CultureInfo.CurrentCulture;
            int weekNumber = ci.Calendar.GetWeekOfYear(now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            yy = now.ToString("yy");
            mm = now.ToString("MM");
            dd = now.ToString("dd");
            yyyy = now.ToString("yyyy");
            ww = weekNumber.ToString("D2");

        }
        private void button1_Click(object sender, EventArgs e)//SEND Button
        {

            string ip_adress = textBox5.Text;
            string text = richTextBox1.Text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        }
        private void button2_Click(object sender, EventArgs e)//LP4777 - Portrait
        {
            date();
            string ip_adress = "10.90.21.172";
            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1080,1200^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1110,1450^A@I,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1085,235^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)40517949221119^FS" +
                "^FO1230,200^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO1115,165^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT1850,120^BXI,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/40517949221119?13=" + yy + mm + dd + "^FS^XZ";
            richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        }
        private void button3_Click(object sender, EventArgs e)//LP4778 - Landspace
        {
            date();
            string ip_adress = "10.90.21.172";

            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1620,800^A@N,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1860,750^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO720,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)50517944221119^FS" +
                "^FO685,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO650,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT610,40^BXR,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/50517944221119?13=" + yy + mm + dd + "^FS^XZ";
            richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        }
        private void button4_Click(object sender, EventArgs e)//LP4781 - Landspace
        {
            date();
            string ip_adress = "10.90.21.172";
            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1620,800^A@N,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1860,750^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO720,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)00517946221119^FS" +
                "^FO685,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO650,495^A@R,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT610,40^BXR,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/00517946221119?13=" + yy + mm + dd + "^FS^XZ";
            richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        } 
        private void button5_Click(object sender, EventArgs e)//LP4780 - Portrait
        {
            date();
            string ip_adress = "10.90.21.172";
            string text = "^XA" +
                "^PW2000" +
                "^LL2200" +
                "^FO1080,1200^A@R,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1110,1450^A@I,28,28,E:NotoSans-Bold.TTF" +
                "^FD" + yy + ww + "^FS" +
                "^FO1085,235^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(240)80517947221119^FS" +
                "^FO1230,200^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FDAl(13)" + yy + mm + dd + "^FS" +
                "^FO1115,165^A@I,29,29,E:NotoSans-Regular.TTF" +
                "^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS" +
                "^FT1850,120^BXI,9,200,48,16" +
                "^FDhttps://www.goto.ikea.com/240/80517947221119?13=" + yy + mm + dd + "^FS^XZ";
            richTextBox1.Text = text;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ip_adress, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(text);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        }
         
        private void button7_Click(object sender, EventArgs e)//Dış Etiket Oluştur
        {
            
            IP = textBox5.Text;
            ID = textBox2.Text;
            DocNo = textBox3.Text;
            VerNo = textBox4.Text;
            bolum = ID.Split('.');
            W = textBox6.Text;
            H = textBox7.Text;
            int_w = Convert.ToInt32(W) * k;
            int_h = Convert.ToInt32(H) * k;
            //label11.Text = bolum[0] +  bolum[1] + bolum[2];
            date();
            string ip_adress = textBox5.Text;

            if (radioButton1.Checked)//Avrupa
            {
                disEtiket_eu_asya = "^XA\r\n" +
                "^FX Boyutlar\r\n" +
                "^PW" + int_w + "^LL" + int_h + "\r\n" +
                "^FX Interleaved 2 of 5 Barcode\r\n" +
                "^BY3.6,4,110^FT550,25^B2R,,N,N^FD" + bolum[0] + bolum[1] + bolum[2] + "221119^FS\r\n" +
                "^FX Siyah arka plan oluşturuluyor.\r\n" +
                "^FO475,25^GB60,295,65^FS\r\n" +
                "^FX Beyaz yazıyı göstermek için ters yazı (FR) ekleniyor.\r\n" +
                "^FO478,35^FR^A0R,45,60,E:NotoSans-Bold.TTF^FD" + bolum[0] + "." + bolum[1] + "." + bolum[2] + "^FS\r\n" +
                "^FX IKEA müsteri numarası\r\n" +
                "^CF0,20^FO515,330^A0R,22,22,E:NotoSans-Bold.TTF^FD22111^FS\r\n" +
                "^FO435,170^A@R,22,22,E:NotoSans-Regular.TTF^FDAl(240)" + bolum[0] + bolum[1] + bolum[2] + "221119^FS\r\n" +
                "^FO410,170^A@R,22,22,E:NotoSans-Regular.TTF^FDAl(13)" + yy + mm + dd + "^FS\r\n" +
                "^FO385,170^A@R,22,22,E:NotoSans-Regular.TTF^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS\r\n" +
                "^FO360,170^A@R,22,22,E:NotoSans-Regular.TTF^FDPI-" + DocNo + "-" + VerNo + "^FS\r\n" +
                "^CI28\r\n" +
                "^FO335,170^A@R,22,22,E:NotoSans-Regular.TTF^FD © Inter IKEA Systems B.V. 2021^FS\r\n" +
                "^FO305,25^A@R,21,21,E:NotoSans-Bold.TTF^FDMade in Turkey^FS\r\n" +
                "^FX DataMatrix\r\n" +
                "^BY156,156^FT335,25^BXR,5,200 ^FDhttps://www.goto.ikea.com/240/" + bolum[0] + bolum[1] + bolum[2] + "221119?13=" + yy + mm + dd + "^FS\r\n" +
                "^FX DataStamp\r\n" +
                "^FO430,570^A@N,32,32,E:NotoSans-Bold.TTF^FD" + yy + ww + "^FS\r\n" +

                "^XZ";
            }
            else if (radioButton2.Checked)//Asya
            {
                disEtiket_eu_asya = "^XA\r\n" +
                "^FX Boyutlar\r\n" +
                "^PW" + int_w + "^LL" + int_h + "\r\n" +
                "^FX Interleaved 2 of 5 Barcode\r\n" +
                "^BY3.6,4,110^FT550,25^B2R,,N,N^FD" + bolum[0] + bolum[1] + bolum[2] + "221119^FS\r\n\r\n" +
                "^FX Siyah arka plan oluşturuluyor.\r\n" +
                "^FO475,25^GB60,295,65^FS\r\n\r\n" +
                "^FX Beyaz yazıyı göstermek için ters yazı (FR) ekleniyor.\r\n" +
                "^FO478,35^FR^A0R,45,60,E:NotoSans-Bold.TTF^FD" + bolum[0] + "." + bolum[1] + "." + bolum[2] + "^FS\r\n\r\n" +
                "^FX IKEA müsteri numarası\r\n" +
                "^CF0,20^FO515,330^A0R,22,22,E:NotoSans-Bold.TTF^FD22111^FS\r\n\r\n" +
                "^FO435,170^A@R,22,22,E:NotoSans-Regular.TTF^FDAl(240)" + bolum[0] + bolum[1] + bolum[2] + "221119^FS\r\n\r\n" +
                "^FO410,170^A@R,22,22,E:NotoSans-Regular.TTF^FDAl(13)" + yy + mm + dd + "^FS\r\n\r\n" +
                "^FO385,170^A@R,22,22,E:NotoSans-Regular.TTF^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS\r\n\r\n" +
                "^FO360,170^A@R,22,22,E:NotoSans-Regular.TTF^FDPI-" + DocNo + "-" + VerNo + "^FS\r\n\r\n" +
                "^CI28\r\n" +
                "^FO335,170^A@R,22,22,E:NotoSans-Regular.TTF^FD © Inter IKEA Systems B.V. 2021^FS\r\n" +
                "^FO305,25^A@R,21,21,E:NotoSans-Bold.TTF^FDMade in Turkey^FS\r\n" +
                "^FX DataMatrix\r\n" +
                "^BY156,156^FT335,25^BXR,5,200 ^FDhttps://www.goto.ikea.com/240/" + bolum[0] + bolum[1] + bolum[2] + "221119?13=" + yy + mm + dd + "^FS\r\n\r\n" +
                "^FX DataStamp\r\n" +
                "^FO430,570^A@N,32,32,E:NotoSans-Bold.TTF^FD" + yy + ww + "^FS\r\n" +
                "^FX 8 digits Date for ASIA labels\r\n" +
                "^FO300,650^A@N,32,32,E:NotoSans-Bold.TTF^FD" + yyyy + "-" + mm + "-" + dd + "^FS\r\n" +
                "^XZ"; ;
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Lütfen bölge seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            richTextBox1.Text = disEtiket_eu_asya;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(IP, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(disEtiket_eu_asya);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }

        }

        private void button8_Click_1(object sender, EventArgs e) //İç etiket Oluştur
        {
            
            IP = textBox5.Text;
            ID = textBox2.Text;
            DocNo = textBox3.Text;
            VerNo = textBox4.Text;
            bolum = ID.Split('.');
            W = textBox6.Text;
            H = textBox7.Text;
            int_w = Convert.ToInt32(W) * k;
            int_h = Convert.ToInt32(H) * k;
            //label11.Text = bolum[0] +  bolum[1] + bolum[2];
            date();
            string ip_adress = textBox5.Text;

            if (radioButton1.Checked && checkBox1.Checked==false)//Avrupa
            {
                icEtiket_eu_asya = "^XA \r\n\r\n " +
                "^FX Boyutlar\r\n" +
                "^PW" + int_w + "^LL" + int_h + "\r\n" +
                "^FO1080,1750^A@R,28,28,E:NotoSans-Bold.TTF^FD" + yy + ww + "^FS\r\n\r\n" +
                "^FO1085,785^A@I,29,29,E:NotoSans-Regular.TTF^FDAl(240)" + bolum[0] + bolum[1] + bolum[2] + "221119^FS\r\n\r\n" +
                "^FO1230,750^A@I,29,29,E:NotoSans-Regular.TTF^FDAl(13)" + yy + mm + dd + "^FS\r\n\r\n" +
                "^FO1115,715^A@I,29,29,E:NotoSans-Regular.TTF^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS\r\n\r\n" +
                "^FT1850,670^BXI,9,200,48,16^FDhttps://www.goto.ikea.com/240/" + bolum[0] + bolum[1] + bolum[2] + "221119?13=" + yy + mm + dd + "^FS^XZ";
            }
            else if (radioButton2.Checked && checkBox1.Checked == false)//Asya
            {
                icEtiket_eu_asya = "^XA\r\n\r\n" +
               "^FX Boyutlar\r\n" +
               "^PW" + int_w + "^LL" + int_h + "\r\n" +
               "^FO1080,1750^A@R,28,28,E:NotoSans-Bold.TTF^FD" + yy + ww + "^FS\r\n\r\n" +
               "^FO1085,785^A@I,29,29,E:NotoSans-Regular.TTF^FDAl(240)" + bolum[0] + bolum[1] + bolum[2] + "221119\r\n^FS\r\n\r\n" +
               "^FO1230,750^A@I,29,29,E:NotoSans-Regular.TTF^FDAl(13)" + yy + mm + dd + "^FS\r\n\r\n" +
               "^FO1115,715^A@I,29,29,E:NotoSans-Regular.TTF^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS\r\n\r\n" +
               "^FX 8 digits Date for ASIA labels\r\n" +
               "^FO1030,650^A@I,28,28,E:NotoSans-Bold.TTF^FD" + yyyy + "-" + mm + "-" + dd + "^FS\r\n" +
               "^FT1850,670^BXI,9,200,48,16^FDhttps://www.goto.ikea.com/240/" + bolum[0] + bolum[1] + bolum[2] + "221119?13=" + yy + mm + dd + "^FS^XZ";
            }
            else if (radioButton1.Checked && checkBox1.Checked)//Avrupa ve 90 derece sola döndür
            {
                icEtiket_eu_asya = "^XA" +
              "^PW" + int_w + "^LL" + int_h + "\r\n\r\n\r\n" +
              "^FO1620,800^A@N,28,28,E:NotoSans-Bold.TTF ^FD" + yy + ww + "^FS\r\n\r\n" +
              "^FO720,495^A@R,29,29,E:NotoSans-Regular.TTF^FDAl(240)" + bolum[0] + bolum[1] + bolum[2] + "221119^FS\r\n\r\n" +
              "^FO685,495^A@R,29,29,E:NotoSans-Regular.TTF^FDAl(13)" + yy + mm + dd + "^FS\r\n\r\n" +
              "^FO650,495^A@R,29,29,E:NotoSans-Regular.TTF ^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS\r\n\r\n" +
              "^FT610,40^BXR,9,200,48,16 ^FDhttps://www.goto.ikea.com/240/" + bolum[0] + bolum[1] + bolum[2] + "221119?13=" + yy + mm + dd + "^FS\r\n\r\n^XZ";
            }
            else if (radioButton2.Checked && checkBox1.Checked)//Asya ve 90 derece sola döndür
            {
                icEtiket_eu_asya = "^XA" +
              "^PW" + int_w + "^LL" + int_h + "\r\n\r\n" +
              "^FO1620,800^A@N,28,28,E:NotoSans-Bold.TTF ^FD" + yy + ww + "^FS\r\n\r\n" +
              "^FO720,495^A@R,29,29,E:NotoSans-Regular.TTF^FDAl(240)" + bolum[0] + bolum[1] + bolum[2] + "221119^FS\r\n\r\n" +
              "^FO685,495^A@R,29,29,E:NotoSans-Regular.TTF^FDAl(13)" + yy + mm + dd + "^FS\r\n\r\n" +
              "^FO650,495^A@R,29,29,E:NotoSans-Regular.TTF ^FD" + yy + "-" + mm + "-" + dd + " (YY-MM-DD)^FS\r\n\r\n" +
              "^FX 8 digits Date for ASIA labels\r\n" +
              "^FO530,700^A@R,28,28,E:NotoSans-Bold.TTF^FD" + yyyy + "-" + mm + "-" + dd + "^FS\r\n\r\n" +
              "^FT610,40^BXR,9,200,48,16 ^FDhttps://www.goto.ikea.com/240/" + bolum[0] + bolum[1] + bolum[2] + "221119?13=" + yy + mm + dd + "^FS\r\n\r\n^XZ";
            }


            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Lütfen bölge seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            richTextBox1.Text = icEtiket_eu_asya;
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(IP, 9100);
                StreamWriter streamWriter = new StreamWriter((Stream)tcpClient.GetStream());
                streamWriter.Write(icEtiket_eu_asya);
                streamWriter.Flush();
                streamWriter.Close();
                tcpClient.Close();

                //job_Control.Text = "Evolabel Printera Job gönderildi .";
            }
            catch (Exception ex)
            {
                //job_Control.Text = "ZPL Code Giriniz ! " + ex.Message;
            }
        }



    }
}
