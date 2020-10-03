namespace JogoBasquete
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmInserir = new System.Windows.Forms.Button();
            this.frmSalvar = new System.Windows.Forms.Button();
            this.frmConsultarPlacar1 = new System.Windows.Forms.Button();
            this.frmConsultarRecordes = new System.Windows.Forms.Button();
            this.txtJogo = new System.Windows.Forms.TextBox();
            this.txtPlacar = new System.Windows.Forms.TextBox();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtRecordMax = new System.Windows.Forms.TextBox();
            this.txtRecordMin = new System.Windows.Forms.TextBox();
            this.lblJogo = new System.Windows.Forms.Label();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblRecordeMin = new System.Windows.Forms.Label();
            this.lblRecordeMax = new System.Windows.Forms.Label();
            this.txtPlacares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmInserir
            // 
            this.frmInserir.Location = new System.Drawing.Point(18, 35);
            this.frmInserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmInserir.Name = "frmInserir";
            this.frmInserir.Size = new System.Drawing.Size(186, 68);
            this.frmInserir.TabIndex = 0;
            this.frmInserir.Text = "Inserir";
            this.frmInserir.UseVisualStyleBackColor = true;
            this.frmInserir.Click += new System.EventHandler(this.frmInserir_Click);
            // 
            // frmSalvar
            // 
            this.frmSalvar.Location = new System.Drawing.Point(670, 550);
            this.frmSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmSalvar.Name = "frmSalvar";
            this.frmSalvar.Size = new System.Drawing.Size(186, 68);
            this.frmSalvar.TabIndex = 1;
            this.frmSalvar.Text = "Salvar";
            this.frmSalvar.UseVisualStyleBackColor = true;
            this.frmSalvar.Click += new System.EventHandler(this.frmSalvar_Click);
            // 
            // frmConsultarPlacar1
            // 
            this.frmConsultarPlacar1.Location = new System.Drawing.Point(244, 35);
            this.frmConsultarPlacar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmConsultarPlacar1.Name = "frmConsultarPlacar1";
            this.frmConsultarPlacar1.Size = new System.Drawing.Size(186, 68);
            this.frmConsultarPlacar1.TabIndex = 2;
            this.frmConsultarPlacar1.Text = "Consultar menor placar";
            this.frmConsultarPlacar1.UseVisualStyleBackColor = true;
            this.frmConsultarPlacar1.Click += new System.EventHandler(this.consultarMenorTempo);
            // 
            // frmConsultarRecordes
            // 
            this.frmConsultarRecordes.Location = new System.Drawing.Point(670, 35);
            this.frmConsultarRecordes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmConsultarRecordes.Name = "frmConsultarRecordes";
            this.frmConsultarRecordes.Size = new System.Drawing.Size(186, 68);
            this.frmConsultarRecordes.TabIndex = 3;
            this.frmConsultarRecordes.Text = "Consultar Recordes";
            this.frmConsultarRecordes.UseVisualStyleBackColor = true;
            this.frmConsultarRecordes.Click += new System.EventHandler(this.frmConsultarRecordes_Click);
            // 
            // txtJogo
            // 
            this.txtJogo.Location = new System.Drawing.Point(21, 223);
            this.txtJogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.Size = new System.Drawing.Size(102, 26);
            this.txtJogo.TabIndex = 4;
            // 
            // txtPlacar
            // 
            this.txtPlacar.Location = new System.Drawing.Point(166, 223);
            this.txtPlacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlacar.Name = "txtPlacar";
            this.txtPlacar.Size = new System.Drawing.Size(102, 26);
            this.txtPlacar.TabIndex = 8;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(459, 223);
            this.txtMaxTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(102, 26);
            this.txtMaxTemp.TabIndex = 10;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(314, 223);
            this.txtMinTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(102, 26);
            this.txtMinTemp.TabIndex = 9;
            this.txtMinTemp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRecordMax
            // 
            this.txtRecordMax.Location = new System.Drawing.Point(753, 223);
            this.txtRecordMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecordMax.Name = "txtRecordMax";
            this.txtRecordMax.Size = new System.Drawing.Size(102, 26);
            this.txtRecordMax.TabIndex = 12;
            // 
            // txtRecordMin
            // 
            this.txtRecordMin.Location = new System.Drawing.Point(608, 223);
            this.txtRecordMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecordMin.Name = "txtRecordMin";
            this.txtRecordMin.Size = new System.Drawing.Size(102, 26);
            this.txtRecordMin.TabIndex = 11;
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo.Location = new System.Drawing.Point(17, 191);
            this.lblJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(56, 27);
            this.lblJogo.TabIndex = 13;
            this.lblJogo.Text = "Jogo";
            this.lblJogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.Location = new System.Drawing.Point(161, 189);
            this.lblPlacar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(73, 27);
            this.lblPlacar.TabIndex = 14;
            this.lblPlacar.Text = "Placar";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(308, 189);
            this.lblMinTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(122, 27);
            this.lblMinTemp.TabIndex = 15;
            this.lblMinTemp.Text = "Min. Temp.";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(453, 189);
            this.lblMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(127, 27);
            this.lblMaxTemp.TabIndex = 16;
            this.lblMaxTemp.Text = "Máx. Temp.";
            // 
            // lblRecordeMin
            // 
            this.lblRecordeMin.AutoSize = true;
            this.lblRecordeMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordeMin.Location = new System.Drawing.Point(602, 189);
            this.lblRecordeMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordeMin.Name = "lblRecordeMin";
            this.lblRecordeMin.Size = new System.Drawing.Size(144, 27);
            this.lblRecordeMin.TabIndex = 17;
            this.lblRecordeMin.Text = "Recorde Min.";
            // 
            // lblRecordeMax
            // 
            this.lblRecordeMax.AutoSize = true;
            this.lblRecordeMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordeMax.Location = new System.Drawing.Point(747, 189);
            this.lblRecordeMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordeMax.Name = "lblRecordeMax";
            this.lblRecordeMax.Size = new System.Drawing.Size(149, 27);
            this.lblRecordeMax.TabIndex = 18;
            this.lblRecordeMax.Text = "Recorde Máx.";
            // 
            // txtPlacares
            // 
            this.txtPlacares.Location = new System.Drawing.Point(18, 323);
            this.txtPlacares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlacares.Multiline = true;
            this.txtPlacares.Name = "txtPlacares";
            this.txtPlacares.Size = new System.Drawing.Size(612, 295);
            this.txtPlacares.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Jogo    -  Placar  -    Min.T  -   Máx.T  - Rec. Min. -  Rec. Max.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 68);
            this.button1.TabIndex = 21;
            this.button1.Text = "Consultar maior placar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.consultarMaiorTempo);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlacares);
            this.Controls.Add(this.lblRecordeMax);
            this.Controls.Add(this.lblRecordeMin);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.lblJogo);
            this.Controls.Add(this.txtRecordMax);
            this.Controls.Add(this.txtRecordMin);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.txtPlacar);
            this.Controls.Add(this.txtJogo);
            this.Controls.Add(this.frmConsultarRecordes);
            this.Controls.Add(this.frmConsultarPlacar1);
            this.Controls.Add(this.frmSalvar);
            this.Controls.Add(this.frmInserir);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.Text = "Placar - Basquete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmInserir;
        private System.Windows.Forms.Button frmSalvar;
        private System.Windows.Forms.Button frmConsultarPlacar1;
        private System.Windows.Forms.Button frmConsultarRecordes;
        private System.Windows.Forms.TextBox txtJogo;
        private System.Windows.Forms.TextBox txtPlacar;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtRecordMax;
        private System.Windows.Forms.TextBox txtRecordMin;
        private System.Windows.Forms.Label lblJogo;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblRecordeMin;
        private System.Windows.Forms.Label lblRecordeMax;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtPlacares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

