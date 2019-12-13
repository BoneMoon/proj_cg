using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_cg_tema2
{
    class Object
    {
        private ArrayList vertices;
        private ArrayList indices;
        private ArrayList numVporFace;

        private int largura, altura;

        private Pen pen;
        private SolidBrush brush;

        private bool wireframe;

        private Stream s;

        public Object()
        {

        }

        void SetObject()
        {
            vertices = new ArrayList();
            indices = new ArrayList();
            numVporFace = new ArrayList();

            pen = new Pen(Color.Black);
            brush = new SolidBrush(Color.Silver);
            wireframe = false;
        }


    }
}
