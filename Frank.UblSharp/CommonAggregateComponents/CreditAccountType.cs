using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to identify a credit account for sales on account.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Credit Account. Details
/// <para />ObjectClass: Credit Account
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CreditAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CreditAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CreditAccountType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__AccountID;
        
    /// <summary>
    /// An identifier for this credit account.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Account. Account Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Credit Account
    /// <para />PropertyTerm: Account Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>Customer Code 29</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType AccountID
    {
        get
        {
            if (__AccountID == null) { __AccountID = new IdentifierType(); }
            return __AccountID;
        }
        set
        {
            __AccountID = value;
        }
    }

}