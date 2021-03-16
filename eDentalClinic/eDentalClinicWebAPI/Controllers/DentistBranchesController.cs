using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eDentalClinic.Model;
using eDentalClinic.Model.Requests;
using eDentalClinicWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDentalClinicWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DentistBranchesController : BaseCRUDController<DentistBranch, DentistBranchSearchRequest, DentistBranchInsertRequest, DentistBranchInsertRequest>
    {
        public DentistBranchesController(ICRUDService<DentistBranch, DentistBranchSearchRequest, DentistBranchInsertRequest, DentistBranchInsertRequest> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}