using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an item of trade. It includes a generic description applicable to all examples of the item together with optional subsidiary descriptions of any number of actual instances of the type.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item. Details
/// <para />ObjectClass: Item
/// <para />AlternativeBusinessTerms: article, product, goods item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemType
{
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__PackQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackSizeNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public NumericType @__PackSizeNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CatalogueIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IndicatorType @__CatalogueIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousRiskIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IndicatorType @__HazardousRiskIndicator;
        
    private System.Collections.Generic.List<TextType> _additionalInformation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType[] @__AdditionalInformation
    {
        get
        {
            return _additionalInformation?.ToArray();
        }
        set
        {
            _additionalInformation = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _keyword;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Keyword", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType[] @__Keyword
    {
        get
        {
            return _keyword?.ToArray();
        }
        set
        {
            _keyword = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<NameType> _brandName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BrandName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public NameType[] @__BrandName
    {
        get
        {
            return _brandName?.ToArray();
        }
        set
        {
            _brandName = value == null ? null : new System.Collections.Generic.List<NameType>(value);
        }
    }
        
    private System.Collections.Generic.List<NameType> _modelName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ModelName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public NameType[] @__ModelName
    {
        get
        {
            return _modelName?.ToArray();
        }
        set
        {
            _modelName = value == null ? null : new System.Collections.Generic.List<NameType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuyersItemIdentification", Order=10)]
    public ItemIdentificationType @__BuyersItemIdentification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellersItemIdentification", Order=11)]
    public ItemIdentificationType @__SellersItemIdentification;
        
    private System.Collections.Generic.List<ItemIdentificationType> _manufacturersItemIdentification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ManufacturersItemIdentification", Order=12)]
    public ItemIdentificationType[] @__ManufacturersItemIdentification
    {
        get
        {
            return _manufacturersItemIdentification?.ToArray();
        }
        set
        {
            _manufacturersItemIdentification = value == null ? null : new System.Collections.Generic.List<ItemIdentificationType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StandardItemIdentification", Order=13)]
    public ItemIdentificationType @__StandardItemIdentification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CatalogueItemIdentification", Order=14)]
    public ItemIdentificationType @__CatalogueItemIdentification;
        
    private System.Collections.Generic.List<ItemIdentificationType> _additionalItemIdentification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalItemIdentification", Order=15)]
    public ItemIdentificationType[] @__AdditionalItemIdentification
    {
        get
        {
            return _additionalItemIdentification?.ToArray();
        }
        set
        {
            _additionalItemIdentification = value == null ? null : new System.Collections.Generic.List<ItemIdentificationType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CatalogueDocumentReference", Order=16)]
    public DocumentReferenceType @__CatalogueDocumentReference;
        
    private System.Collections.Generic.List<DocumentReferenceType> _itemSpecificationDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemSpecificationDocumentReference", Order=17)]
    public DocumentReferenceType[] @__ItemSpecificationDocumentReference
    {
        get
        {
            return _itemSpecificationDocumentReference?.ToArray();
        }
        set
        {
            _itemSpecificationDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginCountry", Order=18)]
    public CountryType @__OriginCountry;
        
    private System.Collections.Generic.List<CommodityClassificationType> _commodityClassification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CommodityClassification", Order=19)]
    public CommodityClassificationType[] @__CommodityClassification
    {
        get
        {
            return _commodityClassification?.ToArray();
        }
        set
        {
            _commodityClassification = value == null ? null : new System.Collections.Generic.List<CommodityClassificationType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransactionConditionsType> _transactionConditions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransactionConditions", Order=20)]
    public TransactionConditionsType[] @__TransactionConditions
    {
        get
        {
            return _transactionConditions?.ToArray();
        }
        set
        {
            _transactionConditions = value == null ? null : new System.Collections.Generic.List<TransactionConditionsType>(value);
        }
    }
        
    private System.Collections.Generic.List<HazardousItemType> _hazardousItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousItem", Order=21)]
    public HazardousItemType[] @__HazardousItem
    {
        get
        {
            return _hazardousItem?.ToArray();
        }
        set
        {
            _hazardousItem = value == null ? null : new System.Collections.Generic.List<HazardousItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<TaxCategoryType> _classifiedTaxCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ClassifiedTaxCategory", Order=22)]
    public TaxCategoryType[] @__ClassifiedTaxCategory
    {
        get
        {
            return _classifiedTaxCategory?.ToArray();
        }
        set
        {
            _classifiedTaxCategory = value == null ? null : new System.Collections.Generic.List<TaxCategoryType>(value);
        }
    }
        
    private System.Collections.Generic.List<ItemPropertyType> _additionalItemProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty", Order=23)]
    public ItemPropertyType[] @__AdditionalItemProperty
    {
        get
        {
            return _additionalItemProperty?.ToArray();
        }
        set
        {
            _additionalItemProperty = value == null ? null : new System.Collections.Generic.List<ItemPropertyType>(value);
        }
    }
        
    private System.Collections.Generic.List<PartyType> _manufacturerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ManufacturerParty", Order=24)]
    public PartyType[] @__ManufacturerParty
    {
        get
        {
            return _manufacturerParty?.ToArray();
        }
        set
        {
            _manufacturerParty = value == null ? null : new System.Collections.Generic.List<PartyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InformationContentProviderParty", Order=25)]
    public PartyType @__InformationContentProviderParty;
        
    private System.Collections.Generic.List<AddressType> _originAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginAddress", Order=26)]
    public AddressType[] @__OriginAddress
    {
        get
        {
            return _originAddress?.ToArray();
        }
        set
        {
            _originAddress = value == null ? null : new System.Collections.Generic.List<AddressType>(value);
        }
    }
        
    private System.Collections.Generic.List<ItemInstanceType> _itemInstance;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemInstance", Order=27)]
    public ItemInstanceType[] @__ItemInstance
    {
        get
        {
            return _itemInstance?.ToArray();
        }
        set
        {
            _itemInstance = value == null ? null : new System.Collections.Generic.List<ItemInstanceType>(value);
        }
    }
        
    private System.Collections.Generic.List<CertificateType> _certificate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Certificate", Order=28)]
    public CertificateType[] @__Certificate
    {
        get
        {
            return _certificate?.ToArray();
        }
        set
        {
            _certificate = value == null ? null : new System.Collections.Generic.List<CertificateType>(value);
        }
    }
        
    private System.Collections.Generic.List<DimensionType> _dimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Dimension", Order=29)]
    public DimensionType[] @__Dimension
    {
        get
        {
            return _dimension?.ToArray();
        }
        set
        {
            _dimension = value == null ? null : new System.Collections.Generic.List<DimensionType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Further details regarding this item (e.g., the URL of a relevant web page).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Additional_ Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Information
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> AdditionalInformation
    {
        get { return _additionalInformation ?? (_additionalInformation = new System.Collections.Generic.List<TextType>()); }
        set { _additionalInformation = value; }
    }

        
    /// <summary>
    /// A keyword (search string) for this item, assigned by the seller party. Can also be a synonym for the name of the item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Keyword. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Keyword
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Keyword
    {
        get { return _keyword ?? (_keyword = new System.Collections.Generic.List<TextType>()); }
        set { _keyword = value; }
    }

        
    /// <summary>
    /// A brand name of this item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Brand Name. Name
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Brand Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Coca-Cola</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<NameType> BrandName
    {
        get { return _brandName ?? (_brandName = new System.Collections.Generic.List<NameType>()); }
        set { _brandName = value; }
    }

        
    /// <summary>
    /// A model name of this item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Model Name. Name
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Model Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>VW Beetle</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<NameType> ModelName
    {
        get { return _modelName ?? (_modelName = new System.Collections.Generic.List<NameType>()); }
        set { _modelName = value; }
    }

        
    /// <summary>
    /// Identifying information for this item, assigned by the manufacturer.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Manufacturers_ Item Identification. Item Identification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Manufacturers
    /// <para />PropertyTerm: Item Identification
    /// <para />AssociatedObjectClass: Item Identification
    /// <para />RepresentationTerm: Item Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemIdentificationType> ManufacturersItemIdentification
    {
        get { return _manufacturersItemIdentification ?? (_manufacturersItemIdentification = new System.Collections.Generic.List<ItemIdentificationType>()); }
        set { _manufacturersItemIdentification = value; }
    }

        
    /// <summary>
    /// An additional identifier for this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Additional_ Item Identification. Item Identification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Item Identification
    /// <para />AssociatedObjectClass: Item Identification
    /// <para />RepresentationTerm: Item Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemIdentificationType> AdditionalItemIdentification
    {
        get { return _additionalItemIdentification ?? (_additionalItemIdentification = new System.Collections.Generic.List<ItemIdentificationType>()); }
        set { _additionalItemIdentification = value; }
    }

        
    /// <summary>
    /// A reference to a specification document for this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Item Specification_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Item Specification
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> ItemSpecificationDocumentReference
    {
        get { return _itemSpecificationDocumentReference ?? (_itemSpecificationDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _itemSpecificationDocumentReference = value; }
    }

        
    /// <summary>
    /// A classification of this item according to a specific system for classifying commodities.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Commodity Classification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Commodity Classification
    /// <para />AssociatedObjectClass: Commodity Classification
    /// <para />RepresentationTerm: Commodity Classification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CommodityClassificationType> CommodityClassification
    {
        get { return _commodityClassification ?? (_commodityClassification = new System.Collections.Generic.List<CommodityClassificationType>()); }
        set { _commodityClassification = value; }
    }

        
    /// <summary>
    /// A set of sales conditions applying to this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Transaction Conditions
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Transaction Conditions
    /// <para />AssociatedObjectClass: Transaction Conditions
    /// <para />RepresentationTerm: Transaction Conditions
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransactionConditionsType> TransactionConditions
    {
        get { return _transactionConditions ?? (_transactionConditions = new System.Collections.Generic.List<TransactionConditionsType>()); }
        set { _transactionConditions = value; }
    }

        
    /// <summary>
    /// Information pertaining to this item as a hazardous item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Hazardous Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Hazardous Item
    /// <para />AssociatedObjectClass: Hazardous Item
    /// <para />RepresentationTerm: Hazardous Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<HazardousItemType> HazardousItem
    {
        get { return _hazardousItem ?? (_hazardousItem = new System.Collections.Generic.List<HazardousItemType>()); }
        set { _hazardousItem = value; }
    }

        
    /// <summary>
    /// A tax category applicable to this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Classified_ Tax Category. Tax Category
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Classified
    /// <para />PropertyTerm: Tax Category
    /// <para />AssociatedObjectClass: Tax Category
    /// <para />RepresentationTerm: Tax Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TaxCategoryType> ClassifiedTaxCategory
    {
        get { return _classifiedTaxCategory ?? (_classifiedTaxCategory = new System.Collections.Generic.List<TaxCategoryType>()); }
        set { _classifiedTaxCategory = value; }
    }

        
    /// <summary>
    /// An additional property of this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Additional_ Item Property. Item Property
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Item Property
    /// <para />AssociatedObjectClass: Item Property
    /// <para />RepresentationTerm: Item Property
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemPropertyType> AdditionalItemProperty
    {
        get { return _additionalItemProperty ?? (_additionalItemProperty = new System.Collections.Generic.List<ItemPropertyType>()); }
        set { _additionalItemProperty = value; }
    }

        
    /// <summary>
    /// The manufacturer of this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Manufacturer_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Manufacturer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyType> ManufacturerParty
    {
        get { return _manufacturerParty ?? (_manufacturerParty = new System.Collections.Generic.List<PartyType>()); }
        set { _manufacturerParty = value; }
    }

        
    /// <summary>
    /// A region (not country) of origin of this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Origin_ Address. Address
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Origin
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AddressType> OriginAddress
    {
        get { return _originAddress ?? (_originAddress = new System.Collections.Generic.List<AddressType>()); }
        set { _originAddress = value; }
    }

        
    /// <summary>
    /// A trackable, unique instantiation of this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Item Instance
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Item Instance
    /// <para />AssociatedObjectClass: Item Instance
    /// <para />RepresentationTerm: Item Instance
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemInstanceType> ItemInstance
    {
        get { return _itemInstance ?? (_itemInstance = new System.Collections.Generic.List<ItemInstanceType>()); }
        set { _itemInstance = value; }
    }

        
    /// <summary>
    /// A certificate associated with this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Certificate
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Certificate
    /// <para />AssociatedObjectClass: Certificate
    /// <para />RepresentationTerm: Certificate
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CertificateType> Certificate
    {
        get { return _certificate ?? (_certificate = new System.Collections.Generic.List<CertificateType>()); }
        set { _certificate = value; }
    }

        
    /// <summary>
    /// One of the measurable dimensions (length, mass, weight, or volume) of this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DimensionType> Dimension
    {
        get { return _dimension ?? (_dimension = new System.Collections.Generic.List<DimensionType>()); }
        set { _dimension = value; }
    }

        
    /// <summary>
    /// The unit packaging quantity; the number of subunits making up this item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Pack Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Pack Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType PackQuantity
    {
        get
        {
            if (__PackQuantity == null) { __PackQuantity = new QuantityType(); }
            return __PackQuantity;
        }
        set
        {
            __PackQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of items in a pack of this item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Pack Size. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Pack Size
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType PackSizeNumeric
    {
        get
        {
            if (__PackSizeNumeric == null) { __PackSizeNumeric = new NumericType(); }
            return __PackSizeNumeric;
        }
        set
        {
            __PackSizeNumeric = value;
        }
    }

        
    /// <summary>
    /// An indicator that this item was ordered from a catalogue (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Catalogue_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Catalogue
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType CatalogueIndicator
    {
        get
        {
            if (__CatalogueIndicator == null) { __CatalogueIndicator = new IndicatorType(); }
            return __CatalogueIndicator;
        }
        set
        {
            __CatalogueIndicator = value;
        }
    }

        
    /// <summary>
    /// A short name optionally given to this item, such as a name from a catalogue, as distinct from a description.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType Name
    {
        get
        {
            if (__Name == null) { __Name = new NameType(); }
            return __Name;
        }
        set
        {
            __Name = value;
        }
    }

        
    /// <summary>
    /// An indication that the transported item, as delivered, is subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item. Hazardous Risk_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Hazardous Risk
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>Default is negative</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType HazardousRiskIndicator
    {
        get
        {
            if (__HazardousRiskIndicator == null) { __HazardousRiskIndicator = new IndicatorType(); }
            return __HazardousRiskIndicator;
        }
        set
        {
            __HazardousRiskIndicator = value;
        }
    }

        
    /// <summary>
    /// Identifying information for this item, assigned by the buyer.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Buyers_ Item Identification. Item Identification
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Buyers
    /// <para />PropertyTerm: Item Identification
    /// <para />AssociatedObjectClass: Item Identification
    /// <para />RepresentationTerm: Item Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemIdentificationType BuyersItemIdentification
    {
        get
        {
            if (__BuyersItemIdentification == null) { __BuyersItemIdentification = new ItemIdentificationType(); }
            return __BuyersItemIdentification;
        }
        set
        {
            __BuyersItemIdentification = value;
        }
    }

        
    /// <summary>
    /// Identifying information for this item, assigned by the seller.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Sellers_ Item Identification. Item Identification
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Sellers
    /// <para />PropertyTerm: Item Identification
    /// <para />AssociatedObjectClass: Item Identification
    /// <para />RepresentationTerm: Item Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemIdentificationType SellersItemIdentification
    {
        get
        {
            if (__SellersItemIdentification == null) { __SellersItemIdentification = new ItemIdentificationType(); }
            return __SellersItemIdentification;
        }
        set
        {
            __SellersItemIdentification = value;
        }
    }

        
    /// <summary>
    /// Identifying information for this item, assigned according to a standard system.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Standard_ Item Identification. Item Identification
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Standard
    /// <para />PropertyTerm: Item Identification
    /// <para />AssociatedObjectClass: Item Identification
    /// <para />RepresentationTerm: Item Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemIdentificationType StandardItemIdentification
    {
        get
        {
            if (__StandardItemIdentification == null) { __StandardItemIdentification = new ItemIdentificationType(); }
            return __StandardItemIdentification;
        }
        set
        {
            __StandardItemIdentification = value;
        }
    }

        
    /// <summary>
    /// Identifying information for this item, assigned according to a cataloguing system.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Catalogue_ Item Identification. Item Identification
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Catalogue
    /// <para />PropertyTerm: Item Identification
    /// <para />AssociatedObjectClass: Item Identification
    /// <para />RepresentationTerm: Item Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemIdentificationType CatalogueItemIdentification
    {
        get
        {
            if (__CatalogueItemIdentification == null) { __CatalogueItemIdentification = new ItemIdentificationType(); }
            return __CatalogueItemIdentification;
        }
        set
        {
            __CatalogueItemIdentification = value;
        }
    }

        
    /// <summary>
    /// A reference to the catalogue in which this item appears.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Catalogue_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Catalogue
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType CatalogueDocumentReference
    {
        get
        {
            if (__CatalogueDocumentReference == null) { __CatalogueDocumentReference = new DocumentReferenceType(); }
            return __CatalogueDocumentReference;
        }
        set
        {
            __CatalogueDocumentReference = value;
        }
    }

        
    /// <summary>
    /// The country of origin of this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Origin_ Country. Country
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Origin
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CountryType OriginCountry
    {
        get
        {
            if (__OriginCountry == null) { __OriginCountry = new CountryType(); }
            return __OriginCountry;
        }
        set
        {
            __OriginCountry = value;
        }
    }

        
    /// <summary>
    /// The party responsible for specification of this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item. Information Content Provider_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item
    /// <para />PropertyTermQualifier: Information Content Provider
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType InformationContentProviderParty
    {
        get
        {
            if (__InformationContentProviderParty == null) { __InformationContentProviderParty = new PartyType(); }
            return __InformationContentProviderParty;
        }
        set
        {
            __InformationContentProviderParty = value;
        }
    }

}