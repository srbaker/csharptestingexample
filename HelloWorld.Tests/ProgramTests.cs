using System;
using System.IO;
using NUnit.Framework;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Test]
        public void HelloWorld()
        {
            Assert.That(
                CapturingStdOut(() => Program.Main(new string[] {})),
                Is.EqualTo("Hello World!\n"));
        }

        [Test]
        public void GoodbyCruelWorld()
        {
            Assert.That(
                CapturingStdOut(() => Program.Main(new string[] {"-g"})),
                Is.EqualTo("Goodbye cruel world.\n"));
        }

        [Test]
        public void HelloName()
        {
            Assert.That(
                CapturingStdOut(() => Program.Main(new string[] { "foobar" })),
                Is.EqualTo("Hello, foobar!\n"));
        }

        private string CapturingStdOut(Action codeWithOutput)
        {
            var originalStdOut = Console.Out;

            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                try
                {
                    codeWithOutput();
                }
                finally
                {
                    Console.SetOut(originalStdOut);
                }

                return stringWriter.ToString();
            }
        }
    }
}