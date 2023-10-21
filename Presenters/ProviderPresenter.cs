using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket__mvp.Models;
using Supermarket__mvp.Views;

namespace Supermarket__mvp.Presenters
{
    internal class ProviderPresenter
    {
        private IProviderView view;
        private IProviderRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProviderModel> providerList;

        public ProviderPresenter(IProviderView view, IProviderRepository repository)
        {
            this.providerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DeleteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBildingSource(providerBindingSource);
            LoadAllProviderList();
            this.view.Show();

        }

        private void LoadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProvider(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }
    }
}
