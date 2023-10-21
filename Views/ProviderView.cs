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
    public partial class ProviderView : Form, IProviderView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProviderView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProviderDetail);
            BtnClosePr.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchPr.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearchPr.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string ProviderId
        {
            get { return TxtProvidId.Text; }

            set { TxtProvidId.Text = value; }
        }
        public string ProviderName
        {
            get { return TxtProviderName.Text; }

            set { TxtProviderName.Text = value; }
        }
        public string ProviderObservation
        {
            get { return TxtProviderObservation.Text; }

            set { TxtProviderObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearchPr.Text; }
            set { TxtSearchPr.Text = value; }
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProviderListBildingSource(BindingSource providerList)
        {
            DgProvider.DataSource = providerList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static ProviderView instance;

        public static ProviderView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProviderView();
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
