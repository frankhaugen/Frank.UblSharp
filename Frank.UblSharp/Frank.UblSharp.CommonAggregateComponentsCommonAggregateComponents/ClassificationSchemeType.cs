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
    [XmlTypeAttribute("ClassificationSchemeType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(BusinessClassificationScheme))]
    [XmlIncludeAttribute(typeof(ClassificationScheme))]
    [XmlIncludeAttribute(typeof(RequestedClassificationScheme))]
    [XmlIncludeAttribute(typeof(RequiredBusinessClassificationScheme))]
    [XmlIncludeAttribute(typeof(RequiredClassificationScheme))]
    public partial class ClassificationSchemeType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this classification scheme.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Last_ Revision Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this classification scheme was last revised.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTermQualifier>Last</ccts:PropertyTermQualifier><ccts:PropertyTerm>Revision Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LastRevisionDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LastRevisionDateType LastRevisionDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Last_ Revision Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time at which this classification scheme was last revised.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTermQualifier>Last</ccts:PropertyTermQualifier><ccts:PropertyTerm>Revision Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LastRevisionTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LastRevisionTimeType LastRevisionTime { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>UNSPSC </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this classification scheme.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>an open, global multi-sector standard for classification of products and services </ccts:Examples></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Agency Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the agency that maintains this classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Agency Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>Defaults to the UN/EDIFACT data element 3055 code list.</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AgencyID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AgencyIdType AgencyId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Agency Name. Text</ccts:DictionaryEntryName><ccts:Definition>The name of the agency that maintains the classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Agency Name</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AgencyName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AgencyNameType AgencyName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Version. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the version of this classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Version</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("VersionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.VersionIdType VersionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) of the documentation for this classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("URI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UriType Uri { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Scheme_ URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) of this classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTermQualifier>Scheme</ccts:PropertyTermQualifier><ccts:PropertyTerm>URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SchemeURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SchemeUriType SchemeUri { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Language. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the language of this classification scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Language</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LanguageID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LanguageIdType LanguageId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ClassificationCategoryType> _classificationCategory;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Scheme. Classification Category</ccts:DictionaryEntryName><ccts:Definition>A description of a category within this classification scheme.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Classification Scheme</ccts:ObjectClass><ccts:PropertyTerm>Classification Category</ccts:PropertyTerm><ccts:AssociatedObjectClass>Classification Category</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Classification Category</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ClassificationCategory")]
        public List<ClassificationCategoryType> ClassificationCategory
        {
            get
            {
                return _classificationCategory;
            }
            set
            {
                _classificationCategory = value;
            }
        }
    }
}
