using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define an exchange rate.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Exchange Rate. Details
/// <para />ObjectClass: Exchange Rate
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ExchangeRateType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SourceCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__SourceCurrencyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SourceCurrencyBaseRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public RateType @__SourceCurrencyBaseRate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TargetCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__TargetCurrencyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TargetCurrencyBaseRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public RateType @__TargetCurrencyBaseRate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExchangeMarketID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__ExchangeMarketID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CalculationRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public RateType @__CalculationRate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MathematicOperatorCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__MathematicOperatorCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Date", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public DateType @__Date;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ForeignExchangeContract", Order=8)]
    public ContractType @__ForeignExchangeContract;
        
    /// <summary>
    /// The reference currency for this exchange rate; the currency from which the exchange is being made.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Source_ Currency Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTermQualifier: Source
    /// <para />PropertyTerm: Currency Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Currency
    /// <para />DataType: Currency_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SourceCurrencyCode
    {
        get
        {
            if (__SourceCurrencyCode == null) { __SourceCurrencyCode = new CodeType(); }
            return __SourceCurrencyCode;
        }
        set
        {
            __SourceCurrencyCode = value;
        }
    }

        
    /// <summary>
    /// In the case of a source currency with denominations of small value, the unit base.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Source_ Currency Base Rate. Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTermQualifier: Source
    /// <para />PropertyTerm: Currency Base Rate
    /// <para />RepresentationTerm: Rate
    /// <para />DataType: Rate. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RateType SourceCurrencyBaseRate
    {
        get
        {
            if (__SourceCurrencyBaseRate == null) { __SourceCurrencyBaseRate = new RateType(); }
            return __SourceCurrencyBaseRate;
        }
        set
        {
            __SourceCurrencyBaseRate = value;
        }
    }

        
    /// <summary>
    /// The target currency for this exchange rate; the currency to which the exchange is being made.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Target_ Currency Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTermQualifier: Target
    /// <para />PropertyTerm: Currency Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Currency
    /// <para />DataType: Currency_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TargetCurrencyCode
    {
        get
        {
            if (__TargetCurrencyCode == null) { __TargetCurrencyCode = new CodeType(); }
            return __TargetCurrencyCode;
        }
        set
        {
            __TargetCurrencyCode = value;
        }
    }

        
    /// <summary>
    /// In the case of a target currency with denominations of small value, the unit base.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Target_ Currency Base Rate. Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTermQualifier: Target
    /// <para />PropertyTerm: Currency Base Rate
    /// <para />RepresentationTerm: Rate
    /// <para />DataType: Rate. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RateType TargetCurrencyBaseRate
    {
        get
        {
            if (__TargetCurrencyBaseRate == null) { __TargetCurrencyBaseRate = new RateType(); }
            return __TargetCurrencyBaseRate;
        }
        set
        {
            __TargetCurrencyBaseRate = value;
        }
    }

        
    /// <summary>
    /// An identifier for the currency exchange market used as the source of this exchange rate.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Exchange Market Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTerm: Exchange Market Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ExchangeMarketID
    {
        get
        {
            if (__ExchangeMarketID == null) { __ExchangeMarketID = new IdentifierType(); }
            return __ExchangeMarketID;
        }
        set
        {
            __ExchangeMarketID = value;
        }
    }

        
    /// <summary>
    /// The factor applied to the source currency to calculate the target currency.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Calculation Rate. Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTerm: Calculation Rate
    /// <para />RepresentationTerm: Rate
    /// <para />DataType: Rate. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RateType CalculationRate
    {
        get
        {
            if (__CalculationRate == null) { __CalculationRate = new RateType(); }
            return __CalculationRate;
        }
        set
        {
            __CalculationRate = value;
        }
    }

        
    /// <summary>
    /// A code signifying whether the calculation rate is a multiplier or a divisor.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Mathematic Operator Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTerm: Mathematic Operator Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Operator
    /// <para />DataType: Operator_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType MathematicOperatorCode
    {
        get
        {
            if (__MathematicOperatorCode == null) { __MathematicOperatorCode = new CodeType(); }
            return __MathematicOperatorCode;
        }
        set
        {
            __MathematicOperatorCode = value;
        }
    }

        
    /// <summary>
    /// The date on which the exchange rate was established.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Exchange Rate. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTerm: Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType Date
    {
        get
        {
            if (__Date == null) { __Date = new DateType(); }
            return __Date;
        }
        set
        {
            __Date = value;
        }
    }

        
    /// <summary>
    /// A contract for foreign exchange.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Exchange Rate. Foreign Exchange_ Contract. Contract
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Exchange Rate
    /// <para />PropertyTermQualifier: Foreign Exchange
    /// <para />PropertyTerm: Contract
    /// <para />AssociatedObjectClass: Contract
    /// <para />RepresentationTerm: Contract
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContractType ForeignExchangeContract
    {
        get
        {
            if (__ForeignExchangeContract == null) { __ForeignExchangeContract = new ContractType(); }
            return __ForeignExchangeContract;
        }
        set
        {
            __ForeignExchangeContract = value;
        }
    }

}