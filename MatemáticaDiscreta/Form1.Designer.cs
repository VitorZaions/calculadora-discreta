namespace MatemáticaDiscreta
{
    partial class DiscretaM
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscretaM));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadoBox = new System.Windows.Forms.TextBox();
            this.MValue = new System.Windows.Forms.NumericUpDown();
            this.LabelM = new System.Windows.Forms.Label();
            this.NValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Box2 = new System.Windows.Forms.CheckBox();
            this.Box1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureForm = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureForm)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(731, 335);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.metroButton2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.MValue);
            this.tabPage1.Controls.Add(this.LabelM);
            this.tabPage1.Controls.Add(this.NValue);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(723, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Início";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(299, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Formula Usada:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(0, 235);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(260, 52);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "Limpar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(470, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado:";
            // 
            // ResultadoBox
            // 
            this.ResultadoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultadoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoBox.ForeColor = System.Drawing.Color.Green;
            this.ResultadoBox.Location = new System.Drawing.Point(3, 10);
            this.ResultadoBox.Multiline = true;
            this.ResultadoBox.Name = "ResultadoBox";
            this.ResultadoBox.Size = new System.Drawing.Size(246, 109);
            this.ResultadoBox.TabIndex = 13;
            // 
            // MValue
            // 
            this.MValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MValue.Location = new System.Drawing.Point(0, 105);
            this.MValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MValue.Name = "MValue";
            this.MValue.Size = new System.Drawing.Size(260, 26);
            this.MValue.TabIndex = 12;
            this.MValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelM
            // 
            this.LabelM.AutoSize = true;
            this.LabelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelM.Location = new System.Drawing.Point(-3, 84);
            this.LabelM.Name = "LabelM";
            this.LabelM.Size = new System.Drawing.Size(84, 20);
            this.LabelM.TabIndex = 11;
            this.LabelM.Text = "Digite o M:";
            // 
            // NValue
            // 
            this.NValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NValue.Location = new System.Drawing.Point(0, 47);
            this.NValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NValue.Name = "NValue";
            this.NValue.Size = new System.Drawing.Size(260, 26);
            this.NValue.TabIndex = 10;
            this.NValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(-3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o N:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 172);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(260, 52);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Calcular";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Box2);
            this.groupBox1.Controls.Add(this.Box1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(295, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações:";
            // 
            // Box2
            // 
            this.Box2.AutoSize = true;
            this.Box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Box2.Location = new System.Drawing.Point(12, 55);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(373, 24);
            this.Box2.TabIndex = 1;
            this.Box2.Text = "Um item pode ser selecionado mais de uma vez?";
            this.Box2.UseVisualStyleBackColor = true;
            // 
            // Box1
            // 
            this.Box1.AutoSize = true;
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Box1.Location = new System.Drawing.Point(12, 27);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(258, 24);
            this.Box1.TabIndex = 0;
            this.Box1.Text = "A ordem dos itens é importante?";
            this.Box1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PictureForm);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(294, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 122);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultadoBox);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(465, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 122);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MatemáticaDiscreta.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(714, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PictureForm
            // 
            this.PictureForm.Location = new System.Drawing.Point(7, 12);
            this.PictureForm.Name = "PictureForm";
            this.PictureForm.Size = new System.Drawing.Size(149, 104);
            this.PictureForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureForm.TabIndex = 18;
            this.PictureForm.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DiscretaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscretaM";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Matemática Discreta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private System.Windows.Forms.NumericUpDown MValue;
        private System.Windows.Forms.Label LabelM;
        private System.Windows.Forms.NumericUpDown NValue;
        private System.Windows.Forms.TextBox ResultadoBox;
        private System.Windows.Forms.CheckBox Box2;
        private System.Windows.Forms.CheckBox Box1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

