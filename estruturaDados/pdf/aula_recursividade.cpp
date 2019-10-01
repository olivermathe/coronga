#include <stdio.h>
#include <conio.h>
#include <malloc.h>

void insere_direita(int valor);
void mostra_lista();

struct nodo {
	int dados;
	struct nodo *prox;
	struct nodo *ant;
};
struct nodo *aux, *inicio=NULL, *fim=NULL;

struct header {
int qtde;
struct nodo *inicio;
struct nodo *fim;
};

struct header *lista;

void insere_direita(int valor){
aux = (struct nodo *) malloc (sizeof(struct nodo));
if(aux != NULL){
	aux->dados = valor;
	aux->prox = NULL;
	aux->ant = lista->fim;
	if(lista->inicio==NULL) lista->inicio=aux;
	else lista->fim->prox = aux;
	lista->fim = aux; 
	lista->qtde++;
}
}

void mostra_lista(){
aux = lista->inicio;
while(aux!=NULL){
	printf("%i ", aux->dados);
	aux=aux->prox;
}
printf("\n");
}

int main(){
	int valor;
	float soma=0;

lista = (struct header *) malloc (sizeof(struct header));
if(lista != NULL)
{
  lista->qtde=0;
  lista->inicio=NULL;
  lista->fim=NULL;
}
else return 1;

printf("Digite um valor ou zero: ");
scanf("%i", &valor); fflush(stdin);

while(valor!=0){
	
insere_direita(valor);

printf("Digite um valor ou zero: ");
scanf("%i", &valor); fflush(stdin);
}
	
mostra_lista();	

aux = lista->inicio;
while(aux!=NULL){
	soma = soma +aux->dados;
	aux=aux->prox;
}
soma = soma/lista->qtde;

insere_direita(soma);

mostra_lista();	

	getch();
	return 0;
}
