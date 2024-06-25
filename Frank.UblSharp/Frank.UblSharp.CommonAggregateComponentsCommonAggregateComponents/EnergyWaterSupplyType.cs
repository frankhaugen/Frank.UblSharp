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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Energy Water Supply. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the supply (and therefore consumption) of an amount of energy or water.</ccts:Definition><ccts:ObjectClass>Energy Water Supply</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("EnergyWaterSupplyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("EnergyWaterSupply", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EnergyWaterSupplyType
    {
        
        [XmlIgnoreAttribute()]
        private List<ConsumptionReportType> _consumptionReport;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Energy Water Supply. Consumption Report</ccts:DictionaryEntryName><ccts:Definition>An amount of energy or water consumed.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Energy Water Supply</ccts:ObjectClass><ccts:PropertyTerm>Consumption Report</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption Report</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption Report</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConsumptionReport")]
        public List<ConsumptionReportType> ConsumptionReport
        {
            get
            {
                return _consumptionReport;
            }
            set
            {
                _consumptionReport = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ConsumptionReport-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ConsumptionReport collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConsumptionReportSpecified
        {
            get
            {
                return ((this.ConsumptionReport != null) 
                            && (this.ConsumptionReport.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<EnergyTaxReportType> _energyTaxReport;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Energy Water Supply. Energy Tax Report</ccts:DictionaryEntryName><ccts:Definition>A tax on the consumption of energy or water.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Energy Water Supply</ccts:ObjectClass><ccts:PropertyTerm>Energy Tax Report</ccts:PropertyTerm><ccts:AssociatedObjectClass>Energy Tax Report</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Energy Tax Report</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EnergyTaxReport")]
        public List<EnergyTaxReportType> EnergyTaxReport
        {
            get
            {
                return _energyTaxReport;
            }
            set
            {
                _energyTaxReport = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EnergyTaxReport-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EnergyTaxReport collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EnergyTaxReportSpecified
        {
            get
            {
                return ((this.EnergyTaxReport != null) 
                            && (this.EnergyTaxReport.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ConsumptionAverageType> _consumptionAverage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Energy Water Supply. Consumption Average</ccts:DictionaryEntryName><ccts:Definition>A consumption average.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Energy Water Supply</ccts:ObjectClass><ccts:PropertyTerm>Consumption Average</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption Average</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption Average</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConsumptionAverage")]
        public List<ConsumptionAverageType> ConsumptionAverage
        {
            get
            {
                return _consumptionAverage;
            }
            set
            {
                _consumptionAverage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ConsumptionAverage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ConsumptionAverage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConsumptionAverageSpecified
        {
            get
            {
                return ((this.ConsumptionAverage != null) 
                            && (this.ConsumptionAverage.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ConsumptionCorrectionType> _energyWaterConsumptionCorrection;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Energy Water Supply. Energy Water_ Consumption Correction. Consumption Correction</ccts:DictionaryEntryName><ccts:Definition>Describes any corrections or adjustments to the supply of energy or water.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Energy Water Supply</ccts:ObjectClass><ccts:PropertyTermQualifier>Energy Water</ccts:PropertyTermQualifier><ccts:PropertyTerm>Consumption Correction</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption Correction</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption Correction</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EnergyWaterConsumptionCorrection")]
        public List<ConsumptionCorrectionType> EnergyWaterConsumptionCorrection
        {
            get
            {
                return _energyWaterConsumptionCorrection;
            }
            set
            {
                _energyWaterConsumptionCorrection = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EnergyWaterConsumptionCorrection-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EnergyWaterConsumptionCorrection collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EnergyWaterConsumptionCorrectionSpecified
        {
            get
            {
                return ((this.EnergyWaterConsumptionCorrection != null) 
                            && (this.EnergyWaterConsumptionCorrection.Count != 0));
            }
        }
    }
}
