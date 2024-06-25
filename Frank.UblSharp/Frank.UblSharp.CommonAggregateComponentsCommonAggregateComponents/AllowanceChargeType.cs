namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("AllowanceChargeType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AllowanceCharge))]
    [XmlIncludeAttribute(typeof(ExtraAllowanceCharge))]
    [XmlIncludeAttribute(typeof(FreightAllowanceCharge))]
    [XmlIncludeAttribute(typeof(ServiceAllowanceCharge))]
    public partial class AllowanceChargeType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this allowance or charge.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Charge_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this AllowanceCharge describes a charge (true) or a discount (false).</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTermQualifier>Charge</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ChargeIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChargeIndicatorType ChargeIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Allowance Charge Reason Code. Code</ccts:DictionaryEntryName><ccts:Definition>A mutually agreed code signifying the reason for this allowance or charge.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge Reason Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Allowance Charge Reason</ccts:DataTypeQualifier><ccts:DataType>Allowance Charge Reason_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AllowanceChargeReasonCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AllowanceChargeReasonCodeType AllowanceChargeReasonCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AllowanceChargeReasonType> _allowanceChargeReason;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Allowance Charge_ Reason. Text</ccts:DictionaryEntryName><ccts:Definition>The reason for this allowance or charge.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTermQualifier>Allowance Charge</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AllowanceChargeReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AllowanceChargeReasonType> AllowanceChargeReason
        {
            get
            {
                return _allowanceChargeReason;
            }
            set
            {
                _allowanceChargeReason = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AllowanceChargeReason-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AllowanceChargeReason collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AllowanceChargeReasonSpecified
        {
            get
            {
                return ((this.AllowanceChargeReason != null) 
                            && (this.AllowanceChargeReason.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Multiplier_ Factor. Numeric</ccts:DictionaryEntryName><ccts:Definition>A number by which the base amount is multiplied to calculate the actual amount of this allowance or charge.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTermQualifier>Multiplier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Factor</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType><ccts:Examples>0.20</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MultiplierFactorNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MultiplierFactorNumericType MultiplierFactorNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Prepaid_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this allowance or charge is prepaid (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTermQualifier>Prepaid</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PrepaidIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PrepaidIndicatorType PrepaidIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Sequence. Numeric</ccts:DictionaryEntryName><ccts:Definition>A number indicating the order of this allowance or charge in the sequence of calculations applied when there are multiple allowances or charges.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Sequence</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType><ccts:Examples>1, 2, 3, 4, etc.</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SequenceNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SequenceNumericType SequenceNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount of this allowance or charge to be applied.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:Examples>35,23</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Amount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AmountType Amount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Base_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount to which the multiplier factor is applied in calculating the amount of this allowance or charge.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTermQualifier>Base</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BaseAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BaseAmountType BaseAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Accounting Cost Code. Code</ccts:DictionaryEntryName><ccts:Definition>The accounting cost centre used by the buyer to account for this allowance or charge, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCostCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostCodeType AccountingCostCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Accounting Cost. Text</ccts:DictionaryEntryName><ccts:Definition>The accounting cost centre used by the buyer to account for this allowance or charge, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCost", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostType AccountingCost { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Per Unit_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The allowance or charge per item; the total allowance or charge is calculated by multiplying the per unit amount by the quantity of items, either at the level of the individual transaction line or for the total number of items in the document, depending on the context in which it appears.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTermQualifier>Per Unit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PerUnitAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PerUnitAmountType PerUnitAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TaxCategoryType> _taxCategory;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Tax Category</ccts:DictionaryEntryName><ccts:Definition>A tax category applicable to this allowance or charge.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Tax Category</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Category</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Category</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TaxCategory")]
        public List<TaxCategoryType> TaxCategory
        {
            get
            {
                return _taxCategory;
            }
            set
            {
                _taxCategory = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TaxCategory-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TaxCategory collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxCategorySpecified
        {
            get
            {
                return ((this.TaxCategory != null) 
                            && (this.TaxCategory.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Tax Total</ccts:DictionaryEntryName><ccts:Definition>The total of all the taxes applicable to this allowance or charge.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Tax Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Total</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TaxTotal")]
        public TaxTotalType TaxTotal { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PaymentMeansType> _paymentMeans;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Allowance Charge. Payment Means</ccts:DictionaryEntryName><ccts:Definition>A means of payment for this allowance or charge.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Allowance Charge</ccts:ObjectClass><ccts:PropertyTerm>Payment Means</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Means</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Means</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PaymentMeans")]
        public List<PaymentMeansType> PaymentMeans
        {
            get
            {
                return _paymentMeans;
            }
            set
            {
                _paymentMeans = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PaymentMeans-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentMeans collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentMeansSpecified
        {
            get
            {
                return ((this.PaymentMeans != null) 
                            && (this.PaymentMeans.Count != 0));
            }
        }
    }
}
