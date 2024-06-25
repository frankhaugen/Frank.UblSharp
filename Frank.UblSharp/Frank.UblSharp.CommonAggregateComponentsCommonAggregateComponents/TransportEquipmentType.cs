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
    [XmlTypeAttribute("TransportEquipmentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AttachedTransportEquipment))]
    [XmlIncludeAttribute(typeof(ContainedInTransportEquipment))]
    [XmlIncludeAttribute(typeof(ContainingTransportEquipment))]
    [XmlIncludeAttribute(typeof(ReferencedTransportEquipment))]
    [XmlIncludeAttribute(typeof(SupportedTransportEquipment))]
    [XmlIncludeAttribute(typeof(TransportEquipment))]
    [XmlIncludeAttribute(typeof(UnsupportedTransportEquipment))]
    public partial class TransportEquipmentType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>OCLU 1234567 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReferencedConsignmentIdType> _referencedConsignmentId;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Referenced_ Consignment Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the consignment contained by this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Referenced</ccts:PropertyTermQualifier><ccts:PropertyTerm>Consignment Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReferencedConsignmentID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReferencedConsignmentIdType> ReferencedConsignmentId
        {
            get
            {
                return _referencedConsignmentId;
            }
            set
            {
                _referencedConsignmentId = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReferencedConsignmentId-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReferencedConsignmentId collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReferencedConsignmentIdSpecified
        {
            get
            {
                return ((this.ReferencedConsignmentId != null) 
                            && (this.ReferencedConsignmentId.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Transport Equipment Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Transport Equipment Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Transport Equipment Type</ccts:DataTypeQualifier><ccts:DataType>Transport Equipment Type_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportEquipmentTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportEquipmentTypeCodeType TransportEquipmentTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Provider Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of provider of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Provider Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProviderTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProviderTypeCodeType ProviderTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Owner Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of owner of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Owner Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OwnerTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OwnerTypeCodeType OwnerTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Size Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the size and type of this piece of piece of transport equipment. When the piece of transport equipment is a shipping container, it is recommended to use ContainerSizeTypeCode for validation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Size Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Container Size Type Code</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SizeTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SizeTypeCodeType SizeTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Disposition Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the current disposition of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Disposition Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Status</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DispositionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DispositionCodeType DispositionCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Fullness Indication Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying whether this piece of transport equipment is full, partially full, or empty.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Fullness Indication Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FullnessIndicationCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FullnessIndicationCodeType FullnessIndicationCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Refrigeration On_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this piece of transport equipment's refrigeration is on (true) or off (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Refrigeration On</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RefrigerationOnIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RefrigerationOnIndicatorType RefrigerationOnIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InformationType> _information;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Information. Text</ccts:DictionaryEntryName><ccts:Definition>Additional information about this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Information", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InformationType> Information
        {
            get
            {
                return _information;
            }
            set
            {
                _information = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Information-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Information collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InformationSpecified
        {
            get
            {
                return ((this.Information != null) 
                            && (this.Information.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Returnability_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this piece of transport equipment is returnable (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Returnability</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReturnabilityIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReturnabilityIndicatorType ReturnabilityIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Legal Status_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indication of the legal status of this piece of transport equipment with respect to the Container Convention Code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Legal Status</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LegalStatusIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LegalStatusIndicatorType LegalStatusIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Air Flow Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The percent of the airflow within this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Air Flow Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AirFlowPercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AirFlowPercentType AirFlowPercent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Humidity Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The percent humidity within this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Humidity Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HumidityPercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HumidityPercentType HumidityPercent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Animal Food_ Approved Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this piece of transport equipment is approved for animal food (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Animal Food</ccts:PropertyTermQualifier><ccts:PropertyTerm>Approved Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AnimalFoodApprovedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AnimalFoodApprovedIndicatorType AnimalFoodApprovedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Human Food_ Approved Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this piece of transport equipment is approved for human food (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Human Food</ccts:PropertyTermQualifier><ccts:PropertyTerm>Approved Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HumanFoodApprovedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HumanFoodApprovedIndicatorType HumanFoodApprovedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Dangerous Goods_ Approved Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this piece of transport equipment is approved for dangerous goods (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Dangerous Goods</ccts:PropertyTermQualifier><ccts:PropertyTerm>Approved Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DangerousGoodsApprovedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DangerousGoodsApprovedIndicatorType DangerousGoodsApprovedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Refrigerated_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this piece of transport equipment is refrigerated (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Refrigerated</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RefrigeratedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RefrigeratedIndicatorType RefrigeratedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Characteristics. Text</ccts:DictionaryEntryName><ccts:Definition>Characteristics of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Characteristics</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Characteristics", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CharacteristicsType Characteristics { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DamageRemarksType> _damageRemarks;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Damage_ Remarks. Text</ccts:DictionaryEntryName><ccts:Definition>Damage associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Damage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Remarks</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DamageRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DamageRemarksType> DamageRemarks
        {
            get
            {
                return _damageRemarks;
            }
            set
            {
                _damageRemarks = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DamageRemarks-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DamageRemarks collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DamageRemarksSpecified
        {
            get
            {
                return ((this.DamageRemarks != null) 
                            && (this.DamageRemarks.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialTransportRequirementsType> _specialTransportRequirements;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Special_ Transport Requirements. Text</ccts:DictionaryEntryName><ccts:Definition>Special transport requirements expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Special</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Requirements</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SpecialTransportRequirements", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialTransportRequirementsType> SpecialTransportRequirements
        {
            get
            {
                return _specialTransportRequirements;
            }
            set
            {
                _specialTransportRequirements = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SpecialTransportRequirements-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SpecialTransportRequirements collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SpecialTransportRequirementsSpecified
        {
            get
            {
                return ((this.SpecialTransportRequirements != null) 
                            && (this.SpecialTransportRequirements.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Gross_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The gross weight of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossWeightMeasureType GrossWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Gross_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The gross volume of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Gross</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GrossVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GrossVolumeMeasureType GrossVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Tare_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The weight of this piece of transport equipment when empty.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Tare</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TareWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TareWeightMeasureType TareWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Tracking Device Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the tracking device for this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Tracking Device Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TrackingDeviceCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TrackingDeviceCodeType TrackingDeviceCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Power. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this piece of transport equipment can supply power (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Power</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PowerIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PowerIndicatorType PowerIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Trace_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for use in tracing this piece of transport equipment, such as the EPC number used in RFID.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Trace</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TraceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TraceIdType TraceId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DimensionType> _measurementDimension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>A measurable dimension (length, mass, weight, or volume) of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MeasurementDimension")]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeasurementDimension-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MeasurementDimension collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MeasurementDimensionSpecified
        {
            get
            {
                return ((this.MeasurementDimension != null) 
                            && (this.MeasurementDimension.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentSealType> _transportEquipmentSeal;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Transport Equipment Seal</ccts:DictionaryEntryName><ccts:Definition>A seal securing the door of a piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Transport Equipment Seal</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment Seal</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment Seal</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportEquipmentSeal")]
        public List<TransportEquipmentSealType> TransportEquipmentSeal
        {
            get
            {
                return _transportEquipmentSeal;
            }
            set
            {
                _transportEquipmentSeal = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportEquipmentSeal-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportEquipmentSeal collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportEquipmentSealSpecified
        {
            get
            {
                return ((this.TransportEquipmentSeal != null) 
                            && (this.TransportEquipmentSeal.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Minimum_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>In the case of a refrigeration unit, the minimum allowable operating temperature for this container.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumTemperature")]
        public TemperatureType MinimumTemperature { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Maximum_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>In the case of a refrigeration unit, the maximum allowable operating temperature for this container.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumTemperature")]
        public TemperatureType MaximumTemperature { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Provider_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party providing this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Provider</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProviderParty")]
        public PartyType ProviderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Loading Proof_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The authorized party responsible for certifying that the goods were loaded into this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading Proof</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Party responsible for proof of vanning (WCO ID 059)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LoadingProofParty")]
        public PartyType LoadingProofParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Supplier Party</ccts:DictionaryEntryName><ccts:Definition>The party that supplies this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Supplier Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Party responsible for proof of vanning (WCO ID 059)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SupplierParty")]
        public SupplierPartyType SupplierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Owner_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that owns this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Owner</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Party responsible for proof of vanning (WCO ID 059)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OwnerParty")]
        public PartyType OwnerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Operating_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that operates this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Operating</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Party responsible for proof of vanning (WCO ID 059)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OperatingParty")]
        public PartyType OperatingParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Loading_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location where this piece of transport equipment is loaded.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Vanning address (WCO ID 068), Stuffing location</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LoadingLocation")]
        public LocationType LoadingLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Unloading_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location where this piece of transport equipment is unloaded.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Unloading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UnloadingLocation")]
        public LocationType UnloadingLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Storage_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location where this piece of transport equipment is being stored.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Storage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StorageLocation")]
        public LocationType StorageLocation { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _positioningTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Positioning_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A positioning of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Positioning</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PositioningTransportEvent")]
        public List<TransportEventType> PositioningTransportEvent
        {
            get
            {
                return _positioningTransportEvent;
            }
            set
            {
                _positioningTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PositioningTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PositioningTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PositioningTransportEventSpecified
        {
            get
            {
                return ((this.PositioningTransportEvent != null) 
                            && (this.PositioningTransportEvent.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _quarantineTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Quarantine_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A quarantine of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Quarantine</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("QuarantineTransportEvent")]
        public List<TransportEventType> QuarantineTransportEvent
        {
            get
            {
                return _quarantineTransportEvent;
            }
            set
            {
                _quarantineTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die QuarantineTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the QuarantineTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool QuarantineTransportEventSpecified
        {
            get
            {
                return ((this.QuarantineTransportEvent != null) 
                            && (this.QuarantineTransportEvent.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _deliveryTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Delivery_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A delivery of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeliveryTransportEvent")]
        public List<TransportEventType> DeliveryTransportEvent
        {
            get
            {
                return _deliveryTransportEvent;
            }
            set
            {
                _deliveryTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DeliveryTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliveryTransportEventSpecified
        {
            get
            {
                return ((this.DeliveryTransportEvent != null) 
                            && (this.DeliveryTransportEvent.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _pickupTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Pickup_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A pickup of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Pickup</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PickupTransportEvent")]
        public List<TransportEventType> PickupTransportEvent
        {
            get
            {
                return _pickupTransportEvent;
            }
            set
            {
                _pickupTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PickupTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PickupTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PickupTransportEventSpecified
        {
            get
            {
                return ((this.PickupTransportEvent != null) 
                            && (this.PickupTransportEvent.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _handlingTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Handling_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A handling of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Handling</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HandlingTransportEvent")]
        public List<TransportEventType> HandlingTransportEvent
        {
            get
            {
                return _handlingTransportEvent;
            }
            set
            {
                _handlingTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HandlingTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HandlingTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HandlingTransportEventSpecified
        {
            get
            {
                return ((this.HandlingTransportEvent != null) 
                            && (this.HandlingTransportEvent.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _loadingTransportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Loading_ Transport Event. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A loading of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Loading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("LoadingTransportEvent")]
        public List<TransportEventType> LoadingTransportEvent
        {
            get
            {
                return _loadingTransportEvent;
            }
            set
            {
                _loadingTransportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LoadingTransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the LoadingTransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LoadingTransportEventSpecified
        {
            get
            {
                return ((this.LoadingTransportEvent != null) 
                            && (this.LoadingTransportEvent.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEventType> _transportEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Transport Event</ccts:DictionaryEntryName><ccts:Definition>A transport event associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Transport Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportEvent")]
        public List<TransportEventType> TransportEvent
        {
            get
            {
                return _transportEvent;
            }
            set
            {
                _transportEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportEventSpecified
        {
            get
            {
                return ((this.TransportEvent != null) 
                            && (this.TransportEvent.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Applicable_ Transport Means. Transport Means</ccts:DictionaryEntryName><ccts:Definition>The applicable transport means associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Applicable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Means</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Means</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Means</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ApplicableTransportMeans")]
        public TransportMeansType ApplicableTransportMeans { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TradingTermsType> _haulageTradingTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Haulage_ Trading Terms. Trading Terms</ccts:DictionaryEntryName><ccts:Definition>A set of haulage trading terms associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Haulage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Trading Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Trading Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Trading Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HaulageTradingTerms")]
        public List<TradingTermsType> HaulageTradingTerms
        {
            get
            {
                return _haulageTradingTerms;
            }
            set
            {
                _haulageTradingTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HaulageTradingTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HaulageTradingTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HaulageTradingTermsSpecified
        {
            get
            {
                return ((this.HaulageTradingTerms != null) 
                            && (this.HaulageTradingTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<HazardousGoodsTransitType> _hazardousGoodsTransit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Hazardous Goods Transit</ccts:DictionaryEntryName><ccts:Definition>Transit-related information regarding a type of hazardous goods contained in this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Hazardous Goods Transit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Hazardous Goods Transit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Hazardous Goods Transit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HazardousGoodsTransit")]
        public List<HazardousGoodsTransitType> HazardousGoodsTransit
        {
            get
            {
                return _hazardousGoodsTransit;
            }
            set
            {
                _hazardousGoodsTransit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HazardousGoodsTransit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HazardousGoodsTransit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HazardousGoodsTransitSpecified
        {
            get
            {
                return ((this.HazardousGoodsTransit != null) 
                            && (this.HazardousGoodsTransit.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportHandlingUnitType> _packagedTransportHandlingUnit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Packaged_ Transport Handling Unit. Transport Handling Unit</ccts:DictionaryEntryName><ccts:Definition>A packaged transport handling unit associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Packaged</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Handling Unit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Handling Unit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Handling Unit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PackagedTransportHandlingUnit")]
        public List<TransportHandlingUnitType> PackagedTransportHandlingUnit
        {
            get
            {
                return _packagedTransportHandlingUnit;
            }
            set
            {
                _packagedTransportHandlingUnit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PackagedTransportHandlingUnit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PackagedTransportHandlingUnit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PackagedTransportHandlingUnitSpecified
        {
            get
            {
                return ((this.PackagedTransportHandlingUnit != null) 
                            && (this.PackagedTransportHandlingUnit.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _serviceAllowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Service_ Allowance Charge. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A service allowance charge associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Service</ccts:PropertyTermQualifier><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ServiceAllowanceCharge")]
        public List<AllowanceChargeType> ServiceAllowanceCharge
        {
            get
            {
                return _serviceAllowanceCharge;
            }
            set
            {
                _serviceAllowanceCharge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ServiceAllowanceCharge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ServiceAllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ServiceAllowanceChargeSpecified
        {
            get
            {
                return ((this.ServiceAllowanceCharge != null) 
                            && (this.ServiceAllowanceCharge.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _freightAllowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Freight_ Allowance Charge. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>A freight allowance charge associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight</ccts:PropertyTermQualifier><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FreightAllowanceCharge")]
        public List<AllowanceChargeType> FreightAllowanceCharge
        {
            get
            {
                return _freightAllowanceCharge;
            }
            set
            {
                _freightAllowanceCharge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FreightAllowanceCharge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FreightAllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FreightAllowanceChargeSpecified
        {
            get
            {
                return ((this.FreightAllowanceCharge != null) 
                            && (this.FreightAllowanceCharge.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentType> _attachedTransportEquipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Attached_ Transport Equipment. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>A piece of transport equipment attached to this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Attached</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AttachedTransportEquipment")]
        public List<TransportEquipmentType> AttachedTransportEquipment
        {
            get
            {
                return _attachedTransportEquipment;
            }
            set
            {
                _attachedTransportEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AttachedTransportEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AttachedTransportEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AttachedTransportEquipmentSpecified
        {
            get
            {
                return ((this.AttachedTransportEquipment != null) 
                            && (this.AttachedTransportEquipment.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Delivery</ccts:DictionaryEntryName><ccts:Definition>The delivery of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Delivery")]
        public DeliveryType Delivery {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Pickup</ccts:DictionaryEntryName><ccts:Definition>The pickup of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Pickup</ccts:PropertyTerm><ccts:AssociatedObjectClass>Pickup</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Pickup</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Pickup")]
        public PickupType Pickup {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Despatch</ccts:DictionaryEntryName><ccts:Definition>The despatch of this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Despatch</ccts:PropertyTerm><ccts:AssociatedObjectClass>Despatch</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Despatch</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Despatch")]
        public DespatchType Despatch { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _shipmentDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Shipment_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a shipping document associated with this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Shipment</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShipmentDocumentReference")]
        public List<DocumentReferenceType> ShipmentDocumentReference
        {
            get
            {
                return _shipmentDocumentReference;
            }
            set
            {
                _shipmentDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ShipmentDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ShipmentDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShipmentDocumentReferenceSpecified
        {
            get
            {
                return ((this.ShipmentDocumentReference != null) 
                            && (this.ShipmentDocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentType> _containedInTransportEquipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Contained In_ Transport Equipment. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>A piece of transport equipment contained in this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTermQualifier>Contained In</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm><ccts:Examples>e.g. pallets inside containers</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContainedInTransportEquipment")]
        public List<TransportEquipmentType> ContainedInTransportEquipment
        {
            get
            {
                return _containedInTransportEquipment;
            }
            set
            {
                _containedInTransportEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContainedInTransportEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContainedInTransportEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContainedInTransportEquipmentSpecified
        {
            get
            {
                return ((this.ContainedInTransportEquipment != null) 
                            && (this.ContainedInTransportEquipment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PackageType> _package;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Package</ccts:DictionaryEntryName><ccts:Definition>A package contained in this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Package</ccts:PropertyTerm><ccts:AssociatedObjectClass>Package</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Package</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Package")]
        public List<PackageType> Package
        {
            get
            {
                return _package;
            }
            set
            {
                _package = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Package-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Package collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PackageSpecified
        {
            get
            {
                return ((this.Package != null) 
                            && (this.Package.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<GoodsItemType> _goodsItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Goods Item</ccts:DictionaryEntryName><ccts:Definition>A goods item contained in this piece of transport equipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:PropertyTerm>Goods Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Goods Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Goods Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("GoodsItem")]
        public List<GoodsItemType> GoodsItem
        {
            get
            {
                return _goodsItem;
            }
            set
            {
                _goodsItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die GoodsItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the GoodsItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool GoodsItemSpecified
        {
            get
            {
                return ((this.GoodsItem != null) 
                            && (this.GoodsItem.Count != 0));
            }
        }
    }
}
