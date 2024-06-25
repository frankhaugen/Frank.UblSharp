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
    [XmlTypeAttribute("ReferenceType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Reference", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {
        
        [XmlIgnoreAttribute()]
        private List<TransformType> _transforms;
        
        [XmlArrayAttribute("Transforms")]
        [XmlArrayItemAttribute("Transform", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public List<TransformType> Transforms
        {
            get
            {
                return _transforms;
            }
            set
            {
                _transforms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Transforms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Transforms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransformsSpecified
        {
            get
            {
                return ((this.Transforms != null) 
                            && (this.Transforms.Count != 0));
            }
        }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("DigestMethod")]
        public DigestMethodType DigestMethod { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("DigestValue", DataType="base64Binary")]
        public Byte[] DigestValue { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("URI")]
        public string Uri { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Type")]
        public string Type { get; set; }
    }
}
