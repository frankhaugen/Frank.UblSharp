using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the completion of a specific task in the tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Completed Task. Details
/// <para />ObjectClass: Completed Task
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CompletedTask", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CompletedTask", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CompletedTaskType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AnnualAverageAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__AnnualAverageAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalTaskAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__TotalTaskAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartyCapacityAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__PartyCapacityAmount;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
        
    private System.Collections.Generic.List<EvidenceSuppliedType> _evidenceSupplied;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EvidenceSupplied", Order=4)]
    public EvidenceSuppliedType[] @__EvidenceSupplied
    {
        get
        {
            return _evidenceSupplied?.ToArray();
        }
        set
        {
            _evidenceSupplied = value == null ? null : new System.Collections.Generic.List<EvidenceSuppliedType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=5)]
    public PeriodType @__Period;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RecipientCustomerParty", Order=6)]
    public CustomerPartyType @__RecipientCustomerParty;
        
    /// <summary>
    /// Text describing this completed task.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Completed Task. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Completed Task
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
    /// The evidence justifying a designation of &quot;complete&quot; for this task.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Completed Task. Evidence Supplied
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Completed Task
    /// <para />PropertyTerm: Evidence Supplied
    /// <para />AssociatedObjectClass: Evidence Supplied
    /// <para />RepresentationTerm: Evidence Supplied
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EvidenceSuppliedType> EvidenceSupplied
    {
        get { return _evidenceSupplied ?? (_evidenceSupplied = new System.Collections.Generic.List<EvidenceSuppliedType>()); }
        set { _evidenceSupplied = value; }
    }

        
    /// <summary>
    /// The average monetary amount of a task such as this completed task.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Completed Task. Annual_ Average. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Completed Task
    /// <para />PropertyTermQualifier: Annual
    /// <para />PropertyTerm: Average
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType AnnualAverageAmount
    {
        get
        {
            if (__AnnualAverageAmount == null) { __AnnualAverageAmount = new AmountType(); }
            return __AnnualAverageAmount;
        }
        set
        {
            __AnnualAverageAmount = value;
        }
    }

        
    /// <summary>
    /// The actual total monetary amount of this completed task.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Completed Task. Total Task. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Completed Task
    /// <para />PropertyTerm: Total Task
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TotalTaskAmount
    {
        get
        {
            if (__TotalTaskAmount == null) { __TotalTaskAmount = new AmountType(); }
            return __TotalTaskAmount;
        }
        set
        {
            __TotalTaskAmount = value;
        }
    }

        
    /// <summary>
    /// A monetary amount corresponding to the financial capacity of the party that carried out this completed task.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Completed Task. Party Capacity. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Completed Task
    /// <para />PropertyTerm: Party Capacity
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PartyCapacityAmount
    {
        get
        {
            if (__PartyCapacityAmount == null) { __PartyCapacityAmount = new AmountType(); }
            return __PartyCapacityAmount;
        }
        set
        {
            __PartyCapacityAmount = value;
        }
    }

        
    /// <summary>
    /// The period in which this completed task was performed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Completed Task. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Completed Task
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType Period
    {
        get
        {
            if (__Period == null) { __Period = new PeriodType(); }
            return __Period;
        }
        set
        {
            __Period = value;
        }
    }

        
    /// <summary>
    /// The original customer for this completed task.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Completed Task. Recipient_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Completed Task
    /// <para />PropertyTermQualifier: Recipient
    /// <para />PropertyTerm: Customer Party
    /// <para />AssociatedObjectClass: Customer Party
    /// <para />RepresentationTerm: Customer Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CustomerPartyType RecipientCustomerParty
    {
        get
        {
            if (__RecipientCustomerParty == null) { __RecipientCustomerParty = new CustomerPartyType(); }
            return __RecipientCustomerParty;
        }
        set
        {
            __RecipientCustomerParty = value;
        }
    }

}