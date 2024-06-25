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
    [XmlTypeAttribute("CommitmentTypeIndicationType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("CommitmentTypeIndication", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CommitmentTypeIndicationType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("CommitmentTypeId")]
        public ObjectIdentifierType CommitmentTypeId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<string> _objectReference;
        
        [XmlElementAttribute("ObjectReference")]
        public List<string> ObjectReference
        {
            get
            {
                return _objectReference;
            }
            set
            {
                _objectReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ObjectReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ObjectReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ObjectReferenceSpecified
        {
            get
            {
                return ((this.ObjectReference != null) 
                            && (this.ObjectReference.Count != 0));
            }
        }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AllSignedDataObjects")]
        public object AllSignedDataObjects { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _commitmentTypeQualifiers;
        
        [XmlArrayAttribute("CommitmentTypeQualifiers")]
        [XmlArrayItemAttribute("CommitmentTypeQualifier", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<AnyType> CommitmentTypeQualifiers
        {
            get
            {
                return _commitmentTypeQualifiers;
            }
            set
            {
                _commitmentTypeQualifiers = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CommitmentTypeQualifiers-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CommitmentTypeQualifiers collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CommitmentTypeQualifiersSpecified
        {
            get
            {
                return ((this.CommitmentTypeQualifiers != null) 
                            && (this.CommitmentTypeQualifiers.Count != 0));
            }
        }
    }
}
