using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_Injection_Dependances.Services
{
    public interface ISalaryCalculator
    {
       Double CalculateSalary(Double yearlyAmount);
    }
}
