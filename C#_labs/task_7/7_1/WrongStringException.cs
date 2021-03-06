﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WrongStringExeption: Exception
    {
        public WrongStringExeption(string enteredValue)
        : base($"\nНеверный формат введенной строки! \n {enteredValue}")
        {
            EnteredValue = enteredValue;
        }

        // расширяем базовый класс новым свойством.
        public string EnteredValue { get; } // Синтаксис C# 6 - readonly свойство
    }
}
