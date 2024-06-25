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
    [XmlTypeAttribute("CommitmentTypeQualifiersListType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CommitmentTypeQualifiersListType
    {
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _commitmentTypeQualifier;
        
        [XmlElementAttribute("CommitmentTypeQualifier")]
        public List<AnyType> CommitmentTypeQualifier
        {
            get
            {
                return _commitmentTypeQualifier;
            }
            set
            {
                _commitmentTypeQualifier = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CommitmentTypeQualifier-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CommitmentTypeQualifier collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CommitmentTypeQualifierSpecified
        {
            get
            {
                return ((this.CommitmentTypeQualifier != null) 
                            && (this.CommitmentTypeQualifier.Count != 0));
            }
        }
    }
}
