namespace MyApp.Tests;

public class ProgramTests
{
    [Fact]
    public void Main_prints_hello_world()
    {
	// Arrange
	using var stringWriter = new StringWriter();
	Console.SetOut(stringWriter);

	// Act
	var program = Assembly.Load(nameof(MyApp));
	program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

	// Assert
	var output = stringWriter.GetStringBuilder().ToString().TrimEnd();
	output.Should().Be("Hello, World!");
    }
}
