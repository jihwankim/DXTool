using System;
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
    partial class Main : Form
    {
        private void CameraZoom(object sender, MouseEventArgs e)
        {
            if (e.Delta / 120 > 0)//위로
                g_camera.EYE.z += (g_camera.EYE.z < -1.0f) ? 1 : 0;
            else //아래로
                g_camera.EYE.z -= (g_camera.EYE.z > -50.0f) ? 1 : 0;
        }

        private void KeyboardInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            char input = Char.ToUpper(e.KeyChar);
            
            // Camera Move
            if (input == 'W') // FORWARD
                g_camera.Move(g_camera.LOOK.x, g_camera.LOOK.y, g_camera.LOOK.z);
            else if (input == 'S') // BACKWARD
                g_camera.Move(-g_camera.LOOK.x, -g_camera.LOOK.y, -g_camera.LOOK.z);
            else if (input == 'A') // LEFT
            {
                VECTOR3 ver = VECTOR3.CrossProduct(g_camera.UP, g_camera.LOOK);
                g_camera.Move(-ver.x, -ver.y, -ver.z);
            }
            else if (input == 'D') // RIGHT
            {
                VECTOR3 ver = VECTOR3.CrossProduct(g_camera.UP, g_camera.LOOK);
                g_camera.Move(ver.x, ver.y, ver.z);
            }
            else
                e.Handled = false;
        }
    }
    
}
