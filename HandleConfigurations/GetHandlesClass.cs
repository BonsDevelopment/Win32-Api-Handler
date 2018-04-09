using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win32_Api_Handler.HandleConfigurations
{
    public static class GetHandlesClass
    {
        private static StringBuilder strHandles = new StringBuilder(256);

        public static string GetClassName(IntPtr Handle)
        {
            int className = pInvokes.GetClassName(Handle, strHandles, strHandles.Capacity);

            return (className != 0) ? strHandles.ToString() : "null";
        }

        public static IntPtr GetParent(IntPtr Handle)
        {
            IntPtr hwndParent = pInvokes.GetParent(Handle);

            return (hwndParent != null) ? hwndParent : IntPtr.Zero;
        } 

        public static string GetControlText(IntPtr Handle)
        {
            strHandles.Clear();
            pInvokes.SendMessage(Handle, (int)WindowMessages.WM_GETTEXT, strHandles.Capacity, strHandles);

            return strHandles.ToString();
        }

        public static string GetParentText(IntPtr Handle)
        {
            strHandles.Clear();
            pInvokes.SendMessage(pInvokes.GetParent(Handle), (int)WindowMessages.WM_GETTEXT, strHandles.Capacity, strHandles);
            return strHandles.ToString();
        }

        public static int GetControlSizeW(IntPtr Handle)
        {
            RECT controlRect;

            if (pInvokes.GetWindowRect(Handle, out controlRect))
            {
                return controlRect.Right - controlRect.Left;
            }

            return 0;

        }

        public static int GetControlSizeH(IntPtr Handle)
        {
            RECT controlRect;

            if (pInvokes.GetWindowRect(Handle, out controlRect))
            {
                return controlRect.Bottom - controlRect.Top;
            }

            return 0;

        }

    }
}
