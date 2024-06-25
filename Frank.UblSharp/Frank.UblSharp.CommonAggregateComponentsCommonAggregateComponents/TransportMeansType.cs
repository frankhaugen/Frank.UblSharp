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
    [XmlTypeAttribute("TransportMeansType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ApplicableTransportMeans))]
    [XmlIncludeAttribute(typeof(TransportMeans))]
    public partial class TransportMeansType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Journey Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the regular service schedule of this means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Journey Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Voyage Number, Scheduled Conveyance Identifier (WCO ID 205), Flight Number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("JourneyID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.JourneyIdType JourneyId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Registration_ Nationality Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the country in which this means of transport is registered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Nationality Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Nationality of Means of Transport (WCO 175, 178 and 179)</ccts:AlternativeBusinessTerms><ccts:Examples>LIB </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RegistrationNationalityID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegistrationNationalityIdType RegistrationNationalityId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegistrationNationalityType> _registrationNationality;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Registration_ Nationality. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the country in which this means of transport is registered.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Nationality</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Flag of Vessel, Nationality of Ship</ccts:AlternativeBusinessTerms><ccts:Examples>Liberia</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RegistrationNationality", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegistrationNationalityType> RegistrationNationality
        {
            get
            {
                return _registrationNationality;
            }
            set
            {
                _registrationNationality = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RegistrationNationality-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RegistrationNationality collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RegistrationNationalitySpecified
        {
            get
            {
                return ((this.RegistrationNationality != null) 
                            && (this.RegistrationNationality.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Direction Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the direction of this means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Direction Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Transit Direction</ccts:AlternativeBusinessTerms><ccts:Examples>North , East </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DirectionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DirectionCodeType DirectionCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Transport Means Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this means of transport (truck, vessel, etc.).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Transport Means Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportMeansTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportMeansTypeCodeType TransportMeansTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Trade Service Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the service regularly provided by the carrier operating this means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Trade Service Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TradeServiceCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TradeServiceCodeType TradeServiceCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Stowage</ccts:DictionaryEntryName><ccts:Definition>The location within the means of transport where goods are to be or have been stowed.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Stowage</ccts:PropertyTerm><ccts:AssociatedObjectClass>Stowage</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Stowage</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Stowage")]
        public StowageType Stowage { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Air Transport</ccts:DictionaryEntryName><ccts:Definition>An aircraft used for transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Air Transport</ccts:PropertyTerm><ccts:AssociatedObjectClass>Air Transport</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Air Transport</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AirTransport")]
        public AirTransportType AirTransport { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Road Transport</ccts:DictionaryEntryName><ccts:Definition>A vehicle used for road transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Road Transport</ccts:PropertyTerm><ccts:AssociatedObjectClass>Road Transport</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Road Transport</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RoadTransport")]
        public RoadTransportType RoadTransport { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Rail Transport</ccts:DictionaryEntryName><ccts:Definition>Equipment used for rail transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Rail Transport</ccts:PropertyTerm><ccts:AssociatedObjectClass>Rail Transport</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Rail Transport</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RailTransport")]
        public RailTransportType RailTransport { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Maritime Transport</ccts:DictionaryEntryName><ccts:Definition>A vessel used for transport by water (not only by sea).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTerm>Maritime Transport</ccts:PropertyTerm><ccts:AssociatedObjectClass>Maritime Transport</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Maritime Transport</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaritimeTransport")]
        public MaritimeTransportType MaritimeTransport { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Owner_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that owns this means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTermQualifier>Owner</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OwnerParty")]
        public PartyType OwnerParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DimensionType> _measurementDimension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Means. Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>A measurable dimension (length, mass, weight, or volume) of this means of transport.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Means</ccts:ObjectClass><ccts:PropertyTermQualifier>Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
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
    }
}
