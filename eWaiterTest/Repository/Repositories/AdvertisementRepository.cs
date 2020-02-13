using Contracts;
using Contracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Repositories
{
    public class AdvertisementRepository : RepositoryBase<Advertisement>, IAdvertisement
    {
        public AdvertisementRepository(eWaiterTestContext context):base(context)
        {

        }

        public IEnumerable<Advertisement> GetAllAdvertisements()
        {
            return FindAll()
                .OrderBy(r => r.DateActiveFrom)
                .ToList();
        }
    }
}
