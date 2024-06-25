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
    [XmlTypeAttribute("TransportationServiceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AdditionalTransportationService))]
    [XmlIncludeAttribute(typeof(FinalDeliveryTransportationService))]
    [XmlIncludeAttribute(typeof(MainTransportationService))]
    [XmlIncludeAttribute(typeof(OriginalDespatchTransportationService))]
    [XmlIncludeAttribute(typeof(TransportationService))]
    public partial class TransportationServiceType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Transport Service Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the extent of this transportation service (e.g., door-to-door, port-to-port).</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Transport Service Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("TransportServiceCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportServiceCodeType TransportServiceCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Tariff Class Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the tariff class applicable to this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Tariff Class Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Tariff Class Specifier</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TariffClassCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TariffClassCodeType TariffClassCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Priority. Text</ccts:DictionaryEntryName><ccts:Definition>The priority of this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Priority</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Priority", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriorityType Priority { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Freight Rate Class Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the rate class for freight in this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Freight Rate Class Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Charge Basis</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreightRateClassCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FreightRateClassCodeType FreightRateClassCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportationServiceDescriptionType> _transportationServiceDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Transportation Service Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Transportation Service Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportationServiceDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportationServiceDescriptionType> TransportationServiceDescription
        {
            get
            {
                return _transportationServiceDescription;
            }
            set
            {
                _transportationServiceDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportationServiceDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportationServiceDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportationServiceDescriptionSpecified
        {
            get
            {
                return ((this.TransportationServiceDescription != null) 
                            && (this.TransportationServiceDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Transportation Service Details URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) of a document providing additional details regarding this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Transportation Service Details URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportationServiceDetailsURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportationServiceDetailsUriType TransportationServiceDetailsUri { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Nomination Date. Date</ccts:DictionaryEntryName><ccts:Definition>In a transport contract, the deadline date by which this transportation service has to be booked. For example, if this service is scheduled for Wednesday 16 February 2011 at 10 a.m. CET, the nomination date might be Tuesday15 February 2011.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Nomination Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NominationDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NominationDateType NominationDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Nomination Time. Time</ccts:DictionaryEntryName><ccts:Definition>In a transport contract, the deadline time by which this transportation service has to be booked. For example, if this service is scheduled for Wednesday 16 February 2011 at 10 a.m. CET, the nomination date might be Tuesday15 February 2011 and the nomination time 4 p.m. at the latest.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Nomination Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NominationTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NominationTimeType NominationTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Sequence. Numeric</ccts:DictionaryEntryName><ccts:Definition>A number indicating the order of this transportation service in a sequence of transportation services.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Sequence</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SequenceNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SequenceNumericType SequenceNumeric { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentType> _transportEquipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>A piece of transport equipment used in this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportEquipment")]
        public List<TransportEquipmentType> TransportEquipment
        {
            get
            {
                return _transportEquipment;
            }
            set
            {
                _transportEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportEquipmentSpecified
        {
            get
            {
                return ((this.TransportEquipment != null) 
                            && (this.TransportEquipment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentType> _supportedTransportEquipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Supported_ Transport Equipment. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>A piece of transport equipment supported in this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Supported</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SupportedTransportEquipment")]
        public List<TransportEquipmentType> SupportedTransportEquipment
        {
            get
            {
                return _supportedTransportEquipment;
            }
            set
            {
                _supportedTransportEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SupportedTransportEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SupportedTransportEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SupportedTransportEquipmentSpecified
        {
            get
            {
                return ((this.SupportedTransportEquipment != null) 
                            && (this.SupportedTransportEquipment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentType> _unsupportedTransportEquipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Unsupported_ Transport Equipment. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>A piece of transport equipment that is not supported in this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Unsupported</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UnsupportedTransportEquipment")]
        public List<TransportEquipmentType> UnsupportedTransportEquipment
        {
            get
            {
                return _unsupportedTransportEquipment;
            }
            set
            {
                _unsupportedTransportEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die UnsupportedTransportEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the UnsupportedTransportEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool UnsupportedTransportEquipmentSpecified
        {
            get
            {
                return ((this.UnsupportedTransportEquipment != null) 
                            && (this.UnsupportedTransportEquipment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CommodityClassificationType> _commodityClassification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Commodity Classification</ccts:DictionaryEntryName><ccts:Definition>A classification of this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Commodity Classification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Commodity Classification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Commodity Classification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CommodityClassification")]
        public List<CommodityClassificationType> CommodityClassification
        {
            get
            {
                return _commodityClassification;
            }
            set
            {
                _commodityClassification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CommodityClassification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CommodityClassification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CommodityClassificationSpecified
        {
            get
            {
                return ((this.CommodityClassification != null) 
                            && (this.CommodityClassification.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CommodityClassificationType> _supportedCommodityClassification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Supported_ Commodity Classification. Commodity Classification</ccts:DictionaryEntryName><ccts:Definition>A classification (e.g., general cargo) for commodities that can be handled in this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Supported</ccts:PropertyTermQualifier><ccts:PropertyTerm>Commodity Classification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Commodity Classification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Commodity Classification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SupportedCommodityClassification")]
        public List<CommodityClassificationType> SupportedCommodityClassification
        {
            get
            {
                return _supportedCommodityClassification;
            }
            set
            {
                _supportedCommodityClassification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SupportedCommodityClassification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SupportedCommodityClassification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SupportedCommodityClassificationSpecified
        {
            get
            {
                return ((this.SupportedCommodityClassification != null) 
                            && (this.SupportedCommodityClassification.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CommodityClassificationType> _unsupportedCommodityClassification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Unsupported_ Commodity Classification. Commodity Classification</ccts:DictionaryEntryName><ccts:Definition>A classification for commodities that cannot be handled in this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Unsupported</ccts:PropertyTermQualifier><ccts:PropertyTerm>Commodity Classification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Commodity Classification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Commodity Classification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UnsupportedCommodityClassification")]
        public List<CommodityClassificationType> UnsupportedCommodityClassification
        {
            get
            {
                return _unsupportedCommodityClassification;
            }
            set
            {
                _unsupportedCommodityClassification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die UnsupportedCommodityClassification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the UnsupportedCommodityClassification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool UnsupportedCommodityClassificationSpecified
        {
            get
            {
                return ((this.UnsupportedCommodityClassification != null) 
                            && (this.UnsupportedCommodityClassification.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Total Capacity_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>The total capacity or volume available in this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Total Capacity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalCapacityDimension")]
        public DimensionType TotalCapacityDimension { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentStageType> _shipmentStage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Shipment Stage</ccts:DictionaryEntryName><ccts:Definition>One of the stages of shipment in this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Shipment Stage</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment Stage</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment Stage</ccts:RepresentationTerm></ccts:Component></para>
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
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _transportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Transport Event</ccts:DictionaryEntryName><ccts:Definition>One of the transport events taking place in this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Responsible Transport Service Provider_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The transport service provider responsible for this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Responsible Transport Service Provider</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ResponsibleTransportServiceProviderParty")]
        public PartyType ResponsibleTransportServiceProviderParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EnvironmentalEmissionType> _environmentalEmission;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Environmental Emission</ccts:DictionaryEntryName><ccts:Definition>An environmental emission resulting from this transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTerm>Environmental Emission</ccts:PropertyTerm><ccts:AssociatedObjectClass>Environmental Emission</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Environmental Emission</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EnvironmentalEmission")]
        public List<EnvironmentalEmissionType> EnvironmentalEmission
        {
            get
            {
                return _environmentalEmission;
            }
            set
            {
                _environmentalEmission = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EnvironmentalEmission-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EnvironmentalEmission collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EnvironmentalEmissionSpecified
        {
            get
            {
                return ((this.EnvironmentalEmission != null) 
                            && (this.EnvironmentalEmission.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Estimated Duration_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The estimated duration of this transportation service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated Duration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedDurationPeriod")]
        public PeriodType EstimatedDurationPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ServiceFrequencyType> _scheduledServiceFrequency;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Service. Scheduled_ Service Frequency. Service Frequency</ccts:DictionaryEntryName><ccts:Definition>A class to specify which day of the week a transport service is operational.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Service</ccts:ObjectClass><ccts:PropertyTermQualifier>Scheduled</ccts:PropertyTermQualifier><ccts:PropertyTerm>Service Frequency</ccts:PropertyTerm><ccts:AssociatedObjectClass>Service Frequency</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Service Frequency</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ScheduledServiceFrequency")]
        public List<ServiceFrequencyType> ScheduledServiceFrequency
        {
            get
            {
                return _scheduledServiceFrequency;
            }
            set
            {
                _scheduledServiceFrequency = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ScheduledServiceFrequency-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ScheduledServiceFrequency collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ScheduledServiceFrequencySpecified
        {
            get
            {
                return ((this.ScheduledServiceFrequency != null) 
                            && (this.ScheduledServiceFrequency.Count != 0));
            }
        }
    }
}
