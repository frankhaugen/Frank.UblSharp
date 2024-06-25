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
    [XmlTypeAttribute("CreditNoteLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(CreditNoteLine))]
    [XmlIncludeAttribute(typeof(SubCreditNoteLine))]
    public partial class CreditNoteLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this credit note line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this credit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Credited_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of items credited in this credit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Credited</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CreditedQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CreditedQuantityType CreditedQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Line Extension Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total amount for this credit note line, including allowance charges but exclusive of taxes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Line Extension Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LineExtensionAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LineExtensionAmountType LineExtensionAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Tax Point Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date of this credit note line, used to indicate the point at which tax becomes applicable.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Tax Point Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TaxPointDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxPointDateType TaxPointDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Accounting Cost Code. Code</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this credit note line, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCostCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostCodeType AccountingCostCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Accounting Cost. Text</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this credit note line, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCost", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostType AccountingCost { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Payment Purpose Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the business purpose for this payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Payment Purpose Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentPurposeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentPurposeCodeType PaymentPurposeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Free Of Charge_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this credit note line is free of charge (true) or not (false). The default is false.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Free Of Charge</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FreeOfChargeIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FreeOfChargeIndicatorType FreeOfChargeIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PeriodType> _invoicePeriod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Invoice_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>An invoice period to which this credit note line applies.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Invoice</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
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
        private List<OrderLineReferenceType> _orderLineReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Order Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to an order line associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Order Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Order Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Order Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OrderLineReference")]
        public List<OrderLineReferenceType> OrderLineReference
        {
            get
            {
                return _orderLineReference;
            }
            set
            {
                _orderLineReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OrderLineReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OrderLineReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrderLineReferenceSpecified
        {
            get
            {
                return ((this.OrderLineReference != null) 
                            && (this.OrderLineReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ResponseType> _discrepancyResponse;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Discrepancy_ Response. Response</ccts:DictionaryEntryName><ccts:Definition>A reason for the credit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Discrepancy</ccts:PropertyTermQualifier><ccts:PropertyTerm>Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Response</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DiscrepancyResponse")]
        public List<ResponseType> DiscrepancyResponse
        {
            get
            {
                return _discrepancyResponse;
            }
            set
            {
                _discrepancyResponse = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DiscrepancyResponse-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DiscrepancyResponse collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DiscrepancyResponseSpecified
        {
            get
            {
                return ((this.DiscrepancyResponse != null) 
                            && (this.DiscrepancyResponse.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<LineReferenceType> _despatchLineReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Despatch_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a despatch line associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Despatch</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DespatchLineReference")]
        public List<LineReferenceType> DespatchLineReference
        {
            get
            {
                return _despatchLineReference;
            }
            set
            {
                _despatchLineReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DespatchLineReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DespatchLineReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DespatchLineReferenceSpecified
        {
            get
            {
                return ((this.DespatchLineReference != null) 
                            && (this.DespatchLineReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<LineReferenceType> _receiptLineReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Receipt_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a receipt line associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Receipt</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReceiptLineReference")]
        public List<LineReferenceType> ReceiptLineReference
        {
            get
            {
                return _receiptLineReference;
            }
            set
            {
                _receiptLineReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReceiptLineReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReceiptLineReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReceiptLineReferenceSpecified
        {
            get
            {
                return ((this.ReceiptLineReference != null) 
                            && (this.ReceiptLineReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<BillingReferenceType> _billingReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Billing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a billing document associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Billing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Billing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Billing Reference</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Pricing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to pricing and item location information associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Pricing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Pricing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Pricing Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PricingReference")]
        public PricingReferenceType PricingReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Originator_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party who originated the Order to which the Credit Note is related.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Originator</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginatorParty")]
        public PartyType OriginatorParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryType> _delivery;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Delivery</ccts:DictionaryEntryName><ccts:Definition>A delivery associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Delivery")]
        public List<DeliveryType> Delivery
        {
            get
            {
                return _delivery;
            }
            set
            {
                _delivery = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Delivery-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Delivery collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliverySpecified
        {
            get
            {
                return ((this.Delivery != null) 
                            && (this.Delivery.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PaymentTermsType> _paymentTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>A specification of payment terms associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
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
        
        [XmlIgnoreAttribute()]
        private List<TaxTotalType> _taxTotal;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Tax Total</ccts:DictionaryEntryName><ccts:Definition>A total amount of taxes of a particular kind applicable to this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Tax Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Total</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TaxTotal")]
        public List<TaxTotalType> TaxTotal
        {
            get
            {
                return _taxTotal;
            }
            set
            {
                _taxTotal = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TaxTotal-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TaxTotal collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxTotalSpecified
        {
            get
            {
                return ((this.TaxTotal != null) 
                            && (this.TaxTotal.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _allowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge associated with this credit note.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Item")]
        public ItemType Item { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Price</ccts:DictionaryEntryName><ccts:Definition>The price of the item associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Unit Price, Base Price</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Price")]
        public PriceType Price { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryTermsType> _deliveryTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Delivery Terms</ccts:DictionaryEntryName><ccts:Definition>Terms and conditions of a delivery associated with this credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Delivery Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeliveryTerms")]
        public List<DeliveryTermsType> DeliveryTerms
        {
            get
            {
                return _deliveryTerms;
            }
            set
            {
                _deliveryTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DeliveryTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliveryTermsSpecified
        {
            get
            {
                return ((this.DeliveryTerms != null) 
                            && (this.DeliveryTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CreditNoteLineType> _subCreditNoteLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Sub_ Credit Note Line. Credit Note Line</ccts:DictionaryEntryName><ccts:Definition>A class defining one or more Credit Note Lines detailing the credit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Sub</ccts:PropertyTermQualifier><ccts:PropertyTerm>Credit Note Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Credit Note Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Credit Note Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SubCreditNoteLine")]
        public List<CreditNoteLineType> SubCreditNoteLine
        {
            get
            {
                return _subCreditNoteLine;
            }
            set
            {
                _subCreditNoteLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SubCreditNoteLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SubCreditNoteLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubCreditNoteLineSpecified
        {
            get
            {
                return ((this.SubCreditNoteLine != null) 
                            && (this.SubCreditNoteLine.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Credit Note Line. Item_ Price Extension. Price Extension</ccts:DictionaryEntryName><ccts:Definition>The price extension, calculated by multiplying the price per unit by the quantity of items on this credit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Credit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Item</ccts:PropertyTermQualifier><ccts:PropertyTerm>Price Extension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price Extension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price Extension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ItemPriceExtension")]
        public PriceExtensionType ItemPriceExtension { get; set; }
    }
}