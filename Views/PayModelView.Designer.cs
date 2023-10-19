namespace Supermarket__mvp.Views
{
    partial class PayModelView
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
            tabPageModeList = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModelDetail = new TabPage();
            button2 = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            txtPayModeId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModelDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 102);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy1;
            pictureBox1.Location = new Point(31, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(148, 38);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageModeList);
            tabControl1.Controls.Add(tabPagePayModelDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 102);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 348);
            tabControl1.TabIndex = 1;
            // 
            // tabPageModeList
            // 
            tabPageModeList.Controls.Add(btnClose);
            tabPageModeList.Controls.Add(btnDelete);
            tabPageModeList.Controls.Add(btnEdit);
            tabPageModeList.Controls.Add(btnNew);
            tabPageModeList.Controls.Add(DgPayMode);
            tabPageModeList.Controls.Add(BtnSearch);
            tabPageModeList.Controls.Add(txtSearch);
            tabPageModeList.Controls.Add(label2);
            tabPageModeList.Location = new Point(4, 24);
            tabPageModeList.Name = "tabPageModeList";
            tabPageModeList.Padding = new Padding(3);
            tabPageModeList.Size = new Size(792, 320);
            tabPageModeList.TabIndex = 0;
            tabPageModeList.Text = "Pay Mode List";
            tabPageModeList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(488, 230);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 41);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(488, 181);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 43);
            btnDelete.TabIndex = 6;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(488, 126);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 41);
            btnEdit.TabIndex = 5;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(488, 68);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(140, 42);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(25, 68);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(442, 217);
            DgPayMode.TabIndex = 3;
            DgPayMode.CellContentClick += DgPayMode_CellContentClick;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(424, 19);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(45, 43);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(27, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Data to Search";
            txtSearch.Size = new Size(391, 23);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 12);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModelDetail
            // 
            tabPagePayModelDetail.Controls.Add(button2);
            tabPagePayModelDetail.Controls.Add(BtnSave);
            tabPagePayModelDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModelDetail.Controls.Add(label5);
            tabPagePayModelDetail.Controls.Add(TxtPayModeName);
            tabPagePayModelDetail.Controls.Add(label4);
            tabPagePayModelDetail.Controls.Add(txtPayModeId);
            tabPagePayModelDetail.Controls.Add(label3);
            tabPagePayModelDetail.Location = new Point(4, 24);
            tabPagePayModelDetail.Name = "tabPagePayModelDetail";
            tabPagePayModelDetail.Padding = new Padding(3);
            tabPagePayModelDetail.Size = new Size(792, 320);
            tabPagePayModelDetail.TabIndex = 1;
            tabPagePayModelDetail.Text = "Pay Mode Detail";
            tabPagePayModelDetail.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Image = Properties.Resources.cancel;
            button2.Location = new Point(144, 237);
            button2.Name = "button2";
            button2.Size = new Size(69, 46);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.DarkGray;
            BtnSave.ForeColor = SystemColors.ControlDark;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(42, 237);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(77, 46);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.AccessibleName = "";
            TxtPayModeObservation.ForeColor = SystemColors.WindowFrame;
            TxtPayModeObservation.Location = new Point(27, 180);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(210, 23);
            TxtPayModeObservation.TabIndex = 5;
            TxtPayModeObservation.Text = "Pay Mode Observation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 155);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.ForeColor = SystemColors.WindowFrame;
            TxtPayModeName.Location = new Point(26, 105);
            TxtPayModeName.Multiline = true;
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(211, 23);
            TxtPayModeName.TabIndex = 3;
            TxtPayModeName.Text = "Pay Mode Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 84);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // txtPayModeId
            // 
            txtPayModeId.Location = new Point(22, 40);
            txtPayModeId.Name = "txtPayModeId";
            txtPayModeId.Size = new Size(143, 23);
            txtPayModeId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 17);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // PayModelView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModelView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageModeList.ResumeLayout(false);
            tabPageModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModelDetail.ResumeLayout(false);
            tabPagePayModelDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageModeList;
        private TabPage tabPagePayModelDetail;
        private Button BtnSearch;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView DgPayMode;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox txtPayModeId;
        private Label label3;
        private Button button2;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
    }
}