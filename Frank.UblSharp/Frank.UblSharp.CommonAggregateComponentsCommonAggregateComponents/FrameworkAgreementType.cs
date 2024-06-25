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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Framework Agreement. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a tendering framework agreement.</ccts:Definition><ccts:ObjectClass>Framework Agreement</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("FrameworkAgreementType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("FrameworkAgreement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class FrameworkAgreementType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Framework Agreement. Expected_ Operator. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of economic operators expected to participate in this framework agreement.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Framework Agreement</ccts:ObjectClass><ccts:PropertyTermQualifier>Expected</ccts:PropertyTermQualifier><ccts:PropertyTerm>Operator</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExpectedOperatorQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpectedOperatorQuantityType ExpectedOperatorQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Framework Agreement. Maximum_ Operator. Quantity</ccts:DictionaryEntryName><ccts:Definition>The maximum number of economic operators allowed to participate in this framework agreement.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Framework Agreement</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Operator</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumOperatorQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumOperatorQuantityType MaximumOperatorQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.JustificationType> _justification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Framework Agreement. Justification. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the justification for this framework agreement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Framework Agreement</ccts:ObjectClass><ccts:PropertyTerm>Justification</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Justification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.JustificationType> Justification
        {
            get
            {
                return _justification;
            }
            set
            {
                _justification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Justification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Justification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool JustificationSpecified
        {
            get
            {
                return ((this.Justification != null) 
                            && (this.Justification.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FrequencyType> _frequency;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Framework Agreement. Frequency. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the frequency with which subsequent contracts will be awarded.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Framework Agreement</ccts:ObjectClass><ccts:PropertyTerm>Frequency</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Frequency", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FrequencyType> Frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                _frequency = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Frequency-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Frequency collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FrequencySpecified
        {
            get
            {
                return ((this.Frequency != null) 
                            && (this.Frequency.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Framework Agreement. Duration_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which this framework agreement applies.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Framework Agreement</ccts:ObjectClass><ccts:PropertyTermQualifier>Duration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DurationPeriod")]
        public PeriodType DurationPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TenderRequirementType> _subsequentProcessTenderRequirement;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Framework Agreement. Subsequent Process_ Tender Requirement. Tender Requirement</ccts:DictionaryEntryName><ccts:Definition>A tender requirement intended for consumption by downstream tendering processes derived from the establishment of this framework agreement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Framework Agreement</ccts:ObjectClass><ccts:PropertyTermQualifier>Subsequent Process</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tender Requirement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tender Requirement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tender Requirement</ccts:RepresentationTerm><ccts:Examples>Curricula required</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SubsequentProcessTenderRequirement")]
        public List<TenderRequirementType> SubsequentProcessTenderRequirement
        {
            get
            {
                return _subsequentProcessTenderRequirement;
            }
            set
            {
                _subsequentProcessTenderRequirement = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SubsequentProcessTenderRequirement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SubsequentProcessTenderRequirement collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SubsequentProcessTenderRequirementSpecified
        {
            get
            {
                return ((this.SubsequentProcessTenderRequirement != null) 
                            && (this.SubsequentProcessTenderRequirement.Count != 0));
            }
        }
    }
}
