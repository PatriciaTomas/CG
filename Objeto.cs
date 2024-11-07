
//Desenho de Faces Poligonais - versão 2.0 - Aplicar translações e rotações aos objetos (o objeto deve ser definido centrado nos eixos coordenados) + leitura do objeto a partir de ficheiro

using System;
using System.Collections; //para usar o ArrayList
using System.Collections.Generic;
using System.Diagnostics; // para usar o Debug
using System.Drawing; //para usar a pen e o brush
using System.IO; //para usar as streams
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using metodosMatriz3D; //implementa a classe Matriz3D


namespace desenhaFaces_v1
{
    public class Objeto
    {
        private ArrayList vertices; // array para guardar os vértices 3D do objecto
        private ArrayList indicesFaces;// array para guardar os índices dos vértices das faces do objecto
        private ArrayList numvPorFace; // array para guardar o número de vértices por face (podemos ter faces com número diferente de vértices)

        private float larguraDesenho;// largura da janela usada para definir a largura da janela
        private float alturaDesenho; // altura da janela usada para definir a altura da janela de desenho

        private float centroProjeccaoY;
        private float centroProjeccaoX;

        private Pen penContorno; // pen usada para o contorno do objecto
        private SolidBrush brushPreenchimento; // brush usado para a cor de fundo do objecto

        private bool wireframe; // define se vai ser usado com preenchimento ou em linha de arame

        private Stream s; // stream para carregar os dados do ficheiro, no caso da estrutura do objeto ser lida a partir de um ficheiro

        private int faceDesenhada;
        private int nrFaces;

        private char projecao;
        public string nomeModelo;

        public string OrdemTransformacoes1 { get; set; }
        public string OrdemTransformacoes2 { get; set; } 

        // Construtor
        public Objeto()
        {
            InicializaObjeto();
            nomeModelo= "Desconhecido";
        }

        // Método de Inicialização
        private void InicializaObjeto()
        {
            this.vertices = new ArrayList();
            this.indicesFaces = new ArrayList();
            this.numvPorFace = new ArrayList();

            penContorno = new Pen(Color.Black, 3);
            brushPreenchimento = new SolidBrush(Color.SteelBlue);

            this.wireframe = false; //no início é desenhado com preenchimento

            this.projecao = '1'; 

            //Quadrado();

            Cubo();

            //PiramideQuadrangular();

            //PiramideHexagonal();

            // PrismaPentagonal();


        }
        /*------------------Métodos para criar Modelos ------------------------------*/

        #region Quadrado
        private void Quadrado()
        {
            //uma face quadrada

            vertices.Add(new Vector3D(-60, -60, 60));
            vertices.Add(new Vector3D(60, -60, 60));
            vertices.Add(new Vector3D(60, 60, 60));
            vertices.Add(new Vector3D(-60, 60, 60));

            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(2);
            indicesFaces.Add(3);

            numvPorFace.Add(4);

            // Debug.WriteLine("num vértices da face " + indicesFaces.Count);

            nomeModelo = "Quadrado";
        }


        #endregion


        #region cubo
        private void Cubo()
        {

           //vértices
            vertices.Add(new Vector3D(-60, -60, 60));  // v0
            vertices.Add(new Vector3D(60, -60, 60));   // v1
            vertices.Add(new Vector3D(-60, 60, 60));   // v2
            vertices.Add(new Vector3D(60, 60, 60));    // v3
            vertices.Add(new Vector3D(-60, 60, -60));  // v4
            vertices.Add(new Vector3D(60, 60, -60));   // v5
            vertices.Add(new Vector3D(-60, -60, -60)); // v6
            vertices.Add(new Vector3D(60, -60, -60));  // v7

            // Face frente
            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(3);
            indicesFaces.Add(2);

            numvPorFace.Add(4);

            
            // Face cima
            indicesFaces.Add(2);
            indicesFaces.Add(3);
            indicesFaces.Add(5);
            indicesFaces.Add(4);

            numvPorFace.Add(4);

            
            // Face direita
            indicesFaces.Add(1);
            indicesFaces.Add(7);
            indicesFaces.Add(5);
            indicesFaces.Add(3);

            numvPorFace.Add(4);

            
            // Face esquerda
            indicesFaces.Add(0);
            indicesFaces.Add(2);
            indicesFaces.Add(4);
            indicesFaces.Add(6);

            numvPorFace.Add(4);


            // Face trás
            indicesFaces.Add(6);
            indicesFaces.Add(4);
            indicesFaces.Add(5);
            indicesFaces.Add(7);

            numvPorFace.Add(4);

            // Face baixo
            indicesFaces.Add(0);
            indicesFaces.Add(6);
            indicesFaces.Add(7);
            indicesFaces.Add(1);

            numvPorFace.Add(4);

            nomeModelo = "Cubo";


        }

        #endregion

        #region piramide Quadrangular
        private void PiramideQuadrangular()
        {
            //vértices
            vertices.Add(new Vector3D(-60, -60, 60));  // v0
            vertices.Add(new Vector3D(60, -60, 60));   // v1
            vertices.Add(new Vector3D(60, -60, -60));   // v2
            vertices.Add(new Vector3D(-60, -60, -60));    // v3
            vertices.Add(new Vector3D(0, 60, 0));  // v4

            // Face tras
            indicesFaces.Add(3);
            indicesFaces.Add(4);
            indicesFaces.Add(2);

            numvPorFace.Add(3);

            // Face esquerda
            indicesFaces.Add(0);
            indicesFaces.Add(4);
            indicesFaces.Add(3);

            numvPorFace.Add(3);

            // Face baixo
            indicesFaces.Add(0);
            indicesFaces.Add(3);
            indicesFaces.Add(2);
            indicesFaces.Add(1);

            numvPorFace.Add(4);

            // Face direita
            indicesFaces.Add(1);
            indicesFaces.Add(2);
            indicesFaces.Add(4);

            numvPorFace.Add(3);

            // Face frente
            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(4);

            numvPorFace.Add(3);
            nomeModelo = "Piramide Quadrangular";
        }
        #endregion


        #region piramide hexagonal
        private void PiramideHexagonal()
        {
            //vértices
            vertices.Add(new Vector3D(60, -60, -30));  // v0
            vertices.Add(new Vector3D(0, -60, -60));   // v1
            vertices.Add(new Vector3D(-60, -60, -30));   // v2
            vertices.Add(new Vector3D(-60, -60, 30));    // v3
            vertices.Add(new Vector3D(0, -60, 60));  // v4
            vertices.Add(new Vector3D(60, -60, 30)); // v5
            vertices.Add(new Vector3D(0, 60, 0)); // v6

            // Face 1
            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(6);

            numvPorFace.Add(3);

            // Face 2
            indicesFaces.Add(1);
            indicesFaces.Add(2);
            indicesFaces.Add(6);

            numvPorFace.Add(3);

            // Face 3
            indicesFaces.Add(2);
            indicesFaces.Add(3);
            indicesFaces.Add(6);

            numvPorFace.Add(3);

            // Face 4
            indicesFaces.Add(3);
            indicesFaces.Add(4);
            indicesFaces.Add(6);

            numvPorFace.Add(3);

            // Face 5
            indicesFaces.Add(4);
            indicesFaces.Add(5);
            indicesFaces.Add(6);

            numvPorFace.Add(3);

            // Face 6
            indicesFaces.Add(5);
            indicesFaces.Add(0);
            indicesFaces.Add(6);

            numvPorFace.Add(3);

            // base
            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(2);
            indicesFaces.Add(3);
            indicesFaces.Add(4);
            indicesFaces.Add(5);

            numvPorFace.Add(6);

            nomeModelo = "Piramide Hexagonal";

        }
        #endregion


        #region prisma pentagonal
        private void PrismaPentagonal()
        {
            //vÃ©rtices
            vertices.Add(new Vector3D(-40, -60, 60));  // v0
            vertices.Add(new Vector3D(40, -60, 60));   // v1
            vertices.Add(new Vector3D(60, -60, 0));   // v2
            vertices.Add(new Vector3D(0, -60, -40));    // v3
            vertices.Add(new Vector3D(-60, -60, 0));  // v4
            vertices.Add(new Vector3D(-40, 60, 60)); // v5
            vertices.Add(new Vector3D(40, 60, 60)); // v6
            vertices.Add(new Vector3D(60, 60, 0));  // v7
            vertices.Add(new Vector3D(0, 60, -40));   // v8
            vertices.Add(new Vector3D(-60, 60, 0));   // v9

            // Face de baixo
            indicesFaces.Add(1);
            indicesFaces.Add(0);
            indicesFaces.Add(4);
            indicesFaces.Add(3);
            indicesFaces.Add(2);

            numvPorFace.Add(5);

            // Face lateral 1
            indicesFaces.Add(3);
            indicesFaces.Add(8);
            indicesFaces.Add(7);
            indicesFaces.Add(2);

            numvPorFace.Add(4);

            // Face lateral 2
            indicesFaces.Add(4);
            indicesFaces.Add(9);
            indicesFaces.Add(8);
            indicesFaces.Add(3);

            numvPorFace.Add(4);

            // Face lateral 3
            indicesFaces.Add(0);
            indicesFaces.Add(5);
            indicesFaces.Add(9);
            indicesFaces.Add(4);

            numvPorFace.Add(4);

            // Face lateral 4
            indicesFaces.Add(1);
            indicesFaces.Add(2);
            indicesFaces.Add(7);
            indicesFaces.Add(6);

            numvPorFace.Add(4);

            //// Face lateral 5
            indicesFaces.Add(0);
            indicesFaces.Add(1);
            indicesFaces.Add(6);
            indicesFaces.Add(5);

            numvPorFace.Add(4);

            // Face de cima
            indicesFaces.Add(5);
            indicesFaces.Add(6);
            indicesFaces.Add(7);
            indicesFaces.Add(8);
            indicesFaces.Add(9);

            numvPorFace.Add(5);

            nomeModelo = "Piramide Pentagonal";


        }

        #endregion


        #region cilindro
        public void Cilindro(float cilindroAltura, float cilindroRaio, float cilindroNumFaces)
        {
            // Cálculo do ângulo entre as faces do cilindro
            var angStep = (float)(Math.PI * 2d) / cilindroNumFaces;
            // Inicialização do ângulo de início (meio do círculo)
            var startAng = (Math.PI) / 2d;
            // Listas para armazenar os vértices do cilindro
            var vectCima = new ArrayList();
            var vectBaixo = new ArrayList();

            // Loop para criar os vértices do cilindro
            for (int i = 0; i < cilindroNumFaces; i += 1)
            {  
                // Criação de vértices na base do cilindro
                vectBaixo.Add(new Vector3D((float)(cilindroRaio * Math.Cos(startAng)), (float)(-cilindroAltura), (float)(cilindroRaio * Math.Sin(startAng))));

                // Criação de vértices no topo do cilindro
                vectCima.Add(new Vector3D((float)(cilindroRaio * Math.Cos(startAng)), (float)(cilindroAltura), (float)(cilindroRaio * Math.Sin(startAng))));

                //Incremento do Angulo
                startAng += angStep;

            }

            // Adiciona os vértices à lista de vértices da instância atual
            this.vertices.AddRange(vectBaixo);
            this.vertices.AddRange(vectCima);

            // Índices para as faces do cilindro
            int j = ((int)vectBaixo.Count);
            int k = j + 1;

            // Adiciona os índices para a base do cilindro
            for (int i = 0; i < ((int)vectBaixo.Count); i++)
            {
                this.indicesFaces.Add(i);
            }

            numvPorFace.Add(((int)vectBaixo.Count));

            // Adiciona os índices para as faces laterais do cilindro
            for (int i = 0; i < ((int)vectBaixo.Count) - 1; i++)
            {


                indicesFaces.Add(i);
                indicesFaces.Add(i + 1);

                indicesFaces.Add(k + i);
                indicesFaces.Add(j + i);

                numvPorFace.Add(4);


            }

            // Adiciona os índices para a última face lateral
            indicesFaces.Add(j - 1);
            indicesFaces.Add(0);
            indicesFaces.Add(j);
            indicesFaces.Add(j + (j - 1));
            numvPorFace.Add(4);

            // Adiciona os índices para o topo do cilindro
            indicesFaces.Add(((int)vectBaixo.Count));

            // Adiciona os índices para as faces superiores e inferiores do cilindro
            for (int i = ((int)vectBaixo.Count) + 1; i < vertices.Count; i++)
            {
                this.indicesFaces.Add(i);
            }
            numvPorFace.Add(((int)vectBaixo.Count));

            // Define o nome do modelo como "Cilindro"
            nomeModelo = "Cilindro";

        }

        #endregion
        /*--------------------------------Métodos para configurar objetos ----------------------------------------------*/
        public void SetCubo(float centroX, float centroY)
        {
            SetCentroProjeccao(centroX, centroY);
            Cubo();
        }

        public void setPiramideQuadrangular(float centroX, float centroY)
        {
            SetCentroProjeccao(centroX, centroY);
            PiramideQuadrangular();
        }

        public void setPiramideHexagonal(float centroX, float centroY)
        {
            SetCentroProjeccao(centroX, centroY);
            PiramideHexagonal();
        }

        public void setPrismaPentagonal(float centroX, float centroY)
        {
            SetCentroProjeccao(centroX, centroY);
            PrismaPentagonal();
        }
        /*-------------------------Métodos para definir e obter informações sobre o objeto-------------------*/


        public string GetNome()
        {
            return this.nomeModelo;
        }

        public int GetnrFaces()
        {
            return this.nrFaces;
        }

        public int GetnrFacesDesenhadas()
        {
            return this.faceDesenhada;
        }
        public void SetnrFacesDesenhadas()
        {
            this.faceDesenhada = 0;
        }

        public ArrayList GetVertices3D()
        {
            return this.vertices;
        }

        public ArrayList GetIndicesFaces()
        {
            return this.indicesFaces;
        }

        public ArrayList GetNumvPorFace()
        {
            return this.numvPorFace;
        }



        /*------------------------------ Métodos para transformações e desenho------------------------------------------------*/


        public Objeto(float largura, float altura)
        {
            SetJanela(largura, altura);
            InicializaObjeto();
        }

        public void SetJanela(float largura, float altura)
        {
            this.larguraDesenho = largura;
            this.alturaDesenho = altura;
        }

        public void SetCentroProjeccao(float centroX, float centroY)
        {
            this.centroProjeccaoX = centroX;
            this.centroProjeccaoY = centroY;
        }


        public void SetWireframe()
        {
            this.wireframe = !this.wireframe;
        }

        public void SetProjecao(char p)
        {
            this.projecao = p;
        }

        public void SetCores(Pen penContorno, SolidBrush brushPreenchimento)
        {
            this.penContorno = penContorno;
            this.brushPreenchimento = brushPreenchimento;
        }



        private ArrayList Transforma(float translacaoX, float translacaoY, float translacaoZ, float rotx, float roty, float rotz, float distX, float distY, float distZ)
        {
            // Cria uma nova lista para armazenar os resultados da transformação
            ArrayList res = new ArrayList(this.vertices.Count);

            // Cria matrizes de transformação para transladar, rotacionar e escalar
            Matriz3D mTrans = Matriz3D.translacao(translacaoX, translacaoY, translacaoZ);
            Matriz3D mRotX = Matriz3D.rotacaoX(rotx);
            Matriz3D mRotY = Matriz3D.rotacaoY(roty);
            Matriz3D mRotZ = Matriz3D.rotacaoZ(rotz);
            Matriz3D mdist = Matriz3D.escala(distX, distY, distZ);

            // Obtém as ordens de transformações ou define uma string vazia se nula
            string ordemTransformacoes1 = this.OrdemTransformacoes1 ?? "";
            string ordemTransformacoes2 = this.OrdemTransformacoes2 ?? "";

            // Concatena as ordens de transformações
            string ordemFinal = ordemTransformacoes1 + ordemTransformacoes2;

            // Exibe as ordens de transformações no console
            Console.WriteLine($"OrdemTransformacoes1: {ordemTransformacoes1}, OrdemTransformacoes2: {ordemTransformacoes2}");

            // Itera sobre os vértices originais
            foreach (Vector3D verticeOriginal in this.vertices)
            {
                // Cria uma cópia do vértice original
                Vector3D v = verticeOriginal.Clone();

                // Adiciona o vértice à lista de resultados
                res.Add(v);

                // Itera sobre os tipos de transformações na ordem final
                foreach (char tipoTransformacao in ordemFinal)
                {
                    // Aplica a transformação correspondente ao tipo
                    switch (tipoTransformacao)
                    {
                        case 'T': //Tranlação
                            v.MultiplicaporMatriz_coordHomogeneas(mTrans);
                            break;
                        case 'R': //Rotação
                            v.MultiplicaporMatriz_coordHomogeneas(mRotX);
                            break;
                        /*case 'S':
                            v.MultiplicaporMatriz_coordHomogeneas(mRotY);
                            break;*/
                    }
                }
            
            // Define a distância para o plano de projeção perspectiva
            float distToPlanoProj = 600.0f; // distância da câmara ao Plano Projeção

                if (projecao == '1') 
                {
                    // Se a projeção for perspectiva, cria a matriz de projeção perspectiva
                    Matriz3D mProjPerspetiva = Matriz3D.projPerspectiva(distToPlanoProj);
                    v.MultiplicaporMatriz_coordHomogeneas(mRotZ);
                    v.MultiplicaporMatriz_coordHomogeneas(mdist);
                    v.MultiplicaporMatriz_coordCartesianas(mProjPerspetiva);
                }
                else
                {
                    // Se a projeção for paralela, cria a matriz de projeção paralela
                    Matriz3D mProjParalela = Matriz3D.projParalela();
                    v.MultiplicaporMatriz_coordHomogeneas(mRotZ);
                    v.MultiplicaporMatriz_coordHomogeneas(mdist);
                    v.MultiplicaporMatriz_coordCartesianas(mProjParalela);
                }
            }

            // Retorna a lista de resultados após as transformações
            return res;
        }



        private ArrayList GeraFaces(ArrayList verticesTransf)
        {
            // Cria uma nova lista para armazenar as faces geradas
            ArrayList faces = new ArrayList();
            int k = 0;

            // Itera sobre o número de vértices por face
            for (int i = 0; i < numvPorFace.Count; i++)
            {
                // Cria uma nova face
                Face f = new Face();

                // Adiciona os vértices à face
                for (int j = 0; j < (int)numvPorFace[i]; j++)
                {
                    Vector3D v = (Vector3D)verticesTransf[(int)indicesFaces[k++]];
                    f.SaveVertice(v);
                }

                // Adiciona a face à lista de faces
                faces.Add(f);
            }

            // Retorna a lista de faces geradas
            return faces;
        }

        public void Desenha(Graphics g, float translacaoX, float translacaoY, float translacaoZ, float rotacaoX, float rotacaoY, float rotacaoZ, float dist)
        {
            // Transforma os vértices
            ArrayList verticesTransf = Transforma(translacaoX, translacaoY, translacaoZ, rotacaoX, rotacaoY, rotacaoZ, dist, dist, dist);

            // Gera as faces a partir dos vértices transformados
            ArrayList faces = GeraFaces(verticesTransf);

            // Itera sobre as faces na lista de faces
            for (int i = 0; i < faces.Count; i++)
            {
                // Obtém a face atual
                Face f = (Face)faces[i];

                // Verifica se o desenho é em wireframe ou preenchido
                if (!this.wireframe)
                {
                    // Desenha a face preenchida, utilizando a escova de preenchimento
                    g.FillPolygon(this.brushPreenchimento, f.GetVertices2D(this.larguraDesenho, alturaDesenho));
                }

                // Desenha o contorno da face, utilizando a caneta de contorno
                g.DrawPolygon(penContorno, f.GetVertices2D(larguraDesenho, alturaDesenho));
            }


            // Atualiza o número total de faces
            nrFaces = faces.Count;
        }

        #region ler ficheiros
        /* ----------------------------------métodos para a leitura do objeto a partir de um ficheiro .txt-------------------------- */

        //construtor
        public Objeto(float largura, float altura, Stream s)
        {
            this.s = s;
            this.LeFicheiro();
            this.SetJanela(largura, altura);
        }
        public void SetObjeto(float largura, float altura, Stream s)
        {
            this.s = s;
            this.LeFicheiro();
            this.SetJanela(largura, altura);

        }

        private void LeFicheiro()
        {

            StreamReader readerObjeto = new StreamReader(this.s); //o StreamReader é usado em C# para definir uma stream para ler os dados do ficheiro para a aplicação 


            //colocar aqui a leitura do ficheiro que tem a estrutura do objeto (coordenadas dos vértices, índices faces, ..) para as estruturas de dados da classe Objeto

            string linha = "";
            ArrayList pontos = new ArrayList();
            ArrayList indices = new ArrayList();

            while (linha != null)
            {
                linha = readerObjeto.ReadLine(); // Lê uma linha de caracteres da stream atual e retorna os dados como uma string 
                if (linha != null)
                {
                    if (linha.StartsWith("v"))
                        pontos.Add(linha);
                    if (linha.StartsWith("f"))
                        indices.Add(linha);
                }

            }
            readerObjeto.Close();

            // extrair as coordenadas individuais dos vértices das linhas guardadas nos arraylist

            char[] separador = { ' ' }; // definir o separador: caractere espaço
            string[] coordenadas;
            foreach (string l in pontos)
            {
                coordenadas = l.Split(separador);
                this.vertices.Add(new Vector3D(float.Parse(coordenadas[1], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[2], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[3], System.Globalization.CultureInfo.InvariantCulture)));
            }

            // extrair os índices das faces, das linhas guardadas nos arraylist

            string[] indicesVertices;
            foreach (string l in indices)
            {
                indicesVertices = l.Split(separador);
                this.numvPorFace.Add(indicesVertices.Length - 1); //adicionar o nº de vértices/indices por face
                for (int i = 1; i < indicesVertices.Length; i++)
                {
                    this.indicesFaces.Add(int.Parse(indicesVertices[i]));
                }
            }

        }

        // métodos para a leitura do objeto a partir de um ficheiro .obj
        public void SetObjectoOBJ(float centroX, float centroY, Stream s) // construtor para criar objecto a partir de um ficheiro
        {
            this.s = s;
            LeFicheiroOBJ();  // função que lê a estrutura do objecto a partir de um ficheiro
            SetCentroProjeccao(centroX, centroY);
        }


        private void LeFicheiroOBJ()
        {
            StreamReader readerObjecto = new StreamReader(this.s);

            string linha = "";
            ArrayList pontos = new ArrayList();
            ArrayList indices = new ArrayList();

            while (linha != null)
            {
                linha = readerObjecto.ReadLine(); // lê uma linha do ficheiro
                if (linha != null)
                {
                    // se a linha inicia em "v", guarda os vértices
                    if (linha.StartsWith("v "))
                        pontos.Add(linha);
                    // se a linha inicia em "f", guarda os índices dos vértices das faces     
                    if (linha.StartsWith("f"))
                        indices.Add(linha);
                }
            }

            readerObjecto.Close();

            //extrair as coordenadas
            char[] separador = { ' ' }; // define o " " como separador
            char[] separador2 = { '/' }; // define o "/" como separador
            string[] coordenadas;
            // Itera sobre as linhas na lista de pontos
            foreach (string l in pontos)
            {
                // Divide a linha em coordenadas usando o separador
                coordenadas = l.Split(separador);

                // Adiciona um novo objeto Vector3D à lista de vértices com coordenadas convertidas
                this.vertices.Add(new Vector3D(
                    float.Parse(coordenadas[1], System.Globalization.CultureInfo.InvariantCulture),
                    float.Parse(coordenadas[2], System.Globalization.CultureInfo.InvariantCulture),
                    float.Parse(coordenadas[3], System.Globalization.CultureInfo.InvariantCulture)
                ));
            }

            // Declaração de arrays para armazenar índices de vértices
            string[] indicesVert;
            string[] indicesVert2;

            // Itera sobre as linhas na lista de índices
            foreach (string l in indices)
            {
                // Divide a linha em índices usando o separador
                indicesVert = l.Split(separador);

                // Adiciona o número de vértices por face à lista
                numvPorFace.Add(indicesVert.Length - 1);

                // Itera sobre os índices da linha
                for (int i = 1; i < indicesVert.Length; i++)
                {
                    // Divide o índice para obter valores individuais
                    indicesVert2 = indicesVert[i].Split(separador2);

                    // Adiciona o índice da face convertido à lista de índices de faces
                    this.indicesFaces.Add(int.Parse(indicesVert2[0]) - 1);
                }
            }


        }

        #endregion



    }


}
