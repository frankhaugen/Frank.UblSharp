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
    [XmlTypeAttribute("GenericTimeStampType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlIncludeAttribute(typeof(AllDataObjectsTimeStamp))]
    [XmlIncludeAttribute(typeof(ArchiveTimeStamp))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CoreComponentTypes.ArchiveTimeStampV2))]
    [XmlIncludeAttribute(typeof(IndividualDataObjectsTimeStamp))]
    [XmlIncludeAttribute(typeof(OtherTimeStampType))]
    [XmlIncludeAttribute(typeof(RefsOnlyTimeStamp))]
    [XmlIncludeAttribute(typeof(SigAndRefsTimeStamp))]
    [XmlIncludeAttribute(typeof(SignatureTimeStamp))]
    [XmlIncludeAttribute(typeof(XAdEsTimeStamp))]
    [XmlIncludeAttribute(typeof(XAdEsTimeStampType))]
    public abstract partial class GenericTimeStampType
    {
        
        [XmlIgnoreAttribute()]
        private List<IncludeType> _include;
        
        [XmlElementAttribute("Include")]
        public List<IncludeType> Include
        {
            get
            {
                return _include;
            }
            set
            {
                _include = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Include-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Include collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IncludeSpecified
        {
            get
            {
                return ((this.Include != null) 
                            && (this.Include.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ReferenceInfoType> _referenceInfo;
        
        [XmlElementAttribute("ReferenceInfo")]
        public List<ReferenceInfoType> ReferenceInfo
        {
            get
            {
                return _referenceInfo;
            }
            set
            {
                _referenceInfo = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReferenceInfo-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReferenceInfo collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReferenceInfoSpecified
        {
            get
            {
                return ((this.ReferenceInfo != null) 
                            && (this.ReferenceInfo.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CanonicalizationMethod", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public Frank.UblSharp.CoreComponentTypes.CanonicalizationMethodType CanonicalizationMethod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EncapsulatedPkiDataType> _encapsulatedTimeStamp;
        
        [XmlElementAttribute("EncapsulatedTimeStamp")]
        public List<EncapsulatedPkiDataType> EncapsulatedTimeStamp
        {
            get
            {
                return _encapsulatedTimeStamp;
            }
            set
            {
                _encapsulatedTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EncapsulatedTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EncapsulatedTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EncapsulatedTimeStampSpecified
        {
            get
            {
                return ((this.EncapsulatedTimeStamp != null) 
                            && (this.EncapsulatedTimeStamp.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _xmlTimeStamp;
        
        [XmlElementAttribute("XMLTimeStamp")]
        public List<AnyType> XmlTimeStamp
        {
            get
            {
                return _xmlTimeStamp;
            }
            set
            {
                _xmlTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die XmlTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the XmlTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool XmlTimeStampSpecified
        {
            get
            {
                return ((this.XmlTimeStamp != null) 
                            && (this.XmlTimeStamp.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
