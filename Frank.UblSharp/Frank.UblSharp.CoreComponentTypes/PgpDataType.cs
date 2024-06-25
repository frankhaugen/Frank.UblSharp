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
    [XmlTypeAttribute("PGPDataType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("PGPData", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class PgpDataType
    {
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PGPKeyID", DataType="base64Binary")]
        public Byte[] PgpKeyId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Byte[]> _pgpKeyPacket;
        
        [XmlElementAttribute("PGPKeyPacket", DataType="base64Binary")]
        public List<Byte[]> PgpKeyPacket
        {
            get
            {
                return _pgpKeyPacket;
            }
            set
            {
                _pgpKeyPacket = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PgpKeyPacket-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PgpKeyPacket collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PgpKeyPacketSpecified
        {
            get
            {
                return ((this.PgpKeyPacket != null) 
                            && (this.PgpKeyPacket.Count != 0));
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
