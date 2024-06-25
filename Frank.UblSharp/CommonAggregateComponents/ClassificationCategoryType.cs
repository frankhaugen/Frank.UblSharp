using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a category within a classification scheme.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Classification Category. Details
/// <para />ObjectClass: Classification Category
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CategorizesClassificationCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CategorizesClassificationCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ClassificationCategoryType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CodeValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__CodeValue;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
        
    private System.Collections.Generic.List<ClassificationCategoryType> _categorizesClassificationCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CategorizesClassificationCategory", Order=3)]
    public ClassificationCategoryType[] @__CategorizesClassificationCategory
    {
        get
        {
            return _categorizesClassificationCategory?.ToArray();
        }
        set
        {
            _categorizesClassificationCategory = value == null ? null : new System.Collections.Generic.List<ClassificationCategoryType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this category.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Category. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Classification Category
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Code Name
    /// </summary>
    /// <example>Electrical Goods , Wooden Toys</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// A recursive description of a subcategory of this category.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Classification Category. Categorizes_ Classification Category. Classification Category
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Classification Category
    /// <para />PropertyTermQualifier: Categorizes
    /// <para />PropertyTerm: Classification Category
    /// <para />AssociatedObjectClass: Classification Category
    /// <para />RepresentationTerm: Classification Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ClassificationCategoryType> CategorizesClassificationCategory
    {
        get { return _categorizesClassificationCategory ?? (_categorizesClassificationCategory = new System.Collections.Generic.List<ClassificationCategoryType>()); }
        set { _categorizesClassificationCategory = value; }
    }

        
    /// <summary>
    /// The name of this category within the classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Category. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Category
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// <para />AlternativeBusinessTerms: Code List Name
    /// </summary>
    /// <example>UNSPSC Class , UNSPSC Segment , UNSPSC Family</example>
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
    /// The value of a code used to identify this category within the classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Category. Code Value. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Category
    /// <para />PropertyTerm: Code Value
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Code Value
    /// </summary>
    /// <example>3420001, 3273666, HSJJD-213</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CodeValue
    {
        get
        {
            if (__CodeValue == null) { __CodeValue = new TextType(); }
            return __CodeValue;
        }
        set
        {
            __CodeValue = value;
        }
    }

}