using System;

namespace App1_CRUD
{
  public class Serie : EntidadeBase
  {
    // Atributos
    private Genero Genero { get; set; } //Genero é um Enum
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }

    private bool Ativo { get; set; }


    // Métodos
    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Ativo = true;
    }

    public override string ToString()
    {
      // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
      string retorno = "";
      retorno += "Gênero: " + this.Genero + Environment.NewLine;
      retorno += "Titulo: " + this.Titulo + Environment.NewLine;
      retorno += "Descrição: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
      retorno += "Ativo: " + this.Ativo;
      return retorno;
    }

    // Métodos encapsulamento
    public string retornaTitulo()
    {
      return this.Titulo;
    }
    public int retornaId()
    {
      return this.Id;
    }
    public bool retornaAtivo()
    {
      return this.Ativo;
    }
    public void Excluir()
    {
      this.Ativo = false;
    }
  }
}