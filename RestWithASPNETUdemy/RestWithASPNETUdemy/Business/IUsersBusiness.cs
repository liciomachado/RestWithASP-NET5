using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IUsersBusiness
    {
        UserVO Create(UserVO Product);
        UserVO FindById(long id);
        List<UserVO> FindAll();
        UserVO Update(UserVO Product);
        void Delete(long id);
    }
}
