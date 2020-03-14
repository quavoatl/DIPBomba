using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces
{
    interface IAuthorizedPerson : IPerson
    {
        public void BagaCategorieInPermis(IDrivePerson persoanaCuPermisacio,
            Enums.CategoriePermis categ);
    }
}
