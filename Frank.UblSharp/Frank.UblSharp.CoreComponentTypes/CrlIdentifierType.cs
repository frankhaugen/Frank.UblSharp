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
    [XmlTypeAttribute("CRLIdentifierType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CrlIdentifierType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Issuer")]
        public string Issuer { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("IssueTime", DataType="dateTime")]
        public DateTime IssueTime { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Number")]
        public int NumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Number-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Number property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> Number
        {
            get
            {
                if (this.NumberValueSpecified)
                {
                    return this.NumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberValue = value.GetValueOrDefault();
                this.NumberValueSpecified = value.HasValue;
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("URI")]
        public string Uri { get; set; }
    }
}
