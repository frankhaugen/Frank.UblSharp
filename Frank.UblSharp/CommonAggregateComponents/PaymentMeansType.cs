using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a means of payment.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Payment Means. Details
/// <para />ObjectClass: Payment Means
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PaymentMeansType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentMeansCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__PaymentMeansCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentDueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__PaymentDueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentChannelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__PaymentChannelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InstructionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__InstructionID;
        
    private System.Collections.Generic.List<TextType> _instructionNote;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__InstructionNote
    {
        get
        {
            return _instructionNote?.ToArray();
        }
        set
        {
            _instructionNote = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<IdentifierType> _paymentID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IdentifierType[] @__PaymentID
    {
        get
        {
            return _paymentID?.ToArray();
        }
        set
        {
            _paymentID = value == null ? null : new System.Collections.Generic.List<IdentifierType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CardAccount", Order=7)]
    public CardAccountType @__CardAccount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayerFinancialAccount", Order=8)]
    public FinancialAccountType @__PayerFinancialAccount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayeeFinancialAccount", Order=9)]
    public FinancialAccountType @__PayeeFinancialAccount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CreditAccount", Order=10)]
    public CreditAccountType @__CreditAccount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentMandate", Order=11)]
    public PaymentMandateType @__PaymentMandate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TradeFinancing", Order=12)]
    public TradeFinancingType @__TradeFinancing;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Means. Instruction_ Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTermQualifier: Instruction
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> InstructionNote
    {
        get { return _instructionNote ?? (_instructionNote = new System.Collections.Generic.List<TextType>()); }
        set { _instructionNote = value; }
    }

        
    /// <summary>
    /// An identifier for a payment made using this means of payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Means. Payment Identifier. Identifier
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Payment Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<IdentifierType> PaymentID
    {
        get { return _paymentID ?? (_paymentID = new System.Collections.Generic.List<IdentifierType>()); }
        set { _paymentID = value; }
    }

        
    /// <summary>
    /// An identifier for this means of payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Means. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
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
    /// A code signifying the type of this means of payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Means. Payment Means Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Payment Means Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Payment Means
    /// <para />DataType: Payment Means_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PaymentMeansCode
    {
        get
        {
            if (__PaymentMeansCode == null) { __PaymentMeansCode = new CodeType(); }
            return __PaymentMeansCode;
        }
        set
        {
            __PaymentMeansCode = value;
        }
    }

        
    /// <summary>
    /// The date on which payment is due for this means of payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Means. Payment Due Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Payment Due Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType PaymentDueDate
    {
        get
        {
            if (__PaymentDueDate == null) { __PaymentDueDate = new DateType(); }
            return __PaymentDueDate;
        }
        set
        {
            __PaymentDueDate = value;
        }
    }

        
    /// <summary>
    /// A code signifying the payment channel for this means of payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Means. Payment Channel Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Payment Channel Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PaymentChannelCode
    {
        get
        {
            if (__PaymentChannelCode == null) { __PaymentChannelCode = new CodeType(); }
            return __PaymentChannelCode;
        }
        set
        {
            __PaymentChannelCode = value;
        }
    }

        
    /// <summary>
    /// An identifier for the payment instruction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Means. Instruction Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Instruction Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType InstructionID
    {
        get
        {
            if (__InstructionID == null) { __InstructionID = new IdentifierType(); }
            return __InstructionID;
        }
        set
        {
            __InstructionID = value;
        }
    }

        
    /// <summary>
    /// A credit card, debit card, or charge card account that constitutes this means of payment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Means. Card Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Card Account
    /// <para />AssociatedObjectClass: Card Account
    /// <para />RepresentationTerm: Card Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CardAccountType CardAccount
    {
        get
        {
            if (__CardAccount == null) { __CardAccount = new CardAccountType(); }
            return __CardAccount;
        }
        set
        {
            __CardAccount = value;
        }
    }

        
    /// <summary>
    /// The payer&apos;s financial account.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Means. Payer_ Financial Account. Financial Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTermQualifier: Payer
    /// <para />PropertyTerm: Financial Account
    /// <para />AssociatedObjectClass: Financial Account
    /// <para />RepresentationTerm: Financial Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public FinancialAccountType PayerFinancialAccount
    {
        get
        {
            if (__PayerFinancialAccount == null) { __PayerFinancialAccount = new FinancialAccountType(); }
            return __PayerFinancialAccount;
        }
        set
        {
            __PayerFinancialAccount = value;
        }
    }

        
    /// <summary>
    /// The payee&apos;s financial account.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Means. Payee_ Financial Account. Financial Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTermQualifier: Payee
    /// <para />PropertyTerm: Financial Account
    /// <para />AssociatedObjectClass: Financial Account
    /// <para />RepresentationTerm: Financial Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public FinancialAccountType PayeeFinancialAccount
    {
        get
        {
            if (__PayeeFinancialAccount == null) { __PayeeFinancialAccount = new FinancialAccountType(); }
            return __PayeeFinancialAccount;
        }
        set
        {
            __PayeeFinancialAccount = value;
        }
    }

        
    /// <summary>
    /// A credit account associated with this means of payment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Means. Credit Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Credit Account
    /// <para />AssociatedObjectClass: Credit Account
    /// <para />RepresentationTerm: Credit Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CreditAccountType CreditAccount
    {
        get
        {
            if (__CreditAccount == null) { __CreditAccount = new CreditAccountType(); }
            return __CreditAccount;
        }
        set
        {
            __CreditAccount = value;
        }
    }

        
    /// <summary>
    /// The payment mandate associated with this means of payment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Means. Payment Mandate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Payment Mandate
    /// <para />AssociatedObjectClass: Payment Mandate
    /// <para />RepresentationTerm: Payment Mandate
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentMandateType PaymentMandate
    {
        get
        {
            if (__PaymentMandate == null) { __PaymentMandate = new PaymentMandateType(); }
            return __PaymentMandate;
        }
        set
        {
            __PaymentMandate = value;
        }
    }

        
    /// <summary>
    /// A trade finance agreement applicable to this means of payment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Means. Trade Financing
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Means
    /// <para />PropertyTerm: Trade Financing
    /// <para />AssociatedObjectClass: Trade Financing
    /// <para />RepresentationTerm: Trade Financing
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TradeFinancingType TradeFinancing
    {
        get
        {
            if (__TradeFinancing == null) { __TradeFinancing = new TradeFinancingType(); }
            return __TradeFinancing;
        }
        set
        {
            __TradeFinancing = value;
        }
    }

}