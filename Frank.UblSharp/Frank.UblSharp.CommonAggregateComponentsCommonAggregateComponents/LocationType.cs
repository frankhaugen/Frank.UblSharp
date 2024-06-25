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
    [XmlTypeAttribute("LocationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ActivityFinalLocation))]
    [XmlIncludeAttribute(typeof(ActivityOriginLocation))]
    [XmlIncludeAttribute(typeof(AlternativeDeliveryLocation))]
    [XmlIncludeAttribute(typeof(AtLocation))]
    [XmlIncludeAttribute(typeof(DeliveryLocation))]
    [XmlIncludeAttribute(typeof(DespatchLocation))]
    [XmlIncludeAttribute(typeof(FirstArrivalPortLocation))]
    [XmlIncludeAttribute(typeof(FreightChargeLocation))]
    [XmlIncludeAttribute(typeof(FromLocation))]
    [XmlIncludeAttribute(typeof(InventoryLocation))]
    [XmlIncludeAttribute(typeof(LastExitPortLocation))]
    [XmlIncludeAttribute(typeof(LoadingLocation))]
    [XmlIncludeAttribute(typeof(LoadingPortLocation))]
    [XmlIncludeAttribute(typeof(Location))]
    [XmlIncludeAttribute(typeof(MeasurementFromLocation))]
    [XmlIncludeAttribute(typeof(MeasurementToLocation))]
    [XmlIncludeAttribute(typeof(NotificationLocation))]
    [XmlIncludeAttribute(typeof(OccurenceLocation))]
    [XmlIncludeAttribute(typeof(ParticipatingLocationsLocation))]
    [XmlIncludeAttribute(typeof(PhysicalLocation))]
    [XmlIncludeAttribute(typeof(PickupLocation))]
    [XmlIncludeAttribute(typeof(RealizedLocation))]
    [XmlIncludeAttribute(typeof(RegistryPortLocation))]
    [XmlIncludeAttribute(typeof(RequestedStatusLocation))]
    [XmlIncludeAttribute(typeof(StatusLocation))]
    [XmlIncludeAttribute(typeof(StorageLocation))]
    [XmlIncludeAttribute(typeof(SubsidiaryLocation))]
    [XmlIncludeAttribute(typeof(ToLocation))]
    [XmlIncludeAttribute(typeof(TransshipPortLocation))]
    [XmlIncludeAttribute(typeof(UnloadingLocation))]
    [XmlIncludeAttribute(typeof(UnloadingPortLocation))]
    public partial class LocationType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this location, e.g., the EAN Location Number, GLN.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>5790002221134</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this location.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConditionsType> _conditions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Conditions. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text describing the physical conditions of the location.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Conditions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Conditions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConditionsType> Conditions
        {
            get
            {
                return _conditions;
            }
            set
            {
                _conditions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Conditions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Conditions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConditionsSpecified
        {
            get
            {
                return ((this.Conditions != null) 
                            && (this.Conditions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Country Subentity. Text</ccts:DictionaryEntryName><ccts:Definition>A territorial division of a country, such as a county or state, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Country Subentity</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>AdministrativeArea, State, Country, Shire, Canton</ccts:AlternativeBusinessTerms><ccts:Examples>Florida , Tamilnadu </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CountrySubentity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CountrySubentityType CountrySubentity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Country Subentity Code. Code</ccts:DictionaryEntryName><ccts:Definition>A territorial division of a country, such as a county or state, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Country Subentity Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>AdministrativeAreaCode, State Code</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CountrySubentityCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CountrySubentityCodeType CountrySubentityCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Location Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Location Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LocationTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LocationTypeCodeType LocationTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Information_ URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) of a document providing information about this location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTermQualifier>Information</ccts:PropertyTermQualifier><ccts:PropertyTerm>URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InformationURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InformationUriType InformationUri { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>winter 2005 collection </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PeriodType> _validityPeriod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>A period during which this location can be used (e.g., for delivery).</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTermQualifier>Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidityPeriod")]
        public List<PeriodType> ValidityPeriod
        {
            get
            {
                return _validityPeriod;
            }
            set
            {
                _validityPeriod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ValidityPeriod-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ValidityPeriod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValidityPeriodSpecified
        {
            get
            {
                return ((this.ValidityPeriod != null) 
                            && (this.ValidityPeriod.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Address</ccts:DictionaryEntryName><ccts:Definition>The address of this location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Address")]
        public AddressType Address { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<LocationType> _subsidiaryLocation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Subsidiary_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>A location subsidiary to this location.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTermQualifier>Subsidiary</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SubsidiaryLocation")]
        public List<LocationType> SubsidiaryLocation
        {
            get
            {
                return _subsidiaryLocation;
            }
            set
            {
                _subsidiaryLocation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SubsidiaryLocation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SubsidiaryLocation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubsidiaryLocationSpecified
        {
            get
            {
                return ((this.SubsidiaryLocation != null) 
                            && (this.SubsidiaryLocation.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<LocationCoordinateType> _locationCoordinate;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location. Location Coordinate</ccts:DictionaryEntryName><ccts:Definition>The geographical coordinates of this location.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Location</ccts:ObjectClass><ccts:PropertyTerm>Location Coordinate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location Coordinate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location Coordinate</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("LocationCoordinate")]
        public List<LocationCoordinateType> LocationCoordinate
        {
            get
            {
                return _locationCoordinate;
            }
            set
            {
                _locationCoordinate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LocationCoordinate-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the LocationCoordinate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LocationCoordinateSpecified
        {
            get
            {
                return ((this.LocationCoordinate != null) 
                            && (this.LocationCoordinate.Count != 0));
            }
        }
    }
}
