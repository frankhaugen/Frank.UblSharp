//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("DimensionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlIncludeAttribute(typeof(Dimension))]
    [XmlIncludeAttribute(typeof(FloorSpaceMeasurementDimension))]
    [XmlIncludeAttribute(typeof(MeasurementDimension))]
    [XmlIncludeAttribute(typeof(PalletSpaceMeasurementDimension))]
    [XmlIncludeAttribute(typeof(RangeDimension))]
    [XmlIncludeAttribute(typeof(TotalCapacityDimension))]
    public partial class DimensionType
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Attribute Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the attribute to which the measure applies.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTerm>Attribute Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Attribute Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the attribute to which the measure applies.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTerm>Attribute Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("AttributeID", Order=0, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AttributeIdType AttributeId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Measure</ccts:DictionaryEntryName><ccts:Definition>The measurement value.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTerm>Measure</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Measure</ccts:DictionaryEntryName><ccts:Definition>The measurement value.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTerm>Measure</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Measure", Order=1, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeasureType_2 Measure { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the measurement attribute.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the measurement attribute.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("Description", Order=2, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Minimum_ Measure. Measure</ccts:DictionaryEntryName><ccts:Definition>The minimum value in a range of measurement of this dimension.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Measure</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Minimum_ Measure. Measure</ccts:DictionaryEntryName><ccts:Definition>The minimum value in a range of measurement of this dimension.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Measure</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumMeasure", Order=3, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumMeasureType MinimumMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Maximum_ Measure. Measure</ccts:DictionaryEntryName><ccts:Definition>The maximum value in a range of measurement of this dimension.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Measure</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Dimension. Maximum_ Measure. Measure</ccts:DictionaryEntryName><ccts:Definition>The maximum value in a range of measurement of this dimension.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Dimension</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Measure</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumMeasure", Order=4, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumMeasureType MaximumMeasure { get; set; }
    }
}
