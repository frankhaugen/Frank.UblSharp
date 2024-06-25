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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a line in an order document (e.g., Order, Order Change, or Order Response) describing an item being ordered.</ccts:Definition><ccts:ObjectClass>Order Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("OrderLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("OrderLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Substitution Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the substitution status of the item on this order line. The order line may indicate that the substitute is proposed by the buyer (in Order) or by the seller (in Order Response) or that a substitution has been made by the seller (in Order Response).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTerm>Substitution Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Substitution Status</ccts:DataTypeQualifier><ccts:DataType>Substitution Status_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubstitutionStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubstitutionStatusCodeType SubstitutionStatusCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Line Item</ccts:DictionaryEntryName><ccts:Definition>The line item itself.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTerm>Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("LineItem")]
        public LineItemType LineItem {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<LineItemType> _sellerProposedSubstituteLineItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Seller Proposed Substitute_ Line Item. Line Item</ccts:DictionaryEntryName><ccts:Definition>In Order Response, a line item proposed by the seller describing a product that might substitute for the product described in this order line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Seller Proposed Substitute</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SellerProposedSubstituteLineItem")]
        public List<LineItemType> SellerProposedSubstituteLineItem
        {
            get
            {
                return _sellerProposedSubstituteLineItem;
            }
            set
            {
                _sellerProposedSubstituteLineItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SellerProposedSubstituteLineItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SellerProposedSubstituteLineItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SellerProposedSubstituteLineItemSpecified
        {
            get
            {
                return ((this.SellerProposedSubstituteLineItem != null) 
                            && (this.SellerProposedSubstituteLineItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<LineItemType> _sellerSubstitutedLineItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Seller Substituted_ Line Item. Line Item</ccts:DictionaryEntryName><ccts:Definition>In Order Response, a line item that has replaced the original order line item. The specified quantity and pricing may differ from those in the original line item, but when a line item is substituted by the seller, it is assumed that other information, such as shipment details, will remain the same.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Seller Substituted</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SellerSubstitutedLineItem")]
        public List<LineItemType> SellerSubstitutedLineItem
        {
            get
            {
                return _sellerSubstitutedLineItem;
            }
            set
            {
                _sellerSubstitutedLineItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SellerSubstitutedLineItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SellerSubstitutedLineItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SellerSubstitutedLineItemSpecified
        {
            get
            {
                return ((this.SellerSubstitutedLineItem != null) 
                            && (this.SellerSubstitutedLineItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<LineItemType> _buyerProposedSubstituteLineItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Buyer Proposed Substitute_ Line Item. Line Item</ccts:DictionaryEntryName><ccts:Definition>A description of an item proposed by the buyer as a possible alternative to the item associated with this order line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Buyer Proposed Substitute</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("BuyerProposedSubstituteLineItem")]
        public List<LineItemType> BuyerProposedSubstituteLineItem
        {
            get
            {
                return _buyerProposedSubstituteLineItem;
            }
            set
            {
                _buyerProposedSubstituteLineItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BuyerProposedSubstituteLineItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BuyerProposedSubstituteLineItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BuyerProposedSubstituteLineItemSpecified
        {
            get
            {
                return ((this.BuyerProposedSubstituteLineItem != null) 
                            && (this.BuyerProposedSubstituteLineItem.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Catalogue_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a catalogue line associated with this order line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Catalogue</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CatalogueLineReference")]
        public LineReferenceType CatalogueLineReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Quotation_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a quotation line associated with this order line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Quotation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("QuotationLineReference")]
        public LineReferenceType QuotationLineReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<OrderLineReferenceType> _orderLineReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Order Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to another order line, such as in a replacement order or another line on the same order that is related.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTerm>Order Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Order Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Order Line Reference</ccts:RepresentationTerm></ccts:Component></para>
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
        private List<DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Order Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this order line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Order Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
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
    }
}