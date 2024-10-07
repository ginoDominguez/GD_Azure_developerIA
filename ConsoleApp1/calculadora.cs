//Mi primer full request


namespace ConsoleApp1;
public class Calculadora
{
    public int Suma(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
      public int Resta(int numero1, int numero2)
    {
        return numero1 - numero2;
        //return 20;
    }
  public int Multiplicacion(int numero1, int numero2)
    {
        return numero1 * numero2;
    }
    public int?  Division(int dividendo, int divisor)
    {
        if(divisor==0)
        {
            return null;

        }
        else{
            return dividendo / divisor;
        
        }
        /*
        try{
            return numero1 / numero2;
        }
        catch(Exception e)
        {
            return 0;
        }
        */
    }


}