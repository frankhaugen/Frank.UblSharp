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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the awarding of a tender in a tendering process.</ccts:Definition><ccts:ObjectClass>Tender Result</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TenderResultType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TenderResult", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderResultType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Tender_ Result Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the result of the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Tender</ccts:PropertyTermQualifier><ccts:PropertyTerm>Result Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TenderResultCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderResultCodeType TenderResultCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the result of the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Advertisement. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary value of the advertisement for this tendering process. </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Advertisement</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AdvertisementAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdvertisementAmountType AdvertisementAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Award Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this result was formalized.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Award Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("AwardDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardDateType AwardDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Award Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time at which this result was formalized.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Award Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AwardTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardTimeType AwardTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Received_ Tender. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of tenders received in this tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Received</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tender</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReceivedTenderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceivedTenderQuantityType ReceivedTenderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Lower_ Tender. Amount</ccts:DictionaryEntryName><ccts:Definition>The least expensive tender received in the tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Lower</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tender</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LowerTenderAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LowerTenderAmountType LowerTenderAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Higher_ Tender. Amount</ccts:DictionaryEntryName><ccts:Definition>The most expensive tender received in this tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Higher</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tender</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HigherTenderAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HigherTenderAmountType HigherTenderAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Start Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which the awarded contract begins.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Start Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StartDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.StartDateType StartDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Received_ Electronic Tender Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of electronic tenders received.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Received</ccts:PropertyTermQualifier><ccts:PropertyTerm>Electronic Tender Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReceivedElectronicTenderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceivedElectronicTenderQuantityType ReceivedElectronicTenderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Received_ Foreign Tender Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of foreing tenders received.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Received</ccts:PropertyTermQualifier><ccts:PropertyTerm>Foreign Tender Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReceivedForeignTenderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceivedForeignTenderQuantityType ReceivedForeignTenderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Contract</ccts:DictionaryEntryName><ccts:Definition>A contract governing this tender result.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Contract</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contract</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contract</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Contract")]
        public ContractType Contract {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Awarded_ Tendered Project. Tendered Project</ccts:DictionaryEntryName><ccts:Definition>The awarded tendered project associated with this tender result.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Awarded</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tendered Project</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tendered Project</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tendered Project</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AwardedTenderedProject")]
        public TenderedProjectType AwardedTenderedProject { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Contract Formalization_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which a contract associated with the awarded project is to be formalized.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTermQualifier>Contract Formalization</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractFormalizationPeriod")]
        public PeriodType ContractFormalizationPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<SubcontractTermsType> _subcontractTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Subcontract Terms</ccts:DictionaryEntryName><ccts:Definition>Subcontract terms for this tender result.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Subcontract Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Subcontract Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Subcontract Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SubcontractTerms")]
        public List<SubcontractTermsType> SubcontractTerms
        {
            get
            {
                return _subcontractTerms;
            }
            set
            {
                _subcontractTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SubcontractTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SubcontractTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubcontractTermsSpecified
        {
            get
            {
                return ((this.SubcontractTerms != null) 
                            && (this.SubcontractTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<WinningPartyType> _winningParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Result. Winning Party</ccts:DictionaryEntryName><ccts:Definition>A party that is identified as the awarded by a tender result.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Result</ccts:ObjectClass><ccts:PropertyTerm>Winning Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Winning Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Winning Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("WinningParty")]
        public List<WinningPartyType> WinningParty
        {
            get
            {
                return _winningParty;
            }
            set
            {
                _winningParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die WinningParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the WinningParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WinningPartySpecified
        {
            get
            {
                return ((this.WinningParty != null) 
                            && (this.WinningParty.Count != 0));
            }
        }
    }
}
