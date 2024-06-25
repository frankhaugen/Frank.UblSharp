using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a payment.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Payment. Details
/// <para />ObjectClass: Payment
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CollectedPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CollectedPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PaymentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaidAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__PaidAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceivedDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__ReceivedDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaidDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__PaidDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaidTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__PaidTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InstructionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IdentifierType @__InstructionID;
        
    /// <summary>
    /// An identifier for this payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment
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
    /// The amount of this payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment. Paid_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment
    /// <para />PropertyTermQualifier: Paid
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PaidAmount
    {
        get
        {
            if (__PaidAmount == null) { __PaidAmount = new AmountType(); }
            return __PaidAmount;
        }
        set
        {
            __PaidAmount = value;
        }
    }

        
    /// <summary>
    /// The date on which this payment was received.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment. Received_ Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment
    /// <para />PropertyTermQualifier: Received
    /// <para />PropertyTerm: Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ReceivedDate
    {
        get
        {
            if (__ReceivedDate == null) { __ReceivedDate = new DateType(); }
            return __ReceivedDate;
        }
        set
        {
            __ReceivedDate = value;
        }
    }

        
    /// <summary>
    /// The date on which this payment was made.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment. Paid_ Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment
    /// <para />PropertyTermQualifier: Paid
    /// <para />PropertyTerm: Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType PaidDate
    {
        get
        {
            if (__PaidDate == null) { __PaidDate = new DateType(); }
            return __PaidDate;
        }
        set
        {
            __PaidDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this payment was made.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment. Paid_ Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment
    /// <para />PropertyTermQualifier: Paid
    /// <para />PropertyTerm: Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType PaidTime
    {
        get
        {
            if (__PaidTime == null) { __PaidTime = new TimeType(); }
            return __PaidTime;
        }
        set
        {
            __PaidTime = value;
        }
    }

        
    /// <summary>
    /// An identifier for the payment instruction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment. Instruction Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment
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

}