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
    [XmlTypeAttribute("TransformType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Transform", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
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
        private List<string> _xPath;
        
        [XmlElementAttribute("XPath")]
        public List<string> XPath
        {
            get
            {
                return _xPath;
            }
            set
            {
                _xPath = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die XPath-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the XPath collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool XPathSpecified
        {
            get
            {
                return ((this.XPath != null) 
                            && (this.XPath.Count != 0));
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlAttributeAttribute("Algorithm")]
        public string Algorithm { get; set; }
        
        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
}
