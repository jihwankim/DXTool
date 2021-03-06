﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public partial class Main : Form
    {
        bool g_IsRunning = true;
        //CAMERA g_camera = new CAMERA(0.0f, 0.0f, -5.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f);
        CAMERA g_camera = new CAMERA(0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 1.0f, 0.0f);

        public Main()
        {
            InitializeComponent();

            DirectX.InitD3D(this.View.Handle.ToInt32());
            DirectX.InitGeometry();

            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(CameraZoom);

            Render();
        }
        

        private float GetNumber(object target)
        {
            float result;

            try
            {
                result = Convert.ToSingle(((TextBox)target).Text);
            }catch
            {
                ((TextBox)target).Text = "0";
                result = 0;
            }

            return result;
        }

        float ssss = 0.0f;
        private async void Render()
        {
            D3DObject Cylinder = new D3DObject(0);

            while(g_IsRunning)
            {
                Cylinder.Rotate(GetNumber(CylinderRotateX), GetNumber(CylinderRotateY), GetNumber(CylinderRotateZ));
                Cylinder.Translaste(GetNumber(CylinderPosX), GetNumber(CylinderPosY), GetNumber(CylinderPosZ));
                
                DirectX.BeginScene();

                DirectX.SetupCamera(g_camera);
                DirectX.SetupLights();
                DirectX.SetupMatrices(Cylinder);
                DirectX.DrawCylinder();

                DirectX.EndScene();


                //g_camera.TARGET.Set(0, (float)Math.Pow(Math.Sin(ssss), 2.0f), (float)Math.Acos(Math.Sqrt(1 - Math.Pow(Math.Sin(ssss), 2.0f))));
                //g_camera.Rotate(0, -0.01f, 0);
                //g_camera.TARGET.Add(0, -0.01f, 0);
                //g_camera.TARGET.Normalize();
                ssss += 0.01f;

                await Task.Delay(10);
            }
        }

        private void Release(object sender, FormClosingEventArgs e)
        {
            g_IsRunning = false;
            DirectX.Cleanup();
        }

        private void IsNumber(object sender, EventArgs e)
        {
            float result;
            if( float.TryParse(((TextBox)sender).Text, out result) == true )
                Convert.ToDouble(((TextBox)sender).Text);
            else
                ((TextBox)sender).Undo();
        }

        
    }
}
