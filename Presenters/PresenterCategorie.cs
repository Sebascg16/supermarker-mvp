using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket__mvp.Views;
using Supermarket__mvp.Models;
using Supermarket__mvp._Repositories;

namespace Supermarket__mvp.Presenters
{
    internal class PresenterCategorie
    {
        private ICategorie view;
        private IRepositoryCategorie repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<ModelCategorie> categorieList;

        public PresenterCategorie(ICategorie view, IRepositoryCategorie repository)
        {
            this.categorieBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategorie;
            this.view.AddNewEvent += AddNewCategorie;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategorie;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(categorieBindingSource);
;

            loadAllCategorieList();

            this.view.Show();
        }

        private void loadAllCategorieList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategorie(object? sender, EventArgs e)
        {
            var categorie = new ModelCategorie();

            categorie.Id = Convert.ToInt32(view.CategorieId);
            categorie.Name = view.CategorieName;
            categorie.Observation = view.CategorieObservation;

            try
            {
                new Common.ModelDataValidation().validate(categorie);
                if (view.IsEdit)
                {
                    repository.Edit(categorie);
                    view.Message = "Categorie edited Successfuly";
                }
                else
                {
                    repository.Add(categorie);
                    view.Message = "Categorie added successfuly";
                }
                view.IsSuccessful = true;
                
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                loadAllCategorieList();
                CleanViewFields();
            }
        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            try
            {
                var categorie = (ModelCategorie)categorieBindingSource.Current;

                repository.Delete(categorie.Id);
                view.IsSuccessful = true;
                view.Message = "Categorie deleted successfully";
                loadAllCategorieList();
            }
            catch 
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could or delete categorie";
            }

        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categorie = (ModelCategorie)categorieBindingSource.Current;
            view.CategorieId = categorie.Id.ToString();
            view.CategorieName = categorie.Name;
            view.CategorieObservation = categorie.Observation;

            view.IsEdit = true;
            
        }

        private void AddNewCategorie(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategorie(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categorieBindingSource.DataSource = categorieList;
        }

        private void CleanViewFields()
        {
            view.CategorieId = "0";
            view.CategorieName = "";
            view.CategorieObservation = "";
        }
    }

}
