using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket__mvp.Models
{
    internal interface IRepositoryCategorie
    {
        void Add(ModelCategorie payModeModelCategorie);
        void Edit(ModelCategorie payModeModelCategorie);
        void Delete(int id);

        IEnumerable<ModelCategorie> GetAll();
        IEnumerable<ModelCategorie> GetByValue(string value);


    }
}
