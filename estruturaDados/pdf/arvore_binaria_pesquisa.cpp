#include <stdio.h>
#include <conio.h>
#include <malloc.h>

struct BSTNode *reserva(int el);
struct BSTNode *busca(struct BSTNode *p, int el);
void insere(struct BSTNode **raiz, int el);
void emordem(struct BSTNode *raiz);
void preordem(struct BSTNode *raiz);
void posordem(struct BSTNode *raiz);
void libera(struct BSTNode **p);

struct BSTNode
{
	int chave;
	struct BSTNode *esquerda;
	struct BSTNode *direita;
};


struct BSTNode *reserva(int el){
	struct BSTNode *t=NULL;
	t = (struct BSTNode *) malloc(sizeof(struct BSTNode));
	if(t!=NULL){
		t->chave = el;
		t->direita = NULL;
		t->esquerda = NULL;
	}
	return t;
}

struct BSTNode *busca(struct BSTNode *raiz, int el)
{
	struct BSTNode *p=raiz;
	while(p!=NULL)
	{
		if(el == p->chave) return p;
		else if(el<p->chave) p = p->esquerda;
		else p = p->direita;
	}
	return NULL;
}

void insere(struct BSTNode **raiz, int el)
{
	struct BSTNode *p=*raiz,*ant=NULL;
	if(busca(p,el)==NULL)
	{
		while(p!=NULL)
		{
		   ant=p;
		   if(el<p->chave) p=p->esquerda;
		   else p=p->direita;
		}
		if(*raiz==NULL) *raiz=reserva(el);
		else if(ant->chave<el) ant->direita = reserva(el);
		else ant->esquerda = reserva(el);
	}	
}

void emordem(struct BSTNode *raiz){
	struct BSTNode *p=raiz;
	if(p!=NULL){
		emordem(p->esquerda);
		printf("%i ", p->chave);
		emordem(p->direita);
	}
}

void preordem(struct BSTNode *raiz){
	struct BSTNode *p=raiz;
	if(p!=NULL){
		printf("%i ", p->chave);
		preordem(p->esquerda);
		preordem(p->direita);
	}
}

void posordem(struct BSTNode *raiz){
	struct BSTNode *p=raiz;
	if(p!=NULL){
		posordem(p->esquerda);
		posordem(p->direita);
		printf("%i ", p->chave);
	}
}

void libera(struct BSTNode **p){
	if(*p==NULL) {
		return;
	}else if((*p)->esquerda==NULL && (*p)->direita==NULL){
		printf("\n%i ", (*p)->chave);
		free(*p); 
		*p=NULL; 
		return;
	}else { 
		libera(&(*p)->esquerda);
		libera(&(*p)->direita);
		libera(p);
	}
}

int main(){
	struct BSTNode *raiz=NULL;
	insere(&raiz, 15);
	insere(&raiz, 12);
	insere(&raiz, 25);
	insere(&raiz, 7);
	insere(&raiz, 14);
	insere(&raiz, 31);
	insere(&raiz, 19);
	
	emordem(raiz); printf("\n");
	preordem(raiz); printf("\n");
	posordem(raiz); printf("\n");
	
	libera(&raiz);
	getch();
	return 0;
}

