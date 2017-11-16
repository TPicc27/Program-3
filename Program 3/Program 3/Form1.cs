// Tony Piccirilli
// CIS 199-01-4162
// Program 3
// April 5, 2016
// This program takes the student's last name
// and how many credit hours the student has
// to determine their earliest registration time and day.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
                const float SENIOR_HOURS = 90;    // Min hours for Senior
                const float JUNIOR_HOURS = 60;    // Min hours for Junior
                const float SOPHOMORE_HOURS = 30; // Min hours for Soph.

                const string DAY1 = "March 30";  // 1st day of registration
                const string DAY2 = "March 31";  // 2nd day of registration
                const string DAY3 = "April 1";   // 3rd day of registration
                const string DAY4 = "April 4";   // 4th day of registration
                const string DAY5 = "April 5";   // 5th day of registration
                const string DAY6 = "April 6";   // 6th day of registration

                const string TIME1 = "8:30 AM";  // 1st time block
                const string TIME2 = "10:00 AM"; // 2nd time block
                const string TIME3 = "11:30 AM"; // 3rd time block
                const string TIME4 = "2:00 PM";  // 4th time block
                const string TIME5 = "4:00 PM";  // 5th time block

                string lastNameStr;       // Entered last name
                char lastNameLetterCh;    // First letter of last name, as char
                string dateStr = "Error"; // Holds date of registration
                string timeStr = "Error"; // Holds time of registration
                float creditHours;        // Entered credit hours
                

                if (float.TryParse(creditBox.Text, out creditHours) && creditHours >= 0) // Valid hours
                {
                    lastNameStr = nameBox.Text;
                    if (lastNameStr.Length > 0) // Empty string?
                    {
                        lastNameStr = lastNameStr.ToUpper(); // Ensure upper case
                        lastNameLetterCh = lastNameStr[0];   // First char of last name

                        if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                        {
                            // Juniors and Seniors share same schedule but different days
                            if (creditHours >= JUNIOR_HOURS)
                            {
                                if (creditHours >= SENIOR_HOURS)
                                    dateStr = DAY1;
                                else // Must be juniors
                                    dateStr = DAY2;

                                
                                char[] lastName = { 'A', 'E', 'J', 'P', 'T', };  // Last Name Array
                                string[] times = { TIME5, TIME1, TIME2, TIME3, TIME4 };  // Time frame for each last name.
                                int index;                                              // Array Subsricpt
                                 
                                 index = lastName.Length - 1;
                                 while (index >= 0 && lastNameLetterCh < lastName[index])
                                    --index;

                                    timeStr = times[index];
                                   
                                
                        }
                            else // Must be soph/fresh
                            {
                                if (creditHours >= SOPHOMORE_HOURS)
                                {
                                    // E-Q on one day
                                    if ((lastNameLetterCh >= 'E') && // >= E and
                                        (lastNameLetterCh <= 'Q'))   // <= Q
                                        dateStr = DAY3;
                                    else // All other letters on next day
                                        dateStr = DAY4;
                                }
                                else // must be freshman
                                {
                                    // E-Q on one day
                                    if ((lastNameLetterCh >= 'E') && // >= E and
                                        (lastNameLetterCh <= 'Q'))   // <= Q
                                        dateStr = DAY5;
                                    else // All other letters on next day
                                        dateStr = DAY6;
                                }
                               
                                
                                char[] lastName = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' };   // Array to find last name.
                                string[] times = { TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2, TIME3 };  //Array to find time frame.
                                int index;   // Array Subsricpt
                                
                                index = lastName.Length - 1;
                                while (index >= 0 && lastNameLetterCh < lastName[index])
                                    --index;
                                    
                                    timeStr = times[index];
                                    
                                
                            }
                            // Output results
                            timeAnswer.Text = dateStr + " at " + timeStr;
                        
                        }
                        else // First char not a letter
                            MessageBox.Show("Enter valid last name!");
                    }
                      else // Empty textbox
                    MessageBox.Show("Enter a last name!");
                }
                else // Can't parse credit hours
                    MessageBox.Show("Please enter valid credit hours earned!");
                }

        private void clearButton_Click(object sender, EventArgs e)
        {
           // To clear all textboxes and labels.
            creditBox.Text = "";
            nameBox.Text = "";
            timeAnswer.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // To close the form.
            this.Close();
        }




        }
        
        
    }
