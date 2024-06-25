using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A character string to identify and distinguish uniquely, one instance of an object in an identification scheme from all other objects in the same scheme together with relevant supplementary information.
/// <para />UniqueID: UNDT000011
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Identifier. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Identifier
/// <para />PrimitiveType: string
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifierType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctIdentifierType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctIdentifierType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("schemeID", DataType="normalizedString")]
    public string @__schemeID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("schemeName")]
    public string @__schemeName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("schemeAgencyID", DataType="normalizedString")]
    public string @__schemeAgencyID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("schemeAgencyName")]
    public string @__schemeAgencyName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("schemeVersionID", DataType="normalizedString")]
    public string @__schemeVersionID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("schemeDataURI", DataType="anyURI")]
    public string @__schemeDataURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("schemeURI", DataType="anyURI")]
    public string @__schemeURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
    public string @__Value;
        
    /// <summary>
    /// The identification of the identification scheme.
    /// <para />UniqueID: UNDT000011-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Identification Scheme. Identifier
    /// <para />ObjectClass: Identification Scheme
    /// <para />PropertyTermName: Identification
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string schemeID
    {
        get
        {
            return __schemeID;
        }
        set
        {
            __schemeID = value;
        }
    }

        
    /// <summary>
    /// The name of the identification scheme.
    /// <para />UniqueID: UNDT000011-SC3
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Identification Scheme. Name. Text
    /// <para />ObjectClass: Identification Scheme
    /// <para />PropertyTermName: Name
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string schemeName
    {
        get
        {
            return __schemeName;
        }
        set
        {
            __schemeName = value;
        }
    }

        
    /// <summary>
    /// The identification of the agency that maintains the identification scheme.
    /// <para />UniqueID: UNDT000011-SC4
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Identification Scheme Agency. Identifier
    /// <para />ObjectClass: Identification Scheme Agency
    /// <para />PropertyTermName: Identification
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// <para />UsageRule: Defaults to the UN/EDIFACT data element 3055 code list.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string schemeAgencyID
    {
        get
        {
            return __schemeAgencyID;
        }
        set
        {
            __schemeAgencyID = value;
        }
    }

        
    /// <summary>
    /// The name of the agency that maintains the identification scheme.
    /// <para />UniqueID: UNDT000011-SC5
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Identification Scheme Agency. Name. Text
    /// <para />ObjectClass: Identification Scheme Agency
    /// <para />PropertyTermName: Agency Name
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string schemeAgencyName
    {
        get
        {
            return __schemeAgencyName;
        }
        set
        {
            __schemeAgencyName = value;
        }
    }

        
    /// <summary>
    /// The version of the identification scheme.
    /// <para />UniqueID: UNDT000011-SC6
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Identification Scheme. Version. Identifier
    /// <para />ObjectClass: Identification Scheme
    /// <para />PropertyTermName: Version
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string schemeVersionID
    {
        get
        {
            return __schemeVersionID;
        }
        set
        {
            __schemeVersionID = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme data is located.
    /// <para />UniqueID: UNDT000011-SC7
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Identification Scheme Data. Uniform Resource. Identifier
    /// <para />ObjectClass: Identification Scheme Data
    /// <para />PropertyTermName: Uniform Resource Identifier
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string schemeDataURI
    {
        get
        {
            return __schemeDataURI;
        }
        set
        {
            __schemeDataURI = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier that identifies where the identification scheme is located.
    /// <para />UniqueID: UNDT000011-SC8
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Identification Scheme. Uniform Resource. Identifier
    /// <para />ObjectClass: Identification Scheme
    /// <para />PropertyTermName: Uniform Resource Identifier
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string schemeURI
    {
        get
        {
            return __schemeURI;
        }
        set
        {
            __schemeURI = value;
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