using MyLeasings.Data.Entities;
using MyLeasings.Models;
using System.Threading.Tasks;

namespace MyLeasings.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);

        PropertyViewModel ToPropertyViewModel(Property property);

        Task<Contract> ToContractAsync(ContractViewModel model, bool isNew);

        ContractViewModel ToContractViewModel(Contract contract);
    }
}
