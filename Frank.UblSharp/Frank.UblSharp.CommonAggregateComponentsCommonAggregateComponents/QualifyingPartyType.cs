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
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("QualifyingPartyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AdditionalQualifyingParty))]
    [XmlIncludeAttribute(typeof(MainQualifyingParty))]
    [XmlIncludeAttribute(typeof(QualifyingParty))]
    public partial class QualifyingPartyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Participation. Percent</ccts:DictionaryEntryName><ccts:Definition>The extent to which this party is expected to participate in the tendering process, expressed as a percentage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Participation</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ParticipationPercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ParticipationPercentType ParticipationPercent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PersonalSituationType> _personalSituation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Personal Situation. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the personal situation of the qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Personal Situation</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PersonalSituation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PersonalSituationType> PersonalSituation
        {
            get
            {
                return _personalSituation;
            }
            set
            {
                _personalSituation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PersonalSituation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PersonalSituation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PersonalSituationSpecified
        {
            get
            {
                return ((this.PersonalSituation != null) 
                            && (this.PersonalSituation.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Operating Years. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of years that this qualifying party has been in operation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Operating Years</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OperatingYearsQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OperatingYearsQuantityType OperatingYearsQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Employee. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of people employed by this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Employee</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmployeeQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmployeeQuantityType EmployeeQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business Classification Evidence. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for an item of evidence to support the classification of this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Business Classification Evidence</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BusinessClassificationEvidenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BusinessClassificationEvidenceIdType BusinessClassificationEvidenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business Identity Evidence. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for an item of evidence to support the business identity of this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Business Identity Evidence</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BusinessIdentityEvidenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BusinessIdentityEvidenceIdType BusinessIdentityEvidenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Tenderer Role Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code stating the Tenderer Role.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Tenderer Role Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TendererRoleCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TendererRoleCodeType TendererRoleCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business_ Classification Scheme. Classification Scheme</ccts:DictionaryEntryName><ccts:Definition>The classification scheme used for the business profile.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Business</ccts:PropertyTermQualifier><ccts:PropertyTerm>Classification Scheme</ccts:PropertyTerm><ccts:AssociatedObjectClass>Classification Scheme</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Classification Scheme</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BusinessClassificationScheme")]
        public ClassificationSchemeType BusinessClassificationScheme { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<CapabilityType> _technicalCapability;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Technical_ Capability. Capability</ccts:DictionaryEntryName><ccts:Definition>A technical capability of this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Technical</ccts:PropertyTermQualifier><ccts:PropertyTerm>Capability</ccts:PropertyTerm><ccts:AssociatedObjectClass>Capability</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Capability</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TechnicalCapability")]
        public List<CapabilityType> TechnicalCapability
        {
            get
            {
                return _technicalCapability;
            }
            set
            {
                _technicalCapability = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TechnicalCapability-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TechnicalCapability collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TechnicalCapabilitySpecified
        {
            get
            {
                return ((this.TechnicalCapability != null) 
                            && (this.TechnicalCapability.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CapabilityType> _financialCapability;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Financial_ Capability. Capability</ccts:DictionaryEntryName><ccts:Definition>A financial capability of this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Financial</ccts:PropertyTermQualifier><ccts:PropertyTerm>Capability</ccts:PropertyTerm><ccts:AssociatedObjectClass>Capability</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Capability</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FinancialCapability")]
        public List<CapabilityType> FinancialCapability
        {
            get
            {
                return _financialCapability;
            }
            set
            {
                _financialCapability = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FinancialCapability-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FinancialCapability collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FinancialCapabilitySpecified
        {
            get
            {
                return ((this.FinancialCapability != null) 
                            && (this.FinancialCapability.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CompletedTaskType> _completedTask;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Completed Task</ccts:DictionaryEntryName><ccts:Definition>A former task completed by this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Completed Task</ccts:PropertyTerm><ccts:AssociatedObjectClass>Completed Task</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Completed Task</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CompletedTask")]
        public List<CompletedTaskType> CompletedTask
        {
            get
            {
                return _completedTask;
            }
            set
            {
                _completedTask = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CompletedTask-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CompletedTask collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CompletedTaskSpecified
        {
            get
            {
                return ((this.CompletedTask != null) 
                            && (this.CompletedTask.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DeclarationType> _declaration;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Declaration</ccts:DictionaryEntryName><ccts:Definition>A declaration by this qualifying party. of certain characteristics or capabilities in fulfilment of requirements specified in a call for tenders.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Declaration</ccts:PropertyTerm><ccts:AssociatedObjectClass>Declaration</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Declaration</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Declaration")]
        public List<DeclarationType> Declaration
        {
            get
            {
                return _declaration;
            }
            set
            {
                _declaration = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Declaration-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Declaration collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeclarationSpecified
        {
            get
            {
                return ((this.Declaration != null) 
                            && (this.Declaration.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Party</ccts:DictionaryEntryName><ccts:Definition>The qualifying party itself.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Party")]
        public PartyType Party { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Economic Operator Role</ccts:DictionaryEntryName><ccts:Definition>A class to describe the tenderer contracting role.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Economic Operator Role</ccts:PropertyTerm><ccts:AssociatedObjectClass>Economic Operator Role</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Economic Operator Role</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EconomicOperatorRole")]
        public EconomicOperatorRoleType EconomicOperatorRole { get; set; }
    }
}
