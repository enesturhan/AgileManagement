using AgileManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Domain.Models
{
    public class Sprint:Entity
    {


        public DateTime StartDate { get; private set; }
        public DateTime FinishDate { get; private set; }



        public List<ProductBackLogItem> ProductBackLogItems { get; private set; }


        //public void AddBackLogItem(ProductBackLogItemTask task)
        //{

        // //   ProductBackLogItems.Add(task);

        //}

    }
}
