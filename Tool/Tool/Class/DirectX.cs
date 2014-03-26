using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Tool
{
    public class DirectX
    {
        // Core Library Functions
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
        public static extern void SetupCamera(float ex, float ey, float ez, float lx, float ly, float lz, float ux, float uy, float uz);

        [DllImport("Core.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawCylinder();

        // Overriding 
        public static void SetupMatrices(D3DObject obj)
        {
            SetupMatrices(obj.trans.x, obj.trans.y, obj.trans.z, obj.rotate.x, obj.rotate.y, obj.rotate.z);
        }
        public static void SetupCamera(CAMERA camera)
        {
            SetupCamera(camera.EYE.x, camera.EYE.y, camera.EYE.z, camera.TARGET.x, camera.TARGET.y, camera.TARGET.z, camera.UP.x, camera.UP.y, camera.UP.z);
        }
    }
}
