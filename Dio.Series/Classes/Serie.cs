using System;
namespace Dio.Series
{
    public class Serie: EntidadeBase
    {
        //atributos

        private Genero Genero{get; set;}

        private string Titulo{get; set;}

        private string Descricao{get; set;}

        private int Ano{get; set;}

        private bool Excluido {get; set;}
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero" + this.Genero + Environment.NewLine;
            retorno += "Titulo" + this.Titulo + Environment.NewLine;
            retorno += "Descricao" + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio" + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido ;
            
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo ;
        }
        public int retornaId()
        {
            return this.id;    
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}