using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leds
{
    public partial class Form1 : Form
    {
        private Leds Luz;
        public Form1()
        {
            InitializeComponent();
            Luz = new Leds();
            tbx_IndicarValor.Text = Luz.Getdados().ToString();
            Atualizainterface();
        }

        private void Atualizainterface()
        {
            tbx_IndicarValor.Text = Luz.Getdados().ToString();
            tbx_dado_2.Text = Convert.ToString(Luz.Getdados(), 2);
            ckb_led1.Checked = Luz.Getled(1);
            ckb_led2.Checked = Luz.Getled(2);
            ckb_led3.Checked = Luz.Getled(3);
            ckb_led4.Checked = Luz.Getled(4);
            ckb_led5.Checked = Luz.Getled(5);
            ckb_led6.Checked = Luz.Getled(6);
            ckb_led7.Checked = Luz.Getled(7);
            ckb_led8.Checked = Luz.Getled(8);
        }

            private void btn_on_1_Click(object sender, EventArgs e)
        {
            Luz.Acender(1);
            Atualizainterface();
        }

        private void btn_off_1_Click(object sender, EventArgs e)
        {
            Luz.Apagar(1);
            Atualizainterface();
        }

        private void btn_on_2_Click(object sender, EventArgs e)
        {
            Luz.Acender(2);
            Atualizainterface();
        }

        private void btn_off_2_Click(object sender, EventArgs e)
        {
            Luz.Apagar(2);
            Atualizainterface();
        }

        private void btn_on_3_Click(object sender, EventArgs e)
        {
            Luz.Acender(3);
            Atualizainterface();
        }

        private void btn_off_3_Click(object sender, EventArgs e)
        {
            Luz.Apagar(3);
            Atualizainterface();
        }

        private void btn_on_4_Click(object sender, EventArgs e)
        {
            Luz.Acender(4);
            Atualizainterface();
        }

        private void btn_off_4_Click(object sender, EventArgs e)
        {
            Luz.Apagar(4);
            Atualizainterface();
        }

        private void btn_on_5_Click(object sender, EventArgs e)
        {
            Luz.Acender(5);
            Atualizainterface();
        }

        private void btn_off_5_Click(object sender, EventArgs e)
        {
            Luz.Apagar(5);
            Atualizainterface();
        }

        private void btn_on_6_Click(object sender, EventArgs e)
        {
            Luz.Acender(6);
            Atualizainterface();
        }

        private void btn_off_6_Click(object sender, EventArgs e)
        {
            Luz.Apagar(6);
            Atualizainterface();
        }

        private void btn_on_7_Click(object sender, EventArgs e)
        {
            Luz.Acender(7);
            Atualizainterface();
        }

        private void btn_off_7_Click(object sender, EventArgs e)
        {
            Luz.Apagar(7);
            Atualizainterface();
        }

        private void btn_on_8_Click(object sender, EventArgs e)
        {
            Luz.Acender(8);
            Atualizainterface();
        }

        private void btn_off_8_Click(object sender, EventArgs e)
        {
            Luz.Apagar(8);
            Atualizainterface();
        }
    }
}
