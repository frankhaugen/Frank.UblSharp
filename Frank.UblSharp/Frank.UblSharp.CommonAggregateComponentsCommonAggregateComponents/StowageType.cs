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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Stowage. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a location on board a means of transport where specified goods or transport equipment have been stowed or are to be stowed.</ccts:Definition><ccts:ObjectClass>Stowage</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("StowageType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("Stowage", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StowageType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Stowage. Location Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Stowage</ccts:ObjectClass><ccts:PropertyTerm>Location Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Cell Location, coded</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LocationID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LocationIdType LocationId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LocationType> _location;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Stowage. Location. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the location.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Stowage</ccts:ObjectClass><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Cell Location</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Location", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LocationType> Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Location-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Location collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LocationSpecified
        {
            get
            {
                return ((this.Location != null) 
                            && (this.Location.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DimensionType> _measurementDimension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Stowage. Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>A measurable dimension (length, mass, weight, or volume) of this stowage.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Stowage</ccts:ObjectClass><ccts:PropertyTermQualifier>Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
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
