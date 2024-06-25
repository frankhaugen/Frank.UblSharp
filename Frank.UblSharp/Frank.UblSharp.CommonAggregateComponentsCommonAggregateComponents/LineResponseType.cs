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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Response. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe responses to a line in a document.</ccts:Definition><ccts:ObjectClass>Line Response</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("LineResponseType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("LineResponse", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LineResponseType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Response. Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to the line being responded to.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Line Response</ccts:ObjectClass><ccts:PropertyTerm>Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("LineReference")]
        public LineReferenceType LineReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ResponseType> _response;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Line Response. Response</ccts:DictionaryEntryName><ccts:Definition>A response to the referenced line.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Line Response</ccts:ObjectClass><ccts:PropertyTerm>Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Response</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Response")]
        public List<ResponseType> Response
        {
            get
            {
                return _response;
            }
            set
            {
                _response = value;
            }
        }
    }
}
