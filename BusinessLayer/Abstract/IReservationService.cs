using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitForApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByOld(int id);
    }
}
