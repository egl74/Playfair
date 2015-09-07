using System.Windows.Forms;

namespace zir1
{
    public partial class Form2 : Form
    {
        public Form2(char[,] chars)
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            for (var i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add(chars[i, 0], chars[i, 1], chars[i, 2], chars[i, 3], chars[i, 4]);
            }
        }
    }
}
