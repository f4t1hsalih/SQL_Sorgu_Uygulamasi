namespace SQL_Sorgu_Uygulamasi
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
            dataGridView1 = new DataGridView();
            rchSorgu = new RichTextBox();
            btnGoruntule = new Button();
            btnIslemler = new Button();
            cmbDatabase = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 240);
            dataGridView1.TabIndex = 5;
            // 
            // rchSorgu
            // 
            rchSorgu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rchSorgu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rchSorgu.Location = new Point(12, 12);
            rchSorgu.Name = "rchSorgu";
            rchSorgu.Size = new Size(613, 180);
            rchSorgu.TabIndex = 0;
            rchSorgu.Text = "";
            // 
            // btnGoruntule
            // 
            btnGoruntule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGoruntule.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoruntule.Location = new Point(631, 70);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(157, 58);
            btnGoruntule.TabIndex = 3;
            btnGoruntule.Text = "Görüntüle";
            btnGoruntule.UseVisualStyleBackColor = true;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // btnIslemler
            // 
            btnIslemler.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIslemler.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIslemler.Location = new Point(631, 134);
            btnIslemler.Name = "btnIslemler";
            btnIslemler.Size = new Size(157, 58);
            btnIslemler.TabIndex = 4;
            btnIslemler.Text = "Ekle - Sil - Güncelle";
            btnIslemler.UseVisualStyleBackColor = true;
            btnIslemler.Click += btnIslemler_Click;
            // 
            // cmbDatabase
            // 
            cmbDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbDatabase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabase.FormattingEnabled = true;
            cmbDatabase.Location = new Point(631, 33);
            cmbDatabase.Name = "cmbDatabase";
            cmbDatabase.Size = new Size(121, 23);
            cmbDatabase.TabIndex = 1;
            cmbDatabase.SelectedIndexChanged += cmbDatabase_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(631, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 6;
            label1.Text = "Database Seç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbDatabase);
            Controls.Add(btnIslemler);
            Controls.Add(btnGoruntule);
            Controls.Add(rchSorgu);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Sorgu Uygulaması";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RichTextBox rchSorgu;
        private Button btnGoruntule;
        private Button btnIslemler;
        private ComboBox cmbDatabase;
        private Label label1;
    }
}