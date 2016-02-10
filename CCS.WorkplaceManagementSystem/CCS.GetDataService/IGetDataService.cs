using System.Collections.Generic;
using System.ServiceModel;
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.GetDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetDataService" in both code and config file together.
    [ServiceContract]
    public interface IGetDataService
    {

        [OperationContract]
        Machine GetMachineData(int value);

        [OperationContract]
        List<Section> GetDeskData(int status1, int status2, int status3, int status4);

        // TODO: Add your service operations here
    }
}
