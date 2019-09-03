using System;
using System.Collections.Generic;
namespace AppPeople.Models
{
    public class PersonRepository
    {
        public static List<Person> people = new List<Person>();//obj que implementa uma lista de person
        public PersonRepository() //construtor vazio pra usar mais adiante
        {
            
        }
        public void Create(Person person)  //metodo para criar pessoas
        {
            people.Add(person);
        }
        public List<Person> GetAll()     //metodo para retornar toda a lista de todas pessoas cadastradas
        {
            return people;
        }
        public Person GetById(int id)           //procurar as pessoas por id na lista 
        {
            return people.Find(x=>x.id == id);
        }
        public Person GeyById(int id)           //pega um id  e compara com o id da arrow funcion e depois retorna o obj conforme o id que foi passado
        {
            return people.Find(x=>x.id == id);  //percorre o id,e depois retornar para o return e jogar lá para a controller
        }
        internal void Edit(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)          //deletar da lista por id (nao passa o obj, só busca ele pelo id)
        {
            people.Remove(GetById(id));   //metodo remover do array list do c# (precisa invocar o getbyid lá do controler)
        }
        public void Update(Person person)
        {
            var index = people.FindIndex(x=>x.id==person.id);
            people[index].name=person.name;
            people[index].address=person.address;
        }
    }
}