using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32_Api_Handler.CodeCreation
{
    public static class Static
    {
        private static Process pName;
        

        private static string strFindWindow = "IntPtr parentHandle = FindWindow(\"%CLASSNAME%\",\"%WINTITLE%\");";

        private static string strFindWindowEx = "IntPtr %CHILD% = FindWindowEx(%PARENT%, %CHILDAFTER%, %CLASSNAME%, null);";

        private static StringBuilder strFull = new StringBuilder();
        //fix main window

        public static string GetStaticCode(IntPtr Handle, string ClassName)
        {
            strFull.Clear();
            var indexLocation = HandleIndex(Handle, ClassName);
            StringBuilder lpClassName = new StringBuilder(256);

            if(Handle == pName.MainWindowHandle)
            {
                string parentHandleWindow = strFindWindow.Replace("%WINTITLE%", $"{pName.MainWindowTitle}");
                pInvokes.GetClassName(pName.MainWindowHandle, lpClassName, lpClassName.Capacity);

                parentHandleWindow = parentHandleWindow.Replace("%CLASSNAME%", lpClassName.ToString());
                strFull.Append(parentHandleWindow);
                return strFull.ToString();
            }

            string findWindow = strFindWindow.Replace("%WINTITLE%", $"{pName.MainWindowTitle}");
            pInvokes.GetClassName(pName.MainWindowHandle, lpClassName, lpClassName.Capacity);

            findWindow = findWindow.Replace("%CLASSNAME%", lpClassName.ToString());          
            strFull.Append((findWindow + Environment.NewLine) + Environment.NewLine );

            var parentList = ParentCount(Handle);
            string loopChild = "";


            //sloppy code cba to fix up - string edits based on conditions
            if (parentList.Count > 1)
            {               
                for (int i = 0; i < parentList.Count -1; i++)
                {
                    lpClassName.Clear();
                    pInvokes.GetClassName(parentList[i], lpClassName, lpClassName.Capacity);
                    loopChild = strFindWindowEx.Replace("%CHILD%", $"child{i}");
                    if (i == 0)
                    {
                        loopChild = loopChild.Replace("%PARENT%", $"parentHandle");
                    }
                    else
                    {
                        loopChild = loopChild.Replace("%PARENT%", $"child{i -1}");
                    }
                    loopChild = loopChild.Replace("%CHILDAFTER%", "IntPtr.Zero");
                    loopChild = loopChild.Replace("%CLASSNAME%", $"\"{lpClassName}\"");
                    strFull.Append((loopChild + Environment.NewLine) + Environment.NewLine);
                }

            }

            int counter = 0;

            var childParents = FindChildHandleClass(pInvokes.GetParent(Handle), ClassName);
 
            if(indexLocation.Item1 > 0 && childParents.Count != 1)
            {

                for (int i = 0; i < indexLocation.Item1; i++)
                {
                    string childHandle = strFindWindowEx.Replace("%CHILD%", $"childAfter{counter}");
                    
                    if (parentList.Count > 1)
                    {
                        childHandle = childHandle.Replace("%PARENT%", $"child{parentList.Count - 2}");
                    }
                    else
                    {
                        childHandle = childHandle.Replace("%PARENT%", $"parentHandle");
                    }
                   
                    if(i > 0)
                    {
                        childHandle = childHandle.Replace("%CHILDAFTER%", $"childAfter{counter - 1}");
                    }
                    else
                    {
                        childHandle = childHandle.Replace("%CHILDAFTER%", $"IntPtr.Zero");
                    }

                    childHandle = childHandle.Replace("%CLASSNAME%", $"\"{ClassName}\"");

                    counter++;
                    strFull.Append((childHandle + Environment.NewLine) + Environment.NewLine);
                }

            }

            string hWnd = strFindWindowEx.Replace("%CHILD%", $"hWnd");
            if (parentList.Count > 1)
            {
                hWnd = hWnd.Replace("%PARENT%", $"child{parentList.Count - 2}");
            }
            else
            {
                hWnd = hWnd.Replace("%PARENT%", $"parentHandle");
            }

            
            hWnd = hWnd.Replace("%CLASSNAME%", $"\"{ClassName}\"");
            if (strFull.ToString().Contains("childHandle"))
            {
                hWnd = hWnd.Replace("%CHILDAFTER%", $"childAfter{counter-1}");
            }
            else
            {
                hWnd = hWnd.Replace("%CHILDAFTER%", "IntPtr.Zero");
            }

            strFull.Append((hWnd + Environment.NewLine) + Environment.NewLine );
            
            return strFull.ToString(); 
        }


        /// <summary>
        /// Grabs the total parents of handle
        /// </summary>
        /// <param name="Handle">Handle to control/window</param>
        /// <returns>List of all the parents</returns>
        private static List<IntPtr> ParentCount(IntPtr Handle)
        {
            List<IntPtr> parentHandles = new List<IntPtr>();

            IntPtr grabParent = pInvokes.GetParent(Handle);

            while (grabParent != IntPtr.Zero)
            {
                parentHandles.Add(grabParent);
                grabParent = pInvokes.GetParent(grabParent);
            }        
            return parentHandles;
        }


        /// <summary>
        /// Gets the index of the handle based on class name
        /// </summary>
        /// <param name="Handle">Handle of control</param>
        /// <param name="ClassName">Classname</param>
        /// <returns>Tuple item1: index location item2: total number of controls with the classname </returns>
        private static Tuple<int,int> HandleIndex(IntPtr Handle,string ClassName)
        {
            uint processID;
            int count = 0;

            pInvokes.GetWindowThreadProcessId(Handle, out processID);
            pName = Process.GetProcessById((int)processID);

            var handleList = FindChildHandleClass(pName.MainWindowHandle, ClassName);

            foreach (var item in handleList )
            {
                if (item == Handle) break;

                count++;
            }
            return new Tuple<int, int>(count, handleList.Count);
        }


        /// <summary>
        /// Loops through all controls with a specific class name
        /// </summary>
        /// <param name="hWndParent">Handle of the parent, usually the main window handle </param>
        /// <param name="className">specific classname</param>
        /// <returns>List of all controls found </returns>
        private static List<IntPtr> FindChildHandleClass(IntPtr hWndParent, string className)
        {
            List<IntPtr> childHandles = new List<IntPtr>();

            int totalControls = 256;

            IntPtr result = IntPtr.Zero;

            for (int i = 0; i < totalControls; i++)
            {
                result = pInvokes.FindWindowEx(hWndParent, result, className, null);
                if (result == IntPtr.Zero) break;
                childHandles.Add(result);
            }

            return childHandles;
        }
    }
}
