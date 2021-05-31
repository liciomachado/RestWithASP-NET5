using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO Book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO Book);
        void Delete(long id);
    }
}
