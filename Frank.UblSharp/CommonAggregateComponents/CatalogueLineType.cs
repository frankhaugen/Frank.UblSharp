using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Catalogue describing a purchasable item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Catalogue Line. Details
/// <para />ObjectClass: Catalogue Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CatalogueLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ActionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LifeCycleStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__LifeCycleStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractSubdivision", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__ContractSubdivision;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__Note
    {
        get
        {
            return _note?.ToArray();
        }
        set
        {
            _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderableIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IndicatorType @__OrderableIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderableUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__OrderableUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContentUnitQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public QuantityType @__ContentUnitQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderQuantityIncrementNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public NumericType @__OrderQuantityIncrementNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumOrderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__MinimumOrderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumOrderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public QuantityType @__MaximumOrderQuantity;
        
    private System.Collections.Generic.List<TextType> _warrantyInformation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType[] @__WarrantyInformation
    {
        get
        {
            return _warrantyInformation?.ToArray();
        }
        set
        {
            _warrantyInformation = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public CodeType @__PackLevelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractorCustomerParty", Order=13)]
    public CustomerPartyType @__ContractorCustomerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Order=14)]
    public SupplierPartyType @__SellerSupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyParty", Order=15)]
    public PartyType @__WarrantyParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyValidityPeriod", Order=16)]
    public PeriodType @__WarrantyValidityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineValidityPeriod", Order=17)]
    public PeriodType @__LineValidityPeriod;
        
    private System.Collections.Generic.List<ItemComparisonType> _itemComparison;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemComparison", Order=18)]
    public ItemComparisonType[] @__ItemComparison
    {
        get
        {
            return _itemComparison?.ToArray();
        }
        set
        {
            _itemComparison = value == null ? null : new System.Collections.Generic.List<ItemComparisonType>(value);
        }
    }
        
    private System.Collections.Generic.List<RelatedItemType> _componentRelatedItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ComponentRelatedItem", Order=19)]
    public RelatedItemType[] @__ComponentRelatedItem
    {
        get
        {
            return _componentRelatedItem?.ToArray();
        }
        set
        {
            _componentRelatedItem = value == null ? null : new System.Collections.Generic.List<RelatedItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<RelatedItemType> _accessoryRelatedItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccessoryRelatedItem", Order=20)]
    public RelatedItemType[] @__AccessoryRelatedItem
    {
        get
        {
            return _accessoryRelatedItem?.ToArray();
        }
        set
        {
            _accessoryRelatedItem = value == null ? null : new System.Collections.Generic.List<RelatedItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<RelatedItemType> _requiredRelatedItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredRelatedItem", Order=21)]
    public RelatedItemType[] @__RequiredRelatedItem
    {
        get
        {
            return _requiredRelatedItem?.ToArray();
        }
        set
        {
            _requiredRelatedItem = value == null ? null : new System.Collections.Generic.List<RelatedItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<RelatedItemType> _replacementRelatedItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem", Order=22)]
    public RelatedItemType[] @__ReplacementRelatedItem
    {
        get
        {
            return _replacementRelatedItem?.ToArray();
        }
        set
        {
            _replacementRelatedItem = value == null ? null : new System.Collections.Generic.List<RelatedItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<RelatedItemType> _complementaryRelatedItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ComplementaryRelatedItem", Order=23)]
    public RelatedItemType[] @__ComplementaryRelatedItem
    {
        get
        {
            return _complementaryRelatedItem?.ToArray();
        }
        set
        {
            _complementaryRelatedItem = value == null ? null : new System.Collections.Generic.List<RelatedItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<RelatedItemType> _replacedRelatedItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReplacedRelatedItem", Order=24)]
    public RelatedItemType[] @__ReplacedRelatedItem
    {
        get
        {
            return _replacedRelatedItem?.ToArray();
        }
        set
        {
            _replacedRelatedItem = value == null ? null : new System.Collections.Generic.List<RelatedItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<ItemLocationQuantityType> _requiredItemLocationQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity", Order=25)]
    public ItemLocationQuantityType[] @__RequiredItemLocationQuantity
    {
        get
        {
            return _requiredItemLocationQuantity?.ToArray();
        }
        set
        {
            _requiredItemLocationQuantity = value == null ? null : new System.Collections.Generic.List<ItemLocationQuantityType>(value);
        }
    }
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=26)]
    public DocumentReferenceType[] @__DocumentReference
    {
        get
        {
            return _documentReference?.ToArray();
        }
        set
        {
            _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=27)]
    public ItemType @__Item;
        
    private System.Collections.Generic.List<ItemPropertyType> _keywordItemProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("KeywordItemProperty", Order=28)]
    public ItemPropertyType[] @__KeywordItemProperty
    {
        get
        {
            return _keywordItemProperty?.ToArray();
        }
        set
        {
            _keywordItemProperty = value == null ? null : new System.Collections.Generic.List<ItemPropertyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallForTendersLineReference", Order=29)]
    public LineReferenceType @__CallForTendersLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallForTendersDocumentReference", Order=30)]
    public DocumentReferenceType @__CallForTendersDocumentReference;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// Text about a warranty (provided by WarrantyParty) for the good or service described in this catalogue line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Warranty_ Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Warranty
    /// <para />PropertyTerm: Information
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Unless specified otherwise and in addition to any rights the Customer may have under statute, Dell warrants to the Customer that Dell branded Products (excluding third party products and software), will be free from defects in materials and workmanship affecting normal use for a period of one year from invoice date ( Standard Warranty ).</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> WarrantyInformation
    {
        get { return _warrantyInformation ?? (_warrantyInformation = new System.Collections.Generic.List<TextType>()); }
        set { _warrantyInformation = value; }
    }

        
    /// <summary>
    /// A combination of price and quantity used to provide price comparisons based on different sizes of order.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Item Comparison
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Item Comparison
    /// <para />AssociatedObjectClass: Item Comparison
    /// <para />RepresentationTerm: Item Comparison
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemComparisonType> ItemComparison
    {
        get { return _itemComparison ?? (_itemComparison = new System.Collections.Generic.List<ItemComparisonType>()); }
        set { _itemComparison = value; }
    }

        
    /// <summary>
    /// An item that may be a component of the item in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Component_ Related Item. Related Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Component
    /// <para />PropertyTerm: Related Item
    /// <para />AssociatedObjectClass: Related Item
    /// <para />RepresentationTerm: Related Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RelatedItemType> ComponentRelatedItem
    {
        get { return _componentRelatedItem ?? (_componentRelatedItem = new System.Collections.Generic.List<RelatedItemType>()); }
        set { _componentRelatedItem = value; }
    }

        
    /// <summary>
    /// An item that may be an optional accessory of the item in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Accessory_ Related Item. Related Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Accessory
    /// <para />PropertyTerm: Related Item
    /// <para />AssociatedObjectClass: Related Item
    /// <para />RepresentationTerm: Related Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RelatedItemType> AccessoryRelatedItem
    {
        get { return _accessoryRelatedItem ?? (_accessoryRelatedItem = new System.Collections.Generic.List<RelatedItemType>()); }
        set { _accessoryRelatedItem = value; }
    }

        
    /// <summary>
    /// An item that may be required for the item in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Required_ Related Item. Related Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Related Item
    /// <para />AssociatedObjectClass: Related Item
    /// <para />RepresentationTerm: Related Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RelatedItemType> RequiredRelatedItem
    {
        get { return _requiredRelatedItem ?? (_requiredRelatedItem = new System.Collections.Generic.List<RelatedItemType>()); }
        set { _requiredRelatedItem = value; }
    }

        
    /// <summary>
    /// An item that may be a replacement for the item in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Replacement_ Related Item. Related Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Replacement
    /// <para />PropertyTerm: Related Item
    /// <para />AssociatedObjectClass: Related Item
    /// <para />RepresentationTerm: Related Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RelatedItemType> ReplacementRelatedItem
    {
        get { return _replacementRelatedItem ?? (_replacementRelatedItem = new System.Collections.Generic.List<RelatedItemType>()); }
        set { _replacementRelatedItem = value; }
    }

        
    /// <summary>
    /// An item that may complement the item in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Complementary_ Related Item. Related Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Complementary
    /// <para />PropertyTerm: Related Item
    /// <para />AssociatedObjectClass: Related Item
    /// <para />RepresentationTerm: Related Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RelatedItemType> ComplementaryRelatedItem
    {
        get { return _complementaryRelatedItem ?? (_complementaryRelatedItem = new System.Collections.Generic.List<RelatedItemType>()); }
        set { _complementaryRelatedItem = value; }
    }

        
    /// <summary>
    /// An item in an existing catalogue that is being replaced by the item in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Replaced_ Related Item. Related Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Replaced
    /// <para />PropertyTerm: Related Item
    /// <para />AssociatedObjectClass: Related Item
    /// <para />RepresentationTerm: Related Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RelatedItemType> ReplacedRelatedItem
    {
        get { return _replacedRelatedItem ?? (_replacedRelatedItem = new System.Collections.Generic.List<RelatedItemType>()); }
        set { _replacedRelatedItem = value; }
    }

        
    /// <summary>
    /// Properties of the item in this catalogue line that are dependent on location and quantity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Required_ Item Location Quantity. Item Location Quantity
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Item Location Quantity
    /// <para />AssociatedObjectClass: Item Location Quantity
    /// <para />RepresentationTerm: Item Location Quantity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemLocationQuantityType> RequiredItemLocationQuantity
    {
        get { return _requiredItemLocationQuantity ?? (_requiredItemLocationQuantity = new System.Collections.Generic.List<ItemLocationQuantityType>()); }
        set { _requiredItemLocationQuantity = value; }
    }

        
    /// <summary>
    /// A reference to a document associated with this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
    {
        get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _documentReference = value; }
    }

        
    /// <summary>
    /// A property of the item in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Keyword_ Item Property. Item Property
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Keyword
    /// <para />PropertyTerm: Item Property
    /// <para />AssociatedObjectClass: Item Property
    /// <para />RepresentationTerm: Item Property
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemPropertyType> KeywordItemProperty
    {
        get { return _keywordItemProperty ?? (_keywordItemProperty = new System.Collections.Generic.List<ItemPropertyType>()); }
        set { _keywordItemProperty = value; }
    }

        
    /// <summary>
    /// An identifier for the line in the catalogue.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the action required to synchronize this catalogue line. Recommend codes (delete, update, add)
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Action Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Action Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Replace , Update , Delete , Add</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ActionCode
    {
        get
        {
            if (__ActionCode == null) { __ActionCode = new CodeType(); }
            return __ActionCode;
        }
        set
        {
            __ActionCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the life cycle status of this catalogue line. Examples are pre-order, end of production
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Life Cycle Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Life Cycle Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>new - announcement only , new and available , deleted - announcement only</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LifeCycleStatusCode
    {
        get
        {
            if (__LifeCycleStatusCode == null) { __LifeCycleStatusCode = new CodeType(); }
            return __LifeCycleStatusCode;
        }
        set
        {
            __LifeCycleStatusCode = value;
        }
    }

        
    /// <summary>
    /// A subdivision of a contract or tender covering this catalogue line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Contract Subdivision. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Contract Subdivision
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Installation , Phase One , Support and Maintenance</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ContractSubdivision
    {
        get
        {
            if (__ContractSubdivision == null) { __ContractSubdivision = new TextType(); }
            return __ContractSubdivision;
        }
        set
        {
            __ContractSubdivision = value;
        }
    }

        
    /// <summary>
    /// An indicator that this catalogue line describes an orderable item (true) or is included for reference purposes only (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Orderable_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Orderable
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    /// <example>TRUE means orderable, FALSE means not orderable</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType OrderableIndicator
    {
        get
        {
            if (__OrderableIndicator == null) { __OrderableIndicator = new IndicatorType(); }
            return __OrderableIndicator;
        }
        set
        {
            __OrderableIndicator = value;
        }
    }

        
    /// <summary>
    /// A textual description of the units in which the item described in this catalogue line can be ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Orderable_ Unit. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Orderable
    /// <para />PropertyTerm: Unit
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType OrderableUnit
    {
        get
        {
            if (__OrderableUnit == null) { __OrderableUnit = new TextType(); }
            return __OrderableUnit;
        }
        set
        {
            __OrderableUnit = value;
        }
    }

        
    /// <summary>
    /// The numeric quantity of the ordering unit (and units of measure) of the catalogue line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Content Unit. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Content Unit
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>If order unit measure identifier is each , then content unit quantity is 1 .</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ContentUnitQuantity
    {
        get
        {
            if (__ContentUnitQuantity == null) { __ContentUnitQuantity = new QuantityType(); }
            return __ContentUnitQuantity;
        }
        set
        {
            __ContentUnitQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of items that can set the order quantity increments.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Order Quantity Increment. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Order Quantity Increment
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType OrderQuantityIncrementNumeric
    {
        get
        {
            if (__OrderQuantityIncrementNumeric == null) { __OrderQuantityIncrementNumeric = new NumericType(); }
            return __OrderQuantityIncrementNumeric;
        }
        set
        {
            __OrderQuantityIncrementNumeric = value;
        }
    }

        
    /// <summary>
    /// The minimum amount of the item described in this catalogue line that can be ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Minimum_ Order Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Order Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>10 boxes</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumOrderQuantity
    {
        get
        {
            if (__MinimumOrderQuantity == null) { __MinimumOrderQuantity = new QuantityType(); }
            return __MinimumOrderQuantity;
        }
        set
        {
            __MinimumOrderQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum amount of the item described in this catalogue line that can be ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Maximum_ Order Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Order Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>1 tonne</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumOrderQuantity
    {
        get
        {
            if (__MaximumOrderQuantity == null) { __MaximumOrderQuantity = new QuantityType(); }
            return __MaximumOrderQuantity;
        }
        set
        {
            __MaximumOrderQuantity = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code signifying the level of packaging associated with the item described in this catalogue line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Line. Pack Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Pack Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Consumer Unit, Trading Unit
    /// </summary>
    /// <example>level 2 , Group 4</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PackLevelCode
    {
        get
        {
            if (__PackLevelCode == null) { __PackLevelCode = new CodeType(); }
            return __PackLevelCode;
        }
        set
        {
            __PackLevelCode = value;
        }
    }

        
    /// <summary>
    /// The customer responsible for the contract with which this catalogue line is associated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Contractor_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Contractor
    /// <para />PropertyTerm: Customer Party
    /// <para />AssociatedObjectClass: Customer Party
    /// <para />RepresentationTerm: Customer Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CustomerPartyType ContractorCustomerParty
    {
        get
        {
            if (__ContractorCustomerParty == null) { __ContractorCustomerParty = new CustomerPartyType(); }
            return __ContractorCustomerParty;
        }
        set
        {
            __ContractorCustomerParty = value;
        }
    }

        
    /// <summary>
    /// The seller/supplier responsible for the contract with which this catalogue line is associated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Seller_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Seller
    /// <para />PropertyTerm: Supplier Party
    /// <para />AssociatedObjectClass: Supplier Party
    /// <para />RepresentationTerm: Supplier Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SupplierPartyType SellerSupplierParty
    {
        get
        {
            if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
            return __SellerSupplierParty;
        }
        set
        {
            __SellerSupplierParty = value;
        }
    }

        
    /// <summary>
    /// The party responsible for any warranty associated with the item described in this catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Warranty_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Warranty
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType WarrantyParty
    {
        get
        {
            if (__WarrantyParty == null) { __WarrantyParty = new PartyType(); }
            return __WarrantyParty;
        }
        set
        {
            __WarrantyParty = value;
        }
    }

        
    /// <summary>
    /// The period for which a warranty associated with the item in this catalogue line is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Warranty Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Warranty Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType WarrantyValidityPeriod
    {
        get
        {
            if (__WarrantyValidityPeriod == null) { __WarrantyValidityPeriod = new PeriodType(); }
            return __WarrantyValidityPeriod;
        }
        set
        {
            __WarrantyValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// The period for which the information in this catalogue line is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Line Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Line Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType LineValidityPeriod
    {
        get
        {
            if (__LineValidityPeriod == null) { __LineValidityPeriod = new PeriodType(); }
            return __LineValidityPeriod;
        }
        set
        {
            __LineValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// A specification of the item itself.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemType Item
    {
        get
        {
            if (__Item == null) { __Item = new ItemType(); }
            return __Item;
        }
        set
        {
            __Item = value;
        }
    }

        
    /// <summary>
    /// Reference to a Line on a Call For Tenders document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Call For Tenders_ Line Reference. Line Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Call For Tenders
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineReferenceType CallForTendersLineReference
    {
        get
        {
            if (__CallForTendersLineReference == null) { __CallForTendersLineReference = new LineReferenceType(); }
            return __CallForTendersLineReference;
        }
        set
        {
            __CallForTendersLineReference = value;
        }
    }

        
    /// <summary>
    /// A class defining references to a Call For Tenders document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Line. Call For Tenders_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Line
    /// <para />PropertyTermQualifier: Call For Tenders
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType CallForTendersDocumentReference
    {
        get
        {
            if (__CallForTendersDocumentReference == null) { __CallForTendersDocumentReference = new DocumentReferenceType(); }
            return __CallForTendersDocumentReference;
        }
        set
        {
            __CallForTendersDocumentReference = value;
        }
    }

}