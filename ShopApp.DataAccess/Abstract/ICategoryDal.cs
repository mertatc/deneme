using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using ShopApp.Entities;


namespace ShopApp.DataAccess.Abstract
{
    public interface ICategoryDal:IRepository<Entities.Category>
    {
    }
}
