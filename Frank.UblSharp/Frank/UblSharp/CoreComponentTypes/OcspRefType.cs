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
    [XmlTypeAttribute("OCSPRefType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [DebuggerStepThroughAttribute()]
    public partial class OcspRefType
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("OCSPIdentifier", Order=0)]
        public OcspIdentifierType OcspIdentifier { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DigestAlgAndValue", Order=1)]
        public DigestAlgAndValueType DigestAlgAndValue { get; set; }
    }
}
