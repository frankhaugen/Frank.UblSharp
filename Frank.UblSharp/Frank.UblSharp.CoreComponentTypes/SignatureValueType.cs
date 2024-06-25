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
    [XmlTypeAttribute("SignatureValueType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureValue", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft den Text ab oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [XmlTextAttribute(DataType="base64Binary")]
        public Byte[] Value { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}