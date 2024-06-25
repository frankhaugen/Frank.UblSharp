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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Party Qualification. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the qualifications of a tenderer party.</ccts:Definition><ccts:ObjectClass>Tenderer Party Qualification</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TendererPartyQualificationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TendererPartyQualification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TendererPartyQualificationType
    {
        
        [XmlIgnoreAttribute()]
        private List<ProcurementProjectLotType> _interestedProcurementProjectLot;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Party Qualification. Interested_ Procurement Project Lot. Procurement Project Lot</ccts:DictionaryEntryName><ccts:Definition>The procurement project lot the party is interested in.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Party Qualification</ccts:ObjectClass><ccts:PropertyTermQualifier>Interested</ccts:PropertyTermQualifier><ccts:PropertyTerm>Procurement Project Lot</ccts:PropertyTerm><ccts:AssociatedObjectClass>Procurement Project Lot</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Procurement Project Lot</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("InterestedProcurementProjectLot")]
        public List<ProcurementProjectLotType> InterestedProcurementProjectLot
        {
            get
            {
                return _interestedProcurementProjectLot;
            }
            set
            {
                _interestedProcurementProjectLot = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die InterestedProcurementProjectLot-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the InterestedProcurementProjectLot collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InterestedProcurementProjectLotSpecified
        {
            get
            {
                return ((this.InterestedProcurementProjectLot != null) 
                            && (this.InterestedProcurementProjectLot.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Party Qualification. Main_ Qualifying Party. Qualifying Party</ccts:DictionaryEntryName><ccts:Definition>The qualifications of the main tenderer party.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Tenderer Party Qualification</ccts:ObjectClass><ccts:PropertyTermQualifier>Main</ccts:PropertyTermQualifier><ccts:PropertyTerm>Qualifying Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Qualifying Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Qualifying Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("MainQualifyingParty")]
        public QualifyingPartyType MainQualifyingParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<QualifyingPartyType> _additionalQualifyingParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tenderer Party Qualification. Additional_ Qualifying Party. Qualifying Party</ccts:DictionaryEntryName><ccts:Definition>The qualifications of a tenderer party other than the main tenderer party when bidding as a consortium.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tenderer Party Qualification</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Qualifying Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Qualifying Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Qualifying Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalQualifyingParty")]
        public List<QualifyingPartyType> AdditionalQualifyingParty
        {
            get
            {
                return _additionalQualifyingParty;
            }
            set
            {
                _additionalQualifyingParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalQualifyingParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalQualifyingParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalQualifyingPartySpecified
        {
            get
            {
                return ((this.AdditionalQualifyingParty != null) 
                            && (this.AdditionalQualifyingParty.Count != 0));
            }
        }
    }
}