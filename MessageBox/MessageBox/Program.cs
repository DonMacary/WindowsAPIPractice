using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using DInvoke.DynamicInvoke;

namespace MessageBox
{
    internal class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        delegate int MessageBoxW(IntPtr hWnd, string lpText, string pCaption, uint uType);


        static void Main(string[] args)
        {
            var address = Generic.GetLibraryAddress("user32.dll", 2155);
            var totallylegitAPI = (MessageBoxW)Marshal.GetDelegateForFunctionPointer(address, typeof(MessageBoxW));

            totallylegitAPI(IntPtr.Zero, "Box 1", "Box 1", 0);
            totallylegitAPI(IntPtr.Zero, "Box 2", "Box 2", 0);
        }
    }
}
