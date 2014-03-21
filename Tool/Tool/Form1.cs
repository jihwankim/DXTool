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
            public static extern void Cleanup();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void InitGeometry();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool BeginScene();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void EndScene();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void SetupLights();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void SetupMatrices(float tx, float ty, float tz, float rx, float ry, float rz);

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void SetupCamera();

            [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DrawCylinder();
        }

        bool IsRunning = true;

        public Form1()
        {
            InitializeComponent();

            DirectX.InitD3D(this.View.Handle.ToInt32());
            DirectX.InitGeometry();

            Render();
        }

        private float GetNumber(object target)
        {
            if (((TextBox)target).TextLength == 0)
                 ((TextBox)target).Text = "0";

            return Convert.ToSingle(((TextBox)target).Text) / 100.0f;
        }

        private async void Render()
        {
            D3DObject Cylinder = new D3DObject(0);

            while(IsRunning)
            {
                Cylinder.tx = GetNumber(CylinderPosX);
                Cylinder.ty = GetNumber(CylinderPosY);
                Cylinder.tz = GetNumber(CylinderPosZ);

                Cylinder.rx += GetNumber(CylinderRotateX);
                Cylinder.ry += GetNumber(CylinderRotateY);
                Cylinder.rz += GetNumber(CylinderRotateZ);
                
                DirectX.BeginScene();

                DirectX.SetupCamera();
                DirectX.SetupLights();
                DirectX.SetupMatrices(Cylinder.tx, Cylinder.ty, Cylinder.tz, Cylinder.rx, Cylinder.ry, Cylinder.rz);

                DirectX.DrawCylinder();

                DirectX.EndScene();

                await Task.Delay(10);
            }
        }

        private void IsNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;        
        }

        private void Release(object sender, FormClosingEventArgs e)
        {
            IsRunning = false;
            DirectX.Cleanup();
        }
    }

    public class D3DObject
    {
        public D3DObject(int _index)
        {
            index = _index;
            tx = ty = tz = 0.0f;
            rx = ry = rz = 0.0f;
        }

        public int index;
        public float tx, ty, tz;
        public float rx, ry, rz;
    }
}
