using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vingadores.Business
{
    class vingadorBusiness
    {
        public void Inserir(Database.tb_heroi heroi)
        {
            if (heroi.nm_heroi.Length >= 200)
                throw new ArgumentException("Limite de caracteres atingido!");

            if (heroi.nm_heroi == string.Empty)
                throw new ArgumentException("Campo vazio!");

            if (heroi.nm_nome.Length >= 200)
                throw new ArgumentException("Limite de caracteres atingido!");

            if (heroi.nm_nome == string.Empty)
                throw new ArgumentException("Campo vazio!");

            if (heroi.ds_sexo == string.Empty)
                throw new ArgumentException("Campo vazio!");

            if (heroi.vl_forca < 0)
                throw new ArgumentException("Valor inválido!");

            if (heroi.vl_forca > 10000000)
                throw new ArgumentException("Limite de valor atigindo!");

            if (heroi.vl_poder < 0)
                throw new ArgumentException("Valor inválido!");

            if (heroi.vl_poder > 10000000)
                throw new ArgumentException("Limite de valor atigindo!");

            if (heroi.ds_status == string.Empty)
                throw new ArgumentException("Campo vazio!");

            Database.VingadorDatabase db = new Database.VingadorDatabase();
            db.Inserir(heroi);
        }

        public List<Database.tb_heroi> Listar(string heroi, string status)
        {
            if (heroi.Length >= 200)
                throw new ArgumentException("Limite de caracteres atingido!");

            Database.VingadorDatabase db = new Database.VingadorDatabase();
            List<Database.tb_heroi> herois = db.Listar(heroi, status);

            return herois;
        }

        public void Deletar(int ID)
        {
            Database.VingadorDatabase db = new Database.VingadorDatabase();
            db.Deletar(ID);
        }

        public void Alterar(Database.tb_heroi heroi)
        {
            if (heroi.nm_heroi.Length >= 200)
                throw new ArgumentException("Limite de caracteres atingido!");

            if (heroi.nm_heroi == string.Empty)
                throw new ArgumentException("Campo vazio!");

            if (heroi.nm_nome.Length >= 200)
                throw new ArgumentException("Limite de caracteres atingido!");

            if (heroi.nm_nome == string.Empty)
                throw new ArgumentException("Campo vazio!");

            if (heroi.ds_sexo == string.Empty)
                throw new ArgumentException("Campo vazio!");

            if (heroi.vl_forca < 0)
                throw new ArgumentException("Valor inválido!");

            if (heroi.vl_forca > 10000000)
                throw new ArgumentException("Limite de valor atigindo!");

            if (heroi.vl_poder < 0)
                throw new ArgumentException("Valor inválido!");

            if (heroi.vl_poder > 10000000)
                throw new ArgumentException("Limite de valor atigindo!");

            if (heroi.ds_status == string.Empty)
                throw new ArgumentException("Campo vazio!");

            Database.VingadorDatabase db = new Database.VingadorDatabase();
            db.Alterar(heroi);
        }
    }
}
