public class MathHelper
{
    /// <summary>
    /// Вычисляет сумму двух целых чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма двух чисел.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Вычисляет разность двух целых чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Разность двух чисел.</returns>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Вычисляет произведение двух целых чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Произведение двух чисел.</returns>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Вычисляет частное двух целых чисел.
    /// </summary>
    /// <param name="a">Делимое.</param>
    /// <param name="b">Делитель.</param>
    /// <returns>Частное двух чисел.</returns>
    /// <exception cref="DivideByZeroException">Выбрасывается, если b равно 0.</exception>
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль недопустимо.");
        }
        return a / b;
    }


    /// <summary>
    /// Возводит число в степень.
    /// </summary>
    /// <param name="baseNumber">Основание степени.</param>
    /// <param name="exponent">Показатель степени.</param>
    /// <returns>Результат возведения в степень.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Если показатель степени меньше 0.</exception>
    public double Power(double baseNumber, int exponent)
    {
        if (exponent < 0)
        {
            throw new ArgumentOutOfRangeException("Показатель степени должен быть неотрицательным.");
        }
        return Math.Pow(baseNumber, exponent);
    }
}