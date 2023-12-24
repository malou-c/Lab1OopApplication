using Lab1OopApplication.Source;
using System;
using System.Windows.Forms;

namespace Lab1OopApplication
{
    public partial class MainForm : Form
    {
        private int counter;
        public int Counter 
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
                CounterTextBox.Text = counter.ToString();
            }
        }

        public double Result { get; private set; }

        public MathOperationsEnum LastOper { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            Counter = 0;
        }

        private void OperButton_Click(object sender, EventArgs e)
        {

            var operButton = sender as Button;
            if (operButton is null)
                return;

            // Проверка, что введены числа
            if (!double.TryParse(InputFirstNumberTextBox.Text, out double firstOperand) ||
                !double.TryParse(InputSecondNumberTextBox.Text, out double secondOperand))
            {
                MessageBox.Show("Введите корректные числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResultForm resultForm;
            double result;

            switch ((string)operButton.Tag)
            {
                case "+":
                    result = MathOperations.Sum(firstOperand, secondOperand);
                    resultForm = new ResultForm(result.ToString(), MathOperationsEnum.Sum);
                    resultForm.ShowDialog();
                    Counter++;
                    break;
                case "-":
                    Result = MathOperations.Subtract(firstOperand, secondOperand);
                    LastOper = MathOperationsEnum.Subtract;
                    resultForm = new ResultForm(this);
                    resultForm.ShowDialog();
                    Counter++;
                    break;
                case "^":
                    Result = MathOperations.Extent(firstOperand, secondOperand);
                    LastOper = MathOperationsEnum.Extent;
                    resultForm = new ResultForm();
                    resultForm.ShowResult(Result.ToString(), LastOper);
                    resultForm.ShowDialog();

                    resultForm.Owner = this;
                    resultForm.AddOperForCounter();
                    break;
                case "<>":
                    var compareResult = MathOperations.Compare(firstOperand, secondOperand);
                    resultForm = new ResultForm(compareResult, MathOperationsEnum.Compare);
                    resultForm.ShowDialog();
                    Counter++;
                    break;
                default:
                    MessageBox.Show("Ошибка обработки операции: Не указан Tag или указан не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
