// Lo siguiente a;ade la referencia  al archivo de TestProject1.
//dotnet add TestProject1\TestProject1.csproj reference ConsoleApp1\ConsoleApp1.csproj
// a;adir new console: dotnet new console -- framework net8.0 --use-program-main


using ConsoleApp1;

namespace TestProject1;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Suma_5_3_y_da_8()
    {
        Calculadora calculadora= new Calculadora();
        var numero1=5;
        var numero2=3;
        var resultadoEsperado=8;
        var resultadoEsperadoDivision=0;

        var resultado= calculadora.Suma(numero1,numero2);

        Assert.AreEqual(resultadoEsperado,resultado);
    }

 [TestMethod]
    public void Suma_2_2_y_da_4()
    {
        Calculadora calculadora= new Calculadora();
        var numero1=2;
        var numero2=2;
        var resultadoEsperado=4;
        var resultadoEsperadoDivision=0;

        var resultado= calculadora.Suma(numero1,numero2);

        Assert.AreEqual(resultadoEsperado,resultado);
    }

 [TestMethod]
    public void Suma_menos2_menos2_y_da_menos4()
    {
        Calculadora calculadora= new Calculadora();
        var numero1=-2;
        var numero2=-2;
        var resultadoEsperado=-4;
        var resultadoEsperadoDivision=-8;

        var resultado= calculadora.Suma(numero1,numero2);

        Assert.AreEqual(resultadoEsperado,resultado);
    }

 [TestMethod]
    public void Resta_2_2_y_da_0()
    {
        Calculadora calculadora= new Calculadora();
        var numero1=2;
        var numero2=2;
        var resultadoEsperado=0;
        var resultadoEsperadoDivision=-8;

        var resultado= calculadora.Resta(numero1,numero2);

        Assert.AreEqual(resultadoEsperado,resultado);
    }
    
 [TestMethod]
    public void Multilpicacion_2_2_y_da_4()
    {
        Calculadora calculadora= new Calculadora();
        var numero1=2;
        var numero2=2;
        var resultadoEsperado=4;
        var resultadoEsperadoDivision=-8;

        var resultado= calculadora.Multiplicacion(numero1,numero2);

        Assert.AreEqual(resultadoEsperado,resultado);
    }
    
 [TestMethod]
    public void Division_4entre2()
    {
        Calculadora calculadora= new Calculadora();
        var numero1=4;
        var numero2=2;
        var resultadoEsperado=2;
        var resultadoEsperadoDivision=-8;

        var resultado= calculadora.Division(numero1,numero2);

        Assert.AreEqual(resultadoEsperado,resultado);
    }
    
     [TestMethod]
    public void Division_4entre0_daNULL()
    {
        Calculadora calculadora= new Calculadora();
        var numero1=4;
        var numero2=0;
        int? resultadoEsperado=null;
        var resultadoEsperadoDivision=-8;

        var resultado= calculadora.Division(numero1,numero2);

        Assert.AreEqual(resultadoEsperado,resultado);
    }
    
      [TestMethod]
    public void Suma2_m3nos2_division_por_cero_meda_()
    {
        Calculadora calculadora= new Calculadora();
        var sumando1=2;
        var sumando2=2;
        var numero1=4;
        var numero2=0;
        int? resultadoEsperado=null;
        var resultadoEsperadoDivision=-8;

        var suma= calculadora.Suma(sumando1,sumando2);
        var division= calculadora.Division(numero1,numero2);

        var resultado= suma-division;

        Assert.AreEqual(resultadoEsperado,resultado);
    }
    



}