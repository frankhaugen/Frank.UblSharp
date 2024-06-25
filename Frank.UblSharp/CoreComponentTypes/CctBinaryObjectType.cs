using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CoreComponentTypes;

/// <summary>
/// A set of finite-length sequences of binary octets.
/// <para />UniqueID: UNDT000002
/// <para />CategoryCode: CCT
/// <para />DictionaryEntryName: Binary Object. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Binary Object
/// <para />PrimitiveType: binary
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SoundType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PictureType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryObjectType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CctBinaryObjectType", Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2", IsNullable=true)]
public abstract partial class CctBinaryObjectType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("format")]
    public string @__format;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("mimeCode", DataType="normalizedString")]
    public string @__mimeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("encodingCode", DataType="normalizedString")]
    public string @__encodingCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("characterSetCode", DataType="normalizedString")]
    public string @__characterSetCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("uri", DataType="anyURI")]
    public string @__uri;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("filename")]
    public string @__filename;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
    public byte[] @__Value;
        
    /// <summary>
    /// The format of the binary content.
    /// <para />UniqueID: UNDT000002-SC2
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Binary Object. Format. Text
    /// <para />ObjectClass: Binary Object
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

        
    /// <summary>
    /// The mime type of the binary object.
    /// <para />UniqueID: UNDT000002-SC3
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Binary Object. Mime. Code
    /// <para />ObjectClass: Binary Object
    /// <para />PropertyTermName: Mime
    /// <para />RepresentationTermName: Code
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string mimeCode
    {
        get
        {
            return __mimeCode;
        }
        set
        {
            __mimeCode = value;
        }
    }

        
    /// <summary>
    /// Specifies the decoding algorithm of the binary object.
    /// <para />UniqueID: UNDT000002-SC4
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Binary Object. Encoding. Code
    /// <para />ObjectClass: Binary Object
    /// <para />PropertyTermName: Encoding
    /// <para />RepresentationTermName: Code
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string encodingCode
    {
        get
        {
            return __encodingCode;
        }
        set
        {
            __encodingCode = value;
        }
    }

        
    /// <summary>
    /// The character set of the binary object if the mime type is text.
    /// <para />UniqueID: UNDT000002-SC5
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Binary Object. Character Set. Code
    /// <para />ObjectClass: Binary Object
    /// <para />PropertyTermName: Character Set
    /// <para />RepresentationTermName: Code
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string characterSetCode
    {
        get
        {
            return __characterSetCode;
        }
        set
        {
            __characterSetCode = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier that identifies where the binary object is located.
    /// <para />UniqueID: UNDT000002-SC6
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Binary Object. Uniform Resource. Identifier
    /// <para />ObjectClass: Binary Object
    /// <para />PropertyTermName: Uniform Resource Identifier
    /// <para />RepresentationTermName: Identifier
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string uri
    {
        get
        {
            return __uri;
        }
        set
        {
            __uri = value;
        }
    }

        
    /// <summary>
    /// The filename of the binary object.
    /// <para />UniqueID: UNDT000002-SC7
    /// <para />CategoryCode: SC
    /// <para />DictionaryEntryName: Binary Object. Filename.Text
    /// <para />ObjectClass: Binary Object
    /// <para />PropertyTermName: Filename
    /// <para />RepresentationTermName: Text
    /// <para />PrimitiveType: string
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string filename
    {
        get
        {
            return __filename;
        }
        set
        {
            __filename = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] Value
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