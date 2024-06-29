using System.CodeDom;
using System.Text;
using System.Text.RegularExpressions;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.GeneratorV2;

public static class UblGeneratorFactory
{
    public static Generator Create(DirectoryInfo outputDirectory, string rootNamespace, List<string> fileLog, OutputWriter outputWriter)
    {
        return new Generator
        {
            OutputFolder = outputDirectory.FullName,
            Log = fileLog.Add,
            PrivateMemberPrefix = "_",
            IntegerDataType = typeof(int),
            CollectionImplementationType = typeof(List<>),
            CollectionType = typeof(List<>),
            NamingScheme = NamingScheme.PascalCase,
            DataAnnotationMode = DataAnnotationMode.All,
            CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization,
            CodeTypeReferenceOptions = CodeTypeReferenceOptions.GenericTypeParameter,
            NamespaceProvider = new NamespaceProvider
            {
                GenerateNamespace = x =>
                {
                    var namespaceBuilder = new StringBuilder();

                    namespaceBuilder.Append(rootNamespace);
                    namespaceBuilder.Append(".");

                    var customNamespace = new Regex("[^a-zA-Z0-9]").Replace(x.XmlSchemaNamespace, "_");

                    if (customNamespace.StartsWith("urn_oasis_names_specification_ubl_schema_xsd_"))
                    {
                        var documentName = customNamespace
                            .Replace("urn_oasis_names_specification_ubl_schema_xsd_", "")
                            .Replace("_2", "");
                        namespaceBuilder.Append(documentName);
                    }

                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonExtensionComponents_2") namespaceBuilder.Append("CommonExtensionComponents");
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonSignatureComponents_2") namespaceBuilder.Append("CommonSignatureComponents");
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureBasicComponents_2") namespaceBuilder.Append("SignatureBasicComponents");
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureAggregateComponents_2") namespaceBuilder.Append("SignatureAggregateComponents");
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonAggregateComponents_2") namespaceBuilder.Append("CommonAggregateComponents");
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonBasicComponents_2") namespaceBuilder.Append("CommonBasicComponents");
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_UnqualifiedDataTypes_2") namespaceBuilder.Append("UnqualifiedDataTypes");
                    if (customNamespace == "urn_un_unece_uncefact_data_specification_CoreComponentTypeSchemaModule_2") namespaceBuilder.Append("CoreComponentTypes");
                    if (customNamespace.StartsWith("http___")) namespaceBuilder.Append("CoreComponentTypes");

                    return namespaceBuilder.ToString();
                }
            },
            GenerateInterfaces = true,
            NetCoreSpecificCode = true,
            SeparateClasses = true,
            EntityFramework = true,
            EnumAsString = true,
            MapUnionToWidestCommonType = true,
            GenerateNullables = true,
            DoNotForceIsNullable = false,
            EmitOrder = true,
            SeparateNamespaceHierarchy = true,
            DisableComments = false,
            GenerateDescriptionAttribute = true,
            EnableNullableReferenceAttributes = true,
            CompactTypeNames = true,
            SeparateSubstitutes = true,
            GenerateSerializableAttribute = true,
            CreateGeneratedCodeAttributeVersion = true,
            AssemblyVisible = false,
            EnableUpaCheck = true,
            UseShouldSerializePattern = false,
            GenerateDesignerCategoryAttribute = false,
            CommentLanguages = { "en" },
            UseXElementForAny = false,
            GenerateDebuggerStepThroughAttribute = true,
            UniqueTypeNamesAcrossNamespaces = true
            // OutputWriter = outputWriter,
        };
    }
}