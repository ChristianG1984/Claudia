using NUnit.Framework;

namespace Claudia.Lib.Default.Test
{
    [TestFixture]
    public class SourceUnitTest
    {
        [Test]
        public void InterpretsPositiveDefineMacroCorrectly()
        {
            Interface.SourceUnit su =
                new SourceUnit(
                    "#ifdef THE_ANSWER\n" +
                    "int the_answer_is = 42;\n" +
                    "#endif\n",
                    "-D THE_ANSWER"
                );
            Assert.That(
                su.PreprocessorResult(),
                Is.EqualTo("int the_answer_is = 42;\n\n")
            );
        }
    }
}
