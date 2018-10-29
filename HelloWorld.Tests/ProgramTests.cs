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
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                Program.Main(new string[] {});
                Assert.That(stringWriter.ToString(), Is.EqualTo("Hello World!\n"));
            }
        }

        [Test]
        public void GoodbyCruelWorld()
        {
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                Program.Main(new string[] {"-g"});
                Assert.That(stringWriter.ToString(), Is.EqualTo("Goodbye cruel world.\n"));
            }
        }
    }
}