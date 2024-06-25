using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the consumption of a utility.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption. Details
/// <para />ObjectClass: Consumption
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Consumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Consumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UtilityStatementTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__UtilityStatementTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MainPeriod", Order=1)]
    public PeriodType @__MainPeriod;
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=3)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EnergyWaterSupply", Order=4)]
    public EnergyWaterSupplyType @__EnergyWaterSupply;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupply", Order=5)]
    public TelecommunicationsSupplyType @__TelecommunicationsSupply;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LegalMonetaryTotal", Order=6)]
    public MonetaryTotalType @__LegalMonetaryTotal;
        
    /// <summary>
    /// An allowance or charges that may apply with this consumption.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption
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
    /// The total of taxes for each tax type covering the consumption.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption
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
    /// A code identifying the type of the Utility Statement required for this consumption. Explains the kind of utility the statement is about, e.g.. &quot;gas&quot;, &quot;electricity&quot;, &quot;telephone&quot;
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption. Utility Statement Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption
    /// <para />PropertyTerm: Utility Statement Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Electricity</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType UtilityStatementTypeCode
    {
        get
        {
            if (__UtilityStatementTypeCode == null) { __UtilityStatementTypeCode = new CodeType(); }
            return __UtilityStatementTypeCode;
        }
        set
        {
            __UtilityStatementTypeCode = value;
        }
    }

        
    /// <summary>
    /// The period of consumption.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption. Main_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption
    /// <para />PropertyTermQualifier: Main
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType MainPeriod
    {
        get
        {
            if (__MainPeriod == null) { __MainPeriod = new PeriodType(); }
            return __MainPeriod;
        }
        set
        {
            __MainPeriod = value;
        }
    }

        
    /// <summary>
    /// The details of any energy or water consumption.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption. Energy Water Supply
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption
    /// <para />PropertyTerm: Energy Water Supply
    /// <para />AssociatedObjectClass: Energy Water Supply
    /// <para />RepresentationTerm: Energy Water Supply
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public EnergyWaterSupplyType EnergyWaterSupply
    {
        get
        {
            if (__EnergyWaterSupply == null) { __EnergyWaterSupply = new EnergyWaterSupplyType(); }
            return __EnergyWaterSupply;
        }
        set
        {
            __EnergyWaterSupply = value;
        }
    }

        
    /// <summary>
    /// The details of any telecommunications consumption.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption. Telecommunications Supply
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption
    /// <para />PropertyTerm: Telecommunications Supply
    /// <para />AssociatedObjectClass: Telecommunications Supply
    /// <para />RepresentationTerm: Telecommunications Supply
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TelecommunicationsSupplyType TelecommunicationsSupply
    {
        get
        {
            if (__TelecommunicationsSupply == null) { __TelecommunicationsSupply = new TelecommunicationsSupplyType(); }
            return __TelecommunicationsSupply;
        }
        set
        {
            __TelecommunicationsSupply = value;
        }
    }

        
    /// <summary>
    /// The total amount payable on this consumption, including any allowances, charges, or taxes.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption. Legal_ Monetary Total. Monetary Total
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption
    /// <para />PropertyTermQualifier: Legal
    /// <para />PropertyTerm: Monetary Total
    /// <para />AssociatedObjectClass: Monetary Total
    /// <para />RepresentationTerm: Monetary Total
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MonetaryTotalType LegalMonetaryTotal
    {
        get
        {
            if (__LegalMonetaryTotal == null) { __LegalMonetaryTotal = new MonetaryTotalType(); }
            return __LegalMonetaryTotal;
        }
        set
        {
            __LegalMonetaryTotal = value;
        }
    }

}