using CoreSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSample.Services
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int Id);
    }
}
