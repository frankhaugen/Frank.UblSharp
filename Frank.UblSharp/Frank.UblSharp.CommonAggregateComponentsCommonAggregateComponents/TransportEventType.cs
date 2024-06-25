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
    [XmlTypeAttribute("TransportEventType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AcceptanceTransportEvent))]
    [XmlIncludeAttribute(typeof(ActualArrivalTransportEvent))]
    [XmlIncludeAttribute(typeof(ActualDepartureTransportEvent))]
    [XmlIncludeAttribute(typeof(ActualPickupTransportEvent))]
    [XmlIncludeAttribute(typeof(ActualWaypointTransportEvent))]
    [XmlIncludeAttribute(typeof(AvailabilityTransportEvent))]
    [XmlIncludeAttribute(typeof(DeliveryTransportEvent))]
    [XmlIncludeAttribute(typeof(DetentionTransportEvent))]
    [XmlIncludeAttribute(typeof(DischargeTransportEvent))]
    [XmlIncludeAttribute(typeof(DropoffTransportEvent))]
    [XmlIncludeAttribute(typeof(EstimatedArrivalTransportEvent))]
    [XmlIncludeAttribute(typeof(EstimatedDepartureTransportEvent))]
    [XmlIncludeAttribute(typeof(ExaminationTransportEvent))]
    [XmlIncludeAttribute(typeof(ExportationTransportEvent))]
    [XmlIncludeAttribute(typeof(HandlingTransportEvent))]
    [XmlIncludeAttribute(typeof(LoadingTransportEvent))]
    [XmlIncludeAttribute(typeof(OptionalTakeoverTransportEvent))]
    [XmlIncludeAttribute(typeof(PickupTransportEvent))]
    [XmlIncludeAttribute(typeof(PlannedArrivalTransportEvent))]
    [XmlIncludeAttribute(typeof(PlannedDeliveryTransportEvent))]
    [XmlIncludeAttribute(typeof(PlannedDepartureTransportEvent))]
    [XmlIncludeAttribute(typeof(PlannedPickupTransportEvent))]
    [XmlIncludeAttribute(typeof(PlannedWaypointTransportEvent))]
    [XmlIncludeAttribute(typeof(PositioningTransportEvent))]
    [XmlIncludeAttribute(typeof(QuarantineTransportEvent))]
    [XmlIncludeAttribute(typeof(ReceiptTransportEvent))]
    [XmlIncludeAttribute(typeof(RequestedArrivalTransportEvent))]
    [XmlIncludeAttribute(typeof(RequestedDeliveryTransportEvent))]
    [XmlIncludeAttribute(typeof(RequestedDepartureTransportEvent))]
    [XmlIncludeAttribute(typeof(RequestedPickupTransportEvent))]
    [XmlIncludeAttribute(typeof(RequestedWaypointTransportEvent))]
    [XmlIncludeAttribute(typeof(StorageTransportEvent))]
    [XmlIncludeAttribute(typeof(TakeoverTransportEvent))]
    [XmlIncludeAttribute(typeof(TransportEvent))]
    [XmlIncludeAttribute(typeof(UpdatedDeliveryTransportEvent))]
    [XmlIncludeAttribute(typeof(UpdatedPickupTransportEvent))]
    [XmlIncludeAttribute(typeof(WarehousingTransportEvent))]
    public partial class TransportEventType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Identification. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this transport event within an agreed event identification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Identification</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IdentificationID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdentificationIdType IdentificationId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Occurrence Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date of this transport event.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Occurrence Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OccurrenceDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OccurrenceDateType OccurrenceDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Occurrence Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time of this transport event.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Occurrence Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OccurrenceTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OccurrenceTimeType OccurrenceTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Transport Event Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this transport event.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Transport Event Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportEventTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportEventTypeCodeType TransportEventTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this transport event.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Completion_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this transport event has been completed (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTermQualifier>Completion</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompletionIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompletionIndicatorType CompletionIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Reported_ Shipment. Shipment</ccts:DictionaryEntryName><ccts:Definition>The shipment involved in this transport event.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTermQualifier>Reported</ccts:PropertyTermQualifier><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReportedShipment")]
        public ShipmentType ReportedShipment { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<StatusType> _currentStatus;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Current_ Status. Status</ccts:DictionaryEntryName><ccts:Definition>The current status of this transport event.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTermQualifier>Current</ccts:PropertyTermQualifier><ccts:PropertyTerm>Status</ccts:PropertyTerm><ccts:AssociatedObjectClass>Status</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Status</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CurrentStatus")]
        public List<StatusType> CurrentStatus
        {
            get
            {
                return _currentStatus;
            }
            set
            {
                _currentStatus = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CurrentStatus-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CurrentStatus collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CurrentStatusSpecified
        {
            get
            {
                return ((this.CurrentStatus != null) 
                            && (this.CurrentStatus.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ContactType> _contact;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Contact</ccts:DictionaryEntryName><ccts:Definition>A contact associated with this transport event.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Contact</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contact</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contact</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Contact")]
        public List<ContactType> Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Contact-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Contact collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContactSpecified
        {
            get
            {
                return ((this.Contact != null) 
                            && (this.Contact.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Location</ccts:DictionaryEntryName><ccts:Definition>The location associated with this transport event.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Location")]
        public LocationType Location { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Signature</ccts:DictionaryEntryName><ccts:Definition>A signature that can be used to sign for an entry or an exit at a transport location (e.g., port terminal).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Signature")]
        public SignatureType Signature { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PeriodType> _period;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Event. Period</ccts:DictionaryEntryName><ccts:Definition>A period of time associated with this transport event.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Event</ccts:ObjectClass><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Period")]
        public List<PeriodType> Period
        {
            get
            {
                return _period;
            }
            set
            {
                _period = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Period-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Period collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PeriodSpecified
        {
            get
            {
                return ((this.Period != null) 
                            && (this.Period.Count != 0));
            }
        }
    }
}
