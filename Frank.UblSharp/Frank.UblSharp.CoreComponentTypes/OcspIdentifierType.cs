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
    [XmlTypeAttribute("OCSPIdentifierType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OcspIdentifierType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ResponderID")]
        public ResponderIdType ResponderId { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ProducedAt", DataType="dateTime")]
        public DateTime ProducedAt { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("URI")]
        public string Uri { get; set; }
    }
}