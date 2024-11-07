using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desenhaFaces_v1
{
    internal class Face
    {
        private ArrayList vertices3D;
    
        public Face()
        {
            InicializaFace();
        }
        private void InicializaFace()
        {
            this.vertices3D = new ArrayList();
        }
        public Face(ArrayList vertices3D)
        {
            InicializaFace();
            this.vertices3D = vertices3D;
        }
        public ArrayList GetVerticesFace()
        {
            return this.vertices3D;
        }

        public void SaveVertice(Vector3D v)
        {
            vertices3D.Add(v);
        }

        public PointF[] GetVertices2D(float largura, float altura)
        {
            PointF[] pontos2D=new PointF[vertices3D.Count];
            for (int i = 0; i < vertices3D.Count; i++)
            {
                Vector3D v=(Vector3D)vertices3D[i];
                pontos2D[i] = v.ConvertePontoJanelaToViewport(largura, altura);// converte o ponto da janela para o viewport
            }

            return pontos2D;
        }


       /* public float backFaceCulling()
        {
            // V^N Para a determinação das faces traseiras, basta
           // calcular o sinal da projeção(produto interno) da
           //normal de cada superfície com a direção de
         //observação(normalmente o eixo Z),
            Vector3D v1 = (Vector3D)vertices3D[1] - (Vector3D)vertices3D[0];
            Vector3D v2 = (Vector3D)vertices3D[2] - (Vector3D)vertices3D[0];
            Vector3D vn = v1 ^ v2;
            //return v1;
            Vector3D camara = new Vector3D(0.0f, 0.0f, 600.0f);

            Vector3D backface = (Vector3D)vertices3D[0] - camara;
            float total = (backface * vn);
            //Console.WriteLine("vert1: " + vertices3D[0] + " , vert2" + vertices3D[1] + ",\n v1: "+v1 + ", v2: " + v2 + ", vn: " + vn);
            return total;
        }*/




    }
}
