using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a budget account.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Budget Account. Details
/// <para />ObjectClass: Budget Account
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("BudgetAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("BudgetAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class BudgetAccountType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BudgetYearNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NumericType @__BudgetYearNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredClassificationScheme", Order=2)]
    public ClassificationSchemeType @__RequiredClassificationScheme;
        
    /// <summary>
    /// An identifier for the budget account, typically an internal accounting reference.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Budget Account. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Budget Account
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
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
    /// The number of the year for this budget account, e.g. 2012
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Budget Account. Budget Year. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Budget Account
    /// <para />PropertyTerm: Budget Year
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType BudgetYearNumeric
    {
        get
        {
            if (__BudgetYearNumeric == null) { __BudgetYearNumeric = new NumericType(); }
            return __BudgetYearNumeric;
        }
        set
        {
            __BudgetYearNumeric = value;
        }
    }

        
    /// <summary>
    /// A classification scheme required for this budget account.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Budget Account. Required_ Classification Scheme. Classification Scheme
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Budget Account
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Classification Scheme
    /// <para />AssociatedObjectClass: Classification Scheme
    /// <para />RepresentationTerm: Classification Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ClassificationSchemeType RequiredClassificationScheme
    {
        get
        {
            if (__RequiredClassificationScheme == null) { __RequiredClassificationScheme = new ClassificationSchemeType(); }
            return __RequiredClassificationScheme;
        }
        set
        {
            __RequiredClassificationScheme = value;
        }
    }

}