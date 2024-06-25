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
    [XmlTypeAttribute("CertificateValuesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlIncludeAttribute(typeof(AttrAuthoritiesCertValues))]
    [XmlIncludeAttribute(typeof(CertificateValues))]
    public partial class CertificateValuesType
    {
        
        [XmlIgnoreAttribute()]
        private List<EncapsulatedPkiDataType> _encapsulatedX509Certificate;
        
        [XmlElementAttribute("EncapsulatedX509Certificate")]
        public List<EncapsulatedPkiDataType> EncapsulatedX509Certificate
        {
            get
            {
                return _encapsulatedX509Certificate;
            }
            set
            {
                _encapsulatedX509Certificate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EncapsulatedX509Certificate-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EncapsulatedX509Certificate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EncapsulatedX509CertificateSpecified
        {
            get
            {
                return ((this.EncapsulatedX509Certificate != null) 
                            && (this.EncapsulatedX509Certificate.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _otherCertificate;
        
        [XmlElementAttribute("OtherCertificate")]
        public List<AnyType> OtherCertificate
        {
            get
            {
                return _otherCertificate;
            }
            set
            {
                _otherCertificate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OtherCertificate-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OtherCertificate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OtherCertificateSpecified
        {
            get
            {
                return ((this.OtherCertificate != null) 
                            && (this.OtherCertificate.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
