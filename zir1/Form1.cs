using System;
using System.Windows.Forms;

namespace zir1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Playfair.Initialize();
        }

        private void showTable_Click(object sender, EventArgs e)
        {
            var table = Playfair.SetPlayfairTable(keyField.Text);
            if (table[0, 0] == 0)
                MessageBox.Show("Empty key");
            var form2 = new Form2(table);
            form2.Show();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            outputField.Text = Playfair.Encrypt(inputField.Text, keyField.Text);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            outputField.Text = Playfair.Decrypt(inputField.Text, keyField.Text);
        }
    }
}
