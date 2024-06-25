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
    [XmlTypeAttribute("EvaluationCriterionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(EvaluationCriterion))]
    [XmlIncludeAttribute(typeof(FinancialEvaluationCriterion))]
    [XmlIncludeAttribute(typeof(TechnicalEvaluationCriterion))]
    public partial class EvaluationCriterionType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Evaluation Criterion Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code that specifies the criterion; it may be financial, technical or organizational.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTerm>Evaluation Criterion Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EvaluationCriterionTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EvaluationCriterionTypeCodeType EvaluationCriterionTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Description. Text</ccts:DictionaryEntryName><ccts:Definition>A description of the criterion.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Threshold_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>Estimated monetary amount of the threshold for the criterion.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTermQualifier>Threshold</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ThresholdAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ThresholdAmountType ThresholdAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Threshold_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>Estimated quantity of the threshold for the criterion.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTermQualifier>Threshold</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ThresholdQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ThresholdQuantityType ThresholdQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Expression Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code identifying the expression that will be used to evaluate the criterion.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTerm>Expression Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExpressionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpressionCodeType ExpressionCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpressionType> _expression;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Expression. Text</ccts:DictionaryEntryName><ccts:Definition>The expression that will be used to evaluate the criterion.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTerm>Expression</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Expression", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpressionType> Expression
        {
            get
            {
                return _expression;
            }
            set
            {
                _expression = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Expression-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Expression collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ExpressionSpecified
        {
            get
            {
                return ((this.Expression != null) 
                            && (this.Expression.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Duration_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>Describes the period for which the evaluation criterion is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTermQualifier>Duration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DurationPeriod")]
        public PeriodType DurationPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EvidenceType> _suggestedEvidence;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Evaluation Criterion. Suggested_ Evidence. Evidence</ccts:DictionaryEntryName><ccts:Definition>Describes any evidences that should be used to satisfy the criterion. </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Evaluation Criterion</ccts:ObjectClass><ccts:PropertyTermQualifier>Suggested</ccts:PropertyTermQualifier><ccts:PropertyTerm>Evidence</ccts:PropertyTerm><ccts:AssociatedObjectClass>Evidence</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Evidence</ccts:RepresentationTerm></ccts:Component></para>
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
