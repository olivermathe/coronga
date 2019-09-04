using System;
using System.Collections.Generic;
namespace AppTarefa.Models
{
    public class TarefasRepository
    {
        public static List<Tarefa> tarefas = new List<Tarefa>();//obj que implementa uma lista de person
        public TarefasRepository() //construtor vazio pra usar mais adiante
        {
        }
        public void Create(Tarefa tarefa)  //metodo para criar pessoas
        {
            tarefas.Add(tarefa);
        }
        public List<Tarefa> GetAll()     //metodo para retornar toda a lista de todas pessoas cadastradas
        {
            return tarefas;
        }
        public Tarefa GetById(int id)           //procurar as pessoas por id na lista 
        {
            return tarefas.Find(x=>x.id == id);
        }
        public Tarefa GeyById(int id)           //pega um id  e compara com o id da arrow funcion e depois retorna o obj conforme o id que foi passado
        {
            return tarefas.Find(x=>x.id == id);  //percorre o id,e depois retornar para o return e jogar lá para a controller
        }
        internal void Edit(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)          //deletar da lista por id (nao passa o obj, só busca ele pelo id)
        {
            tarefas.Remove(GetById(id));   //metodo remover do array list do c# (precisa invocar o getbyid lá do controler)
        }
        public void Update(Tarefa tarefa)
        {
            var index = tarefas.FindIndex(x=>x.id==tarefa.id);
            tarefas[index].name=tarefa.name;
            tarefas[index].dataLimite=tarefa.dataLimite;
        }
    }
}