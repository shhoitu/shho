namespace MyApp.Tests;

public class CalendarTests {
	[Fact]
	public void IsLeapYear_given_2022_returns_false() {
		// Arrange
		var sut = new Calendar();
		
		// Act
		var result = sut.IsLeapYear(2022);

		// Assert
		result.Should().Be(false);
	}
	
	[Fact]
	public void IsLeapYear_given_1000_returns_false() {
		// Arrange
		var sut = new Calendar();

		// Act
		var result = sut.IsLeapYear(1000);

		// Assert
		result.Should().Be(false);
	}

	[Fact]
	public void IsLeapYear_given_1600_returns_true() {
		// Arrange
		var sut = new Calendar();

		// Act
		var result = sut.IsLeapYear(1600);

		// Assert
		result.Should().Be(true);
	}

	[Fact]
	public void IsLeapYear_given_2004_returns_true() {
		// Arrange
		var sut = new Calendar();

		// Act
		var result = sut.IsLeapYear(1600);

		// Assert
		result.Should().Be(true);
	}
}

