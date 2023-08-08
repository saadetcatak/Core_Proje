using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SendMessageManager : IMessageService
    {
        IMessageDal _messageDal;
        private EfServiceDal efServiceDal;

        public SendMessageManager(EfServiceDal efServiceDal)
        {
            this.efServiceDal = efServiceDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetByID(int id)
        {
           return _messageDal.GetByID(id);
        }

        public List<Message> TGetList()
        {
           return _messageDal.GetList();
        }

        public void TUpdate(Message t)
        {
           _messageDal.Update(t);
        }
    }
}
