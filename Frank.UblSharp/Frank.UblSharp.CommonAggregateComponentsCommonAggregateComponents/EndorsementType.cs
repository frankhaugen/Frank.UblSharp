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
    [XmlTypeAttribute("EndorsementType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(EmbassyEndorsement))]
    [XmlIncludeAttribute(typeof(Endorsement))]
    [XmlIncludeAttribute(typeof(InsuranceEndorsement))]
    [XmlIncludeAttribute(typeof(IssuerEndorsement))]
    public partial class EndorsementType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorsement. Document. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this endorsement.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Endorsement</ccts:ObjectClass><ccts:PropertyTerm>Document</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("DocumentID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentIdType DocumentId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorsement. Approval Status. Text</ccts:DictionaryEntryName><ccts:Definition>The status of this endorsement.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Endorsement</ccts:ObjectClass><ccts:PropertyTerm>Approval Status</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Authentication Code</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ApprovalStatus", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ApprovalStatusType ApprovalStatus { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RemarksType> _remarks;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorsement. Remarks. Text</ccts:DictionaryEntryName><ccts:Definition>Remarks provided by the endorsing party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Endorsement</ccts:ObjectClass><ccts:PropertyTerm>Remarks</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RemarksType> Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Remarks-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Remarks collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RemarksSpecified
        {
            get
            {
                return ((this.Remarks != null) 
                            && (this.Remarks.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorsement. Endorser Party</ccts:DictionaryEntryName><ccts:Definition>The type of party providing this endorsement.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Endorsement</ccts:ObjectClass><ccts:PropertyTerm>Endorser Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorser Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorser Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("EndorserParty")]
        public EndorserPartyType EndorserParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<SignatureType> _signature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorsement. Signature</ccts:DictionaryEntryName><ccts:Definition>A signature applied to this endorsement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Endorsement</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Signature")]
        public List<SignatureType> Signature
        {
            get
            {
                return _signature;
            }
            set
            {
                _signature = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Signature-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Signature collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SignatureSpecified
        {
            get
            {
                return ((this.Signature != null) 
                            && (this.Signature.Count != 0));
            }
        }
    }
}
