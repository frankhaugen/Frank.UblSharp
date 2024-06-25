namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A particular point in the progression of time together with the relevant supplementary information.
/// <para />UniqueID: UNDT000008
/// <para />CategoryCode: CCT
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
[System.Xml.Serialization.XmlTypeAttribute("CctDateTimeType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctDateTimeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("format")]
    public string @__format;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public string @__Value;
        
    /// <summary>
    /// The format of the date time content
    /// <para />UniqueID: UNDT000008-SC1
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Date Time. Format. Text
    /// <para />ObjectClass: Date Time
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