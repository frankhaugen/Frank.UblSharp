using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a monetary total.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Monetary Total. Details
/// <para />ObjectClass: Monetary Total
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AnticipatedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AnticipatedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class MonetaryTotalType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__LineExtensionAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxExclusiveAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__TaxExclusiveAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxInclusiveAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__TaxInclusiveAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceTotalAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__AllowanceTotalAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChargeTotalAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__ChargeTotalAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrepaidAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public AmountType @__PrepaidAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayableRoundingAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__PayableRoundingAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public AmountType @__PayableAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayableAlternativeAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__PayableAlternativeAmount;
        
    /// <summary>
    /// The monetary amount of an extended transaction line, net of tax and settlement discounts, but inclusive of any applicable rounding amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Line Extension Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
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

        
    /// <summary>
    /// The monetary amount of an extended transaction line, exclusive of taxes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Tax Exclusive Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTerm: Tax Exclusive Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TaxExclusiveAmount
    {
        get
        {
            if (__TaxExclusiveAmount == null) { __TaxExclusiveAmount = new AmountType(); }
            return __TaxExclusiveAmount;
        }
        set
        {
            __TaxExclusiveAmount = value;
        }
    }

        
    /// <summary>
    /// The monetary amount including taxes; the sum of payable amount and prepaid amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Tax Inclusive Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTerm: Tax Inclusive Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TaxInclusiveAmount
    {
        get
        {
            if (__TaxInclusiveAmount == null) { __TaxInclusiveAmount = new AmountType(); }
            return __TaxInclusiveAmount;
        }
        set
        {
            __TaxInclusiveAmount = value;
        }
    }

        
    /// <summary>
    /// The total monetary amount of all allowances.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Allowance_ Total Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTermQualifier: Allowance
    /// <para />PropertyTerm: Total Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType AllowanceTotalAmount
    {
        get
        {
            if (__AllowanceTotalAmount == null) { __AllowanceTotalAmount = new AmountType(); }
            return __AllowanceTotalAmount;
        }
        set
        {
            __AllowanceTotalAmount = value;
        }
    }

        
    /// <summary>
    /// The total monetary amount of all charges.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Charge_ Total Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTermQualifier: Charge
    /// <para />PropertyTerm: Total Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType ChargeTotalAmount
    {
        get
        {
            if (__ChargeTotalAmount == null) { __ChargeTotalAmount = new AmountType(); }
            return __ChargeTotalAmount;
        }
        set
        {
            __ChargeTotalAmount = value;
        }
    }

        
    /// <summary>
    /// The total prepaid monetary amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Prepaid Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTerm: Prepaid Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PrepaidAmount
    {
        get
        {
            if (__PrepaidAmount == null) { __PrepaidAmount = new AmountType(); }
            return __PrepaidAmount;
        }
        set
        {
            __PrepaidAmount = value;
        }
    }

        
    /// <summary>
    /// The rounding amount (positive or negative) added to produce the line extension amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Payable_ Rounding Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTermQualifier: Payable
    /// <para />PropertyTerm: Rounding Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PayableRoundingAmount
    {
        get
        {
            if (__PayableRoundingAmount == null) { __PayableRoundingAmount = new AmountType(); }
            return __PayableRoundingAmount;
        }
        set
        {
            __PayableRoundingAmount = value;
        }
    }

        
    /// <summary>
    /// The amount of the monetary total to be paid.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Payable_ Amount. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTermQualifier: Payable
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PayableAmount
    {
        get
        {
            if (__PayableAmount == null) { __PayableAmount = new AmountType(); }
            return __PayableAmount;
        }
        set
        {
            __PayableAmount = value;
        }
    }

        
    /// <summary>
    /// The amount of the monetary total to be paid, expressed in an alternative currency.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Monetary Total. Payable_ Alternative Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Monetary Total
    /// <para />PropertyTermQualifier: Payable
    /// <para />PropertyTerm: Alternative Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PayableAlternativeAmount
    {
        get
        {
            if (__PayableAlternativeAmount == null) { __PayableAlternativeAmount = new AmountType(); }
            return __PayableAlternativeAmount;
        }
        set
        {
            __PayableAlternativeAmount = value;
        }
    }

}