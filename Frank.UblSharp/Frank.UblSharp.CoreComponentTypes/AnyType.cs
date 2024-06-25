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
    [XmlTypeAttribute("AnyType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("Any", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class AnyType
    {
        
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
        
        [XmlIgnoreAttribute()]
        private List<XmlAttribute> _anyAttribute;
        
        [XmlAnyAttributeAttribute()]
        public List<XmlAttribute> AnyAttribute
        {
            get
            {
                return _anyAttribute;
            }
            set
            {
                _anyAttribute = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AnyAttribute-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AnyAttribute collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AnyAttributeSpecified
        {
            get
            {
                return ((this.AnyAttribute != null) 
                            && (this.AnyAttribute.Count != 0));
            }
        }
        
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
}