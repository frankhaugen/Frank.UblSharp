namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A particular point in the progression of time, together with relevant supplementary information.
/// <para />UniqueID: UBLUDT000008
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Date Time. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Date Time
/// <para />PrimitiveType: string
/// <para />UsageRule: Can be used for a date and/or time.
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DateTimeType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class DateTimeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime @__Value;
        
    public static implicit operator DateTimeType(System.DateTime value)
    {
        return new DateTimeType { Value = value };
    }

    public static implicit operator System.DateTime(DateTimeType value)
    {
        return value.Value;
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.DateTime Value
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