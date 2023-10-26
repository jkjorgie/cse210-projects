class Fraction 
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        this._numerator = 1;
        this._denominator = 1;
    }

    public Fraction(int numerator)
    {
        this._numerator = numerator;
        this._denominator = 1;
    }

    public Fraction(int numerator, int denominator) {
        this._numerator = numerator;
        this._denominator = denominator;
    }

    public int GetNumerator()
    {
        return this._numerator;
    }

    public void SetNumerator(int numerator)
    {
        this._numerator = numerator;
    }

    public int GetDenominator()
    {
        return this._denominator;
    }

    public void SetDenominator(int denominator)
    {
        this._denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{this._numerator}/{this._denominator}";
    }

    public double GetDoubleValue()
    {
        return (double)this._numerator / this._denominator;
    }
}