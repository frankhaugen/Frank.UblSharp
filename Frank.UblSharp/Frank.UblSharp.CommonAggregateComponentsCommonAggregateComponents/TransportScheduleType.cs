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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Details</ccts:DictionaryEntryName><ccts:Definition>Describes the location and schedule relating to a transport means.</ccts:Definition><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TransportScheduleType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TransportSchedule", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportScheduleType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Sequence. Numeric</ccts:DictionaryEntryName><ccts:Definition>A number indicating the order of this status in the sequence in which statuses are to be presented.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTerm>Sequence</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SequenceNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SequenceNumericType SequenceNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Reference Date. Date</ccts:DictionaryEntryName><ccts:Definition>The reference date for the transport schedule status.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTerm>Reference Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReferenceDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReferenceDateType ReferenceDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Reference Time. Time</ccts:DictionaryEntryName><ccts:Definition>The reference time for the transport schedule status.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTerm>Reference Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReferenceTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReferenceTimeType ReferenceTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Reliability Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The reliability of the transport schedule status, expressed as a percentage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTerm>Reliability Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReliabilityPercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReliabilityPercentType ReliabilityPercent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RemarksType> _remarks;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Remarks. Text</ccts:DictionaryEntryName><ccts:Definition>Remarks related to the transport schedule status.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTerm>Remarks</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Status_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location for which status is reported.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTermQualifier>Status</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("StatusLocation")]
        public LocationType StatusLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Actual Arrival_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The actual arrival at a location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual Arrival</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualArrivalTransportEvent")]
        public TransportEventType ActualArrivalTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Actual Departure_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The actual departure from a location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualDepartureTransportEvent")]
        public TransportEventType ActualDepartureTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Estimated Departure_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>An estimated departure from a specified location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedDepartureTransportEvent")]
        public TransportEventType EstimatedDepartureTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Estimated Arrival_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>An estimated arrival at a specified location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated Arrival</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedArrivalTransportEvent")]
        public TransportEventType EstimatedArrivalTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Planned Departure_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The planned departure from a specified location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned Departure</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlannedDepartureTransportEvent")]
        public TransportEventType PlannedDepartureTransportEvent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Schedule. Planned Arrival_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>The planned arrival at a specified location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Schedule</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned Arrival</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlannedArrivalTransportEvent")]
        public TransportEventType PlannedArrivalTransportEvent { get; set; }
    }
}