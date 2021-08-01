using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MapWinGIS;
using AxMapWinGIS;
using System.Windows.Forms.VisualStyles;

namespace teste_WFA_SQL
{
    public partial class Form1 : Form
    {


        DAL dal = new DAL();

        Int32 id_layer;



        public Form1()
        {
            InitializeComponent();
            
        }
        void consultaBanco()
        {
            string pesquisaNome = "%" + NomeBox.Text + "%";
            string pesquisaNascimento = "%" + BirthBox.Text + "%";
            string pesquisaSexo = "%" + GenderBox.Text + "%";
            string pesquisaResponsavel = "%" + RespBox.Text + "%";
            string pesquisaTAG = "%" + TAGbox.Text + "%";
            string sqlstr = "SELECT * FROM PESSOAS WHERE NOME like '" + pesquisaNome + "' and REGISTRO like '" + pesquisaNascimento + "' and CARGO like'" + pesquisaSexo + "' and FUNÇAO like '" + pesquisaResponsavel + "' and TAG like '"+ pesquisaTAG +"'";
            DataTable tabela = dal.RetornarDataTable(sqlstr);
            dataGridView1.DataSource = tabela;
        }
        
        void consultaLog()
        {
            string PesquisaRegistro = "%" + RegBox2.Text + "%";
            string TAG = "SELECT TAG FROM PESSOAS WHERE REGISTRO LIKE '" + PesquisaRegistro + "'";
            DataTable tagg = dal.RetornarDataTable(TAG);
            TagGrid.DataSource = tagg;
            if ((tagg.Rows.Count > 0))
            {
                string tog = tagg.Rows[0]["TAG"].ToString();
                string LOG = "SELECT * FROM LOG WHERE ID_PESSOA LIKE '" + tog + "'";
                DataTable tabelalog = dal.RetornarDataTable(LOG);
                //MessageBox.Show(tog);
                dataGridView2.DataSource = tabelalog;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Shapefile sf_blocoA = new MapWinGIS.Shapefile();
            sf_blocoA.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_blocoB = new MapWinGIS.Shapefile();
            sf_blocoB.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_blocoC = new MapWinGIS.Shapefile();
            sf_blocoC.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_blocoD = new MapWinGIS.Shapefile();
            sf_blocoD.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_blocoE = new MapWinGIS.Shapefile();
            sf_blocoE.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_blocoF = new MapWinGIS.Shapefile();
            sf_blocoF.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_blocoG = new MapWinGIS.Shapefile();
            sf_blocoG.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_blocoH = new MapWinGIS.Shapefile();
            sf_blocoH.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            Shapefile sf_Refeitorio = new MapWinGIS.Shapefile();
            sf_Refeitorio.CreateNewWithShapeID("", ShpfileType.SHP_POINT);

            //Inserir dados no combobox Sexo:
           // GenderBox.Items.Add("M");
          //  GenderBox.Items.Add("F");


            //axMap1.Projection = MapWinGIS.tkMapProjection.PROJECTION_WGS84;

            GeoProjection proj = new MapWinGIS.GeoProjection();
            proj.ImportFromProj4("+proj=utm +zone=22 +south +ellps=aust_SA +units=m +no_defs");
            axMap1.GeoProjection = proj;


            //axMap1.KnownExtents = tkKnownExtents.keBrazil;

            axMap1.TileProvider = tkTileProvider.OpenStreetMap;


            //axMap1.Latitude = -24.061f;
            //axMap1.Longitude = -52.386f;

            // definição do xtent do mapa
            axMap1.CursorMode= tkCursorMode.cmZoomIn;
            axMap1.ZoomIn(15);
            //axMap1.ZoomPercent = 17;
            Extents ext = new Extents();
            ext.SetBounds(358905.12, 7338481.93, 0, 359238.60, 7338150.07, 0);
            axMap1.Extents = ext;
            axMap1.Redraw();


            //blocos

            //GeoProjection proj = new GeoProjection();
            //proj = axMap1.Projection;


            

            


            axMap1.AddLayer(sf_blocoA, true);
            axMap1.AddLayer(sf_blocoB, true);
            axMap1.AddLayer(sf_blocoC, true);
            axMap1.AddLayer(sf_blocoD, true);
            axMap1.AddLayer(sf_blocoE, true);
            axMap1.AddLayer(sf_blocoF, true);
            axMap1.AddLayer(sf_blocoH, true);
            axMap1.AddLayer(sf_blocoG, true);
            axMap1.AddLayer(sf_Refeitorio, true);

            //sf_blocoA.Projection = MapWinGIS.tkMapProjection.PROJECTION_WGS84.ToString();

            sf_blocoA.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_blocoB.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_blocoC.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_blocoD.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_blocoE.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_blocoF.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_blocoG.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_blocoH.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            sf_Refeitorio.Projection = "+proj = utm + zone = 22 + south + ellps = aust_SA + units = m + no_defs";
            //////////////////////////////////////BLOCO A//////////////////////////////////////

            MapWinGIS.Point pnt = new MapWinGIS.Point();
            pnt.x = 359064.00; //- 24.061f;
            pnt.y = 7338305.00; //- 52.386f;

            Shape shp = new MapWinGIS.Shape();
            shp.Create(ShpfileType.SHP_POINT);
            shp.InsertPoint(pnt, 0);
            sf_blocoA.EditInsertShape(shp, 0);

            sf_blocoA.Labels.AddLabel("BLOCO A", 359064.00 -10, 7338319.27-5);
            
            

            //////////////////////////////////////BLOCO B//////////////////////////////////////

            MapWinGIS.Point pnt1 = new MapWinGIS.Point();
            pnt1.x = 359056.22; 
            pnt1.y = 7338367.46; 

            Shape shp1 = new MapWinGIS.Shape();
            shp1.Create(ShpfileType.SHP_POINT);
            shp1.InsertPoint(pnt1, 0);
            sf_blocoB.EditInsertShape(shp1, 0);

            sf_blocoB.Labels.AddLabel("BLOCO B", 359056.22 + 2, 7338367.46 + 2);



            //////////////////////////////////////BLOCO C//////////////////////////////////////

            MapWinGIS.Point pnt2 = new MapWinGIS.Point();
            pnt2.x = 359073.00;
            pnt2.y = 7338340.00;

            Shape shp2 = new MapWinGIS.Shape();
            shp2.Create(ShpfileType.SHP_POINT);
            shp2.InsertPoint(pnt2, 0);
            sf_blocoC.EditInsertShape(shp2, 0);

            sf_blocoC.Labels.AddLabel("BLOCO C", 359073.00 + 2, 7338340.00 + 2);


            //////////////////////////////////////BLOCO D//////////////////////////////////////

            MapWinGIS.Point pnt3 = new MapWinGIS.Point();
            pnt3.x = 359089.53;
            pnt3.y = 7338316.78;

            Shape shp3 = new MapWinGIS.Shape();
            shp3.Create(ShpfileType.SHP_POINT);
            shp3.InsertPoint(pnt3, 0);
            sf_blocoD.EditInsertShape(shp3, 0);

            sf_blocoD.Labels.AddLabel("BLOCO D", 359089.53 + 2, 7338316.78 + 2);

            

            //////////////////////////////////////BLOCO E//////////////////////////////////////

            MapWinGIS.Point pnt4 = new MapWinGIS.Point();

            pnt4.x = 359105.78;
            pnt4.y = 7338290.92;

            Shape shp4 = new MapWinGIS.Shape();
            shp4.Create(ShpfileType.SHP_POINT);
            shp4.InsertPoint(pnt4, 0);
            sf_blocoE.EditInsertShape(shp4, 0);

            sf_blocoE.Labels.AddLabel("BLOCO E", 359105.78 + 2, 7338290.92 + 2);

            //////////////////////////////////////BLOCO F//////////////////////////////////////

            MapWinGIS.Point pnt5 = new MapWinGIS.Point();
            pnt5.x = 359126.83;
            pnt5.y = 7338268.99;

            Shape shp5 = new MapWinGIS.Shape();
            shp5.Create(ShpfileType.SHP_POINT);
            shp5.InsertPoint(pnt5, 0);
            sf_blocoF.EditInsertShape(shp5, 0);

            sf_blocoF.Labels.AddLabel("BLOCO F", 359126.83 + 2, 7338268.99 + 2);
            

            //////////////////////////////////////BLOCO H//////////////////////////////////////

            MapWinGIS.Point pnt6 = new MapWinGIS.Point();
            pnt6.x = 359143.90;
            pnt6.y = 7338242.69;

            Shape shp6 = new MapWinGIS.Shape();
            shp6.Create(ShpfileType.SHP_POINT);
            shp6.InsertPoint(pnt6, 0);
            sf_blocoH.EditInsertShape(shp6, 0);

            sf_blocoH.Labels.AddLabel("BLOCO H", 359143.90 + 2, 7338242.69 + 2);
            

            //////////////////////////////////////BLOCO G//////////////////////////////////////

            MapWinGIS.Point pnt7 = new MapWinGIS.Point();
            pnt7.x = 359132.00;
            pnt7.y = 7338346.00;

            Shape shp7 = new MapWinGIS.Shape();
            shp7.Create(ShpfileType.SHP_POINT);
            shp7.InsertPoint(pnt7, 0);
            sf_blocoG.EditInsertShape(shp7, 0);

            sf_blocoG.Labels.AddLabel("BLOCO G", 359132.00 + 2, 7338346.00 + 2);
            

            //////////////////////////////////////REFEITORIO//////////////////////////////////////

            MapWinGIS.Point pnt8 = new MapWinGIS.Point();
            pnt8.x = 359119.84;
            pnt8.y = 7338182.33;

            Shape shp8 = new MapWinGIS.Shape();
            shp8.Create(ShpfileType.SHP_POINT);
            shp8.InsertPoint(pnt8, 0);
            sf_Refeitorio.EditInsertShape(shp8, 0);

            sf_Refeitorio.Labels.AddLabel("Refeitorio", 359119.84 + 2, 7338182.33 + 2);



            Utils utils = new Utils(); // perfumaria 
            sf_blocoA.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf_blocoA.DefaultDrawingOptions.FillColor = utils.ColorByName(tkMapColor.Blue);
            sf_blocoA.DefaultDrawingOptions.LineColor = utils.ColorByName(tkMapColor.Black);
            sf_blocoA.DefaultDrawingOptions.PointSize = 12;
            sf_blocoA.Labels.FrameVisible = false;

            Utils utils2 = new Utils(); // perfumaria 
            sf_blocoB.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf_blocoB.DefaultDrawingOptions.FillColor = utils2.ColorByName(tkMapColor.Red);
            sf_blocoB.DefaultDrawingOptions.LineColor = utils2.ColorByName(tkMapColor.Black);
            sf_blocoB.DefaultDrawingOptions.PointSize = 12;
            sf_blocoB.Labels.FrameVisible = false;

            Utils utils3 = new Utils(); // perfumaria 
            sf_blocoC.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf_blocoC.DefaultDrawingOptions.FillColor = utils3.ColorByName(tkMapColor.Yellow);
            sf_blocoC.DefaultDrawingOptions.LineColor = utils3.ColorByName(tkMapColor.Black);
            sf_blocoC.DefaultDrawingOptions.PointSize = 12;
            sf_blocoC.Labels.FrameVisible = false;

            Utils utils4 = new Utils(); // perfumaria 
            sf_blocoD.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf_blocoD.DefaultDrawingOptions.FillColor = utils4.ColorByName(tkMapColor.Snow);
            sf_blocoD.DefaultDrawingOptions.LineColor = utils4.ColorByName(tkMapColor.Black);
            sf_blocoD.DefaultDrawingOptions.PointSize = 12;
            sf_blocoD.Labels.FrameVisible = false;

            Utils utils5 = new Utils(); // perfumaria 
            sf_blocoE.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf_blocoE.DefaultDrawingOptions.FillColor = utils5.ColorByName(tkMapColor.Black);
            sf_blocoE.DefaultDrawingOptions.LineColor = utils5.ColorByName(tkMapColor.Black);
            sf_blocoE.DefaultDrawingOptions.PointSize = 12;
            sf_blocoE.Labels.FrameVisible = false;

            Utils utils6 = new Utils(); // perfumaria 
            sf_blocoF.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf_blocoF.DefaultDrawingOptions.FillColor = utils6.ColorByName(tkMapColor.Gray);
            sf_blocoF.DefaultDrawingOptions.LineColor = utils6.ColorByName(tkMapColor.Black);
            sf_blocoF.DefaultDrawingOptions.PointSize = 12;
            sf_blocoF.Labels.FrameVisible = false;

            Utils utils7 = new Utils(); // perfumaria 
            sf_blocoG.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            sf_blocoG.DefaultDrawingOptions.FillColor = utils7.ColorByName(tkMapColor.Purple);
            sf_blocoG.DefaultDrawingOptions.LineColor = utils7.ColorByName(tkMapColor.Black);
            sf_blocoG.DefaultDrawingOptions.PointSize = 12;
            sf_blocoG.Labels.FrameVisible = false;

            Utils utils8 = new Utils(); // perfumaria 
            sf_blocoH.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
           //sf_blocoH.DefaultDrawingOptions.FillBgColor = utils8.ColorByName(tkMapColor.RoyalBlue);
            sf_blocoH.DefaultDrawingOptions.FillColor = utils8.ColorByName(tkMapColor.RoyalBlue);
            sf_blocoH.DefaultDrawingOptions.LineColor = utils8.ColorByName(tkMapColor.Black);
            sf_blocoH.DefaultDrawingOptions.PointSize = 12;
            sf_blocoH.Labels.FrameVisible = false;

            Utils utils9 = new Utils(); // perfumaria 
            sf_Refeitorio.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsCircle);
            
            sf_Refeitorio.DefaultDrawingOptions.FillColor = utils9.ColorByName(tkMapColor.Yellow);
            sf_Refeitorio.DefaultDrawingOptions.LineColor = utils9.ColorByName(tkMapColor.Black);
            sf_Refeitorio.DefaultDrawingOptions.PointSize = 12;
            sf_Refeitorio.Labels.FrameVisible = false;





            axMap1.Redraw();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=database-1.c9rst2cteqor.sa-east-1.rds.amazonaws.com; port=3306; User Id=lukesdras; database=Cadastro; password=gostoso12");
                objcon.Open();
                // MessageBox.Show("Conectou!!!!");

                label1.Text = "Conectado com sucesso";




                objcon.Close();
            }

            catch
            {
                // MessageBox.Show("Falhou a conexão!!!!!!!");
                label1.Text = "Conexão falhou, verifique conexão com a internet!";
            }
        }

        private void NomeBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                consultaBanco();

            }
            catch
            {
                label1.Text = "Conexão falhou, verifique conexão com a internet!";

            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=database-1.c9rst2cteqor.sa-east-1.rds.amazonaws.com; port=3306; User Id=lukesdras; database=Cadastro; password=gostoso12");
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("INSERT INTO PESSOAS(id, NOME, REGISTRO, CARGO, FUNÇAO, ID_BLOCO, TAG ) values(null, ?, ?, ?, ?, 10, ?);", objcon);
                label1.Text = "Conectado com sucesso";

                //LINKA OS TEXTBOX COM AS VARIAVEIS DO SQL
                objcmd.Parameters.Add("@NOME", MySqlDbType.VarChar, 255).Value = NomeBox.Text;
                objcmd.Parameters.Add("@REGISTRO", MySqlDbType.VarChar, 255).Value = BirthBox.Text;
                objcmd.Parameters.Add("@CARGO", MySqlDbType.VarChar, 255).Value = GenderBox.SelectedItem.ToString();
                objcmd.Parameters.Add("@FUNÇAO", MySqlDbType.VarChar, 255).Value = RespBox.Text;
                objcmd.Parameters.Add("@TAG", MySqlDbType.VarChar, 255).Value = TAGbox.Text;

                //EXECUTA COMANDO QUERY SQL
                objcmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Inserido com Sucesso!!");



                objcon.Close();
            }

            catch
            {
                // MessageBox.Show("Falhou a conexão!!!!!!!");
                label1.Text = "Conexão falhou, verifique conexão com a internet!";
            }
        }

        

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenderBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                consultaBanco();
            }
            catch (Exception b)
            {
                label1.Text = "Conexão falhou, verifique conexão com a internet!" + b.Message ;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                consultaBanco();
            }

            catch
            {
                // MessageBox.Show("Falhou a conexão!!!!!!!");
                label1.Text = "Conexão falhou, verifique conexão com a internet!";
            }
        }

        private void TAGbox_TextChanged_1(object sender, EventArgs e)
        {
            consultaBanco();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //LIMPAR CAMPOS
            NomeBox.Text = "";
            BirthBox.Text = "";
            GenderBox.Text = "";
            RespBox.Text = "";
            TAGbox.Text = "";

            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=database-1.c9rst2cteqor.sa-east-1.rds.amazonaws.com; port=3306; User Id=lukesdras; database=Cadastro; password=gostoso12");
                objcon.Open();

                //BLOCO QUE MANDA COMANDO 
                MySqlCommand objrdy = new MySqlCommand("INSERT INTO COMANDO(id, C) values(null, ?)", objcon); //MANDA COMANDO 0 ou 1 para RASP
                objrdy.Parameters.Add("@C", MySqlDbType.Bit).Value = 1; // comando 1
                objrdy.ExecuteNonQuery();


                MySqlCommand objaff = new MySqlCommand("INSERT INTO CATCH_TAG(id, tag) values(null, 'TENTE NOVAMENTE')", objcon);
                objaff.ExecuteNonQuery();


                //BLOCO QUE CAPTURA TAG


                MessageBox.Show("PASSE A TAG");

                objrdy.Parameters.Clear();
                objrdy.Parameters.Add("@C", MySqlDbType.Bit).Value = 0; //comando 0
                objrdy.ExecuteNonQuery();

                MySqlCommand objgt = new MySqlCommand("SELECT * from CATCH_TAG ORDER by id DESC ", objcon); //RESGATA ULTIMO ID NO CATCHTAG PARA COMPARAR SE HOUVE ALTERAÇÂO NO WHILE
                objgt.Parameters.Clear();
                objgt.CommandType = CommandType.Text;
                MySqlDataReader gt;
                gt = objgt.ExecuteReader();
                gt.Read();
                TAGbox.Text = gt.GetString(1);



                label1.Text = "Conectado com sucesso";
                objcon.Close();
            }
            catch
            {
                // MessageBox.Show("Falhou a conexão!!!!!!!");
                label1.Text = "Conexão falhou, verifique conexão com a internet!";
            }
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BirthBox_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                consultaBanco();
            }
            catch
            {
                // MessageBox.Show("Falhou a conexão!!!!!!!");
                label1.Text = "Conexão falhou, verifique conexão com a internet!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RespBox_TextChanged_1(object sender, EventArgs e)
        {
            consultaBanco();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void zoom_in_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = tkCursorMode.cmZoomIn;
            Pesquisa_Interior_PROF.Visible = false;
            Pesquisa_Interior_Alunos.Visible = false;

        }

        private void Zoom_OUT_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = tkCursorMode.cmZoomOut;
            Pesquisa_Interior_PROF.Visible = false;
            Pesquisa_Interior_Alunos.Visible = false;
        }

        private void Pan_zoom_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = tkCursorMode.cmPan;
            Pesquisa_Interior_PROF.Visible = false;
            Pesquisa_Interior_Alunos.Visible = false;
        }

        private void Seleção_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = tkCursorMode.cmEditShape;
            contextMenuStrip1.Visible = false;
            Pesquisa_Interior_PROF.Visible = false;
            Pesquisa_Interior_Alunos.Visible = false;
        }

        private void Pesquisa_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = tkCursorMode.cmIdentify;
            Pesquisa_Interior_PROF.Visible = false;
            Pesquisa_Interior_Alunos.Visible = false;
        }

        private void Regua_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = tkCursorMode.cmMeasure;
            contextMenuStrip1.Visible = false;
            Pesquisa_Interior_PROF.Visible = false;
            Pesquisa_Interior_Alunos.Visible = false;
        }

        
        private void axMap1_ShapeIdentified(object sender, _DMapEvents_ShapeIdentifiedEvent e)
        {
            // Pesquisa_Interior.Visible = false;
            contextMenuStrip1.Visible = true;
            Pesquisa_Interior_PROF.Visible = true;
            Pesquisa_Interior_Alunos.Visible = true;
            double id_shape=e.shapeIndex;
            id_layer = e.layerHandle;
            string nome_layer = "";
            id_layer++;
            
            

            switch (id_layer)
            {
                case 1:
                    nome_layer = "BLOCO_A";
                    break;
                case 2:
                    nome_layer = "BLOCO_B";
                    break;
                case 3:
                    nome_layer = "BLOCO_C";
                    break;
                case 4:
                    nome_layer = "BLOCO_D";
                    break;
                case 5:
                    nome_layer = "BLOCO_E";
                    break;
                case 6:
                    nome_layer = "BLOCO_F";
                    break;
                case 7:
                    nome_layer = "BLOCO_G";
                    break;
                case 8:
                    nome_layer = "BLOCO_H";
                    break;
                case 9:
                    nome_layer = "Refeitorio";
                    break;


            }




        }

        private void axMap1_MouseUpEvent(object sender, _DMapEvents_MouseUpEvent e)
        {
            Pesquisa_Interior_PROF.Visible = false;
            Pesquisa_Interior_Alunos.Visible = false;
        }

        private void axMap1_MouseDownEvent(object sender, _DMapEvents_MouseDownEvent e)
        {

        }

        
        private void Pesquisa_Interior_PROF_Click(object sender, EventArgs e)
        {

            string sqlstr = "SELECT * FROM PESSOAS WHERE ID_BLOCO= '" + id_layer + "' and CARGO = 'Professor' " ;
            DataTable tabela = dal.RetornarDataTable(sqlstr);

            panel_PESQUISA_BLOCO.Visible = true;

            dataGridView_PESQUISA_BLOCO.DataSource = tabela;

        }


        private void Pesquisa_Interior_ALUNOS_Click(object sender, EventArgs e)
        {

            string sqlstr = "SELECT * FROM PESSOAS WHERE ID_BLOCO= '" + id_layer + "' and CARGO = 'Aluno' ";
            DataTable tabela = dal.RetornarDataTable(sqlstr);

            panel_PESQUISA_BLOCO.Visible = true;

            dataGridView_PESQUISA_BLOCO.DataSource = tabela;

        }
        private void logDoBlocoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Promptt Prompt = new Promptt("Adicionar Data no formato DD-MM-AA" , "Atenção");
            
            string resultado = Prompt.Result;

            string sqlstr = "SELECT * FROM LOG WHERE ID_BLOCO = '" + id_layer + "' and DATA = '" + resultado + "' ";

            DataTable tabela = dal.RetornarDataTable(sqlstr);

            panel_PESQUISA_BLOCO.Visible = true;

            dataGridView_PESQUISA_BLOCO.DataSource = tabela;
        }

        private void button_FECHAR_PESQUISA_BLOCO_Click(object sender, EventArgs e)
        {
            panel_PESQUISA_BLOCO.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void RegBox2_TextChanged(object sender, EventArgs e)
        {
            consultaLog();
        }
    }
}
