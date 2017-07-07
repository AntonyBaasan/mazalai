using System;
using Xunit;

namespace LogAn.UnitTests
{
  public class LogAnalyzerTests
  {
    [Theory]
    [InlineData("a.fab", false)]
    [InlineData("a.slf", true)]
    [InlineData("a.SLF", true)]
    public void IsValidFileName_VariousExtension_Check(string fileName, bool expected)
    {
      var analyzer = new LogAnalyzer();

      bool result = analyzer.IsValidLogFileName(fileName);

      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void IsValidFileName_EmptyFileName_ThrowArgumentException(string fileName)
    {
      var analyzer = new LogAnalyzer();

      Assert.Throws<ArgumentException>(()=>analyzer.IsValidLogFileName(fileName));
    }

    [Theory]
    [InlineData("a.foo", false)]
    [InlineData("a.slf", true)]
    public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string fileName, bool expected)
    {
      var analyzer = new LogAnalyzer();

      analyzer.IsValidLogFileName(fileName);

      Assert.Equal(expected, analyzer.WasLastFileNameValid);
    }

  }
}