using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasClasses
{
    public class Livro
    {
        //atributo
        private string isbn;
        private string titulo;
        private GeneroLivro genero;
        private DateTime dataPublicacao;
        private Editora editora;
        //validar string generico
        private bool validarStringGen(string s)
        {
            return !String.IsNullOrEmpty(s) || !String.IsNullOrWhiteSpace(s);
        }
        //Construtores
        public Livro(string isb,string titulo,GeneroLivro gen,DateTime datapub,Editora edit)
        {
            isbn = isb;
            this.titulo = titulo;
            genero = gen;
            dataPublicacao = datapub;
            editora = edit;
        }
        //Gets & sets
        public string getIsbn()
        {
            return isbn;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public GeneroLivro getGenero()
        {
            return genero;
        }
        public DateTime getDataPub()
        {
            return dataPublicacao;
        }
        public Editora getEditora()
        {
            return editora;
        }
        //Metodos
        public string ImprimeDados()
        {
            return string.Format("ISBN: {0}" +
                               "\nTitulo: {1}" +
                               "\nGenero: {2}" +
                               "\nData Publicação: {3}" +
                               "\nEditora: {4}", isbn, titulo, 
                               genero.ImprimeDados(),
                               dataPublicacao.ToShortDateString(),
                               editora.ImprimeDados());
        }
    }
}
