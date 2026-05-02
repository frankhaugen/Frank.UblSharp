# UBL code generation

## Supported pipeline (use this)

1. **Schemas** live in `Frank.UblSharp.Resources` (`xsd/**`). The `Frank.UblSharp.Internals.XsdCodeGenerator` analyzer generates `AdditionalResources` (including `GetXmlSchemaSet()`).
2. **`Frank.UblSharp.Resources.ResourcesHelper`** delegates to `AdditionalResources.GetXmlSchemaSet()` for a single schema entry point.
3. **`Frank.UblSharp.Generation`** hosts the Roslyn source generator **`UblCodeGenerator`**. It loads the schema set, runs `XmlSchemaMetaVisitor` on the **full** set, filters with **`UblMainDocumentXmlSchemaFilter`**, then **`XmlSchemaClassGenerator`** (`UblGeneratorFactory`) and emits C# via **`AddSource`** (no disk writes from the generator).
4. **`Frank.UblSharp`** references `Frank.UblSharp.Generation` with `ReferenceOutputAssembly="false"` and loads the generator plus peer assemblies from `artifacts/bin/Frank.UblSharp.Generation/<config>/` so `Frank.UblSharp.Resources` and `Frank.UblSharp.Internals.XsdCodeGenerator` resolve next to `Frank.UblSharp.Generation.dll`.

`GeneratorExecutionContext` helpers live only in **`Frank.UblSharp.Internals.XsdCodeGenerator`** (`GeneratorExecutionContextExtensions`); `Frank.UblSharp.Generation` uses them via `InternalsVisibleTo`.

## Legacy CLI projects (not part of the supported pipeline)

These standalone tools overlap with the analyzer and are easy to drift out of sync with `net10.0` / current resources:

- `Frank.UblSharp.Generator`
- `Frank.UblSharp.GeneratorV2`, `GeneratorV3`, `GeneratorV4`

Prefer the analyzer path above for new work. Updating or removing the legacy projects should be done only after parity checks.

## Tests

`Frank.UblSharp.Tests` exercises XML serialization against types produced by the generator (namespaces match document modules, e.g. `Invoice`, `CreditNote`).
