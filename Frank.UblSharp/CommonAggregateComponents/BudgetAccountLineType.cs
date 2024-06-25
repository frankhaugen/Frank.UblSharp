using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a budget account line.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Budget Account Line. Details
/// <para />ObjectClass: Budget Account Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("BudgetAccountLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("BudgetAccountLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class BudgetAccountLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__TotalAmount;
        
    private System.Collections.Generic.List<BudgetAccountType> _budgetAccount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BudgetAccount", Order=2)]
    public BudgetAccountType[] @__BudgetAccount
    {
        get
        {
            return _budgetAccount?.ToArray();
        }
        set
        {
            _budgetAccount = value == null ? null : new System.Collections.Generic.List<BudgetAccountType>(value);
        }
    }
        
    /// <summary>
    /// An account covering this budget account line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Budget Account Line. Budget Account
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Budget Account Line
    /// <para />PropertyTerm: Budget Account
    /// <para />AssociatedObjectClass: Budget Account
    /// <para />RepresentationTerm: Budget Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<BudgetAccountType> BudgetAccount
    {
        get { return _budgetAccount ?? (_budgetAccount = new System.Collections.Generic.List<BudgetAccountType>()); }
        set { _budgetAccount = value; }
    }

        
    /// <summary>
    /// An identifier for this budget account line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Budget Account Line. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Budget Account Line
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
    /// The total monetary amount for this budget account line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Budget Account Line. Total_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Budget Account Line
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TotalAmount
    {
        get
        {
            if (__TotalAmount == null) { __TotalAmount = new AmountType(); }
            return __TotalAmount;
        }
        set
        {
            __TotalAmount = value;
        }
    }

}