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
    [XmlTypeAttribute("ItemType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(Item))]
    [XmlIncludeAttribute(typeof(SupplyItem))]
    public partial class ItemType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Description-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Pack Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The unit packaging quantity; the number of subunits making up this item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Pack Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PackQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackQuantityType PackQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Pack Size. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of items in a pack of this item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Pack Size</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PackSizeNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackSizeNumericType PackSizeNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Catalogue_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this item was ordered from a catalogue (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Catalogue</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CatalogueIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CatalogueIndicatorType CatalogueIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Name</ccts:DictionaryEntryName><ccts:Definition>A short name optionally given to this item, such as a name from a catalogue, as distinct from a description.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType Name {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Hazardous Risk_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that the transported item, as delivered, is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Hazardous Risk</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>Default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardousRiskIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalInformationType> _additionalInformation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Additional_ Information. Text</ccts:DictionaryEntryName><ccts:Definition>Further details regarding this item (e.g., the URL of a relevant web page).</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalInformationType> AdditionalInformation
        {
            get
            {
                return _additionalInformation;
            }
            set
            {
                _additionalInformation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalInformation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalInformation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalInformationSpecified
        {
            get
            {
                return ((this.AdditionalInformation != null) 
                            && (this.AdditionalInformation.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.KeywordType> _keyword;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Keyword. Text</ccts:DictionaryEntryName><ccts:Definition>A keyword (search string) for this item, assigned by the seller party. Can also be a synonym for the name of the item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Keyword</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Keyword", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.KeywordType> Keyword
        {
            get
            {
                return _keyword;
            }
            set
            {
                _keyword = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Keyword-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Keyword collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool KeywordSpecified
        {
            get
            {
                return ((this.Keyword != null) 
                            && (this.Keyword.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BrandNameType> _brandName;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Brand Name. Name</ccts:DictionaryEntryName><ccts:Definition>A brand name of this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Brand Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>Coca-Cola</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("BrandName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BrandNameType> BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                _brandName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BrandName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BrandName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BrandNameSpecified
        {
            get
            {
                return ((this.BrandName != null) 
                            && (this.BrandName.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ModelNameType> _modelName;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Model Name. Name</ccts:DictionaryEntryName><ccts:Definition>A model name of this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Model Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>VW Beetle </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ModelName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ModelNameType> ModelName
        {
            get
            {
                return _modelName;
            }
            set
            {
                _modelName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ModelName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ModelName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ModelNameSpecified
        {
            get
            {
                return ((this.ModelName != null) 
                            && (this.ModelName.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Buyers_ Item Identification. Item Identification</ccts:DictionaryEntryName><ccts:Definition>Identifying information for this item, assigned by the buyer.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Buyers</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Identification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Identification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Identification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BuyersItemIdentification")]
        public ItemIdentificationType BuyersItemIdentification { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Sellers_ Item Identification. Item Identification</ccts:DictionaryEntryName><ccts:Definition>Identifying information for this item, assigned by the seller.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Sellers</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Identification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Identification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Identification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SellersItemIdentification")]
        public ItemIdentificationType SellersItemIdentification { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemIdentificationType> _manufacturersItemIdentification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Manufacturers_ Item Identification. Item Identification</ccts:DictionaryEntryName><ccts:Definition>Identifying information for this item, assigned by the manufacturer.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Manufacturers</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Identification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Identification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Identification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ManufacturersItemIdentification")]
        public List<ItemIdentificationType> ManufacturersItemIdentification
        {
            get
            {
                return _manufacturersItemIdentification;
            }
            set
            {
                _manufacturersItemIdentification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ManufacturersItemIdentification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ManufacturersItemIdentification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ManufacturersItemIdentificationSpecified
        {
            get
            {
                return ((this.ManufacturersItemIdentification != null) 
                            && (this.ManufacturersItemIdentification.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Standard_ Item Identification. Item Identification</ccts:DictionaryEntryName><ccts:Definition>Identifying information for this item, assigned according to a standard system.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Standard</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Identification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Identification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Identification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StandardItemIdentification")]
        public ItemIdentificationType StandardItemIdentification { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Catalogue_ Item Identification. Item Identification</ccts:DictionaryEntryName><ccts:Definition>Identifying information for this item, assigned according to a cataloguing system.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Catalogue</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Identification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Identification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Identification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CatalogueItemIdentification")]
        public ItemIdentificationType CatalogueItemIdentification { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemIdentificationType> _additionalItemIdentification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Additional_ Item Identification. Item Identification</ccts:DictionaryEntryName><ccts:Definition>An additional identifier for this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Identification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Identification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Identification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalItemIdentification")]
        public List<ItemIdentificationType> AdditionalItemIdentification
        {
            get
            {
                return _additionalItemIdentification;
            }
            set
            {
                _additionalItemIdentification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalItemIdentification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalItemIdentification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalItemIdentificationSpecified
        {
            get
            {
                return ((this.AdditionalItemIdentification != null) 
                            && (this.AdditionalItemIdentification.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Catalogue_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to the catalogue in which this item appears.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Catalogue</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CatalogueDocumentReference")]
        public DocumentReferenceType CatalogueDocumentReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _itemSpecificationDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Item Specification_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a specification document for this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Item Specification</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ItemSpecificationDocumentReference")]
        public List<DocumentReferenceType> ItemSpecificationDocumentReference
        {
            get
            {
                return _itemSpecificationDocumentReference;
            }
            set
            {
                _itemSpecificationDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ItemSpecificationDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ItemSpecificationDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ItemSpecificationDocumentReferenceSpecified
        {
            get
            {
                return ((this.ItemSpecificationDocumentReference != null) 
                            && (this.ItemSpecificationDocumentReference.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Origin_ Country. Country</ccts:DictionaryEntryName><ccts:Definition>The country of origin of this item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Origin</ccts:PropertyTermQualifier><ccts:PropertyTerm>Country</ccts:PropertyTerm><ccts:AssociatedObjectClass>Country</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Country</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginCountry")]
        public CountryType OriginCountry { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<CommodityClassificationType> _commodityClassification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Commodity Classification</ccts:DictionaryEntryName><ccts:Definition>A classification of this item according to a specific system for classifying commodities.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Commodity Classification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Commodity Classification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Commodity Classification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CommodityClassification")]
        public List<CommodityClassificationType> CommodityClassification
        {
            get
            {
                return _commodityClassification;
            }
            set
            {
                _commodityClassification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CommodityClassification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CommodityClassification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CommodityClassificationSpecified
        {
            get
            {
                return ((this.CommodityClassification != null) 
                            && (this.CommodityClassification.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransactionConditionsType> _transactionConditions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Transaction Conditions</ccts:DictionaryEntryName><ccts:Definition>A set of sales conditions applying to this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Transaction Conditions</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transaction Conditions</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transaction Conditions</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransactionConditions")]
        public List<TransactionConditionsType> TransactionConditions
        {
            get
            {
                return _transactionConditions;
            }
            set
            {
                _transactionConditions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransactionConditions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransactionConditions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransactionConditionsSpecified
        {
            get
            {
                return ((this.TransactionConditions != null) 
                            && (this.TransactionConditions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<HazardousItemType> _hazardousItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Hazardous Item</ccts:DictionaryEntryName><ccts:Definition>Information pertaining to this item as a hazardous item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Hazardous Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Hazardous Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Hazardous Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HazardousItem")]
        public List<HazardousItemType> HazardousItem
        {
            get
            {
                return _hazardousItem;
            }
            set
            {
                _hazardousItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HazardousItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HazardousItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HazardousItemSpecified
        {
            get
            {
                return ((this.HazardousItem != null) 
                            && (this.HazardousItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TaxCategoryType> _classifiedTaxCategory;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Classified_ Tax Category. Tax Category</ccts:DictionaryEntryName><ccts:Definition>A tax category applicable to this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Classified</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tax Category</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Category</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Category</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ClassifiedTaxCategory")]
        public List<TaxCategoryType> ClassifiedTaxCategory
        {
            get
            {
                return _classifiedTaxCategory;
            }
            set
            {
                _classifiedTaxCategory = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ClassifiedTaxCategory-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ClassifiedTaxCategory collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ClassifiedTaxCategorySpecified
        {
            get
            {
                return ((this.ClassifiedTaxCategory != null) 
                            && (this.ClassifiedTaxCategory.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ItemPropertyType> _additionalItemProperty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Additional_ Item Property. Item Property</ccts:DictionaryEntryName><ccts:Definition>An additional property of this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Property</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Property</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Property</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalItemProperty")]
        public List<ItemPropertyType> AdditionalItemProperty
        {
            get
            {
                return _additionalItemProperty;
            }
            set
            {
                _additionalItemProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalItemProperty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalItemProperty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalItemPropertySpecified
        {
            get
            {
                return ((this.AdditionalItemProperty != null) 
                            && (this.AdditionalItemProperty.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PartyType> _manufacturerParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Manufacturer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The manufacturer of this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Manufacturer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ManufacturerParty")]
        public List<PartyType> ManufacturerParty
        {
            get
            {
                return _manufacturerParty;
            }
            set
            {
                _manufacturerParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ManufacturerParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ManufacturerParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ManufacturerPartySpecified
        {
            get
            {
                return ((this.ManufacturerParty != null) 
                            && (this.ManufacturerParty.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Information Content Provider_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party responsible for specification of this item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Information Content Provider</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InformationContentProviderParty")]
        public PartyType InformationContentProviderParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AddressType> _originAddress;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Origin_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>A region (not country) of origin of this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Origin</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OriginAddress")]
        public List<AddressType> OriginAddress
        {
            get
            {
                return _originAddress;
            }
            set
            {
                _originAddress = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OriginAddress-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OriginAddress collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OriginAddressSpecified
        {
            get
            {
                return ((this.OriginAddress != null) 
                            && (this.OriginAddress.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ItemInstanceType> _itemInstance;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Item Instance</ccts:DictionaryEntryName><ccts:Definition>A trackable, unique instantiation of this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Item Instance</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Instance</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Instance</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ItemInstance")]
        public List<ItemInstanceType> ItemInstance
        {
            get
            {
                return _itemInstance;
            }
            set
            {
                _itemInstance = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ItemInstance-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ItemInstance collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ItemInstanceSpecified
        {
            get
            {
                return ((this.ItemInstance != null) 
                            && (this.ItemInstance.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CertificateType> _certificate;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Certificate</ccts:DictionaryEntryName><ccts:Definition>A certificate associated with this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Certificate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Certificate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Certificate</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Certificate")]
        public List<CertificateType> Certificate
        {
            get
            {
                return _certificate;
            }
            set
            {
                _certificate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Certificate-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Certificate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CertificateSpecified
        {
            get
            {
                return ((this.Certificate != null) 
                            && (this.Certificate.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DimensionType> _dimension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item. Dimension</ccts:DictionaryEntryName><ccts:Definition>One of the measurable dimensions (length, mass, weight, or volume) of this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item</ccts:ObjectClass><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Dimension")]
        public List<DimensionType> Dimension
        {
            get
            {
                return _dimension;
            }
            set
            {
                _dimension = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Dimension-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Dimension collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DimensionSpecified
        {
            get
            {
                return ((this.Dimension != null) 
                            && (this.Dimension.Count != 0));
            }
        }
    }
}
