using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_Programming_Design
{
    /// <summary>
    /// This form generates a three questions based on the users input. 
    /// It has variety of radiobuttons, check boxes, dropdown list and text boxes.
    /// It hass a button that switches the user to another form with times table.
    /// </summary>

    public partial class frmMainQuiz : Form
    {
        int[] randomNumbersArr = new int[6];                // Array that will store 6 random numbers for equations
        int equation1_Answer;                               // This variable stores an answer for equation 1
        int equation2_Answer;                               // This variable stores an answer for equation 2
        int equation3_Answer;                               // This variable stores an answer for equation 3

        public frmMainQuiz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function generates 6 random numbers in particular ranges depending on which range option user has chosen
        /// and whether it has ticked a negative number checkbox.
        /// </summary>
        private void GenerateNumbers()
        {
            Random randomNumber = new Random();
            if (cboMagnitude.Text == "0-10")                                 // Magnitude 0-10
            {                                                                
                if (chkNegative.Checked)                                      
                {                                                            // If negative checkbox ticked - generates numbers in range -10 to 10
                    for (int i = 0; i < 6; i++)                               
                    {                                                         
                        int randNum = randomNumber.Next(-10, 11);             
                        randomNumbersArr[i] = randNum;                        
                    }                                                         
                }                                                             
                else                                                          
                {                                                             
                    for (int i = 0; i < 6; i++)                               
                    {                                                         
                        int randNum = randomNumber.Next(0, 11);               
                        randomNumbersArr[i] = randNum;                        
                    }
                }
            }
            if (cboMagnitude.Text == "0-100")                               // Magnitude 0-10
            {
                if (chkNegative.Checked)                                     
                {                                                           // If negative checkbox ticked - generates numbers in range -100 to 100
                    for (int i = 0; i < 6; i++)
                    {
                        int randNum = randomNumber.Next(-100, 101);
                        randomNumbersArr[i] = randNum;
                    }
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int randNum = randomNumber.Next(0, 101);
                        randomNumbersArr[i] = randNum;
                    }
                }
            }
            if (cboMagnitude.Text == "0-1000")                             // Magnitude 0-10
            {
                if (chkNegative.Checked)                                    
                {                                                          // If negative checkbox ticked - generates numbers in range -10 to 10
                    for (int i = 0; i < 6; i++)
                    {
                        int randNum = randomNumber.Next(-1000, 1001);
                        randomNumbersArr[i] = randNum;
                    }
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int randNum = randomNumber.Next(0, 1001);
                        randomNumbersArr[i] = randNum;
                    }
                }
            }
        }

        /// <summary>
        /// This function Generates random numbers just for devision option.
        /// It multiplies two random numbers in particular range. Checkes if the result is not higher that allowed range 
        /// and none of the randomly generated numbers are zero to avoid DevideByZeroException. 
        /// If all three numbers are valid then result and first random number are added to the array.
        /// </summary>
        private void GenerateDivisionNumbers()
        {
            Random randomNumber = new Random();
            ArrayList divisionNumbersArr = new ArrayList();            //ListArray to store numbers for division

            while (divisionNumbersArr.Count < 6)                       // While array does not store 6 valid numbers it will look for them
            {
                if (cboMagnitude.Text == "0-10")
                {
                    if (chkNegative.Checked)
                    {
                        int randNumOne = randomNumber.Next(-10, 11);          // Range with negative numbers
                        int randNumTwo = randomNumber.Next(-10, 11);          // Range with negative numbers
                        int result = randNumOne * randNumTwo;
                        if (result > 10 || result < -10)                     // if result more than 10 or less than -10 it will skip the whole code 
                        {                                                    // in the loop and start from begining of the loop. It applies for each magnitude
                            continue;
                        }
                        else if (randNumOne == 0 || randNumTwo == 0)         // Checks if any generated number is zero
                        {
                            continue;
                        }
                        else
                        {
                            divisionNumbersArr.Add(result);                  // Adds valid numbers in the array
                            divisionNumbersArr.Add(randNumOne);              // Adds valid numbers in the array
                        }
                    }
                    else
                    {
                        int randNumOne = randomNumber.Next(1, 11);
                        int randNumTwo = randomNumber.Next(1, 11);
                        int result = randNumOne * randNumTwo;
                        if (result > 10 || result < -10)
                        {
                            continue;
                        }
                        else if (randNumOne == 0 || randNumTwo == 0)
                        {
                            continue;
                        }
                        else
                        {
                            divisionNumbersArr.Add(result);
                            divisionNumbersArr.Add(randNumOne);
                        }
                    }
                }
                else if (cboMagnitude.Text == "0-100")
                {
                    if (chkNegative.Checked)
                    {
                        int randNumOne = randomNumber.Next(-101, 101);
                        int randNumTwo = randomNumber.Next(-101, 101);
                        int result = randNumOne * randNumTwo;
                        if (result > 100 || result < -100)
                        {
                            continue;
                        }
                        else if (randNumOne == 0 || randNumTwo == 0)
                        {
                            continue;
                        }
                        else
                        {
                            divisionNumbersArr.Add(result);
                            divisionNumbersArr.Add(randNumOne);
                        }
                    }
                    else
                    {
                        int randNumOne = randomNumber.Next(1, 101);
                        int randNumTwo = randomNumber.Next(1, 101);
                        int result = randNumOne * randNumTwo;
                        if (result > 100 || result < -100)
                        {
                            continue;
                        }
                        else if (randNumOne == 0 || randNumTwo == 0)
                        {
                            continue;
                        }
                        else
                        {
                            divisionNumbersArr.Add(result);
                            divisionNumbersArr.Add(randNumOne);
                        }
                    }
                }
                else if (cboMagnitude.Text == "0-1000")
                {
                    if (chkNegative.Checked)
                    {
                        int randNumOne = randomNumber.Next(-1000, 1001);
                        int randNumTwo = randomNumber.Next(-1000, 1001);
                        int result = randNumOne * randNumTwo;
                        if (result > 1000 || result < -1000)
                        {
                            continue;
                        }
                        else if (randNumOne == 0 || randNumTwo == 0)
                        {
                            continue;
                        }
                        else
                        {
                            divisionNumbersArr.Add(result);
                            divisionNumbersArr.Add(randNumOne);
                        }
                    }
                    else
                    {
                        int randNumOne = randomNumber.Next(1, 1001);
                        int randNumTwo = randomNumber.Next(1, 1001);
                        int result = randNumOne * randNumTwo;
                        if (result > 1000 || result < -1000)
                        {
                            continue;
                        }
                        else if (randNumOne == 0 || randNumTwo == 0)
                        {
                            continue;
                        }
                        else
                        {
                            divisionNumbersArr.Add(result);
                            divisionNumbersArr.Add(randNumOne);
                        }
                    }
                }
            }

            for (int i = 0; i < divisionNumbersArr.Count; i++)                  // 
            {                                                                   // Copies values from ArrayList to randomNumbersArr
                randomNumbersArr[i] = Convert.ToInt32(divisionNumbersArr[i]);   // 
            }                                                                   // 
        }

        /// <summary>
        /// This function makes equations visible. Generates numbers with function GenerateNumbers().
        /// Clears textboxes with ClearTextBoxes().
        /// Then it writes equations with generated numbers and chosen operator.
        /// Assigns an answers in variables in order to check the answers of the user.
        /// </summary>
        private void btnGenQuestions_Click(object sender, EventArgs e)
        {
            lblCheckEq1.Text = string.Empty;
            lblCheckEq2.Text = string.Empty;
            lblCheckEq3.Text = string.Empty;
            lblEquation1.Visible = true;             
            lblEquation2.Visible = true;             
            lblEquation3.Visible = true;             
            txtEquation1.Visible = true;             
            txtEquation2.Visible = true;             
            txtEquation3.Visible = true;             
            btnCheckAnswer.Visible = true;
            GenerateNumbers();
            ClearTextBoxes();
            if (optAdd.Checked)
            {
                lblEquation1.Text = $"{randomNumbersArr[0]} + {randomNumbersArr[1]} =";
                lblEquation2.Text = $"{randomNumbersArr[2]} + {randomNumbersArr[3]} =";
                lblEquation3.Text = $"{randomNumbersArr[4]} + {randomNumbersArr[5]} =";
                equation1_Answer = randomNumbersArr[0] + randomNumbersArr[1];
                equation2_Answer = randomNumbersArr[2] + randomNumbersArr[3];
                equation3_Answer = randomNumbersArr[4] + randomNumbersArr[5];
            }
            else if (optMultiplication.Checked)
            {
                lblEquation1.Text = $"{randomNumbersArr[0]} x {randomNumbersArr[1]} =";
                lblEquation2.Text = $"{randomNumbersArr[2]} x {randomNumbersArr[3]} =";
                lblEquation3.Text = $"{randomNumbersArr[4]} x {randomNumbersArr[5]} =";
                equation1_Answer = randomNumbersArr[0] * randomNumbersArr[1];
                equation2_Answer = randomNumbersArr[2] * randomNumbersArr[3];
                equation3_Answer = randomNumbersArr[4] * randomNumbersArr[5];
            }
            else if (optSubstract.Checked)
            {
                lblEquation1.Text = $"{randomNumbersArr[0]} - {randomNumbersArr[1]} =";
                lblEquation2.Text = $"{randomNumbersArr[2]} - {randomNumbersArr[3]} =";
                lblEquation3.Text = $"{randomNumbersArr[4]} - {randomNumbersArr[5]} =";
                equation1_Answer = randomNumbersArr[0] - randomNumbersArr[1];
                equation2_Answer = randomNumbersArr[2] - randomNumbersArr[3];
                equation3_Answer = randomNumbersArr[4] - randomNumbersArr[5];
            }
            else if (optDivision.Checked)
            {
                GenerateDivisionNumbers();
                lblEquation1.Text = $"{randomNumbersArr[0]} / {randomNumbersArr[1]} =";
                lblEquation2.Text = $"{randomNumbersArr[2]} / {randomNumbersArr[3]} =";
                lblEquation3.Text = $"{randomNumbersArr[4]} / {randomNumbersArr[5]} =";
                equation1_Answer = randomNumbersArr[0] / randomNumbersArr[1];
                equation2_Answer = randomNumbersArr[2] / randomNumbersArr[3];
                equation3_Answer = randomNumbersArr[4] / randomNumbersArr[5];
            }
        }

        /// <summary>
        /// This function checks users answers for equations.
        /// displays "Correct" with green colour or "Wrong" with red colour
        /// </summary>
        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (NotEmpty())
            {
                if (Convert.ToInt32(txtEquation1.Text) == equation1_Answer)
                {
                    lblCheckEq1.Text = "Correct";
                    lblCheckEq1.ForeColor = Color.LightGreen;
                }
                else if (Convert.ToInt32(txtEquation1.Text) != equation1_Answer)
                {
                    lblCheckEq1.Text = "Wrong";
                    lblCheckEq1.ForeColor = Color.Red;
                }

                if (Convert.ToInt32(txtEquation2.Text) == equation2_Answer)
                {
                    lblCheckEq2.Text = "Correct";
                    lblCheckEq2.ForeColor = Color.LightGreen;
                }
                else if (Convert.ToInt32(txtEquation2.Text) != equation2_Answer)
                {
                    lblCheckEq2.Text = "Wrong";
                    lblCheckEq2.ForeColor = Color.Red;
                }

                if (Convert.ToInt32(txtEquation3.Text) == equation3_Answer)
                {
                    lblCheckEq3.Text = "Correct";
                    lblCheckEq3.ForeColor = Color.LightGreen;
                }
                else if (Convert.ToInt32(txtEquation3.Text) != equation3_Answer)
                {
                    lblCheckEq3.Text = "Wrong";
                    lblCheckEq3.ForeColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// This function just clears textboxes for equations, so old answers for new equations will not be shown.
        /// </summary>
        private void ClearTextBoxes()
        {
            txtEquation1.Text = string.Empty;
            txtEquation2.Text = string.Empty;
            txtEquation3.Text = string.Empty;
        }

        /// <summary>
        /// This function checks an answers for valid format. 
        /// Only digits and no blank textboxes.
        /// If format is valid - returns true, otherwise returns false and shows an error message.
        /// </summary>

        private bool NotEmpty()
        {
            if (txtEquation1.Text == string.Empty || txtEquation2.Text == string.Empty || txtEquation3.Text == string.Empty)
            {
                MessageBox.Show("Please fill the answer boxes");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Button to switch open another form with times table
        /// </summary>
        private void btnSwitchToTimesFrm_Click(object sender, EventArgs e)
        {
            frmTimesTable TimesTableForm = new frmTimesTable();
            TimesTableForm.Show();
        }

        /// <summary>
        /// Next three functions drop an error message if user attempted to enter 
        /// wrong format character in any of the textboxes.
        /// Only digits and minus allowed.
        /// </summary>

        private void txtEquation1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEquation1.Text, "[^0-9||-]"))
            {
                MessageBox.Show("Only digits for the answers");
                txtEquation1.Text = string.Empty;
            }
        }
        private void txtEquation2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEquation2.Text, "[^0-9||-]"))
            {
                MessageBox.Show("Only digits for the answers");
                txtEquation2.Text = string.Empty;
            }
        }
        private void txtEquation3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEquation3.Text, "[^0-9||-]"))
            {
                MessageBox.Show("Only digits for the answers");
                txtEquation3.Text = string.Empty;
            }
        }
    }
}
