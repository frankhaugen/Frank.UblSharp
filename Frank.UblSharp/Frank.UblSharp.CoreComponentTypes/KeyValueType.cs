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
    [XmlTypeAttribute("KeyValueType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("KeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyValueType
    {
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DSAKeyValue")]
        public DsaKeyValueType DsaKeyValue { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RSAKeyValue")]
        public RsaKeyValueType RsaKeyValue { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAnyElementAttribute()]
        public XmlElement Any { get; set; }
        
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
}
