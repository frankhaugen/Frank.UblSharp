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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a hazardous item.</ccts:Definition><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("HazardousItemType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("HazardousItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class HazardousItemType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this hazardous item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>Round Up </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Placard Notation. Text</ccts:DictionaryEntryName><ccts:Definition>Text of the placard notation corresponding to the hazard class of this hazardous item. Can also be the hazard identification number of the orange placard (upper part) required on the means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Placard Notation</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>5.1 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlacardNotation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PlacardNotationType PlacardNotation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Placard Endorsement. Text</ccts:DictionaryEntryName><ccts:Definition>Text of the placard endorsement that is to be shown on the shipping papers for this hazardous item. Can also be used for the number of the orange placard (lower part) required on the means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Placard Endorsement</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>2 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlacardEndorsement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PlacardEndorsementType PlacardEndorsement { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalInformationType> _additionalInformation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Additional_ Information. Text</ccts:DictionaryEntryName><ccts:Definition>Text providing further information about the hazardous substance.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Information</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Must be stored away from flammable materials N.O.S. or a Waste Characteristics Code in conjunction with an EPA Waste Stream code </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalInformationType> AdditionalInformation
        {
            get
            {
                return _additionalInformation;
            }
            set
            {
                _additionalInformation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalInformation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalInformation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalInformationSpecified
        {
            get
            {
                return ((this.AdditionalInformation != null) 
                            && (this.AdditionalInformation.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. UNDG Code. Code</ccts:DictionaryEntryName><ccts:Definition>The UN code for this kind of hazardous item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>UNDG Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>UN Code</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UNDGCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UndgCodeType UndgCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Emergency Procedures Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the emergency procedures for this hazardous item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Emergency Procedures Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>EMG code, EMS Page Number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmergencyProceduresCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmergencyProceduresCodeType EmergencyProceduresCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Medical First Aid Guide Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying a medical first aid guide appropriate to this hazardous item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Medical First Aid Guide Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>MFAG page number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MedicalFirstAidGuideCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MedicalFirstAidGuideCodeType MedicalFirstAidGuideCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Technical_ Name. Name</ccts:DictionaryEntryName><ccts:Definition>The full technical name of a specific hazardous substance contained in this goods item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Technical</ccts:PropertyTermQualifier><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>Granular Sodium Chlorate WeedKiller </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TechnicalName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TechnicalNameType TechnicalName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Category. Name</ccts:DictionaryEntryName><ccts:Definition>The name of the category of hazard that applies to the Item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Category</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CategoryName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CategoryNameType CategoryName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Hazardous Category Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying a kind of hazard for a material.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Hazardous Category Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Hazardous material class code</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardousCategoryCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousCategoryCodeType HazardousCategoryCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Upper_ Orange Hazard Placard Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>The number for the upper part of the orange hazard placard required on the means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Upper</ccts:PropertyTermQualifier><ccts:PropertyTerm>Orange Hazard Placard Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Hazard identification number (upper part)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UpperOrangeHazardPlacardID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UpperOrangeHazardPlacardIdType UpperOrangeHazardPlacardId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Lower_ Orange Hazard Placard Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>The number for the lower part of the orange hazard placard required on the means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Lower</ccts:PropertyTermQualifier><ccts:PropertyTerm>Orange Hazard Placard Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Substance identification number (lower part)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LowerOrangeHazardPlacardID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LowerOrangeHazardPlacardIdType LowerOrangeHazardPlacardId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Marking Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier to the marking of the Hazardous Item</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Marking Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Dangerous goods label marking</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MarkingID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MarkingIdType MarkingId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Hazard Class Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the hazard class applicable to this hazardous item as defined by the relevant regulation authority (e.g., the IMDG Class Number of the SOLAS Convention of IMO and the ADR/RID Class Number for the road/rail environment).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Hazard Class Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>IMDG Class Number, ADR/RID Class Number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardClassID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardClassIdType HazardClassId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Net_ Weight. Measure</ccts:DictionaryEntryName><ccts:Definition>The net weight of this hazardous item, excluding packaging.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Weight</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetWeightMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetWeightMeasureType NetWeightMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Net_ Volume. Measure</ccts:DictionaryEntryName><ccts:Definition>The volume of this hazardous item, excluding packaging and transport equipment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Net</ccts:PropertyTermQualifier><ccts:PropertyTerm>Volume</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("NetVolumeMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NetVolumeMeasureType NetVolumeMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of goods items in this hazardous item that are hazardous.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Contact_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The individual, group, or body to be contacted in case of a hazardous incident associated with this item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Contact</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContactParty")]
        public PartyType ContactParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<SecondaryHazardType> _secondaryHazard;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Secondary Hazard</ccts:DictionaryEntryName><ccts:Definition>A secondary hazard associated with this hazardous item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Secondary Hazard</ccts:PropertyTerm><ccts:AssociatedObjectClass>Secondary Hazard</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Secondary Hazard</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SecondaryHazard")]
        public List<SecondaryHazardType> SecondaryHazard
        {
            get
            {
                return _secondaryHazard;
            }
            set
            {
                _secondaryHazard = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SecondaryHazard-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SecondaryHazard collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SecondaryHazardSpecified
        {
            get
            {
                return ((this.SecondaryHazard != null) 
                            && (this.SecondaryHazard.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<HazardousGoodsTransitType> _hazardousGoodsTransit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Hazardous Goods Transit</ccts:DictionaryEntryName><ccts:Definition>Information related to the transit of this kind of hazardous goods.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTerm>Hazardous Goods Transit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Hazardous Goods Transit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Hazardous Goods Transit</ccts:RepresentationTerm></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Emergency_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>The threshold temperature at which emergency procedures apply in the handling of temperature-controlled goods.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Emergency</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmergencyTemperature")]
        public TemperatureType EmergencyTemperature { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Flashpoint_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>The flashpoint temperature of this hazardous item; i.e., the lowest temperature at which vapors above a volatile combustible substance ignite in air when exposed to flame.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Flashpoint</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FlashpointTemperature")]
        public TemperatureType FlashpointTemperature { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TemperatureType> _additionalTemperature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Hazardous Item. Additional_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>Another temperature relevant to the handling of this hazardous item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Hazardous Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalTemperature")]
        public List<TemperatureType> AdditionalTemperature
        {
            get
            {
                return _additionalTemperature;
            }
            set
            {
                _additionalTemperature = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalTemperature-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalTemperature collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalTemperatureSpecified
        {
            get
            {
                return ((this.AdditionalTemperature != null) 
                            && (this.AdditionalTemperature.Count != 0));
            }
        }
    }
}
