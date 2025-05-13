using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void Update(T t);
        List<T> TGetList();
        T GetById(int id);
    }
}
