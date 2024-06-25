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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe utility consumption, including details of the environment in which consumption takes place.</ccts:Definition><ccts:ObjectClass>Consumption Report</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("ConsumptionReportType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ConsumptionReport", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsumptionReportType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consumption report.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>n/a</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Consumption Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of consumption, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Consumption Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Consumption</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsumptionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumptionTypeType ConsumptionType { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Consumption Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of consumption, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Consumption Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Consumption</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsumptionTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumptionTypeCodeType ConsumptionTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text reporting utility consumption.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>This report contain the latest year consumption</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Description-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Total_ Consumed Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total quantity consumed.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Consumed Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>20479.00</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalConsumedQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalConsumedQuantityType TotalConsumedQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Basic_ Consumed Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The basic quantity consumed, excluding additional consumption.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTermQualifier>Basic</ccts:PropertyTermQualifier><ccts:PropertyTerm>Consumed Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>20000.00</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BasicConsumedQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BasicConsumedQuantityType BasicConsumedQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Resident_ Occupants Numeric. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of people occupying the residence covered by this report.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTermQualifier>Resident</ccts:PropertyTermQualifier><ccts:PropertyTerm>Occupants Numeric</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType><ccts:Examples>4.0</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ResidentOccupantsNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResidentOccupantsNumericType ResidentOccupantsNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Consumers_ Energy Level Code. Code</ccts:DictionaryEntryName><ccts:Definition>The level of energy consumed, compared to the average for this residence type and the number of people living in the residence, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTermQualifier>Consumers</ccts:PropertyTermQualifier><ccts:PropertyTerm>Energy Level Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>B</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsumersEnergyLevelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumersEnergyLevelCodeType ConsumersEnergyLevelCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Consumers_ Energy Level. Text</ccts:DictionaryEntryName><ccts:Definition>The level of energy consumed, compared to the average for this residence type and the number of people living in the residence, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTermQualifier>Consumers</ccts:PropertyTermQualifier><ccts:PropertyTerm>Energy Level</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Middel</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ConsumersEnergyLevel", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumersEnergyLevelType ConsumersEnergyLevel { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Residence Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of residence (house, apartment, etc.) covered in this report, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Residence Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>House</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ResidenceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResidenceTypeType ResidenceType { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Residence Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of residence (house, apartment, etc.) covered in this report, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Residence Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>House</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ResidenceTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResidenceTypeCodeType ResidenceTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Heating Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of heating in the residence covered in this report, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Heating Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>District heating</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HeatingType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HeatingTypeType HeatingType { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Heating Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of heating in the residence covered in this report, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Heating Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>DistrictHeating</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HeatingTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HeatingTypeCodeType HeatingTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Period</ccts:DictionaryEntryName><ccts:Definition>The period of consumption covered in this report.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Period")]
        public PeriodType Period { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Guidance_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document providing an explanation of this kind of report.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTermQualifier>Guidance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GuidanceDocumentReference")]
        public DocumentReferenceType GuidanceDocumentReference { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to some other document (for example, this report in another format).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType DocumentReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ConsumptionReportReferenceType> _consumptionReportReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Consumption Report Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a previous consumption report.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Consumption Report Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption Report Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption Report Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConsumptionReportReference")]
        public List<ConsumptionReportReferenceType> ConsumptionReportReference
        {
            get
            {
                return _consumptionReportReference;
            }
            set
            {
                _consumptionReportReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ConsumptionReportReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ConsumptionReportReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConsumptionReportReferenceSpecified
        {
            get
            {
                return ((this.ConsumptionReportReference != null) 
                            && (this.ConsumptionReportReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ConsumptionHistoryType> _consumptionHistory;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Report. Consumption History</ccts:DictionaryEntryName><ccts:Definition>A report describing historical parameters relating to a specific instance of consumption.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Report</ccts:ObjectClass><ccts:PropertyTerm>Consumption History</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption History</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption History</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConsumptionHistory")]
        public List<ConsumptionHistoryType> ConsumptionHistory
        {
            get
            {
                return _consumptionHistory;
            }
            set
            {
                _consumptionHistory = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ConsumptionHistory-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ConsumptionHistory collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConsumptionHistorySpecified
        {
            get
            {
                return ((this.ConsumptionHistory != null) 
                            && (this.ConsumptionHistory.Count != 0));
            }
        }
    }
}
