namespace Biblioteca
{
    public static class Bisiesto
        //Escribir un programa que determine si un año es bisiesto.
        //Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
        //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
    {
        public static bool IsBisiesto(int year) 
        {
            bool bisiesto = false;

            if (year % 4 == 0) 
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        bisiesto = true;        
                    }
                }
                else 
                { 
                    bisiesto = true;
                }
            }
            else 
            {
                bisiesto = false;
            }
            return bisiesto;
        }
    }
}