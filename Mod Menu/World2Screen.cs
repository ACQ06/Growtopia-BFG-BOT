using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace World2Screen
{
    class Click
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        public static string WINDOW_NAME = "Growtopia";
        public static IntPtr hWnd = FindWindow(null, WINDOW_NAME);

        public static void TargetBlock(int x, int y)
        {
            float CameraX = Utility.Camera.X();
            float CameraY = Utility.Camera.Y();
            float ZoomFactor = Utility.Camera.ZoomFactor();

            const int WM_LBUTTONDOWN = 0x0201;
            const int WM_LBUTTONUP = 0x0202;

            int X = (int)((x * 32 - CameraX) * ZoomFactor) + 5;
            int Y = (int)((y * 32 - CameraY) * ZoomFactor) + 30;


            SendMessage(hWnd, WM_LBUTTONDOWN, new IntPtr(0x0001), (IntPtr)((Y << 16) | (X & 0xffff)));
            SendMessage(hWnd, WM_LBUTTONUP, new IntPtr(0x0001), (IntPtr)((Y << 16) | (X & 0xffff)));
        }
    }
}