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
    [XmlTypeAttribute("PaymentTermsType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(BonusPaymentTerms))]
    [XmlIncludeAttribute(typeof(CollectPaymentTerms))]
    [XmlIncludeAttribute(typeof(CommissionPaymentTerms))]
    [XmlIncludeAttribute(typeof(DisbursementPaymentTerms))]
    [XmlIncludeAttribute(typeof(PaymentTerms))]
    [XmlIncludeAttribute(typeof(PenaltyPaymentTerms))]
    [XmlIncludeAttribute(typeof(PrepaidPaymentTerms))]
    [XmlIncludeAttribute(typeof(ServiceChargePaymentTerms))]
    public partial class PaymentTermsType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this set of payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentMeansIdType> _paymentMeansId;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Payment Means Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for a means of payment associated with these payment terms.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Means Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PaymentMeansID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentMeansIdType> PaymentMeansId
        {
            get
            {
                return _paymentMeansId;
            }
            set
            {
                _paymentMeansId = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PaymentMeansId-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentMeansId collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentMeansIdSpecified
        {
            get
            {
                return ((this.PaymentMeansId != null) 
                            && (this.PaymentMeansId.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Prepaid Payment Reference Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for a reference to a prepaid payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Prepaid Payment Reference Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PrepaidPaymentReferenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PrepaidPaymentReferenceIdType PrepaidPaymentReferenceId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Note-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Note collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoteSpecified
        {
            get
            {
                return ((this.Note != null) 
                            && (this.Note.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Reference_ Event Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the event during which these terms are offered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Reference</ccts:PropertyTermQualifier><ccts:PropertyTerm>Event Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReferenceEventCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReferenceEventCodeType ReferenceEventCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Settlement_ Discount Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The percentage for the settlement discount that is offered for payment under these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Settlement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Discount Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SettlementDiscountPercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SettlementDiscountPercentType SettlementDiscountPercent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Penalty_ Surcharge Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The penalty for payment after the settlement period, expressed as a percentage of the payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Penalty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Surcharge Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PenaltySurchargePercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PenaltySurchargePercentType PenaltySurchargePercent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Payment Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The part of a payment, expressed as a percent, relevant for these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentPercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentPercentType PaymentPercent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount covered by these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Amount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AmountType Amount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Settlement_ Discount Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount of a settlement discount offered for payment under these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Settlement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Discount Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SettlementDiscountAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SettlementDiscountAmountType SettlementDiscountAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Penalty_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount of the penalty for payment after the settlement period.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Penalty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PenaltyAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PenaltyAmountType PenaltyAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Payment Terms Details URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) of a document providing additional details regarding these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Terms Details URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentTermsDetailsURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentTermsDetailsUriType PaymentTermsDetailsUri { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Payment Due Date. Date</ccts:DictionaryEntryName><ccts:Definition>The due date for these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Due Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentDueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentDueDateType PaymentDueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Installment Due Date. Date</ccts:DictionaryEntryName><ccts:Definition>The due date for an installment payment for these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Installment Due Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InstallmentDueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InstallmentDueDateType InstallmentDueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Invoicing Party_ Reference. Text</ccts:DictionaryEntryName><ccts:Definition>A reference to the payment terms used by the invoicing party. This may have been requested of the payer by the payee to accompany its remittance.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Invoicing Party</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reference</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InvoicingPartyReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InvoicingPartyReferenceType InvoicingPartyReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Settlement_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which settlement may occur.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Settlement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SettlementPeriod")]
        public PeriodType SettlementPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Penalty_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which penalties may apply.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Penalty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PenaltyPeriod")]
        public PeriodType PenaltyPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Exchange Rate</ccts:DictionaryEntryName><ccts:Definition>The currency exchange rate for purposes of these payment terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTerm>Exchange Rate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Exchange Rate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Exchange Rate</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExchangeRate")]
        public ExchangeRateType ExchangeRate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Terms. Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which these payment terms are valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ValidityPeriod")]
        public PeriodType ValidityPeriod { get; set; }
    }
}