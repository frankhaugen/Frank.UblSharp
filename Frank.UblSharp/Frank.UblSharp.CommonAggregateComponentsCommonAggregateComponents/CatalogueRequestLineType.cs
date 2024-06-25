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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Request Line. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a line describing a request for a catalogue line.</ccts:Definition><ccts:ObjectClass>Catalogue Request Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CatalogueRequestLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("CatalogueRequestLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueRequestLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Request Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the requested catalogue line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Catalogue Request Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>1 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Request Line. Contract Subdivision. Text</ccts:DictionaryEntryName><ccts:Definition>A subdivision of a contract or tender covering the line being requested.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Request Line</ccts:ObjectClass><ccts:PropertyTerm>Contract Subdivision</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Installation , Phase One , Support and Maintenance </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractSubdivision", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContractSubdivisionType ContractSubdivision { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Request Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Request Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Note-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Note collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoteSpecified
        {
            get
            {
                return ((this.Note != null) 
                            && (this.Note.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Request Line. Line Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period for which the information in the requested catalogue line is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Request Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Line Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LineValidityPeriod")]
        public PeriodType LineValidityPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemLocationQuantityType> _requiredItemLocationQuantity;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Request Line. Required_ Item Location Quantity. Item Location Quantity</ccts:DictionaryEntryName><ccts:Definition>Properties of the item in the requested catalogue line that are dependent on location and quantity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Request Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Location Quantity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Location Quantity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Location Quantity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequiredItemLocationQuantity")]
        public List<ItemLocationQuantityType> RequiredItemLocationQuantity
        {
            get
            {
                return _requiredItemLocationQuantity;
            }
            set
            {
                _requiredItemLocationQuantity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequiredItemLocationQuantity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequiredItemLocationQuantity collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequiredItemLocationQuantitySpecified
        {
            get
            {
                return ((this.RequiredItemLocationQuantity != null) 
                            && (this.RequiredItemLocationQuantity.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Request Line. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with the requested catalogue line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Catalogue Request Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Item")]
        public ItemType Item {get;set;}
    }
}
