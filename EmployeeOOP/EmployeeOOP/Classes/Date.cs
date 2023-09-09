using System.ComponentModel.Design;

namespace EmployeeOOP.Classes
{
    public class Date
    {


        private int _year;
        private int _month;
        private int _day;

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = ValidateMonth(month);
            _year = year;
        }

        private static int ValidateMonth(int month)
        {
          if (month <= 1 && month >= 12 )
            {
                return month;
            }
          else
            {
                 throw new (string.Format("el mes no es valido {0}", month));
            }

        }

        public override string ToString()
        {
            return @$"{_day:00}/{_month:00}/{_year:0000}";

        }

    }
}
