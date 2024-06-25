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
    [XmlTypeAttribute("ItemLocationQuantityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ItemLocationQuantity))]
    [XmlIncludeAttribute(typeof(OfferedItemLocationQuantity))]
    [XmlIncludeAttribute(typeof(OriginalItemLocationQuantity))]
    [XmlIncludeAttribute(typeof(RequiredItemLocationQuantity))]
    public partial class ItemLocationQuantityType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Lead Time. Measure</ccts:DictionaryEntryName><ccts:Definition>The lead time, i.e., the time taken from the time at which an item is ordered to the time of its delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTerm>Lead Time</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType><ccts:Examples>2 days , 24 hours </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LeadTimeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LeadTimeMeasureType LeadTimeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Minimum_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The minimum quantity that can be ordered to qualify for a specific price.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>10 boxes , 1 carton , 1000 sheets </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumQuantityType MinimumQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Maximum_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The maximum quantity that can be ordered to qualify for a specific price.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>10 boxes , 1 carton , 1000 sheets </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumQuantityType MaximumQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Hazardous Risk_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported item, as delivered, in the stated quantity to the stated location, is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTermQualifier>Hazardous Risk</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>Default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardousRiskIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TradingRestrictionsType> _tradingRestrictions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Trading Restrictions. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing trade restrictions on the quantity of this item or on the item itself.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTerm>Trading Restrictions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>not for export </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TradingRestrictions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TradingRestrictionsType> TradingRestrictions
        {
            get
            {
                return _tradingRestrictions;
            }
            set
            {
                _tradingRestrictions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TradingRestrictions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TradingRestrictions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TradingRestrictionsSpecified
        {
            get
            {
                return ((this.TradingRestrictions != null) 
                            && (this.TradingRestrictions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AddressType> _applicableTerritoryAddress;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Applicable Territory_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The applicable sales territory.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTermQualifier>Applicable Territory</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ApplicableTerritoryAddress")]
        public List<AddressType> ApplicableTerritoryAddress
        {
            get
            {
                return _applicableTerritoryAddress;
            }
            set
            {
                _applicableTerritoryAddress = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ApplicableTerritoryAddress-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicableTerritoryAddress collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ApplicableTerritoryAddressSpecified
        {
            get
            {
                return ((this.ApplicableTerritoryAddress != null) 
                            && (this.ApplicableTerritoryAddress.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Price</ccts:DictionaryEntryName><ccts:Definition>The price associated with the given location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Price")]
        public PriceType Price { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryUnitType> _deliveryUnit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Delivery Unit</ccts:DictionaryEntryName><ccts:Definition>A delivery unit in which the item is located.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTerm>Delivery Unit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Unit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Unit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeliveryUnit")]
        public List<DeliveryUnitType> DeliveryUnit
        {
            get
            {
                return _deliveryUnit;
            }
            set
            {
                _deliveryUnit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryUnit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DeliveryUnit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliveryUnitSpecified
        {
            get
            {
                return ((this.DeliveryUnit != null) 
                            && (this.DeliveryUnit.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TaxCategoryType> _applicableTaxCategory;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Applicable_ Tax Category. Tax Category</ccts:DictionaryEntryName><ccts:Definition>A tax category applicable to this item location quantity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTermQualifier>Applicable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tax Category</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Category</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Category</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ApplicableTaxCategory")]
        public List<TaxCategoryType> ApplicableTaxCategory
        {
            get
            {
                return _applicableTaxCategory;
            }
            set
            {
                _applicableTaxCategory = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ApplicableTaxCategory-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicableTaxCategory collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ApplicableTaxCategorySpecified
        {
            get
            {
                return ((this.ApplicableTaxCategory != null) 
                            && (this.ApplicableTaxCategory.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Package</ccts:DictionaryEntryName><ccts:Definition>The package to which this price applies.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTerm>Package</ccts:PropertyTerm><ccts:AssociatedObjectClass>Package</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Package</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Package")]
        public PackageType Package { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _allowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge associated with this item location quantity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Location Quantity. Dependent Price Reference</ccts:DictionaryEntryName><ccts:Definition>The price of the item as a percentage of the price of some other item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Location Quantity</ccts:ObjectClass><ccts:PropertyTerm>Dependent Price Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dependent Price Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dependent Price Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DependentPriceReference")]
        public DependentPriceReferenceType DependentPriceReference { get; set; }
    }
}