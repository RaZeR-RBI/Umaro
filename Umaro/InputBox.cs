using System;
using System.Windows.Forms;

namespace Umaro
{
    public partial class InputBox : Form
    {
        // the InputBox
        private static InputBox newInputBox;
        // строка, которая будет возвращена форме запроса
        private static string returnString;

        public InputBox()
        {
            InitializeComponent();
        }

        public static string Show(string inputBoxText)
        {
            newInputBox = new InputBox { label1 = { Text = inputBoxText } };
            newInputBox.ShowDialog();
            newInputBox.textBox1.Focus();
            return returnString;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            returnString = textBox1.Text;
            newInputBox.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            returnString = string.Empty;
            newInputBox.Dispose();
        }
    }
}
