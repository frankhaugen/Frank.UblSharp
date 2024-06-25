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
    [XmlTypeAttribute("UnsignedDataObjectPropertiesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("UnsignedDataObjectProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class UnsignedDataObjectPropertiesType
    {
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _unsignedDataObjectProperty;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("UnsignedDataObjectProperty")]
        public List<AnyType> UnsignedDataObjectProperty
        {
            get
            {
                return _unsignedDataObjectProperty;
            }
            set
            {
                _unsignedDataObjectProperty = value;
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
