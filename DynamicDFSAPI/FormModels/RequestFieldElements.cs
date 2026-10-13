using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Proof.DFSExtension
{
    public class RequestFieldElements
    {
        /// <summary>
        /// Gets or sets a <see cref="string"/> 
        /// that contains the ConnectionSettingsId
        /// </summary>      
        public string ConnectionSettingsId { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="string"/> 
        /// that contains the ConnectionSettingsId
        /// </summary>      
        public string PackageProcessMapId { get; set; }


        /// <summary>
        /// Gets or sets a <see cref="string"/> 
        /// that contains the FieldName
        /// </summary>    
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or sets the DataTypeId.
        /// </summary>      
        public int DataTypeId { get; set; }

        /// <summary>
        /// Gets or sets the DefaultValue.
        /// </summary>     
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the Sequence.
        /// </summary>      
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets the RowId.
        /// </summary>      
        public string RowId { get; set; }

        /// <summary>
        /// Gets or sets the param type.
        /// 1-QueryParam
        /// 2-BodyParam
        /// 3-HeaderParam
        /// </summary>     
        public byte ParamType { get; set; }

        /// <summary>
        /// Gets or sets the RowId.
        /// </summary>   
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the ElementName.
        /// </summary>
        public string ElementName { get; set; }


        /// <summary>
        /// Gets or sets the JsonPath.
        /// </summary>     
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the JsonPath.
        /// </summary>      
        public byte? PathType { get; set; }
    }
}
