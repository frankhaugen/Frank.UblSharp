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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe tendering terms for a tendering process.</ccts:Definition><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TenderingTermsType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TenderingTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderingTermsType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Awarding Method Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the awarding method in a tendering process (e.g., a method favoring the tender with the lowest price or the tender that is most economically advantageous).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Awarding Method Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Price, Multiple criteria</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AwardingMethodTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardingMethodTypeCodeType AwardingMethodTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Price Evaluation Code. Code</ccts:DictionaryEntryName><ccts:Definition>Textual description of the legal form required for potential tenderers.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Price Evaluation Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Unit prices, global price</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PriceEvaluationCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceEvaluationCodeType PriceEvaluationCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Maximum Variant_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>Maximum number of variants the tenderer is allowed to present for this tendering project.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum Variant</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumVariantQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumVariantQuantityType MaximumVariantQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Variant_ Constraint. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that variants are allowed and unconstrained in number (true) or not allowed (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Variant</ccts:PropertyTermQualifier><ccts:PropertyTerm>Constraint</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("VariantConstraintIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.VariantConstraintIndicatorType VariantConstraintIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AcceptedVariantsDescriptionType> _acceptedVariantsDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Accepted Variants_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text specifying the things for which variants are accepted.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Accepted Variants</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AcceptedVariantsDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AcceptedVariantsDescriptionType> AcceptedVariantsDescription
        {
            get
            {
                return _acceptedVariantsDescription;
            }
            set
            {
                _acceptedVariantsDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AcceptedVariantsDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AcceptedVariantsDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AcceptedVariantsDescriptionSpecified
        {
            get
            {
                return ((this.AcceptedVariantsDescription != null) 
                            && (this.AcceptedVariantsDescription.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceRevisionFormulaDescriptionType> _priceRevisionFormulaDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Price Revision_ Formula Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the formula for price revision.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Price Revision</ccts:PropertyTermQualifier><ccts:PropertyTerm>Formula Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PriceRevisionFormulaDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceRevisionFormulaDescriptionType> PriceRevisionFormulaDescription
        {
            get
            {
                return _priceRevisionFormulaDescription;
            }
            set
            {
                _priceRevisionFormulaDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PriceRevisionFormulaDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PriceRevisionFormulaDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PriceRevisionFormulaDescriptionSpecified
        {
            get
            {
                return ((this.PriceRevisionFormulaDescription != null) 
                            && (this.PriceRevisionFormulaDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Funding_ Program Code. Code</ccts:DictionaryEntryName><ccts:Definition>The program that funds the tendering process (e.g., "National", "European"), expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Funding</ccts:PropertyTermQualifier><ccts:PropertyTerm>Program Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FundingProgramCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FundingProgramCodeType FundingProgramCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FundingProgramType> _fundingProgram;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Funding_ Program. Text</ccts:DictionaryEntryName><ccts:Definition>The program that funds the tendering process (e.g., EU 6th Framework Program) expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Funding</ccts:PropertyTermQualifier><ccts:PropertyTerm>Program</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FundingProgram", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FundingProgramType> FundingProgram
        {
            get
            {
                return _fundingProgram;
            }
            set
            {
                _fundingProgram = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FundingProgram-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FundingProgram collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FundingProgramSpecified
        {
            get
            {
                return ((this.FundingProgram != null) 
                            && (this.FundingProgram.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Maximum_ Advertisement. Amount</ccts:DictionaryEntryName><ccts:Definition>The maximum advertised monetary value of the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Advertisement</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumAdvertisementAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumAdvertisementAmountType MaximumAdvertisementAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Note-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Note collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoteSpecified
        {
            get
            {
                return ((this.Note != null) 
                            && (this.Note.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Payment Frequency Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the frequency of payment in the contract associated with the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Frequency Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentFrequencyCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentFrequencyCodeType PaymentFrequencyCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Economic Operator Registry_ URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) of an electronic registry of economic operators.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Economic Operator Registry</ccts:PropertyTermQualifier><ccts:PropertyTerm>URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Web site</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EconomicOperatorRegistryURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EconomicOperatorRegistryUriType EconomicOperatorRegistryUri { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Required Curricula. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that tenderers are required to provide a curriculum vitae for each participant in the project (true) or are not so required (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Required Curricula</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequiredCurriculaIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RequiredCurriculaIndicatorType RequiredCurriculaIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Other_ Conditions. Indicator</ccts:DictionaryEntryName><ccts:Definition>Indicates whether other conditions exist (true) or not (false). If the indicator is true, the description may be provided.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Other</ccts:PropertyTermQualifier><ccts:PropertyTerm>Conditions</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OtherConditionsIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OtherConditionsIndicatorType OtherConditionsIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalConditionsType> _additionalConditions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Additional_ Conditions. Text</ccts:DictionaryEntryName><ccts:Definition>Other existing conditions.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Conditions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalConditions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalConditionsType> AdditionalConditions
        {
            get
            {
                return _additionalConditions;
            }
            set
            {
                _additionalConditions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalConditions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalConditions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalConditionsSpecified
        {
            get
            {
                return ((this.AdditionalConditions != null) 
                            && (this.AdditionalConditions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Latest_ Security Clearance Date. Date</ccts:DictionaryEntryName><ccts:Definition>The end date until which the candidates can obtain the necessary level of security clearance.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest</ccts:PropertyTermQualifier><ccts:PropertyTerm>Security Clearance Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatestSecurityClearanceDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestSecurityClearanceDateType LatestSecurityClearanceDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Documentation Fee Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount to be paid to obtain the contract documents and additional documentation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Documentation Fee Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DocumentationFeeAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentationFeeAmountType DocumentationFeeAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ClauseType> _penaltyClause;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Penalty_ Clause. Clause</ccts:DictionaryEntryName><ccts:Definition>The penalty clauses</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Penalty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Clause</ccts:PropertyTerm><ccts:AssociatedObjectClass>Clause</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Clause</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PenaltyClause")]
        public List<ClauseType> PenaltyClause
        {
            get
            {
                return _penaltyClause;
            }
            set
            {
                _penaltyClause = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PenaltyClause-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PenaltyClause collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PenaltyClauseSpecified
        {
            get
            {
                return ((this.PenaltyClause != null) 
                            && (this.PenaltyClause.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<FinancialGuaranteeType> _requiredFinancialGuarantee;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Required_ Financial Guarantee. Financial Guarantee</ccts:DictionaryEntryName><ccts:Definition>A financial guarantee of a tenderer or bid submitter's actual entry into a contract in the event that it is the successful bidder.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Financial Guarantee</ccts:PropertyTerm><ccts:AssociatedObjectClass>Financial Guarantee</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Financial Guarantee</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequiredFinancialGuarantee")]
        public List<FinancialGuaranteeType> RequiredFinancialGuarantee
        {
            get
            {
                return _requiredFinancialGuarantee;
            }
            set
            {
                _requiredFinancialGuarantee = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequiredFinancialGuarantee-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequiredFinancialGuarantee collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequiredFinancialGuaranteeSpecified
        {
            get
            {
                return ((this.RequiredFinancialGuarantee != null) 
                            && (this.RequiredFinancialGuarantee.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Procurement Legislation_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document providing references to procurement legislation applicable to the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Procurement Legislation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProcurementLegislationDocumentReference")]
        public DocumentReferenceType ProcurementLegislationDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Fiscal Legislation_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document providing references to fiscal legislation applicable to the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Fiscal Legislation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FiscalLegislationDocumentReference")]
        public DocumentReferenceType FiscalLegislationDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Environmental Legislation_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document providing references to environmental legislation applicable to the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Environmental Legislation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EnvironmentalLegislationDocumentReference")]
        public DocumentReferenceType EnvironmentalLegislationDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Employment Legislation_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document providing references to employment legislation applicable to the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Employment Legislation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmploymentLegislationDocumentReference")]
        public DocumentReferenceType EmploymentLegislationDocumentReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _contractualDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Contractual_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document that will become part of the awarded contract.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Contractual</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContractualDocumentReference")]
        public List<DocumentReferenceType> ContractualDocumentReference
        {
            get
            {
                return _contractualDocumentReference;
            }
            set
            {
                _contractualDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContractualDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContractualDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContractualDocumentReferenceSpecified
        {
            get
            {
                return ((this.ContractualDocumentReference != null) 
                            && (this.ContractualDocumentReference.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Call For Tenders_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to the Call for Tender associated with these tendering terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Call For Tenders</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CallForTendersDocumentReference")]
        public DocumentReferenceType CallForTendersDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Warranty Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which a warranty for work, service, or goods associated with these tendering terms is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarrantyValidityPeriod")]
        public PeriodType WarrantyValidityPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PaymentTermsType> _paymentTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>A specification of payment terms associated with the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PaymentTerms")]
        public List<PaymentTermsType> PaymentTerms
        {
            get
            {
                return _paymentTerms;
            }
            set
            {
                _paymentTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PaymentTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentTermsSpecified
        {
            get
            {
                return ((this.PaymentTerms != null) 
                            && (this.PaymentTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TendererQualificationRequestType> _tendererQualificationRequest;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Tenderer Qualification Request</ccts:DictionaryEntryName><ccts:Definition>Required set of qualifications for a tenderer in this tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Tenderer Qualification Request</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tenderer Qualification Request</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tenderer Qualification Request</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TendererQualificationRequest")]
        public List<TendererQualificationRequestType> TendererQualificationRequest
        {
            get
            {
                return _tendererQualificationRequest;
            }
            set
            {
                _tendererQualificationRequest = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TendererQualificationRequest-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TendererQualificationRequest collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TendererQualificationRequestSpecified
        {
            get
            {
                return ((this.TendererQualificationRequest != null) 
                            && (this.TendererQualificationRequest.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<SubcontractTermsType> _allowedSubcontractTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Allowed_ Subcontract Terms. Subcontract Terms</ccts:DictionaryEntryName><ccts:Definition>Subcontract terms for the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Allowed</ccts:PropertyTermQualifier><ccts:PropertyTerm>Subcontract Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Subcontract Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Subcontract Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AllowedSubcontractTerms")]
        public List<SubcontractTermsType> AllowedSubcontractTerms
        {
            get
            {
                return _allowedSubcontractTerms;
            }
            set
            {
                _allowedSubcontractTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AllowedSubcontractTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AllowedSubcontractTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AllowedSubcontractTermsSpecified
        {
            get
            {
                return ((this.AllowedSubcontractTerms != null) 
                            && (this.AllowedSubcontractTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TenderPreparationType> _tenderPreparation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Tender Preparation</ccts:DictionaryEntryName><ccts:Definition>Directions for preparing a tender for the+D2057 tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Tender Preparation</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tender Preparation</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tender Preparation</ccts:RepresentationTerm><ccts:Examples>Curricula required, Experience required, ....</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TenderPreparation")]
        public List<TenderPreparationType> TenderPreparation
        {
            get
            {
                return _tenderPreparation;
            }
            set
            {
                _tenderPreparation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TenderPreparation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TenderPreparation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TenderPreparationSpecified
        {
            get
            {
                return ((this.TenderPreparation != null) 
                            && (this.TenderPreparation.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ContractExecutionRequirementType> _contractExecutionRequirement;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Contract Execution Requirement</ccts:DictionaryEntryName><ccts:Definition>A requirement relating to execution of the contract that will be awarded as a result of the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Contract Execution Requirement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contract Execution Requirement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contract Execution Requirement</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContractExecutionRequirement")]
        public List<ContractExecutionRequirementType> ContractExecutionRequirement
        {
            get
            {
                return _contractExecutionRequirement;
            }
            set
            {
                _contractExecutionRequirement = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContractExecutionRequirement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContractExecutionRequirement collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContractExecutionRequirementSpecified
        {
            get
            {
                return ((this.ContractExecutionRequirement != null) 
                            && (this.ContractExecutionRequirement.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Awarding Terms</ccts:DictionaryEntryName><ccts:Definition>The terms in the tendering process for awarding the contract for a project.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Awarding Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Awarding Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Awarding Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AwardingTerms")]
        public AwardingTermsType AwardingTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Additional Information_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A party that has additional information about the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional Information</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AdditionalInformationParty")]
        public PartyType AdditionalInformationParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Document Provider_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that has the contract documents for the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Document Provider</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DocumentProviderParty")]
        public PartyType DocumentProviderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Tender Recipient_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party to which tenders should be presented.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Tender Recipient</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TenderRecipientParty")]
        public PartyType TenderRecipientParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Contract Responsible_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party responsible for the execution of the contract.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Contract Responsible</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractResponsibleParty")]
        public PartyType ContractResponsibleParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PartyType> _tenderEvaluationParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Tender Evaluation_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A party in the contracting authority responsible for evaluating tenders received.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Tender Evaluation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TenderEvaluationParty")]
        public List<PartyType> TenderEvaluationParty
        {
            get
            {
                return _tenderEvaluationParty;
            }
            set
            {
                _tenderEvaluationParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TenderEvaluationParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TenderEvaluationParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TenderEvaluationPartySpecified
        {
            get
            {
                return ((this.TenderEvaluationParty != null) 
                            && (this.TenderEvaluationParty.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Tender Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which tenders submitted for this tendering process must remain valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Tender Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TenderValidityPeriod")]
        public PeriodType TenderValidityPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Contract Acceptance_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period of time during which the contracting authority may accept a contract.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Contract Acceptance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractAcceptancePeriod")]
        public PeriodType ContractAcceptancePeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Appeal Terms</ccts:DictionaryEntryName><ccts:Definition>Information about the terms to present for an appeal against a tender award.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Appeal Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Appeal Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Appeal Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AppealTerms")]
        public AppealTermsType AppealTerms { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<LanguageType> _language;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Language</ccts:DictionaryEntryName><ccts:Definition>One of the default languages specified for the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Language</ccts:PropertyTerm><ccts:AssociatedObjectClass>Language</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Language</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Language")]
        public List<LanguageType> Language
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Language-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Language collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LanguageSpecified
        {
            get
            {
                return ((this.Language != null) 
                            && (this.Language.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<BudgetAccountLineType> _budgetAccountLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Budget Account Line</ccts:DictionaryEntryName><ccts:Definition>A budget account line associated with the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTerm>Budget Account Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Budget Account Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Budget Account Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("BudgetAccountLine")]
        public List<BudgetAccountLineType> BudgetAccountLine
        {
            get
            {
                return _budgetAccountLine;
            }
            set
            {
                _budgetAccountLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BudgetAccountLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BudgetAccountLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BudgetAccountLineSpecified
        {
            get
            {
                return ((this.BudgetAccountLine != null) 
                            && (this.BudgetAccountLine.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Terms. Replaced Notice_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A class defining a reference to the notice that is being replaced.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Replaced Notice</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReplacedNoticeDocumentReference")]
        public DocumentReferenceType ReplacedNoticeDocumentReference { get; set; }
    }
}
