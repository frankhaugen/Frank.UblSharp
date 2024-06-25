using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe energy taxes.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Energy Tax Report. Details
/// <para />ObjectClass: Energy Tax Report
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EnergyTaxReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EnergyTaxReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EnergyTaxReportType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxEnergyAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__TaxEnergyAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxEnergyOnAccountAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__TaxEnergyOnAccountAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxEnergyBalanceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__TaxEnergyBalanceAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxScheme", Order=3)]
    public TaxSchemeType @__TaxScheme;
        
    /// <summary>
    /// The monetary amount of taxes (and duties).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Energy Tax Report. Tax Energy Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Energy Tax Report
    /// <para />PropertyTerm: Tax Energy Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>3087.90</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TaxEnergyAmount
    {
        get
        {
            if (__TaxEnergyAmount == null) { __TaxEnergyAmount = new AmountType(); }
            return __TaxEnergyAmount;
        }
        set
        {
            __TaxEnergyAmount = value;
        }
    }

        
    /// <summary>
    /// The monetary amount of taxes (and duties) paid on account.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Energy Tax Report. Tax Energy_ On Account Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Energy Tax Report
    /// <para />PropertyTermQualifier: Tax Energy
    /// <para />PropertyTerm: On Account Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>2855.40</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TaxEnergyOnAccountAmount
    {
        get
        {
            if (__TaxEnergyOnAccountAmount == null) { __TaxEnergyOnAccountAmount = new AmountType(); }
            return __TaxEnergyOnAccountAmount;
        }
        set
        {
            __TaxEnergyOnAccountAmount = value;
        }
    }

        
    /// <summary>
    /// The monetary amount of the balance of taxes owing.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Energy Tax Report. Tax Energy Balance. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Energy Tax Report
    /// <para />PropertyTerm: Tax Energy Balance
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>232.49</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TaxEnergyBalanceAmount
    {
        get
        {
            if (__TaxEnergyBalanceAmount == null) { __TaxEnergyBalanceAmount = new AmountType(); }
            return __TaxEnergyBalanceAmount;
        }
        set
        {
            __TaxEnergyBalanceAmount = value;
        }
    }

        
    /// <summary>
    /// The relevant taxation scheme.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Energy Tax Report. Tax Scheme
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Energy Tax Report
    /// <para />PropertyTerm: Tax Scheme
    /// <para />AssociatedObjectClass: Tax Scheme
    /// <para />RepresentationTerm: Tax Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TaxSchemeType TaxScheme
    {
        get
        {
            if (__TaxScheme == null) { __TaxScheme = new TaxSchemeType(); }
            return __TaxScheme;
        }
        set
        {
            __TaxScheme = value;
        }
    }

}