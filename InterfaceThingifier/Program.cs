using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace InterfaceThingifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var filepath = @"c:\dev\scratch\interfacethingifier\togglemonkey\arbitarybadger.cs";
            var filecontents = File.ReadAllText(filepath);
            var tree = CSharpSyntaxTree.ParseText(filecontents);
            var root = (CompilationUnitSyntax) tree.GetRoot();
        }
    }
}
