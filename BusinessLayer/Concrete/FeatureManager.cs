using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FeatureManager : IFeatureDal
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Delete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
          return _featureDal.GetList();
        }

        public void Insert(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
