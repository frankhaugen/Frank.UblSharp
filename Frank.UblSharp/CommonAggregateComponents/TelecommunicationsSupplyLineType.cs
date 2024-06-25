using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class that outlines the telecommunication supply in details
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Telecommunications Supply Line. Details
/// <para />ObjectClass: Telecommunications Supply Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TelecommunicationsSupplyLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TelecommunicationsSupplyLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TelecommunicationsSupplyLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PhoneNumber", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__PhoneNumber;
        
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__LineExtensionAmount;
        
    private System.Collections.Generic.List<ExchangeRateType> _exchangeRate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Order=4)]
    public ExchangeRateType[] @__ExchangeRate
    {
        get
        {
            return _exchangeRate?.ToArray();
        }
        set
        {
            _exchangeRate = value == null ? null : new System.Collections.Generic.List<ExchangeRateType>(value);
        }
    }
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=5)]
    public AllowanceChargeType[] @__AllowanceCharge
    {
        get
        {
            return _allowanceCharge?.ToArray();
        }
        set
        {
            _allowanceCharge = value == null ? null : new System.Collections.Generic.List<AllowanceChargeType>(value);
        }
    }
        
    private System.Collections.Generic.List<TaxTotalType> _taxTotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=6)]
    public TaxTotalType[] @__TaxTotal
    {
        get
        {
            return _taxTotal?.ToArray();
        }
        set
        {
            _taxTotal = value == null ? null : new System.Collections.Generic.List<TaxTotalType>(value);
        }
    }
        
    private System.Collections.Generic.List<TelecommunicationsServiceType> _telecommunicationsService;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsService", Order=7)]
    public TelecommunicationsServiceType[] @__TelecommunicationsService
    {
        get
        {
            return _telecommunicationsService?.ToArray();
        }
        set
        {
            _telecommunicationsService = value == null ? null : new System.Collections.Generic.List<TelecommunicationsServiceType>(value);
        }
    }
        
    /// <summary>
    /// The description of the telecommunication supply line
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Additional informations</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Exchanges rates used to calculate the amount for this line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Exchange Rate
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Exchange Rate
    /// <para />AssociatedObjectClass: Exchange Rate
    /// <para />RepresentationTerm: Exchange Rate
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ExchangeRateType> ExchangeRate
    {
        get { return _exchangeRate ?? (_exchangeRate = new System.Collections.Generic.List<ExchangeRateType>()); }
        set { _exchangeRate = value; }
    }

        
    /// <summary>
    /// An allowance or charge that applies to this telecommunication supply line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AllowanceChargeType> AllowanceCharge
    {
        get { return _allowanceCharge ?? (_allowanceCharge = new System.Collections.Generic.List<AllowanceChargeType>()); }
        set { _allowanceCharge = value; }
    }

        
    /// <summary>
    /// A total amount of taxes of a particular kind applicable to this telecommunications supply line
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Tax Total
    /// <para />AssociatedObjectClass: Tax Total
    /// <para />RepresentationTerm: Tax Total
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TaxTotalType> TaxTotal
    {
        get { return _taxTotal ?? (_taxTotal = new System.Collections.Generic.List<TaxTotalType>()); }
        set { _taxTotal = value; }
    }

        
    /// <summary>
    /// A telecommunications service (e.g., a telephone call).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Telecommunications Service
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Telecommunications Service
    /// <para />AssociatedObjectClass: Telecommunications Service
    /// <para />RepresentationTerm: Telecommunications Service
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TelecommunicationsServiceType> TelecommunicationsService
    {
        get { return _telecommunicationsService ?? (_telecommunicationsService = new System.Collections.Generic.List<TelecommunicationsServiceType>()); }
        set { _telecommunicationsService = value; }
    }

        
    /// <summary>
    /// An identifier for this telecommunications supply line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1</example>
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
    /// The phone number used for this telecommunication supply line
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Phone Number. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Phone Number
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>12345678</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PhoneNumber
    {
        get
        {
            if (__PhoneNumber == null) { __PhoneNumber = new TextType(); }
            return __PhoneNumber;
        }
        set
        {
            __PhoneNumber = value;
        }
    }

        
    /// <summary>
    /// An amount specifying the cost of this telecommunication line
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply Line. Line Extension Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Supply Line
    /// <para />PropertyTerm: Line Extension Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType LineExtensionAmount
    {
        get
        {
            if (__LineExtensionAmount == null) { __LineExtensionAmount = new AmountType(); }
            return __LineExtensionAmount;
        }
        set
        {
            __LineExtensionAmount = value;
        }
    }

}