namespace AndrewLord.ExtensionsPackages.UnityRandomValue {

  using System;

  /// <summary>
  /// Create random number generators for different types. Each creator specifies defaults which match the Random 
  /// class.
  /// </summary>
  public class RandomValue {

    private static Random generator = new Random();

    /// <summary>
    /// Create an integer random number generator. The random numbers are seeded using the time.
    /// </summary>
    /// <returns>An integer random number generator.</returns>
    public static RandomNumber<int> CreateInteger() {
      return new RandomIntegerNumber(generator)
        .Minimum(0)
        .Maximum(int.MaxValue);
    }

    /// <summary>
    /// Create an integer random number generator using the provided Random class. This allows you to choose the 
    /// seed value.
    /// </summary>
    /// <param name="generator">Random number generator.</param>
    /// <returns>An integer random number generator.</returns>
    public static RandomNumber<int> CreateInteger(Random generator) {
      return new RandomIntegerNumber(generator)
        .Minimum(0)
        .Maximum(int.MaxValue);
    }

    /// <summary>
    /// Create a float random number generator. The random numbers are seeded using the time.
    /// </summary>
    /// <returns>A float random number generator.</returns>
    public static RandomNumber<float> CreateFloat() {
      return new RandomFloatNumber(generator)
        .Minimum(0f)
        .Maximum(1f);
    }

    /// <summary>
    /// Create a float random number generator using the provided Random class. This allows you to choose the 
    /// seed value.
    /// </summary>
    /// <param name="generator">Random number generator.</param>
    /// <returns>A float random number generator.</returns>
    public static RandomNumber<float> CreateFloat(Random generator) {
      return new RandomFloatNumber(generator)
        .Minimum(0f)
        .Maximum(1f);
    }

    /// <summary>
    /// Create a double random number generator. The random numbers are seeded using the time.
    /// </summary>
    /// <returns>A double random number generator.</returns>
    public static RandomNumber<double> CreateDouble() {
      return new RandomDoubleNumber(generator)
        .Minimum(0)
        .Maximum(1);
    }

    /// <summary>
    /// Create a double random number generator using the provided Random class. This allows you to choose the 
    /// seed value.
    /// </summary>
    /// <param name="generator">Random number generator.</param>
    /// <returns>A double random number generator.</returns>
    public static RandomNumber<double> CreateDouble(Random generator) {
      return new RandomDoubleNumber(generator)
        .Minimum(0)
        .Maximum(1);
    }

    class RandomIntegerNumber : RandomNumber<int> {
      public RandomIntegerNumber(Random generator) : base(generator) {
      }
    
      public override int Get() {
        return generator.Next(minimum, maximum);
      }
    }

    class RandomFloatNumber : RandomNumber<float> {
      public RandomFloatNumber(Random generator) : base(generator) {
      }

      public override float Get() {
        float randomDouble = (float) generator.NextDouble();
        return minimum + (randomDouble * (maximum - minimum));
      }
    }

    class RandomDoubleNumber : RandomNumber<double> {
      public RandomDoubleNumber(Random generator) : base(generator) {
      }

      public override double Get() {
        double randomDouble = generator.NextDouble();
        return minimum + (randomDouble * (maximum - minimum));
      }
    }
  }
}