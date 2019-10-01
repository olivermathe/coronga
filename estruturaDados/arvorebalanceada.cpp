#include <stdio.h>
#include <conio.h>
#include <malloc.h>

struct nodo *crianodo(int el);
int altura(struct nodo *raiz);
int maximo(int a1, int a2);
int getfator(struct nodo *raiz);
struct nodo *rotacaodireita(struct nodo *k2);
struct nodo *rotacaoesquerda(struct nodo *k1);
struct nodo *rotacaodupladireita(struct nodo *k3);
struct nodo *rotacaoduplaesquerda(struct nodo *k1);
struct nodo *insere (struct nodo *raiz, int el);
void emordem(struct nodo *raiz);
void libera(struct nodo **p);

struct nodo{
	int alt;
	int chave;
	struct nodo *esquerda, *direita;
};

struct nodo *crianodo(int el) {
		struct nodo *p=NULL;
		p=(struct nodo *) malloc(sizeof(struct nodo));
		if (p!=NULL){
			p->alt=0;
			p->chave=el;
			p->esquerda = NULL;
			p->direita = NULL;
		}
		return p;
}

int altura(struct nodo *raiz){
	if(raiz==NULL) return 0;
	else return raiz->alt;
}

int maximo(int a1, int a2){
	if(a1>a2) return a1;
	else return a2;
}

int getfator(struct nodo *raiz){
	struct nodo *p=raiz;
	if(p!=NULL)
	return altura(p->esquerda) - altura(p->direita);
	else return 0;
}
	
struct nodo *rotacaodireita(struct nodo *k2){
	struct nodo *k1 = k2->esquerda;
	k2->esquerda = k1->direita;
	k1->direita = k2;
	k2->alt = maximo(altura(k2->esquerda),altura(k2->direita))+1;
	k1->alt = maximo(altura(k1->esquerda), k2->alt)+1;
	return k1;
}	
	
struct nodo *rotacaoesquerda(struct nodo *k1){
	struct nodo *k2 = k1->direita;
	k1->direita = k2->esquerda;
	k2->esquerda = k1;
	k1->alt = maximo(altura(k1->esquerda),altura(k1->direita))+1;
	k2->alt = maximo(altura(k2->direita), k1->alt)+1;
	return k2;
}	

struct nodo *rotacaodupladireita(struct nodo *k3){
	struct nodo *k1 = k3->esquerda;
	k3->esquerda = rotacaoesquerda(k1);
    return rotacaodireita(k3);
}		

struct nodo *rotacaoduplaesquerda(struct nodo *k1){
	struct nodo *k3 = k1->direita;
	k1->direita = rotacaodireita(k3);
    return rotacaoesquerda(k1);
}	

struct nodo *insere (struct nodo *raiz, int el){
	struct nodo *p=raiz;
	if (raiz == NULL) p=crianodo(el);
	else if(el<p->chave)  p->esquerda = insere(p->esquerda,el);
	else if(el>p->chave)  p->direita = insere(p->direita, el);
	
	if(getfator(p)==2){  //fator externo fora do limite e positivo
		if(getfator(p->esquerda)>0) p=rotacaodireita(p);
		else p= rotacaodupladireita(p);
	} else
	if(getfator(p)==-2){  //fator externo fora do limite e negativo
		if(getfator(p->direita)<0) p=rotacaoesquerda(p);
		else p= rotacaoduplaesquerda(p);
	}
	p->alt = maximo(altura(p->esquerda), altura(p->direita))+1;
	return p;
}

void emordem(struct nodo *raiz){
	struct nodo *p=raiz;
	if(p!=NULL){
		emordem(p->esquerda);
		printf("%i ", p->chave);
		emordem(p->direita);
	}
}

void libera(struct nodo **p){
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
	struct nodo *r=NULL;
	r=insere(r,10);
	r=insere(r,15);
	r=insere(r,13);
	r=insere(r,7);
	r=insere(r,6);
	r=insere(r,18);
	r=insere(r,17);
	emordem(r);
	libera(&r);
	return 0;
}
