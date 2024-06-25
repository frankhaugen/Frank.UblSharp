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
    [XmlTypeAttribute("SignatureType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SignedInfo")]
        public SignedInfoType SignedInfo { get; set; }
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SignatureValue")]
        public SignatureValueType SignatureValue { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("KeyInfo")]
        public KeyInfoType KeyInfo { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ObjectType> _object;
        
        [XmlElementAttribute("Object")]
        public List<ObjectType> Object
        {
            get
            {
                return _object;
            }
            set
            {
                _object = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Object-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Object collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ObjectSpecified
        {
            get
            {
                return ((this.Object != null) 
                            && (this.Object.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
