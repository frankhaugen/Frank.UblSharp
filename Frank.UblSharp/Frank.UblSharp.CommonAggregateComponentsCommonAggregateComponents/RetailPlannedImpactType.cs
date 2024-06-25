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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Retail Planned Impact. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a planned effect of a retail event (e.g., a promotion or a change in inventory policy) upon supply or demand.</ccts:Definition><ccts:ObjectClass>Retail Planned Impact</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("RetailPlannedImpactType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("RetailPlannedImpact", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RetailPlannedImpactType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Retail Planned Impact. Amount</ccts:DictionaryEntryName><ccts:Definition>Estimated monetary value of the planned event as an impact</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Retail Planned Impact</ccts:ObjectClass><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Amount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AmountType Amount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Retail Planned Impact. Forecast_ Purpose Code. Code</ccts:DictionaryEntryName><ccts:Definition>It will have impact on either Sales forecast or Order Forecast</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Retail Planned Impact</ccts:ObjectClass><ccts:PropertyTermQualifier>Forecast</ccts:PropertyTermQualifier><ccts:PropertyTerm>Purpose Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ForecastPurposeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForecastPurposeCodeType ForecastPurposeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Retail Planned Impact. Forecast Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of forecast. Examples of values are: BASE PROMOTIONAL SEASONAL TOTAL</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Retail Planned Impact</ccts:ObjectClass><ccts:PropertyTerm>Forecast Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ForecastTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForecastTypeCodeType ForecastTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Retail Planned Impact. Period</ccts:DictionaryEntryName><ccts:Definition>The period to which this impact applies.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Retail Planned Impact</ccts:ObjectClass><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Period")]
        public PeriodType Period { get; set; }
    }
}