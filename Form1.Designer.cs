namespace SeguroAutomóveis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rbCorolla = new RadioButton();
            rbGolf = new RadioButton();
            rbA250 = new RadioButton();
            rb320i = new RadioButton();
            rbCivic = new RadioButton();
            txtSeguro = new TextBox();
            txtTotal = new TextBox();
            groupBox3 = new GroupBox();
            cbAntiFurto = new CheckBox();
            cbTrava = new CheckBox();
            cbAlarme = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            rbEstacionamento = new RadioButton();
            rbGaragem = new RadioButton();
            rbRua = new RadioButton();
            groupBox4 = new GroupBox();
            rbFaixa4 = new RadioButton();
            rbFaixa3 = new RadioButton();
            rbFaixa2 = new RadioButton();
            rbFaixa1 = new RadioButton();
            btnCalcular = new Button();
            label3 = new Label();
            txtAno = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCorolla);
            groupBox1.Controls.Add(rbGolf);
            groupBox1.Controls.Add(rbA250);
            groupBox1.Controls.Add(rb320i);
            groupBox1.Controls.Add(rbCivic);
            groupBox1.Location = new Point(17, 77);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(283, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione o veículo";
            // 
            // rbCorolla
            // 
            rbCorolla.AutoSize = true;
            rbCorolla.Location = new Point(18, 175);
            rbCorolla.Margin = new Padding(3, 4, 3, 4);
            rbCorolla.Name = "rbCorolla";
            rbCorolla.Size = new Size(241, 24);
            rbCorolla.TabIndex = 4;
            rbCorolla.TabStop = true;
            rbCorolla.Text = "Toyota GR Corolla R$300.000,00";
            rbCorolla.UseVisualStyleBackColor = true;
            // 
            // rbGolf
            // 
            rbGolf.AutoSize = true;
            rbGolf.Location = new Point(18, 141);
            rbGolf.Margin = new Padding(3, 4, 3, 4);
            rbGolf.Name = "rbGolf";
            rbGolf.Size = new Size(262, 24);
            rbGolf.TabIndex = 3;
            rbGolf.TabStop = true;
            rbGolf.Text = "Volkswagem Golf GTI R$180.000,00";
            rbGolf.UseVisualStyleBackColor = true;
            // 
            // rbA250
            // 
            rbA250.AutoSize = true;
            rbA250.Location = new Point(18, 108);
            rbA250.Margin = new Padding(3, 4, 3, 4);
            rbA250.Name = "rbA250";
            rbA250.Size = new Size(260, 24);
            rbA250.TabIndex = 2;
            rbA250.TabStop = true;
            rbA250.Text = "Mercedez Benz A250 R$210.000,00";
            rbA250.UseVisualStyleBackColor = true;
            // 
            // rb320i
            // 
            rb320i.AutoSize = true;
            rb320i.Location = new Point(18, 75);
            rb320i.Margin = new Padding(3, 4, 3, 4);
            rb320i.Name = "rb320i";
            rb320i.Size = new Size(189, 24);
            rb320i.TabIndex = 1;
            rb320i.TabStop = true;
            rb320i.Text = "BMW 320i R$200.000,00";
            rb320i.UseVisualStyleBackColor = true;
            // 
            // rbCivic
            // 
            rbCivic.AutoSize = true;
            rbCivic.Location = new Point(18, 41);
            rbCivic.Margin = new Padding(3, 4, 3, 4);
            rbCivic.Name = "rbCivic";
            rbCivic.Size = new Size(201, 24);
            rbCivic.TabIndex = 0;
            rbCivic.TabStop = true;
            rbCivic.Text = "Honda Civic R$150.000,00";
            rbCivic.UseVisualStyleBackColor = true;
            // 
            // txtSeguro
            // 
            txtSeguro.Font = new Font("Segoe UI", 12F);
            txtSeguro.Location = new Point(469, 561);
            txtSeguro.Margin = new Padding(3, 4, 3, 4);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.ReadOnly = true;
            txtSeguro.Size = new Size(155, 34);
            txtSeguro.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F);
            txtTotal.Location = new Point(469, 618);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(155, 34);
            txtTotal.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbAntiFurto);
            groupBox3.Controls.Add(cbTrava);
            groupBox3.Controls.Add(cbAlarme);
            groupBox3.Location = new Point(17, 308);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(256, 152);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opcionais de segurança";
            // 
            // cbAntiFurto
            // 
            cbAntiFurto.AutoSize = true;
            cbAntiFurto.Location = new Point(25, 97);
            cbAntiFurto.Margin = new Padding(3, 4, 3, 4);
            cbAntiFurto.Name = "cbAntiFurto";
            cbAntiFurto.Size = new Size(96, 24);
            cbAntiFurto.TabIndex = 2;
            cbAntiFurto.Text = "Anti-furto";
            cbAntiFurto.UseVisualStyleBackColor = true;
            // 
            // cbTrava
            // 
            cbTrava.AutoSize = true;
            cbTrava.Location = new Point(25, 64);
            cbTrava.Margin = new Padding(3, 4, 3, 4);
            cbTrava.Name = "cbTrava";
            cbTrava.Size = new Size(119, 24);
            cbTrava.TabIndex = 1;
            cbTrava.Text = "Trava Elétrica";
            cbTrava.UseVisualStyleBackColor = true;
            // 
            // cbAlarme
            // 
            cbAlarme.AutoSize = true;
            cbAlarme.Location = new Point(25, 31);
            cbAlarme.Margin = new Padding(3, 4, 3, 4);
            cbAlarme.Name = "cbAlarme";
            cbAlarme.Size = new Size(79, 24);
            cbAlarme.TabIndex = 0;
            cbAlarme.Text = "Alarme";
            cbAlarme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(305, 561);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 3;
            label1.Text = "Valor do Seguro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(305, 621);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 4;
            label2.Text = "Valor Total:";
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(16, 81);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(45, 19);
            radioButton8.TabIndex = 2;
            radioButton8.TabStop = true;
            radioButton8.Text = "Rua";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(16, 56);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(110, 19);
            radioButton9.TabIndex = 1;
            radioButton9.TabStop = true;
            radioButton9.Text = "Estacionamento";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(16, 31);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(76, 19);
            radioButton10.TabIndex = 0;
            radioButton10.TabStop = true;
            radioButton10.Text = "Garagem ";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(342, 12);
            label4.Name = "label4";
            label4.Size = new Size(282, 35);
            label4.TabIndex = 7;
            label4.Text = "Informações do Seguro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(17, 12);
            label5.Name = "label5";
            label5.Size = new Size(283, 35);
            label5.TabIndex = 8;
            label5.Text = "Informações do Veículo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbEstacionamento);
            groupBox2.Controls.Add(rbGaragem);
            groupBox2.Controls.Add(rbRua);
            groupBox2.Location = new Point(341, 308);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 165);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pernoite do veículo";
            // 
            // rbEstacionamento
            // 
            rbEstacionamento.AutoSize = true;
            rbEstacionamento.Location = new Point(27, 77);
            rbEstacionamento.Margin = new Padding(3, 4, 3, 4);
            rbEstacionamento.Name = "rbEstacionamento";
            rbEstacionamento.Size = new Size(136, 24);
            rbEstacionamento.TabIndex = 2;
            rbEstacionamento.TabStop = true;
            rbEstacionamento.Text = "Estacionamento";
            rbEstacionamento.UseVisualStyleBackColor = true;
            // 
            // rbGaragem
            // 
            rbGaragem.AutoSize = true;
            rbGaragem.Location = new Point(27, 111);
            rbGaragem.Margin = new Padding(3, 4, 3, 4);
            rbGaragem.Name = "rbGaragem";
            rbGaragem.Size = new Size(91, 24);
            rbGaragem.TabIndex = 1;
            rbGaragem.TabStop = true;
            rbGaragem.Text = "Garagem";
            rbGaragem.UseVisualStyleBackColor = true;
            // 
            // rbRua
            // 
            rbRua.AutoSize = true;
            rbRua.Location = new Point(27, 44);
            rbRua.Margin = new Padding(3, 4, 3, 4);
            rbRua.Name = "rbRua";
            rbRua.Size = new Size(55, 24);
            rbRua.TabIndex = 0;
            rbRua.TabStop = true;
            rbRua.Text = "Rua";
            rbRua.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbFaixa4);
            groupBox4.Controls.Add(rbFaixa3);
            groupBox4.Controls.Add(rbFaixa2);
            groupBox4.Controls.Add(rbFaixa1);
            groupBox4.Location = new Point(342, 77);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(229, 185);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Faixa etária do proprietário";
            // 
            // rbFaixa4
            // 
            rbFaixa4.AutoSize = true;
            rbFaixa4.Location = new Point(23, 140);
            rbFaixa4.Margin = new Padding(3, 4, 3, 4);
            rbFaixa4.Name = "rbFaixa4";
            rbFaixa4.Size = new Size(137, 24);
            rbFaixa4.TabIndex = 3;
            rbFaixa4.TabStop = true;
            rbFaixa4.Text = "41 anos ou mais";
            rbFaixa4.UseVisualStyleBackColor = true;
            // 
            // rbFaixa3
            // 
            rbFaixa3.AutoSize = true;
            rbFaixa3.Location = new Point(23, 107);
            rbFaixa3.Margin = new Padding(3, 4, 3, 4);
            rbFaixa3.Name = "rbFaixa3";
            rbFaixa3.Size = new Size(113, 24);
            rbFaixa3.TabIndex = 2;
            rbFaixa3.TabStop = true;
            rbFaixa3.Text = "31 a 40 anos";
            rbFaixa3.UseVisualStyleBackColor = true;
            // 
            // rbFaixa2
            // 
            rbFaixa2.AutoSize = true;
            rbFaixa2.Location = new Point(23, 73);
            rbFaixa2.Margin = new Padding(3, 4, 3, 4);
            rbFaixa2.Name = "rbFaixa2";
            rbFaixa2.Size = new Size(113, 24);
            rbFaixa2.TabIndex = 1;
            rbFaixa2.TabStop = true;
            rbFaixa2.Text = "26 a 30 anos";
            rbFaixa2.UseVisualStyleBackColor = true;
            // 
            // rbFaixa1
            // 
            rbFaixa1.AutoSize = true;
            rbFaixa1.Location = new Point(23, 40);
            rbFaixa1.Margin = new Padding(3, 4, 3, 4);
            rbFaixa1.Name = "rbFaixa1";
            rbFaixa1.Size = new Size(113, 24);
            rbFaixa1.TabIndex = 0;
            rbFaixa1.TabStop = true;
            rbFaixa1.Text = "18 a 25 anos";
            rbFaixa1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 15F);
            btnCalcular.Location = new Point(455, 481);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(114, 56);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 481);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 12;
            label3.Text = "Ano do veículo:";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(143, 478);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(125, 27);
            txtAno.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 517);
            label6.Name = "label6";
            label6.Size = new Size(378, 20);
            label6.TabIndex = 14;
            label6.Text = "Carros abaixo do ano de 2015 não podem fazer seguro.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 680);
            Controls.Add(label6);
            Controls.Add(txtAno);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(txtTotal);
            Controls.Add(txtSeguro);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSeguro;
        private TextBox txtTotal;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private RadioButton rbCorolla;
        private RadioButton rbGolf;
        private RadioButton rbA250;
        private RadioButton rb320i;
        private RadioButton rbCivic;
        private CheckBox cbAntiFurto;
        private CheckBox cbTrava;
        private CheckBox cbAlarme;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton rbEstacionamento;
        private RadioButton rbGaragem;
        private RadioButton rbRua;
        private GroupBox groupBox4;
        private RadioButton rbFaixa4;
        private RadioButton rbFaixa3;
        private RadioButton rbFaixa2;
        private RadioButton rbFaixa1;
        private Button btnCalcular;
        private Label label3;
        private TextBox txtAno;
        private Label label6;
    }
}
