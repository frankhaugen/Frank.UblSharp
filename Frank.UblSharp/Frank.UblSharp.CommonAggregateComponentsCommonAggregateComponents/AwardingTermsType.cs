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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define the terms for awarding a contract.</ccts:Definition><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("AwardingTermsType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("AwardingTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AwardingTermsType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Weighting Algorithm Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the weighting algorithm for awarding criteria. When multiple awarding criteria is used, different weighting and choices management algorithms based upon scores and weights of all award criteria can be used. An algorithm for weighting criteria shall be reported in the call for tenders document. It is used to determine how to perform the final management of tenders based on the results in each of the established award criteria</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Weighting Algorithm Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WeightingAlgorithmCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WeightingAlgorithmCodeType WeightingAlgorithmCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing terms under which the contract is to be awarded.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TechnicalCommitteeDescriptionType> _technicalCommitteeDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Technical Committee_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the committee of experts evaluating the subjective criteria for awarding the contract.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Technical Committee</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TechnicalCommitteeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TechnicalCommitteeDescriptionType> TechnicalCommitteeDescription
        {
            get
            {
                return _technicalCommitteeDescription;
            }
            set
            {
                _technicalCommitteeDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TechnicalCommitteeDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TechnicalCommitteeDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TechnicalCommitteeDescriptionSpecified
        {
            get
            {
                return ((this.TechnicalCommitteeDescription != null) 
                            && (this.TechnicalCommitteeDescription.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LowTendersDescriptionType> _lowTendersDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Low Tenders_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the exclusion criterion for abnormally low tenders.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Low Tenders</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("LowTendersDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LowTendersDescriptionType> LowTendersDescription
        {
            get
            {
                return _lowTendersDescription;
            }
            set
            {
                _lowTendersDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LowTendersDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the LowTendersDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LowTendersDescriptionSpecified
        {
            get
            {
                return ((this.LowTendersDescription != null) 
                            && (this.LowTendersDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Prize Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>Indicates whether a prize will be awarded (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Prize Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PrizeIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PrizeIndicatorType PrizeIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PrizeDescriptionType> _prizeDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Prize Description. Text</ccts:DictionaryEntryName><ccts:Definition>Number and value of the prizes to be awarded.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Prize Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PrizeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PrizeDescriptionType> PrizeDescription
        {
            get
            {
                return _prizeDescription;
            }
            set
            {
                _prizeDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PrizeDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PrizeDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PrizeDescriptionSpecified
        {
            get
            {
                return ((this.PrizeDescription != null) 
                            && (this.PrizeDescription.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentDescriptionType> _paymentDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Payment Description. Text</ccts:DictionaryEntryName><ccts:Definition>Details of payments to all participants.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PaymentDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentDescriptionType> PaymentDescription
        {
            get
            {
                return _paymentDescription;
            }
            set
            {
                _paymentDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PaymentDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentDescriptionSpecified
        {
            get
            {
                return ((this.PaymentDescription != null) 
                            && (this.PaymentDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Followup Contract Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>Indicates if any service contract following the contest will be awarded to the winner or one of the winners of the contest (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Followup Contract Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FollowupContractIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FollowupContractIndicatorType FollowupContractIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Binding On Buyer Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>Indicates if the decision is binding on the buyer (true) or not (false). </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Binding On Buyer Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BindingOnBuyerIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BindingOnBuyerIndicatorType BindingOnBuyerIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AwardingCriterionType> _awardingCriterion;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Awarding Criterion</ccts:DictionaryEntryName><ccts:Definition>Defines a criterion for awarding this tender.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTerm>Awarding Criterion</ccts:PropertyTerm><ccts:AssociatedObjectClass>Awarding Criterion</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Awarding Criterion</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AwardingCriterion")]
        public List<AwardingCriterionType> AwardingCriterion
        {
            get
            {
                return _awardingCriterion;
            }
            set
            {
                _awardingCriterion = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AwardingCriterion-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AwardingCriterion collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AwardingCriterionSpecified
        {
            get
            {
                return ((this.AwardingCriterion != null) 
                            && (this.AwardingCriterion.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PersonType> _technicalCommitteePerson;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Awarding Terms. Technical Committee_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>A member of a committee of experts evaluating the subjective criteria for awarding the contract.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Awarding Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Technical Committee</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TechnicalCommitteePerson")]
        public List<PersonType> TechnicalCommitteePerson
        {
            get
            {
                return _technicalCommitteePerson;
            }
            set
            {
                _technicalCommitteePerson = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TechnicalCommitteePerson-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TechnicalCommitteePerson collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TechnicalCommitteePersonSpecified
        {
            get
            {
                return ((this.TechnicalCommitteePerson != null) 
                            && (this.TechnicalCommitteePerson.Count != 0));
            }
        }
    }
}
