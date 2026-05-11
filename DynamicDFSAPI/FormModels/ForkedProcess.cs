using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using log4net;

namespace CPS.Proof.DFSExtension
{

    [Serializable]
    [DataContract]
    public class ForkedProcess
    {
        [DataMember(Name = "FrkPrcId", EmitDefaultValue = false)]
        public string FrkPrcId { get; set; }

        [DataMember(Name = "FrkActMapId", EmitDefaultValue = false)]
        public string FrkActMapId { get; set; }

        [DataMember(Name = "MFId", EmitDefaultValue = false)]
        public string MFId { get; set; }

        [DataMember(Name = "NewInstanceId", EmitDefaultValue = false)]
        public string NewInstanceId { get; set; }

        [DataMember(Name = "InsertQuery", EmitDefaultValue = false)]
        public string InsertQuery { get; set; }
    }
}
