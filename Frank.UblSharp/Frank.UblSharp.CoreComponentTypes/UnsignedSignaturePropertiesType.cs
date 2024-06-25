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
    [XmlTypeAttribute("UnsignedSignaturePropertiesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("UnsignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class UnsignedSignaturePropertiesType
    {
        
        [XmlIgnoreAttribute()]
        private List<CounterSignatureType> _counterSignature;
        
        [XmlElementAttribute("CounterSignature")]
        public List<CounterSignatureType> CounterSignature
        {
            get
            {
                return _counterSignature;
            }
            set
            {
                _counterSignature = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CounterSignature-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CounterSignature collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CounterSignatureSpecified
        {
            get
            {
                return ((this.CounterSignature != null) 
                            && (this.CounterSignature.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XAdEsTimeStampType> _signatureTimeStamp;
        
        [XmlElementAttribute("SignatureTimeStamp")]
        public List<XAdEsTimeStampType> SignatureTimeStamp
        {
            get
            {
                return _signatureTimeStamp;
            }
            set
            {
                _signatureTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SignatureTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SignatureTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SignatureTimeStampSpecified
        {
            get
            {
                return ((this.SignatureTimeStamp != null) 
                            && (this.SignatureTimeStamp.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CompleteCertificateRefsType> _completeCertificateRefs;
        
        [XmlElementAttribute("CompleteCertificateRefs")]
        public List<CompleteCertificateRefsType> CompleteCertificateRefs
        {
            get
            {
                return _completeCertificateRefs;
            }
            set
            {
                _completeCertificateRefs = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CompleteCertificateRefs-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CompleteCertificateRefs collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CompleteCertificateRefsSpecified
        {
            get
            {
                return ((this.CompleteCertificateRefs != null) 
                            && (this.CompleteCertificateRefs.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CompleteRevocationRefsType> _completeRevocationRefs;
        
        [XmlElementAttribute("CompleteRevocationRefs")]
        public List<CompleteRevocationRefsType> CompleteRevocationRefs
        {
            get
            {
                return _completeRevocationRefs;
            }
            set
            {
                _completeRevocationRefs = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CompleteRevocationRefs-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CompleteRevocationRefs collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CompleteRevocationRefsSpecified
        {
            get
            {
                return ((this.CompleteRevocationRefs != null) 
                            && (this.CompleteRevocationRefs.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CompleteCertificateRefsType> _attributeCertificateRefs;
        
        [XmlElementAttribute("AttributeCertificateRefs")]
        public List<CompleteCertificateRefsType> AttributeCertificateRefs
        {
            get
            {
                return _attributeCertificateRefs;
            }
            set
            {
                _attributeCertificateRefs = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AttributeCertificateRefs-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AttributeCertificateRefs collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AttributeCertificateRefsSpecified
        {
            get
            {
                return ((this.AttributeCertificateRefs != null) 
                            && (this.AttributeCertificateRefs.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CompleteRevocationRefsType> _attributeRevocationRefs;
        
        [XmlElementAttribute("AttributeRevocationRefs")]
        public List<CompleteRevocationRefsType> AttributeRevocationRefs
        {
            get
            {
                return _attributeRevocationRefs;
            }
            set
            {
                _attributeRevocationRefs = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AttributeRevocationRefs-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AttributeRevocationRefs collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AttributeRevocationRefsSpecified
        {
            get
            {
                return ((this.AttributeRevocationRefs != null) 
                            && (this.AttributeRevocationRefs.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XAdEsTimeStampType> _sigAndRefsTimeStamp;
        
        [XmlElementAttribute("SigAndRefsTimeStamp")]
        public List<XAdEsTimeStampType> SigAndRefsTimeStamp
        {
            get
            {
                return _sigAndRefsTimeStamp;
            }
            set
            {
                _sigAndRefsTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SigAndRefsTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SigAndRefsTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SigAndRefsTimeStampSpecified
        {
            get
            {
                return ((this.SigAndRefsTimeStamp != null) 
                            && (this.SigAndRefsTimeStamp.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XAdEsTimeStampType> _refsOnlyTimeStamp;
        
        [XmlElementAttribute("RefsOnlyTimeStamp")]
        public List<XAdEsTimeStampType> RefsOnlyTimeStamp
        {
            get
            {
                return _refsOnlyTimeStamp;
            }
            set
            {
                _refsOnlyTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RefsOnlyTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RefsOnlyTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RefsOnlyTimeStampSpecified
        {
            get
            {
                return ((this.RefsOnlyTimeStamp != null) 
                            && (this.RefsOnlyTimeStamp.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CertificateValuesType> _certificateValues;
        
        [XmlElementAttribute("CertificateValues")]
        public List<CertificateValuesType> CertificateValues
        {
            get
            {
                return _certificateValues;
            }
            set
            {
                _certificateValues = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CertificateValues-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CertificateValues collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CertificateValuesSpecified
        {
            get
            {
                return ((this.CertificateValues != null) 
                            && (this.CertificateValues.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RevocationValuesType> _revocationValues;
        
        [XmlElementAttribute("RevocationValues")]
        public List<RevocationValuesType> RevocationValues
        {
            get
            {
                return _revocationValues;
            }
            set
            {
                _revocationValues = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RevocationValues-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RevocationValues collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RevocationValuesSpecified
        {
            get
            {
                return ((this.RevocationValues != null) 
                            && (this.RevocationValues.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CertificateValuesType> _attrAuthoritiesCertValues;
        
        [XmlElementAttribute("AttrAuthoritiesCertValues")]
        public List<CertificateValuesType> AttrAuthoritiesCertValues
        {
            get
            {
                return _attrAuthoritiesCertValues;
            }
            set
            {
                _attrAuthoritiesCertValues = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AttrAuthoritiesCertValues-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AttrAuthoritiesCertValues collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AttrAuthoritiesCertValuesSpecified
        {
            get
            {
                return ((this.AttrAuthoritiesCertValues != null) 
                            && (this.AttrAuthoritiesCertValues.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RevocationValuesType> _attributeRevocationValues;
        
        [XmlElementAttribute("AttributeRevocationValues")]
        public List<RevocationValuesType> AttributeRevocationValues
        {
            get
            {
                return _attributeRevocationValues;
            }
            set
            {
                _attributeRevocationValues = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AttributeRevocationValues-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AttributeRevocationValues collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AttributeRevocationValuesSpecified
        {
            get
            {
                return ((this.AttributeRevocationValues != null) 
                            && (this.AttributeRevocationValues.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XAdEsTimeStampType> _archiveTimeStamp;
        
        [XmlElementAttribute("ArchiveTimeStamp")]
        public List<XAdEsTimeStampType> ArchiveTimeStamp
        {
            get
            {
                return _archiveTimeStamp;
            }
            set
            {
                _archiveTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ArchiveTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ArchiveTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ArchiveTimeStampSpecified
        {
            get
            {
                return ((this.ArchiveTimeStamp != null) 
                            && (this.ArchiveTimeStamp.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XmlElement> _any;
        
        [XmlAnyElementAttribute()]
        public List<XmlElement> Any
        {
            get
            {
                return _any;
            }
            set
            {
                _any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Any-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get
            {
                return ((this.Any != null) 
                            && (this.Any.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
