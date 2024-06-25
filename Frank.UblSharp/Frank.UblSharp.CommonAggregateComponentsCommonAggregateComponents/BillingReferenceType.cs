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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a reference to a billing document.</ccts:Definition><ccts:ObjectClass>Billing Reference</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("BillingReferenceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("BillingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BillingReferenceType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Invoice_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to an invoice.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Invoice</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InvoiceDocumentReference")]
        public DocumentReferenceType InvoiceDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Self Billed Invoice_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a self billed invoice.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Self Billed Invoice</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SelfBilledInvoiceDocumentReference")]
        public DocumentReferenceType SelfBilledInvoiceDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Credit Note_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a credit note.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Credit Note</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CreditNoteDocumentReference")]
        public DocumentReferenceType CreditNoteDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Self Billed Credit Note_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a self billed credit note.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Self Billed Credit Note</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SelfBilledCreditNoteDocumentReference")]
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Debit Note_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a debit note.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Debit Note</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DebitNoteDocumentReference")]
        public DocumentReferenceType DebitNoteDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Reminder_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a billing reminder.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Reminder</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReminderDocumentReference")]
        public DocumentReferenceType ReminderDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Additional_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to an additional document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AdditionalDocumentReference")]
        public DocumentReferenceType AdditionalDocumentReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<BillingReferenceLineType> _billingReferenceLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Billing Reference. Billing Reference Line</ccts:DictionaryEntryName><ccts:Definition>A reference to a transaction line in the billing document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Billing Reference</ccts:ObjectClass><ccts:PropertyTerm>Billing Reference Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Billing Reference Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Billing Reference Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("BillingReferenceLine")]
        public List<BillingReferenceLineType> BillingReferenceLine
        {
            get
            {
                return _billingReferenceLine;
            }
            set
            {
                _billingReferenceLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BillingReferenceLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BillingReferenceLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BillingReferenceLineSpecified
        {
            get
            {
                return ((this.BillingReferenceLine != null) 
                            && (this.BillingReferenceLine.Count != 0));
            }
        }
    }
}
