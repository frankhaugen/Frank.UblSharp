using System.CodeDom;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.Generation.CodeGen;

public static class UblGeneratorFactory
{
    public static Generator Create(DirectoryInfo outputDirectory, Action<string> logAction, OutputWriter? outputWriter = null)
    {
        return new Generator
        {
            OutputFolder = outputDirectory.FullName,
            Log = logAction,
            PrivateMemberPrefix = "_",
            IntegerDataType = typeof(int),
            CollectionImplementationType = typeof(Collection<>),
            CollectionType = typeof(Collection<>),
            NamingScheme = NamingScheme.PascalCase,
            DataAnnotationMode = DataAnnotationMode.None,
            CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization,
            CodeTypeReferenceOptions = CodeTypeReferenceOptions.GlobalReference,
            NamespaceProvider = new NamespaceProvider
            {
                GenerateNamespace = x =>
                {
                    var customNamespace = new Regex("[^a-zA-Z0-9]").Replace(x.XmlSchemaNamespace, "_");

                    // Single mapping per namespace (avoid stacking oasis generic + explicit rules).
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonExtensionComponents_2") return "CommonExtensionComponents";
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonSignatureComponents_2") return "CommonSignatureComponents";
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureBasicComponents_2") return "SignatureBasicComponents";
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureAggregateComponents_2") return "SignatureAggregateComponents";
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonAggregateComponents_2") return "CommonAggregateComponents";
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonBasicComponents_2") return "CommonBasicComponents";
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_UnqualifiedDataTypes_2") return "UnqualifiedDataTypes";

                    if (customNamespace.StartsWith("urn_oasis_names_specification_ubl_schema_xsd_", StringComparison.Ordinal))
                    {
                        return customNamespace
                            .Replace("urn_oasis_names_specification_ubl_schema_xsd_", "", StringComparison.Ordinal)
                            .Replace("_2", "", StringComparison.Ordinal);
                    }

                    if (customNamespace == "urn_un_unece_uncefact_data_specification_CoreComponentTypeSchemaModule_2") return "CoreComponentTypes";

                    // Do not map arbitrary http(s) URLs to CoreComponentTypes — xmldsig/XAdES must stay separate.
                    if (customNamespace.StartsWith("http___www_w3_org_2000_09_xmldsig", StringComparison.Ordinal)) return "XmlDsig";
                    if (customNamespace.StartsWith("http___uri_etsi_org_01903_", StringComparison.Ordinal)) return "Xades";

                    return string.Empty;
                }
            },
            GenerateInterfaces = true,
            NetCoreSpecificCode = true,
            SeparateClasses = true,
            EntityFramework = false,
            EnumAsString = true,
            MapUnionToWidestCommonType = true,
            GenerateNullables = false,
            DoNotForceIsNullable = false,
            EmitOrder = false,
            SeparateNamespaceHierarchy = true,
            DisableComments = false,
            GenerateDescriptionAttribute = false,
            EnableNullableReferenceAttributes = false,
            CompactTypeNames = true,
            SeparateSubstitutes = true,
            GenerateSerializableAttribute = false,
            CreateGeneratedCodeAttributeVersion = true,
            AssemblyVisible = false,
            EnableUpaCheck = true,
            UseShouldSerializePattern = false,
            GenerateDesignerCategoryAttribute = false,
            CommentLanguages = { "en" },
            UseXElementForAny = true,
            GenerateDebuggerStepThroughAttribute = true,
            UniqueTypeNamesAcrossNamespaces = true,
            OutputWriter = outputWriter,
        };
    }
}