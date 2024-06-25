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
    [XmlTypeAttribute("ValidationDataType", Namespace="http://uri.etsi.org/01903/v1.4.1#")]
    [XmlRootAttribute("TimeStampValidationData", Namespace="http://uri.etsi.org/01903/v1.4.1#")]
    public partial class ValidationDataType
    {
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CertificateValues", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public Frank.UblSharp.CoreComponentTypes.CertificateValuesType CertificateValues { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RevocationValues", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public Frank.UblSharp.CoreComponentTypes.RevocationValuesType RevocationValues { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("UR")]
        public string Ur { get; set; }
    }
}
