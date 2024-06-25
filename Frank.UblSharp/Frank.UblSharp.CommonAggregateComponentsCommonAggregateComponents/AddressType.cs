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
    [XmlTypeAttribute("AddressType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(Address))]
    [XmlIncludeAttribute(typeof(ApplicableAddress))]
    [XmlIncludeAttribute(typeof(ApplicableTerritoryAddress))]
    [XmlIncludeAttribute(typeof(DeliveryAddress))]
    [XmlIncludeAttribute(typeof(DespatchAddress))]
    [XmlIncludeAttribute(typeof(JurisdictionRegionAddress))]
    [XmlIncludeAttribute(typeof(LocationAddress))]
    [XmlIncludeAttribute(typeof(OriginAddress))]
    [XmlIncludeAttribute(typeof(PostalAddress))]
    [XmlIncludeAttribute(typeof(RegistrationAddress))]
    [XmlIncludeAttribute(typeof(ResidenceAddress))]
    [XmlIncludeAttribute(typeof(ReturnAddress))]
    public partial class AddressType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this address within an agreed scheme of address identifiers.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>DetailsKey</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Address Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A mutually agreed code signifying the type of this address.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Address Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AddressTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AddressTypeCodeType AddressTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Address Format Code. Code</ccts:DictionaryEntryName><ccts:Definition>A mutually agreed code signifying the format of this address.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Address Format Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AddressFormatCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AddressFormatCodeType AddressFormatCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Postbox. Text</ccts:DictionaryEntryName><ccts:Definition>A post office box number registered for postal delivery by a postal service provider.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Postbox</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>PostBox, PO Box</ccts:AlternativeBusinessTerms><ccts:Examples>123 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Postbox", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PostboxType Postbox { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Floor. Text</ccts:DictionaryEntryName><ccts:Definition>An identifiable floor of a building.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Floor</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>SubPremiseNumber</ccts:AlternativeBusinessTerms><ccts:Examples>30 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Floor", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FloorType Floor { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Room. Text</ccts:DictionaryEntryName><ccts:Definition>An identifiable room, suite, or apartment of a building.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Room</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>SubPremiseNumber</ccts:AlternativeBusinessTerms><ccts:Examples>Reception </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Room", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RoomType Room { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Street Name. Name</ccts:DictionaryEntryName><ccts:Definition>The name of the street, road, avenue, way, etc. to which the number of the building is attached.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Street Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Thoroughfare</ccts:AlternativeBusinessTerms><ccts:Examples>Kwun Tong Road </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StreetName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.StreetNameType StreetName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Additional_ Street Name. Name</ccts:DictionaryEntryName><ccts:Definition>An additional street name used to further clarify the address.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Street Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Thoroughfare</ccts:AlternativeBusinessTerms><ccts:Examples>Cnr Aberdeen Road </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AdditionalStreetName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalStreetNameType AdditionalStreetName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Block Name. Name</ccts:DictionaryEntryName><ccts:Definition>The name of the block (an area surrounded by streets and usually containing several buildings) in which this address is located.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Block Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>Seabird</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BlockName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BlockNameType BlockName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Building Name. Name</ccts:DictionaryEntryName><ccts:Definition>The name of a building.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Building Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:AlternativeBusinessTerms>BuildingName</ccts:AlternativeBusinessTerms><ccts:Examples>Plot 421 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BuildingName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BuildingNameType BuildingName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Building Number. Text</ccts:DictionaryEntryName><ccts:Definition>The number of a building within the street.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Building Number</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>PremiseNumber</ccts:AlternativeBusinessTerms><ccts:Examples>388 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BuildingNumber", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BuildingNumberType BuildingNumber { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Inhouse_ Mail. Text</ccts:DictionaryEntryName><ccts:Definition>The specific identifable location within a building where mail is delivered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTermQualifier>Inhouse</ccts:PropertyTermQualifier><ccts:PropertyTerm>Mail</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>MailStop</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InhouseMail", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InhouseMailType InhouseMail { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Department. Text</ccts:DictionaryEntryName><ccts:Definition>The department of the addressee.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Department</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Department</ccts:AlternativeBusinessTerms><ccts:Examples>Accounts Payable </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Department", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DepartmentType Department { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Mark Attention. Text</ccts:DictionaryEntryName><ccts:Definition>The name, expressed as text, of a person or department in an organization to whose attention incoming mail is directed; corresponds to the printed forms "for the attention of", "FAO", and ATTN:".</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Mark Attention</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MarkAttention", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MarkAttentionType MarkAttention { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Mark Care. Text</ccts:DictionaryEntryName><ccts:Definition>The name, expressed as text, of a person or organization at this address into whose care incoming mail is entrusted; corresponds to the printed forms "care of" and "c/o".</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Mark Care</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MarkCare", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MarkCareType MarkCare { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Plot Identification. Text</ccts:DictionaryEntryName><ccts:Definition>An identifier (e.g., a parcel number) for the piece of land associated with this address.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Plot Identification</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlotIdentification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PlotIdentificationType PlotIdentification { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. City Subdivision Name. Name</ccts:DictionaryEntryName><ccts:Definition>The name of the subdivision of a city, town, or village in which this address is located, such as the name of its district or borough.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>City Subdivision Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CitySubdivisionName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CitySubdivisionNameType CitySubdivisionName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. City Name. Name</ccts:DictionaryEntryName><ccts:Definition>The name of a city, town, or village.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>City Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:AlternativeBusinessTerms>LocalityName</ccts:AlternativeBusinessTerms><ccts:Examples>Hong Kong </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CityName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CityNameType CityName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Postal_ Zone. Text</ccts:DictionaryEntryName><ccts:Definition>The postal identifier for this address according to the relevant national postal service, such as a ZIP code or Post Code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTermQualifier>Postal</ccts:PropertyTermQualifier><ccts:PropertyTerm>Zone</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>PostalCodeNumber</ccts:AlternativeBusinessTerms><ccts:Examples>SW11 4EW 2500 GG </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PostalZone", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PostalZoneType PostalZone { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Country Subentity. Text</ccts:DictionaryEntryName><ccts:Definition>The political or administrative division of a country in which this address is located, such as the name of its county, province, or state, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Country Subentity</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>AdministrativeArea, State, Country, Shire, Canton</ccts:AlternativeBusinessTerms><ccts:Examples>Florida , Tamilnadu </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CountrySubentity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CountrySubentityType CountrySubentity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Country Subentity Code. Code</ccts:DictionaryEntryName><ccts:Definition>The political or administrative division of a country in which this address is located, such as a county, province, or state, expressed as a code (typically nationally agreed).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Country Subentity Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>AdministrativeAreaCode, State Code</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CountrySubentityCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CountrySubentityCodeType CountrySubentityCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Region. Text</ccts:DictionaryEntryName><ccts:Definition>The recognized geographic or economic region or group of countries in which this address is located.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Region</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>LocalityName, Economic Zone</ccts:AlternativeBusinessTerms><ccts:Examples>European Union </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Region", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegionType Region { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. District. Text</ccts:DictionaryEntryName><ccts:Definition>The district or geographical division of a country or region in which this address is located.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>District</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>LocalityName, Area</ccts:AlternativeBusinessTerms><ccts:Examples>East Coast </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("District", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DistrictType District { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Timezone Offset. Text</ccts:DictionaryEntryName><ccts:Definition>The time zone in which this address is located (as an offset from Universal Coordinated Time (UTC)) at the time of exchange.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Timezone Offset</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>+8:00 -3:00 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TimezoneOffset", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TimezoneOffsetType TimezoneOffset { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AddressLineType> _addressLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Address Line</ccts:DictionaryEntryName><ccts:Definition>An unstructured address line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Address Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AddressLine")]
        public List<AddressLineType> AddressLine
        {
            get
            {
                return _addressLine;
            }
            set
            {
                _addressLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AddressLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AddressLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AddressLineSpecified
        {
            get
            {
                return ((this.AddressLine != null) 
                            && (this.AddressLine.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Country</ccts:DictionaryEntryName><ccts:Definition>The country in which this address is situated.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Country</ccts:PropertyTerm><ccts:AssociatedObjectClass>Country</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Country</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Country")]
        public CountryType Country { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<LocationCoordinateType> _locationCoordinate;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Address. Location Coordinate</ccts:DictionaryEntryName><ccts:Definition>The geographical coordinates of this address.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Address</ccts:ObjectClass><ccts:PropertyTerm>Location Coordinate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location Coordinate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location Coordinate</ccts:RepresentationTerm></ccts:Component></para>
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
