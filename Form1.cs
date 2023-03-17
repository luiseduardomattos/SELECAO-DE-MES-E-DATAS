using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SELECAO_DE_MES_E_DATAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionarData_Click(object sender, EventArgs e)
        {
            txtBox1Inicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txtBox2Final.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            txtBox3Atual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBox1Inicial.Clear();
            txtBox2Final.Clear();
            txtBox3Atual.Clear();
        }
    }
}
