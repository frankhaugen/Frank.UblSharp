namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// One calendar day according the Gregorian calendar.
/// <para />UniqueID: UBLUDT000009
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Date. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Date
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DateType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class DateType
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