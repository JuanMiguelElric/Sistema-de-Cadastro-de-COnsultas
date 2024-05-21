using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dever
{
    public class ConsultarConsultaForm : Form
    {




        public ConsultarConsultaForm(List<Consulta> consultas)
        {
            InitializeComponent();
            LoadConsultas(consultas);


        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 36);
            this.label1.MaximumSize = new System.Drawing.Size(300000, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas Recentes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 392);
            this.dataGridView1.TabIndex = 5;
            // 
            // ConsultarConsultaForm
            // 
            this.ClientSize = new System.Drawing.Size(999, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarConsultaForm";
            this.Text = " Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void LoadConsultas(List<Consulta> consultas)
        {
            dataGridView1.DataSource = consultas;
        }

        private Label label1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private DataGridView dataGridView1;
    }

    public class Consulta
    {
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public DateTime Data { get; set; }
        public string Genero { get; set; }
    }


     public class CadastroConsultaForm : Form
     {
         public event Action<Consulta> ConsultaCadastrada;

         public CadastroConsultaForm()
         {
             // Inicializa componentes do formulário de cadastro, se necessário.
             InitializeComponent();
         }

         private void InitializeComponent()
         {
             this.label1 = new System.Windows.Forms.Label();
             this.label2 = new System.Windows.Forms.Label();
             this.label3 = new System.Windows.Forms.Label();
             this.label4 = new System.Windows.Forms.Label();
             this.label5 = new System.Windows.Forms.Label();
             this.checkBox1 = new System.Windows.Forms.CheckBox();
             this.nomepaciente = new System.Windows.Forms.TextBox();
             this.Genero = new System.Windows.Forms.RadioButton();
             this.Feminino = new System.Windows.Forms.RadioButton();
             this.DataConsulta = new System.Windows.Forms.DateTimePicker();
             this.comboBox1 = new System.Windows.Forms.ComboBox();
             this.pictureBox1 = new System.Windows.Forms.PictureBox();
             this.Cancelar = new System.Windows.Forms.Button();
             this.button1 = new System.Windows.Forms.Button();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
             this.SuspendLayout();
             // 
             // label1
             // 
             this.label1.AutoSize = true;
             this.label1.Location = new System.Drawing.Point(373, 41);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(121, 16);
             this.label1.TabIndex = 0;
             this.label1.Text = "Cadastrar Consulta";
             this.label1.Click += new System.EventHandler(this.label1_Click);
             // 
             // label2
             // 
             this.label2.AutoSize = true;
             this.label2.Location = new System.Drawing.Point(55, 117);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(124, 16);
             this.label2.TabIndex = 1;
             this.label2.Text = "Nome Do Paciente:";
             this.label2.Click += new System.EventHandler(this.label2_Click);
             // 
             // label3
             // 
             this.label3.AutoSize = true;
             this.label3.Location = new System.Drawing.Point(55, 187);
             this.label3.Name = "label3";
             this.label3.Size = new System.Drawing.Size(55, 16);
             this.label3.TabIndex = 2;
             this.label3.Text = "Genêro:";
             this.label3.Click += new System.EventHandler(this.label3_Click);
             // 
             // label4
             // 
             this.label4.AutoSize = true;
             this.label4.Location = new System.Drawing.Point(487, 188);
             this.label4.Name = "label4";
             this.label4.Size = new System.Drawing.Size(55, 16);
             this.label4.TabIndex = 3;
             this.label4.Text = "Médico:";
             this.label4.Click += new System.EventHandler(this.label4_Click);
             // 
             // label5
             // 
             this.label5.AutoSize = true;
             this.label5.Location = new System.Drawing.Point(55, 256);
             this.label5.Name = "label5";
             this.label5.Size = new System.Drawing.Size(111, 16);
             this.label5.TabIndex = 4;
             this.label5.Text = "Data da consulta:";
             this.label5.Click += new System.EventHandler(this.label5_Click);
             // 
             // checkBox1
             // 
             this.checkBox1.AutoSize = true;
             this.checkBox1.Location = new System.Drawing.Point(58, 340);
             this.checkBox1.Name = "checkBox1";
             this.checkBox1.Size = new System.Drawing.Size(294, 20);
             this.checkBox1.TabIndex = 5;
             this.checkBox1.Text = "Gostaria de receber notificações por e-mail?";
             this.checkBox1.UseVisualStyleBackColor = true;
             this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
             // 
             // nomepaciente
             // 
             this.nomepaciente.Location = new System.Drawing.Point(58, 136);
             this.nomepaciente.Name = "nomepaciente";
             this.nomepaciente.Size = new System.Drawing.Size(840, 22);
             this.nomepaciente.TabIndex = 6;
             // 
             // Genero
             // 
             this.Genero.AutoSize = true;
             this.Genero.Location = new System.Drawing.Point(58, 207);
             this.Genero.Name = "Genero";
             this.Genero.Size = new System.Drawing.Size(89, 20);
             this.Genero.TabIndex = 7;
             this.Genero.TabStop = true;
             this.Genero.Text = "Masculino";
             this.Genero.UseVisualStyleBackColor = true;
             this.Genero.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
             // 
             // Feminino
             // 
             this.Feminino.AutoSize = true;
             this.Feminino.Location = new System.Drawing.Point(171, 207);
             this.Feminino.Name = "Feminino";
             this.Feminino.Size = new System.Drawing.Size(83, 20);
             this.Feminino.TabIndex = 8;
             this.Feminino.TabStop = true;
             this.Feminino.Text = "Feminino";
             this.Feminino.UseVisualStyleBackColor = true;
             this.Feminino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
             // 
             // DataConsulta
             // 
             this.DataConsulta.Location = new System.Drawing.Point(58, 275);
             this.DataConsulta.Name = "DataConsulta";
             this.DataConsulta.Size = new System.Drawing.Size(294, 22);
             this.DataConsulta.TabIndex = 10;
             // 
             // comboBox1
             // 
             this.comboBox1.DisplayMember = "aasaassadas";
             this.comboBox1.FormattingEnabled = true;
             this.comboBox1.Items.AddRange(new object[] {
             "Dr. João Silva",
             "Dra. Maria Oliveira",
             "Dr. Pedro Santos",
             "Dra. Ana Costa"});
             this.comboBox1.Location = new System.Drawing.Point(490, 207);
             this.comboBox1.Name = "comboBox1";
             this.comboBox1.Size = new System.Drawing.Size(300, 24);
             this.comboBox1.TabIndex = 12;
             this.comboBox1.Tag = "aaaaa";
             this.comboBox1.Text = "Escolha um médico";
             this.comboBox1.ValueMember = "aasaassadas";
             this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
             // 
             // pictureBox1
             // 
             this.pictureBox1.Location = new System.Drawing.Point(490, 256);
             this.pictureBox1.Name = "pictureBox1";
             this.pictureBox1.Size = new System.Drawing.Size(288, 198);
             this.pictureBox1.TabIndex = 13;
             this.pictureBox1.TabStop = false;
             this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
             // 
             // Cancelar
             // 
             this.Cancelar.BackColor = System.Drawing.Color.Red;
             this.Cancelar.Location = new System.Drawing.Point(574, 486);
             this.Cancelar.Name = "Cancelar";
             this.Cancelar.Size = new System.Drawing.Size(154, 38);
             this.Cancelar.TabIndex = 14;
             this.Cancelar.Text = "Cancelar";
             this.Cancelar.UseVisualStyleBackColor = false;
             this.Cancelar.Click += new System.EventHandler(this.button1_Click);
             // 
             // button1
             // 
             this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
             this.button1.Location = new System.Drawing.Point(744, 486);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(154, 38);
             this.button1.TabIndex = 15;
             this.button1.Text = "Cadastrar";
             this.button1.UseVisualStyleBackColor = false;
             this.button1.Click += new System.EventHandler(this.button1_Click_1);
             // 
             // CadastroConsultaForm
             // 
             this.ClientSize = new System.Drawing.Size(984, 641);
             this.Controls.Add(this.button1);
             this.Controls.Add(this.Cancelar);
             this.Controls.Add(this.pictureBox1);
             this.Controls.Add(this.comboBox1);
             this.Controls.Add(this.DataConsulta);
             this.Controls.Add(this.Feminino);
             this.Controls.Add(this.Genero);
             this.Controls.Add(this.nomepaciente);
             this.Controls.Add(this.checkBox1);
             this.Controls.Add(this.label5);
             this.Controls.Add(this.label4);
             this.Controls.Add(this.label3);
             this.Controls.Add(this.label2);
             this.Controls.Add(this.label1);
             this.Name = "CadastroConsultaForm";
             this.Text = "Cadastro de Consulta";
             this.Load += new System.EventHandler(this.CadastroConsultaForm_Load);
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
             this.ResumeLayout(false);
             this.PerformLayout();

         }

         private void CadastroConsultaForm_Load(object sender, EventArgs e)
         {


         }

         private Label label1;

         private void label1_Click(object sender, EventArgs e)
         {

         }

         private Label label2;

         private void label2_Click(object sender, EventArgs e)
         {

         }

         private Label label3;

         private void label3_Click(object sender, EventArgs e)
         {

         }

         private Label label4;

         private void label4_Click(object sender, EventArgs e)
         {

         }

         private Label label5;

         private void label5_Click(object sender, EventArgs e)
         {

         }

         private CheckBox checkBox1;

         private void checkBox1_CheckedChanged(object sender, EventArgs e)
         {

         }


         private RadioButton Genero;

         private void radioButton1_CheckedChanged(object sender, EventArgs e)
         {

         }

         private RadioButton Feminino;

         private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
         {

         }






         private DateTimePicker DataConsulta;
         private System.Windows.Forms.TextBox nomepaciente;

         private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
         {



         }

         private System.Windows.Forms.ComboBox comboBox1;



         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private PictureBox pictureBox1;

         private void pictureBox1_Click(object sender, EventArgs e)
         {
             if (comboBox1.SelectedItem != null)
             {
                 // Obtém o item selecionado
                 string itemSelecionado = comboBox1.SelectedItem.ToString();

                 // Verifica se o item selecionado é "Dr. João Silva"
                 if (itemSelecionado == "Dr. João Silva")
                 {
                     pictureBox1.Image = Image.FromFile("C:\\Users\\Juanc\\texte\\Dever\\imagens\\retrato-de-enfermeira-no-hospital.jpg");
                 }else if(itemSelecionado == "Dra. Maria Oliveira")
                 {
                     pictureBox1.Image = Image.FromFile("C:\\Users\\Juanc\\texte\\Dever\\imagens\\medica.jpg");

                 }else if(itemSelecionado == "Dr. Pedro Santos")
                 {
                     pictureBox1.Image = Image.FromFile("C:\\Users\\Juanc\\texte\\Dever\\imagens\\AAA.jpg");

                 }
                 else if (itemSelecionado == "Dra. Ana Costa")
                 {
                     pictureBox1.Image = Image.FromFile("C:\\Users\\Juanc\\texte\\Dever\\imagens\\ANA.jpg");

                 }
             }
         }

         private System.Windows.Forms.Button Cancelar;

         private void button1_Click(object sender, EventArgs e)
         {

         }

         private System.Windows.Forms.Button button1;

         private void button1_Click_1(object sender, EventArgs e)
         {

             Consulta novaConsulta = new Consulta
             {
                 Medico = comboBox1.SelectedItem.ToString(),
                 Data = DataConsulta.Value,
                 Paciente = nomepaciente.Text,
                 Genero = Genero.Checked ? "Masculino" : "Feminino"
             };

             ConsultaCadastrada?.Invoke(novaConsulta);
             this.Close();
         }
     }


     
   

    public partial class Form1 : Form
    {
        private List<Consulta> consultas = new List<Consulta>();

        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroConsultaForm cadastroForm = new CadastroConsultaForm();
            cadastroForm.ConsultaCadastrada += CadastroForm_ConsultaCadastrada;
            cadastroForm.Show();
        }

        private void CadastroForm_ConsultaCadastrada(Consulta novaConsulta)
        {
            consultas.Add(novaConsulta);
        }

        private void consultarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarConsultaForm consultarForm = new ConsultarConsultaForm(consultas);
            consultarForm.Show();
        }
    }
}
