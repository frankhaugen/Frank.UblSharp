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
    [XmlTypeAttribute("DocumentResponseType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AdditionalDocumentResponse))]
    [XmlIncludeAttribute(typeof(DocumentResponse))]
    public partial class DocumentResponseType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Response. Response</ccts:DictionaryEntryName><ccts:Definition>A response to the document as a whole.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Response</ccts:ObjectClass><ccts:PropertyTerm>Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Response</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Response")]
        public ResponseType Response {get;set;}
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Response. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A referenced document.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Document Response</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("DocumentReference")]
        public List<DocumentReferenceType> DocumentReference
        {
            get
            {
                return _documentReference;
            }
            set
            {
                _documentReference = value;
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Response. Issuer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party that issued the document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Response</ccts:ObjectClass><ccts:PropertyTermQualifier>Issuer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IssuerParty")]
        public PartyType IssuerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Response. Recipient_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party for which the document is intended.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Response</ccts:ObjectClass><ccts:PropertyTermQualifier>Recipient</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RecipientParty")]
        public PartyType RecipientParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<LineResponseType> _lineResponse;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Response. Line Response</ccts:DictionaryEntryName><ccts:Definition>A response to a particular line in the document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Document Response</ccts:ObjectClass><ccts:PropertyTerm>Line Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Line Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Line Response</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("LineResponse")]
        public List<LineResponseType> LineResponse
        {
            get
            {
                return _lineResponse;
            }
            set
            {
                _lineResponse = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LineResponse-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the LineResponse collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LineResponseSpecified
        {
            get
            {
                return ((this.LineResponse != null) 
                            && (this.LineResponse.Count != 0));
            }
        }
    }
}
