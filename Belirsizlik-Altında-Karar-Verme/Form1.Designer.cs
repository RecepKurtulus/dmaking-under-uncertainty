namespace Belirsizlik_Altında_Karar_Verme
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
            this.createModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodNmbr = new System.Windows.Forms.TextBox();
            this.sittnNmbr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.sttsnLabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.startModel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.equalProbBtn = new System.Windows.Forms.Button();
            this.alphaValueBtn = new System.Windows.Forms.TextBox();
            this.hurwiczBtn = new System.Windows.Forms.Button();
            this.pessimistBtn = new System.Windows.Forms.Button();
            this.choiceBox = new System.Windows.Forms.ComboBox();
            this.optimistBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createModel
            // 
            this.createModel.Location = new System.Drawing.Point(580, 177);
            this.createModel.Name = "createModel";
            this.createModel.Size = new System.Drawing.Size(94, 29);
            this.createModel.TabIndex = 0;
            this.createModel.Text = "Oluştur";
            this.createModel.UseVisualStyleBackColor = true;
            this.createModel.Click += new System.EventHandler(this.createModel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "BELİRSİZLİK ALTINDA KARAR VERME PROGRAMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(462, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kaç Adet Durumunuz  ve Ürününüz Var ?";
            // 
            // prodNmbr
            // 
            this.prodNmbr.Location = new System.Drawing.Point(462, 125);
            this.prodNmbr.Name = "prodNmbr";
            this.prodNmbr.Size = new System.Drawing.Size(125, 27);
            this.prodNmbr.TabIndex = 3;
            // 
            // sittnNmbr
            // 
            this.sittnNmbr.Location = new System.Drawing.Point(669, 125);
            this.sittnNmbr.Name = "sittnNmbr";
            this.sittnNmbr.Size = new System.Drawing.Size(125, 27);
            this.sittnNmbr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Karar ==>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(800, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "<== Durum";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 673);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.sttsnLabel);
            this.tabPage1.Controls.Add(this.prodLabel);
            this.tabPage1.Controls.Add(this.startModel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.createModel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sittnNmbr);
            this.tabPage1.Controls.Add(this.prodNmbr);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 640);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(339, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 11;
            // 
            // sttsnLabel
            // 
            this.sttsnLabel.AutoSize = true;
            this.sttsnLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sttsnLabel.Location = new System.Drawing.Point(669, 233);
            this.sttsnLabel.Name = "sttsnLabel";
            this.sttsnLabel.Size = new System.Drawing.Size(114, 25);
            this.sttsnLabel.TabIndex = 9;
            this.sttsnLabel.Text = "DURUMLAR";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodLabel.Location = new System.Drawing.Point(462, 233);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(108, 25);
            this.prodLabel.TabIndex = 8;
            this.prodLabel.Text = "KARARLAR";
            // 
            // startModel
            // 
            this.startModel.Location = new System.Drawing.Point(580, 602);
            this.startModel.Name = "startModel";
            this.startModel.Size = new System.Drawing.Size(94, 29);
            this.startModel.TabIndex = 7;
            this.startModel.Text = "Başlat";
            this.startModel.UseVisualStyleBackColor = true;
            this.startModel.Click += new System.EventHandler(this.startModel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.equalProbBtn);
            this.tabPage2.Controls.Add(this.alphaValueBtn);
            this.tabPage2.Controls.Add(this.hurwiczBtn);
            this.tabPage2.Controls.Add(this.pessimistBtn);
            this.tabPage2.Controls.Add(this.choiceBox);
            this.tabPage2.Controls.Add(this.optimistBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 640);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pişmanlık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // equalProbBtn
            // 
            this.equalProbBtn.Location = new System.Drawing.Point(992, 500);
            this.equalProbBtn.Name = "equalProbBtn";
            this.equalProbBtn.Size = new System.Drawing.Size(94, 29);
            this.equalProbBtn.TabIndex = 16;
            this.equalProbBtn.Text = "Eşit Olasılık";
            this.equalProbBtn.UseVisualStyleBackColor = true;
            this.equalProbBtn.Click += new System.EventHandler(this.equalProbBtn_Click);
            // 
            // alphaValueBtn
            // 
            this.alphaValueBtn.Location = new System.Drawing.Point(167, 467);
            this.alphaValueBtn.Name = "alphaValueBtn";
            this.alphaValueBtn.PlaceholderText = "Alfa Değeri";
            this.alphaValueBtn.Size = new System.Drawing.Size(94, 27);
            this.alphaValueBtn.TabIndex = 14;
            // 
            // hurwiczBtn
            // 
            this.hurwiczBtn.Location = new System.Drawing.Point(167, 500);
            this.hurwiczBtn.Name = "hurwiczBtn";
            this.hurwiczBtn.Size = new System.Drawing.Size(94, 29);
            this.hurwiczBtn.TabIndex = 13;
            this.hurwiczBtn.Text = "Hurwicz";
            this.hurwiczBtn.UseVisualStyleBackColor = true;
            this.hurwiczBtn.Click += new System.EventHandler(this.hurwiczBtn_Click);
            // 
            // pessimistBtn
            // 
            this.pessimistBtn.Location = new System.Drawing.Point(427, 500);
            this.pessimistBtn.Name = "pessimistBtn";
            this.pessimistBtn.Size = new System.Drawing.Size(94, 29);
            this.pessimistBtn.TabIndex = 12;
            this.pessimistBtn.Text = "Kötümser";
            this.pessimistBtn.UseVisualStyleBackColor = true;
            this.pessimistBtn.Click += new System.EventHandler(this.pessimistBtn_Click);
            // 
            // choiceBox
            // 
            this.choiceBox.FormattingEnabled = true;
            this.choiceBox.Items.AddRange(new object[] {
            "Kâr",
            "Maliyet"});
            this.choiceBox.Location = new System.Drawing.Point(527, 455);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(200, 28);
            this.choiceBox.TabIndex = 11;
            // 
            // optimistBtn
            // 
            this.optimistBtn.Location = new System.Drawing.Point(733, 500);
            this.optimistBtn.Name = "optimistBtn";
            this.optimistBtn.Size = new System.Drawing.Size(94, 29);
            this.optimistBtn.TabIndex = 0;
            this.optimistBtn.Text = "İyimser";
            this.optimistBtn.UseVisualStyleBackColor = true;
            this.optimistBtn.Click += new System.EventHandler(this.optimistBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button createModel;
        private Label label1;
        private Label label2;
        private TextBox situationNumber;
        private Label label3;
        private TextBox productNumber;
        private Label label4;
        private Button button2;
        private TextBox prodNmbr;
        private TextBox sittnNmbr;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button startModel;
        private Label prodLabel;
        private Label sttsnLabel;
        private Button optimistBtn;
        private Label label5;
        private ComboBox choiceBox;
        private Button pessimistBtn;
        private Button hurwiczBtn;
        private TextBox alphaValueBtn;
        private Button equalProbBtn;
        private Button button1;
    }
}