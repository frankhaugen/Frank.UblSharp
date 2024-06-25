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
    
    
    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Details</ccts:DictionaryEntryName><ccts:Definition>The evaluation that the Contracting Authority party requests to fulfill to the tenderers.</ccts:Definition><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TendererQualificationRequestType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TendererQualificationRequest", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TendererQualificationRequestType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Company Legal Form Code. Code</ccts:DictionaryEntryName><ccts:Definition>The legal status requested for potential tenderers, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTerm>Company Legal Form Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompanyLegalFormCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyLegalFormCodeType CompanyLegalFormCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Company Legal Form. Text</ccts:DictionaryEntryName><ccts:Definition>The legal status requested for potential tenderers, expressed as text</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTerm>Company Legal Form</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompanyLegalForm", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyLegalFormType CompanyLegalForm { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PersonalSituationType> _personalSituation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Personal Situation. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the personal situation of the economic operators in this tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTerm>Personal Situation</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PersonalSituation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PersonalSituationType> PersonalSituation
        {
            get
            {
                return _personalSituation;
            }
            set
            {
                _personalSituation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PersonalSituation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PersonalSituation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PersonalSituationSpecified
        {
            get
            {
                return ((this.PersonalSituation != null) 
                            && (this.PersonalSituation.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Operating Years. Quantity</ccts:DictionaryEntryName><ccts:Definition>Textual description of the legal form required for potential tenderers.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTerm>Operating Years</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OperatingYearsQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OperatingYearsQuantityType OperatingYearsQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Employee. Quantity</ccts:DictionaryEntryName><ccts:Definition>Textual description of the legal form required for potential tenderers.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTerm>Employee</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmployeeQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmployeeQuantityType EmployeeQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the evaluation requirements for this tenderer.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        
        [XmlIgnoreAttribute()]
        private List<ClassificationSchemeType> _requiredBusinessClassificationScheme;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Required Business_ Classification Scheme. Classification Scheme</ccts:DictionaryEntryName><ccts:Definition>A classification scheme for the business profile.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Required Business</ccts:PropertyTermQualifier><ccts:PropertyTerm>Classification Scheme</ccts:PropertyTerm><ccts:AssociatedObjectClass>Classification Scheme</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Classification Scheme</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequiredBusinessClassificationScheme")]
        public List<ClassificationSchemeType> RequiredBusinessClassificationScheme
        {
            get
            {
                return _requiredBusinessClassificationScheme;
            }
            set
            {
                _requiredBusinessClassificationScheme = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequiredBusinessClassificationScheme-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequiredBusinessClassificationScheme collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequiredBusinessClassificationSchemeSpecified
        {
            get
            {
                return ((this.RequiredBusinessClassificationScheme != null) 
                            && (this.RequiredBusinessClassificationScheme.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<EvaluationCriterionType> _technicalEvaluationCriterion;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Technical_ Evaluation Criterion. Evaluation Criterion</ccts:DictionaryEntryName><ccts:Definition>A technical evaluation criterion required for an economic operator in a tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Technical</ccts:PropertyTermQualifier><ccts:PropertyTerm>Evaluation Criterion</ccts:PropertyTerm><ccts:AssociatedObjectClass>Evaluation Criterion</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Evaluation Criterion</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TechnicalEvaluationCriterion")]
        public List<EvaluationCriterionType> TechnicalEvaluationCriterion
        {
            get
            {
                return _technicalEvaluationCriterion;
            }
            set
            {
                _technicalEvaluationCriterion = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TechnicalEvaluationCriterion-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TechnicalEvaluationCriterion collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TechnicalEvaluationCriterionSpecified
        {
            get
            {
                return ((this.TechnicalEvaluationCriterion != null) 
                            && (this.TechnicalEvaluationCriterion.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<EvaluationCriterionType> _financialEvaluationCriterion;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Financial_ Evaluation Criterion. Evaluation Criterion</ccts:DictionaryEntryName><ccts:Definition>A financial evaluation criterion required for an economic operator in a tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Financial</ccts:PropertyTermQualifier><ccts:PropertyTerm>Evaluation Criterion</ccts:PropertyTerm><ccts:AssociatedObjectClass>Evaluation Criterion</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Evaluation Criterion</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FinancialEvaluationCriterion")]
        public List<EvaluationCriterionType> FinancialEvaluationCriterion
        {
            get
            {
                return _financialEvaluationCriterion;
            }
            set
            {
                _financialEvaluationCriterion = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FinancialEvaluationCriterion-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FinancialEvaluationCriterion collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FinancialEvaluationCriterionSpecified
        {
            get
            {
                return ((this.FinancialEvaluationCriterion != null) 
                            && (this.FinancialEvaluationCriterion.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TendererRequirementType> _specificTendererRequirement;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Specific_ Tenderer Requirement. Tenderer Requirement</ccts:DictionaryEntryName><ccts:Definition>A requirement to be met by a tenderer.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Specific</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tenderer Requirement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tenderer Requirement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tenderer Requirement</ccts:RepresentationTerm><ccts:Examples>Preregistration in a Business Registry</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SpecificTendererRequirement")]
        public List<TendererRequirementType> SpecificTendererRequirement
        {
            get
            {
                return _specificTendererRequirement;
            }
            set
            {
                _specificTendererRequirement = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SpecificTendererRequirement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SpecificTendererRequirement collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SpecificTendererRequirementSpecified
        {
            get
            {
                return ((this.SpecificTendererRequirement != null) 
                            && (this.SpecificTendererRequirement.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<EconomicOperatorRoleType> _economicOperatorRole;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Qualification Request. Economic Operator Role</ccts:DictionaryEntryName><ccts:Definition>A class to describe the tenderer contracting role.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Qualification Request</ccts:ObjectClass><ccts:PropertyTerm>Economic Operator Role</ccts:PropertyTerm><ccts:AssociatedObjectClass>Economic Operator Role</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Economic Operator Role</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EconomicOperatorRole")]
        public List<EconomicOperatorRoleType> EconomicOperatorRole
        {
            get
            {
                return _economicOperatorRole;
            }
            set
            {
                _economicOperatorRole = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EconomicOperatorRole-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EconomicOperatorRole collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EconomicOperatorRoleSpecified
        {
            get
            {
                return ((this.EconomicOperatorRole != null) 
                            && (this.EconomicOperatorRole.Count != 0));
            }
        }
    }
}
