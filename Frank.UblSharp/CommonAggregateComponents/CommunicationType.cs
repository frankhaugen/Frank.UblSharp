using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a means of communication.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Communication. Details
/// <para />ObjectClass: Communication
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Communication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Communication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CommunicationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChannelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__ChannelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Channel", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__Channel;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Value", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__Value;
        
    /// <summary>
    /// The method of communication, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Communication. Channel Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Communication
    /// <para />PropertyTerm: Channel Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Channel
    /// <para />DataType: Channel_ Code. Type
    /// </summary>
    /// <example>Phone Fax Email</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ChannelCode
    {
        get
        {
            if (__ChannelCode == null) { __ChannelCode = new CodeType(); }
            return __ChannelCode;
        }
        set
        {
            __ChannelCode = value;
        }
    }

        
    /// <summary>
    /// The method of communication, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Communication. Channel. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Communication
    /// <para />PropertyTerm: Channel
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Skype</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Channel
    {
        get
        {
            if (__Channel == null) { __Channel = new TextType(); }
            return __Channel;
        }
        set
        {
            __Channel = value;
        }
    }

        
    /// <summary>
    /// An identifying value (phone number, email address, etc.) for this channel of communication
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Communication. Value. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Communication
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>+44 1 2345 6789 president@whitehouse.com</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Value
    {
        get
        {
            if (__Value == null) { __Value = new TextType(); }
            return __Value;
        }
        set
        {
            __Value = value;
        }
    }

}