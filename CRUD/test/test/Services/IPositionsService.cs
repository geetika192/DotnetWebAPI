using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAngularCrudDemo.Models;

namespace AspNetCoreAngularCrudDemo.Services
{
    public interface IPositionsService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
