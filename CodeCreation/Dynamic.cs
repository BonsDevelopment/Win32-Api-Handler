using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32_Api_Handler.CodeCreation
{
    public static class Dynamic
    {
        private static Process pName;
        public static string GetDynamicCode(IntPtr Handle)
        {
            string CodeTemplate = String.Empty;
            Tuple<int, int> tIndex = HandleIndex(Handle);
            //check for main window handle

            if (pInvokes.GetParent(Handle) != pName.MainWindowHandle && Handle != pName.MainWindowHandle)
            {
                List<IntPtr> handleList = FindChildHandle(pName.MainWindowHandle);
                List<IntPtr> childHandleList = FindChildParent(handleList, new List<IntPtr>(),Handle);
                Tuple<int, int> childParentIndex = ChildParentIndex(childHandleList, Handle);

                CodeTemplate = Properties.Resources.DynamicCode2;
                CodeTemplate = CodeTemplate.Replace("%PROCESSNAME%", pName.ProcessName);
                CodeTemplate = CodeTemplate.Replace("%INDEX%", $"{childParentIndex.Item1}");
                CodeTemplate = CodeTemplate.Replace("%INDEX2%", $"{childParentIndex.Item2}");
                CodeTemplate = CodeTemplate.Replace("%TOTALCONTROLS%", $"256");

            }
            else
            {

                CodeTemplate = Properties.Resources.DynamicCode;

                CodeTemplate = CodeTemplate.Replace("%PROCESSNAME%", pName.ProcessName);
                CodeTemplate = CodeTemplate.Replace("%INDEX%", $"{tIndex.Item1}");
                CodeTemplate = CodeTemplate.Replace("%TOTALCONTROLS%", $"{tIndex.Item2 + 1}");
            }

            return CodeTemplate;
        }


        /// <summary>
        /// Grabs the index of the handle passed in
        /// </summary>
        /// <param name="Handle">Handle to control</param>
        /// <returns>Tuple item1: index location item2: total controls</returns>
        private static Tuple<int,int> HandleIndex(IntPtr Handle)
        {
            uint processID;
            int count = 0;

            pInvokes.GetWindowThreadProcessId(Handle, out processID);
            pName = Process.GetProcessById((int)processID);

            if (Handle != pName.MainWindowHandle)
            {
                foreach (var item in FindChildHandle(pName.MainWindowHandle))
                {
                    if (item == Handle) break;

                    count++;
                }
            }

            return new Tuple<int, int>(count, FindChildHandle(pName.MainWindowHandle).Count());
        }




        /// <summary>
        /// Loops through every control on the parent
        /// </summary>
        /// <param name="hWndParent"> Main window handle</param>
        /// <returns>Every child control</returns>
        private static List<IntPtr> FindChildHandle(IntPtr hWndParent)
        {
            List<IntPtr> childHandles = new List<IntPtr>();

            int totalControls = 256;

            IntPtr result = IntPtr.Zero;

            for (int i = 0; i < totalControls; i++)
            {
                result = pInvokes.FindWindowEx(hWndParent, result, null, null);
                if (result == IntPtr.Zero) break;
                childHandles.Add(result);
            }

            return childHandles;
        }

        private static Tuple<int,int> ChildParentIndex(List<IntPtr> handleList, IntPtr Handle)
        {
            int parentIndex = 0;
            int childIndex = 0;
            foreach (var item in handleList)
            {
                Console.WriteLine(item);
                if (item == pInvokes.GetParent(Handle))
                {
                    foreach (var item2 in FindChildHandle(item))
                    {
                        if (item2 == Handle)
                        {
                            break;
                        }
                        childIndex++;
                    }
                    break;
                }
                parentIndex++;
            }
            return new Tuple<int,int>(parentIndex, childIndex);
        }

        /// <summary>
        /// Grabs all child parents
        /// </summary>
        /// <param name="hWndList">list of handles</param>
        /// <param name="returnList">the list to return</param>
        /// <returns></returns>
        private static List<IntPtr> FindChildParent(List<IntPtr> hWndList, List<IntPtr> returnList, IntPtr Handle)
        {
            foreach (var handle in hWndList)
            {
                var childLoop = FindChildHandle(handle);

                if (childLoop.Count >= 1)
                {
                    foreach (var subhandle in childLoop)
                    {
                        returnList.Add(subhandle);
                        if (subhandle == pInvokes.GetParent(Handle))
                            return returnList;
                    }
                }
                FindChildParent(childLoop, returnList,Handle);
            }
            return returnList;
        }

    }
}
