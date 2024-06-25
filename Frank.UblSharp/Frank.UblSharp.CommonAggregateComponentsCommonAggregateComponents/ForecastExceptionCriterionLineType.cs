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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Forecast Exception Criterion Line. Details</ccts:DictionaryEntryName><ccts:Definition>Establishes the criterion for one of the three types of exceptions. This class provides criteria for the kind of forecast exception, the identification of the purpose of the forecast, the source of data and the time basis criterion for the exception.</ccts:Definition><ccts:ObjectClass>Forecast Exception Criterion Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("ForecastExceptionCriterionLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ForecastExceptionCriterionLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ForecastExceptionCriterionLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Forecast Exception Criterion Line. Forecast_ Purpose Code. Code</ccts:DictionaryEntryName><ccts:Definition>A description of the purpose for the forecast that is assigned to each forecast data item exception criterion.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Forecast Exception Criterion Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Forecast</ccts:PropertyTermQualifier><ccts:PropertyTerm>Purpose Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ForecastPurposeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForecastPurposeCodeType ForecastPurposeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Forecast Exception Criterion Line. Forecast Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A description of a Forecast selected from a list.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Forecast Exception Criterion Line</ccts:ObjectClass><ccts:PropertyTerm>Forecast Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ForecastTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForecastTypeCodeType ForecastTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Forecast Exception Criterion Line. Comparison Data Source Code. Code</ccts:DictionaryEntryName><ccts:Definition>If it is a forecast comparison exception, this value indicates the other source of information.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Forecast Exception Criterion Line</ccts:ObjectClass><ccts:PropertyTerm>Comparison Data Source Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ComparisonDataSourceCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ComparisonDataSourceCodeType ComparisonDataSourceCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Forecast Exception Criterion Line. Data Source Code. Code</ccts:DictionaryEntryName><ccts:Definition>Indication of the partner who provides the information.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Forecast Exception Criterion Line</ccts:ObjectClass><ccts:PropertyTerm>Data Source Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("DataSourceCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DataSourceCodeType DataSourceCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Forecast Exception Criterion Line. Time Delta Days Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>Time basis in days for the Exception.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Forecast Exception Criterion Line</ccts:ObjectClass><ccts:PropertyTerm>Time Delta Days Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TimeDeltaDaysQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TimeDeltaDaysQuantityType TimeDeltaDaysQuantity { get; set; }
    }
}
