using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data.Common;
using System.Transactions;

namespace CPS.Proof.DFSExtension
{
    public class PageContext
    {
        /// <summary>
        /// Represents the <see cref="SlotId"/> that holds instance details.
        /// </summary>
        public string SlotId { get; set; }

        /// <summary>
        /// Represents the <see cref="SlotId"/> that holds instance details.
        /// </summary>
        public bool GenerateInstanceName { get; set; }

        /// <summary>
        /// Represents the <see cref="InstanceInfo"/> that holds instance details.
        /// </summary>
        public FormInstanceInfo InstanceContext { get; set; }

        /// <summary>
        /// Represents the property that is used to get 
        /// and set the ispace command details.
        /// </summary>
        public FormInstanceCommand InstanceCommand { get; set; }

        public Dictionary<string, string>? KeyElements { get; set; }

        public FormStatus Status { get; set; }

        public FormSuspendedReason SuspendedReason { get; set; }

        public TransactionObject TransactionObject { get; set; }

        /// <summary>
        /// Gets/sets the process type.
        /// </summary>
        public ProcessType ProcessType
        {
            get;
            set;
        }
    }

    

    public class FormInstanceInfo
    {

        [DataMember(Name = "SlId", IsRequired = true, EmitDefaultValue = false)]
        public SlotToken? SlId { get; set; }
        
        [DataMember(Name = "InsId", IsRequired = false, EmitDefaultValue = false)]
        public string? InsId { get; set; }

        [DataMember(Name = "IName", IsRequired = false, EmitDefaultValue = false)]
        public string? IName { get; set; }

        [DataMember(Name = "ElmId", IsRequired = false, EmitDefaultValue = false)]
        public string ElmId { get; set; }

        [DataMember(Name = "PPM", IsRequired = false, EmitDefaultValue = false)]
        public string PPM { get; set; }         
             
        [DataMember(Name = "PamId", IsRequired = false, EmitDefaultValue = false)]
        public string PamId { get; set; }


        [DataMember(Name = "AName", IsRequired = false, EmitDefaultValue = false)]
        public string AName { get; set; }

        [DataMember(Name = "FV", IsRequired = false, EmitDefaultValue = false)]
        public string FV { get; set; }

        [DataMember(Name = "FGId", IsRequired = false, EmitDefaultValue = false)]
        public string FGId { get; set; }

        [DataMember(Name = "FGrp", IsRequired = false, EmitDefaultValue = false)]
        public string FGrp { get; set; }

        [DataMember(Name = "UpdOn", IsRequired = false, EmitDefaultValue = false)]
        public string UpdOn { get; set; }

        [DataMember(Name = "UpdBy", IsRequired = false, EmitDefaultValue = false)]
        public long UpdBy { get; set; }

        [DataMember(Name = "DAtId", IsRequired = false, EmitDefaultValue = false)]
        public string DAtId { get; set; }

        [DataMember(Name = "DActNm", IsRequired = false, EmitDefaultValue = false)]
        public string DActNm { get; set; }

        [DataMember(Name = "ICode", IsRequired = false, EmitDefaultValue = false)]
        public InstanceCodes ICode { get; set; }

        [DataMember(Name = "PICode", IsRequired = false, EmitDefaultValue = false)]
        public InstanceCodes PICode { get; set; }

        [DataMember(Name = "IDesc", IsRequired = false, EmitDefaultValue = false)]
        public string IDesc { get; set; }
              
        [DataMember(Name = "MFId", IsRequired = false, EmitDefaultValue = false)]
        public string MFId { get; set; }

        [DataMember(Name = "Ver", IsRequired = false, EmitDefaultValue = false)]
        public decimal Ver { get; set; }
              

        [DataMember(Name = "InsCmd", IsRequired = false, EmitDefaultValue = false)]
        public string InsCmd { get; set; }                    

        [DataMember(Name = "Vwprt", IsRequired = false, EmitDefaultValue = false)]
        public ViewportTypes Viewport { get; set; }
                          

        [DataMember(Name = "InsSt", IsRequired = false, EmitDefaultValue = false)]
        public InstanceOperationType InsSt { get; set; }

        [DataMember(Name = "PInsId", IsRequired = false, EmitDefaultValue = false)]
        public string PInsId { get; set; }         

        [DataMember(Name = "VpamId", IsRequired = false, EmitDefaultValue = false)]
        public string VpamId { get; set; }

        [DataMember(Name = "Sub", IsRequired = false, EmitDefaultValue = false)]
        public string? Sub { get; set; }

        [DataMember(Name = "AsgnUserId", IsRequired = false, EmitDefaultValue = false)]
        public string? AsgnUserId { get; set; }

        [DataMember(Name = "AsgnRMId", IsRequired = false, EmitDefaultValue = false)]
        public string? AsgnRMId { get; set; }

        [DataMember(Name = "sla", IsRequired = false, EmitDefaultValue = false)]
        public string Sla { get; set; }      

        [DataMember(Name = "slatrig", IsRequired = false, EmitDefaultValue = false)]
        public string SlaTrigger { get; set; }

        [DataMember(Name = "elapsedtime", IsRequired = false, EmitDefaultValue = false)]
        public double ElapsedTime { get; set; }

        [DataMember(Name = "ValStatus", IsRequired = false, EmitDefaultValue = false)]
        public ValidationFlag ValStatus { get; set; }

        [DataMember(Name = "State", IsRequired = false, EmitDefaultValue = false)]
        public StateType State { get; set; }
            

    }

     public class TransactionObject
    {
        public List<Tuple<string, CommittableTransaction, DbConnection>> Connections
        {
            get;
            set;
        }

        public Dictionary<string, CommittableTransaction> Transactions
        {
            get;
            set;
        }
    }

}

