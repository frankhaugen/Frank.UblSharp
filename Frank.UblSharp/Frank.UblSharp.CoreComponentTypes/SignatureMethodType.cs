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
    [XmlTypeAttribute("SignatureMethodType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureMethod", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureMethodType
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("HMACOutputLength")]
        public int HmacOutputLengthValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HmacOutputLength-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HmacOutputLength property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HmacOutputLengthValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> HmacOutputLength
        {
            get
            {
                if (this.HmacOutputLengthValueSpecified)
                {
                    return this.HmacOutputLengthValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HmacOutputLengthValue = value.GetValueOrDefault();
                this.HmacOutputLengthValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XmlElement> _any;
        
        [XmlAnyElementAttribute()]
        public List<XmlElement> Any
        {
            get
            {
                return _any;
            }
            set
            {
                _any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Any-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get
            {
                return ((this.Any != null) 
                            && (this.Any.Count != 0));
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("Algorithm")]
        public string Algorithm { get; set; }
        
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
}
