using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket__mvp.Views
{
    public partial class PayModelView : Form, IPayModeView
    {
        private bool IsEdit;
        private bool IsSuccessful;
        private string Message;

        public string PayModeId
        {
            get { return txtPayModeId.Text; }

            set { txtPayModeId.Text = value; }
        }

        public string PayModeName
        {
            get { return TxtPayModeName.Text; }

            set { TxtPayModeName.Text = value; }
        }

        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }

            set { TxtPayModeObservation.Text = value; }
        }

        public string SearchValue
        {
            get { return txtSearch.Text; }

            set { txtSearch.Text = value; }
        }

        bool IPayModeView.IsEdit
        {
            get { return IsEdit; }

            set { IsEdit = value; }
        }

        bool IPayModeView.IsSuccessful
        {
            get { return IsSuccessful; }

            set { IsSuccessful = value; }
        }

        string IPayModeView.Message
        {
            get { return Message; }
            set { Message = value; }
        }

        public PayModelView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModelDetail);

            btnCancel.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //Agregamos llame el evento AddNewEvent cuando se haga clic en el botón BtnNew
            btnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageModeList);
                tabControl1.TabPages.Add(tabPagePayModelDetail);
                tabPagePayModelDetail.Text = "Add new Pay Mode"; //Cambia el titulo de la pestaña

            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageModeList);
                tabControl1.TabPages.Add(tabPagePayModelDetail);
                tabPagePayModelDetail.Text = "Edit Pay Mode";
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageModeList);
                    tabControl1.TabPages.Add(tabPagePayModelDetail);
                }
                MessageBox.Show(Message);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageModeList);
                tabControl1.TabPages.Add(tabPagePayModelDetail);
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay mode", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        private static PayModelView instance;

        public static PayModelView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModelView();
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
        private void DgPayMode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PayModelView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
