using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket__mvp.Views;
using Supermarket__mvp.Models;



namespace Supermarket__mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;


            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();

        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var PayMode = new PayModeModel(); ;

            PayMode.Id = Convert.ToInt32(view.PayModeId);
            PayMode.Name = view.PayModeName;
            PayMode.Observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().validate(PayMode);
                if(view.IsEdit)
                {
                    repository.Edit(PayMode);
                    view.Message = "Paymode edited successfuly";
                }
                else
                {
                    repository.Add(PayMode);
                    view.Message = "Paymode added successfuly";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                loadAllPayModeList();
                CleanViewFields();

            }
        }
        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel) payModeBindingSource.Current;

                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode Deleted Successfully";
                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred , could not delete pay mode";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var PayMode = (PayModeModel)payModeBindingSource.Current;

            //Se cambia el contenido de las cajas de texto por el objeto recuperado del datagridview

            view.PayModeId = PayMode.Id.ToString();
            view.PayModeName = PayMode.Name;
            view.PayModeObservation = PayMode.Observation;

            //Se establece el modo edición

            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
