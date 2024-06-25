namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// An instance of time that occurs every day.
/// <para />UniqueID: UBLUDT0000010
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Time. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Time
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TimeType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class TimeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.DateTimeOffset @__Value;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.DateTimeOffset Value
    {
        get
        {
            if (__Value == null) { __Value = new System.DateTimeOffset(); }
            return __Value;
        }
        set
        {
            __Value = value;
        }
    }

}