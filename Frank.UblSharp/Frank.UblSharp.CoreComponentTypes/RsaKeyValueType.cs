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
    [XmlTypeAttribute("RSAKeyValueType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("RSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class RsaKeyValueType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Modulus", DataType="base64Binary")]
        public Byte[] Modulus { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Exponent", DataType="base64Binary")]
        public Byte[] Exponent { get; set; }
    }
}
