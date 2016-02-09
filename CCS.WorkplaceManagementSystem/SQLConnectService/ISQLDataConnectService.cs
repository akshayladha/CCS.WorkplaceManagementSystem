using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CCS.WorkplaceManagementSystem.Models;

namespace SQLConnectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISQLDataConnectService" in both code and config file together.
    [ServiceContract]
    public interface ISQLDataConnectService
    {
        [OperationContract]
        Machine GetMachineData(int value);

        [OperationContract]
        List<Section> GetDeskData(int status1, int status2, int status3, int status4);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "SQLConnectService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
