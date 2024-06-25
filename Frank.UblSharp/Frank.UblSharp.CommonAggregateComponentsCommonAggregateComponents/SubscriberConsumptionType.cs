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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Details</ccts:DictionaryEntryName><ccts:Definition>The consumption for a specific party for given consumption point provided by a numbers of suppliers. An enterprise can have one utility statement for several parties (e.g. a ministry of defence receiving a telephone bill). In this way each subscriber consumption represent a sub utility statement.</ccts:Definition><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("SubscriberConsumptionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("SubscriberConsumption", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SubscriberConsumptionType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Consumption Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>The identifier tor this specification.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTerm>Consumption Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsumptionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumptionIdType ConsumptionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Specification Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The code which specifies the type of this specification, e.g. an on account specification or the yearly specification.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTerm>Specification Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SpecificationTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecificationTypeCodeType SpecificationTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>This is how we have calculating your yearly statement</ccts:Examples></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Total Metered Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total quantity consumed, as calculated from meter readings.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTerm>Total Metered Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>2000.0</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalMeteredQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalMeteredQuantityType TotalMeteredQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Subscriber_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party subscribing to the utility.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTermQualifier>Subscriber</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubscriberParty")]
        public PartyType SubscriberParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Utility_ Consumption Point. Consumption Point</ccts:DictionaryEntryName><ccts:Definition>The point at which the utility is consumed.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTermQualifier>Utility</ccts:PropertyTermQualifier><ccts:PropertyTerm>Consumption Point</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption Point</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption Point</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("UtilityConsumptionPoint")]
        public ConsumptionPointType UtilityConsumptionPoint { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<OnAccountPaymentType> _onAccountPayment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. On Account Payment</ccts:DictionaryEntryName><ccts:Definition>The planned prepayments (on account) regarding this subscription.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTerm>On Account Payment</ccts:PropertyTerm><ccts:AssociatedObjectClass>On Account Payment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>On Account Payment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OnAccountPayment")]
        public List<OnAccountPaymentType> OnAccountPayment
        {
            get
            {
                return _onAccountPayment;
            }
            set
            {
                _onAccountPayment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OnAccountPayment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OnAccountPayment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OnAccountPaymentSpecified
        {
            get
            {
                return ((this.OnAccountPayment != null) 
                            && (this.OnAccountPayment.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Consumption</ccts:DictionaryEntryName><ccts:Definition>The consumption in case the consumption is from one and only one supplier.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTerm>Consumption</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Consumption")]
        public ConsumptionType Consumption {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<SupplierConsumptionType> _supplierConsumption;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Subscriber Consumption. Supplier Consumption</ccts:DictionaryEntryName><ccts:Definition>The consumption in case the consumption is from more than one supplier.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Subscriber Consumption</ccts:ObjectClass><ccts:PropertyTerm>Supplier Consumption</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Consumption</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Consumption</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SupplierConsumption")]
        public List<SupplierConsumptionType> SupplierConsumption
        {
            get
            {
                return _supplierConsumption;
            }
            set
            {
                _supplierConsumption = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SupplierConsumption-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SupplierConsumption collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SupplierConsumptionSpecified
        {
            get
            {
                return ((this.SupplierConsumption != null) 
                            && (this.SupplierConsumption.Count != 0));
            }
        }
    }
}