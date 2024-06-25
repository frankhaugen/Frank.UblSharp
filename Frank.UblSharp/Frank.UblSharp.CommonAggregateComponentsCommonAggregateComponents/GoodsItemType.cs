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
    [XmlTypeAttribute("GoodsItemType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ContainedGoodsItem))]
    [XmlIncludeAttribute(typeof(GoodsItem))]
    [XmlIncludeAttribute(typeof(ReferencedGoodsItem))]
    public partial class GoodsItemType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Sequence Number. Identifier</ccts:DictionaryEntryName><ccts:Definition>A sequence number differentiating a specific goods item within a consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Sequence Number</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SequenceNumberID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SequenceNumberIdType SequenceNumberId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this goods item to identify it for customs, statistical, or transport purposes.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Description of goods (WCO ID 137)</ccts:AlternativeBusinessTerms></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Hazardous Risk_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported goods item is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Hazardous Risk</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardousRiskIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Declared Customs_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The total declared value for customs purposes of the goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared Customs</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>For Customs Value (WCO ID 108)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredCustomsValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredCustomsValueAmountType DeclaredCustomsValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Declared For Carriage_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The value of this goods item, declared by the shipper or his agent solely for the purpose of varying the carrier's level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared For Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Interest in delivery, declared value for carriage</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredForCarriageValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Declared Statistics_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The total declared value of all the goods items in the same consignment with this goods item that have the same statistical heading.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared Statistics</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Statistical Value (WCO ID 114)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredStatisticsValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Free On Board_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount that has to be or has been paid as calculated under the applicable trade delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Free On Board</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>FOB Value</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreeOnBoardValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FreeOnBoardValueAmountType FreeOnBoardValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Insurance_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount covered by insurance for this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Insurance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Value Insured</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InsuranceValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InsuranceValueAmountType InsuranceValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount on which a duty, tax, or fee will be assessed.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ValueAmountType ValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Gross_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The weight of this goods item, including packing and packaging but excluding the carrier's equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Actual Gross Weight</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossWeightMeasureType GrossWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Net_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The weight of this goods item, excluding packing but including packaging that normally accompanies the goods.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetWeightMeasureType NetWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Net Net_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The total weight of this goods item, excluding all packing and packaging.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Net Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Customs Weight (WCO ID 128)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetNetWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetNetWeightMeasureType NetNetWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Chargeable_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The weight on which a charge is to be based.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Chargeable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ChargeableWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChargeableWeightMeasureType ChargeableWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Gross_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The volume of this goods item, normally calculated by multiplying its maximum length, width, and height.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Volume, Gross Measurement Cube (GMC), Cube (WCO ID 134)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossVolumeMeasureType GrossVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Net_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The volume contained by a goods item, excluding the volume of any packaging material.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetVolumeMeasureType NetVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of units making up this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Preference Criterion Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the treatment preference for this goods item according to international trading agreements.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Preference Criterion Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Preference Criterion is used in the following manner in the paper CO of another country (e.g.):
        ///A - The good is wholly obtained or produced entirely in the territory of one or more of the NAFTA countries as reference in Article 415. Note: The purchase of a good in the territory does not necessarily render it wholly obtained or produced . If the good is an agricultural good, see also criterion F and Annex 703.2. (Reference: Article 401(a), 415).
        ///B - ...
        ///C - ...
        ///D - ...
        ///E - ...
        ///F - The good is an originating agricultural good under preference criterion A,B, or C above and is not subjected to quantitative restriction in the importing NAFTA country because....
        ///Thus, the column Preference Criterion will indicate either A, B, C,...</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreferenceCriterionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreferenceCriterionCodeType PreferenceCriterionCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Required_ Customs Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for a set of tariff codes required to specify a type of goods for customs, transport, statistical, or other regulatory purposes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customs Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Tariff code extensions (WCO ID 255)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequiredCustomsID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RequiredCustomsIdType RequiredCustomsId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Customs Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code assigned by customs to signify the status of this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Customs Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Customs status of goods (WCO ID 094)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CustomsStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomsStatusCodeType CustomsStatusCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Customs Tariff Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>Quantity of the units in this goods item as required by customs for tariff, statistical, or fiscal purposes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Customs Tariff Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CustomsTariffQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomsTariffQuantityType CustomsTariffQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Customs Import_ Classified Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this goods item has been classified for import by customs (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Customs Import</ccts:PropertyTermQualifier><ccts:PropertyTerm>Classified Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CustomsImportClassifiedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Chargeable_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of units in the goods item to which charges apply.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Chargeable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ChargeableQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChargeableQuantityType ChargeableQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Returnable_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of units in the goods item that may be returned.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Returnable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReturnableQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReturnableQuantityType ReturnableQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Trace_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for use in tracing this goods item, such as the EPC number used in RFID.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Trace</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TraceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TraceIdType TraceId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemType> _item;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Item</ccts:DictionaryEntryName><ccts:Definition>Product information relating to a goods item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Item")]
        public List<ItemType> Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Item-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Item collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ItemSpecified
        {
            get
            {
                return ((this.Item != null) 
                            && (this.Item.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<GoodsItemContainerType> _goodsItemContainer;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Goods Item Container</ccts:DictionaryEntryName><ccts:Definition>The transporting of a goods item in a unit of transport equipment (e.g., container).</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Goods Item Container</ccts:PropertyTerm><ccts:AssociatedObjectClass>Goods Item Container</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Goods Item Container</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("GoodsItemContainer")]
        public List<GoodsItemContainerType> GoodsItemContainer
        {
            get
            {
                return _goodsItemContainer;
            }
            set
            {
                _goodsItemContainer = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die GoodsItemContainer-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the GoodsItemContainer collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool GoodsItemContainerSpecified
        {
            get
            {
                return ((this.GoodsItemContainer != null) 
                            && (this.GoodsItemContainer.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _freightAllowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Freight_ Allowance Charge. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A cost incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance to the extent that they relate to the freight costs.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight</ccts:PropertyTermQualifier><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Freight Costs</ccts:AlternativeBusinessTerms></ccts:Component></para>
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
        private List<InvoiceLineType> _invoiceLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Invoice Line</ccts:DictionaryEntryName><ccts:Definition>Information about an invoice line relating to this goods item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Invoice Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Invoice Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Invoice Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("InvoiceLine")]
        public List<InvoiceLineType> InvoiceLine
        {
            get
            {
                return _invoiceLine;
            }
            set
            {
                _invoiceLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die InvoiceLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the InvoiceLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InvoiceLineSpecified
        {
            get
            {
                return ((this.InvoiceLine != null) 
                            && (this.InvoiceLine.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TemperatureType> _temperature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Temperature</ccts:DictionaryEntryName><ccts:Definition>The temperature of the goods item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm><ccts:Examples>maximum, storage, minimum</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Temperature")]
        public List<TemperatureType> Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Temperature-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Temperature collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TemperatureSpecified
        {
            get
            {
                return ((this.Temperature != null) 
                            && (this.Temperature.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<GoodsItemType> _containedGoodsItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Contained_ Goods Item. Goods Item</ccts:DictionaryEntryName><ccts:Definition>A goods item contained in this goods item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Contained</ccts:PropertyTermQualifier><ccts:PropertyTerm>Goods Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Goods Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Goods Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContainedGoodsItem")]
        public List<GoodsItemType> ContainedGoodsItem
        {
            get
            {
                return _containedGoodsItem;
            }
            set
            {
                _containedGoodsItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContainedGoodsItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContainedGoodsItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContainedGoodsItemSpecified
        {
            get
            {
                return ((this.ContainedGoodsItem != null) 
                            && (this.ContainedGoodsItem.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Origin_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The region in which the goods have been produced or manufactured, according to criteria laid down for the purposes of application of the customs tariff, or of quantitative restrictions, or of any other measure related to trade.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Origin</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Region of origin (WCO ID 066)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginAddress")]
        public AddressType OriginAddress { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Delivery</ccts:DictionaryEntryName><ccts:Definition>The delivery of this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Delivery")]
        public DeliveryType Delivery { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Pickup</ccts:DictionaryEntryName><ccts:Definition>The pickup of this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Pickup</ccts:PropertyTerm><ccts:AssociatedObjectClass>Pickup</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Pickup</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Pickup")]
        public PickupType Pickup { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Despatch</ccts:DictionaryEntryName><ccts:Definition>The despatch of this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTerm>Despatch</ccts:PropertyTerm><ccts:AssociatedObjectClass>Despatch</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Despatch</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Despatch")]
        public DespatchType Despatch { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DimensionType> _measurementDimension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>A measurable dimension (length, mass, weight, or volume) of this goods item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MeasurementDimension")]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeasurementDimension-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MeasurementDimension collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MeasurementDimensionSpecified
        {
            get
            {
                return ((this.MeasurementDimension != null) 
                            && (this.MeasurementDimension.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PackageType> _containingPackage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Containing_ Package. Package</ccts:DictionaryEntryName><ccts:Definition>A package containing this goods item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Containing</ccts:PropertyTermQualifier><ccts:PropertyTerm>Package</ccts:PropertyTerm><ccts:AssociatedObjectClass>Package</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Package</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContainingPackage")]
        public List<PackageType> ContainingPackage
        {
            get
            {
                return _containingPackage;
            }
            set
            {
                _containingPackage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContainingPackage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContainingPackage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContainingPackageSpecified
        {
            get
            {
                return ((this.ContainingPackage != null) 
                            && (this.ContainingPackage.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Shipment_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a shipping document associated with this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Shipment</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ShipmentDocumentReference")]
        public DocumentReferenceType ShipmentDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Minimum_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>Information about minimum temperature.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumTemperature")]
        public TemperatureType MinimumTemperature { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item. Maximum_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>Information about maximum temperature.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumTemperature")]
        public TemperatureType MaximumTemperature { get; set; }
    }
}
