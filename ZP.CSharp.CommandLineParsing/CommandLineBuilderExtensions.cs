using System;
using System.CommandLine;
using System.CommandLine.Builder;
namespace ZP.CSharp.CommandLineParsing
{
    public static class CommandLineBuilderExtensions
    {
        public static CommandLineBuilder UseDefaultsWithCustomHelpAndVersionOpts(
            this CommandLineBuilder builder,
            string helpAlias,
            string versionAlias)
        {
            return builder.UseDefaultsWithCustomHelpAndVersionOpts(
                new string[]{helpAlias},
                new string[]{versionAlias}
            );
        }
        public static CommandLineBuilder UseDefaultsWithCustomHelpAndVersionOpts(
            this CommandLineBuilder builder,
            string[] helpAliases,
            string[] versionAliases)
        {
            return builder
                .UseVersionOption(versionAliases)
                .UseHelp(helpAliases)
                .UseEnvironmentVariableDirective()
                .UseParseDirective()
                .UseSuggestDirective()
                .RegisterWithDotnetSuggest()
                .UseTypoCorrections()
                .UseParseErrorReporting()
                .UseExceptionHandler()
                .CancelOnProcessTermination();
        }
        public static CommandLineBuilder UseDefaultsWithCustomHelpOpts(
            this CommandLineBuilder builder,
            string helpAlias)
        {
            return builder.UseDefaultsWithCustomHelpOpts(new string[]{helpAlias});
        }
        public static CommandLineBuilder UseDefaultsWithCustomHelpOpts(
            this CommandLineBuilder builder,
            string[] helpAliases)
        {
            return builder
                .UseVersionOption()
                .UseHelp(helpAliases)
                .UseEnvironmentVariableDirective()
                .UseParseDirective()
                .UseSuggestDirective()
                .RegisterWithDotnetSuggest()
                .UseTypoCorrections()
                .UseParseErrorReporting()
                .UseExceptionHandler()
                .CancelOnProcessTermination();
        }
         public static CommandLineBuilder UseDefaultsWithCustomVersionOpts(
            this CommandLineBuilder builder,
            string versionAlias)
        {
            return builder.UseDefaultsWithCustomVersionOpts(new string[]{versionAlias});
        }
        public static CommandLineBuilder UseDefaultsWithCustomVersionOpts(
            this CommandLineBuilder builder,
            string[] versionAliases)
        {
            return builder
                .UseVersionOption(versionAliases)
                .UseHelp()
                .UseEnvironmentVariableDirective()
                .UseParseDirective()
                .UseSuggestDirective()
                .RegisterWithDotnetSuggest()
                .UseTypoCorrections()
                .UseParseErrorReporting()
                .UseExceptionHandler()
                .CancelOnProcessTermination();
        }
    }
}
