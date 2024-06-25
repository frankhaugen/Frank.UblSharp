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
    [XmlTypeAttribute("CompleteRevocationRefsType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlIncludeAttribute(typeof(AttributeRevocationRefs))]
    [XmlIncludeAttribute(typeof(CompleteRevocationRefs))]
    public partial class CompleteRevocationRefsType
    {
        
        [XmlIgnoreAttribute()]
        private List<CrlRefType> _crlRefs;
        
        [XmlArrayAttribute("CRLRefs")]
        [XmlArrayItemAttribute("CRLRef", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<CrlRefType> CrlRefs
        {
            get
            {
                return _crlRefs;
            }
            set
            {
                _crlRefs = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CrlRefs-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CrlRefs collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CrlRefsSpecified
        {
            get
            {
                return ((this.CrlRefs != null) 
                            && (this.CrlRefs.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<OcspRefType> _ocspRefs;
        
        [XmlArrayAttribute("OCSPRefs")]
        [XmlArrayItemAttribute("OCSPRef", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<OcspRefType> OcspRefs
        {
            get
            {
                return _ocspRefs;
            }
            set
            {
                _ocspRefs = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OcspRefs-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OcspRefs collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OcspRefsSpecified
        {
            get
            {
                return ((this.OcspRefs != null) 
                            && (this.OcspRefs.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _otherRefs;
        
        [XmlArrayAttribute("OtherRefs")]
        [XmlArrayItemAttribute("OtherRef", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<AnyType> OtherRefs
        {
            get
            {
                return _otherRefs;
            }
            set
            {
                _otherRefs = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OtherRefs-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OtherRefs collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OtherRefsSpecified
        {
            get
            {
                return ((this.OtherRefs != null) 
                            && (this.OtherRefs.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
