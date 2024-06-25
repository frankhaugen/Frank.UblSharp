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
    [XmlTypeAttribute("PartyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AdditionalInformationParty))]
    [XmlIncludeAttribute(typeof(AgentParty))]
    [XmlIncludeAttribute(typeof(AppealInformationParty))]
    [XmlIncludeAttribute(typeof(AppealReceiverParty))]
    [XmlIncludeAttribute(typeof(BeneficiaryParty))]
    [XmlIncludeAttribute(typeof(BillOfLadingHolderParty))]
    [XmlIncludeAttribute(typeof(BillToParty))]
    [XmlIncludeAttribute(typeof(CarrierParty))]
    [XmlIncludeAttribute(typeof(ConsigneeParty))]
    [XmlIncludeAttribute(typeof(ConsignorParty))]
    [XmlIncludeAttribute(typeof(ContactParty))]
    [XmlIncludeAttribute(typeof(ContractResponsibleParty))]
    [XmlIncludeAttribute(typeof(CustomsAgentParty))]
    [XmlIncludeAttribute(typeof(DeliveryParty))]
    [XmlIncludeAttribute(typeof(DespatchParty))]
    [XmlIncludeAttribute(typeof(DocumentProviderParty))]
    [XmlIncludeAttribute(typeof(EvidenceIssuingParty))]
    [XmlIncludeAttribute(typeof(ExporterParty))]
    [XmlIncludeAttribute(typeof(FinalDeliveryParty))]
    [XmlIncludeAttribute(typeof(FinancingParty))]
    [XmlIncludeAttribute(typeof(FreightForwarderParty))]
    [XmlIncludeAttribute(typeof(GuarantorParty))]
    [XmlIncludeAttribute(typeof(HazardousItemNotificationParty))]
    [XmlIncludeAttribute(typeof(HeadOfficeParty))]
    [XmlIncludeAttribute(typeof(ImporterParty))]
    [XmlIncludeAttribute(typeof(InformationContentProviderParty))]
    [XmlIncludeAttribute(typeof(InsuranceParty))]
    [XmlIncludeAttribute(typeof(InterestedParty))]
    [XmlIncludeAttribute(typeof(InventoryReportingParty))]
    [XmlIncludeAttribute(typeof(IssuerParty))]
    [XmlIncludeAttribute(typeof(LoadingProofParty))]
    [XmlIncludeAttribute(typeof(LogisticsOperatorParty))]
    [XmlIncludeAttribute(typeof(ManufacturerParty))]
    [XmlIncludeAttribute(typeof(MediationParty))]
    [XmlIncludeAttribute(typeof(MortgageHolderParty))]
    [XmlIncludeAttribute(typeof(NotaryParty))]
    [XmlIncludeAttribute(typeof(NotifyParty))]
    [XmlIncludeAttribute(typeof(OperatingParty))]
    [XmlIncludeAttribute(typeof(OriginalDespatchParty))]
    [XmlIncludeAttribute(typeof(OriginatorParty))]
    [XmlIncludeAttribute(typeof(OwnerParty))]
    [XmlIncludeAttribute(typeof(Party))]
    [XmlIncludeAttribute(typeof(PayeeParty))]
    [XmlIncludeAttribute(typeof(PayerParty))]
    [XmlIncludeAttribute(typeof(PerformingCarrierParty))]
    [XmlIncludeAttribute(typeof(PickupParty))]
    [XmlIncludeAttribute(typeof(PreparationParty))]
    [XmlIncludeAttribute(typeof(PreSelectedParty))]
    [XmlIncludeAttribute(typeof(ProviderParty))]
    [XmlIncludeAttribute(typeof(ReceiverParty))]
    [XmlIncludeAttribute(typeof(RecipientParty))]
    [XmlIncludeAttribute(typeof(ResponsibleTransportServiceProviderParty))]
    [XmlIncludeAttribute(typeof(SenderParty))]
    [XmlIncludeAttribute(typeof(SignatoryParty))]
    [XmlIncludeAttribute(typeof(SourceIssuerParty))]
    [XmlIncludeAttribute(typeof(SubcontractorParty))]
    [XmlIncludeAttribute(typeof(SubscriberParty))]
    [XmlIncludeAttribute(typeof(SubstituteCarrierParty))]
    [XmlIncludeAttribute(typeof(TaxRepresentativeParty))]
    [XmlIncludeAttribute(typeof(TendererParty))]
    [XmlIncludeAttribute(typeof(TenderEvaluationParty))]
    [XmlIncludeAttribute(typeof(TenderRecipientParty))]
    [XmlIncludeAttribute(typeof(TerminalOperatorParty))]
    [XmlIncludeAttribute(typeof(TransportAdvisorParty))]
    [XmlIncludeAttribute(typeof(TransportServiceProviderParty))]
    [XmlIncludeAttribute(typeof(TransportUserParty))]
    [XmlIncludeAttribute(typeof(UtilityCustomerParty))]
    [XmlIncludeAttribute(typeof(UtilitySupplierParty))]
    [XmlIncludeAttribute(typeof(WarrantyParty))]
    [XmlIncludeAttribute(typeof(WitnessParty))]
    public partial class PartyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Mark Care_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this party is "care of" (c/o) (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Mark Care</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MarkCareIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MarkCareIndicatorType MarkCareIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Mark Attention_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this party is "for the attention of" (FAO) (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Mark Attention</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MarkAttentionIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MarkAttentionIndicatorType MarkAttentionIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Website_ URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) that identifies this party's web site; i.e., the web site's Uniform Resource Locator (URL).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Website</ccts:PropertyTermQualifier><ccts:PropertyTerm>URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WebsiteURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WebsiteUriType WebsiteUri { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Logo Reference. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this party's logo.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Logo Reference</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>http://www2.coca-cola.com/images/logo.gif</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LogoReferenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LogoReferenceIdType LogoReferenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Endpoint Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the end point of the routing service (e.g., EAN Location Number, GLN).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Endpoint Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>5790002221134</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EndpointID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EndpointIdType EndpointId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Industry Classification Code. Code</ccts:DictionaryEntryName><ccts:Definition>This party's Industry Classification Code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Industry Classification Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Public authority , NAIC codes</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IndustryClassificationCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IndustryClassificationCodeType IndustryClassificationCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PartyIdentificationType> _partyIdentification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Party Identification</ccts:DictionaryEntryName><ccts:Definition>An identifier for this party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Party Identification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party Identification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party Identification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PartyIdentification")]
        public List<PartyIdentificationType> PartyIdentification
        {
            get
            {
                return _partyIdentification;
            }
            set
            {
                _partyIdentification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PartyIdentification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PartyIdentification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PartyIdentificationSpecified
        {
            get
            {
                return ((this.PartyIdentification != null) 
                            && (this.PartyIdentification.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PartyNameType> _partyName;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Party Name</ccts:DictionaryEntryName><ccts:Definition>A name for this party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Party Name</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party Name</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party Name</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PartyName")]
        public List<PartyNameType> PartyName
        {
            get
            {
                return _partyName;
            }
            set
            {
                _partyName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PartyName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PartyName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PartyNameSpecified
        {
            get
            {
                return ((this.PartyName != null) 
                            && (this.PartyName.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Language</ccts:DictionaryEntryName><ccts:Definition>The language associated with this party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Language</ccts:PropertyTerm><ccts:AssociatedObjectClass>Language</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Language</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Language")]
        public LanguageType Language { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Postal_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The party's postal address.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Postal</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PostalAddress")]
        public AddressType PostalAddress { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Physical_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The physical location of this party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Physical</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PhysicalLocation")]
        public LocationType PhysicalLocation { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PartyTaxSchemeType> _partyTaxScheme;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Party Tax Scheme</ccts:DictionaryEntryName><ccts:Definition>A tax scheme applying to this party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Party Tax Scheme</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party Tax Scheme</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party Tax Scheme</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PartyTaxScheme")]
        public List<PartyTaxSchemeType> PartyTaxScheme
        {
            get
            {
                return _partyTaxScheme;
            }
            set
            {
                _partyTaxScheme = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PartyTaxScheme-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PartyTaxScheme collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PartyTaxSchemeSpecified
        {
            get
            {
                return ((this.PartyTaxScheme != null) 
                            && (this.PartyTaxScheme.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PartyLegalEntityType> _partyLegalEntity;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Party Legal Entity</ccts:DictionaryEntryName><ccts:Definition>A description of this party as a legal entity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Party Legal Entity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party Legal Entity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party Legal Entity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PartyLegalEntity")]
        public List<PartyLegalEntityType> PartyLegalEntity
        {
            get
            {
                return _partyLegalEntity;
            }
            set
            {
                _partyLegalEntity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PartyLegalEntity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PartyLegalEntity collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PartyLegalEntitySpecified
        {
            get
            {
                return ((this.PartyLegalEntity != null) 
                            && (this.PartyLegalEntity.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Contact</ccts:DictionaryEntryName><ccts:Definition>The primary contact for this party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Contact</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contact</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contact</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Contact")]
        public ContactType Contact { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PersonType> _person;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Person</ccts:DictionaryEntryName><ccts:Definition>A person associated with this party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Person</ccts:PropertyTerm><ccts:AssociatedObjectClass>Person</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Person</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Person")]
        public List<PersonType> Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Person-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Person collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PersonSpecified
        {
            get
            {
                return ((this.Person != null) 
                            && (this.Person.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Agent_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A party who acts as an agent for this party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Agent</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:Examples>Customs Broker</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AgentParty")]
        public PartyType AgentParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ServiceProviderPartyType> _serviceProviderParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Service Provider Party</ccts:DictionaryEntryName><ccts:Definition>A party providing a service to this party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Service Provider Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Service Provider Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Service Provider Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ServiceProviderParty")]
        public List<ServiceProviderPartyType> ServiceProviderParty
        {
            get
            {
                return _serviceProviderParty;
            }
            set
            {
                _serviceProviderParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ServiceProviderParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ServiceProviderParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ServiceProviderPartySpecified
        {
            get
            {
                return ((this.ServiceProviderParty != null) 
                            && (this.ServiceProviderParty.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PowerOfAttorneyType> _powerOfAttorney;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Power Of Attorney</ccts:DictionaryEntryName><ccts:Definition>A power of attorney associated with this party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Power Of Attorney</ccts:PropertyTerm><ccts:AssociatedObjectClass>Power Of Attorney</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Power Of Attorney</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PowerOfAttorney")]
        public List<PowerOfAttorneyType> PowerOfAttorney
        {
            get
            {
                return _powerOfAttorney;
            }
            set
            {
                _powerOfAttorney = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PowerOfAttorney-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PowerOfAttorney collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PowerOfAttorneySpecified
        {
            get
            {
                return ((this.PowerOfAttorney != null) 
                            && (this.PowerOfAttorney.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Party. Financial Account</ccts:DictionaryEntryName><ccts:Definition>The financial account associated with this party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Party</ccts:ObjectClass><ccts:PropertyTerm>Financial Account</ccts:PropertyTerm><ccts:AssociatedObjectClass>Financial Account</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Financial Account</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FinancialAccount")]
        public FinancialAccountType FinancialAccount { get; set; }
    }
}
