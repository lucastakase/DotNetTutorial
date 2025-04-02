namespace MyTests;

public class WeatherCalculatorTests
{
[Theory]
[InlineData(2023, 3, 15, "Spring")]
[InlineData(2023, 4, 10, "Spring")]
[InlineData(2023, 5, 25, "Spring")]
[InlineData(2023, 6, 1, "Summer")]
[InlineData(2023, 7, 10, "Summer")]
[InlineData(2023, 8, 20, "Summer")]
[InlineData(2023, 9, 5, "Fall")]
[InlineData(2023, 10, 15, "Fall")]
[InlineData(2023, 11, 30, "Fall")]
[InlineData(2023, 12, 25, "Winter")]
[InlineData(2023, 1, 10, "Winter")]
[InlineData(2023, 2, 28, "Winter")]
public void DetermineSeason_ReturnsCorrectSeason(int year, int month, int day, string expectedSeason)
{
    // Arrange
    var date = new DateOnly(year, month, day);

    // Act
    var result = MyLibrary.WeatherCalculator.DetermineSeason(date);

    // Assert
    Assert.Equal(expectedSeason, result);
}
}