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
    [XmlTypeAttribute("PriceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AlternativeConditionPrice))]
    [XmlIncludeAttribute(typeof(Price))]
    [XmlIncludeAttribute(typeof(TaxExclusivePrice))]
    [XmlIncludeAttribute(typeof(TaxInclusivePrice))]
    public partial class PriceType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Price Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount of the price.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTerm>Price Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>unit price</ccts:AlternativeBusinessTerms><ccts:Examples>23.45</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PriceAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceAmountType PriceAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Base_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity at which this price applies.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTermQualifier>Base</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BaseQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BaseQuantityType BaseQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceChangeReasonType> _priceChangeReason;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Price Change_ Reason. Text</ccts:DictionaryEntryName><ccts:Definition>A reason for a price change.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTermQualifier>Price Change</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Clearance of old stock , New contract applies </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PriceChangeReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceChangeReasonType> PriceChangeReason
        {
            get
            {
                return _priceChangeReason;
            }
            set
            {
                _priceChangeReason = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PriceChangeReason-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PriceChangeReason collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PriceChangeReasonSpecified
        {
            get
            {
                return ((this.PriceChangeReason != null) 
                            && (this.PriceChangeReason.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Price Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of price, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTerm>Price Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PriceTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceTypeCodeType PriceTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Price Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of price, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTerm>Price Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>retail, wholesale, discount, contract</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PriceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceTypeType PriceTypeProperty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Orderable Unit Factor. Rate</ccts:DictionaryEntryName><ccts:Definition>The factor by which the base price unit can be converted to the orderable unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTerm>Orderable Unit Factor</ccts:PropertyTerm><ccts:RepresentationTerm>Rate</ccts:RepresentationTerm><ccts:DataType>Rate. Type</ccts:DataType><ccts:Examples>Nails are priced by weight but ordered by quantity. So this would say how many nails per kilo</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OrderableUnitFactorRate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderableUnitFactorRateType OrderableUnitFactorRate { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PeriodType> _validityPeriod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>A period during which this price is valid.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTermQualifier>Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Price List</ccts:DictionaryEntryName><ccts:Definition>Information about a price list applicable to this price.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTerm>Price List</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price List</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price List</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PriceList")]
        public PriceListType PriceList { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _allowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge associated with this price.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AllowanceCharge")]
        public List<AllowanceChargeType> AllowanceCharge
        {
            get
            {
                return _allowanceCharge;
            }
            set
            {
                _allowanceCharge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AllowanceCharge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AllowanceChargeSpecified
        {
            get
            {
                return ((this.AllowanceCharge != null) 
                            && (this.AllowanceCharge.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price. Pricing_ Exchange Rate. Exchange Rate</ccts:DictionaryEntryName><ccts:Definition>The exchange rate applicable to this price, if it differs from the exchange rate applicable to the document as a whole.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price</ccts:ObjectClass><ccts:PropertyTermQualifier>Pricing</ccts:PropertyTermQualifier><ccts:PropertyTerm>Exchange Rate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Exchange Rate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Exchange Rate</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PricingExchangeRate")]
        public ExchangeRateType PricingExchangeRate { get; set; }
    }
}
