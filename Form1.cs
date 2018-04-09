using System;
using System.Text;
using System.Windows.Forms;
using Win32_Api_Handler.CodeCreation;
using Win32_Api_Handler.HandleConfigurations;

namespace Win32_Api_Handler
{
    public partial class Form1 : Form
    {
        private IntPtr hWnd;
        public Form1()
        {
            InitializeComponent();
                     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hWnd = pInvokes.WindowFromPoint(Cursor.Position);

            if (hWnd != IntPtr.Zero)
            {               
                subParentLbl.Text = $"\"{GetHandlesClass.GetParent(hWnd)}\"";
                subHandleLbl.Text = $"\"{hWnd}\"";
                subClassnameLbl.Text = $"\"{GetHandlesClass.GetClassName(hWnd)}\"";
                subControlTextLbl.Text = $"\"{GetHandlesClass.GetControlText(hWnd)}\"";
                subParentTextLbl.Text = $"\"{GetHandlesClass.GetParentText(hWnd)}\"";
                subWidthLbl.Text = $"{GetHandlesClass.GetControlSizeW(hWnd)}";
                subHeightLbl.Text = $"{GetHandlesClass.GetControlSizeH(hWnd)}";
            }
        }

        private void controlGrabber1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseWinHandleTimer.Stop();
            dynamicTextBox.Text = Dynamic.GetDynamicCode(hWnd);
            staticCodeTextBox.Text = Static.GetStaticCode(hWnd, subClassnameLbl.Text.Replace("\"",""));
            onMouseChkBox.Checked = false;
        }

        private void controlGrabber1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseWinHandleTimer.Enabled = true;
            mouseWinHandleTimer.Start();            
        }

        private void onMouseChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onMouseChkBox.Checked)
            {
                mouseWinHandleTimer.Enabled = true;
                mouseWinHandleTimer.Start();
            }
            else
            {
                mouseWinHandleTimer.Enabled = false;
                mouseWinHandleTimer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            wmComboBox1.DataSource = Enum.GetNames(typeof(WindowMessages));
        }

        private void wmComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void sendMsgBtn_Click(object sender, EventArgs e)
        {
            if (mouseWinHandleTimer.Enabled) return;
            
            uint WM_MSG = (uint)(WindowMessages)Enum.Parse(typeof(WindowMessages), wmComboBox1.SelectedValue.ToString());

            if(WM_MSG == (uint)WindowMessages.BM_CLICK)
            {
                pInvokes.SendMessage(hWnd, WM_MSG, 0, null);
            }
            else if (WM_MSG == (uint)WindowMessages.WM_GETTEXT)
            {
                StringBuilder getText = new StringBuilder(256);
                pInvokes.SendMessage(hWnd, WM_MSG, getText.Capacity, getText);
                wmGetTextBox1.Text = getText.ToString();
            }
            else if (WM_MSG == (uint)WindowMessages.WM_SETTEXT)
            {
                StringBuilder setText = new StringBuilder(256);
                setText.Append(setTextTxtBox1.Text);
                pInvokes.SendMessage(hWnd, WM_MSG, 0,setText );
                setText.Clear();

            }
            else
            {
                pInvokes.SendMessage(hWnd, WM_MSG, 0, null);
            }

        }

        private void pinvokeBtn_Click(object sender, EventArgs e)
        {
            NativeMethodsForm nfmForm = new NativeMethodsForm();
            nfmForm.ShowDialog();
        }
    }
}
