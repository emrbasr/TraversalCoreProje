using DataAccess.Abstract;
using DataAccess.Repository;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class CommandDal : RepositoryBase<Command>, ICommandDal
    {
    }
}
