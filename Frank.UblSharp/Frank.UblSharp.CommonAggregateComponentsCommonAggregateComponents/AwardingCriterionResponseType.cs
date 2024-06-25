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
    [XmlTypeAttribute("AwardingCriterionResponseType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AwardingCriterionResponse))]
    [XmlIncludeAttribute(typeof(SubordinateAwardingCriterionResponse))]
    public partial class AwardingCriterionResponseType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Criterion Response. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identification of this awarding criterion response.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Criterion Response</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Criterion Response. Awarding Criterion Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifer of the awarding criterion being referred to.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Criterion Response</ccts:ObjectClass><ccts:PropertyTerm>Awarding Criterion Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AwardingCriterionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardingCriterionIdType AwardingCriterionId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardingCriterionDescriptionType> _awardingCriterionDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Criterion Response. Awarding Criterion_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Describes the awarding criterion.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Criterion Response</ccts:ObjectClass><ccts:PropertyTermQualifier>Awarding Criterion</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AwardingCriterionDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardingCriterionDescriptionType> AwardingCriterionDescription
        {
            get
            {
                return _awardingCriterionDescription;
            }
            set
            {
                _awardingCriterionDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AwardingCriterionDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AwardingCriterionDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AwardingCriterionDescriptionSpecified
        {
            get
            {
                return ((this.AwardingCriterionDescription != null) 
                            && (this.AwardingCriterionDescription.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Criterion Response. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Describes the awarding criterion response.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Criterion Response</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Criterion Response. Quantity</ccts:DictionaryEntryName><ccts:Definition>Specifies the quantity tendered for this awarding criterion.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Criterion Response</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Criterion Response. Amount</ccts:DictionaryEntryName><ccts:Definition>Specifies the monetary amount tendered for this awarding criterion.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Criterion Response</ccts:ObjectClass><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Amount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AmountType Amount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AwardingCriterionResponseType> _subordinateAwardingCriterionResponse;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Criterion Response. Subordinate_ Awarding Criterion Response. Awarding Criterion Response</ccts:DictionaryEntryName><ccts:Definition>Defines responses to any subsidiary awarding criterion.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Criterion Response</ccts:ObjectClass><ccts:PropertyTermQualifier>Subordinate</ccts:PropertyTermQualifier><ccts:PropertyTerm>Awarding Criterion Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Awarding Criterion Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Awarding Criterion Response</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SubordinateAwardingCriterionResponse")]
        public List<AwardingCriterionResponseType> SubordinateAwardingCriterionResponse
        {
            get
            {
                return _subordinateAwardingCriterionResponse;
            }
            set
            {
                _subordinateAwardingCriterionResponse = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SubordinateAwardingCriterionResponse-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SubordinateAwardingCriterionResponse collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubordinateAwardingCriterionResponseSpecified
        {
            get
            {
                return ((this.SubordinateAwardingCriterionResponse != null) 
                            && (this.SubordinateAwardingCriterionResponse.Count != 0));
            }
        }
    }
}
