namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
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
    [XmlTypeAttribute("TendererRequirementType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(SpecificTendererRequirement))]
    [XmlIncludeAttribute(typeof(TendererRequirement))]
    public partial class TendererRequirementType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType> _name;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Requirement. Name</ccts:DictionaryEntryName><ccts:Definition>A name of this tenderer requirement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Requirement</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType> Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Name-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Name collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NameSpecified
        {
            get
            {
                return ((this.Name != null) 
                            && (this.Name.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Requirement. Tenderer Requirement_ Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying this requirement.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tenderer Requirement</ccts:ObjectClass><ccts:PropertyTermQualifier>Tenderer Requirement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TendererRequirementTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TendererRequirementTypeCodeType TendererRequirementTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Requirement. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this requirement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Requirement</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Description-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Requirement. Legal Reference. Text</ccts:DictionaryEntryName><ccts:Definition>The legal reference of the exclusion criterion.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tenderer Requirement</ccts:ObjectClass><ccts:PropertyTerm>Legal Reference</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Art. 45 2 b</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LegalReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LegalReferenceType LegalReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EvidenceType> _suggestedEvidence;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Requirement. Suggested_ Evidence. Evidence</ccts:DictionaryEntryName><ccts:Definition>An item of evidence that should be submitted to satisfy this requirement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Requirement</ccts:ObjectClass><ccts:PropertyTermQualifier>Suggested</ccts:PropertyTermQualifier><ccts:PropertyTerm>Evidence</ccts:PropertyTerm><ccts:AssociatedObjectClass>Evidence</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Evidence</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SuggestedEvidence")]
        public List<EvidenceType> SuggestedEvidence
        {
            get
            {
                return _suggestedEvidence;
            }
            set
            {
                _suggestedEvidence = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SuggestedEvidence-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SuggestedEvidence collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SuggestedEvidenceSpecified
        {
            get
            {
                return ((this.SuggestedEvidence != null) 
                            && (this.SuggestedEvidence.Count != 0));
            }
        }
    }
}