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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a line in a Catalogue describing a purchasable item.</ccts:Definition><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CatalogueLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("CatalogueLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the line in the catalogue.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>1 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Action Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the action required to synchronize this catalogue line. Recommend codes (delete, update, add)</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Action Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Replace , Update , Delete , Add </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ActionCodeType ActionCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Life Cycle Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the life cycle status of this catalogue line. Examples are pre-order, end of production</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Life Cycle Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>new - announcement only , new and available , deleted - announcement only </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LifeCycleStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LifeCycleStatusCodeType LifeCycleStatusCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Contract Subdivision. Text</ccts:DictionaryEntryName><ccts:Definition>A subdivision of a contract or tender covering this catalogue line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Contract Subdivision</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Installation , Phase One , Support and Maintenance </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractSubdivision", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContractSubdivisionType ContractSubdivision { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Note-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Note collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoteSpecified
        {
            get
            {
                return ((this.Note != null) 
                            && (this.Note.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Orderable_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this catalogue line describes an orderable item (true) or is included for reference purposes only (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Orderable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>TRUE means orderable, FALSE means not orderable</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OrderableIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderableIndicatorType OrderableIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Orderable_ Unit. Text</ccts:DictionaryEntryName><ccts:Definition>A textual description of the units in which the item described in this catalogue line can be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Orderable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Unit</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OrderableUnit", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderableUnitType OrderableUnit { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Content Unit. Quantity</ccts:DictionaryEntryName><ccts:Definition>The numeric quantity of the ordering unit (and units of measure) of the catalogue line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Content Unit</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>If order unit measure identifier is each , then content unit quantity is 1 .</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContentUnitQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContentUnitQuantityType ContentUnitQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Order Quantity Increment. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of items that can set the order quantity increments.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Order Quantity Increment</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OrderQuantityIncrementNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Minimum_ Order Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The minimum amount of the item described in this catalogue line that can be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Order Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>10 boxes </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumOrderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumOrderQuantityType MinimumOrderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Maximum_ Order Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The maximum amount of the item described in this catalogue line that can be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Order Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>1 tonne </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumOrderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumOrderQuantityType MaximumOrderQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WarrantyInformationType> _warrantyInformation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Warranty_ Information. Text</ccts:DictionaryEntryName><ccts:Definition>Text about a warranty (provided by WarrantyParty) for the good or service described in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Unless specified otherwise and in addition to any rights the Customer may have under statute, Dell warrants to the Customer that Dell branded Products (excluding third party products and software), will be free from defects in materials and workmanship affecting normal use for a period of one year from invoice date ( Standard Warranty ). </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("WarrantyInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WarrantyInformationType> WarrantyInformation
        {
            get
            {
                return _warrantyInformation;
            }
            set
            {
                _warrantyInformation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die WarrantyInformation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the WarrantyInformation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WarrantyInformationSpecified
        {
            get
            {
                return ((this.WarrantyInformation != null) 
                            && (this.WarrantyInformation.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Pack Level Code. Code</ccts:DictionaryEntryName><ccts:Definition>A mutually agreed code signifying the level of packaging associated with the item described in this catalogue line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Pack Level Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Consumer Unit, Trading Unit</ccts:AlternativeBusinessTerms><ccts:Examples>level 2 , Group 4 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PackLevelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackLevelCodeType PackLevelCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Contractor_ Customer Party. Customer Party</ccts:DictionaryEntryName><ccts:Definition>The customer responsible for the contract with which this catalogue line is associated.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Contractor</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customer Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customer Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customer Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractorCustomerParty")]
        public CustomerPartyType ContractorCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Seller_ Supplier Party. Supplier Party</ccts:DictionaryEntryName><ccts:Definition>The seller/supplier responsible for the contract with which this catalogue line is associated.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Seller</ccts:PropertyTermQualifier><ccts:PropertyTerm>Supplier Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SellerSupplierParty")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Warranty_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party responsible for any warranty associated with the item described in this catalogue line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarrantyParty")]
        public PartyType WarrantyParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Warranty Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period for which a warranty associated with the item in this catalogue line is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarrantyValidityPeriod")]
        public PeriodType WarrantyValidityPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Line Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period for which the information in this catalogue line is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Line Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LineValidityPeriod")]
        public PeriodType LineValidityPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemComparisonType> _itemComparison;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Item Comparison</ccts:DictionaryEntryName><ccts:Definition>A combination of price and quantity used to provide price comparisons based on different sizes of order.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Item Comparison</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Comparison</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Comparison</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ItemComparison")]
        public List<ItemComparisonType> ItemComparison
        {
            get
            {
                return _itemComparison;
            }
            set
            {
                _itemComparison = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ItemComparison-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ItemComparison collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ItemComparisonSpecified
        {
            get
            {
                return ((this.ItemComparison != null) 
                            && (this.ItemComparison.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RelatedItemType> _componentRelatedItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Component_ Related Item. Related Item</ccts:DictionaryEntryName><ccts:Definition>An item that may be a component of the item in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Component</ccts:PropertyTermQualifier><ccts:PropertyTerm>Related Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Related Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Related Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ComponentRelatedItem")]
        public List<RelatedItemType> ComponentRelatedItem
        {
            get
            {
                return _componentRelatedItem;
            }
            set
            {
                _componentRelatedItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ComponentRelatedItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ComponentRelatedItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ComponentRelatedItemSpecified
        {
            get
            {
                return ((this.ComponentRelatedItem != null) 
                            && (this.ComponentRelatedItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RelatedItemType> _accessoryRelatedItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Accessory_ Related Item. Related Item</ccts:DictionaryEntryName><ccts:Definition>An item that may be an optional accessory of the item in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Accessory</ccts:PropertyTermQualifier><ccts:PropertyTerm>Related Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Related Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Related Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AccessoryRelatedItem")]
        public List<RelatedItemType> AccessoryRelatedItem
        {
            get
            {
                return _accessoryRelatedItem;
            }
            set
            {
                _accessoryRelatedItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AccessoryRelatedItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AccessoryRelatedItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AccessoryRelatedItemSpecified
        {
            get
            {
                return ((this.AccessoryRelatedItem != null) 
                            && (this.AccessoryRelatedItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RelatedItemType> _requiredRelatedItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Required_ Related Item. Related Item</ccts:DictionaryEntryName><ccts:Definition>An item that may be required for the item in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Related Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Related Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Related Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequiredRelatedItem")]
        public List<RelatedItemType> RequiredRelatedItem
        {
            get
            {
                return _requiredRelatedItem;
            }
            set
            {
                _requiredRelatedItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequiredRelatedItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequiredRelatedItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequiredRelatedItemSpecified
        {
            get
            {
                return ((this.RequiredRelatedItem != null) 
                            && (this.RequiredRelatedItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RelatedItemType> _replacementRelatedItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Replacement_ Related Item. Related Item</ccts:DictionaryEntryName><ccts:Definition>An item that may be a replacement for the item in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Replacement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Related Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Related Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Related Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReplacementRelatedItem")]
        public List<RelatedItemType> ReplacementRelatedItem
        {
            get
            {
                return _replacementRelatedItem;
            }
            set
            {
                _replacementRelatedItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReplacementRelatedItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReplacementRelatedItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReplacementRelatedItemSpecified
        {
            get
            {
                return ((this.ReplacementRelatedItem != null) 
                            && (this.ReplacementRelatedItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RelatedItemType> _complementaryRelatedItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Complementary_ Related Item. Related Item</ccts:DictionaryEntryName><ccts:Definition>An item that may complement the item in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Complementary</ccts:PropertyTermQualifier><ccts:PropertyTerm>Related Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Related Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Related Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ComplementaryRelatedItem")]
        public List<RelatedItemType> ComplementaryRelatedItem
        {
            get
            {
                return _complementaryRelatedItem;
            }
            set
            {
                _complementaryRelatedItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ComplementaryRelatedItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ComplementaryRelatedItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ComplementaryRelatedItemSpecified
        {
            get
            {
                return ((this.ComplementaryRelatedItem != null) 
                            && (this.ComplementaryRelatedItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RelatedItemType> _replacedRelatedItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Replaced_ Related Item. Related Item</ccts:DictionaryEntryName><ccts:Definition>An item in an existing catalogue that is being replaced by the item in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Replaced</ccts:PropertyTermQualifier><ccts:PropertyTerm>Related Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Related Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Related Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReplacedRelatedItem")]
        public List<RelatedItemType> ReplacedRelatedItem
        {
            get
            {
                return _replacedRelatedItem;
            }
            set
            {
                _replacedRelatedItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReplacedRelatedItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReplacedRelatedItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReplacedRelatedItemSpecified
        {
            get
            {
                return ((this.ReplacedRelatedItem != null) 
                            && (this.ReplacedRelatedItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ItemLocationQuantityType> _requiredItemLocationQuantity;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Required_ Item Location Quantity. Item Location Quantity</ccts:DictionaryEntryName><ccts:Definition>Properties of the item in this catalogue line that are dependent on location and quantity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Location Quantity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Location Quantity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Location Quantity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequiredItemLocationQuantity")]
        public List<ItemLocationQuantityType> RequiredItemLocationQuantity
        {
            get
            {
                return _requiredItemLocationQuantity;
            }
            set
            {
                _requiredItemLocationQuantity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequiredItemLocationQuantity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequiredItemLocationQuantity collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequiredItemLocationQuantitySpecified
        {
            get
            {
                return ((this.RequiredItemLocationQuantity != null) 
                            && (this.RequiredItemLocationQuantity.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentReference")]
        public List<DocumentReferenceType> DocumentReference
        {
            get
            {
                return _documentReference;
            }
            set
            {
                _documentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentReferenceSpecified
        {
            get
            {
                return ((this.DocumentReference != null) 
                            && (this.DocumentReference.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Item</ccts:DictionaryEntryName><ccts:Definition>A specification of the item itself.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Item")]
        public ItemType Item {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<ItemPropertyType> _keywordItemProperty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Keyword_ Item Property. Item Property</ccts:DictionaryEntryName><ccts:Definition>A property of the item in this catalogue line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Keyword</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Property</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Property</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Property</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("KeywordItemProperty")]
        public List<ItemPropertyType> KeywordItemProperty
        {
            get
            {
                return _keywordItemProperty;
            }
            set
            {
                _keywordItemProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die KeywordItemProperty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the KeywordItemProperty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool KeywordItemPropertySpecified
        {
            get
            {
                return ((this.KeywordItemProperty != null) 
                            && (this.KeywordItemProperty.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Call For Tenders_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>Reference to a Line on a Call For Tenders document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Call For Tenders</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CallForTendersLineReference")]
        public LineReferenceType CallForTendersLineReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Line. Call For Tenders_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A class defining references to a Call For Tenders document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Call For Tenders</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CallForTendersDocumentReference")]
        public DocumentReferenceType CallForTendersDocumentReference { get; set; }
    }
}
