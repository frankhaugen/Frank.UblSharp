//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.CoreComponentTypes
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;


    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("SignedInfoType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlElementAttribute("CanonicalizationMethod")]
        public CanonicalizationMethodType_2 CanonicalizationMethod { get; set; }

        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlElementAttribute("SignatureMethod")]
        public SignatureMethodType_2 SignatureMethod { get; set; }

        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlElementAttribute("Reference")]
        public Collection<ReferenceType_2> Reference { get; set; }
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        [KeyAttribute()]
        public string Id { get; set; }
    }
}
