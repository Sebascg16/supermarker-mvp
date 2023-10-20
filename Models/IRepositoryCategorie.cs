using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket__mvp.Models
{
    internal interface IRepositoryCategorie
    {
        void Add(ModeModelCategorie payModeModelCategorie);
        void Edit(ModeModelCategorie payModeModelCategorie);
        void Delete(int id);

        IEnumerable<ModeModelCategorie> GetAll();
        IEnumerable<ModeModelCategorie> GetByValue(string value);


    }
}
