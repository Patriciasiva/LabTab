namespace LabTab
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
            somar = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            txtSomar = new Button();
            txtResultadoSomar = new TextBox();
            txtNum2TabSomar = new TextBox();
            txtNum1TabSomar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label5 = new Label();
            btnSubtrair = new Button();
            txtResultadoSubtracao = new TextBox();
            txtNum2SubTab2 = new TextBox();
            txtNum1SubTab2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tabPage3 = new TabPage();
            label9 = new Label();
            btnMultiplicar = new Button();
            txtResultadoMultiplicacao = new TextBox();
            txtNum2MultTab3 = new TextBox();
            txtNum1MultTab3 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabPage4 = new TabPage();
            label13 = new Label();
            btnDividir = new Button();
            txtResultadoDivisao = new TextBox();
            txtNum2DivTab4 = new TextBox();
            txtNum1DivTab4 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            somar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // somar
            // 
            somar.Controls.Add(tabPage1);
            somar.Controls.Add(tabPage2);
            somar.Controls.Add(tabPage3);
            somar.Controls.Add(tabPage4);
            somar.Location = new Point(32, 12);
            somar.Name = "somar";
            somar.SelectedIndex = 0;
            somar.Size = new Size(434, 261);
            somar.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtSomar);
            tabPage1.Controls.Add(txtResultadoSomar);
            tabPage1.Controls.Add(txtNum2TabSomar);
            tabPage1.Controls.Add(txtNum1TabSomar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(426, 233);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Somar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(146, 56);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 7;
            label4.Text = "+";
            // 
            // txtSomar
            // 
            txtSomar.Location = new Point(232, 119);
            txtSomar.Name = "txtSomar";
            txtSomar.Size = new Size(58, 23);
            txtSomar.TabIndex = 6;
            txtSomar.Text = "Somar";
            txtSomar.UseVisualStyleBackColor = true;
            txtSomar.Click += txtSomar_Click;
            // 
            // txtResultadoSomar
            // 
            txtResultadoSomar.Location = new Point(25, 119);
            txtResultadoSomar.Name = "txtResultadoSomar";
            txtResultadoSomar.ReadOnly = true;
            txtResultadoSomar.Size = new Size(100, 23);
            txtResultadoSomar.TabIndex = 5;
            // 
            // txtNum2TabSomar
            // 
            txtNum2TabSomar.Location = new Point(190, 58);
            txtNum2TabSomar.Name = "txtNum2TabSomar";
            txtNum2TabSomar.Size = new Size(100, 23);
            txtNum2TabSomar.TabIndex = 4;
            // 
            // txtNum1TabSomar
            // 
            txtNum1TabSomar.Location = new Point(25, 56);
            txtNum1TabSomar.Name = "txtNum1TabSomar";
            txtNum1TabSomar.Size = new Size(100, 23);
            txtNum1TabSomar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 101);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 28);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Segundo Número";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Primeiro Número";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(btnSubtrair);
            tabPage2.Controls.Add(txtResultadoSubtracao);
            tabPage2.Controls.Add(txtNum2SubTab2);
            tabPage2.Controls.Add(txtNum1SubTab2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(426, 233);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Subtrair";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(125, 39);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 15;
            label5.Text = "-";
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(169, 101);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(100, 23);
            btnSubtrair.TabIndex = 14;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // txtResultadoSubtracao
            // 
            txtResultadoSubtracao.Location = new Point(4, 102);
            txtResultadoSubtracao.Name = "txtResultadoSubtracao";
            txtResultadoSubtracao.ReadOnly = true;
            txtResultadoSubtracao.Size = new Size(100, 23);
            txtResultadoSubtracao.TabIndex = 13;
            // 
            // txtNum2SubTab2
            // 
            txtNum2SubTab2.Location = new Point(169, 41);
            txtNum2SubTab2.Name = "txtNum2SubTab2";
            txtNum2SubTab2.Size = new Size(100, 23);
            txtNum2SubTab2.TabIndex = 12;
            // 
            // txtNum1SubTab2
            // 
            txtNum1SubTab2.Location = new Point(4, 39);
            txtNum1SubTab2.Name = "txtNum1SubTab2";
            txtNum1SubTab2.Size = new Size(100, 23);
            txtNum1SubTab2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 84);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Resultado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 11);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 9;
            label7.Text = "Segundo Número";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 11);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 8;
            label8.Text = "Primeiro Número";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(btnMultiplicar);
            tabPage3.Controls.Add(txtResultadoMultiplicacao);
            tabPage3.Controls.Add(txtNum2MultTab3);
            tabPage3.Controls.Add(txtNum1MultTab3);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(426, 233);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Multiplicar";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(146, 58);
            label9.Name = "label9";
            label9.Size = new Size(21, 25);
            label9.TabIndex = 23;
            label9.Text = "*";
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(190, 120);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(100, 23);
            btnMultiplicar.TabIndex = 22;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // txtResultadoMultiplicacao
            // 
            txtResultadoMultiplicacao.Location = new Point(25, 121);
            txtResultadoMultiplicacao.Name = "txtResultadoMultiplicacao";
            txtResultadoMultiplicacao.ReadOnly = true;
            txtResultadoMultiplicacao.Size = new Size(100, 23);
            txtResultadoMultiplicacao.TabIndex = 21;
            // 
            // txtNum2MultTab3
            // 
            txtNum2MultTab3.Location = new Point(190, 60);
            txtNum2MultTab3.Name = "txtNum2MultTab3";
            txtNum2MultTab3.Size = new Size(100, 23);
            txtNum2MultTab3.TabIndex = 20;
            // 
            // txtNum1MultTab3
            // 
            txtNum1MultTab3.Location = new Point(25, 58);
            txtNum1MultTab3.Name = "txtNum1MultTab3";
            txtNum1MultTab3.Size = new Size(100, 23);
            txtNum1MultTab3.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 103);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 18;
            label10.Text = "Resultado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(190, 30);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 17;
            label11.Text = "Segundo Número";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 30);
            label12.Name = "label12";
            label12.Size = new Size(99, 15);
            label12.TabIndex = 16;
            label12.Text = "Primeiro Número";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(btnDividir);
            tabPage4.Controls.Add(txtResultadoDivisao);
            tabPage4.Controls.Add(txtNum2DivTab4);
            tabPage4.Controls.Add(txtNum1DivTab4);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label16);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(426, 233);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Dividir";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(131, 44);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 31;
            label13.Text = "/";
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(171, 106);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(100, 23);
            btnDividir.TabIndex = 30;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // txtResultadoDivisao
            // 
            txtResultadoDivisao.Location = new Point(6, 107);
            txtResultadoDivisao.Name = "txtResultadoDivisao";
            txtResultadoDivisao.ReadOnly = true;
            txtResultadoDivisao.Size = new Size(100, 23);
            txtResultadoDivisao.TabIndex = 29;
            // 
            // txtNum2DivTab4
            // 
            txtNum2DivTab4.Location = new Point(171, 46);
            txtNum2DivTab4.Name = "txtNum2DivTab4";
            txtNum2DivTab4.Size = new Size(100, 23);
            txtNum2DivTab4.TabIndex = 28;
            // 
            // txtNum1DivTab4
            // 
            txtNum1DivTab4.Location = new Point(6, 44);
            txtNum1DivTab4.Name = "txtNum1DivTab4";
            txtNum1DivTab4.Size = new Size(100, 23);
            txtNum1DivTab4.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 89);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 26;
            label14.Text = "Resultado";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(171, 16);
            label15.Name = "label15";
            label15.Size = new Size(101, 15);
            label15.TabIndex = 25;
            label15.Text = "Segundo Número";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 16);
            label16.Name = "label16";
            label16.Size = new Size(99, 15);
            label16.TabIndex = 24;
            label16.Text = "Primeiro Número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 376);
            Controls.Add(somar);
            Name = "Form1";
            Text = "Form1";
            somar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl somar;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label4;
        private Button txtSomar;
        private TextBox txtResultadoSomar;
        private TextBox txtNum2TabSomar;
        private TextBox txtNum1TabSomar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btnSubtrair;
        private TextBox txtResultadoSubtracao;
        private TextBox txtNum2SubTab2;
        private TextBox txtNum1SubTab2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnMultiplicar;
        private TextBox txtResultadoMultiplicacao;
        private TextBox txtNum2MultTab3;
        private TextBox txtNum1MultTab3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnDividir;
        private TextBox txtResultadoDivisao;
        private TextBox txtNum2DivTab4;
        private TextBox txtNum1DivTab4;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}
