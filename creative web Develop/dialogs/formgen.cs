using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class formgen : Form
    {
        public string generatedcode = "";

        public formgen()
        {
            InitializeComponent();
        }

        private void CxFlatButton1_Click(object sender, EventArgs e)
        {

            if (uploadfile.Checked == true && uploadfilename.Text == "")
            {

                MessageBox.Show("Invalid upload input file name");

            }
            else
            {


                if (action.Text == "")
                {
                    if (post.Checked == true)
                    {
                        if (uploadfile.Checked == true)
                        {
                            generatedcode = "<form method=\"post\" enctype=\"multipart / form - data\">";
                        }
                        else
                        {
                            generatedcode = "<form method=\"post\">";
                        }
                    }
                    else
                    {
                        generatedcode = "<form method=\"get\">";
                    }
                }
                else
                {
                    if (post.Checked == true)
                    {
                        if (uploadfile.Checked == true)
                        {
                            generatedcode = "<form action=\"" + action.Text + "\" method=\"post\" enctype=\"multipart / form - data\">";
                        }
                        else
                        {
                            generatedcode = "<form action=\"" + action.Text + "\" method=\"post\">";
                        }
                    }
                    else
                    {
                        generatedcode = "<form action=\"" + action.Text + "\" method=\"get\">";
                    }
                }

                generatedcode += "\n" +  custom.Text;

                if (uploadfile.Checked == false)
                {
                    generatedcode += "\n";
                }
                else
                {
                    generatedcode += "\n <input type=\"file\" name=\"" + uploadfilename.Text + "\" id=\"" + uploadfilename.Text + "\"/>";
                }

                if(buttontext.Text == "")
                {
                    if (submit.Checked == true)
                    {
                        generatedcode += "\n <input type=\"submit\" name=\"s\" value=\"Submit\"/>";
                    }
                    else if(button.Checked == true)
                    {
                        generatedcode += "\n <button>Submit</button>";
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (submit.Checked == true)
                    {
                        generatedcode += "\n <input type=\"submit\" name=\"s\" value=\"" + buttontext.Text + "\"/>";
                    }
                    else if (button.Checked == true)
                    {
                        generatedcode += "\n <button>" + buttontext.Text + "</button>";
                    }
                    else
                    {

                    }
                    
                }
                generatedcode += "\n </form>";
                this.Close();
            }
        }

        private void Formgen_Load(object sender, EventArgs e)
        {
           
        }

        private void Uploadfile_CheckedChanged(object sender, EventArgs e)
        {
            if(uploadfile.Checked == true)
            {
                post.Checked = true;
            }
        }

        private void Post_CheckedChanged(object sender, EventArgs e)
        {
            if (post.Checked == false)
            {
              uploadfile.Checked = false;
            }
        }

        private void Button_CheckedChanged(object sender, EventArgs e)
        {

        }
        public string codeoutput()
        {
            return generatedcode;
        }

        private void CxFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
