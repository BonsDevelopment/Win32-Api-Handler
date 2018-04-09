using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32_Api_Handler
{
    public partial class NativeMethodsForm : Form
    {
        public NativeMethodsForm()
        {
            InitializeComponent();
            
        }
    
        private void NativeMethodsForm_Shown(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}
