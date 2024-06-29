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
    [XmlTypeAttribute("SignedSignaturePropertiesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("SignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignedSignaturePropertiesType
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [XmlElementAttribute("SigningTime", Order=0, DataType="dateTime")]
        public DateTime SigningTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SigningTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SigningTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<DateTime> SigningTime
        {
            get
            {
                if (this.SigningTimeValueSpecified)
                {
                    return this.SigningTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SigningTimeValue = value.GetValueOrDefault();
                this.SigningTimeValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CertIdType> _signingCertificate;
        
        [XmlArrayAttribute("SigningCertificate", Order=1)]
        [XmlArrayItemAttribute("Cert", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<CertIdType> SigningCertificate
        {
            get
            {
                return _signingCertificate;
            }
            set
            {
                _signingCertificate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the SigningCertificate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SigningCertificateSpecified
        {
            get
            {
                return ((this.SigningCertificate != null) 
                            && (this.SigningCertificate.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SignaturePolicyIdentifier", Order=2)]
        public SignaturePolicyIdentifierType SignaturePolicyIdentifier { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SignatureProductionPlace", Order=3)]
        public SignatureProductionPlaceType SignatureProductionPlace { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SignerRole", Order=4)]
        public SignerRoleType SignerRole { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        [KeyAttribute()]
        public string Id { get; set; }
    }
}
