using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D_EA;
using E_EA;

namespace N_EA
{
    public class N_Agenda
    {
       
        public List<E_Agenda> ListarAgenda(string buscar)
        {
            D_Agenda ObjDato = new D_Agenda();
            return ObjDato.ListarAgenda(buscar);
        }

        public void InsertAppl(E_Agenda _Agenda)
        {
            D_Agenda ObjDato = new D_Agenda();
            ObjDato.insertA(_Agenda);
        }

        public void UpdateAppl(E_Agenda _Agenda)
        {
            D_Agenda ObjDato = new D_Agenda();
            ObjDato.updateA(_Agenda);
        }

        public void DeleteAppl(E_Agenda _Agenda)
        {
            D_Agenda ObjDato = new D_Agenda();
            ObjDato.deleteA(_Agenda);

        }

        public void Showlist()
        {
            D_Agenda ObjDato = new D_Agenda();
            ObjDato.Showlist();
        }

    }
}
