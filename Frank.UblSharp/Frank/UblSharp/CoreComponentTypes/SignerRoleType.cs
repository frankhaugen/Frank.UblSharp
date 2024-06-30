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
    [XmlTypeAttribute("SignerRoleType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignerRoleType
    {

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }

        [XmlArrayAttribute("ClaimedRoles")]
        [XmlArrayItemAttribute("ClaimedRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public Collection<AnyType> ClaimedRoles { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ClaimedRoles collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ClaimedRolesSpecified
        {
            get
            {
                return ((this.ClaimedRoles != null)
                            && (this.ClaimedRoles.Count != 0));
            }
        }

        [XmlArrayAttribute("CertifiedRoles")]
        [XmlArrayItemAttribute("CertifiedRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public Collection<EncapsulatedPkiDataType> CertifiedRoles { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CertifiedRoles collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool CertifiedRolesSpecified
        {
            get
            {
                return ((this.CertifiedRoles != null)
                            && (this.CertifiedRoles.Count != 0));
            }
        }
    }
}
