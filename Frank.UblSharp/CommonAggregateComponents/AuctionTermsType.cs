using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the terms to be fulfilled by tenderers if an auction is to be executed before the awarding of a tender.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Auction Terms. Details
/// <para />ObjectClass: Auction Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AuctionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AuctionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AuctionTermsType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AuctionConstraintIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IndicatorType @__AuctionConstraintIndicator;
        
    private System.Collections.Generic.List<TextType> _justificationDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("JustificationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__JustificationDescription
    {
        get
        {
            return _justificationDescription?.ToArray();
        }
        set
        {
            _justificationDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _processDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcessDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__ProcessDescription
    {
        get
        {
            return _processDescription?.ToArray();
        }
        set
        {
            _processDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _conditionsDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConditionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__ConditionsDescription
    {
        get
        {
            return _conditionsDescription?.ToArray();
        }
        set
        {
            _conditionsDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _electronicDeviceDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ElectronicDeviceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__ElectronicDeviceDescription
    {
        get
        {
            return _electronicDeviceDescription?.ToArray();
        }
        set
        {
            _electronicDeviceDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AuctionURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IdentifierType @__AuctionURI;
        
    /// <summary>
    /// Text describing a justification for the use of an auction in awarding the tender.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Auction Terms. Justification_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Auction Terms
    /// <para />PropertyTermQualifier: Justification
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> JustificationDescription
    {
        get { return _justificationDescription ?? (_justificationDescription = new System.Collections.Generic.List<TextType>()); }
        set { _justificationDescription = value; }
    }

        
    /// <summary>
    /// Text for tenderers describing terms governing the auction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Auction Terms. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Auction Terms
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Text describing the auction process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Auction Terms. Process_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Auction Terms
    /// <para />PropertyTermQualifier: Process
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ProcessDescription
    {
        get { return _processDescription ?? (_processDescription = new System.Collections.Generic.List<TextType>()); }
        set { _processDescription = value; }
    }

        
    /// <summary>
    /// Text describing the conditions under which the tenderers will be able to bid as part of the auction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Auction Terms. Conditions_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Auction Terms
    /// <para />PropertyTermQualifier: Conditions
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ConditionsDescription
    {
        get { return _conditionsDescription ?? (_conditionsDescription = new System.Collections.Generic.List<TextType>()); }
        set { _conditionsDescription = value; }
    }

        
    /// <summary>
    /// Text describing an electronic device used for the auction, including associated connectivity specifications.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Auction Terms. Electronic Device_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Auction Terms
    /// <para />PropertyTermQualifier: Electronic Device
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ElectronicDeviceDescription
    {
        get { return _electronicDeviceDescription ?? (_electronicDeviceDescription = new System.Collections.Generic.List<TextType>()); }
        set { _electronicDeviceDescription = value; }
    }

        
    /// <summary>
    /// Indicates whether an electronic auction will be used before the awarding of a contract (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Auction Terms. Auction_ Constraint. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Auction Terms
    /// <para />PropertyTermQualifier: Auction
    /// <para />PropertyTerm: Constraint
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType AuctionConstraintIndicator
    {
        get
        {
            if (__AuctionConstraintIndicator == null) { __AuctionConstraintIndicator = new IndicatorType(); }
            return __AuctionConstraintIndicator;
        }
        set
        {
            __AuctionConstraintIndicator = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) of the electronic device used for the auction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Auction Terms. Auction_ URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Auction Terms
    /// <para />PropertyTermQualifier: Auction
    /// <para />PropertyTerm: URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType AuctionURI
    {
        get
        {
            if (__AuctionURI == null) { __AuctionURI = new IdentifierType(); }
            return __AuctionURI;
        }
        set
        {
            __AuctionURI = value;
        }
    }

}