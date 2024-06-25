namespace Frank.UblSharp.CommonSignatureComponentsCommonSignatureComponents
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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>UBL Document Signatures. Details</ccts:DictionaryEntryName><ccts:Definition>This class collects all signature information for a document.</ccts:Definition><ccts:ObjectClass>UBL Document Signatures</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("UBLDocumentSignaturesType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
    [XmlRootAttribute("UBLDocumentSignatures", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
    public partial class UblDocumentSignaturesType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.SignatureAggregateComponentsSignatureAggregateComponents.SignatureInformationType> _signatureInformation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>UBL Document Signatures. Signature Information</ccts:DictionaryEntryName><ccts:Definition>Each of these is scaffolding for a single digital signature.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>UBL Document Signatures</ccts:ObjectClass><ccts:PropertyTerm>Signature Information</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature Information</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature Information</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SignatureInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
        public List<Frank.UblSharp.SignatureAggregateComponentsSignatureAggregateComponents.SignatureInformationType> SignatureInformation
        {
            get
            {
                return _signatureInformation;
            }
            set
            {
                _signatureInformation = value;
            }
        }
    }
}
