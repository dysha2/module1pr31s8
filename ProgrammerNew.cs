using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s8
{
    public class ProgrammerNew:Programmer
    {
        private uint p;
        private uint qp;
        public uint Qp { get => qp; }
        public ProgrammerNew(string sname, uint lang, uint progs, uint p) : base(sname, lang, progs)
        {
            this.p = p;
        }
        public override void SetQ()
        {
            qp = languages*programs * p / programs;
        }
        public override string GetInfo()
        {
            return $"Фамилия: {surname}\nКоличество языков: {languages}\nКоличество прог: {programs}\nЧисло правильно написанных программ: {p}\nQp: {Qp}\n";
        }
    }
}
