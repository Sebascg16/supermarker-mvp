using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket__mvp.Models;
using Supermarket__mvp.Views;
using Supermarket__mvp._Repositories;

namespace Supermarket__mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowViewCategorie += ShowViewCategorie;
            this.mainView.ShowProductView += ShowProductView;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString) ;
            new ProductPresenter(view, repository);
        }

        private void ShowViewCategorie(object? sender, EventArgs e)
        {
            ICategorie view = ViewCategorie.GetInstance((MainView)mainView);
            IRepositoryCategorie reposity = new RepositoryCategorie(sqlConnectionString);
            new PresenterCategorie(view, reposity);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModelView.GetInstance((MainView)mainView);
            IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, reposity);
        }

        private void ShowProviderView(object? sender, EventArgs e)
        {
            IProviderView view = ProviderView.GetInstance((MainView)mainView);
            IProviderRepository repository = new ProviderRepository(sqlConnectionString);
            new ProviderPresenter(view, repository);
        }

    }
}