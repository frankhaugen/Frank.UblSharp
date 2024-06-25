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
    [XmlTypeAttribute("ShipmentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ConsolidatedShipment))]
    [XmlIncludeAttribute(typeof(ReferencedShipment))]
    [XmlIncludeAttribute(typeof(ReportedShipment))]
    [XmlIncludeAttribute(typeof(Shipment))]
    public partial class ShipmentType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this shipment.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Waybill Number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Shipping Priority Level Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the priority or level of service required for this shipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Shipping Priority Level Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Service Level, Service Priority</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ShippingPriorityLevelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ShippingPriorityLevelCodeType ShippingPriorityLevelCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Handling Code. Code</ccts:DictionaryEntryName><ccts:Definition>The handling required for this shipment, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Handling Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Special Handling</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HandlingCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingCodeType HandlingCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingInstructionsType> _handlingInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Handling_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>The handling required for this shipment, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Handling</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Information. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text pertinent to this shipment, conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Gross_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The total gross weight of a shipment; the weight of the goods plus packaging plus transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossWeightMeasureType GrossWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Net_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The net weight of this shipment, excluding packaging.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetWeightMeasureType NetWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Net Net_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The total net weight of this shipment, excluding packaging and transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Net Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetNetWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetNetWeightMeasureType NetNetWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Gross_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The total volume of the goods in this shipment, including packaging.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossVolumeMeasureType GrossVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Net_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The total volume of the goods in this shipment, excluding packaging and transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetVolumeMeasureType NetVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Total_ Goods Item Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of goods items in this shipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Goods Item Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalGoodsItemQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Total_ Transport Handling Unit Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of pieces of transport handling equipment (pallets, boxes, cases, etc.) in this shipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Handling Unit Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Number of THUs</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalTransportHandlingUnitQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Insurance_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount covered by insurance for this shipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Insurance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Value Insured</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InsuranceValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InsuranceValueAmountType InsuranceValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Declared Customs_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The total declared value for customs purposes of those goods in this shipment that are subject to the same customs procedure and have the same tariff/statistical heading, country information, and duty regime.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared Customs</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredCustomsValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredCustomsValueAmountType DeclaredCustomsValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Declared For Carriage_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The value of this shipment, declared by the shipper or his agent solely for the purpose of varying the carrier's level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared For Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Declared value for carriage, Interest in delivery</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredForCarriageValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Declared Statistics_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The value, declared for statistical purposes, of those goods in this shipment that have the same statistical heading.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared Statistics</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Statistical Value</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclaredStatisticsValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Free On Board_ Value. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount that has to be or has been paid as calculated under the applicable trade delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Free On Board</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>FOB Value</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreeOnBoardValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FreeOnBoardValueAmountType FreeOnBoardValueAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialInstructionsType> _specialInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Special_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Special instructions relating to this shipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Special</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeliveryInstructionsType> _deliveryInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Delivery_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Delivery instructions relating to this shipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Split Consignment_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that the consignment has been split in transit (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Split Consignment</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SplitConsignmentIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SplitConsignmentIndicatorType SplitConsignmentIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Consignment_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of consignments within this shipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Consignment</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsignmentQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsignmentQuantityType ConsignmentQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ConsignmentType> _consignment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Consignment</ccts:DictionaryEntryName><ccts:Definition>A consignment covering this shipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Consignment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consignment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consignment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Consignment")]
        public List<ConsignmentType> Consignment
        {
            get
            {
                return _consignment;
            }
            set
            {
                _consignment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Consignment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Consignment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConsignmentSpecified
        {
            get
            {
                return ((this.Consignment != null) 
                            && (this.Consignment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<GoodsItemType> _goodsItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Goods Item</ccts:DictionaryEntryName><ccts:Definition>A goods item included in this shipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Goods Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Goods Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Goods Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("GoodsItem")]
        public List<GoodsItemType> GoodsItem
        {
            get
            {
                return _goodsItem;
            }
            set
            {
                _goodsItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die GoodsItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the GoodsItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool GoodsItemSpecified
        {
            get
            {
                return ((this.GoodsItem != null) 
                            && (this.GoodsItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentStageType> _shipmentStage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Shipment Stage</ccts:DictionaryEntryName><ccts:Definition>A stage in the transport movement of this shipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Shipment Stage</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment Stage</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment Stage</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShipmentStage")]
        public List<ShipmentStageType> ShipmentStage
        {
            get
            {
                return _shipmentStage;
            }
            set
            {
                _shipmentStage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ShipmentStage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ShipmentStage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShipmentStageSpecified
        {
            get
            {
                return ((this.ShipmentStage != null) 
                            && (this.ShipmentStage.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Delivery</ccts:DictionaryEntryName><ccts:Definition>The delivery of this shipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Delivery")]
        public DeliveryType Delivery {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<TransportHandlingUnitType> _transportHandlingUnit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Transport Handling Unit</ccts:DictionaryEntryName><ccts:Definition>A transport handling unit associated with this shipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTerm>Transport Handling Unit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Handling Unit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Handling Unit</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Return_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The address to which a shipment should be returned.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Return</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReturnAddress")]
        public AddressType ReturnAddress { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Origin_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The region in which the goods have been produced or manufactured, according to criteria laid down for the purposes of application of the customs tariff, or of quantitative restrictions, or of any other measure related to trade.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Origin</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginAddress")]
        public AddressType OriginAddress { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. First Arrival Port_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The first arrival location of a shipment. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>First Arrival Port</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FirstArrivalPortLocation")]
        public LocationType FirstArrivalPortLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Last Exit Port_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The final exporting location for a shipment. This would be a port for sea, an airport for air, a terminal for rail, or a border post for land crossing.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Last Exit Port</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LastExitPortLocation")]
        public LocationType LastExitPortLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Export_ Country. Country</ccts:DictionaryEntryName><ccts:Definition>The country from which the goods were originally exported, without any commercial transaction taking place in intermediate countries.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Export</ccts:PropertyTermQualifier><ccts:PropertyTerm>Country</ccts:PropertyTerm><ccts:AssociatedObjectClass>Country</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Country</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Country of exportation (WCO ID 062)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExportCountry")]
        public CountryType ExportCountry { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _freightAllowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment. Freight_ Allowance Charge. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A cost incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance to the extent that they relate to the freight costs.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight</ccts:PropertyTermQualifier><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Freight Costs</ccts:AlternativeBusinessTerms></ccts:Component></para>
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
    }
}