using BusinessLayer.Abstract.AbstractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _accountDal = accountDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public Account GetById(int id)
        {
            return _accountDal.GetById(id);
        }

        public void insert(Account t)
        {
            _accountDal.insert(t);
            _unitOfWorkDal.Save();
        }

        public void MultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void update(Account t)
        {
            _accountDal.update(t);
            _unitOfWorkDal.Save();
        }
    }
}
