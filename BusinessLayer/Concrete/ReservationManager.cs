using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation entity)
        {
            _reservationDal.insert(entity);
        }

        public void Delete(Reservation entity)
        {
            _reservationDal.delete(entity);
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByOld(int id)
        {
            return _reservationDal.GetListWithReservationByOld(id);
        }

        public List<Reservation> GetListWithReservationByWaitForApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitForApproval(id);
        }

        public void Update(Reservation entity)
        {
            _reservationDal.update(entity);
        }
    }
}
