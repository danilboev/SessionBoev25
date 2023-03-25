using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "boevExDataSet1.TransportB". При необходимости она может быть перемещена или удалена.
            this.transportBTableAdapter1.Fill(this.boevExDataSet1.TransportB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "boevExDataSet.TransportB". При необходимости она может быть перемещена или удалена.
            this.transportBTableAdapter.Fill(this.boevExDataSet.TransportB);

        }
    }
}
