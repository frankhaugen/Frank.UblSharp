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
    
    
    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a line in a Statement of account.</ccts:Definition><ccts:ObjectClass>Statement Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("StatementLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("StatementLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StatementLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this statement line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this statement line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Balance Brought Forward_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication that this statement line contains an outstanding balance from the previous bill(s) (true) or does not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Balance Brought Forward</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BalanceBroughtForwardIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BalanceBroughtForwardIndicatorType BalanceBroughtForwardIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Debit_ Line Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount debited on this statement line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Debit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DebitLineAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DebitLineAmountType DebitLineAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Credit_ Line Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount credited on this statement line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Credit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CreditLineAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CreditLineAmountType CreditLineAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Balance Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The balance amount on this statement line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Balance Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BalanceAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BalanceAmountType BalanceAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Payment Purpose Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the business purpose for this payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Payment Purpose Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentPurposeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentPurposeCodeType PaymentPurposeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Payment Means</ccts:DictionaryEntryName><ccts:Definition>A means of payment associated with this statement line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Payment Means</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Means</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Means</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentMeans")]
        public PaymentMeansType PaymentMeans { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PaymentTermsType> _paymentTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>A specification of payment terms associated with this statement line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PaymentTerms")]
        public List<PaymentTermsType> PaymentTerms
        {
            get
            {
                return _paymentTerms;
            }
            set
            {
                _paymentTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PaymentTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentTermsSpecified
        {
            get
            {
                return ((this.PaymentTerms != null) 
                            && (this.PaymentTerms.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Buyer_ Customer Party. Customer Party</ccts:DictionaryEntryName><ccts:Definition>The buyer associated with this statement line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Buyer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customer Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customer Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customer Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BuyerCustomerParty")]
        public CustomerPartyType BuyerCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Seller_ Supplier Party. Supplier Party</ccts:DictionaryEntryName><ccts:Definition>The seller/supplier associated with this statement line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Seller</ccts:PropertyTermQualifier><ccts:PropertyTerm>Supplier Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SellerSupplierParty")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Originator_ Customer Party. Customer Party</ccts:DictionaryEntryName><ccts:Definition>The originating party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Originator</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customer Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customer Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customer Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginatorCustomerParty")]
        public CustomerPartyType OriginatorCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Accounting_ Customer Party. Customer Party</ccts:DictionaryEntryName><ccts:Definition>The Accounting Customer Party related to the statement information reported on this Statement Line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Accounting</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customer Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customer Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customer Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCustomerParty")]
        public CustomerPartyType AccountingCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Accounting_ Supplier Party. Supplier Party</ccts:DictionaryEntryName><ccts:Definition>The Accounting Supplier Party related to the statement information reported on this Statement Line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Accounting</ccts:PropertyTermQualifier><ccts:PropertyTerm>Supplier Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingSupplierParty")]
        public SupplierPartyType AccountingSupplierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Payee_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The payee.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Payee</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PayeeParty")]
        public PartyType PayeeParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PeriodType> _invoicePeriod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Invoice_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>An invoice period to which this statement line applies.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Invoice</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("InvoicePeriod")]
        public List<PeriodType> InvoicePeriod
        {
            get
            {
                return _invoicePeriod;
            }
            set
            {
                _invoicePeriod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die InvoicePeriod-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the InvoicePeriod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InvoicePeriodSpecified
        {
            get
            {
                return ((this.InvoicePeriod != null) 
                            && (this.InvoicePeriod.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<BillingReferenceType> _billingReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Billing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a billing document associated with this statement line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Billing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Billing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Billing Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("BillingReference")]
        public List<BillingReferenceType> BillingReference
        {
            get
            {
                return _billingReference;
            }
            set
            {
                _billingReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BillingReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BillingReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BillingReferenceSpecified
        {
            get
            {
                return ((this.BillingReference != null) 
                            && (this.BillingReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this statement line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentReference")]
        public List<DocumentReferenceType> DocumentReference
        {
            get
            {
                return _documentReference;
            }
            set
            {
                _documentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentReferenceSpecified
        {
            get
            {
                return ((this.DocumentReference != null) 
                            && (this.DocumentReference.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Exchange Rate</ccts:DictionaryEntryName><ccts:Definition>The rate of exchange between the currency of the Statement and the currency of the document described in the BillingReference.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Exchange Rate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Exchange Rate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Exchange Rate</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExchangeRate")]
        public ExchangeRateType ExchangeRate { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _allowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A charge or discount price component associated with this statement line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AllowanceCharge")]
        public List<AllowanceChargeType> AllowanceCharge
        {
            get
            {
                return _allowanceCharge;
            }
            set
            {
                _allowanceCharge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AllowanceCharge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AllowanceChargeSpecified
        {
            get
            {
                return ((this.AllowanceCharge != null) 
                            && (this.AllowanceCharge.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PaymentType> _collectedPayment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Statement Line. Collected_ Payment. Payment</ccts:DictionaryEntryName><ccts:Definition>A collected payment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Statement Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Collected</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CollectedPayment")]
        public List<PaymentType> CollectedPayment
        {
            get
            {
                return _collectedPayment;
            }
            set
            {
                _collectedPayment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CollectedPayment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CollectedPayment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CollectedPaymentSpecified
        {
            get
            {
                return ((this.CollectedPayment != null) 
                            && (this.CollectedPayment.Count != 0));
            }
        }
    }
}