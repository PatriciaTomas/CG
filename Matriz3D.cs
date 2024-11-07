using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desenhaFaces_v1
{
    class Matriz3D
    {
        public float[,] m = new float[4, 4];

        //construtor por omissão;
        public Matriz3D()
        {
            this.m[0, 0] = this.m[0, 1] = this.m[0, 2] = this.m[0, 3] = 0.0f;
            this.m[1, 0] = this.m[1, 1] = this.m[1, 2] = this.m[1, 3] = 0.0f;
            this.m[2, 0] = this.m[2, 1] = this.m[2, 2] = this.m[2, 3] = 0.0f;
            this.m[3, 0] = this.m[3, 1] = this.m[3, 2] = this.m[3, 3] = 0.0f;
        }

        //construtor com parâmetros;
        public Matriz3D(float m00, float m01, float m02, float m03,
                        float m10, float m11, float m12, float m13,
                        float m20, float m21, float m22, float m23,
                        float m30, float m31, float m32, float m33)
        {
            this.m[0, 0] = m00; this.m[0, 1] = m01; this.m[0, 2] = m02; this.m[0, 3] = m03;
            this.m[1, 0] = m10; this.m[1, 1] = m11; this.m[1, 2] = m12; this.m[1, 3] = m13;
            this.m[2, 0] = m20; this.m[2, 1] = m21; this.m[2, 2] = m22; this.m[2, 3] = m23;
            this.m[3, 0] = m30; this.m[3, 1] = m31; this.m[3, 2] = m32; this.m[3, 3] = m33;
        }

        //construtor
        public Matriz3D(float[,] m)
        {
            this.m[0, 0] = m[0, 0];
            this.m[0, 1] = m[0, 1];
            this.m[0, 2] = m[0, 2];
            this.m[0, 3] = m[0, 3];
            this.m[1, 0] = m[1, 0];
            this.m[1, 1] = m[1, 1];
            this.m[1, 2] = m[1, 2];
            this.m[1, 3] = m[1, 3];
            this.m[2, 0] = m[2, 0];
            this.m[2, 1] = m[2, 1];
            this.m[2, 2] = m[2, 2];
            this.m[2, 3] = m[2, 3];
            this.m[3, 0] = m[3, 0];
            this.m[3, 1] = m[3, 1];
            this.m[3, 2] = m[3, 2];
            this.m[3, 3] = m[3, 3];
        }

        // constrói a matriz identidade
        public void Identidade()
        {
            this.m[0, 0] = 1.0f;
            this.m[1, 1] = 1.0f;
            this.m[2, 2] = 1.0f;
            this.m[3, 3] = 1.0f;

            this.m[0, 1] = this.m[0, 2] = this.m[0, 3] = 0.0f;
            this.m[1, 0] = this.m[1, 2] = this.m[1, 3] = 0.0f;
            this.m[2, 0] = this.m[2, 1] = this.m[2, 3] = 0.0f;
            this.m[3, 0] = this.m[3, 1] = this.m[3, 2] = 0.0f;
        }

        //sobrecarga do operador * para multiplicação de matrizes
        public static Matriz3D operator *(Matriz3D m1, Matriz3D m2)
        {
            return new Matriz3D((m1.m[0, 0] * m2.m[0, 0]) + (m1.m[0, 1] * m2.m[1, 0]) + (m1.m[0, 2] * m2.m[1, 0]) + (m1.m[0, 3] * m2.m[3, 0]),
                                (m1.m[0, 0] * m2.m[0, 1]) + (m1.m[0, 1] * m2.m[1, 1]) + (m1.m[0, 2] * m2.m[1, 1]) + (m1.m[0, 3] * m2.m[3, 1]),
                                (m1.m[0, 0] * m2.m[0, 2]) + (m1.m[0, 1] * m2.m[1, 2]) + (m1.m[0, 2] * m2.m[1, 2]) + (m1.m[0, 3] * m2.m[3, 2]),
                                (m1.m[0, 0] * m2.m[0, 3]) + (m1.m[0, 1] * m2.m[1, 3]) + (m1.m[0, 2] * m2.m[1, 3]) + (m1.m[0, 3] * m2.m[3, 3]),
                                (m1.m[1, 0] * m2.m[0, 0]) + (m1.m[1, 1] * m2.m[1, 0]) + (m1.m[1, 2] * m2.m[1, 0]) + (m1.m[1, 3] * m2.m[3, 0]),
                                (m1.m[1, 0] * m2.m[0, 1]) + (m1.m[1, 1] * m2.m[1, 1]) + (m1.m[1, 2] * m2.m[1, 1]) + (m1.m[1, 3] * m2.m[3, 1]),
                                (m1.m[1, 0] * m2.m[0, 2]) + (m1.m[1, 1] * m2.m[1, 2]) + (m1.m[1, 2] * m2.m[1, 2]) + (m1.m[1, 3] * m2.m[3, 2]),
                                (m1.m[1, 0] * m2.m[0, 3]) + (m1.m[1, 1] * m2.m[1, 3]) + (m1.m[1, 2] * m2.m[1, 3]) + (m1.m[1, 3] * m2.m[3, 3]),
                                (m1.m[2, 0] * m2.m[0, 0]) + (m1.m[2, 1] * m2.m[1, 0]) + (m1.m[2, 2] * m2.m[1, 0]) + (m1.m[2, 3] * m2.m[3, 0]),
                                (m1.m[2, 0] * m2.m[0, 1]) + (m1.m[2, 1] * m2.m[1, 1]) + (m1.m[2, 2] * m2.m[1, 1]) + (m1.m[2, 3] * m2.m[3, 1]),
                                (m1.m[2, 0] * m2.m[0, 2]) + (m1.m[2, 1] * m2.m[1, 2]) + (m1.m[2, 2] * m2.m[1, 2]) + (m1.m[2, 3] * m2.m[3, 2]),
                                (m1.m[2, 0] * m2.m[0, 3]) + (m1.m[2, 1] * m2.m[1, 3]) + (m1.m[2, 2] * m2.m[1, 3]) + (m1.m[2, 3] * m2.m[3, 3]),
                                (m1.m[3, 0] * m2.m[0, 0]) + (m1.m[3, 1] * m2.m[1, 0]) + (m1.m[3, 2] * m2.m[1, 0]) + (m1.m[3, 3] * m2.m[3, 0]),
                                (m1.m[3, 0] * m2.m[0, 1]) + (m1.m[3, 1] * m2.m[1, 1]) + (m1.m[3, 2] * m2.m[1, 1]) + (m1.m[3, 3] * m2.m[3, 1]),
                                (m1.m[3, 0] * m2.m[0, 2]) + (m1.m[3, 1] * m2.m[1, 2]) + (m1.m[3, 2] * m2.m[1, 2]) + (m1.m[3, 3] * m2.m[3, 2]),
                                (m1.m[3, 0] * m2.m[0, 3]) + (m1.m[3, 1] * m2.m[1, 3]) + (m1.m[3, 2] * m2.m[1, 3]) + (m1.m[3, 3] * m2.m[3, 3]));
        }

        // Retorna a multiplicação da matriz por um vector coluna
        public float[] multiplicaVector(float[] vector)
        {
            float[] v = new float[4];
            v[0] = (this.m[0, 0] * vector[0]) + (this.m[0, 1] * vector[1]) + (this.m[0, 2] * vector[2]) + (this.m[0, 3] * vector[3]);
            v[1] = (this.m[1, 0] * vector[0]) + (this.m[1, 1] * vector[1]) + (this.m[1, 2] * vector[2]) + (this.m[1, 3] * vector[3]);
            v[2] = (this.m[2, 0] * vector[0]) + (this.m[2, 1] * vector[1]) + (this.m[2, 2] * vector[2]) + (this.m[2, 3] * vector[3]);
            v[3] = (this.m[3, 0] * vector[0]) + (this.m[3, 1] * vector[1]) + (this.m[3, 2] * vector[2]) + (this.m[3, 3] * vector[3]);
            return v;
        }

        //Constrói a matriz Variação de Escala - formulário
        public static Matriz3D escala(float sx, float sy, float sz)
        {
            return new Matriz3D(sx, 0, 0, 0, 0, sy, 0, 0, 0, 0, sz, 0, 0, 0, 0, 1);
        }

        //Constrói a matriz Translação - formulário
        public static Matriz3D translacao(float tx, float ty, float tz)
        {
            return new Matriz3D(1.0f, 0.0f, 0.0f, tx, 0.0f, 1.0f, 0.0f, ty, 0.0f, 0.0f, 1.0f, tz, 0.0f, 0.0f, 0.0f, 1.0f);
        }

        //Constrói a matriz Rotação em torno do eixo X - form
        public static Matriz3D rotacaoX(float theta)
        {
            theta = (theta * 3.141593f) / 180f; //Passar o valor inserido para radianos 
            float cos = (float)Math.Cos((double)theta);
            float sen = (float)Math.Sin((double)theta);

            return new Matriz3D(1.0f, 0.0f, 0.0f, 0.0f, 0.0f, cos, -sen, 0.0f, 0.0f, sen, cos, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);
        }

        //Constrói a matriz Rotação em torno do eixo Y
        public static Matriz3D rotacaoY(float theta)
        {
            theta = (theta * 3.141593f) / 180f;
            float cos = (float)Math.Cos((double)theta);
            float sen = (float)Math.Sin((double)theta);

            return new Matriz3D(cos, 0.0f, sen, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, -sen, 0.0f, cos, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);
        }

        //Constrói a matriz Rotação em torno do eixo Z
        public static Matriz3D rotacaoZ(float theta)
        {
            theta = (theta * 3.141593f) / 180f;
            float cos = (float)Math.Cos((double)theta);
            float sen = (float)Math.Sin((double)theta);

            return new Matriz3D(cos, -sen, 0.0f, 0.0f, sen, cos, 0.0f, 0.0f, 0.0f, 0.0f, 1, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);
        }

        // constrói a matriz de Projecção Paralela (Mort)
        public static Matriz3D projParalela()
        {
            return new Matriz3D(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
        }

        // constrói a matriz de Projecção Perspectiva
        public static Matriz3D projPerspectiva(float d)
        {
            return new Matriz3D(1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, (-1.0f / d), 1.0f);
        }

        //converter em string
        public override string ToString()
        {
            string res = "[" + this.m[0, 0] + this.m[0, 1] + this.m[0, 2] + this.m[0, 3] + "]\n" +
                         "[" + this.m[1, 0] + this.m[1, 1] + this.m[1, 2] + this.m[1, 3] + "]\n" +
                         "[" + this.m[2, 0] + this.m[2, 1] + this.m[2, 2] + this.m[2, 3] + "]\n" +
                         "[" + this.m[3, 0] + this.m[3, 1] + this.m[3, 2] + this.m[3, 3] + "]\n";
            return res;
        }
    }
}
