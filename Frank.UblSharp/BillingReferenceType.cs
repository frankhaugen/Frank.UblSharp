/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class BillingReferenceType
{
    private DocumentReferenceType creditNoteDocumentReferenceField;
    private DocumentReferenceType selfBilledCreditNoteDocumentReferenceField;
    private DocumentReferenceType debitNoteDocumentReferenceField;
    private DocumentReferenceType reminderDocumentReferenceField;
    private DocumentReferenceType additionalDocumentReferenceField;
    private BillingReferenceLineType[] billingReferenceLineField;
    /// <remarks/>
    public DocumentReferenceType InvoiceDocumentReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType SelfBilledInvoiceDocumentReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType CreditNoteDocumentReference
    {
        get
        {
            return this.creditNoteDocumentReferenceField;
        }

        set
        {
            this.creditNoteDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    public DocumentReferenceType SelfBilledCreditNoteDocumentReference
    {
        get
        {
            return this.selfBilledCreditNoteDocumentReferenceField;
        }

        set
        {
            this.selfBilledCreditNoteDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    public DocumentReferenceType DebitNoteDocumentReference
    {
        get
        {
            return this.debitNoteDocumentReferenceField;
        }

        set
        {
            this.debitNoteDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    public DocumentReferenceType ReminderDocumentReference
    {
        get
        {
            return this.reminderDocumentReferenceField;
        }

        set
        {
            this.reminderDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    public DocumentReferenceType AdditionalDocumentReference
    {
        get
        {
            return this.additionalDocumentReferenceField;
        }

        set
        {
            this.additionalDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BillingReferenceLine")]
    public BillingReferenceLineType[] BillingReferenceLine
    {
        get
        {
            return this.billingReferenceLineField;
        }

        set
        {
            this.billingReferenceLineField = value;
        }
    }
}