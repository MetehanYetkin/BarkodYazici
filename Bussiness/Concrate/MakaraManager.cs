using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrate
{
    public class MakaraManager : IMakaraService
    {
        IMakaraDal _makaraDal;
        public MakaraManager(IMakaraDal makaraDal)
        {
            _makaraDal = makaraDal;
        }
        public void Add(Makara makara)
        {
            _makaraDal.Add(makara);
        }

        public void Delete(Makara makara)
        {
            _makaraDal.Delete(makara);
        }

        public List<Makara> GetAll()
        {
            return new List<Makara>(_makaraDal.GetAll());
        }

        public void Update(Makara makara)
        {
            _makaraDal.Update(makara);
        }
    }
}
