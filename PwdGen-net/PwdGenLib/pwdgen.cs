using System;
using System.Collections.Generic;

namespace pwdgenlib
{
    [Flags]
    /// <summary> Режимы генерации </summary>
    public enum pwdgenModes
    {
        /// <summary> Заглавные русские буквы </summary>
        UpperRussian = 0x01,
        /// <summary> Заглавные английские буквы </summary>
        UpperEnglish = 0x02,
        /// <summary> Строчные русские буквы </summary>
        LowerRussian = 0x04,
        /// <summary> Строчные английские буквы </summary>
        LowerEnglish = 0x08,
        /// <summary> Цифры </summary>
        Numbers = 0x10,
        /// <summary> Символы </summary>
        Chars = 0x20,
    }

    public static class pwdgenModesExtension
    {
        public static void SetFlag(this ref pwdgenModes self, pwdgenModes flag) => self |= flag;

        public static void UnSetFlag(this ref pwdgenModes self, pwdgenModes flag) => self &= ~flag;

        public static void BoolFlag(this ref pwdgenModes self, pwdgenModes flag, bool isSet)
        {
            if (isSet) self.SetFlag(flag);
            else self.UnSetFlag(flag);
        }
    }

    /// <summary> Класс для генерации паролей </summary>
    public class pwdgen
    {
        const string russianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const string englishLetters = "abcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        const string chars = @"~!@#$%^&?*-=+_'`""";
        const string dots = @",.:;-=_+";
        const string brackets = @"(){}[]<>";
        const string slashes = @"/|\";

        Random rnd;
        List<string> vocabulary = new List<string>();

        pwdgenModes _mode;
        public pwdgenModes mode
        {
            get { return _mode; }
            set
            {
                if (0 == value) return;
                _mode = value;
                vocabulary.Clear();
                if (value.HasFlag(pwdgenModes.LowerRussian)) vocabulary.Add(russianLetters);
                if (value.HasFlag(pwdgenModes.UpperRussian)) vocabulary.Add(russianLetters.ToUpper());
                if (value.HasFlag(pwdgenModes.LowerEnglish)) vocabulary.Add(englishLetters);
                if (value.HasFlag(pwdgenModes.UpperEnglish)) vocabulary.Add(englishLetters.ToUpper());
                if (value.HasFlag(pwdgenModes.Numbers)) vocabulary.Add(numbers);
                if (value.HasFlag(pwdgenModes.Chars)) vocabulary.Add(chars + dots + brackets + slashes);
            }
        }

        /// <summary> Создать новый экземпляр генератора паролей </summary>
        /// <param name="mode">Режим генерирования (режим 0 устанавливает режим по умолчанию) 
        /// <see cref="pwdgen() ">смотри перегрузку без параметров</see></param>
        public pwdgen(pwdgenModes mode)
        {
            rnd = new Random();
            this.mode = mode != 0 ? mode
                                  : pwdgenModes.UpperEnglish
                                  | pwdgenModes.LowerEnglish
                                  | pwdgenModes.Numbers;
        }

        /// <summary> Создать новый экземпляр генератора паролей с режимом по умолчанию 
        /// (строчные и заглавные английские буквы вместе с цифрами)</summary>
        public pwdgen() : this(0) { }

        /// <summary> Генерировать пароль указанной длинны </summary>
        /// <param name="length">длинна пароля</param>
        /// <returns>пароль указанной длинны</returns>
        public string Generate(int length)
        {
            string pwd = "";
            for (int i = 0; i < length; i++)
            {
                var page = vocabulary[rnd.Next(vocabulary.Count)];
                pwd += page[rnd.Next(page.Length)];
            }
            return pwd;
        }
    }
}
