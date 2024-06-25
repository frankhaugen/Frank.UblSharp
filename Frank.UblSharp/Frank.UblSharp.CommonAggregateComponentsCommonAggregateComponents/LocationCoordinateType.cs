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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Details</ccts:DictionaryEntryName><ccts:Definition>A class for defining a set of geographical coordinates (apparently misnamed).</ccts:Definition><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("LocationCoordinateType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("LocationCoordinate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LocationCoordinateType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Coordinate System Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the location system used.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTerm>Coordinate System Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CoordinateSystemCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CoordinateSystemCodeType CoordinateSystemCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Latitude_ Degrees. Measure</ccts:DictionaryEntryName><ccts:Definition>The degree component of a latitude measured in degrees and minutes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTermQualifier>Latitude</ccts:PropertyTermQualifier><ccts:PropertyTerm>Degrees</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatitudeDegreesMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatitudeDegreesMeasureType LatitudeDegreesMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Latitude_ Minutes. Measure</ccts:DictionaryEntryName><ccts:Definition>The minutes component of a latitude measured in degrees and minutes (modulo 60).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTermQualifier>Latitude</ccts:PropertyTermQualifier><ccts:PropertyTerm>Minutes</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatitudeMinutesMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatitudeMinutesMeasureType LatitudeMinutesMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Latitude Direction Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the direction of latitude measurement from the equator (north or south).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTerm>Latitude Direction Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Latitude Direction</ccts:DataTypeQualifier><ccts:DataType>Latitude Direction_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatitudeDirectionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatitudeDirectionCodeType LatitudeDirectionCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Longitude_ Degrees. Measure</ccts:DictionaryEntryName><ccts:Definition>The degree component of a longitude measured in degrees and minutes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTermQualifier>Longitude</ccts:PropertyTermQualifier><ccts:PropertyTerm>Degrees</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LongitudeDegreesMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LongitudeDegreesMeasureType LongitudeDegreesMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Longitude_ Minutes. Measure</ccts:DictionaryEntryName><ccts:Definition>The minutes component of a longitude measured in degrees and minutes (modulo 60).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTermQualifier>Longitude</ccts:PropertyTermQualifier><ccts:PropertyTerm>Minutes</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LongitudeMinutesMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LongitudeMinutesMeasureType LongitudeMinutesMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Longitude Direction Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the direction of longitude measurement from the prime meridian (east or west).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTerm>Longitude Direction Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Longitude Direction</ccts:DataTypeQualifier><ccts:DataType>Longitude Direction_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LongitudeDirectionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LongitudeDirectionCodeType LongitudeDirectionCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Location Coordinate. Altitude. Measure</ccts:DictionaryEntryName><ccts:Definition>The altitude of the location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Location Coordinate</ccts:ObjectClass><ccts:PropertyTerm>Altitude</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AltitudeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AltitudeMeasureType AltitudeMeasure { get; set; }
    }
}