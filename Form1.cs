using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO; // para usar as streams
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desenhaFaces_v1
{
    public partial class Form1 : Form
    {
        // Declaração de variáveis
        private Objeto obj, obj2; // Objetos para desenhar
        private Pen pen1; // Caneta para contornos
        private SolidBrush brush1; // Pincel para preenchimento
        private string nomeFicheiro; // Nome do arquivo

        float altCilindro = 0; // Altura do cilindro
        float raioCilindro = 0; // Raio do cilindro
        float numFacesCilindro = 0; // Número de faces do cilindro

        

        // Construtor
        public Form1()
        {
            InitializeComponent();

            // Inicialização dos objetos
            obj = new Objeto(pb_desenho.Width, pb_desenho.Height);
            obj2 = new Objeto(pb_desenho2.Width, pb_desenho2.Height);

            // Configuração da caneta e do pincel
            pen1 = new Pen(CorStroke_pb.BackColor, (float)Espessura_nud.Value);
            pen1.LineJoin = System.Drawing.Drawing2D.LineJoin.Round; // arredonda a junção das linhas
            brush1 = new SolidBrush(CorFill_pb.BackColor);

            // Atribuir a caneta e o pincel ao objeto
            obj.SetCores(pen1, brush1);
            obj2.SetCores(pen1, brush1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherComboBoxOrdens(comboBox1);

        }
        #region Combo Box
        private void PreencherComboBoxOrdens(ComboBox comboBox)
        {
            // Adicionar opções às ComboBoxes
            comboBox.Items.Add("TR");
            comboBox.Items.Add("RT");

            // Selecionar a primeira opção como padrão
            comboBox.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Redesenhar a PictureBox 1 quando a ordem é alterada
            pb_desenho.Invalidate();

            // Redesenhar a PictureBox 2 quando a ordem é alterada
            pb_desenho2.Invalidate();
        }


        #endregion

        #region Métodos de Desenho



        // Método de desenho para o Picture Box 1
        private void pb_desenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (obj != null)
            {
                obj.OrdemTransformacoes1 = comboBox1.Text; // Obtem a ordem escolhida do ComboBox

               
                obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, tb_dist.Value);

                lb_total_esq.Text = "Nº Total de Faces: " + obj.GetnrFaces();
                fdesenhadas_esq.Text = "Nº de Faces Desenhadas: " + obj.GetnrFacesDesenhadas();
                lb_nomeModelo.Text = "Nome do Modelo: " + obj.GetNome();
                lb_pic1.Text = "Ordem Transformações: " + obj.OrdemTransformacoes1;

            }
        }


        // Método de desenho para o Picture Box 2
        private void pb_desenho2_Paint(object sender, PaintEventArgs e)
        {
            // Inicializa um objeto Graphics para desenhar na PictureBox
            Graphics g = e.Graphics;
            // Define o modo de suavização para obter desenhos mais suaves
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Verifica se o objeto tridimensional (obj2) está inicializado
            if (obj2 != null)
            {
                // Define a ordem das transformações com base na seleção da ComboBox
                if (comboBox1.Text == "RT")
                {
                    obj2.OrdemTransformacoes2 = "TR";
                }
                else
                {
                    obj2.OrdemTransformacoes2 = "RT";
                }

                // Chama o método Desenha para desenhar o objeto tridimensional
                obj2.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, tb_dist.Value);
            }

            // Atualiza labels com informações sobre o número de faces
            lb_total_dt.Text = "Nº Total de Faces: " + obj2.GetnrFaces();
            fdesenhadas_dt.Text = "Nº de Faces Desenhadas: " + obj2.GetnrFacesDesenhadas();
            // Atualiza label com a ordem das transformações utilizada
            lb_pic2.Text = "Ordem Transformações: " + obj2.OrdemTransformacoes2;
        }


        #endregion


        #region Manipulação de Eventos do Formulário

        /*---------------------------------Configuração Cores ---------------------------------*/
        private void SetCores() //para atualizar a classe objeto com os atributos da pen e brush que foram escolhidos no form
        {
            if (pen1 != null && brush1 != null)
            {
                pen1.Color = CorStroke_pb.BackColor;
                pen1.Width = (float)Espessura_nud.Value;
                brush1.Color = CorFill_pb.BackColor;
                obj.SetCores(pen1, brush1);//atribui as cores escolhidas no form às variáveis na classe
                obj2.SetCores(pen1, brush1);
            }
        }

        // Manipula o clique no botão de escolha de cor para a borda
        private void CorStroke_btn_Click(object sender, EventArgs e)
        {
            // Cria uma instância do diálogo de escolha de cor
            ColorDialog dialogo = new ColorDialog();
            // Define a cor inicial do diálogo como a cor atual da borda
            dialogo.Color = this.CorStroke_pb.BackColor;

            // Abre o diálogo de escolha de cor e verifica se o usuário selecionou uma cor
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                // Atualiza a cor da borda com a cor escolhida
                this.CorStroke_pb.BackColor = dialogo.Color;

                // Verifica se os objetos estão inicializados
                if (obj != null && obj2 != null)
                {
                    // Configura as cores nos objetos
                    SetCores();

                    // Invalida as PictureBoxes para forçar o redesenho
                    this.pb_desenho.Invalidate();
                    this.pb_desenho2.Invalidate();
                }
            }
        }

        // Manipula o clique no botão de escolha de cor para o preenchimento
        private void CorFill_btn_Click(object sender, EventArgs e)
        {
            // Cria uma instância do diálogo de escolha de cor
            ColorDialog dialogo = new ColorDialog();
            // Define a cor inicial do diálogo como a cor atual do preenchimento
            dialogo.Color = this.CorFill_pb.BackColor;

            
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                // Atualiza a cor do preenchimento com a cor escolhida
                this.CorFill_pb.BackColor = dialogo.Color;

               
                if (obj != null && obj2 != null)
                {
                    
                    SetCores();

                  
                    this.pb_desenho.Invalidate();
                    this.pb_desenho2.Invalidate();
                }
            }
        }


        /*---------------------------------Wireframe ---------------------------------*/
        // Manipula a alteração no estado de seleção do checkbox de wireframe
        private void cb_wireframe_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se os objetos estão inicializados
            if (obj != null && obj2 != null)
            {
                // Ativa ou desativa o modo wireframe nos objetos
                obj.SetWireframe();
                obj2.SetWireframe();

                // Invalida as PictureBoxes para forçar o redesenho com o novo estado
                this.pb_desenho.Invalidate();
                this.pb_desenho2.Invalidate();
            }

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }

        /*---------------------------------Espessura ---------------------------------*/
        // Manipula a alteração no valor da NumericUpDown de espessura
        private void Espessura_nud_ValueChanged(object sender, EventArgs e)
        {
            // Verifica se os objetos estão inicializados
            if (obj != null && obj2 != null)
            {
                // Atualiza as cores com base nos controles de seleção de cor
                SetCores();

                // Invalida as PictureBoxes para forçar o redesenho com a nova espessura
                this.pb_desenho.Invalidate();
                this.pb_desenho2.Invalidate();
            }
        }

        /*---------------------------------Menu ---------------------------------*/

        //Abrir Menu ao Clicar
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Funcionalidade ainda não implementada!\n");

            Stream str;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)

                try
                {
                    if ((str = fileDialog.OpenFile()) != null)
                    {

                        using (str)
                        {
                            if (obj != null && obj2 != null)
                            {
                                // se vamos querer usar o mesmo obj para os dados lidos a partir do ficheiro, temos de remover dos arraylist os dados do objeto anterior

                                obj.GetVertices3D().Clear();
                                obj.GetIndicesFaces().Clear();
                                obj.GetNumvPorFace().Clear();
                                obj.SetObjeto(this.pb_desenho.Width, this.pb_desenho.Height, str); //lê o novo objeto a partir de ficheiro

                                obj2.GetVertices3D().Clear();
                                obj2.GetIndicesFaces().Clear();
                                obj2.GetNumvPorFace().Clear();
                                obj2.SetObjeto(this.pb_desenho2.Width, this.pb_desenho2.Height, str); //lê o novo objeto a partir de ficheiro
                            }

                            nomeFicheiro = fileDialog.SafeFileName;

                            SetCores(); // atualizar a classe objeto com os atributos da pen e brush que foram escolhidos no form

                            if (cb_wireframe.Checked)
                            {
                                obj.SetWireframe();
                                obj2.SetWireframe();
                            }

                            this.pb_desenho.Invalidate();
                            this.pb_desenho2.Invalidate();


                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Não foi possível ler o ficheiro\n" + ex.Message);
                }

        }

        //Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        //Sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenho de Faces Poligonais\n" + "Versão 2.0\n");
        }

        //Redimencionar Janela
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (obj != null && obj2 != null)
            {
                obj.SetJanela(this.pb_desenho.Width, this.pb_desenho.Height);
                obj2.SetJanela(this.pb_desenho2.Width, this.pb_desenho2.Height);
                this.pb_desenho.Invalidate();
                this.pb_desenho2.Invalidate();

            }
        }

        //Abrir Ficheiros OBJ
        // Manipula o evento de clique no item de menu "Objeto"
        private void objToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stx;
            OpenFileDialog fileDialog = new OpenFileDialog();

            // Configura o filtro do diálogo de seleção de arquivo
            fileDialog.Filter = "Text files (*.obj)|*.obj|All files (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            // Verifica se o diálogo foi confirmado
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Tenta abrir o arquivo selecionado
                    if ((stx = fileDialog.OpenFile()) != null)
                    {
                        // Garante que os objetos estão inicializados
                        if (obj != null)
                        {
                            // Limpa os dados existentes nos objetos
                            obj.GetVertices3D().Clear();
                            obj.GetIndicesFaces().Clear();
                            obj.GetNumvPorFace().Clear();
                            obj.SetObjectoOBJ(this.pb_desenho.Width, this.pb_desenho.Height, stx);

                            obj2.GetVertices3D().Clear();
                            obj2.GetIndicesFaces().Clear();
                            obj2.GetNumvPorFace().Clear();
                            obj2.SetObjectoOBJ(this.pb_desenho2.Width, this.pb_desenho2.Height, stx);
                        }

                        // Obtém o nome do arquivo e define as cores
                        nomeFicheiro = fileDialog.SafeFileName;
                        String[] nomeobj = nomeFicheiro.Split('.');
                        SetCores();

                        // Verifica se a opção de wireframe está ativada
                        if (cb_wireframe.Checked)
                        {
                            obj.SetWireframe();
                        }

                        // Redesenha a PictureBox principal
                        this.pb_desenho.Invalidate();
                    }
                }
                catch (Exception ex)
                {
                    // Exibe uma mensagem de erro em caso de falha na leitura do arquivo
                    MessageBox.Show("Erro: Não foi possível ler o ficheiro\n" + ex.Message);
                }
            }
        }
    

    //Abrir Ficheiros TXT
    private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream str;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)

                try
                {
                    if ((str = fileDialog.OpenFile()) != null)
                    {

                        using (str)
                        {
                            if (obj != null && obj2 != null)
                            {
                                // se vamos querer usar o mesmo obj para os dados lidos a partir do ficheiro, temos de remover dos arraylist os dados do objeto anterior

                                obj.GetVertices3D().Clear();
                                obj.GetIndicesFaces().Clear();
                                obj.GetNumvPorFace().Clear();
                                obj.SetnrFacesDesenhadas();

                                obj2.GetVertices3D().Clear();
                                obj2.GetIndicesFaces().Clear();
                                obj2.GetNumvPorFace().Clear();
                                obj2.SetnrFacesDesenhadas();

                                obj.SetObjeto(this.pb_desenho.Width, this.pb_desenho.Height, str); //lê o novo objeto a partir de ficheiro
                                //obj2.SetObjeto(this.pb_desenho2.Width, this.pb_desenho2.Height, str);
                            }

                            nomeFicheiro = fileDialog.SafeFileName;
                            String[] nomeobj = nomeFicheiro.Split('.');
                            SetCores(); // atualizar a classe objeto com os atributos da pen e brush que foram escolhidos no form

                            if (cb_wireframe.Checked)
                            {
                                obj.SetWireframe();
                                //obj2.SetWireframe();
                            }

                            this.pb_desenho.Invalidate();
                            //this.pb_desenho2.Invalidate();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Não foi possível ler o ficheiro\n" + ex.Message);
                }
        }


        /*---------------------------------Modelos Menu---------------------------------*/

        //Menu Cubo

        // Manipula o evento de clique no item de menu "Cubo"
        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            // Limpa os dados existentes nos objetos
            obj.GetVertices3D().Clear();
            obj.GetIndicesFaces().Clear();
            obj.GetNumvPorFace().Clear();

            // Configura o objeto para representar um cubo na PictureBox principal
            obj.SetCubo(this.pb_desenho.Width, this.pb_desenho.Height);

            // Limpa os dados existentes nos objetos da segunda PictureBox
            obj2.GetVertices3D().Clear();
            obj2.GetIndicesFaces().Clear();
            obj2.GetNumvPorFace().Clear();

            // Configura o objeto para representar um cubo na PictureBox secundária
            obj2.SetCubo(this.pb_desenho2.Width, this.pb_desenho2.Height);

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }


        //Menu Pirâmide Quadrangular
        private void pirâmideQuadrangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();

            obj.GetVertices3D().Clear();
            obj.GetIndicesFaces().Clear();
            obj.GetNumvPorFace().Clear();
            obj.setPiramideQuadrangular(this.pb_desenho.Width, this.pb_desenho.Height);

            obj2.GetVertices3D().Clear();
            obj2.GetIndicesFaces().Clear();
            obj2.GetNumvPorFace().Clear();
            obj2.setPiramideQuadrangular(this.pb_desenho2.Width, this.pb_desenho2.Height);

        }

        //Menu Pirâmide Hexagonal
        private void pirâmideHexagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();

            obj.GetVertices3D().Clear();
            obj.GetIndicesFaces().Clear();
            obj.GetNumvPorFace().Clear();
            obj.setPiramideHexagonal(this.pb_desenho.Width, this.pb_desenho.Height);

            obj2.GetVertices3D().Clear();
            obj2.GetIndicesFaces().Clear();
            obj2.GetNumvPorFace().Clear();
            obj2.setPiramideHexagonal(this.pb_desenho2.Width, this.pb_desenho2.Height);

        }

        //Menu Prisma Pentagonal
        private void prismaPentagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();

            obj.GetVertices3D().Clear();
            obj.GetIndicesFaces().Clear();
            obj.GetNumvPorFace().Clear();
            obj.setPrismaPentagonal(this.pb_desenho.Width, this.pb_desenho.Height);
            obj.setPrismaPentagonal(this.pb_desenho2.Width, this.pb_desenho2.Height);

            obj2.GetVertices3D().Clear();
            obj2.GetIndicesFaces().Clear();
            obj2.GetNumvPorFace().Clear();
            obj2.setPrismaPentagonal(this.pb_desenho2.Width, this.pb_desenho2.Height);

        }


        /*---------------------------------Translação---------------------------------*/


        // Manipula a alteração do valor na barra de translação X
        private void tb_transx_ValueChanged(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }

        // Manipula a alteração do valor na barra de translação Y
        private void tb_transy_ValueChanged(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }


        // Manipula a alteração do valor na barra de translação Z
        private void tb_transz_ValueChanged(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }


        /*--------------------------------- Rotação---------------------------------*/
        // Manipula a alteração do valor na barra de rotação X
        private void Rotx_tb_ValueChanged(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }

        // Manipula a alteração do valor na barra de rotação Y
        private void Roty_tb_ValueChanged(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }

        // Manipula a alteração do valor na barra de rotação Z
        private void Rotz_tb_ValueChanged(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();

            // Atualiza o número de faces desenhadas nos objetos
            obj.SetnrFacesDesenhadas();
            obj2.SetnrFacesDesenhadas();
        }



        /*---------------------------------Tipos de Projeção---------------------------------*/

        // Manipula a alteração do estado do RadioButton do tipo de projeção
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //se perspetiva estiver selecionada
            if (rb_persp.Checked)
            {
                // Define a projeção perspectiva para os objetos
                obj.SetProjecao('1');
                obj2.SetProjecao('1');

                // Redesenha as PictureBox principal e secundária
                pb_desenho.Invalidate();
                pb_desenho2.Invalidate();
            }
            else
            {
                // Define a projeção paralela para os objetos
                obj.SetProjecao('0');
                obj2.SetProjecao('0');

                // Redesenha as PictureBox principal e secundária
                pb_desenho.Invalidate();
                pb_desenho2.Invalidate();
            }
        }


        /*---------------------------------Escala/Distancia---------------------------------*/

        // Manipula a alteração do valor da TrackBar de escala
        private void tb_escala_ValueChanged(object sender, EventArgs e)
        {
            // Redesenha as PictureBox principal e secundária ao alterar o valor da escala
            this.pb_desenho.Invalidate();
            this.pb_desenho2.Invalidate();
        }

        /*---------------------------------Cilindro---------------------------------*/

        // Manipula a alteração do valor do NumericUpDown para o raio do cilindro
        private void rCilindro_ValueChanged(object sender, EventArgs e)
        {
            raioCilindro = (float)rCilindro.Value;
        }

        // Manipula a alteração do valor do NumericUpDown para a altura do cilindro
        private void alturaCilindro_ValueChanged(object sender, EventArgs e)
        {
            altCilindro = (float)alturaCilindro.Value;
        }

        // Manipula a alteração do valor do NumericUpDown para o número de faces do cilindro
        private void facesCilindro_ValueChanged(object sender, EventArgs e)
        {
            numFacesCilindro = (float)facesCilindro.Value;
        }

        // Manipula o clique no botão para criar um cilindro
        private void bt_criaCilindro_Click(object sender, EventArgs e)
        {
            // Atualiza as variáveis com os valores dos NumericUpDown
            altCilindro = (float)alturaCilindro.Value;
            numFacesCilindro = (float)facesCilindro.Value;
            raioCilindro = (float)rCilindro.Value;

            // Limpa as listas de vértices, índices e número de vértices por face
            obj.GetVertices3D().Clear();
            obj.GetIndicesFaces().Clear();
            obj.GetNumvPorFace().Clear();

            // Cria um cilindro com os parâmetros especificados
            obj.Cilindro(altCilindro, raioCilindro, numFacesCilindro);

            // Redesenha a PictureBox principal
            this.pb_desenho.Invalidate();
        }


        /*---------------------------------Labels da Ordem de transformação---------------------------------*/

        private void lb_pic2_Click(object sender, EventArgs e)
        {

        }

        private void lb_pic1_Click(object sender, EventArgs e)
        {

        }


        /*---------------------------------Botão Reset---------------------------------*/

        // Manipula o clique no botão para redefinir valores de transformação e distância
        private void bt_reset_Click(object sender, EventArgs e)
        {
            // Define os valores dos controles de translação para zero
            tb_transx.Value = 0;
            tb_transy.Value = 0;
            tb_transz.Value = 0;

            // Define os valores dos controles de rotação para zero
            Rotx_tb.Value = 0;
            Roty_tb.Value = 0;
            Rotz_tb.Value = 0;

            // Define o valor do controle de distância para 1
            tb_dist.Value = 1;

            // Redesenha as PictureBox principal e secundária
            pb_desenho.Invalidate();
            pb_desenho2.Invalidate();
        }



        #endregion

    }
}
