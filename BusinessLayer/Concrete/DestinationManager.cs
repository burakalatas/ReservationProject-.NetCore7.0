﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination entity)
        {
            _destinationDal.insert(entity);
        }

        public void Delete(Destination entity)
        {
            _destinationDal.delete(entity);
        }

        public Destination GetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public Destination GetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> GetLast4Destination()
        {
            return _destinationDal.GetLast4Destination();
        }

        public List<Destination> GetList()
        {
            return _destinationDal.list();
        }

        public void Update(Destination entity)
        {
            _destinationDal.update(entity);
        }
    }
}
