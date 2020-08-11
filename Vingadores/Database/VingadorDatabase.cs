using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vingadores.Database
{
    class VingadorDatabase
    {
        public void Inserir(tb_heroi heroi)
        {
            vingadoresEntities db = new vingadoresEntities();
            db.tb_heroi.Add(heroi);

            db.SaveChanges();
        }

        public List<tb_heroi> Listar(string heroi, string status)
        {
            vingadoresEntities db = new vingadoresEntities();

            if(status != "Todos" && status != string.Empty)
            {
                List<tb_heroi> herois = db.tb_heroi.Where(x => x.nm_heroi.Contains(heroi)
                                                        && x.ds_status == status)
                                                   .ToList();

                return herois;
            }
            else
            {
                List<tb_heroi> herois = db.tb_heroi.Where(x => x.nm_heroi.Contains(heroi))
                                                   .ToList();

                return herois;
            }
                
        }

        public void Deletar(int ID)
        {
            vingadoresEntities db = new vingadoresEntities();
            tb_heroi heroiRemover = db.tb_heroi
                                      .FirstOrDefault(x => x.id_heroi == ID);

            if(heroiRemover != null)
            {
                db.tb_heroi.Remove(heroiRemover);
                db.SaveChanges();
            }
        }

        public void Alterar(tb_heroi heroi)
        {
            vingadoresEntities db = new vingadoresEntities();
            tb_heroi heroiAlterar = db.tb_heroi
                                      .FirstOrDefault(x => x.id_heroi == heroi.id_heroi);

            if(heroiAlterar != null)
            {
                heroiAlterar.nm_heroi = heroi.nm_heroi;
                heroiAlterar.nm_nome = heroi.nm_nome;
                heroiAlterar.ds_sexo = heroi.ds_sexo;
                heroiAlterar.vl_forca = heroi.vl_forca;
                heroiAlterar.vl_poder = heroi.vl_poder;
                heroiAlterar.ds_status = heroi.ds_status;

                db.SaveChanges();
            }
        }
    }
}
