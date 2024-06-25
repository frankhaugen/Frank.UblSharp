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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a taxation scheme applying to a party.</ccts:Definition><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PartyTaxSchemeType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("PartyTaxScheme", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyTaxSchemeType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Registration_ Name. Name</ccts:DictionaryEntryName><ccts:Definition>The name of the party as registered with the relevant fiscal authority.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>Microsoft Corporation </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RegistrationName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegistrationNameType RegistrationName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Company Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the party assigned for tax purposes by the taxation authority.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass><ccts:PropertyTerm>Company Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>VAT Number</ccts:AlternativeBusinessTerms><ccts:Examples>3556625 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompanyID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyIdType CompanyId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Tax Level Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the tax level applicable to the party within this taxation scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass><ccts:PropertyTerm>Tax Level Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TaxLevelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxLevelCodeType TaxLevelCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Exemption Reason Code. Code</ccts:DictionaryEntryName><ccts:Definition>A reason for the party's exemption from tax, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass><ccts:PropertyTerm>Exemption Reason Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExemptionReasonCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExemptionReasonCodeType ExemptionReasonCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExemptionReasonType> _exemptionReason;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Exemption_ Reason. Text</ccts:DictionaryEntryName><ccts:Definition>A reason for the party's exemption from tax, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass><ccts:PropertyTermQualifier>Exemption</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ExemptionReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExemptionReasonType> ExemptionReason
        {
            get
            {
                return _exemptionReason;
            }
            set
            {
                _exemptionReason = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExemptionReason-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExemptionReason collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ExemptionReasonSpecified
        {
            get
            {
                return ((this.ExemptionReason != null) 
                            && (this.ExemptionReason.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Registration_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The address of the party as registered for tax purposes.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RegistrationAddress")]
        public AddressType RegistrationAddress { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Tax Scheme. Tax Scheme</ccts:DictionaryEntryName><ccts:Definition>The taxation scheme applicable to the party.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Party Tax Scheme</ccts:ObjectClass><ccts:PropertyTerm>Tax Scheme</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Scheme</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Scheme</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("TaxScheme")]
        public TaxSchemeType TaxScheme { get; set; }
    }
}
