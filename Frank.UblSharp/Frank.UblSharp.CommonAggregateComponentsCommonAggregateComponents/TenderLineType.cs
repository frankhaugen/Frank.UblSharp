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
    [XmlTypeAttribute("TenderLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(SubTenderLine))]
    [XmlIncludeAttribute(typeof(TenderLine))]
    public partial class TenderLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this tender line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of the item quoted in this tender line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Line Extension Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total amount for this tender line, including allowance charges but net of taxes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Line Extension Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LineExtensionAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LineExtensionAmountType LineExtensionAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Total_ Tax Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total tax amount for this tender line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tax Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalTaxAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalTaxAmountType TotalTaxAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Orderable_ Unit. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing a unit in which the item described in this tender line can be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Orderable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Unit</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OrderableUnit", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderableUnitType OrderableUnit { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Content Unit. Quantity</ccts:DictionaryEntryName><ccts:Definition>The unit of measure and quantity of the orderable unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Content Unit</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>If order unit measure identifier is each , then content unit quantity is 1 .</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContentUnitQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContentUnitQuantityType ContentUnitQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Order Quantity Increment. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of items that can set the order quantity increments.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Order Quantity Increment</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OrderQuantityIncrementNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Minimum_ Order Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The minimum number of items described in this tender line that can be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Order Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>10 boxes </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumOrderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumOrderQuantityType MinimumOrderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Maximum_ Order Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The maximum number of items described in this tender line that can be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Order Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>1 tonne </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumOrderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumOrderQuantityType MaximumOrderQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WarrantyInformationType> _warrantyInformation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Warranty_ Information. Text</ccts:DictionaryEntryName><ccts:Definition>Text about a warranty (provided by WarrantyParty) for the good or service described in this tender line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Unless specified otherwise and in addition to any rights the Customer may have under statute, Dell warrants to the Customer that Dell branded Products (excluding third party products and software), will be free from defects in materials and workmanship affecting normal use for a period of one year from invoice date ( Standard Warranty ). </ccts:Examples></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Pack Level Code. Code</ccts:DictionaryEntryName><ccts:Definition>A mutually agreed code signifying the level of packaging associated with the item described in this tender line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Pack Level Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Consumer Unit, Trading Unit</ccts:AlternativeBusinessTerms><ccts:Examples>level 2 , Group 4 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PackLevelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackLevelCodeType PackLevelCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this tender line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with this tender line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Item")]
        public ItemType Item {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<ItemLocationQuantityType> _offeredItemLocationQuantity;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Offered_ Item Location Quantity. Item Location Quantity</ccts:DictionaryEntryName><ccts:Definition>A set of location-specific properties (e.g., price, quantity, lead time) associated with the item described in this tender line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Offered</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Location Quantity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Location Quantity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Location Quantity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OfferedItemLocationQuantity")]
        public List<ItemLocationQuantityType> OfferedItemLocationQuantity
        {
            get
            {
                return _offeredItemLocationQuantity;
            }
            set
            {
                _offeredItemLocationQuantity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OfferedItemLocationQuantity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OfferedItemLocationQuantity collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OfferedItemLocationQuantitySpecified
        {
            get
            {
                return ((this.OfferedItemLocationQuantity != null) 
                            && (this.OfferedItemLocationQuantity.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<RelatedItemType> _replacementRelatedItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Replacement_ Related Item. Related Item</ccts:DictionaryEntryName><ccts:Definition>A catalogue item that may be a replacement for the item described in this tender line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Replacement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Related Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Related Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Related Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReplacementRelatedItem")]
        public List<RelatedItemType> ReplacementRelatedItem
        {
            get
            {
                return _replacementRelatedItem;
            }
            set
            {
                _replacementRelatedItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReplacementRelatedItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReplacementRelatedItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReplacementRelatedItemSpecified
        {
            get
            {
                return ((this.ReplacementRelatedItem != null) 
                            && (this.ReplacementRelatedItem.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Warranty_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party responsible for any warranty described in this tender line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarrantyParty")]
        public PartyType WarrantyParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Warranty Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period for which a warranty associated with the item described in this tender line is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Warranty Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WarrantyValidityPeriod")]
        public PeriodType WarrantyValidityPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TenderLineType> _subTenderLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Sub_ Tender Line. Tender Line</ccts:DictionaryEntryName><ccts:Definition>An association to a Sub Tender Line</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Sub</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tender Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tender Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tender Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SubTenderLine")]
        public List<TenderLineType> SubTenderLine
        {
            get
            {
                return _subTenderLine;
            }
            set
            {
                _subTenderLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SubTenderLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SubTenderLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubTenderLineSpecified
        {
            get
            {
                return ((this.SubTenderLine != null) 
                            && (this.SubTenderLine.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Call For Tenders_ Line Reference. Line Reference</ccts:DictionaryEntryName><ccts:Definition>Reference to a Line on a Call For Tenders document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Call For Tenders</ccts:PropertyTermQualifier><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CallForTendersLineReference")]
        public LineReferenceType CallForTendersLineReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Line. Call For Tenders_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A class defining references to a Call For Tenders document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Call For Tenders</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CallForTendersDocumentReference")]
        public DocumentReferenceType CallForTendersDocumentReference { get; set; }
    }
}
