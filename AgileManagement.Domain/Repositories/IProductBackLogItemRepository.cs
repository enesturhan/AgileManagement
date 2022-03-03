using AgileManagement.Core;
using AgileManagement.Domain;
using AgileManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Domain
{
    public interface IProductBackLogItemRepository: IGenericRepository<ProductBackLogItem>
    {
    }
}
