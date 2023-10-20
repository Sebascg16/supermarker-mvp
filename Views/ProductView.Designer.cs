namespace Supermarket__mvp.Views
{
    partial class ProductView
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
            tabProductList = new TabPage();
            btnCloseP = new Button();
            BtnDeleteP = new Button();
            BtnEditP = new Button();
            btnNewP = new Button();
            DgProduct = new DataGridView();
            btnSearchP = new Button();
            TxtSearchP = new TextBox();
            label2 = new Label();
            tabProductDetail = new TabPage();
            BtnCancelP = new Button();
            BtnSaveP = new Button();
            TxtObservation = new TextBox();
            TxtNameP = new TextBox();
            TxtIdP = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabProductDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.Producto;
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(167, 29);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Controls.Add(tabProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabProductList
            // 
            tabProductList.Controls.Add(btnCloseP);
            tabProductList.Controls.Add(BtnDeleteP);
            tabProductList.Controls.Add(BtnEditP);
            tabProductList.Controls.Add(btnNewP);
            tabProductList.Controls.Add(DgProduct);
            tabProductList.Controls.Add(btnSearchP);
            tabProductList.Controls.Add(TxtSearchP);
            tabProductList.Controls.Add(label2);
            tabProductList.Location = new Point(4, 24);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3);
            tabProductList.Size = new Size(792, 322);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Product List";
            tabProductList.UseVisualStyleBackColor = true;
            // 
            // btnCloseP
            // 
            btnCloseP.Image = Properties.Resources.cerrar;
            btnCloseP.Location = new Point(485, 245);
            btnCloseP.Name = "btnCloseP";
            btnCloseP.Size = new Size(49, 46);
            btnCloseP.TabIndex = 7;
            btnCloseP.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteP
            // 
            BtnDeleteP.Image = Properties.Resources.delete;
            BtnDeleteP.Location = new Point(485, 187);
            BtnDeleteP.Name = "BtnDeleteP";
            BtnDeleteP.Size = new Size(49, 37);
            BtnDeleteP.TabIndex = 6;
            BtnDeleteP.Text = " ";
            BtnDeleteP.UseVisualStyleBackColor = true;
            // 
            // BtnEditP
            // 
            BtnEditP.Image = Properties.Resources.edit;
            BtnEditP.Location = new Point(485, 129);
            BtnEditP.Name = "BtnEditP";
            BtnEditP.Size = new Size(49, 40);
            BtnEditP.TabIndex = 5;
            BtnEditP.UseVisualStyleBackColor = true;
            // 
            // btnNewP
            // 
            btnNewP.Image = Properties.Resources._new;
            btnNewP.Location = new Point(485, 73);
            btnNewP.Name = "btnNewP";
            btnNewP.Size = new Size(49, 39);
            btnNewP.TabIndex = 4;
            btnNewP.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(28, 73);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(437, 218);
            DgProduct.TabIndex = 3;
            // 
            // btnSearchP
            // 
            btnSearchP.Image = Properties.Resources.search_small;
            btnSearchP.Location = new Point(471, 7);
            btnSearchP.Name = "btnSearchP";
            btnSearchP.Size = new Size(47, 49);
            btnSearchP.TabIndex = 2;
            btnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearchP
            // 
            TxtSearchP.Location = new Point(24, 33);
            TxtSearchP.Name = "TxtSearchP";
            TxtSearchP.PlaceholderText = "Data to Search";
            TxtSearchP.Size = new Size(441, 23);
            TxtSearchP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 15);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // tabProductDetail
            // 
            tabProductDetail.Controls.Add(BtnCancelP);
            tabProductDetail.Controls.Add(BtnSaveP);
            tabProductDetail.Controls.Add(TxtObservation);
            tabProductDetail.Controls.Add(TxtNameP);
            tabProductDetail.Controls.Add(TxtIdP);
            tabProductDetail.Controls.Add(label5);
            tabProductDetail.Controls.Add(label4);
            tabProductDetail.Controls.Add(label3);
            tabProductDetail.Location = new Point(4, 24);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3);
            tabProductDetail.Size = new Size(792, 322);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Product Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelP
            // 
            BtnCancelP.Image = Properties.Resources.cancel;
            BtnCancelP.Location = new Point(130, 255);
            BtnCancelP.Name = "BtnCancelP";
            BtnCancelP.Size = new Size(55, 42);
            BtnCancelP.TabIndex = 7;
            BtnCancelP.UseVisualStyleBackColor = true;
            // 
            // BtnSaveP
            // 
            BtnSaveP.Image = Properties.Resources.save;
            BtnSaveP.Location = new Point(44, 255);
            BtnSaveP.Name = "BtnSaveP";
            BtnSaveP.Size = new Size(53, 42);
            BtnSaveP.TabIndex = 6;
            BtnSaveP.UseVisualStyleBackColor = true;
            // 
            // TxtObservation
            // 
            TxtObservation.Location = new Point(19, 154);
            TxtObservation.Multiline = true;
            TxtObservation.Name = "TxtObservation";
            TxtObservation.PlaceholderText = "Product Observation";
            TxtObservation.Size = new Size(246, 82);
            TxtObservation.TabIndex = 5;
            // 
            // TxtNameP
            // 
            TxtNameP.Location = new Point(19, 91);
            TxtNameP.Name = "TxtNameP";
            TxtNameP.PlaceholderText = "Product Name";
            TxtNameP.Size = new Size(265, 23);
            TxtNameP.TabIndex = 4;
            // 
            // TxtIdP
            // 
            TxtIdP.Location = new Point(19, 31);
            TxtIdP.Name = "TxtIdP";
            TxtIdP.Size = new Size(175, 23);
            TxtIdP.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 136);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 2;
            label5.Text = "Product Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 73);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 13);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabProductList;
        private TextBox TxtSearchP;
        private Label label2;
        private TabPage tabProductDetail;
        private Button btnCloseP;
        private Button BtnDeleteP;
        private Button BtnEditP;
        private Button btnNewP;
        private DataGridView DgProduct;
        private Button btnSearchP;
        private Button BtnCancelP;
        private Button BtnSaveP;
        private TextBox TxtObservation;
        private TextBox TxtNameP;
        private TextBox TxtIdP;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}