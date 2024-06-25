using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe information about a charge or discount as applied to a price component.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Allowance Charge. Details
/// <para />ObjectClass: Allowance Charge
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AllowanceChargeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChargeIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IndicatorType @__ChargeIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceChargeReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__AllowanceChargeReasonCode;
        
    private System.Collections.Generic.List<TextType> _allowanceChargeReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceChargeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__AllowanceChargeReason
    {
        get
        {
            return _allowanceChargeReason?.ToArray();
        }
        set
        {
            _allowanceChargeReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MultiplierFactorNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public NumericType @__MultiplierFactorNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrepaidIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IndicatorType @__PrepaidIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public NumericType @__SequenceNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BaseAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__BaseAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public CodeType @__AccountingCostCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public TextType @__AccountingCost;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PerUnitAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public AmountType @__PerUnitAmount;
        
    private System.Collections.Generic.List<TaxCategoryType> _taxCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxCategory", Order=12)]
    public TaxCategoryType[] @__TaxCategory
    {
        get
        {
            return _taxCategory?.ToArray();
        }
        set
        {
            _taxCategory = value == null ? null : new System.Collections.Generic.List<TaxCategoryType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=13)]
    public TaxTotalType @__TaxTotal;
        
    private System.Collections.Generic.List<PaymentMeansType> _paymentMeans;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Order=14)]
    public PaymentMeansType[] @__PaymentMeans
    {
        get
        {
            return _paymentMeans?.ToArray();
        }
        set
        {
            _paymentMeans = value == null ? null : new System.Collections.Generic.List<PaymentMeansType>(value);
        }
    }
        
    /// <summary>
    /// The reason for this allowance or charge.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Allowance Charge_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTermQualifier: Allowance Charge
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> AllowanceChargeReason
    {
        get { return _allowanceChargeReason ?? (_allowanceChargeReason = new System.Collections.Generic.List<TextType>()); }
        set { _allowanceChargeReason = value; }
    }

        
    /// <summary>
    /// A tax category applicable to this allowance or charge.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Allowance Charge. Tax Category
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Tax Category
    /// <para />AssociatedObjectClass: Tax Category
    /// <para />RepresentationTerm: Tax Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TaxCategoryType> TaxCategory
    {
        get { return _taxCategory ?? (_taxCategory = new System.Collections.Generic.List<TaxCategoryType>()); }
        set { _taxCategory = value; }
    }

        
    /// <summary>
    /// A means of payment for this allowance or charge.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Allowance Charge. Payment Means
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Payment Means
    /// <para />AssociatedObjectClass: Payment Means
    /// <para />RepresentationTerm: Payment Means
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PaymentMeansType> PaymentMeans
    {
        get { return _paymentMeans ?? (_paymentMeans = new System.Collections.Generic.List<PaymentMeansType>()); }
        set { _paymentMeans = value; }
    }

        
    /// <summary>
    /// An identifier for this allowance or charge.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
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
    /// An indicator that this AllowanceCharge describes a charge (true) or a discount (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Charge_ Indicator. Indicator
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTermQualifier: Charge
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType ChargeIndicator
    {
        get
        {
            if (__ChargeIndicator == null) { __ChargeIndicator = new IndicatorType(); }
            return __ChargeIndicator;
        }
        set
        {
            __ChargeIndicator = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code signifying the reason for this allowance or charge.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Allowance Charge Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Allowance Charge Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Allowance Charge Reason
    /// <para />DataType: Allowance Charge Reason_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AllowanceChargeReasonCode
    {
        get
        {
            if (__AllowanceChargeReasonCode == null) { __AllowanceChargeReasonCode = new CodeType(); }
            return __AllowanceChargeReasonCode;
        }
        set
        {
            __AllowanceChargeReasonCode = value;
        }
    }

        
    /// <summary>
    /// A number by which the base amount is multiplied to calculate the actual amount of this allowance or charge.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Multiplier_ Factor. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTermQualifier: Multiplier
    /// <para />PropertyTerm: Factor
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    /// <example>0.20</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType MultiplierFactorNumeric
    {
        get
        {
            if (__MultiplierFactorNumeric == null) { __MultiplierFactorNumeric = new NumericType(); }
            return __MultiplierFactorNumeric;
        }
        set
        {
            __MultiplierFactorNumeric = value;
        }
    }

        
    /// <summary>
    /// An indicator that this allowance or charge is prepaid (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Prepaid_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTermQualifier: Prepaid
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType PrepaidIndicator
    {
        get
        {
            if (__PrepaidIndicator == null) { __PrepaidIndicator = new IndicatorType(); }
            return __PrepaidIndicator;
        }
        set
        {
            __PrepaidIndicator = value;
        }
    }

        
    /// <summary>
    /// A number indicating the order of this allowance or charge in the sequence of calculations applied when there are multiple allowances or charges.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Sequence. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Sequence
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    /// <example>1, 2, 3, 4, etc.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType SequenceNumeric
    {
        get
        {
            if (__SequenceNumeric == null) { __SequenceNumeric = new NumericType(); }
            return __SequenceNumeric;
        }
        set
        {
            __SequenceNumeric = value;
        }
    }

        
    /// <summary>
    /// The monetary amount of this allowance or charge to be applied.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>35,23</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType Amount
    {
        get
        {
            if (__Amount == null) { __Amount = new AmountType(); }
            return __Amount;
        }
        set
        {
            __Amount = value;
        }
    }

        
    /// <summary>
    /// The monetary amount to which the multiplier factor is applied in calculating the amount of this allowance or charge.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Base_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTermQualifier: Base
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType BaseAmount
    {
        get
        {
            if (__BaseAmount == null) { __BaseAmount = new AmountType(); }
            return __BaseAmount;
        }
        set
        {
            __BaseAmount = value;
        }
    }

        
    /// <summary>
    /// The accounting cost centre used by the buyer to account for this allowance or charge, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Accounting Cost Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Accounting Cost Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AccountingCostCode
    {
        get
        {
            if (__AccountingCostCode == null) { __AccountingCostCode = new CodeType(); }
            return __AccountingCostCode;
        }
        set
        {
            __AccountingCostCode = value;
        }
    }

        
    /// <summary>
    /// The accounting cost centre used by the buyer to account for this allowance or charge, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Accounting Cost. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Accounting Cost
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType AccountingCost
    {
        get
        {
            if (__AccountingCost == null) { __AccountingCost = new TextType(); }
            return __AccountingCost;
        }
        set
        {
            __AccountingCost = value;
        }
    }

        
    /// <summary>
    /// The allowance or charge per item; the total allowance or charge is calculated by multiplying the per unit amount by the quantity of items, either at the level of the individual transaction line or for the total number of items in the document, depending on the context in which it appears.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Allowance Charge. Per Unit_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTermQualifier: Per Unit
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PerUnitAmount
    {
        get
        {
            if (__PerUnitAmount == null) { __PerUnitAmount = new AmountType(); }
            return __PerUnitAmount;
        }
        set
        {
            __PerUnitAmount = value;
        }
    }

        
    /// <summary>
    /// The total of all the taxes applicable to this allowance or charge.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Allowance Charge. Tax Total
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Allowance Charge
    /// <para />PropertyTerm: Tax Total
    /// <para />AssociatedObjectClass: Tax Total
    /// <para />RepresentationTerm: Tax Total
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TaxTotalType TaxTotal
    {
        get
        {
            if (__TaxTotal == null) { __TaxTotal = new TaxTotalType(); }
            return __TaxTotal;
        }
        set
        {
            __TaxTotal = value;
        }
    }

}