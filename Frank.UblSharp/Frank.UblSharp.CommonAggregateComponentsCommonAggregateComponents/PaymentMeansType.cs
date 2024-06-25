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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a means of payment.</ccts:Definition><ccts:ObjectClass>Payment Means</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PaymentMeansType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("PaymentMeans", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PaymentMeansType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this means of payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Payment Means Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this means of payment.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Payment Means Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Payment Means</ccts:DataTypeQualifier><ccts:DataType>Payment Means_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PaymentMeansCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentMeansCodeType PaymentMeansCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Payment Due Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which payment is due for this means of payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Payment Due Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentDueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentDueDateType PaymentDueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Payment Channel Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the payment channel for this means of payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Payment Channel Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentChannelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentChannelCodeType PaymentChannelCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Instruction Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the payment instruction.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Instruction Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InstructionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InstructionIdType InstructionId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InstructionNoteType> _instructionNote;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Instruction_ Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTermQualifier>Instruction</ccts:PropertyTermQualifier><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("InstructionNote", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InstructionNoteType> InstructionNote
        {
            get
            {
                return _instructionNote;
            }
            set
            {
                _instructionNote = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die InstructionNote-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the InstructionNote collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InstructionNoteSpecified
        {
            get
            {
                return ((this.InstructionNote != null) 
                            && (this.InstructionNote.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentIdType> _paymentId;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Payment Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for a payment made using this means of payment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Payment Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PaymentID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentIdType> PaymentId
        {
            get
            {
                return _paymentId;
            }
            set
            {
                _paymentId = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PaymentId-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentId collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentIdSpecified
        {
            get
            {
                return ((this.PaymentId != null) 
                            && (this.PaymentId.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Card Account</ccts:DictionaryEntryName><ccts:Definition>A credit card, debit card, or charge card account that constitutes this means of payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Card Account</ccts:PropertyTerm><ccts:AssociatedObjectClass>Card Account</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Card Account</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CardAccount")]
        public CardAccountType CardAccount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Payer_ Financial Account. Financial Account</ccts:DictionaryEntryName><ccts:Definition>The payer's financial account.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTermQualifier>Payer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Financial Account</ccts:PropertyTerm><ccts:AssociatedObjectClass>Financial Account</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Financial Account</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PayerFinancialAccount")]
        public FinancialAccountType PayerFinancialAccount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Payee_ Financial Account. Financial Account</ccts:DictionaryEntryName><ccts:Definition>The payee's financial account.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTermQualifier>Payee</ccts:PropertyTermQualifier><ccts:PropertyTerm>Financial Account</ccts:PropertyTerm><ccts:AssociatedObjectClass>Financial Account</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Financial Account</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PayeeFinancialAccount")]
        public FinancialAccountType PayeeFinancialAccount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Credit Account</ccts:DictionaryEntryName><ccts:Definition>A credit account associated with this means of payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Credit Account</ccts:PropertyTerm><ccts:AssociatedObjectClass>Credit Account</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Credit Account</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CreditAccount")]
        public CreditAccountType CreditAccount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Payment Mandate</ccts:DictionaryEntryName><ccts:Definition>The payment mandate associated with this means of payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Payment Mandate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Mandate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Mandate</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PaymentMandate")]
        public PaymentMandateType PaymentMandate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Payment Means. Trade Financing</ccts:DictionaryEntryName><ccts:Definition>A trade finance agreement applicable to this means of payment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Payment Means</ccts:ObjectClass><ccts:PropertyTerm>Trade Financing</ccts:PropertyTerm><ccts:AssociatedObjectClass>Trade Financing</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Trade Financing</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TradeFinancing")]
        public TradeFinancingType TradeFinancing { get; set; }
    }
}
