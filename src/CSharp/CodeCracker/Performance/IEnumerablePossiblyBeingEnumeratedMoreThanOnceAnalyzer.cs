using System.Collections.Immutable;
using CodeCracker.Properties;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CodeCracker.CSharp.Performance
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class IEnumerablePossiblyBeingEnumeratedMoreThanOnceAnalyzer : DiagnosticAnalyzer
    {
        internal static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.IEnumerablePossiblyBeingEnumeratedMoreThanOnce_Title), Resources.ResourceManager, typeof(Resources));

        internal static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(
            DiagnosticId.IEnumerablePossiblyBeingEnumeratedMoreThanOnce.ToDiagnosticId(),
            Title,
            Title,
            SupportedCategories.Maintainability,
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true,
            helpLinkUri: HelpLink.ForDiagnostic(DiagnosticId.IEnumerablePossiblyBeingEnumeratedMoreThanOnce));

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext context) => context.RegisterSyntaxNodeAction(Analyzer, SyntaxKind.SingleLineDocumentationCommentTrivia);

        private void Analyzer(SyntaxNodeAnalysisContext obj) { throw new System.NotImplementedException(); }
    }
}