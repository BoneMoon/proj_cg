using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace trabalho_cg_tema2
{
    class Vector3D
    {
        public float x, y, z, w; 

        public Vector3D()
        {
            this.x = 0.0f; this.y = 0.0f; this.z = 0.0f; this.w = 1.0f;
        }

        public Vector3D(Vector3D v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 1.0f;
        }
        public Vector3D(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }


        public Vector3D clone()
        {
            return new Vector3D(this.x, this.y, this.z, this.w);
        }


        public float getX()
        {
            return this.x;
        }

        public float getY()
        {
            return this.y;
        }

        public float getZ()
        {
            return this.z;
        }

        public void setX(float x)
        {
            this.x = x;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public void setZ(float z)
        {
            this.z = z;
        }
        public void set(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public bool Equals(Vector3D v)
        {
            if (v.x == this.x && v.y == this.y && v.z == this.z && v.w == this.w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Vector3D operator +(Vector3D v)
        {
            return v;
        }

        public static Vector3D operator -(Vector3D v)
        {
            float x1, y1, z1, w1;
            x1 = -v.x;
            y1 = -v.y;
            z1 = -v.z;
            w1 = v.w;
            return new Vector3D(x1, y1, z1, w1);
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w);
        }

        public static Vector3D operator *(Vector3D v, float c)
        {
            float x1, y1, z1, w1;
            x1 = c * v.x;
            y1 = c * v.y;
            z1 = c * v.z;
            w1 = v.w;
            return new Vector3D(x1, y1, z1, w1);
        }

        public static Vector3D operator %(Vector3D v1, Vector3D v2)
        {
            Vector3D r = new Vector3D();
            r.x = v1.x * v2.x;
            r.y = v1.y * v2.y;
            r.z = v1.z * v2.z;
            r.w = v1.w * v2.w;
            return r;

        }

        public static Vector3D operator /(Vector3D v, float c)
        {
            float x1, y1, z1, w1;
            x1 = v.x / c;
            y1 = v.y / c;
            z1 = v.z / c;
            w1 = v.w;
            return new Vector3D(x1, y1, z1, w1);
        }

        public static float operator *(Vector3D v1, Vector3D v2)
        {
            float r;
            r = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            return r;
        }

        public static Vector3D operator ^(Vector3D v1, Vector3D v2)
        {
            Vector3D r = new Vector3D();
            r.x = (v1.y * v2.z - v2.y * v1.z);
            r.y = v1.z * v2.x - v1.x * v2.z;
            r.z = (v1.x * v2.y - v2.x * v1.y);
            r.w = v1.w;
            return r;
        }

        public float norm()
        {
            return (float)Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }

        public void normalize()
        {
            float n = norm();
            if (n != 0.0)
            {
                this.x = this.x / n;
                this.y = this.y / n;
                this.z = this.z / n;
            }
        }

        public override String ToString()
        {
            String res;
            res = "(" + this.x + ", " + this.y + ", " + this.z + ")";
            return res;

        }

        public void geraCoordHomogeneas(metodosMatriz3D.Matriz3D m)
        {
            float[] resultado = m.multiplicaVector(new float[] { this.x, this.y, this.z, this.w });


            this.x = resultado[0];
            this.y = resultado[1];
            this.z = resultado[2];
            this.w = resultado[3];
        }

        public void geraCoordCartesianas(metodosMatriz3D.Matriz3D m)
        {
            float[] resultado = m.multiplicaVector(new float[] { this.x, this.y, this.z, this.w });


            this.x = resultado[0] / resultado[3];
            this.y = resultado[1] / resultado[3];
            this.z = resultado[2] / resultado[3];
            this.w = 1.0f;
        }

        public PointF converteJanelaViewport(int largura, int altura)
        {
            return new PointF(largura / 2 + this.x, altura / 2 - this.y);

        }

    }
}
