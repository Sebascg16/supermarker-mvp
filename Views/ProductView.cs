using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket__mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private String message;
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabProductDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearchP.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearchP.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            btnNewP.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Add New Product";

            };

            BtnEditP.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Edit Product";
            };

            BtnSaveP.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabProductDetail);
                    tabControl1.TabPages.Add(tabProductList);
                }
                MessageBox.Show(Message);
            };

            BtnCancelP.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductDetail);
                tabControl1.TabPages.Add(tabProductList);
            };

            BtnDeleteP.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Product",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }

        public string ProductId
        {
            get { return TxtIdP.Text; }
            set { TxtIdP.Text = value; }
        }
        public string ProductObservation
        {
            get { return TxtObservation.Text; }
            set { TxtObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearchP.Text; }
            set { TxtSearchP.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }

        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        string IProductView.ProductName
        {
            get { return TxtNameP.Text; }
            set { TxtNameP.Text = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBildingSource(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }

        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)

        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}
