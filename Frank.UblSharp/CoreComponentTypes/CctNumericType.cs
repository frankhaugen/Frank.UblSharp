using Frank.UblSharp.UnqualifiedDataTypes;
using ValueType = Frank.UblSharp.UnqualifiedDataTypes.ValueType;

namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
/// <para />UniqueID: UNDT000014
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Numeric. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Numeric
/// <para />PrimitiveType: string
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RateType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NumericType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctNumericType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctNumericType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("format")]
    public string @__format;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal @__Value;
        
    /// <summary>
    /// Whether the number is an integer, decimal, real number or percentage.
    /// <para />UniqueID: UNDT000014-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Numeric. Format. Text
    /// <para />ObjectClass: Numeric
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
    public decimal Value
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