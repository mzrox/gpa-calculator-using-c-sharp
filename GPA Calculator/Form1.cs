using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (oop.Text == "" || dld.Text == "" || ds.Text == "" || pns.Text == "" || ps.Text == "" || isl.Text == "" || oop1.Text == "" || dld1.Text == "" || ds1.Text == "" || pns1.Text == "" || ps1.Text == "" || isl1.Text == "")
            {
                MessageBox.Show("All Entries Should Be Filled");
            }
            else
            {
                float[] arr = new float[6];
                int[] arr1 = new int[6];
                float[] mul = new float[6];
                float suma = 0;
                int sum = 0;
                float gpa1 = 0;
                int a;
                string c;

                arr[0] = Int32.Parse(oop.Text);
                arr[1] = Int32.Parse(dld.Text);
                arr[2] = Int32.Parse(ds.Text);
                arr[3] = Int32.Parse(pns.Text);
                arr[4] = Int32.Parse(ps.Text);
                arr[5] = Int32.Parse(isl.Text);
                for (int i = 0; i <= 5; i++)
                {
                    if (arr[i] > 100 || arr[i] < 0)
                    {
                        MessageBox.Show("Marks Should be from 0-100");
                    }
                }
                arr1[0] = Int32.Parse(oop1.Text);
                arr1[1] = Int32.Parse(dld1.Text);
                arr1[2] = Int32.Parse(ds1.Text);
                arr1[3] = Int32.Parse(pns1.Text);
                arr1[4] = Int32.Parse(ps1.Text);
                arr1[5] = Int32.Parse(isl1.Text);

                if (checkBox1.Checked)
                {
                    arr[0] = 0;
                    arr1[0] = 0;
                }
                if (checkBox2.Checked)
                {
                    arr[1] = 0;
                    arr1[1] = 0;
                }
                if (checkBox3.Checked)
                {
                    arr[2] = 0;
                    arr1[2] = 0;
                }
                if (checkBox4.Checked)
                {
                    arr[3] = 0;
                    arr1[3] = 0;
                }
                if (checkBox5.Checked)
                {
                    arr[4] = 0;
                    arr1[4] = 0;
                }
                if (checkBox6.Checked)
                {
                    arr[5] = 0;
                    arr1[5] = 0;
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
                {
                    gpa.Text = "Not Enrolled In Any Course";
                }
                else
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        mul[i] = arr[i] * arr1[i];
                        suma += mul[i];
                    }
                    sum = arr1[0] + arr1[1] + arr1[2] + arr1[3] + arr1[4] + arr1[5];
                    gpa1 = suma / sum;
                    float gpa2;
                    gpa2 = gpa1 / 25;
                    if (gpa1 >= 90 && gpa1 <= 100)
                    {
                        
                        gpa.Text = "Your GPA = " + gpa2 + " (A+)";
                    }
                    else if (gpa1 < 90 && gpa1 >= 80)
                    {
                        gpa.Text = "Your GPA = " + gpa2 + " (A)";
                    }
                    else if (gpa1 < 80 && gpa1 >= 70)
                    {
                        gpa.Text = "Your GPA = " + gpa2 + " (B)";
                    }
                    else if (gpa1 < 70 && gpa1 >= 60)
                    {
                        gpa.Text = "Your GPA = " + gpa2 + " (C)";
                    }
                    else if (gpa1 < 60 && gpa1 >= 50)
                    {
                        gpa.Text = "Your GPA = " + gpa2 + " (D)";
                    }
                    else if (gpa1 < 50 && gpa1 >= 0)
                    {
                        gpa.Text = "Your GPA = " + gpa2 + " (F)";
                    }
                }
                
            }
            
        }

        private void oop_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpa_Click(object sender, EventArgs e)
        {

        }
    }
}
