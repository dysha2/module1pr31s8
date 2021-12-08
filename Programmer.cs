using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s8
{
    public class Programmer
    {
        private protected string surname;
        private protected uint languages;
        private protected uint programs;
        private uint q;
        public Programmer(string sname, uint lang,uint progs)
        {
            this.surname = sname;
            this.languages = lang;
            this.programs = progs;
        }
        public virtual void SetQ() => q = languages * programs;
        public uint Q
        {
            get => q;
        }
        public virtual string GetInfo()
        {
            return $"Фамилия: {surname}\nКоличество языков: {languages}\nКоличество прог: {programs}\nQ: {Q}\n";
        }
    }
}
