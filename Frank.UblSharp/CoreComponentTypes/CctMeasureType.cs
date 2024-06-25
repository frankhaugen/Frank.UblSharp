using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A numeric value determined by measuring an object along with the specified unit of measure.
/// <para />UniqueID: UNDT000013
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Measure. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Measure
/// <para />PrimitiveType: decimal
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasureType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctMeasureType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctMeasureType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("unitCode", DataType="normalizedString")]
    public string @__unitCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("unitCodeListVersionID", DataType="normalizedString")]
    public string @__unitCodeListVersionID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal @__Value;
        
    /// <summary>
    /// The type of unit of measure.
    /// <para />UniqueID: UNDT000013-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Measure Unit. Code
    /// <para />ObjectClass: Measure Unit
    /// <para />PropertyTermName: Code
    /// <para />RepresentationTermName: Code
    /// <para />PrimitiveType: string
    /// <para />UsageRule: Reference UNECE Rec. 20 and X12 355
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string unitCode
    {
        get
        {
            return __unitCode;
        }
        set
        {
            __unitCode = value;
        }
    }

        
    /// <summary>
    /// The version of the measure unit code list.
    /// <para />UniqueID: UNDT000013-SC3
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Measure Unit. Code List Version. Identifier
    /// <para />ObjectClass: Measure Unit
    /// <para />PropertyTermName: Code List Version
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string unitCodeListVersionID
    {
        get
        {
            return __unitCodeListVersionID;
        }
        set
        {
            __unitCodeListVersionID = value;
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