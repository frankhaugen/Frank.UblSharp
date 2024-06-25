using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A character string (letters, figures, or symbols) that for brevity and/or languange independence may be used to represent or replace a definitive value or text of an attribute together with relevant supplementary information.
/// <para />UniqueID: UNDT000007
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Code. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Code
/// <para />PrimitiveType: string
/// <para />UsageRule: Should not be used if the character string identifies an instance of an object class or an object in the real world, in which case the Identifier. Type should be used.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctCodeType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctCodeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("listID", DataType="normalizedString")]
    public string @__listID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("listAgencyID", DataType="normalizedString")]
    public string @__listAgencyID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("listAgencyName")]
    public string @__listAgencyName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("listName")]
    public string @__listName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("listVersionID", DataType="normalizedString")]
    public string @__listVersionID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("name")]
    public string @__name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("languageID", DataType="language")]
    public string @__languageID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("listURI", DataType="anyURI")]
    public string @__listURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("listSchemeURI", DataType="anyURI")]
    public string @__listSchemeURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
    public string @__Value;
        
    /// <summary>
    /// The identification of a list of codes.
    /// <para />UniqueID: UNDT000007-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code List. Identifier
    /// <para />ObjectClass: Code List
    /// <para />PropertyTermName: Identification
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string listID
    {
        get
        {
            return __listID;
        }
        set
        {
            __listID = value;
        }
    }

        
    /// <summary>
    /// An agency that maintains one or more lists of codes.
    /// <para />UniqueID: UNDT000007-SC3
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code List. Agency. Identifier
    /// <para />ObjectClass: Code List
    /// <para />PropertyTermName: Agency
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// <para />UsageRule: Defaults to the UN/EDIFACT data element 3055 code list.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string listAgencyID
    {
        get
        {
            return __listAgencyID;
        }
        set
        {
            __listAgencyID = value;
        }
    }

        
    /// <summary>
    /// The name of the agency that maintains the list of codes.
    /// <para />UniqueID: UNDT000007-SC4
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code List. Agency Name. Text
    /// <para />ObjectClass: Code List
    /// <para />PropertyTermName: Agency Name
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string listAgencyName
    {
        get
        {
            return __listAgencyName;
        }
        set
        {
            __listAgencyName = value;
        }
    }

        
    /// <summary>
    /// The name of a list of codes.
    /// <para />UniqueID: UNDT000007-SC5
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code List. Name. Text
    /// <para />ObjectClass: Code List
    /// <para />PropertyTermName: Name
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string listName
    {
        get
        {
            return __listName;
        }
        set
        {
            __listName = value;
        }
    }

        
    /// <summary>
    /// The version of the list of codes.
    /// <para />UniqueID: UNDT000007-SC6
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code List. Version. Identifier
    /// <para />ObjectClass: Code List
    /// <para />PropertyTermName: Version
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string listVersionID
    {
        get
        {
            return __listVersionID;
        }
        set
        {
            __listVersionID = value;
        }
    }

        
    /// <summary>
    /// The textual equivalent of the code content component.
    /// <para />UniqueID: UNDT000007-SC7
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code. Name. Text
    /// <para />ObjectClass: Code
    /// <para />PropertyTermName: Name
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string name
    {
        get
        {
            return __name;
        }
        set
        {
            __name = value;
        }
    }

        
    /// <summary>
    /// The identifier of the language used in the code name.
    /// <para />UniqueID: UNDT000007-SC8
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
    /// The Uniform Resource Identifier that identifies where the code list is located.
    /// <para />UniqueID: UNDT000007-SC9
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code List. Uniform Resource. Identifier
    /// <para />ObjectClass: Code List
    /// <para />PropertyTermName: Uniform Resource Identifier
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string listURI
    {
        get
        {
            return __listURI;
        }
        set
        {
            __listURI = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier that identifies where the code list scheme is located.
    /// <para />UniqueID: UNDT000007-SC10
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Code List Scheme. Uniform Resource. Identifier
    /// <para />ObjectClass: Code List Scheme
    /// <para />PropertyTermName: Uniform Resource Identifier
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string listSchemeURI
    {
        get
        {
            return __listSchemeURI;
        }
        set
        {
            __listSchemeURI = value;
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