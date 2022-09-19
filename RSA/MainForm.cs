using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class MainForm : Form
    {
        public byte[] byteData;
        public ushort[] ushortData;
        public int p;
        public int q;
        public int n;
        public int Ko;
        public int Kp;
        enum LastAction { actEncrypt, actDecrypt, actNone, byteOpen, ushortOpen };
        LastAction lastAction = LastAction.actNone;

        public MainForm()
        {
            InitializeComponent();
        }

        private void bDecrypt_Click(object sender, EventArgs e)
        {
            if (ushortData == null || lastAction!=LastAction.ushortOpen)
            {
                MessageBox.Show("Зашифрованный файл не открыт");
                return;
            }

            if (!ValDecryptInput())
                return;

            byteData = RSA.Decrypt(ushortData, Kp, n);

            string strOut = "";
            foreach (byte b in byteData)
            {
                strOut += Convert.ToString(b) + " ";
            }

            tbOutput.Text = strOut;
            lastAction = LastAction.actDecrypt;



        }

        private bool ValDecryptInput()
        {
            try
            {
                n = Convert.ToInt32(tbRValue.Text);
                
                if (n < 255)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Параметр 'r' должен иметь целочисленное значение большее 255");
                return false;
            }

            try
            {
                Kp = Convert.ToInt32(tbPrivateKey.Text);
                if (Kp < 2)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Параметр 'Kp' должен иметь целочисленное значение большее 1");
                return false;
            }

            return true;
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            if (dOpen.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = dOpen.FileName;
            string fileStr = "";
            if (cbEncrypted.Checked)
            {
                ushortData = FileProc.ReadFileByShort(filename);

                foreach (ushort us in ushortData)
                {
                    fileStr += Convert.ToString(us) + " ";
                }

                lastAction = LastAction.ushortOpen;
            }
            else
            {
                byteData = FileProc.ReadFileByByte(filename);

                foreach (byte b in byteData)
                {
                    fileStr += Convert.ToString(b) + " ";
                }

                lastAction = LastAction.byteOpen;
            }
            
            tbInput.Text = fileStr;

        }

        private bool ValEncryptInput()
        {
            try
            {
                p = Convert.ToInt32(tbPValue.Text);

                if (p<1)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Параметр 'p' должен иметь целочисленное значение большее 0");
                return false;
            }

            try
            {
                q = Convert.ToInt32(tbQValue.Text);

                if (q<1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Параметр 'q' должен иметь целочисленное значение большее 0");
                return false;
            }

            if (!RSA.IsPrime(p, 20))
            {
                MessageBox.Show("Параметр 'p' должен быть простым числом");
                return false;
            }

            if (!RSA.IsPrime(q, 20))
            {
                MessageBox.Show("Параметр 'q' должен быть простым числом");
                return false;
            }

            if (p*q <  256 || p*q > 65536)
            {
                MessageBox.Show("Произведение p*q должно удовлетворять условию 255<p*q<65537");
                return false;
            }

            try
            {
                Kp = Convert.ToInt32(tbPrivateKey.Text);

                int f = (p - 1) * (q - 1);
                int x1 = 1;
                int y1 = 1;

                if (Kp<2)
                {
                    throw new Exception();
                }
                if (Kp>f-1)
                {
                    throw new Exception();
                }
                if (RSA.GcdExtended(Kp, f, ref x1, ref y1) != 1)
                {
                    throw new Exception();
                }
                
            }
            catch
            {
                MessageBox.Show("Kp должно удовлетворять условиям: 1<Kp<f(r) и (Kp,f(r))==1, где r=p*q, a f(r) - функция Эйлера");
                return false;
            }

            return true;


        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            if (byteData == null || lastAction!=LastAction.byteOpen)
            {
                MessageBox.Show("Исходный файл не открыт или открыт зашифрованный файл");
                return;
            }

            if (!ValEncryptInput())
                return;


            

            (Ko, n, Kp) = RSA.GenerateKey(p, q, Kp);

            tbRValue.Text = Convert.ToString(n);
            tbOpenKey.Text = Convert.ToString(Ko);
            tbPrivateKey.Text = Convert.ToString(Kp);


            ushortData = RSA.Encrypt(byteData, Ko, n);

            string outStr = "";
            foreach (ushort us in ushortData)
            {
                outStr += Convert.ToString(us) + " ";
            }

            tbOutput.Text = outStr;
            lastAction = LastAction.actEncrypt;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!(lastAction == LastAction.actEncrypt || lastAction == LastAction.actDecrypt))
            {
                MessageBox.Show("Нечего сохранять");
                return;
            }
            
            if (dSave.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = dSave.FileName;

           
            if (lastAction == LastAction.actDecrypt)
            {
                FileProc.WriteFileByByte(filename, byteData);
                return;
            }

            if (lastAction == LastAction.actEncrypt)
            {
                FileProc.WriteFileByInt16(filename, ushortData);
                return;
            }
        }
    }
}
