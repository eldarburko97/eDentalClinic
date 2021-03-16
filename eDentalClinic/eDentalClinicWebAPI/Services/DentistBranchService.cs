using AutoMapper;
using eDentalClinic.Model.Requests;
using eDentalClinicWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Services
{
    public class DentistBranchService : CRUDService<eDentalClinic.Model.DentistBranch, DentistBranchSearchRequest, Database.DentistBranch, DentistBranchInsertRequest, DentistBranchInsertRequest>
    {
        private eDentalClinicContext _context;
        private IMapper _mapper;

        public DentistBranchService(eDentalClinicContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
