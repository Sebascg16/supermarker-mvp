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

        public bool IsEdit
        {
            get { return IsEdit; }

            set { IsEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return IsSuccessful; }

            set { IsSuccessful = value; }
        }

        public string Message
        {
            get { return Message; }
            set { Message = value; }
        }

        public PayModelView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModelDetail);
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

        private void DgPayMode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
