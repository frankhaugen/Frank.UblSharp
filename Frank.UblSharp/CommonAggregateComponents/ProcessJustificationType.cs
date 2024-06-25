using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a justification for the choice of tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Process Justification. Details
/// <para />ObjectClass: Process Justification
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ProcessJustification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ProcessJustification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ProcessJustificationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousCancellationReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__PreviousCancellationReasonCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcessReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ProcessReasonCode;
        
    private System.Collections.Generic.List<TextType> _processReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcessReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__ProcessReason
    {
        get
        {
            return _processReason?.ToArray();
        }
        set
        {
            _processReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
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
        
    /// <summary>
    /// The reason why the contracting authority has followed a particular tendering procedure for the awarding of a contract, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Process Justification. Process_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Process Justification
    /// <para />PropertyTermQualifier: Process
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ProcessReason
    {
        get { return _processReason ?? (_processReason = new System.Collections.Generic.List<TextType>()); }
        set { _processReason = value; }
    }

        
    /// <summary>
    /// Text providing justification for the selection of this process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Process Justification. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Process Justification
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
    /// A code signifying the type of the previous tendering process (which is now being cancelled).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Process Justification. Previous_ Cancellation Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Process Justification
    /// <para />PropertyTermQualifier: Previous
    /// <para />PropertyTerm: Cancellation Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PreviousCancellationReasonCode
    {
        get
        {
            if (__PreviousCancellationReasonCode == null) { __PreviousCancellationReasonCode = new CodeType(); }
            return __PreviousCancellationReasonCode;
        }
        set
        {
            __PreviousCancellationReasonCode = value;
        }
    }

        
    /// <summary>
    /// The reason why the contracting authority has followed a particular tendering procedure for the awarding of a contract, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Process Justification. Process_ Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Process Justification
    /// <para />PropertyTermQualifier: Process
    /// <para />PropertyTerm: Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ProcessReasonCode
    {
        get
        {
            if (__ProcessReasonCode == null) { __ProcessReasonCode = new CodeType(); }
            return __ProcessReasonCode;
        }
        set
        {
            __ProcessReasonCode = value;
        }
    }

}