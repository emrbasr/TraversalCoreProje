using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommandManager : ICommandService
    {
        ICommandDal _commmandDal;

        public CommandManager(ICommandDal commmandDal)
        {
            _commmandDal = commmandDal;
        }

        public void TAdd(Command entity)
        {
           _commmandDal.Insert(entity);
        }

        public void TDelete(Command entity)
        {
            throw new NotImplementedException();
        }

        public Command TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Command> TGetDestinationById(int id)
        {
            return _commmandDal.GetListByFilter(x => x.DestinationId == id);
        }

        public List<Command> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Command entity)
        {
            throw new NotImplementedException();
        }
    }
}
