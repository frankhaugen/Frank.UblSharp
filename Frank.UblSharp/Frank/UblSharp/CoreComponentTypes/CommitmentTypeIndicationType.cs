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
    [XmlTypeAttribute("CommitmentTypeIndicationType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CommitmentTypeIndicationType
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
        [XmlElementAttribute("CommitmentTypeId")]
        public ObjectIdentifierType CommitmentTypeId { get; set; }

        [XmlElementAttribute("ObjectReference")]
        public Collection<string> ObjectReference { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ObjectReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ObjectReferenceSpecified
        {
            get
            {
                return ((this.ObjectReference != null)
                            && (this.ObjectReference.Count != 0));
            }
        }

        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AllSignedDataObjects")]
        public object AllSignedDataObjects { get; set; }

        [XmlArrayAttribute("CommitmentTypeQualifiers")]
        [XmlArrayItemAttribute("CommitmentTypeQualifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public Collection<AnyType> CommitmentTypeQualifiers { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CommitmentTypeQualifiers collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool CommitmentTypeQualifiersSpecified
        {
            get
            {
                return ((this.CommitmentTypeQualifiers != null)
                            && (this.CommitmentTypeQualifiers.Count != 0));
            }
        }
    }
}
