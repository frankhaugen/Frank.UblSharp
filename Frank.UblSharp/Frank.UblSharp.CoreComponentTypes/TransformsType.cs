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
    [XmlTypeAttribute("TransformsType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Transforms", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformsType
    {
        
        [XmlIgnoreAttribute()]
        private List<TransformType> _transform;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Transform")]
        public List<TransformType> Transform
        {
            get
            {
                return _transform;
            }
            set
            {
                _transform = value;
            }
        }
    }
}
