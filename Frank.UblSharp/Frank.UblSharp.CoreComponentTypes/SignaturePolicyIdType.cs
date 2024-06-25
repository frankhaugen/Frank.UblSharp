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
    [XmlTypeAttribute("SignaturePolicyIdType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignaturePolicyIdType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SigPolicyId")]
        public ObjectIdentifierType SigPolicyId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CoreComponentTypes.TransformType> _transforms;
        
        [XmlArrayAttribute("Transforms", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        [XmlArrayItemAttribute("Transform", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public List<Frank.UblSharp.CoreComponentTypes.TransformType> Transforms
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
        [XmlElementAttribute("SigPolicyHash")]
        public DigestAlgAndValueType SigPolicyHash { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _sigPolicyQualifiers;
        
        [XmlArrayAttribute("SigPolicyQualifiers")]
        [XmlArrayItemAttribute("SigPolicyQualifier", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<AnyType> SigPolicyQualifiers
        {
            get
            {
                return _sigPolicyQualifiers;
            }
            set
            {
                _sigPolicyQualifiers = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SigPolicyQualifiers-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SigPolicyQualifiers collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SigPolicyQualifiersSpecified
        {
            get
            {
                return ((this.SigPolicyQualifiers != null) 
                            && (this.SigPolicyQualifiers.Count != 0));
            }
        }
    }
}
