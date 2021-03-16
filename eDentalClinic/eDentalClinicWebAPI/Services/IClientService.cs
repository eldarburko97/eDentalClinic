using AutoMapper;
using eDentalClinic.Model.Requests;
using eDentalClinicWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Services
{
   public interface IClientService
    {
        List<eDentalClinic.Model.Client> GetAll(ClientSearchRequest search);

        eDentalClinic.Model.Client GetById(int id);

        eDentalClinic.Model.Client Insert(ClientInsertRequest request);

        eDentalClinic.Model.Client Update(int id, ClientInsertRequest request);
        eDentalClinic.Model.Client Authenticate(string username, string password);
    }
}
