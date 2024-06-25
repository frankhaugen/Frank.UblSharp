using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a party contracting to provide services, such as transportation, finance, etc.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Service Provider Party. Details
/// <para />ObjectClass: Service Provider Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ServiceProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ServiceProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ServiceProviderPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ServiceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ServiceTypeCode;
        
    private System.Collections.Generic.List<TextType> _serviceType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ServiceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__ServiceType
    {
        get
        {
            return _serviceType?.ToArray();
        }
        set
        {
            _serviceType = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=3)]
    public PartyType @__Party;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerContact", Order=4)]
    public ContactType @__SellerContact;
        
    /// <summary>
    /// The type of service provided, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Service Provider Party. Service Type. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Service Provider Party
    /// <para />PropertyTerm: Service Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ServiceType
    {
        get { return _serviceType ?? (_serviceType = new System.Collections.Generic.List<TextType>()); }
        set { _serviceType = value; }
    }

        
    /// <summary>
    /// An identifier for this service provider.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Service Provider Party. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Service Provider Party
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// The type of service provided, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Service Provider Party. Service Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Service Provider Party
    /// <para />PropertyTerm: Service Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ServiceTypeCode
    {
        get
        {
            if (__ServiceTypeCode == null) { __ServiceTypeCode = new CodeType(); }
            return __ServiceTypeCode;
        }
        set
        {
            __ServiceTypeCode = value;
        }
    }

        
    /// <summary>
    /// The party providing the service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Service Provider Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Service Provider Party
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType Party
    {
        get
        {
            if (__Party == null) { __Party = new PartyType(); }
            return __Party;
        }
        set
        {
            __Party = value;
        }
    }

        
    /// <summary>
    /// The contact for the service provider.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Service Provider Party. Seller_ Contact. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Service Provider Party
    /// <para />PropertyTermQualifier: Seller
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType SellerContact
    {
        get
        {
            if (__SellerContact == null) { __SellerContact = new ContactType(); }
            return __SellerContact;
        }
        set
        {
            __SellerContact = value;
        }
    }

}