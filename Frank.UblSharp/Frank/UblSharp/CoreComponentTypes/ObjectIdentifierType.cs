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
    [XmlTypeAttribute("ObjectIdentifierType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("ObjectIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class ObjectIdentifierType
    {

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }

        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlElementAttribute("Identifier")]
        public IdentifierType_3 Identifier { get; set; }

        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Description")]
        public string Description { get; set; }

        [XmlArrayAttribute("DocumentationReferences")]
        [XmlArrayItemAttribute("DocumentationReference", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public Collection<string> DocumentationReferences { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentationReferences collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DocumentationReferencesSpecified
        {
            get
            {
                return ((this.DocumentationReferences != null)
                            && (this.DocumentationReferences.Count != 0));
            }
        }
    }
}
