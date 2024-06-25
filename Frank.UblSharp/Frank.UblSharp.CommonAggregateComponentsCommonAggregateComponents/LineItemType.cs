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
    [XmlTypeAttribute("LineItemType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AlternativeLineItem))]
    [XmlIncludeAttribute(typeof(BuyerProposedSubstituteLineItem))]
    [XmlIncludeAttribute(typeof(LineItem))]
    [XmlIncludeAttribute(typeof(SellerProposedSubstituteLineItem))]
    [XmlIncludeAttribute(typeof(SellerSubstitutedLineItem))]
    [XmlIncludeAttribute(typeof(SubLineItem))]
    public partial class LineItemType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this line item, assigned by the buyer.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Sales_ Order Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this line item, assigned by the seller.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Sales</ccts:PropertyTermQualifier><ccts:PropertyTerm>Order Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SalesOrderID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SalesOrderIdType SalesOrderId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Line Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the status of this line item with respect to its original state.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Line Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Line Status</ccts:DataTypeQualifier><ccts:DataType>Line Status_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LineStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LineStatusCodeType LineStatusCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of items associated with this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Line Extension Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total amount for this line item, including allowance charges but net of taxes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Line Extension Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LineExtensionAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LineExtensionAmountType LineExtensionAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Total_ Tax Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total tax amount for this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tax Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalTaxAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalTaxAmountType TotalTaxAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Minimum_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The minimum quantity of the item associated with this line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumQuantityType MinimumQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Maximum_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The maximum quantity of the item associated with this line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumQuantityType MaximumQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Minimum_ Backorder. Quantity</ccts:DictionaryEntryName><ccts:Definition>The minimum back order quantity of the item associated with this line (where back order is allowed).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Backorder</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumBackorderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumBackorderQuantityType MinimumBackorderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Maximum_ Backorder. Quantity</ccts:DictionaryEntryName><ccts:Definition>The maximum back order quantity of the item associated with this line (where back order is allowed).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Backorder</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumBackorderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumBackorderQuantityType MaximumBackorderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Inspection Method Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the inspection requirements for the item associated with this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Inspection Method Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InspectionMethodCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InspectionMethodCodeType InspectionMethodCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Partial Delivery Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that a partial delivery is allowed (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Partial Delivery Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PartialDeliveryIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PartialDeliveryIndicatorType PartialDeliveryIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Back Order Allowed Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that back order is allowed (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Back Order Allowed Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BackOrderAllowedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BackOrderAllowedIndicatorType BackOrderAllowedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Accounting Cost Code. Code</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this line item, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCostCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostCodeType AccountingCostCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Accounting Cost. Text</ccts:DictionaryEntryName><ccts:Definition>The buyer's accounting cost centre for this line item, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Accounting Cost</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingCost", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostType AccountingCost { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WarrantyInformationType> _warrantyInformation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Warranty_ Information. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing a warranty (provided by WarrantyParty) for the good or service described in this line item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Unless specified otherwise and in addition to any rights the Customer may have under statute, Dell warrants to the Customer that Dell branded Products (excluding third party products and software), will be free from defects in materials and workmanship affecting normal use for a period of one year from invoice date ( Standard Warranty ). </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("WarrantyInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WarrantyInformationType> WarrantyInformation
        {
            get
            {
                return _warrantyInformation;
            }
            set
            {
                _warrantyInformation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die WarrantyInformation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the WarrantyInformation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WarrantyInformationSpecified
        {
            get
            {
                return ((this.WarrantyInformation != null) 
                            && (this.WarrantyInformation.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryType> _delivery;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Delivery</ccts:DictionaryEntryName><ccts:Definition>A delivery associated with this line item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Delivery Terms</ccts:DictionaryEntryName><ccts:Definition>Terms and conditions of the delivery associated with this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Delivery Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType DeliveryTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Originator_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party who originated the Order associated with this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Originator</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginatorParty")]
        public PartyType OriginatorParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<OrderedShipmentType> _orderedShipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Ordered Shipment</ccts:DictionaryEntryName><ccts:Definition>An ordered shipment associated with this line item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Ordered Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Ordered Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Ordered Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OrderedShipment")]
        public List<OrderedShipmentType> OrderedShipment
        {
            get
            {
                return _orderedShipment;
            }
            set
            {
                _orderedShipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OrderedShipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OrderedShipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrderedShipmentSpecified
        {
            get
            {
                return ((this.OrderedShipment != null) 
                            && (this.OrderedShipment.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Pricing Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to pricing and item location information associated with this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Pricing Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Pricing Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Pricing Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PricingReference")]
        public PricingReferenceType PricingReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _allowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge associated with this line item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Price</ccts:DictionaryEntryName><ccts:Definition>The price of the item of trade associated with this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Price")]
        public PriceType Price { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Item</ccts:DictionaryEntryName><ccts:Definition>The item of trade associated with this line item.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Item")]
        public ItemType Item {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<LineItemType> _subLineItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Sub_ Line Item. Line Item</ccts:DictionaryEntryName><ccts:Definition>The subsidiary line items that constitute the main line item, such as in a bill of materials.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Sub</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SubLineItem")]
        public List<LineItemType> SubLineItem
        {
            get
            {
                return _subLineItem;
            }
            set
            {
                _subLineItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SubLineItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SubLineItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubLineItemSpecified
        {
            get
            {
                return ((this.SubLineItem != null) 
                            && (this.SubLineItem.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Warranty Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which the warranty associated with this line item is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarrantyValidityPeriod")]
        public PeriodType WarrantyValidityPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Warranty_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party responsible for any warranty associated with this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarrantyParty")]
        public PartyType WarrantyParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TaxTotalType> _taxTotal;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Tax Total</ccts:DictionaryEntryName><ccts:Definition>A total amount of taxes of a particular kind applicable to this item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Tax Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Total</ccts:RepresentationTerm></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Item_ Price Extension. Price Extension</ccts:DictionaryEntryName><ccts:Definition>The price extension, calculated by multiplying the price per unit by the quantity of items.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Item</ccts:PropertyTermQualifier><ccts:PropertyTerm>Price Extension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price Extension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price Extension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ItemPriceExtension")]
        public PriceExtensionType ItemPriceExtension { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<LineReferenceType> _lineReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Item. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a line in a document associated with this line item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Line Item</ccts:ObjectClass><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("LineReference")]
        public List<LineReferenceType> LineReference
        {
            get
            {
                return _lineReference;
            }
            set
            {
                _lineReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LineReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the LineReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LineReferenceSpecified
        {
            get
            {
                return ((this.LineReference != null) 
                            && (this.LineReference.Count != 0));
            }
        }
    }
}
