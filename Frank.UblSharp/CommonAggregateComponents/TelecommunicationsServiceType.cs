using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a telecommunications service (e.g., a telephone call or a video on demand service).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Telecommunications Service. Details
/// <para />ObjectClass: Telecommunications Service
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TelecommunicationsService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TelecommunicationsService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TelecommunicationsServiceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__CallDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__CallTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ServiceNumberCalled", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__ServiceNumberCalled;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsServiceCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__TelecommunicationsServiceCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsServiceCategoryCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__TelecommunicationsServiceCategoryCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MovieTitle", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__MovieTitle;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RoamingPartnerName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public NameType @__RoamingPartnerName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayPerView", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType @__PayPerView;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsServiceCall", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public TextType @__TelecommunicationsServiceCall;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsServiceCallCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public CodeType @__TelecommunicationsServiceCallCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallBaseAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public AmountType @__CallBaseAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public AmountType @__CallExtensionAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Price", Order=14)]
    public PriceType @__Price;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Country", Order=15)]
    public CountryType @__Country;
        
    private System.Collections.Generic.List<ExchangeRateType> _exchangeRate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Order=16)]
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
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=17)]
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
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=18)]
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
        
    private System.Collections.Generic.List<DutyType> _callDuty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallDuty", Order=19)]
    public DutyType[] @__CallDuty
    {
        get
        {
            return _callDuty?.ToArray();
        }
        set
        {
            _callDuty = value == null ? null : new System.Collections.Generic.List<DutyType>(value);
        }
    }
        
    private System.Collections.Generic.List<DutyType> _timeDuty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TimeDuty", Order=20)]
    public DutyType[] @__TimeDuty
    {
        get
        {
            return _timeDuty?.ToArray();
        }
        set
        {
            _timeDuty = value == null ? null : new System.Collections.Generic.List<DutyType>(value);
        }
    }
        
    /// <summary>
    /// A exchanges rates used in the pricing e.g.. when phone calls has crossed border lines.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Exchange Rate
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Service
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
    /// An allowance or charge that applies to the UtilityStatement as a whole.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Service
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
    /// A total amount of taxes of a particular kind applicable to this telecommunications service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Service
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
    /// In the case of a telephone call, a duty on this call.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Call_ Duty. Duty
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTermQualifier: Call
    /// <para />PropertyTerm: Duty
    /// <para />AssociatedObjectClass: Duty
    /// <para />RepresentationTerm: Duty
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DutyType> CallDuty
    {
        get { return _callDuty ?? (_callDuty = new System.Collections.Generic.List<DutyType>()); }
        set { _callDuty = value; }
    }

        
    /// <summary>
    /// A duty on a consumption of time.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Time_ Duty. Duty
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTermQualifier: Time
    /// <para />PropertyTerm: Duty
    /// <para />AssociatedObjectClass: Duty
    /// <para />RepresentationTerm: Duty
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DutyType> TimeDuty
    {
        get { return _timeDuty ?? (_timeDuty = new System.Collections.Generic.List<DutyType>()); }
        set { _timeDuty = value; }
    }

        
    /// <summary>
    /// An identifier for this telecommunications service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
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
    /// In the case of a telephone call, the date of the call.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Call_ Date. Date
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTermQualifier: Call
    /// <para />PropertyTerm: Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    /// <example>2008-01-01</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType CallDate
    {
        get
        {
            if (__CallDate == null) { __CallDate = new DateType(); }
            return __CallDate;
        }
        set
        {
            __CallDate = value;
        }
    }

        
    /// <summary>
    /// In the case of a telephone call, the time of the call.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Call_ Time. Time
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTermQualifier: Call
    /// <para />PropertyTerm: Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    /// <example>00:01:00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType CallTime
    {
        get
        {
            if (__CallTime == null) { __CallTime = new TimeType(); }
            return __CallTime;
        }
        set
        {
            __CallTime = value;
        }
    }

        
    /// <summary>
    /// In the case of a telephone call, the phone number called.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Service Number Called. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Service Number Called
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>12345679</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ServiceNumberCalled
    {
        get
        {
            if (__ServiceNumberCalled == null) { __ServiceNumberCalled = new TextType(); }
            return __ServiceNumberCalled;
        }
        set
        {
            __ServiceNumberCalled = value;
        }
    }

        
    /// <summary>
    /// The telecommunications category, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Telecommunications Service Category. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Telecommunications Service Category
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Subscription</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TelecommunicationsServiceCategory
    {
        get
        {
            if (__TelecommunicationsServiceCategory == null) { __TelecommunicationsServiceCategory = new TextType(); }
            return __TelecommunicationsServiceCategory;
        }
        set
        {
            __TelecommunicationsServiceCategory = value;
        }
    }

        
    /// <summary>
    /// The telecommunications category, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Telecommunications Service Category Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Telecommunications Service Category Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Subscription</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TelecommunicationsServiceCategoryCode
    {
        get
        {
            if (__TelecommunicationsServiceCategoryCode == null) { __TelecommunicationsServiceCategoryCode = new CodeType(); }
            return __TelecommunicationsServiceCategoryCode;
        }
        set
        {
            __TelecommunicationsServiceCategoryCode = value;
        }
    }

        
    /// <summary>
    /// The title of a movie delivered via this telecommunications service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Movie Title. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Movie Title
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>The Matrix</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MovieTitle
    {
        get
        {
            if (__MovieTitle == null) { __MovieTitle = new TextType(); }
            return __MovieTitle;
        }
        set
        {
            __MovieTitle = value;
        }
    }

        
    /// <summary>
    /// Statement of the roaming partner name.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Roaming Partner Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Roaming Partner Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType RoamingPartnerName
    {
        get
        {
            if (__RoamingPartnerName == null) { __RoamingPartnerName = new NameType(); }
            return __RoamingPartnerName;
        }
        set
        {
            __RoamingPartnerName = value;
        }
    }

        
    /// <summary>
    /// A pay-per-view delivered via this telecommunications service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Pay Per View. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Pay Per View
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PayPerView
    {
        get
        {
            if (__PayPerView == null) { __PayPerView = new TextType(); }
            return __PayPerView;
        }
        set
        {
            __PayPerView = value;
        }
    }

        
    /// <summary>
    /// The number of calls.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>5761</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// The telecommunications call described as a text
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Telecommunications Service Call. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Telecommunications Service Call
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>CallAttempt</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TelecommunicationsServiceCall
    {
        get
        {
            if (__TelecommunicationsServiceCall == null) { __TelecommunicationsServiceCall = new TextType(); }
            return __TelecommunicationsServiceCall;
        }
        set
        {
            __TelecommunicationsServiceCall = value;
        }
    }

        
    /// <summary>
    /// The telecommunications call described as a code
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Telecommunications Service Call Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Telecommunications Service Call Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>CallAttempt</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TelecommunicationsServiceCallCode
    {
        get
        {
            if (__TelecommunicationsServiceCallCode == null) { __TelecommunicationsServiceCallCode = new CodeType(); }
            return __TelecommunicationsServiceCallCode;
        }
        set
        {
            __TelecommunicationsServiceCallCode = value;
        }
    }

        
    /// <summary>
    /// The amount to be payed as the base for one call
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Call Base_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTermQualifier: Call Base
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType CallBaseAmount
    {
        get
        {
            if (__CallBaseAmount == null) { __CallBaseAmount = new AmountType(); }
            return __CallBaseAmount;
        }
        set
        {
            __CallBaseAmount = value;
        }
    }

        
    /// <summary>
    /// The amount to be payed for the call
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Call Extension_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTermQualifier: Call Extension
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>542.44</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType CallExtensionAmount
    {
        get
        {
            if (__CallExtensionAmount == null) { __CallExtensionAmount = new AmountType(); }
            return __CallExtensionAmount;
        }
        set
        {
            __CallExtensionAmount = value;
        }
    }

        
    /// <summary>
    /// The price for using the telecommunication service
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Price
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Price
    /// <para />AssociatedObjectClass: Price
    /// <para />RepresentationTerm: Price
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PriceType Price
    {
        get
        {
            if (__Price == null) { __Price = new PriceType(); }
            return __Price;
        }
        set
        {
            __Price = value;
        }
    }

        
    /// <summary>
    /// The country to which the service is provided. In case of a telephone call it is the country where the receiver is located.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Service. Country
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Service
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CountryType Country
    {
        get
        {
            if (__Country == null) { __Country = new CountryType(); }
            return __Country;
        }
        set
        {
            __Country = value;
        }
    }

}