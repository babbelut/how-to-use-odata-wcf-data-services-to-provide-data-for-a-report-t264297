using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T264297.NwindServiceReference;

namespace T264297 {
    class NorthwindModel {
        NorthwindEntities context = new NorthwindEntities(new Uri("http://services.odata.org/V3/Northwind/Northwind.svc"));
        public List<Category> Categories() {
            return context.Categories.Expand("Products").ToList();
        }
    }
}
