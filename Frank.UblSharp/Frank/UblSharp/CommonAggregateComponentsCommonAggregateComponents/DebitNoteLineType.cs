//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;


    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("DebitNoteLineType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlIncludeAttribute(typeof(DebitNoteLine))]
    [XmlIncludeAttribute(typeof(SubDebitNoteLine))]
    public partial class DebitNoteLineType
    {

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this debit note line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this debit note line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [KeyAttribute()]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Collection<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> Note { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Note collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool NoteSpecified
        {
            get
            {
                return ((this.Note != null)
                            && (this.Note.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Debited_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of Items debited in this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Debited</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Debited_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of Items debited in this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Debited</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DebitedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DebitedQuantityType DebitedQuantity { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Line Extension Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total amount for this debit note line, including allowance charges but net of taxes.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Line Extension Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Line Extension Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total amount for this debit note line, including allowance charges but net of taxes.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Line Extension Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LineExtensionAmountType LineExtensionAmount { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Tax Point Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date of this debit note line, used to indicate the point at which tax becomes applicable.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Tax Point Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Tax Point Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date of this debit note line, used to indicate the point at which tax becomes applicable.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Tax Point Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TaxPointDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxPointDateType TaxPointDate { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Accounting Cost Code. Code</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this debit note line, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Accounting Cost Code. Code</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this debit note line, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostCodeType AccountingCostCode { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Accounting Cost. Text</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this debit note line, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Accounting Cost. Text</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this debit note line, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostType AccountingCost { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Payment Purpose Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the business purpose for this payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Payment Purpose Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Payment Purpose Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the business purpose for this payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Payment Purpose Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentPurposeCodeType PaymentPurposeCode { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Discrepancy_ Response. Response</ccts:DictionaryEntryName><ccts:Definition>A reason for the debit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Discrepancy</ccts:PropertyTermQualifier><ccts:PropertyTerm>Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Response</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Discrepancy_ Response. Response</ccts:DictionaryEntryName><ccts:Definition>A reason for the debit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Discrepancy</ccts:PropertyTermQualifier><ccts:PropertyTerm>Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Response</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("DiscrepancyResponse")]
        public Collection<ResponseType> DiscrepancyResponse { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DiscrepancyResponse collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DiscrepancyResponseSpecified
        {
            get
            {
                return ((this.DiscrepancyResponse != null)
                            && (this.DiscrepancyResponse.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Despatch_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a despatch line associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Despatch</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Despatch_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a despatch line associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Despatch</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("DespatchLineReference")]
        public Collection<LineReferenceType> DespatchLineReference { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DespatchLineReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DespatchLineReferenceSpecified
        {
            get
            {
                return ((this.DespatchLineReference != null)
                            && (this.DespatchLineReference.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Receipt_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a receipt line associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Receipt</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Receipt_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a receipt line associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Receipt</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("ReceiptLineReference")]
        public Collection<LineReferenceType> ReceiptLineReference { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ReceiptLineReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ReceiptLineReferenceSpecified
        {
            get
            {
                return ((this.ReceiptLineReference != null)
                            && (this.ReceiptLineReference.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Billing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a billing document associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Billing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Billing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Billing Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Billing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a billing document associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Billing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Billing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Billing Reference</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("BillingReference")]
        public Collection<BillingReferenceType> BillingReference { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the BillingReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool BillingReferenceSpecified
        {
            get
            {
                return ((this.BillingReference != null)
                            && (this.BillingReference.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("DocumentReference")]
        public Collection<DocumentReferenceType> DocumentReference { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DocumentReferenceSpecified
        {
            get
            {
                return ((this.DocumentReference != null)
                            && (this.DocumentReference.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Pricing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to pricing and item location information associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Pricing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Pricing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Pricing Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Pricing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to pricing and item location information associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Pricing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Pricing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Pricing Reference</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PricingReference")]
        public PricingReferenceType PricingReference { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Delivery</ccts:DictionaryEntryName><ccts:Definition>A delivery associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Delivery</ccts:DictionaryEntryName><ccts:Definition>A delivery associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("Delivery")]
        public Collection<DeliveryType> Delivery { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Delivery collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DeliverySpecified
        {
            get
            {
                return ((this.Delivery != null)
                            && (this.Delivery.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Tax Total</ccts:DictionaryEntryName><ccts:Definition>A total amount of taxes of a particular kind applicable to this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Tax Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Total</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Tax Total</ccts:DictionaryEntryName><ccts:Definition>A total amount of taxes of a particular kind applicable to this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Tax Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Total</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("TaxTotal")]
        public Collection<TaxTotalType> TaxTotal { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TaxTotal collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool TaxTotalSpecified
        {
            get
            {
                return ((this.TaxTotal != null)
                            && (this.TaxTotal.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge associated with this debit note.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge associated with this debit note.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("AllowanceCharge")]
        public Collection<AllowanceChargeType> AllowanceCharge { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool AllowanceChargeSpecified
        {
            get
            {
                return ((this.AllowanceCharge != null)
                            && (this.AllowanceCharge.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Item")]
        public ItemType Item { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Price</ccts:DictionaryEntryName><ccts:Definition>The price of the item associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Unit Price, Base Price</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Price</ccts:DictionaryEntryName><ccts:Definition>The price of the item associated with this debit note line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Unit Price, Base Price</ccts:AlternativeBusinessTerms></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Price")]
        public PriceType Price { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Sub_ Debit Note Line. Debit Note Line</ccts:DictionaryEntryName><ccts:Definition>A recursive description of a debit note line subsidiary to this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Sub</ccts:PropertyTermQualifier><ccts:PropertyTerm>Debit Note Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Debit Note Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Debit Note Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Debit Note Line. Sub_ Debit Note Line. Debit Note Line</ccts:DictionaryEntryName><ccts:Definition>A recursive description of a debit note line subsidiary to this debit note line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Debit Note Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Sub</ccts:PropertyTermQualifier><ccts:PropertyTerm>Debit Note Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Debit Note Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Debit Note Line</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("SubDebitNoteLine")]
        public Collection<DebitNoteLineType> SubDebitNoteLine { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the SubDebitNoteLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SubDebitNoteLineSpecified
        {
            get
            {
                return ((this.SubDebitNoteLine != null)
                            && (this.SubDebitNoteLine.Count != 0));
            }
        }
    }
}
