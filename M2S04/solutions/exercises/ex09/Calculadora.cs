namespace Exercise09;

public static class Calculadora
{
    public const Decimal Pi = 3.14159265359m;

    public static Decimal Somar(Decimal num1, Decimal num2) {

      return num1 + num2;
    }

    public static Decimal Subtrair(Decimal num1, Decimal num2) {

      return num1 - num2;
    }

    public static Decimal Multiplicar(Decimal num1, Decimal num2) {

      return num1 * num2;
    }

    public static Decimal Dividir(Decimal num1, Decimal num2) {

      if (num2 == 0) {
        return 0;
      }

      return num1 / num2;
    }

}
