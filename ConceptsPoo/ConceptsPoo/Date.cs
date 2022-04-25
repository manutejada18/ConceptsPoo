using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPoo
{

    /////////////////Clase Date.cs
    public class Date
    {
        //"This" para asignar valores a los atributos de la clase ej. this.year
        private int _year;
        private int _month;
        private int _day;

        //Contructor de la clase Date
        public Date(int year, int month, int day)//Parametros del constructor
        {
            _year = year;
            _month = CheckMonth(month);//Mandamos el mes para que no pase de 12
            _day = CheckDay(year, month, day);//Mandamos los 3 parametros por años biciestos
        }

        //Generar el metodo para validar el dia  
        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year)) 
            {
                return day;
            }
            //Arreglo para organizar los dias por meses
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Invalid Day"); //Creamos la excepcion para el Dia
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0; 
            //if(year % 4 == 0)             
            //{
            //    if ((year % 100) == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }    
            //}
            //else 
            //{
            //    return false;            
            //}
        }


        //Generar el metodo para validar el mes
        private int CheckMonth(int month)
        {
            if (month >= 1 && month<=12)
            {
                return month;
            }
            //Arrojamos la excepcion del error en base al metodo Checkmonth
            throw new MonthException("Invalid Month"); //Creamos la excepcion para el Mes
        }

        //Usar metodo para sobreescribir fecha string a formato fecha
        public override string ToString()
        {
            //return _year+"/"+_month+"/"+_day; //Forma no recomendada
            //Interpolacion de strings Poniendo el signo de "$"
            return $"{_year}/{_month:00}/{_day:00}";
        }

    }
    /////////////////////////////////////////////
}
