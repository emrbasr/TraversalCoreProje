using DataAccess.Abstract;
using DataAccess.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class FeatureDal2:RepositoryBase<Feature2>,IFeatureDal2
    {
    }
}
