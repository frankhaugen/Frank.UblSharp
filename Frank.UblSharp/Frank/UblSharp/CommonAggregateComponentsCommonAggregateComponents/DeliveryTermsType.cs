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
    
    
    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Details</ccts:DictionaryEntryName><ccts:Definition>A class for describing the terms and conditions applying to the delivery of goods.</ccts:Definition><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Details</ccts:DictionaryEntryName><ccts:Definition>A class for describing the terms and conditions applying to the delivery of goods.</ccts:Definition><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass></ccts:Component>")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("DeliveryTermsType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("DeliveryTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeliveryTermsType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this description of delivery terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>CIF, FOB, or EXW from the INCOTERMS Terms of Delivery. (2000 version preferred.)</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this description of delivery terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>CIF, FOB, or EXW from the INCOTERMS Terms of Delivery. (2000 version preferred.)</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Order=0, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [KeyAttribute()]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialTermsType> _specialTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Special_ Terms. Text</ccts:DictionaryEntryName><ccts:Definition>A description of any terms or conditions relating to the delivery items.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Special</ccts:PropertyTermQualifier><ccts:PropertyTerm>Terms</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Special_ Terms. Text</ccts:DictionaryEntryName><ccts:Definition>A description of any terms or conditions relating to the delivery items.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Special</ccts:PropertyTermQualifier><ccts:PropertyTerm>Terms</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("SpecialTerms", Order=1, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecialTermsType> SpecialTerms
        {
            get
            {
                return _specialTerms;
            }
            set
            {
                _specialTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the SpecialTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SpecialTermsSpecified
        {
            get
            {
                return ((this.SpecialTerms != null) 
                            && (this.SpecialTerms.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Loss Risk Responsibility Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code that identifies one of various responsibilities for loss risk in the execution of the delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Loss Risk Responsibility Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Loss Risk Responsibility Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code that identifies one of various responsibilities for loss risk in the execution of the delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Loss Risk Responsibility Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LossRiskResponsibilityCode", Order=2, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LossRiskResponsibilityCodeType LossRiskResponsibilityCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LossRiskType> _lossRisk;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Loss Risk. Text</ccts:DictionaryEntryName><ccts:Definition>A description of responsibility for risk of loss in execution of the delivery, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Loss Risk</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Loss Risk. Text</ccts:DictionaryEntryName><ccts:Definition>A description of responsibility for risk of loss in execution of the delivery, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Loss Risk</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("LossRisk", Order=3, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LossRiskType> LossRisk
        {
            get
            {
                return _lossRisk;
            }
            set
            {
                _lossRisk = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LossRisk collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool LossRiskSpecified
        {
            get
            {
                return ((this.LossRisk != null) 
                            && (this.LossRisk.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount covered by these delivery terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount covered by these delivery terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Amount", Order=4, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AmountType_2 Amount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Delivery_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location for the contracted delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Delivery_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location for the contracted delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryLocation", Order=5)]
        public LocationType DeliveryLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge covered by these delivery terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery Terms. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge covered by these delivery terms.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery Terms</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AllowanceCharge", Order=6)]
        public AllowanceChargeType AllowanceCharge { get; set; }
    }
}
