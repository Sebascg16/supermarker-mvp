using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket__mvp.Models
{
    internal interface IPayModeRepositoryCategorie
    {
        void Add(PayModeModelCategorie payModeModelCategorie);
        void Edit(PayModeModelCategorie payModeModelCategorie);
        void Delete(int id);

        IEnumerable<PayModeModelCategorie> GetAll();
        IEnumerable<PayModeModelCategorie> GetByValue(string value);


    }
}
