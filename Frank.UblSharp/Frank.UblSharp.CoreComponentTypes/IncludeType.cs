namespace Frank.UblSharp.CoreComponentTypes
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("IncludeType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("Include", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IncludeType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("URI")]
        public string Uri { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("referencedData")]
        public bool ReferencedDataValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReferencedData-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReferencedData property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReferencedDataValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ReferencedData
        {
            get
            {
                if (this.ReferencedDataValueSpecified)
                {
                    return this.ReferencedDataValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReferencedDataValue = value.GetValueOrDefault();
                this.ReferencedDataValueSpecified = value.HasValue;
            }
        }
    }
}
