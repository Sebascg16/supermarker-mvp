namespace Supermarket__mvp.Views
{
    partial class ViewCategorie
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategorieList = new TabPage();
            BtnCloseC = new Button();
            BtnDeleteC = new Button();
            BtnEditC = new Button();
            btnNewC = new Button();
            DgPayModeC = new DataGridView();
            btnSearchC = new Button();
            txtSearchC = new TextBox();
            label2 = new Label();
            tabPageCategorieDetail = new TabPage();
            BtnCancelC = new Button();
            BtnSaveC = new Button();
            TxtPayModeObservationC = new TextBox();
            TxtPayModeNameC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtPayModeIdC = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayModeC).BeginInit();
            tabPageCategorieDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(29, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 29);
            label1.Name = "label1";
            label1.Size = new Size(205, 36);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIE";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategorieDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.Controls.Add(BtnCloseC);
            tabPageCategorieList.Controls.Add(BtnDeleteC);
            tabPageCategorieList.Controls.Add(BtnEditC);
            tabPageCategorieList.Controls.Add(btnNewC);
            tabPageCategorieList.Controls.Add(DgPayModeC);
            tabPageCategorieList.Controls.Add(btnSearchC);
            tabPageCategorieList.Controls.Add(txtSearchC);
            tabPageCategorieList.Controls.Add(label2);
            tabPageCategorieList.Location = new Point(4, 24);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3);
            tabPageCategorieList.Size = new Size(792, 322);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "Categorie List";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseC
            // 
            BtnCloseC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseC.Image = Properties.Resources.cerrar;
            BtnCloseC.Location = new Point(496, 238);
            BtnCloseC.Name = "BtnCloseC";
            BtnCloseC.Size = new Size(52, 44);
            BtnCloseC.TabIndex = 7;
            BtnCloseC.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteC
            // 
            BtnDeleteC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteC.Image = Properties.Resources.delete;
            BtnDeleteC.Location = new Point(496, 180);
            BtnDeleteC.Name = "BtnDeleteC";
            BtnDeleteC.Size = new Size(52, 41);
            BtnDeleteC.TabIndex = 6;
            BtnDeleteC.UseVisualStyleBackColor = true;
            // 
            // BtnEditC
            // 
            BtnEditC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditC.Image = Properties.Resources.edit;
            BtnEditC.Location = new Point(496, 125);
            BtnEditC.Name = "BtnEditC";
            BtnEditC.Size = new Size(52, 40);
            BtnEditC.TabIndex = 5;
            BtnEditC.UseVisualStyleBackColor = true;
            // 
            // btnNewC
            // 
            btnNewC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewC.Image = Properties.Resources._new;
            btnNewC.Location = new Point(496, 72);
            btnNewC.Name = "btnNewC";
            btnNewC.Size = new Size(52, 38);
            btnNewC.TabIndex = 4;
            btnNewC.UseVisualStyleBackColor = true;
            // 
            // DgPayModeC
            // 
            DgPayModeC.AllowUserToAddRows = false;
            DgPayModeC.AllowUserToDeleteRows = false;
            DgPayModeC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayModeC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayModeC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayModeC.Location = new Point(25, 72);
            DgPayModeC.Name = "DgPayModeC";
            DgPayModeC.ReadOnly = true;
            DgPayModeC.RowTemplate.Height = 25;
            DgPayModeC.Size = new Size(442, 220);
            DgPayModeC.TabIndex = 3;
            DgPayModeC.CellContentClick += DgPayModeC_CellContentClick;
            // 
            // btnSearchC
            // 
            btnSearchC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchC.Image = Properties.Resources.search_small;
            btnSearchC.Location = new Point(419, 15);
            btnSearchC.Name = "btnSearchC";
            btnSearchC.Size = new Size(50, 51);
            btnSearchC.TabIndex = 2;
            btnSearchC.UseVisualStyleBackColor = true;
            // 
            // txtSearchC
            // 
            txtSearchC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchC.Location = new Point(27, 30);
            txtSearchC.Name = "txtSearchC";
            txtSearchC.PlaceholderText = "Data to Search";
            txtSearchC.Size = new Size(386, 23);
            txtSearchC.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 12);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Categorie";
            // 
            // tabPageCategorieDetail
            // 
            tabPageCategorieDetail.Controls.Add(BtnCancelC);
            tabPageCategorieDetail.Controls.Add(BtnSaveC);
            tabPageCategorieDetail.Controls.Add(TxtPayModeObservationC);
            tabPageCategorieDetail.Controls.Add(TxtPayModeNameC);
            tabPageCategorieDetail.Controls.Add(label5);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Controls.Add(txtPayModeIdC);
            tabPageCategorieDetail.Controls.Add(label3);
            tabPageCategorieDetail.Location = new Point(4, 24);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3);
            tabPageCategorieDetail.Size = new Size(792, 322);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "Categorie Detail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelC
            // 
            BtnCancelC.Image = Properties.Resources.cancel;
            BtnCancelC.Location = new Point(134, 252);
            BtnCancelC.Name = "BtnCancelC";
            BtnCancelC.Size = new Size(46, 49);
            BtnCancelC.TabIndex = 7;
            BtnCancelC.UseVisualStyleBackColor = true;
            // 
            // BtnSaveC
            // 
            BtnSaveC.Image = Properties.Resources.save;
            BtnSaveC.Location = new Point(54, 252);
            BtnSaveC.Name = "BtnSaveC";
            BtnSaveC.Size = new Size(46, 49);
            BtnSaveC.TabIndex = 6;
            BtnSaveC.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservationC
            // 
            TxtPayModeObservationC.Location = new Point(30, 160);
            TxtPayModeObservationC.Multiline = true;
            TxtPayModeObservationC.Name = "TxtPayModeObservationC";
            TxtPayModeObservationC.PlaceholderText = "Categorie Observation";
            TxtPayModeObservationC.Size = new Size(270, 86);
            TxtPayModeObservationC.TabIndex = 5;
            // 
            // TxtPayModeNameC
            // 
            TxtPayModeNameC.Location = new Point(30, 93);
            TxtPayModeNameC.Name = "TxtPayModeNameC";
            TxtPayModeNameC.PlaceholderText = "Categorie Name";
            TxtPayModeNameC.Size = new Size(279, 23);
            TxtPayModeNameC.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 131);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 3;
            label5.Text = "Categorie Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 75);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 2;
            label4.Text = "Categorie Name";
            // 
            // txtPayModeIdC
            // 
            txtPayModeIdC.Location = new Point(30, 36);
            txtPayModeIdC.Name = "txtPayModeIdC";
            txtPayModeIdC.PlaceholderText = "0";
            txtPayModeIdC.Size = new Size(195, 23);
            txtPayModeIdC.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 15);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "Categorie Id";
            // 
            // ViewCategorie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ViewCategorie";
            Text = "Categorie Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayModeC).EndInit();
            tabPageCategorieDetail.ResumeLayout(false);
            tabPageCategorieDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage;
        private TextBox txtSearchC;
        private Label label2;
        private TabPage tabPageCategorieDetail;
        private DataGridView DgPayModeC;
        private Button btnSearchC;
        private Button BtnCloseC;
        private Button BtnDeleteC;
        private Button BtnEditC;
        private Button btnNewC;
        private TextBox TxtPayModeObservationC;
        private TextBox TxtPayModeNameC;
        private Label label5;
        private Label label4;
        private TextBox txtPayModeIdC;
        private Label label3;
        private Button BtnCancelC;
        private Button BtnSaveC;
        private TabPage tabPageCategorieList;
    }
}