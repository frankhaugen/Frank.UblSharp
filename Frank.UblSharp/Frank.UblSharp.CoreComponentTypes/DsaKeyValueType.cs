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
    [XmlTypeAttribute("DSAKeyValueType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("DSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class DsaKeyValueType
    {
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("P", DataType="base64Binary")]
        public Byte[] P { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Q", DataType="base64Binary")]
        public Byte[] Q { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("G", DataType="base64Binary")]
        public Byte[] G { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Y", DataType="base64Binary")]
        public Byte[] Y { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("J", DataType="base64Binary")]
        public Byte[] J { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Seed", DataType="base64Binary")]
        public Byte[] Seed { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PgenCounter", DataType="base64Binary")]
        public Byte[] PgenCounter { get; set; }
    }
}