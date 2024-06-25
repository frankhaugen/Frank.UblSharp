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
    [XmlTypeAttribute("SignaturePropertiesType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureProperties", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignaturePropertiesType
    {
        
        [XmlIgnoreAttribute()]
        private List<SignaturePropertyType> _signatureProperty;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SignatureProperty")]
        public List<SignaturePropertyType> SignatureProperty
        {
            get
            {
                return _signatureProperty;
            }
            set
            {
                _signatureProperty = value;
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
