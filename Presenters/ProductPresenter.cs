using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket__mvp.Views;
using Supermarket__mvp.Models;
using System.Data;

namespace Supermarket__mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteProductCategorie;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);

            LoadAllProductList();

            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();

            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductName;
            product.Observation = view.ProductObservation;

            try
            {
                new Common.ModelDataValidation().validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited Succesfelly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccesful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductObservation = "";
        }

        private void DeleteProductCategorie(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccesful = true;
                view.Message = "Product deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete product";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductObservation = product.Observation;
            view.IsEdit = true;

        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}
