using Tyuiu.VariiMN.Sprint6.Task3.V2.Lib;

namespace Tyuiu.VariiMN.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
            { 9, 13, -14, 23, 1 },
            { 15, -17, 21, 25, 23 },
            { -4, 29, -20, -10, 14 },
            { 27, 33, 12, 33, -12 },
            { 18, -9, 5, 6, 3 }
        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewResult_DDE.RowCount = 5;
            dataGridViewResult_DDE.ColumnCount = 5;
            dataGridViewResult_DDE.ColumnHeadersVisible = false;
            dataGridViewResult_DDE.RowHeadersVisible = false;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_DDE.Columns[i].Width = 50;
                dataGridViewResult_DDE.Rows[i].Height = 30;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewResult_DDE.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void buttonHelp_DDE_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp_DDE.BackColor = Color.LightBlue;
        }

        private void buttonHelp_DDE_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_DDE.BackColor = SystemColors.Control;
        }

        private void buttonCalculate_DDE_MouseEnter(object sender, EventArgs e)
        {
            buttonCalculate_DDE.BackColor = Color.LightGreen;
        }

        private void buttonCalculate_DDE_MouseLeave(object sender, EventArgs e)
        {
            buttonCalculate_DDE.BackColor = SystemColors.Control;
        }

        private void buttonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 3 âûïîëíèë ñòóäåíò ãðóïïû ÈÑÏá-25-1 Äàöêèé Ä.Å.", "Ñïðàâêà", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCalculate_DDE_Click(object sender, EventArgs e)
        {
            try
            {
                // Âûçîâ ìåòîäà ñîðòèðîâêè
                int[,] resultMatrix = ds.Calculate(matrix);

                // Âûâîä ðåçóëüòàòà
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult_DDE.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }

                textBoxResult_DDE.Text = "Ñîðòèðîâêà âûïîëíåíà óñïåøíî!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Îøèáêà: " + ex.Message, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}