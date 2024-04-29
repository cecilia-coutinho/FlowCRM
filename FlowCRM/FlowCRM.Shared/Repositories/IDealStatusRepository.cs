using FlowCRM.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Repositories
{
    public interface IDealStatusRepository
    {
        Task<IEnumerable<DealStatus>> GetDealStatusesAsync();
        Task<DealStatus> GetDealStatusAsync(Guid id);
    }
}
