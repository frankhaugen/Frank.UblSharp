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
    [XmlTypeAttribute("ShipmentStageType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(MainCarriageShipmentStage))]
    [XmlIncludeAttribute(typeof(OnCarriageShipmentStage))]
    [XmlIncludeAttribute(typeof(PreCarriageShipmentStage))]
    [XmlIncludeAttribute(typeof(ShipmentStage))]
    public partial class ShipmentStageType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>1 , 2 , etc..</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Transport Mode Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the method of transport used for this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Transport Mode Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Transport Mode</ccts:DataTypeQualifier><ccts:DataType>Transport Mode_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportModeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportModeCodeType TransportModeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Transport Means Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the kind of transport means (truck, vessel, etc.) used for this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Transport Means Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportMeansTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportMeansTypeCodeType TransportMeansTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Transit_ Direction Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the direction of transit in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Transit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Direction Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransitDirectionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransitDirectionCodeType TransitDirectionCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Pre Carriage_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this stage takes place before the main carriage of the shipment (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Pre Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>Truck delivery to wharf</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreCarriageIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreCarriageIndicatorType PreCarriageIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. On Carriage_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this stage takes place after the main carriage of the shipment (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>On Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>Truck delivery from wharf</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OnCarriageIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OnCarriageIndicatorType OnCarriageIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Estimated_ Delivery Date. Date</ccts:DictionaryEntryName><ccts:Definition>The estimated date of delivery in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedDeliveryDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EstimatedDeliveryDateType EstimatedDeliveryDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Estimated_ Delivery Time. Time</ccts:DictionaryEntryName><ccts:Definition>The estimated time of delivery in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedDeliveryTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EstimatedDeliveryTimeType EstimatedDeliveryTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Required_ Delivery Date. Date</ccts:DictionaryEntryName><ccts:Definition>The delivery date required by the buyer in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequiredDeliveryDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RequiredDeliveryDateType RequiredDeliveryDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Required_ Delivery Time. Time</ccts:DictionaryEntryName><ccts:Definition>The delivery time required by the buyer in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequiredDeliveryTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RequiredDeliveryTimeType RequiredDeliveryTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Loading_ Sequence Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the loading sequence (of consignments) associated with this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Sequence Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LoadingSequenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LoadingSequenceIdType LoadingSequenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Successive_ Sequence Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies the successive loading sequence (of consignments) associated with a shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Successive</ccts:PropertyTermQualifier><ccts:PropertyTerm>Sequence Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SuccessiveSequenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SuccessiveSequenceIdType SuccessiveSequenceId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InstructionsType> _instructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Text of instructions applicable to a shipment stage.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Instructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InstructionsType> Instructions
        {
            get
            {
                return _instructions;
            }
            set
            {
                _instructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Instructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Instructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InstructionsSpecified
        {
            get
            {
                return ((this.Instructions != null) 
                            && (this.Instructions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DemurrageInstructionsType> _demurrageInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Demurrage_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>Text of instructions relating to demurrage (the case in which a vessel is prevented from loading or discharging cargo within the stipulated laytime).</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Demurrage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DemurrageInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DemurrageInstructionsType> DemurrageInstructions
        {
            get
            {
                return _demurrageInstructions;
            }
            set
            {
                _demurrageInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DemurrageInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DemurrageInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DemurrageInstructionsSpecified
        {
            get
            {
                return ((this.DemurrageInstructions != null) 
                            && (this.DemurrageInstructions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Crew Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of crew aboard a transport means.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Crew Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CrewQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CrewQuantityType CrewQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Passenger Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of passengers aboard a transport means.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Passenger Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PassengerQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PassengerQuantityType PassengerQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Transit_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which this shipment stage actually took place.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Transit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransitPeriod")]
        public PeriodType TransitPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PartyType> _carrierParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Carrier_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A carrier party responsible for this shipment stage.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CarrierParty")]
        public List<PartyType> CarrierParty
        {
            get
            {
                return _carrierParty;
            }
            set
            {
                _carrierParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CarrierParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CarrierParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CarrierPartySpecified
        {
            get
            {
                return ((this.CarrierParty != null) 
                            && (this.CarrierParty.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Transport Means</ccts:DictionaryEntryName><ccts:Definition>The means of transport used in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Transport Means</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Means</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Means</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportMeans")]
        public TransportMeansType TransportMeans { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Loading Port_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location of loading for a shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading Port</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LoadingPortLocation")]
        public LocationType LoadingPortLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Unloading Port_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location of unloading for a shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Unloading Port</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UnloadingPortLocation")]
        public LocationType UnloadingPortLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Transship Port_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location of transshipment relating to a shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Transship Port</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransshipPortLocation")]
        public LocationType TransshipPortLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Loading_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The loading of goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LoadingTransportEvent")]
        public TransportEventType LoadingTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Examination_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The examination of shipments in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Examination</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExaminationTransportEvent")]
        public TransportEventType ExaminationTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Availability_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The making available of shipments in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Availability</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AvailabilityTransportEvent")]
        public TransportEventType AvailabilityTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Exportation_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The export event associated with this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Exportation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExportationTransportEvent")]
        public TransportEventType ExportationTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Discharge_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The discharge event associated with this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Discharge</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DischargeTransportEvent")]
        public TransportEventType DischargeTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Warehousing_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The warehousing event associated with this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Warehousing</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarehousingTransportEvent")]
        public TransportEventType WarehousingTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Takeover_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The receiver's takeover of the goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Takeover</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TakeoverTransportEvent")]
        public TransportEventType TakeoverTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Optional Takeover_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The optional takeover of the goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Optional Takeover</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OptionalTakeoverTransportEvent")]
        public TransportEventType OptionalTakeoverTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Dropoff_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The dropping off of goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Dropoff</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DropoffTransportEvent")]
        public TransportEventType DropoffTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Actual Pickup_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The pickup of goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual Pickup</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualPickupTransportEvent")]
        public TransportEventType ActualPickupTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Delivery_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The delivery of goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryTransportEvent")]
        public TransportEventType DeliveryTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Receipt_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The receipt of goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Receipt</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReceiptTransportEvent")]
        public TransportEventType ReceiptTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Storage_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The storage of goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Storage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StorageTransportEvent")]
        public TransportEventType StorageTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Acceptance_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The acceptance of goods in this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Acceptance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AcceptanceTransportEvent")]
        public TransportEventType AcceptanceTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Terminal Operator_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A terminal operator associated with this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Terminal Operator</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TerminalOperatorParty")]
        public PartyType TerminalOperatorParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Customs Agent_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A customs agent associated with this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Customs Agent</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CustomsAgentParty")]
        public PartyType CustomsAgentParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Estimated Transit_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The estimated transit period of this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated Transit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedTransitPeriod")]
        public PeriodType EstimatedTransitPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _freightAllowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Freight_ Allowance Charge. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A freight allowance charge for this shipment stage.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight</ccts:PropertyTermQualifier><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Freight Charge_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location associated with a freight charge related to this shipment stage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight Charge</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreightChargeLocation")]
        public LocationType FreightChargeLocation { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _detentionTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Detention_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The detention of a transport means during loading and unloading operations.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Detention</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DetentionTransportEvent")]
        public List<TransportEventType> DetentionTransportEvent
        {
            get
            {
                return _detentionTransportEvent;
            }
            set
            {
                _detentionTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DetentionTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DetentionTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DetentionTransportEventSpecified
        {
            get
            {
                return ((this.DetentionTransportEvent != null) 
                            && (this.DetentionTransportEvent.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Requested Departure_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The departure requested by the party requesting a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequestedDepartureTransportEvent")]
        public TransportEventType RequestedDepartureTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Requested Arrival_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The arrival requested by the party requesting a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Arrival</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequestedArrivalTransportEvent")]
        public TransportEventType RequestedArrivalTransportEvent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _requestedWaypointTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Requested Waypoint_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A waypoint requested by the party requesting a transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Waypoint</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequestedWaypointTransportEvent")]
        public List<TransportEventType> RequestedWaypointTransportEvent
        {
            get
            {
                return _requestedWaypointTransportEvent;
            }
            set
            {
                _requestedWaypointTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequestedWaypointTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequestedWaypointTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequestedWaypointTransportEventSpecified
        {
            get
            {
                return ((this.RequestedWaypointTransportEvent != null) 
                            && (this.RequestedWaypointTransportEvent.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Planned Departure_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The departure planned by the party providing a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlannedDepartureTransportEvent")]
        public TransportEventType PlannedDepartureTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Planned Arrival_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The arrival planned by the party providing a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned Arrival</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlannedArrivalTransportEvent")]
        public TransportEventType PlannedArrivalTransportEvent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _plannedWaypointTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Planned Waypoint_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A waypoint planned by the party providing a transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned Waypoint</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PlannedWaypointTransportEvent")]
        public List<TransportEventType> PlannedWaypointTransportEvent
        {
            get
            {
                return _plannedWaypointTransportEvent;
            }
            set
            {
                _plannedWaypointTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PlannedWaypointTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PlannedWaypointTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PlannedWaypointTransportEventSpecified
        {
            get
            {
                return ((this.PlannedWaypointTransportEvent != null) 
                            && (this.PlannedWaypointTransportEvent.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Actual Departure_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The actual departure from a specific location during a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualDepartureTransportEvent")]
        public TransportEventType ActualDepartureTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Actual Waypoint_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The location of an actual waypoint during a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual Waypoint</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualWaypointTransportEvent")]
        public TransportEventType ActualWaypointTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Actual Arrival_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The actual arrival at a specific location during a transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual Arrival</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualArrivalTransportEvent")]
        public TransportEventType ActualArrivalTransportEvent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _transportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A significant occurrence in the course of this shipment of goods.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Estimated Departure_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>Describes an estimated departure at a location during a transport service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedDepartureTransportEvent")]
        public TransportEventType EstimatedDepartureTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Estimated Arrival_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>Describes an estimated arrival at a location during a transport service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated Arrival</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedArrivalTransportEvent")]
        public TransportEventType EstimatedArrivalTransportEvent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PersonType> _passengerPerson;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Passenger_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>A person who travels in a conveyance without participating in its operation.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Passenger</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PassengerPerson")]
        public List<PersonType> PassengerPerson
        {
            get
            {
                return _passengerPerson;
            }
            set
            {
                _passengerPerson = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PassengerPerson-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PassengerPerson collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PassengerPersonSpecified
        {
            get
            {
                return ((this.PassengerPerson != null) 
                            && (this.PassengerPerson.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PersonType> _driverPerson;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Driver_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>Describes a person responsible for driving the transport means.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Driver</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DriverPerson")]
        public List<PersonType> DriverPerson
        {
            get
            {
                return _driverPerson;
            }
            set
            {
                _driverPerson = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DriverPerson-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DriverPerson collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DriverPersonSpecified
        {
            get
            {
                return ((this.DriverPerson != null) 
                            && (this.DriverPerson.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Reporting_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>Describes a person being responsible for providing the required administrative reporting relating to a transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Reporting</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReportingPerson")]
        public PersonType ReportingPerson { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PersonType> _crewMemberPerson;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Crew Member_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>A person operating or serving aboard a transport means.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Crew Member</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CrewMemberPerson")]
        public List<PersonType> CrewMemberPerson
        {
            get
            {
                return _crewMemberPerson;
            }
            set
            {
                _crewMemberPerson = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CrewMemberPerson-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CrewMemberPerson collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CrewMemberPersonSpecified
        {
            get
            {
                return ((this.CrewMemberPerson != null) 
                            && (this.CrewMemberPerson.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Security Officer_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>The person on board the vessel, accountable to the master, designated by the company as responsible for the security of the ship, including implementation and maintenance of the ship security plan and for the liaison with the company security officer and the port facility security officers.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Security Officer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SecurityOfficerPerson")]
        public PersonType SecurityOfficerPerson { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Master_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>The person responsible for the ship's safe and efficient operation, including cargo operations, navigation, crew management and for ensuring that the vessel complies with local and international laws, as well as company and flag state policies.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Master</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MasterPerson")]
        public PersonType MasterPerson { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Shipment Stage. Ships Surgeon_ Person. Person</ccts:DictionaryEntryName><ccts:Definition>The person responsible for the health of the people aboard a ship at sea.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Shipment Stage</ccts:ObjectClass><ccts:PropertyTermQualifier>Ships Surgeon</ccts:PropertyTermQualifier><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ShipsSurgeonPerson")]
        public PersonType ShipsSurgeonPerson { get; set; }
    }
}
