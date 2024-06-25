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
    [XmlTypeAttribute("RevocationValuesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlIncludeAttribute(typeof(AttributeRevocationValues))]
    [XmlIncludeAttribute(typeof(RevocationValues))]
    public partial class RevocationValuesType
    {
        
        [XmlIgnoreAttribute()]
        private List<EncapsulatedPkiDataType> _crlValues;
        
        [XmlArrayAttribute("CRLValues")]
        [XmlArrayItemAttribute("EncapsulatedCRLValue", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<EncapsulatedPkiDataType> CrlValues
        {
            get
            {
                return _crlValues;
            }
            set
            {
                _crlValues = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CrlValues-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CrlValues collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CrlValuesSpecified
        {
            get
            {
                return ((this.CrlValues != null) 
                            && (this.CrlValues.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<EncapsulatedPkiDataType> _ocspValues;
        
        [XmlArrayAttribute("OCSPValues")]
        [XmlArrayItemAttribute("EncapsulatedOCSPValue", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<EncapsulatedPkiDataType> OcspValues
        {
            get
            {
                return _ocspValues;
            }
            set
            {
                _ocspValues = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OcspValues-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OcspValues collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OcspValuesSpecified
        {
            get
            {
                return ((this.OcspValues != null) 
                            && (this.OcspValues.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _otherValues;
        
        [XmlArrayAttribute("OtherValues")]
        [XmlArrayItemAttribute("OtherValue", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<AnyType> OtherValues
        {
            get
            {
                return _otherValues;
            }
            set
            {
                _otherValues = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OtherValues-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OtherValues collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OtherValuesSpecified
        {
            get
            {
                return ((this.OtherValues != null) 
                            && (this.OtherValues.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
