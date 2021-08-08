using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Name: Samir Ali
//Date: May 5, 2020
//Title: Quadrilateral Identifier
//Purpose: To identify the quadrilateral for it's shape and existance
namespace Quadrilateral

{
    public partial class lblCalculate : Form
    {
        public static int x = 0; //declares/globalizes the variable x and assigns it the datatype integer as well as the value 0
        public static double Side1; //declares/globalizes the variable Side1 and assigns it the datatype double.
        public static double Side2;
        public static double Side3;
        public static double Side4;
        public static double Angle1;
        public static double Angle2;
        public static double Angle3;
        public static double Angle4;
        public static double TotalAngle;
        public static double Diagonal1;
        public static double Diagonal2;
        public static double Diagonal3;
        public static double Diagonal4;
        public static double DiagonalDifference;
        public static double DiagonalDifference2;

        public lblCalculate()
        {
            InitializeComponent();
        }


        private void NextSide_Click(object sender, EventArgs e)
        {
            try //runs the block of code within the brackets and checks for errors
            {
                if (x < 0) // x is the variable that control the label upon button press,if the user spams the back button it resets its value to 0
                {
                    x = 0; //x becomes 0
                }
                else if (x == 0) //on the first click of the next button, the label will change to the specified text.
                {
                    lblSide.Text = "Enter Side1:";
                }
                else if (x == 1) //on the second click of the next button, the label will change to the specified text and store the value of the user's input for Side1 after converting it to double.
                {
                    Side1 = double.Parse(txtValue.Text);
                    lblSide.Text = "Enter Side2:";
                    txtValue.Clear(); //clears the user's input and the textbox in general
                }
                else if (x == 2)
                {
                    Side2 = double.Parse(txtValue.Text);
                    lblSide.Text = "Enter Side3:";
                    txtValue.Clear();
                }
                else if (x == 3)
                {
                    Side3 = double.Parse(txtValue.Text);
                    lblSide.Text = "Enter Side4:";
                    txtValue.Clear();
                }
                else if (x == 4)
                {
                    Side4 = double.Parse(txtValue.Text);
                    lblSide.Text = "Enter Angle1:";
                    txtValue.Clear();
                }
                else if (x == 5)
                {
                    Angle1 = double.Parse(txtValue.Text);
                    lblSide.Text = "Enter Angle2:";
                    txtValue.Clear();
                }
                else if (x == 6)
                {
                    Angle2 = double.Parse(txtValue.Text);
                    lblSide.Text = "Enter Angle3:";
                    txtValue.Clear();
                }
                else if (x == 7)
                {
                    Angle3 = double.Parse(txtValue.Text);
                    lblSide.Text = "Enter Angle4:";
                    txtValue.Clear();
                }
                else if (x == 8)
                {
                    Angle4 = double.Parse(txtValue.Text);
                    lblSide.Text = "Now Click Calculate";
                    txtValue.Clear();
                    btnCalculate.Visible = true; //Once all input is entered, the calculate button becomes visible.
                }
                x += 1; //After every time the button is pressed, the variable x's value is added by 1
                TotalAngle = (Angle1 + Angle2 + Angle3 + Angle4); //calculates the total sum of all the angles and stores it under the variable TotalAngle
                Diagonal1 = Math.Sqrt(Math.Pow(Side1 / 2, 2) + Math.Pow(Side4 / 2, 2) - 2 * Side1 / 2 * Side4 / 2 * Math.Cos(Angle1 * Math.PI / 180)); //Uses cosine formula to determine one of the diagonals of the quadrilateral
                Diagonal2 = Math.Sqrt(Math.Pow(Side2 / 2, 2) + Math.Pow(Side3 / 2, 2) - 2 * Side2 / 2 * Side3 / 2 * Math.Cos(Angle3 * Math.PI / 180));
                Diagonal3 = Math.Sqrt(Math.Pow(Side3 / 2, 2) + Math.Pow(Side4 / 2, 2) - 2 * Side3 / 2 * Side4 / 2 * Math.Cos(Angle4 * Math.PI / 180));
                Diagonal4 = Math.Sqrt(Math.Pow(Side1 / 2, 2) + Math.Pow(Side2 / 2, 2) - 2 * Side1 / 2 * Side2 / 2 * Math.Cos(Angle2 * Math.PI / 180));
                DiagonalDifference = Diagonal1 - Diagonal2; //Finds the difference of the parallel diagonals and stores it under DiagonalDifference
                DiagonalDifference2 = Diagonal3 - Diagonal4; //Finds the difference of the second pair of parallel diagonals and stores it under DiagonalDifference2
            }
            catch (Exception) //tries to look for any exceptions with the above code
            {
                MessageBox.Show("Wrong Input! Try Again"); //if there is an error then a messsage box will show with the specified text
            }



        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (TotalAngle == 360 && Side1 > 0 && Side2 > 0 && Side3 > 0 && Side4 > 0 && (DiagonalDifference >= -0.5 && DiagonalDifference <= 0.5 || DiagonalDifference2 >= -0.5 && DiagonalDifference2 <= 0.5)) //the conditions that must be met for the shape to be a quadrilateral
            {
                if (Side1 != Side2 && Side1 == Side3 && Side3 != Side4 && Side2 == Side4 && Angle1 == 90) //properties of a rectangle are the conditions of the if statement
                {
                    txtResult.Text = "It's a Rectangle"; //if shape has met those conditions, then output in the textbox it's a Sectangle
                }
                else if (Side1 == Side2 && Side3 == Side4 && Side1 == Side3 && Side2 == Side4 && Angle1 == 90) // if it's not a rectangle the properties of a square are checked and if the conditions are met it will output a result
                {
                    txtResult.Text = "It's a Square"; //if shape has met those conditions, then output in the textbox it's a Square
                }
                else if (Side1 != Side2 && Side1 == Side3 && Angle1 != Angle2 && Angle1 == Angle3)  // if it's not a square the properties of a Parallelogram are checked and if the conditions are met it will output a result
                {
                    txtResult.Text = "It's a Parallelogram!"; //if shape has met those conditions, then output in the textbox it's a Parallelogram
                }
                else if (Side1 == Side2 && Side3 == Side4 && Side1 == Side3 && Angle1 != Angle2 && Angle1 == Angle3)  // if it's not a Parallelogram the properties of a Rhombus are checked and if the conditions are met it will output a result
                {
                    txtResult.Text = "It's a Rhombus!"; //if shape has met those conditions, then output in the textbox it's a Rhombus
                }
                else if (Side1 == Side2 && Side1 != Side3 && Side3 == Side4 && Side2 != Side4 && Angle1 == Angle3 && Angle1 != Angle2 || Angle2 == Angle4 && Angle2 != Angle3)  // if it's not a Rhombus the properties of a Kite are checked and if the conditions are met it will output a result
                {
                    txtResult.Text = "It's a Kite!"; //if shape has met those conditions, then output in the textbox it's a Kite
                }
                else if (Side1 != Side2 && Side1 != Side3 && Side1 != Side4 && Angle1 != Angle2 && Angle1 != Angle3 && Angle1 + Angle4 == 180)  // if it's not a Kite the properties of a Trapezoid are checked and if the conditions are met it will output a result
                {
                    txtResult.Text = "It's a Trapezoid"; //if shape has met those conditions, then output in the textbox it's a Trapzeoid
                }
                else if (Angle1 + Angle4 == 180 && Angle1 == Angle2 && Side1 == Side3 || Side2 == Side4)  // if it's not a general Trapezoid the properties of a Isoceles Trapezoid are checked and if the conditions are met it will output a result
                {
                    txtResult.Text = "It's Isoceles Trapezoid"; //if shape has met those conditions, then output in the textbox it's a Isoceles Trapezoid
                }
                else
                {
                    txtResult.Text = "Undefined"; //Any shape that is a quadrilateral besides the defined ones above will be undefined
                }
            }
            else if (Angle1 <= 0 || Angle2 <= 0 || Angle3 <= 0 || Angle4 <= 0)
            {
                txtResult.Text = "Invalid Angle"; //if user input has met those conditions, then output in the textbox is Invalid Angle
            }
            else if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0 || Side4 <= 0)
            {
                txtResult.Text = "Invalid Side"; //if user input has met those conditions, then output in the textbox is Invalid Side
            }
            else if (TotalAngle > 360 || TotalAngle < 360)
            {
                txtResult.Text = "Sum of Angles"; //if user input has met those conditions, then output in the textbox is Sum of Angles
            }
            else
            {
                txtResult.Text = "Error No Shape"; //Any other issue with user input or if its not an existant quadrilateral will be error
            }
        }

            private void btnBack_Click(object sender, EventArgs e)
            {
                btnCalculate.Visible = false; //if the back button is clicked the calculate button goes invisible
                x -= 1; //everytime the back button is clicked the variable x is subtracted by 1
                if (x == 1) // if x's value is 1 (btnNext has only been pressed once)
                {
                    lblSide.Text = "Enter Side1:"; //Change the label to the following text
                }
                if (x == 2)
                {
                    lblSide.Text = "Enter Side2:";
                }
                else if (x == 3)
                {
                    lblSide.Text = "Enter Side3:";
                }
                else if (x == 4)
                {
                    lblSide.Text = "Enter Side4:";
                }
                else if (x == 5)
                {
                    lblSide.Text = "Enter Angle1:";
                }
                else if (x == 6)
                {
                    lblSide.Text = "Enter Angle2:";
                }
                else if (x == 7)
                {
                    lblSide.Text = "Enter Angle3:";
                }
                else if (x == 8)
                {
                    lblSide.Text = "Enter Angle4:";
                }
                else if (x == 9)
                {
                    lblSide.Text = "Now Click Calculate";
                }
            }

            private void lblCalculate_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter) //checks to see if the key enter is pressed
                {
                    btnNextSide.PerformClick(); //if the key enter is pressed then it will mimic a click on the button Next
                }
                else if (e.KeyCode == Keys.B)  //checks to see if the key B is pressed
            {
                    btnBack.PerformClick(); //if the key B is pressed then it will mimic a click on the button Back
            }
                else if (e.KeyCode == Keys.ShiftKey)  //checks to see if the key ShiftKey is pressed
            {
                    btnCalculate.PerformClick(); //if the ShiftKey is pressed then it will mimic a click on the button Calculate
            }
            }
        }
    }

