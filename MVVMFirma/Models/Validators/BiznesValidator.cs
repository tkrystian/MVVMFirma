using System;

namespace MVVMFirma.Models.Validators
{
    public class BiznesValidator : Validator
    {
        public static string SprawdzDate(DateTime data)
        {
            if (data < DateTime.Now.Date)
            {
                return "Wybrano nieprawidłową datę";
            }
            return null;
        }

        public static string SprawdzCzyDodatniaLiczba(decimal liczba)
        {
            if (liczba < 0)
            {
                return "Wybrano nieprawidłową wartość";
            }
            return null;
        }

        public static string SprawdzNumerTelefonu(int numer)
        {
            if (numer < 0 || numer.ToString().Length != 9)
            {
                return "Wprowadzono niepoprawny numer";
            }
            return null;
        }
    }
}
