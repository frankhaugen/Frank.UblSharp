namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A list of two mutually exclusive Boolean values that express the only possible states of a Property.
/// <para />UniqueID: UNDT000012
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Indicator. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Indicator
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctIndicatorType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctIndicatorType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("format")]
    public string @__format;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public string @__Value;
        
    /// <summary>
    /// Whether the indicator is numeric, textual or binary.
    /// <para />UniqueID: UNDT000012-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Indicator. Format. Text
    /// <para />ObjectClass: Indicator
    /// <para />PropertyTermName: Format
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string format
    {
        get
        {
            return __format;
        }
        set
        {
            __format = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Value
    {
        get
        {
            return __Value;
        }
        set
        {
            __Value = value;
        }
    }

}