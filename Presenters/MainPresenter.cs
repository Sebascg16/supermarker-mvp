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
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModelView.GetInstance();
            IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, reposity);
        }
    }
}
