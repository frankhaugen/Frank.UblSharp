using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.Internals.XsdCodeGenerator
{
    internal class ClassMember
    {
        public ClassMember(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public Dictionary<string, ClassMember> NestedClasses { get; } = new Dictionary<string, ClassMember>();
        public List<MemberDeclarationSyntax> MemberDeclarationSyntaxes { get; } = new List<MemberDeclarationSyntax>();

        public ClassMember GetOrAddNestedClass(List<string> classPath)
        {
            if (!classPath.Any()) return this;

            var nextClass = classPath.First();
            if (!NestedClasses.TryGetValue(nextClass, out var nextClassMember))
            {
                nextClassMember = new ClassMember(nextClass);
                NestedClasses[nextClass] = nextClassMember;
            }

            classPath.RemoveAt(0);
            return nextClassMember.GetOrAddNestedClass(classPath);
        }

        public ClassDeclarationSyntax GenerateClassRecursively()
        {
            var classDeclaration = SyntaxFactory.ClassDeclaration(ConvertPathToClassName(Name))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.InternalKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .AddMembers(MemberDeclarationSyntaxes.ToArray());

            foreach (var nestedClass in NestedClasses.Values)
            {
                classDeclaration = classDeclaration.AddMembers(nestedClass.GenerateClassRecursively());
            }

            return classDeclaration;
        }

        private static string ConvertPathToClassName(string path)
        {
            var className = Path.GetFileNameWithoutExtension(path);
            className = Regex.Replace(className, @"[\W]", "_");
            return char.ToUpper(className[0]) + className.Substring(1);
        }
    }
}