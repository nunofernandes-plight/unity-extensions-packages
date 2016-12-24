namespace AndrewLord.ExtensionsPackages.UnityRandomValue {

  using System;

  /// <summary>
  /// Generate a random number between a specified minimum and maximum, without needing to specify these limits each
  /// time. Creators of this class can define a default minimum and maximum, so that these don't always need to be
  /// specified.
  /// </summary>
  public abstract class RandomNumber<TValue> {

    protected TValue minimum;
    protected TValue maximum;
    protected Random generator;

    /// <summary>
    /// Create a random number generator using the specified Random class. By passing this in it allows you to
    /// customise how your numbers are generated.
    /// </summary>
    /// <param name="generator">A random number generator.</param>
    public RandomNumber(Random generator) {
      this.generator = generator;
    }

    /// <summary>
    /// Specify a minimum value for the generated number.
    /// </summary>
    /// <param name="minimum">The minimum value.</param>
    /// <returns>Self, to allow for chained calls.</returns>
    public RandomNumber<TValue> Minimum(TValue minimum) {
      this.minimum = minimum;
      return this;
    }

    /// <summary>
    /// Specify a maximum value for the generated number.
    /// </summary>
    /// <param name="maximum">The maximum value.</param>
    /// <returns>Self, to allow chained calls.</returns>
    public RandomNumber<TValue> Maximum(TValue maximum) {
      this.maximum = maximum;
      return this;
    }

    /// <summary>
    /// Get a random number within the specified range.
    /// </summary>
    /// <returns>The random number.</returns>
    public abstract TValue Get();
  }
}
