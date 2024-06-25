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
    [XmlTypeAttribute("X509DataType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("X509Data", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {
        
        [XmlIgnoreAttribute()]
        private List<X509IssuerSerialType> _x509IssuerSerial;
        
        [XmlElementAttribute("X509IssuerSerial")]
        public List<X509IssuerSerialType> X509IssuerSerial
        {
            get
            {
                return _x509IssuerSerial;
            }
            set
            {
                _x509IssuerSerial = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die X509IssuerSerial-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the X509IssuerSerial collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool X509IssuerSerialSpecified
        {
            get
            {
                return ((this.X509IssuerSerial != null) 
                            && (this.X509IssuerSerial.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Byte[]> _x509Ski;
        
        [XmlElementAttribute("X509SKI", DataType="base64Binary")]
        public List<Byte[]> X509Ski
        {
            get
            {
                return _x509Ski;
            }
            set
            {
                _x509Ski = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die X509Ski-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the X509Ski collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool X509SkiSpecified
        {
            get
            {
                return ((this.X509Ski != null) 
                            && (this.X509Ski.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<string> _x509SubjectName;
        
        [XmlElementAttribute("X509SubjectName")]
        public List<string> X509SubjectName
        {
            get
            {
                return _x509SubjectName;
            }
            set
            {
                _x509SubjectName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die X509SubjectName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the X509SubjectName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool X509SubjectNameSpecified
        {
            get
            {
                return ((this.X509SubjectName != null) 
                            && (this.X509SubjectName.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Byte[]> _x509Certificate;
        
        [XmlElementAttribute("X509Certificate", DataType="base64Binary")]
        public List<Byte[]> X509Certificate
        {
            get
            {
                return _x509Certificate;
            }
            set
            {
                _x509Certificate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die X509Certificate-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the X509Certificate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool X509CertificateSpecified
        {
            get
            {
                return ((this.X509Certificate != null) 
                            && (this.X509Certificate.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Byte[]> _x509Crl;
        
        [XmlElementAttribute("X509CRL", DataType="base64Binary")]
        public List<Byte[]> X509Crl
        {
            get
            {
                return _x509Crl;
            }
            set
            {
                _x509Crl = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die X509Crl-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the X509Crl collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool X509CrlSpecified
        {
            get
            {
                return ((this.X509Crl != null) 
                            && (this.X509Crl.Count != 0));
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
    }
}
