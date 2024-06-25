namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to a billing document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Billing Reference. Details
/// <para />ObjectClass: Billing Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class BillingReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoiceDocumentReference", Order=0)]
    public DocumentReferenceType @__InvoiceDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SelfBilledInvoiceDocumentReference", Order=1)]
    public DocumentReferenceType @__SelfBilledInvoiceDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CreditNoteDocumentReference", Order=2)]
    public DocumentReferenceType @__CreditNoteDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SelfBilledCreditNoteDocumentReference", Order=3)]
    public DocumentReferenceType @__SelfBilledCreditNoteDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DebitNoteDocumentReference", Order=4)]
    public DocumentReferenceType @__DebitNoteDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReminderDocumentReference", Order=5)]
    public DocumentReferenceType @__ReminderDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Order=6)]
    public DocumentReferenceType @__AdditionalDocumentReference;
        
    private System.Collections.Generic.List<BillingReferenceLineType> _billingReferenceLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BillingReferenceLine", Order=7)]
    public BillingReferenceLineType[] @__BillingReferenceLine
    {
        get
        {
            return _billingReferenceLine?.ToArray();
        }
        set
        {
            _billingReferenceLine = value == null ? null : new System.Collections.Generic.List<BillingReferenceLineType>(value);
        }
    }
        
    /// <summary>
    /// A reference to a transaction line in the billing document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Billing Reference Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTerm: Billing Reference Line
    /// <para />AssociatedObjectClass: Billing Reference Line
    /// <para />RepresentationTerm: Billing Reference Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<BillingReferenceLineType> BillingReferenceLine
    {
        get { return _billingReferenceLine ?? (_billingReferenceLine = new System.Collections.Generic.List<BillingReferenceLineType>()); }
        set { _billingReferenceLine = value; }
    }

        
    /// <summary>
    /// A reference to an invoice.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Invoice_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTermQualifier: Invoice
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType InvoiceDocumentReference
    {
        get
        {
            if (__InvoiceDocumentReference == null) { __InvoiceDocumentReference = new DocumentReferenceType(); }
            return __InvoiceDocumentReference;
        }
        set
        {
            __InvoiceDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a self billed invoice.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Self Billed Invoice_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTermQualifier: Self Billed Invoice
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType SelfBilledInvoiceDocumentReference
    {
        get
        {
            if (__SelfBilledInvoiceDocumentReference == null) { __SelfBilledInvoiceDocumentReference = new DocumentReferenceType(); }
            return __SelfBilledInvoiceDocumentReference;
        }
        set
        {
            __SelfBilledInvoiceDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a credit note.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Credit Note_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTermQualifier: Credit Note
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType CreditNoteDocumentReference
    {
        get
        {
            if (__CreditNoteDocumentReference == null) { __CreditNoteDocumentReference = new DocumentReferenceType(); }
            return __CreditNoteDocumentReference;
        }
        set
        {
            __CreditNoteDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a self billed credit note.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Self Billed Credit Note_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTermQualifier: Self Billed Credit Note
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType SelfBilledCreditNoteDocumentReference
    {
        get
        {
            if (__SelfBilledCreditNoteDocumentReference == null) { __SelfBilledCreditNoteDocumentReference = new DocumentReferenceType(); }
            return __SelfBilledCreditNoteDocumentReference;
        }
        set
        {
            __SelfBilledCreditNoteDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a debit note.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Debit Note_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTermQualifier: Debit Note
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType DebitNoteDocumentReference
    {
        get
        {
            if (__DebitNoteDocumentReference == null) { __DebitNoteDocumentReference = new DocumentReferenceType(); }
            return __DebitNoteDocumentReference;
        }
        set
        {
            __DebitNoteDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a billing reminder.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Reminder_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTermQualifier: Reminder
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType ReminderDocumentReference
    {
        get
        {
            if (__ReminderDocumentReference == null) { __ReminderDocumentReference = new DocumentReferenceType(); }
            return __ReminderDocumentReference;
        }
        set
        {
            __ReminderDocumentReference = value;
        }
    }

        
    /// <summary>
    /// A reference to an additional document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Billing Reference. Additional_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Billing Reference
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType AdditionalDocumentReference
    {
        get
        {
            if (__AdditionalDocumentReference == null) { __AdditionalDocumentReference = new DocumentReferenceType(); }
            return __AdditionalDocumentReference;
        }
        set
        {
            __AdditionalDocumentReference = value;
        }
    }

}