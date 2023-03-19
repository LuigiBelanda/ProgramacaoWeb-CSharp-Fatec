using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Classes
{
    public class Cliente
    {
        // ======================
        // Atributos
        // ======================
        private int Id;
        public string Nome;
        public string Telefone;
        private Endereco Endereco;

        // ======================
        // Construtor
        // ======================
        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        // ======================
        // Métodos Get
        // ======================
        public Endereco getEndereco()
        {
            return Endereco;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        // ======================
        // Métodos Set
        // ======================
        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}