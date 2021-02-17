using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Interfaces
{
    public interface ISpecification
    {
        bool IsSatisfied(AbstractMenuComponent item);
    }
}
