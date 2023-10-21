namespace Supermarket__mvp.Views
{
    partial class ProviderView
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
            tabPageProviderList = new TabPage();
            BtnClosePr = new Button();
            BtnDeletePr = new Button();
            BtnEditPr = new Button();
            BtnNewPr = new Button();
            DgProvider = new DataGridView();
            BtnSearchPr = new Button();
            TxtSearchPr = new TextBox();
            label2 = new Label();
            tabPageProviderDetail = new TabPage();
            TxtProviderObservation = new TextBox();
            TxtProviderName = new TextBox();
            TxtProvidId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            tabPageProviderDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.proveedor;
            pictureBox1.Location = new Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 30);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 0;
            label1.Text = "PROVIDER";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnClosePr);
            tabPageProviderList.Controls.Add(BtnDeletePr);
            tabPageProviderList.Controls.Add(BtnEditPr);
            tabPageProviderList.Controls.Add(BtnNewPr);
            tabPageProviderList.Controls.Add(DgProvider);
            tabPageProviderList.Controls.Add(BtnSearchPr);
            tabPageProviderList.Controls.Add(TxtSearchPr);
            tabPageProviderList.Controls.Add(label2);
            tabPageProviderList.Location = new Point(4, 24);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(792, 322);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "ProviderList";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // BtnClosePr
            // 
            BtnClosePr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClosePr.Image = Properties.Resources.cerrar;
            BtnClosePr.Location = new Point(414, 242);
            BtnClosePr.Name = "BtnClosePr";
            BtnClosePr.Size = new Size(49, 40);
            BtnClosePr.TabIndex = 7;
            BtnClosePr.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePr
            // 
            BtnDeletePr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeletePr.Image = Properties.Resources.delete;
            BtnDeletePr.Location = new Point(414, 190);
            BtnDeletePr.Name = "BtnDeletePr";
            BtnDeletePr.Size = new Size(49, 46);
            BtnDeletePr.TabIndex = 6;
            BtnDeletePr.UseVisualStyleBackColor = true;
            // 
            // BtnEditPr
            // 
            BtnEditPr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditPr.Image = Properties.Resources.edit;
            BtnEditPr.Location = new Point(414, 130);
            BtnEditPr.Name = "BtnEditPr";
            BtnEditPr.Size = new Size(49, 54);
            BtnEditPr.TabIndex = 5;
            BtnEditPr.UseVisualStyleBackColor = true;
            // 
            // BtnNewPr
            // 
            BtnNewPr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewPr.Image = Properties.Resources._new;
            BtnNewPr.Location = new Point(414, 80);
            BtnNewPr.Name = "BtnNewPr";
            BtnNewPr.Size = new Size(49, 44);
            BtnNewPr.TabIndex = 4;
            BtnNewPr.UseVisualStyleBackColor = true;
            // 
            // DgProvider
            // 
            DgProvider.AllowUserToAddRows = false;
            DgProvider.AllowUserToDeleteRows = false;
            DgProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(19, 80);
            DgProvider.Name = "DgProvider";
            DgProvider.ReadOnly = true;
            DgProvider.RowTemplate.Height = 25;
            DgProvider.Size = new Size(371, 202);
            DgProvider.TabIndex = 3;
            // 
            // BtnSearchPr
            // 
            BtnSearchPr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchPr.Image = Properties.Resources.search_small;
            BtnSearchPr.Location = new Point(396, 16);
            BtnSearchPr.Name = "BtnSearchPr";
            BtnSearchPr.Size = new Size(53, 41);
            BtnSearchPr.TabIndex = 2;
            BtnSearchPr.UseVisualStyleBackColor = true;
            // 
            // TxtSearchPr
            // 
            TxtSearchPr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchPr.Location = new Point(19, 34);
            TxtSearchPr.Name = "TxtSearchPr";
            TxtSearchPr.PlaceholderText = "Data to Search";
            TxtSearchPr.Size = new Size(371, 23);
            TxtSearchPr.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 16);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Provider";
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(TxtProviderObservation);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(TxtProvidId);
            tabPageProviderDetail.Controls.Add(label5);
            tabPageProviderDetail.Controls.Add(label4);
            tabPageProviderDetail.Controls.Add(label3);
            tabPageProviderDetail.Location = new Point(4, 24);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(792, 322);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProviderObservation
            // 
            TxtProviderObservation.Location = new Point(21, 177);
            TxtProviderObservation.Multiline = true;
            TxtProviderObservation.Name = "TxtProviderObservation";
            TxtProviderObservation.PlaceholderText = "Provider Observation";
            TxtProviderObservation.Size = new Size(278, 94);
            TxtProviderObservation.TabIndex = 5;
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(21, 101);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Provider Name";
            TxtProviderName.Size = new Size(278, 23);
            TxtProviderName.TabIndex = 4;
            // 
            // TxtProvidId
            // 
            TxtProvidId.Location = new Point(21, 36);
            TxtProvidId.Name = "TxtProvidId";
            TxtProvidId.PlaceholderText = "0";
            TxtProvidId.Size = new Size(221, 23);
            TxtProvidId.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 149);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 2;
            label5.Text = "Provider Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 83);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 1;
            label4.Text = "Provider Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 18);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 0;
            label3.Text = "Provider ID";
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProviderView";
            Text = "ProviderView";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private Button BtnClosePr;
        private Button BtnDeletePr;
        private Button BtnEditPr;
        private Button BtnNewPr;
        private DataGridView DgProvider;
        private Button BtnSearchPr;
        private TextBox TxtSearchPr;
        private Label label2;
        private TextBox TxtProviderObservation;
        private TextBox TxtProviderName;
        private TextBox TxtProvidId;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}