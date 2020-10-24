using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssc_lab3_tema
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBox.Text);
            byte[] mac = mh.ComputeMAC(myConverter.StringToByteArray(textBoxPlain.Text),
                myConverter.StringToByteArray(textBoxKey.Text));

            textBoxMAC.Text = myConverter.ByteArrayToString(mac);
            textBoxMACHEX.Text = myConverter.ByteArrayToHexString(mac);

            byte[] hash = mh.ComputeHASH(myConverter.StringToByteArray(textBoxPlain.Text),
                myConverter.StringToByteArray(textBoxKey.Text));

            textBoxHash.Text = myConverter.ByteArrayToString(hash);
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBox.Text);

            if(mh.CheckAuthenticity(myConverter.StringToByteArray(textBoxPlain.Text),
                myConverter.HexStringToByteArray(textBoxMACHEX.Text),
                myConverter.StringToByteArray(textBoxKey.Text)) == true)
            {
                System.Windows.Forms.MessageBox.Show("MAC OK!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("MAC NOT OK!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
