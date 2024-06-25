using Frank.UblSharp.CoreComponentTypes;

namespace Frank.UblSharp.UnqualifiedDataTypes;

/// <summary>
/// A character string (letters, figures, or symbols) that for brevity and/or language independence may be used to represent or replace a definitive value or text of an attribute, together with relevant supplementary information.
/// <para />UniqueID: UBLUDT000007
/// <para />CategoryCode: UDT
/// <para />DictionaryEntryName: Code. Type
/// <para />VersionID: 1.0
/// <para />RepresentationTermName: Code
/// <para />PrimitiveType: string
/// <para />UsageRule: Other supplementary components in the CCT are captured as part of the token and name for the schema module containing the code list and thus, are not declared as attributes.
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CodeType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2", IsNullable=true)]
public partial class CodeType : CctCodeType
{
        
    public static implicit operator CodeType(string value)
    {
        return value == null ? null : new CodeType { Value = value };
    }

    public static implicit operator string(CodeType value)
    {
        return value.Value;
    }

}