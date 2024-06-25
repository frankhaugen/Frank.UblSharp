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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Declaration. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a declaration by an economic operator of certain characteristics or capabilities in fulfilment of requirements specified in a call for tenders.</ccts:Definition><ccts:ObjectClass>Declaration</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("DeclarationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("Declaration", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeclarationType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType> _name;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Declaration. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this declaration.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Declaration</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType> Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Name-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Name collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NameSpecified
        {
            get
            {
                return ((this.Name != null) 
                            && (this.Name.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Declaration. Declaration Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this declaration.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Declaration</ccts:ObjectClass><ccts:PropertyTerm>Declaration Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeclarationTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclarationTypeCodeType DeclarationTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Declaration. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this declaration.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Declaration</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        private List<EvidenceSuppliedType> _evidenceSupplied;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Declaration. Evidence Supplied</ccts:DictionaryEntryName><ccts:Definition>The evidence supporting this declaration.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Declaration</ccts:ObjectClass><ccts:PropertyTerm>Evidence Supplied</ccts:PropertyTerm><ccts:AssociatedObjectClass>Evidence Supplied</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Evidence Supplied</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EvidenceSupplied")]
        public List<EvidenceSuppliedType> EvidenceSupplied
        {
            get
            {
                return _evidenceSupplied;
            }
            set
            {
                _evidenceSupplied = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EvidenceSupplied-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EvidenceSupplied collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EvidenceSuppliedSpecified
        {
            get
            {
                return ((this.EvidenceSupplied != null) 
                            && (this.EvidenceSupplied.Count != 0));
            }
        }
    }
}
