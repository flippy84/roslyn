// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.Editor.CSharp.Outlining.MetadataAsSource
{
    internal class DelegateDeclarationOutliner : AbstractMetadataAsSourceOutliner<DelegateDeclarationSyntax>
    {
        protected override SyntaxToken GetEndToken(DelegateDeclarationSyntax node)
        {
            return node.Modifiers.Count > 0
                    ? node.Modifiers.First()
                    : node.DelegateKeyword;
        }
    }
}
