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
    [XmlTypeAttribute("OtherCertStatusValuesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OtherCertStatusValuesType
    {
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _otherValue;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("OtherValue")]
        public List<AnyType> OtherValue
        {
            get
            {
                return _otherValue;
            }
            set
            {
                _otherValue = value;
            }
        }
    }
}