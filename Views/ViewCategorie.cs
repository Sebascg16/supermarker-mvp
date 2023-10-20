﻿using System;
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
    public partial class ViewCategorie : Form, ICategorie
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public string PayModeId
        {
            get { return txtPayModeIdC.Text; }

            set { txtPayModeIdC.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeNameC.Text; }

            set { TxtPayModeNameC.Text = value; }
        }

        public string PayModeObservation
        {
            get { return TxtPayModeObservationC.Text; }

            set { TxtPayModeObservationC.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearchC.Text; }

            set { txtSearchC.Text = value; }
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

        public ViewCategorie()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCategorieDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearchC.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            txtSearchC.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }
                };
            btnNewC.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieList);
                tabControl1.TabPages.Add(tabPageCategorieDetail);
                tabPageCategorieDetail.Text = "Add new Categorie";
            };
            BtnEditC.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDeleteC.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            BtnSaveC.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            BtnCancelC.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
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

        private void DgPayModeC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayModeC.DataSource = payModeList;
        }

        private static ViewCategorie instance;

        public static ViewCategorie GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ViewCategorie();
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

        public void SetCategorieListBildingSource(BindingSource categorieList)
        {
            DgPayModeC.DataSource = categorieList;
        }
    }
}
