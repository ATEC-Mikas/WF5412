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
        private string _isbn;
        private string _titulo;
        private GeneroLivro _genero;
        private DateTime _dataPublicacao;
        private Editora _editora;
        //validar string generico
        private bool validarStringGen(string s)
        {
            return !String.IsNullOrEmpty(s) || !String.IsNullOrWhiteSpace(s);
        }
        //Construtores
        public Livro(string isb,string titulo,GeneroLivro gen,DateTime datapub,Editora edit)
        {
            _isbn = isb;
            _titulo = titulo;
            _genero = gen;
            _dataPublicacao = datapub;
            _editora = edit;
        }

        public string Isbn
        {
            get { return _isbn; }
        }
        public string Titulo
        {
            get { return _titulo; }
        }
        public GeneroLivro Genero
        {
            get { return _genero; }
        }
        public DateTime DataPublicacao
        {
            get { return _dataPublicacao; }
        }
        public Editora Editora
        {
            get { return _editora; }
        }

        //Metodos
        public string ImprimeDados()
        {
            return string.Format("ISBN: {0}" +
                               "\nTitulo: {1}" +
                               "\nGenero: {2}" +
                               "\nData Publicação: {3}" +
                               "\nEditora: {4}", Isbn, Titulo, 
                               Genero.ImprimeDados(),
                               DataPublicacao.ToShortDateString(),
                               Editora.ImprimeDados());
        }
    }
}
