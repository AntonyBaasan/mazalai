using System;

public class LogAnalyzer
{
  public bool WasLastFileNameValid { get; set; }
  public bool IsValidLogFileName(string fileName)
  {
    WasLastFileNameValid = false;

    if (String.IsNullOrEmpty(fileName))
      throw new ArgumentException("fileName has to be provided.");

    if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
    {
      return false;
    }

    WasLastFileNameValid = true;
    return true;
  }
}