using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the result of an attempt to verify a signature.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Result Of Verification. Details
/// <para />ObjectClass: Result Of Verification
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ResultOfVerification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ResultOfVerification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ResultOfVerificationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidatorID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ValidatorID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidationResultCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ValidationResultCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__ValidationDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidationTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TimeType @__ValidationTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidateProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__ValidateProcess;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidateTool", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType @__ValidateTool;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidateToolVersion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__ValidateToolVersion;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignatoryParty", Order=7)]
    public PartyType @__SignatoryParty;
        
    /// <summary>
    /// An identifier for the organization, person, service, or server that verified the signature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Result Of Verification. Validator. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTerm: Validator
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ValidatorID
    {
        get
        {
            if (__ValidatorID == null) { __ValidatorID = new IdentifierType(); }
            return __ValidatorID;
        }
        set
        {
            __ValidatorID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the result of the verification.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Result Of Verification. Validation_ Result Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTermQualifier: Validation
    /// <para />PropertyTerm: Result Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ValidationResultCode
    {
        get
        {
            if (__ValidationResultCode == null) { __ValidationResultCode = new CodeType(); }
            return __ValidationResultCode;
        }
        set
        {
            __ValidationResultCode = value;
        }
    }

        
    /// <summary>
    /// The date upon which verification took place.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Result Of Verification. Validation Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTerm: Validation Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ValidationDate
    {
        get
        {
            if (__ValidationDate == null) { __ValidationDate = new DateType(); }
            return __ValidationDate;
        }
        set
        {
            __ValidationDate = value;
        }
    }

        
    /// <summary>
    /// The time at which verification took place.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Result Of Verification. Validation Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTerm: Validation Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ValidationTime
    {
        get
        {
            if (__ValidationTime == null) { __ValidationTime = new TimeType(); }
            return __ValidationTime;
        }
        set
        {
            __ValidationTime = value;
        }
    }

        
    /// <summary>
    /// The verification process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Result Of Verification. Validate_ Process. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTermQualifier: Validate
    /// <para />PropertyTerm: Process
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ValidateProcess
    {
        get
        {
            if (__ValidateProcess == null) { __ValidateProcess = new TextType(); }
            return __ValidateProcess;
        }
        set
        {
            __ValidateProcess = value;
        }
    }

        
    /// <summary>
    /// The tool used to verify the signature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Result Of Verification. Validate_ Tool. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTermQualifier: Validate
    /// <para />PropertyTerm: Tool
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ValidateTool
    {
        get
        {
            if (__ValidateTool == null) { __ValidateTool = new TextType(); }
            return __ValidateTool;
        }
        set
        {
            __ValidateTool = value;
        }
    }

        
    /// <summary>
    /// The version of the tool used to verify the signature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Result Of Verification. Validate_ Tool Version. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTermQualifier: Validate
    /// <para />PropertyTerm: Tool Version
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ValidateToolVersion
    {
        get
        {
            if (__ValidateToolVersion == null) { __ValidateToolVersion = new TextType(); }
            return __ValidateToolVersion;
        }
        set
        {
            __ValidateToolVersion = value;
        }
    }

        
    /// <summary>
    /// The signing party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Result Of Verification. Signatory_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Result Of Verification
    /// <para />PropertyTermQualifier: Signatory
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType SignatoryParty
    {
        get
        {
            if (__SignatoryParty == null) { __SignatoryParty = new PartyType(); }
            return __SignatoryParty;
        }
        set
        {
            __SignatoryParty = value;
        }
    }

}