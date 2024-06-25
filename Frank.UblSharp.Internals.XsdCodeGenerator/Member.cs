using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.Internals.XsdCodeGenerator
{
    public struct Member
    {
        public MemberDeclarationSyntax MemberDeclarationSyntax { get; set; }
        public List<string> Directories { get; set; }
        public string RelativePath { get; set; }
    }
}