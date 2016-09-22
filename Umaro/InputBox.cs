using System;
using System.Windows.Forms;

namespace Umaro
{
    public partial class InputBox : Form
    {
        private static readonly InputBox _instance = new InputBox();
        private string returnString;

        //Input validation
        private Func<string, bool> validatorFunc;
        private string errorMessage;
        private bool isValidated;

        public InputBox()
        {
            InitializeComponent();
        }

        public static string Show(string inputBoxText)
        {
            _instance.lblMain.Text = inputBoxText;
            _instance.ShowDialog();
            _instance.txtMain.Text = "";
            _instance.txtMain.Focus();
            _instance.txtMain.CausesValidation = false;
            _instance.isValidated = true;
            return _instance.returnString;
        }

        public static string Show(string inputBoxText, Func<string, bool> validator, string errorMsg)
        {
            _instance.lblMain.Text = inputBoxText;
            _instance.validatorFunc = validator;
            _instance.errorMessage = errorMsg;
            _instance.ShowDialog();
            _instance.txtMain.Text = "";
            _instance.txtMain.Focus();
            _instance.txtMain.CausesValidation = true;

            return _instance.returnString;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!isValidated)
                return;

            returnString = txtMain.Text;
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!isValidated)
                return;

            returnString = string.Empty;
            Hide();
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            isValidated = validatorFunc(txtMain.Text);

            if (isValidated)
                errProvider.Clear();
            else
            {
                e.Cancel = true;
                errProvider.SetError(txtMain, errorMessage);
            }
        }
    }
}
