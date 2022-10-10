using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC.Models;

namespace WebMVC.Servicos
{
    public class AnimalServico
    {
        private AnimalServico() { }

        private static AnimalServico animalServico;

        public static AnimalServico Instancia()
        {
            if (animalServico == null) animalServico = new AnimalServico();
            return animalServico;
        }

        private List<Animal> animais = new List<Animal>();

        public void Add(Animal animal)
        {
            this.animais.Add(animal);
        }

        public List<Animal> Todos()
        {
            return this.animais;
        }

        public void Remover(Animal animal)
        {
            var animalLista = this.animais.Find(a => a.Nome == animal.Nome);
            if (animalLista != null)
                this.animais.Remove(animalLista);
        }

        public void Alterar(string novoNome, Animal animal)
        {
            this.Remover(animal);
            animal.Nome = novoNome;
            this.animais.Add(animal);
        }

    }
}