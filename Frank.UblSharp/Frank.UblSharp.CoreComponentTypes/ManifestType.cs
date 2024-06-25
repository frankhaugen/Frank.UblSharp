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
    [XmlTypeAttribute("ManifestType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Manifest", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ManifestType
    {
        
        [XmlIgnoreAttribute()]
        private List<ReferenceType> _reference;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Reference")]
        public List<ReferenceType> Reference
        {
            get
            {
                return _reference;
            }
            set
            {
                _reference = value;
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}