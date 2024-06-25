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
    [XmlTypeAttribute("KeyInfoType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("KeyInfo", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {
        
        [XmlIgnoreAttribute()]
        private List<string> _keyName;
        
        [XmlElementAttribute("KeyName")]
        public List<string> KeyName
        {
            get
            {
                return _keyName;
            }
            set
            {
                _keyName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die KeyName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the KeyName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool KeyNameSpecified
        {
            get
            {
                return ((this.KeyName != null) 
                            && (this.KeyName.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<KeyValueType> _keyValue;
        
        [XmlElementAttribute("KeyValue")]
        public List<KeyValueType> KeyValue
        {
            get
            {
                return _keyValue;
            }
            set
            {
                _keyValue = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die KeyValue-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the KeyValue collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool KeyValueSpecified
        {
            get
            {
                return ((this.KeyValue != null) 
                            && (this.KeyValue.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RetrievalMethodType> _retrievalMethod;
        
        [XmlElementAttribute("RetrievalMethod")]
        public List<RetrievalMethodType> RetrievalMethod
        {
            get
            {
                return _retrievalMethod;
            }
            set
            {
                _retrievalMethod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RetrievalMethod-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RetrievalMethod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RetrievalMethodSpecified
        {
            get
            {
                return ((this.RetrievalMethod != null) 
                            && (this.RetrievalMethod.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<X509DataType> _x509Data;
        
        [XmlElementAttribute("X509Data")]
        public List<X509DataType> X509Data
        {
            get
            {
                return _x509Data;
            }
            set
            {
                _x509Data = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die X509Data-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the X509Data collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool X509DataSpecified
        {
            get
            {
                return ((this.X509Data != null) 
                            && (this.X509Data.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PgpDataType> _pgpData;
        
        [XmlElementAttribute("PGPData")]
        public List<PgpDataType> PgpData
        {
            get
            {
                return _pgpData;
            }
            set
            {
                _pgpData = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PgpData-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PgpData collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PgpDataSpecified
        {
            get
            {
                return ((this.PgpData != null) 
                            && (this.PgpData.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<SpkiDataType> _spkiData;
        
        [XmlElementAttribute("SPKIData")]
        public List<SpkiDataType> SpkiData
        {
            get
            {
                return _spkiData;
            }
            set
            {
                _spkiData = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SpkiData-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SpkiData collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SpkiDataSpecified
        {
            get
            {
                return ((this.SpkiData != null) 
                            && (this.SpkiData.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<string> _mgmtData;
        
        [XmlElementAttribute("MgmtData")]
        public List<string> MgmtData
        {
            get
            {
                return _mgmtData;
            }
            set
            {
                _mgmtData = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MgmtData-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MgmtData collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MgmtDataSpecified
        {
            get
            {
                return ((this.MgmtData != null) 
                            && (this.MgmtData.Count != 0));
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
        public string Id {get;set;}
        
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
}
