using RestCrudApi.Data.VO;
using RestCrudApi.Model;
using System.Collections.Generic;

namespace RestCrudApi.Business
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
