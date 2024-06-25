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
    [XmlTypeAttribute("ConsignmentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ChildConsignment))]
    [XmlIncludeAttribute(typeof(Consignment))]
    [XmlIncludeAttribute(typeof(ReferencedConsignment))]
    public partial class ConsignmentType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier assigned to a collection of goods for both import and export.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Unique consignment reference number (UCR)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Carrier Assigned_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consignment, assigned by the carrier.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CarrierAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CarrierAssignedIdType CarrierAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Consignee Assigned_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consignment, assigned by the consignee.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consignee Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsigneeAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsigneeAssignedIdType ConsigneeAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Consignor Assigned_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consignment, assigned by the consignor.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consignor Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsignorAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsignorAssignedIdType ConsignorAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Freight Forwarder Assigned_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consignment, assigned by the freight forwarder.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight Forwarder Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreightForwarderAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FreightForwarderAssignedIdType FreightForwarderAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Broker Assigned_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consignment, assigned by the broker.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Broker Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BrokerAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BrokerAssignedIdType BrokerAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Contracted Carrier Assigned_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consignment, assigned by the contracted carrier.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Contracted Carrier Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractedCarrierAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContractedCarrierAssignedIdType ContractedCarrierAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Performing Carrier Assigned_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consignment, assigned by the performing carrier.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Performing Carrier Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PerformingCarrierAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PerformingCarrierAssignedIdType PerformingCarrierAssignedId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SummaryDescriptionType> _summaryDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Summary_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>A textual summary description of the consignment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Summary</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SummaryDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SummaryDescriptionType> SummaryDescription
        {
            get
            {
                return _summaryDescription;
            }
            set
            {
                _summaryDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SummaryDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SummaryDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SummaryDescriptionSpecified
        {
            get
            {
                return ((this.SummaryDescription != null) 
                            && (this.SummaryDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Total_ Invoice Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total of all invoice amounts declared in this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Invoice Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalInvoiceAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalInvoiceAmountType TotalInvoiceAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Declared Customs_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The total declared value for customs purposes of all the goods in this consignment, regardless of whether they are subject to the same customs procedure, tariff/statistical categorization, country information, or duty regime.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared Customs</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredCustomsValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredCustomsValueAmountType DeclaredCustomsValueAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TariffDescriptionType> _tariffDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Tariff Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the tariff applied to this consignment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Tariff Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TariffDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TariffDescriptionType> TariffDescription
        {
            get
            {
                return _tariffDescription;
            }
            set
            {
                _tariffDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TariffDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TariffDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TariffDescriptionSpecified
        {
            get
            {
                return ((this.TariffDescription != null) 
                            && (this.TariffDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Tariff Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the tariff applied to this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Tariff Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Tariff code number (WCO ID 145)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TariffCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TariffCodeType TariffCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Insurance Premium Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount of the premium payable to an insurance company for insuring the goods contained in this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Insurance Premium Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Insurance Cost</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InsurancePremiumAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InsurancePremiumAmountType InsurancePremiumAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Gross_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The total declared weight of the goods in this consignment, including packaging but excluding the carrier's equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Total gross weight (WCO ID 131)</ccts:AlternativeBusinessTerms><ccts:Examples>Total cube of all goods items referred to as one consignment.</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossWeightMeasureType GrossWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Net_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The total net weight of all the goods items referred to as one consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetWeightMeasureType NetWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Net Net_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The total net weight of the goods in this consignment, exclusive of packaging.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Net Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetNetWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetNetWeightMeasureType NetNetWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Chargeable_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The weight upon which a charge is to be based.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Chargeable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Chargeable Weight. Basis.Measure</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ChargeableWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChargeableWeightMeasureType ChargeableWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Gross_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The total volume of the goods referred to as one consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Cube</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossVolumeMeasureType GrossVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Net_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The total net volume of all goods items referred to as one consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetVolumeMeasureType NetVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Loading_ Length. Measure</ccts:DictionaryEntryName><ccts:Definition>The total length in a means of transport or a piece of transport equipment which, given the width and height of the transport means, will accommodate all of the consignments in a single consolidation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Length</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LoadingLengthMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LoadingLengthMeasureType LoadingLengthMeasure { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RemarksType> _remarks;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Remarks. Text</ccts:DictionaryEntryName><ccts:Definition>Remarks concerning the complete consignment, to be printed on the transport document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Remarks</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RemarksType> Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Remarks-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Remarks collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RemarksSpecified
        {
            get
            {
                return ((this.Remarks != null) 
                            && (this.Remarks.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Hazardous Risk_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods in this consignment are subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Hazardous Risk</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Dangerous Goods RID Indicator</ccts:AlternativeBusinessTerms><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardousRiskIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Animal_ Food Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods in this consignment are animal foodstuffs (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Animal</ccts:PropertyTermQualifier><ccts:PropertyTerm>Food Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AnimalFoodIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AnimalFoodIndicatorType AnimalFoodIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Human_ Food Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods in this consignment are for human consumption (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Human</ccts:PropertyTermQualifier><ccts:PropertyTerm>Food Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HumanFoodIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HumanFoodIndicatorType HumanFoodIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Livestock_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods are livestock (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Livestock</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LivestockIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LivestockIndicatorType LivestockIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Bulk Cargo_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods in this consignment are bulk cargoes (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Bulk Cargo</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BulkCargoIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BulkCargoIndicatorType BulkCargoIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Containerized_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods in this consignment are containerized cargoes (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Containerized</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContainerizedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContainerizedIndicatorType ContainerizedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. General Cargo_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods in this consignment are general cargoes (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>General Cargo</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GeneralCargoIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GeneralCargoIndicatorType GeneralCargoIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Special_ Security Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods in this consignment require special security (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Special</ccts:PropertyTermQualifier><ccts:PropertyTerm>Security Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SpecialSecurityIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialSecurityIndicatorType SpecialSecurityIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Third Party Payer_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that this consignment will be paid for by a third party (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Third Party Payer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ThirdPartyPayerIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ThirdPartyPayerIndicatorType ThirdPartyPayerIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CarrierServiceInstructionsType> _carrierServiceInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Carrier Service_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Service instructions to the carrier, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier Service</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CarrierServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CarrierServiceInstructionsType> CarrierServiceInstructions
        {
            get
            {
                return _carrierServiceInstructions;
            }
            set
            {
                _carrierServiceInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CarrierServiceInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CarrierServiceInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CarrierServiceInstructionsSpecified
        {
            get
            {
                return ((this.CarrierServiceInstructions != null) 
                            && (this.CarrierServiceInstructions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomsClearanceServiceInstructionsType> _customsClearanceServiceInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Customs Clearance Service_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Service instructions for customs clearance, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Customs Clearance Service</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CustomsClearanceServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomsClearanceServiceInstructionsType> CustomsClearanceServiceInstructions
        {
            get
            {
                return _customsClearanceServiceInstructions;
            }
            set
            {
                _customsClearanceServiceInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CustomsClearanceServiceInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CustomsClearanceServiceInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CustomsClearanceServiceInstructionsSpecified
        {
            get
            {
                return ((this.CustomsClearanceServiceInstructions != null) 
                            && (this.CustomsClearanceServiceInstructions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForwarderServiceInstructionsType> _forwarderServiceInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Forwarder Service_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Service instructions for the forwarder, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Forwarder Service</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ForwarderServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForwarderServiceInstructionsType> ForwarderServiceInstructions
        {
            get
            {
                return _forwarderServiceInstructions;
            }
            set
            {
                _forwarderServiceInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ForwarderServiceInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ForwarderServiceInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ForwarderServiceInstructionsSpecified
        {
            get
            {
                return ((this.ForwarderServiceInstructions != null) 
                            && (this.ForwarderServiceInstructions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialServiceInstructionsType> _specialServiceInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Special Service_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Special service instructions, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Special Service</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SpecialServiceInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialServiceInstructionsType> SpecialServiceInstructions
        {
            get
            {
                return _specialServiceInstructions;
            }
            set
            {
                _specialServiceInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SpecialServiceInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SpecialServiceInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SpecialServiceInstructionsSpecified
        {
            get
            {
                return ((this.SpecialServiceInstructions != null) 
                            && (this.SpecialServiceInstructions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Sequence Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>A sequence identifier for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Sequence Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SequenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SequenceIdType SequenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Shipping Priority Level Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the priority or level of service required for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Shipping Priority Level Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ShippingPriorityLevelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ShippingPriorityLevelCodeType ShippingPriorityLevelCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Handling Code. Code</ccts:DictionaryEntryName><ccts:Definition>The handling required for this consignment, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Handling Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Special Handling</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HandlingCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingCodeType HandlingCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingInstructionsType> _handlingInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Handling_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>The handling required for this consignment, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Handling</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HandlingInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingInstructionsType> HandlingInstructions
        {
            get
            {
                return _handlingInstructions;
            }
            set
            {
                _handlingInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HandlingInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HandlingInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HandlingInstructionsSpecified
        {
            get
            {
                return ((this.HandlingInstructions != null) 
                            && (this.HandlingInstructions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InformationType> _information;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Information. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text pertinent to this consignment, conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Information", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InformationType> Information
        {
            get
            {
                return _information;
            }
            set
            {
                _information = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Information-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Information collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InformationSpecified
        {
            get
            {
                return ((this.Information != null) 
                            && (this.Information.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Total_ Goods Item Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of goods items in this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Goods Item Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalGoodsItemQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Total_ Transport Handling Unit Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of pieces of transport handling equipment (pallets, boxes, cases, etc.) in this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Handling Unit Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Number of THUs</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalTransportHandlingUnitQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Insurance_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount covered by insurance for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Insurance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Value Insured</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InsuranceValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InsuranceValueAmountType InsuranceValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Declared For Carriage_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The value of this consignment, declared by the shipper or his agent solely for the purpose of varying the carrier's level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared For Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Declared value for carriage, Interest in delivery</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredForCarriageValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Declared Statistics_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The value, declared for statistical purposes, of those goods in this consignment that have the same statistical heading.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared Statistics</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Statistical Value</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredStatisticsValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Free On Board_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount that has to be or has been paid as calculated under the applicable trade delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Free On Board</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>FOB Value</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreeOnBoardValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FreeOnBoardValueAmountType FreeOnBoardValueAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialInstructionsType> _specialInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Special_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Special instructions relating to this consignment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Special</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SpecialInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialInstructionsType> SpecialInstructions
        {
            get
            {
                return _specialInstructions;
            }
            set
            {
                _specialInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SpecialInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SpecialInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SpecialInstructionsSpecified
        {
            get
            {
                return ((this.SpecialInstructions != null) 
                            && (this.SpecialInstructions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Split Consignment_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this consignment has been split in transit (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Split Consignment</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SplitConsignmentIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SplitConsignmentIndicatorType SplitConsignmentIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeliveryInstructionsType> _deliveryInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Delivery_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>A set of delivery instructions relating to this consignment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeliveryInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeliveryInstructionsType> DeliveryInstructions
        {
            get
            {
                return _deliveryInstructions;
            }
            set
            {
                _deliveryInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DeliveryInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliveryInstructionsSpecified
        {
            get
            {
                return ((this.DeliveryInstructions != null) 
                            && (this.DeliveryInstructions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Consignment_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The count in this consignment considering goods items, child consignments, shipments</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consignment</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsignmentQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsignmentQuantityType ConsignmentQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Consolidatable_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this consignment can be consolidated (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consolidatable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsolidatableIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsolidatableIndicatorType ConsolidatableIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HaulageInstructionsType> _haulageInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Haulage_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Instructions regarding haulage of this consignment, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Haulage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HaulageInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HaulageInstructionsType> HaulageInstructions
        {
            get
            {
                return _haulageInstructions;
            }
            set
            {
                _haulageInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HaulageInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HaulageInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HaulageInstructionsSpecified
        {
            get
            {
                return ((this.HaulageInstructions != null) 
                            && (this.HaulageInstructions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Loading_ Sequence Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the loading sequence of this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Sequence Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LoadingSequenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LoadingSequenceIdType LoadingSequenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Child Consignment Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of (consolidated) child consignments</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Child Consignment Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ChildConsignmentQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChildConsignmentQuantityType ChildConsignmentQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Total_ Packages Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of packages associated with a Consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Packages Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalPackagesQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalPackagesQuantityType TotalPackagesQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentType> _consolidatedShipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Consolidated_ Shipment. Shipment</ccts:DictionaryEntryName><ccts:Definition>A consolidated shipment (a shipment created by an act of consolidation).</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consolidated</ccts:PropertyTermQualifier><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConsolidatedShipment")]
        public List<ShipmentType> ConsolidatedShipment
        {
            get
            {
                return _consolidatedShipment;
            }
            set
            {
                _consolidatedShipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ConsolidatedShipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ConsolidatedShipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConsolidatedShipmentSpecified
        {
            get
            {
                return ((this.ConsolidatedShipment != null) 
                            && (this.ConsolidatedShipment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CustomsDeclarationType> _customsDeclaration;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Customs Declaration</ccts:DictionaryEntryName><ccts:Definition>A class describing identifiers or references relating to customs procedures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Customs Declaration</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customs Declaration</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customs Declaration</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CustomsDeclaration")]
        public List<CustomsDeclarationType> CustomsDeclaration
        {
            get
            {
                return _customsDeclaration;
            }
            set
            {
                _customsDeclaration = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CustomsDeclaration-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CustomsDeclaration collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CustomsDeclarationSpecified
        {
            get
            {
                return ((this.CustomsDeclaration != null) 
                            && (this.CustomsDeclaration.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Requested Pickup_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The pickup of this consignment requested by the party requesting a transportation service (the transport user).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Pickup</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequestedPickupTransportEvent")]
        public TransportEventType RequestedPickupTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Requested Delivery_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The delivery of this consignment requested by the party requesting a transportation service (the transport user).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequestedDeliveryTransportEvent")]
        public TransportEventType RequestedDeliveryTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Planned Pickup_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The pickup of this consignment planned by the party responsible for providing the transportation service (the transport service provider).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned Pickup</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlannedPickupTransportEvent")]
        public TransportEventType PlannedPickupTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Planned Delivery_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The delivery of this consignment planned by the party responsible for providing the transportation service (the transport service provider).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlannedDeliveryTransportEvent")]
        public TransportEventType PlannedDeliveryTransportEvent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<StatusType> _status;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Status</ccts:DictionaryEntryName><ccts:Definition>The status of a particular condition associated with this consignment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Status</ccts:PropertyTerm><ccts:AssociatedObjectClass>Status</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Status</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Status")]
        public List<StatusType> Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Status-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Status collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return ((this.Status != null) 
                            && (this.Status.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ConsignmentType> _childConsignment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Child_ Consignment. Consignment</ccts:DictionaryEntryName><ccts:Definition>One of the child consignments of which a consolidated consignment is composed.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Child</ccts:PropertyTermQualifier><ccts:PropertyTerm>Consignment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consignment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consignment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ChildConsignment")]
        public List<ConsignmentType> ChildConsignment
        {
            get
            {
                return _childConsignment;
            }
            set
            {
                _childConsignment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ChildConsignment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ChildConsignment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChildConsignmentSpecified
        {
            get
            {
                return ((this.ChildConsignment != null) 
                            && (this.ChildConsignment.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Consignee_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A party to which goods are consigned.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consignee</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Consignee (WCO ID 51 and 52)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsigneeParty")]
        public PartyType ConsigneeParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Exporter_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that makes the export declaration, or on behalf of which the export declaration is made, and that is the owner of the goods in this consignment or has similar right of disposal over them at the time when the declaration is accepted.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Exporter</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Exporter (WCO ID 41 and 42)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExporterParty")]
        public PartyType ExporterParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Consignor_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party consigning goods, as stipulated in the transport contract by the party ordering transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consignor</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Consignor (WCO ID 71 and 72)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsignorParty")]
        public PartyType ConsignorParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Importer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that makes an import declaration regarding this consignment, or on behalf of which a customs clearing agent or other authorized person makes an import declaration regarding this consignment. This may include a person who has possession of the goods or to whom the goods are consigned.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Importer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Importer (WCO ID 39 and 40)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ImporterParty")]
        public PartyType ImporterParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Carrier_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party providing the transport of goods in this consignment between named points.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Transport Company, Shipping Line, NVOCC, Airline, Haulier, Courier, Carrier (WCO ID 49 and 50)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CarrierParty")]
        public PartyType CarrierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Freight Forwarder_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party combining individual smaller consignments into a single larger shipment (the consolidated shipment), which is sent to a counterpart that mirrors the consolidator's activity by dividing the consolidated consignment into its original components.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight Forwarder</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Consolidator (WCO ID 192 AND 193)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreightForwarderParty")]
        public PartyType FreightForwarderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Notify_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party to be notified upon arrival of goods and when special occurrences (usually pre-defined) take place during a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Notify</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>WCO ID 57 and 58</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NotifyParty")]
        public PartyType NotifyParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Original Despatch_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The original despatch (sender) party for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Original Despatch</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginalDespatchParty")]
        public PartyType OriginalDespatchParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Final Delivery_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The final delivery party for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Final Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FinalDeliveryParty")]
        public PartyType FinalDeliveryParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Performing Carrier_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party performing the carriage of this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Performing Carrier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PerformingCarrierParty")]
        public PartyType PerformingCarrierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Substitute Carrier_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A substitute party performing the carriage of this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Substitute Carrier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubstituteCarrierParty")]
        public PartyType SubstituteCarrierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Logistics Operator_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The logistics operator party for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Logistics Operator</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LogisticsOperatorParty")]
        public PartyType LogisticsOperatorParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Transport Advisor_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party providing transport advice this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Transport Advisor</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportAdvisorParty")]
        public PartyType TransportAdvisorParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Hazardous Item Notification_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that would be notified of a hazardous item in this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Hazardous Item Notification</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardousItemNotificationParty")]
        public PartyType HazardousItemNotificationParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Insurance_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party holding the insurance for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Insurance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InsuranceParty")]
        public PartyType InsuranceParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Mortgage Holder_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party holding the mortgage for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Mortgage Holder</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MortgageHolderParty")]
        public PartyType MortgageHolderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Bill Of Lading Holder_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party holding the bill of lading for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Bill Of Lading Holder</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BillOfLadingHolderParty")]
        public PartyType BillOfLadingHolderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Original Departure_ Country. Country</ccts:DictionaryEntryName><ccts:Definition>The country from which the goods in this consignment were originally exported, without any commercial transaction taking place in intermediate countries.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Original Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Country</ccts:PropertyTerm><ccts:AssociatedObjectClass>Country</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Country</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Country of origin (WCO ID 062)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginalDepartureCountry")]
        public CountryType OriginalDepartureCountry { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Final Destination_ Country. Country</ccts:DictionaryEntryName><ccts:Definition>The country in which the goods in this consignment are to be delivered to the final consignee or buyer.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Final Destination</ccts:PropertyTermQualifier><ccts:PropertyTerm>Country</ccts:PropertyTerm><ccts:AssociatedObjectClass>Country</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Country</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Ultimate Destination Country, Country of Final Arrival, Country of Destination</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FinalDestinationCountry")]
        public CountryType FinalDestinationCountry { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<CountryType> _transitCountry;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Transit_ Country. Country</ccts:DictionaryEntryName><ccts:Definition>One of the countries through which goods or passengers in this consignment are routed between the country of original departure and the country of final destination.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Transit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Country</ccts:PropertyTerm><ccts:AssociatedObjectClass>Country</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Country</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Country(ies) of routing (WCO ID 064)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransitCountry")]
        public List<CountryType> TransitCountry
        {
            get
            {
                return _transitCountry;
            }
            set
            {
                _transitCountry = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransitCountry-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransitCountry collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransitCountrySpecified
        {
            get
            {
                return ((this.TransitCountry != null) 
                            && (this.TransitCountry.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Transport_ Contract. Contract</ccts:DictionaryEntryName><ccts:Definition>A transport contract relating to this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Transport</ccts:PropertyTermQualifier><ccts:PropertyTerm>Contract</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contract</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contract</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportContract")]
        public ContractType TransportContract { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _transportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A class describing a significant occurrence or happening related to the transportation of goods.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportEvent")]
        public List<TransportEventType> TransportEvent
        {
            get
            {
                return _transportEvent;
            }
            set
            {
                _transportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportEventSpecified
        {
            get
            {
                return ((this.TransportEvent != null) 
                            && (this.TransportEvent.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Original Despatch_ Transportation Service. Transportation Service</ccts:DictionaryEntryName><ccts:Definition>The service for pickup from the consignor under the transport contract for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Original Despatch</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transportation Service</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transportation Service</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transportation Service</ccts:RepresentationTerm><ccts:Examples>Door-to-door , Pier-to-door </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginalDespatchTransportationService")]
        public TransportationServiceType OriginalDespatchTransportationService { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Final Delivery_ Transportation Service. Transportation Service</ccts:DictionaryEntryName><ccts:Definition>The service for delivery to the consignee under the transport contract for this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Final Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transportation Service</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transportation Service</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transportation Service</ccts:RepresentationTerm><ccts:Examples>Door-to-door , Pier-to-door </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FinalDeliveryTransportationService")]
        public TransportationServiceType FinalDeliveryTransportationService { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Delivery Terms</ccts:DictionaryEntryName><ccts:Definition>The conditions agreed upon between a seller and a buyer with regard to the delivery of goods and/or services (e.g., CIF, FOB, or EXW from the INCOTERMS Terms of Delivery).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Delivery Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Terms</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Trade Terms, INCOTERMS</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType DeliveryTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>The terms of payment between the parties (such as logistics service client, logistics service provider) in a transaction.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentTerms")]
        public PaymentTermsType PaymentTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Collect_ Payment Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>The terms of payment that apply to the collection of this consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Collect</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CollectPaymentTerms")]
        public PaymentTermsType CollectPaymentTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Disbursement_ Payment Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>The terms of payment for disbursement.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Disbursement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DisbursementPaymentTerms")]
        public PaymentTermsType DisbursementPaymentTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Prepaid_ Payment Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>The terms of payment for prepayment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Prepaid</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PrepaidPaymentTerms")]
        public PaymentTermsType PrepaidPaymentTerms { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _freightAllowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Freight_ Allowance Charge. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A cost incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage for this consignment. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance to the extent that they relate to the freight costs.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight</ccts:PropertyTermQualifier><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Freight Costs</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FreightAllowanceCharge")]
        public List<AllowanceChargeType> FreightAllowanceCharge
        {
            get
            {
                return _freightAllowanceCharge;
            }
            set
            {
                _freightAllowanceCharge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FreightAllowanceCharge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FreightAllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FreightAllowanceChargeSpecified
        {
            get
            {
                return ((this.FreightAllowanceCharge != null) 
                            && (this.FreightAllowanceCharge.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _extraAllowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Extra_ Allowance Charge. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A charge for extra allowance.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Extra</ccts:PropertyTermQualifier><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ExtraAllowanceCharge")]
        public List<AllowanceChargeType> ExtraAllowanceCharge
        {
            get
            {
                return _extraAllowanceCharge;
            }
            set
            {
                _extraAllowanceCharge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExtraAllowanceCharge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExtraAllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ExtraAllowanceChargeSpecified
        {
            get
            {
                return ((this.ExtraAllowanceCharge != null) 
                            && (this.ExtraAllowanceCharge.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentStageType> _mainCarriageShipmentStage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Main Carriage_ Shipment Stage. Shipment Stage</ccts:DictionaryEntryName><ccts:Definition>A shipment stage during main carriage.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Main Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Shipment Stage</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment Stage</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment Stage</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MainCarriageShipmentStage")]
        public List<ShipmentStageType> MainCarriageShipmentStage
        {
            get
            {
                return _mainCarriageShipmentStage;
            }
            set
            {
                _mainCarriageShipmentStage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MainCarriageShipmentStage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MainCarriageShipmentStage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MainCarriageShipmentStageSpecified
        {
            get
            {
                return ((this.MainCarriageShipmentStage != null) 
                            && (this.MainCarriageShipmentStage.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentStageType> _preCarriageShipmentStage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Pre Carriage_ Shipment Stage. Shipment Stage</ccts:DictionaryEntryName><ccts:Definition>A shipment stage during precarriage (usually refers to movement activity that takes place prior to the container being loaded at a port of loading).</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Pre Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Shipment Stage</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment Stage</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment Stage</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PreCarriageShipmentStage")]
        public List<ShipmentStageType> PreCarriageShipmentStage
        {
            get
            {
                return _preCarriageShipmentStage;
            }
            set
            {
                _preCarriageShipmentStage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PreCarriageShipmentStage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PreCarriageShipmentStage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PreCarriageShipmentStageSpecified
        {
            get
            {
                return ((this.PreCarriageShipmentStage != null) 
                            && (this.PreCarriageShipmentStage.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentStageType> _onCarriageShipmentStage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. On Carriage_ Shipment Stage. Shipment Stage</ccts:DictionaryEntryName><ccts:Definition>A shipment stage during on-carriage (usually refers to movement activity that takes place after the container is discharged at a port of discharge).</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>On Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Shipment Stage</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment Stage</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment Stage</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OnCarriageShipmentStage")]
        public List<ShipmentStageType> OnCarriageShipmentStage
        {
            get
            {
                return _onCarriageShipmentStage;
            }
            set
            {
                _onCarriageShipmentStage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OnCarriageShipmentStage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OnCarriageShipmentStage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OnCarriageShipmentStageSpecified
        {
            get
            {
                return ((this.OnCarriageShipmentStage != null) 
                            && (this.OnCarriageShipmentStage.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportHandlingUnitType> _transportHandlingUnit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Transport Handling Unit</ccts:DictionaryEntryName><ccts:Definition>A transport handling unit used for loose and containerized goods.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTerm>Transport Handling Unit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Handling Unit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Handling Unit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportHandlingUnit")]
        public List<TransportHandlingUnitType> TransportHandlingUnit
        {
            get
            {
                return _transportHandlingUnit;
            }
            set
            {
                _transportHandlingUnit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportHandlingUnit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportHandlingUnit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportHandlingUnitSpecified
        {
            get
            {
                return ((this.TransportHandlingUnit != null) 
                            && (this.TransportHandlingUnit.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. First Arrival Port_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The first arrival location in a transport. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>First Arrival Port</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FirstArrivalPortLocation")]
        public LocationType FirstArrivalPortLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consignment. Last Exit Port_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The final exporting location in a transport. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consignment</ccts:ObjectClass><ccts:PropertyTermQualifier>Last Exit Port</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LastExitPortLocation")]
        public LocationType LastExitPortLocation { get; set; }
    }
}
