using System;
using Xunit;

namespace LogAn.UnitTests
{
    public class LogAnalyzerTests
    {
        [Fact]
        public void IsValidFileName_BadExtension_ReturnFalse()
        {
          var analyzer = new LogAnalyzer();
          
          bool result = analyzer.IsValidLogFileName("fileWithBadExtension.fab");

          Assert.False(result);
        } 
    }
}