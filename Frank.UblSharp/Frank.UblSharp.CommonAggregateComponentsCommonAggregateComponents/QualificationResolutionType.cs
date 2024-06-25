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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualification Resolution. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the acceptance or rejection of an economic operator in a tendering process.</ccts:Definition><ccts:ObjectClass>Qualification Resolution</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("QualificationResolutionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("QualificationResolution", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class QualificationResolutionType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualification Resolution. Admission Code. Code</ccts:DictionaryEntryName><ccts:Definition>An indicator that the economic operator has been accepted into the tendering process (true) or rejected from the tendering process (false).</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Qualification Resolution</ccts:ObjectClass><ccts:PropertyTerm>Admission Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("AdmissionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdmissionCodeType AdmissionCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExclusionReasonType> _exclusionReason;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualification Resolution. Exclusion Reason. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing a reason for an exclusion from the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualification Resolution</ccts:ObjectClass><ccts:PropertyTerm>Exclusion Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ExclusionReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExclusionReasonType> ExclusionReason
        {
            get
            {
                return _exclusionReason;
            }
            set
            {
                _exclusionReason = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExclusionReason-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExclusionReason collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ExclusionReasonSpecified
        {
            get
            {
                return ((this.ExclusionReason != null) 
                            && (this.ExclusionReason.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResolutionType> _resolution;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualification Resolution. Resolution. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this qualification resolution.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualification Resolution</ccts:ObjectClass><ccts:PropertyTerm>Resolution</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Resolution", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResolutionType> Resolution
        {
            get
            {
                return _resolution;
            }
            set
            {
                _resolution = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Resolution-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Resolution collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ResolutionSpecified
        {
            get
            {
                return ((this.Resolution != null) 
                            && (this.Resolution.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualification Resolution. Resolution Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this qualification resolution was formalized.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Qualification Resolution</ccts:ObjectClass><ccts:PropertyTerm>Resolution Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ResolutionDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResolutionDateType ResolutionDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualification Resolution. Resolution Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time at which this qualification resolution was formalized.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualification Resolution</ccts:ObjectClass><ccts:PropertyTerm>Resolution Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ResolutionTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResolutionTimeType ResolutionTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualification Resolution. Procurement Project Lot</ccts:DictionaryEntryName><ccts:Definition>The Procurement project lot to which this tenderer is accepted or rejected.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualification Resolution</ccts:ObjectClass><ccts:PropertyTerm>Procurement Project Lot</ccts:PropertyTerm><ccts:AssociatedObjectClass>Procurement Project Lot</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Procurement Project Lot</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProcurementProjectLot")]
        public ProcurementProjectLotType ProcurementProjectLot { get; set; }
    }
}
