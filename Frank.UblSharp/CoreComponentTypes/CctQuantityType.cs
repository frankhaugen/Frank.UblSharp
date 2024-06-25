using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A counted number of non-monetary units possibly including fractions.
/// <para />UniqueID: UNDT000018
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Quantity. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Quantity
/// <para />PrimitiveType: decimal
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctQuantityType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctQuantityType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("unitCode", DataType="normalizedString")]
    public string @__unitCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("unitCodeListID", DataType="normalizedString")]
    public string @__unitCodeListID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("unitCodeListAgencyID", DataType="normalizedString")]
    public string @__unitCodeListAgencyID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("unitCodeListAgencyName")]
    public string @__unitCodeListAgencyName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal @__Value;
        
    /// <summary>
    /// The unit of the quantity
    /// <para />UniqueID: UNDT000018-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Quantity. Unit. Code
    /// <para />ObjectClass: Quantity
    /// <para />PropertyTermName: Unit Code
    /// <para />RepresentationTermName: Code
    /// <para />PrimitiveType: string
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
    /// The quantity unit code list.
    /// <para />UniqueID: UNDT000018-SC3
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Quantity Unit. Code List. Identifier
    /// <para />ObjectClass: Quantity Unit
    /// <para />PropertyTermName: Code List
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string unitCodeListID
    {
        get
        {
            return __unitCodeListID;
        }
        set
        {
            __unitCodeListID = value;
        }
    }

        
    /// <summary>
    /// The identification of the agency that maintains the quantity unit code list
    /// <para />UniqueID: UNDT000018-SC4
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Quantity Unit. Code List Agency. Identifier
    /// <para />ObjectClass: Quantity Unit
    /// <para />PropertyTermName: Code List Agency
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// <para />UsageRule: Defaults to the UN/EDIFACT data element 3055 code list.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string unitCodeListAgencyID
    {
        get
        {
            return __unitCodeListAgencyID;
        }
        set
        {
            __unitCodeListAgencyID = value;
        }
    }

        
    /// <summary>
    /// The name of the agency which maintains the quantity unit code list.
    /// <para />UniqueID: UNDT000018-SC5
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Quantity Unit. Code List Agency Name. Text
    /// <para />ObjectClass: Quantity Unit
    /// <para />PropertyTermName: Code List Agency Name
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string unitCodeListAgencyName
    {
        get
        {
            return __unitCodeListAgencyName;
        }
        set
        {
            __unitCodeListAgencyName = value;
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