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
    [XmlTypeAttribute("OtherCertStatusRefsType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OtherCertStatusRefsType
    {
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _otherRef;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("OtherRef")]
        public List<AnyType> OtherRef
        {
            get
            {
                return _otherRef;
            }
            set
            {
                _otherRef = value;
            }
        }
    }
}
