using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tool
{
    public partial class Form1 : Form
    {
        public class DirectX
        {
            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void InitD3D(Int32 hWnd);

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Render();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Cleanup();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void InitGeometry();
        }

        public Form1()
        {
            InitializeComponent();

            DirectX.InitD3D(this.Handle.ToInt32());
            DirectX.InitGeometry();

            Render();
        }

        private async void Render()
        {
            while(true)
            {
                DirectX.Render();
                await Task.Delay(10);
            }
        }
    }
}
