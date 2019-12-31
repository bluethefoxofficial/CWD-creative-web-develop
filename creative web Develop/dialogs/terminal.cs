using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop.dialogs
{
    public partial class terminal : Form
    {
        public terminal()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CxFlatButton1_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            // Reference to System.Drawing library
            parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            parameters.ReferencedAssemblies.Add("System");
            parameters.ReferencedAssemblies.Add("System.windows.forms");
            parameters.ReferencedAssemblies.Add("creative_web_Develop");
            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = true;
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = true;
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, fastColoredTextBox1.Text);
        }
    }
}
