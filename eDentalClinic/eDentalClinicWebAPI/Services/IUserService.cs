using eDentalClinic.Model;
using eDentalClinic.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Services
{
    public interface IUserService
    {
        List<Client> GetAll(UserSearchRequest search);
        Client GetById(int userId);
        User Insert(UserInsertRequest request);
        Client Update(int id, UserInsertRequest request);
        User Authenticate(string username, string password);
        User Register(UserInsertRequest request);
    }
}
