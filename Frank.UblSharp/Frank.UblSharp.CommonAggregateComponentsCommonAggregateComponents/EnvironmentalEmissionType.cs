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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Environmental Emission. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe an environmental emission.</ccts:Definition><ccts:ObjectClass>Environmental Emission</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("EnvironmentalEmissionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("EnvironmentalEmission", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EnvironmentalEmissionType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Environmental Emission. Environmental Emission Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code specifying the type of environmental emission.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Environmental Emission</ccts:ObjectClass><ccts:PropertyTerm>Environmental Emission Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("EnvironmentalEmissionTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EnvironmentalEmissionTypeCodeType EnvironmentalEmissionTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Environmental Emission. Value. Measure</ccts:DictionaryEntryName><ccts:Definition>A value measurement for the environmental emission.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Environmental Emission</ccts:ObjectClass><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ValueMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ValueMeasureType ValueMeasure { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Environmental Emission. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this environmental emission.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Environmental Emission</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        private List<EmissionCalculationMethodType> _emissionCalculationMethod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Environmental Emission. Emission Calculation Method</ccts:DictionaryEntryName><ccts:Definition>A method used to calculate the amount of this emission.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Environmental Emission</ccts:ObjectClass><ccts:PropertyTerm>Emission Calculation Method</ccts:PropertyTerm><ccts:AssociatedObjectClass>Emission Calculation Method</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Emission Calculation Method</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EmissionCalculationMethod")]
        public List<EmissionCalculationMethodType> EmissionCalculationMethod
        {
            get
            {
                return _emissionCalculationMethod;
            }
            set
            {
                _emissionCalculationMethod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EmissionCalculationMethod-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EmissionCalculationMethod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EmissionCalculationMethodSpecified
        {
            get
            {
                return ((this.EmissionCalculationMethod != null) 
                            && (this.EmissionCalculationMethod.Count != 0));
            }
        }
    }
}
