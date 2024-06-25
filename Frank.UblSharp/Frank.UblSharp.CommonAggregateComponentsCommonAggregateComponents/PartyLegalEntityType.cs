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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a party as a legal entity.</ccts:Definition><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PartyLegalEntityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("PartyLegalEntity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyLegalEntityType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Registration_ Name. Name</ccts:DictionaryEntryName><ccts:Definition>The name of the party as registered with the relevant legal authority.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>Microsoft Corporation </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RegistrationName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegistrationNameType RegistrationName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Company Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the party as registered within a company registration scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Company Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Business Registration Number, Company Number</ccts:AlternativeBusinessTerms><ccts:Examples>3556625 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompanyID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyIdType CompanyId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Registration_ Date. Date</ccts:DictionaryEntryName><ccts:Definition>The registration date of the CompanyID.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RegistrationDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegistrationDateType RegistrationDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Registration Expiration_ Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date upon which a registration expires (e.g., registration for an import/export license).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration Expiration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RegistrationExpirationDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RegistrationExpirationDateType RegistrationExpirationDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Company Legal Form Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the party's legal status.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Company Legal Form Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Legal Status</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompanyLegalFormCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyLegalFormCodeType CompanyLegalFormCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Company Legal Form. Text</ccts:DictionaryEntryName><ccts:Definition>The company legal status, expressed as a text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Company Legal Form</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompanyLegalForm", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyLegalFormType CompanyLegalForm { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Sole Proprietorship Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that the company is owned and controlled by one person (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Sole Proprietorship Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SoleProprietorshipIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SoleProprietorshipIndicatorType SoleProprietorshipIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Company Liquidation Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the party's liquidation status.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Company Liquidation Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CompanyLiquidationStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyLiquidationStatusCodeType CompanyLiquidationStatusCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Corporate Stock_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The number of shares in the capital stock of a corporation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTermQualifier>Corporate Stock</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CorporateStockAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CorporateStockAmountType CorporateStockAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Fully Paid Shares Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that all shares of corporate stock have been paid by shareholders (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Fully Paid Shares Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FullyPaidSharesIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FullyPaidSharesIndicatorType FullyPaidSharesIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Registration_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The registered address of the party within a corporate registration scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTermQualifier>Registration</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RegistrationAddress")]
        public AddressType RegistrationAddress { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Corporate Registration Scheme</ccts:DictionaryEntryName><ccts:Definition>The corporate registration scheme used to register the party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Corporate Registration Scheme</ccts:PropertyTerm><ccts:AssociatedObjectClass>Corporate Registration Scheme</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Corporate Registration Scheme</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CorporateRegistrationScheme")]
        public CorporateRegistrationSchemeType CorporateRegistrationScheme { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Head Office_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The head office of the legal entity</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTermQualifier>Head Office</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HeadOfficeParty")]
        public PartyType HeadOfficeParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ShareholderPartyType> _shareholderParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party Legal Entity. Shareholder Party</ccts:DictionaryEntryName><ccts:Definition>A party owning shares in this legal entity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party Legal Entity</ccts:ObjectClass><ccts:PropertyTerm>Shareholder Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shareholder Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shareholder Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShareholderParty")]
        public List<ShareholderPartyType> ShareholderParty
        {
            get
            {
                return _shareholderParty;
            }
            set
            {
                _shareholderParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ShareholderParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ShareholderParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShareholderPartySpecified
        {
            get
            {
                return ((this.ShareholderParty != null) 
                            && (this.ShareholderParty.Count != 0));
            }
        }
    }
}
