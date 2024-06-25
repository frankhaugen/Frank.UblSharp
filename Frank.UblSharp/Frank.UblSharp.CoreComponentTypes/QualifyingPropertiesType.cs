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
    [XmlTypeAttribute("QualifyingPropertiesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("QualifyingProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesType
    {
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SignedProperties")]
        public SignedPropertiesType SignedProperties { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UnsignedProperties")]
        public UnsignedPropertiesType UnsignedProperties { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("Target")]
        public string Target { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}