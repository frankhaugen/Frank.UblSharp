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
    [XmlTypeAttribute("ExchangeRateType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ExchangeRate))]
    [XmlIncludeAttribute(typeof(PaymentAlternativeExchangeRate))]
    [XmlIncludeAttribute(typeof(PaymentExchangeRate))]
    [XmlIncludeAttribute(typeof(PricingExchangeRate))]
    [XmlIncludeAttribute(typeof(TaxExchangeRate))]
    public partial class ExchangeRateType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Source_ Currency Code. Code</ccts:DictionaryEntryName><ccts:Definition>The reference currency for this exchange rate; the currency from which the exchange is being made.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTermQualifier>Source</ccts:PropertyTermQualifier><ccts:PropertyTerm>Currency Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Currency</ccts:DataTypeQualifier><ccts:DataType>Currency_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SourceCurrencyCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SourceCurrencyCodeType SourceCurrencyCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Source_ Currency Base Rate. Rate</ccts:DictionaryEntryName><ccts:Definition>In the case of a source currency with denominations of small value, the unit base.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTermQualifier>Source</ccts:PropertyTermQualifier><ccts:PropertyTerm>Currency Base Rate</ccts:PropertyTerm><ccts:RepresentationTerm>Rate</ccts:RepresentationTerm><ccts:DataType>Rate. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SourceCurrencyBaseRate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SourceCurrencyBaseRateType SourceCurrencyBaseRate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Target_ Currency Code. Code</ccts:DictionaryEntryName><ccts:Definition>The target currency for this exchange rate; the currency to which the exchange is being made.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTermQualifier>Target</ccts:PropertyTermQualifier><ccts:PropertyTerm>Currency Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Currency</ccts:DataTypeQualifier><ccts:DataType>Currency_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("TargetCurrencyCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TargetCurrencyCodeType TargetCurrencyCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Target_ Currency Base Rate. Rate</ccts:DictionaryEntryName><ccts:Definition>In the case of a target currency with denominations of small value, the unit base.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTermQualifier>Target</ccts:PropertyTermQualifier><ccts:PropertyTerm>Currency Base Rate</ccts:PropertyTerm><ccts:RepresentationTerm>Rate</ccts:RepresentationTerm><ccts:DataType>Rate. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TargetCurrencyBaseRate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TargetCurrencyBaseRateType TargetCurrencyBaseRate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Exchange Market Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the currency exchange market used as the source of this exchange rate.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTerm>Exchange Market Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExchangeMarketID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExchangeMarketIdType ExchangeMarketId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Calculation Rate. Rate</ccts:DictionaryEntryName><ccts:Definition>The factor applied to the source currency to calculate the target currency.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTerm>Calculation Rate</ccts:PropertyTerm><ccts:RepresentationTerm>Rate</ccts:RepresentationTerm><ccts:DataType>Rate. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CalculationRate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CalculationRateType CalculationRate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Mathematic Operator Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying whether the calculation rate is a multiplier or a divisor.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTerm>Mathematic Operator Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Operator</ccts:DataTypeQualifier><ccts:DataType>Operator_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MathematicOperatorCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MathematicOperatorCodeType MathematicOperatorCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which the exchange rate was established.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTerm>Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Date", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DateType Date { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Exchange Rate. Foreign Exchange_ Contract. Contract</ccts:DictionaryEntryName><ccts:Definition>A contract for foreign exchange.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Exchange Rate</ccts:ObjectClass><ccts:PropertyTermQualifier>Foreign Exchange</ccts:PropertyTermQualifier><ccts:PropertyTerm>Contract</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contract</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contract</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ForeignExchangeContract")]
        public ContractType ForeignExchangeContract { get; set; }
    }
}
