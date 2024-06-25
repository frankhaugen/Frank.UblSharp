using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A character string (i.e. a finite set of characters) generally in the form of words of a language.
/// <para />UniqueID: UNDT000019
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Text. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Text
/// <para />PrimitiveType: string
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(NameType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctTextType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctTextType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("languageID", DataType="language")]
    public string @__languageID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("languageLocaleID", DataType="normalizedString")]
    public string @__languageLocaleID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public string @__Value;
        
    /// <summary>
    /// The identifier of the language used in the content component.
    /// <para />UniqueID: UNDT000019-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Language. Identifier
    /// <para />ObjectClass: Language
    /// <para />PropertyTermName: Identification
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string languageID
    {
        get
        {
            return __languageID;
        }
        set
        {
            __languageID = value;
        }
    }

        
    /// <summary>
    /// The identification of the locale of the language.
    /// <para />UniqueID: UNDT000019-SC3
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Language. Locale. Identifier
    /// <para />ObjectClass: Language
    /// <para />PropertyTermName: Locale
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string languageLocaleID
    {
        get
        {
            return __languageLocaleID;
        }
        set
        {
            __languageLocaleID = value;
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