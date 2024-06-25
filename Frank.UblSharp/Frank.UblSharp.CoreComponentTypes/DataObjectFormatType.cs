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
    [XmlTypeAttribute("DataObjectFormatType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("DataObjectFormat", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class DataObjectFormatType
    {
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Description")]
        public string Description { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ObjectIdentifier")]
        public ObjectIdentifierType ObjectIdentifier { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MimeType")]
        public string MimeType { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Encoding")]
        public string Encoding { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("ObjectReference")]
        public string ObjectReference { get; set; }
    }
}
