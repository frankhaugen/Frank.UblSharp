namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A list of two mutually exclusive Boolean values that express the only possible states of a property.
/// <para />UniqueID: UBLUDT0000012
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Indicator. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Indicator
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicatorType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class IndicatorType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool @__Value;
        
    public static implicit operator IndicatorType(bool value)
    {
        return new IndicatorType { Value = value };
    }

    public static implicit operator bool(IndicatorType value)
    {
        return value.Value;
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool Value
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