using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_
{
    public partial class Form1 : Form
    {
        private List<int> LottoNumbers;
        private const decimal CostPerGuess = 20.00m;


        public Form1()
        {
            InitializeComponent();
            GenerateLottoNumbers();
        }
        private void GenerateLottoNumbers()
        {
            Random rand = new Random();
            LottoNumbers = new List<int>();
            while (LottoNumbers.Count < 6)
            {
                int number = rand.Next(1, 46);
                if (!LottoNumbers.Contains(number))
                {
                    LottoNumbers.Add(number);
                }
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            List<int> userGuess = new List<int>();
            int num1, num2, num3, num4, num5, num6;

            if (int.TryParse(txtNumber1.Text, out num1) &&   
                int.TryParse(txtNumber2.Text, out num2) &&
                int.TryParse(txtNumber3.Text, out num3) &&
                int.TryParse(txtNumber4.Text, out num4) &&
                int.TryParse(txtNumber5.Text, out num5) &&
                int.TryParse(txtNumber6.Text, out num6))
            {


                userGuess.AddRange(new[] { num1, num2, num3, num4, num5, num6 });

                if (userGuess.Any(num => num < 1 || num > 45))
                {
                    MessageBox.Show("Each number must be between 1 and 45.");
                    return;

                }


                int correctCount = LottoNumbers.Intersect(userGuess).Count();
                lblResult.Text = "You matched " + correctCount + " numbers.";

                decimal totalCost = CalculateTotalCost(userGuess.Count);
                lblCost.Text = "Total Cost: R" + totalCost.ToString("F2");
                lblGuesses.Text = "Number of Guesses: " + userGuess.Count;


                if (correctCount == 6)
                {
                    MessageBox.Show("Congratulations! You have won!");
                    this.BackColor = Color.Green;
                }

            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }


        }

        private static decimal CalculateTotalCost(int numberOfGuesses)
        {
            return numberOfGuesses * CostPerGuess;
        }






        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateLottoNumbers();

            lblResult.Text = "";
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtNumber3.Clear();
            txtNumber4.Clear();
            txtNumber5.Clear();
            txtNumber6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void lblGuesses_Click(object sender, EventArgs e)
        {

        }
        private void UpdateFormColor(int correctGuesses)
        {
            if (correctGuesses >= 4)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
        
    


      
