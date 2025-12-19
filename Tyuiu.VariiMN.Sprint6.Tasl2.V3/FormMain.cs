using System;
using System.Windows.Forms;
using Tyuiu.VariiMN.Sprint6.Task2.V3.Lib;


namespace Tyuiu.VariiMN.Sprint6.Tasl2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_DDE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = int.Parse(textBoxStart_DDE.Text);
                int stopValue = int.Parse(textBoxStop_DDE.Text);

                double[] values = ds.GetMassFunction(startValue, stopValue);

                dataGridViewResult_DDE.Rows.Clear();

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    dataGridViewResult_DDE.Rows.Add(x, values[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Îøèáêà ââîäà äàííûõ!");
            }
        }

        private void buttonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 2 âûïîëíèë ñòóäåíò ãðóïïû ÈÑÏá-25-1 Äàöêèé Äåíèñ Åâãåíüåâè÷");
        }
    }
}
