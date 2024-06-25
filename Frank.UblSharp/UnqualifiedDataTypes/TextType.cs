using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A character string (i.e. a finite set of characters), generally in the form of words of a language.
/// <para />UniqueID: UBLUDT0000019
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Text. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Text
/// <para />PrimitiveType: string
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TextType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class TextType : CctTextType
{
        
    public static implicit operator TextType(string value)
    {
        return value == null ? null : new TextType { Value = value };
    }

    public static implicit operator string(TextType value)
    {
        return value.Value;
    }

}