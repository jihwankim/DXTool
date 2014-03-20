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
        // Core Project에서 빌드한 DLL을 이용해 외부 함수 사용을 위한 클래스
        public class DirectX
        {
            // Calling Convention을 맞춰준다
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
