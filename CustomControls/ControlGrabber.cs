using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32_Api_Handler.CustomControls
{
    class ControlGrabber : PictureBox
    {
        public ControlGrabber()
        {
            this.MouseDown += ControlGrabber_MouseDown;
            this.MouseUp += ControlGrabber_MouseUp;
            this.BackgroundImage = Properties.Resources.circle1;
            this.BackgroundImageLayout = ImageLayout.Center;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = System.Drawing.Color.LightGray;
        }

        private void ControlGrabber_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            this.BackgroundImage = Properties.Resources.circle1;
            this.Update();
        }

        private void ControlGrabber_MouseDown(object sender, MouseEventArgs e)
        {
            using (var memStream = new MemoryStream(Properties.Resources.circle))
            {
                Cursor = new Cursor(memStream);
            }
            pInvokes.SetCapture(this.Handle);
            this.BackgroundImage = null;
            this.Update();
        }
    }
}
