using Lab1OopApplication.Source;
using System;
using System.Windows.Forms;

namespace Lab1OopApplication
{
    public partial class ResultForm : Form
    {
        private MainForm mainForm;

        public ResultForm(string result, MathOperationsEnum oper)
        {
            InitializeComponent();
            ShowResult(result, oper);
        }

        public ResultForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            ShowResult(mainForm.Result.ToString(), mainForm.LastOper);
        }

        public ResultForm()
        {
            InitializeComponent();
        }

        public void ShowResult(string result, MathOperationsEnum oper)
        {
            string operName = "";

            switch (oper)
            {
                case MathOperationsEnum.Sum:
                    operName = "сложения";
                    break;
                case MathOperationsEnum.Subtract:
                    operName = "вычитания";
                    break;
                case MathOperationsEnum.Extent:
                    operName = "возведения в степень";
                    break;
                case MathOperationsEnum.Compare:
                    operName = "сравнения";
                    break;
                default:
                    break;
            }

            ResultLabel.Text = $"Pезультат {operName}: {result}";
        }

        public void AddOperForCounter()
        {
            var form = Owner as MainForm;
            if (form is null)
                return;
            form.Counter++;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
