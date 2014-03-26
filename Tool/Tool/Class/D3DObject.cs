using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    // VECTOR
    public struct VECTOR3
    {
        public VECTOR3(float vx, float vy, float vz) { x = vx; y = vy; z = vz; }//{ _x = vx; _y = vy; _z = vz; }

        public float x, y, z;
        public void Set(float vx, float vy, float vz)
        {
            x = vx;
            y = vy;
            z = vz;
        }
        public void Add(float vx, float vy, float vz)
        {
            x += vx;
            y += vy;
            z += vz;
        }
        public void Multi(float vx, float vy, float vz)
        {
            x *= vx;
            y *= vy;
            z *= vz;
        }
        public float GetLength()
        {
            return (float)Math.Sqrt(Math.Pow(x, 2.0f) + Math.Pow(y, 2.0f) + Math.Pow(z, 2.0f));
        }
        static public VECTOR3 CrossProduct(VECTOR3 a, VECTOR3 b)
        {
            float len;
            VECTOR3 result = new VECTOR3();
            result.x = a.y * b.z - a.z * b.y;
            result.y = -a.x * b.z + a.z * b.x;

            result.z = a.x * b.y - a.y * b.x;

            len = result.GetLength();
            result.Multi(1 / len, 1 / len, 1 / len);
            return result;
        }
        //private float _x, _y, _z;
//         public float x
//         {
//             get { return _x; }
//             set
//             {
//                 _x += value;
//                 if (_x > 360.0f)
//                     _x %= 360.0f;
//             }
//         }
//         public float y
//         {
//             get { return _y; }
//             set
//             {
//                 _y += value;
//                 if (_y > 360.0f)
//                     _y %= 360.0f;
//             }
//         }
//         public float z
//         {
//             get { return _z; }
//             set
//             {
//                 _z += value;
//                 if (_z > 360.0f)
//                     _z %= 360.0f;
//             }
//         }
    }
    public struct CAMERA
    {
        public CAMERA(float ex, float ey, float ez, float lx, float ly, float lz, float ux, float uy, float uz)
        {
            EYE = new VECTOR3(ex, ey, ez);
            TARGET = new VECTOR3(lx, ly, lz);
            UP = new VECTOR3(ux, uy, uz);
            LOOK = new VECTOR3();
            RIGHT = new VECTOR3();

            UpdateLook();
        }
        public void Move(float x, float y, float z)
        {
            EYE.Add(x, y, z);
            TARGET.Add(x, y, z);
            /*
            EYE.x += x;
            TARGET.x += x;

            EYE.y += y;
            TARGET.y += y;

            EYE.z += z;
            TARGET.z += z;*/
        }
        public void Rotate(float x, float y, float z)
        {
            TARGET.Add(x, y, z);
            UpdateLook();
            /*
            TARGET.x += x;
            TARGET.y += y;
            TARGET.z += z;
            */
        }
        private void UpdateLook()
        {
          
            float x, y, z;

            x = TARGET.x - EYE.x;
            y = TARGET.y - EYE.y;
            z = TARGET.z - EYE.z;
           

            //float len = (float)Math.Sqrt(Math.Pow(x, 2.0f) + Math.Pow(y, 2.0f) + Math.Pow(z, 2.0f));
            float len = Math.Abs(TARGET.GetLength() - EYE.GetLength());
            LOOK.Set(x / len, y / len, z / len);
        }

        public VECTOR3 EYE;// = new VECTOR3();
        public VECTOR3 TARGET;// = new VECTOR3();
        public VECTOR3 UP;// = new VECTOR3();
        public VECTOR3 LOOK;// = new VECTOR3();
        public VECTOR3 RIGHT;// = new VECTOR3();
    }

    // Object
    public class D3DObject
    {
        public int index;
        public VECTOR3 trans, rotate;

        public D3DObject(int _index)
        {
            index = _index;
//             tx = ty = tz = 0.0f;
//             rx = ry = rz = 0.0f;
        }
        public void Rotate(float x, float y, float z, bool Init=false)
        {
            if (Init)
                rotate.x = rotate.y = rotate.z = 0.0f;

            rotate.x += x;
            rotate.y += y;
            rotate.z += z;
        }
        public void Translaste(float x, float y, float z, bool Init = true)
        {
            if (Init)
                trans.x = trans.y = trans.z = 0.0f;

            trans.x += x;
            trans.y += y;
            trans.z += z;
        }

        
        //public float tx, ty, tz;
        //public float rx, ry, rz;
    }
}
