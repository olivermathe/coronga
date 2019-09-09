//aldrin jr e antonio lago
#include <stdio.h>
#include <malloc.h>
struct BSTNode *reserva(int el);
struct BSTNode *busca(struct BSTNode *p, int el);
void insere(struct BSTNode **raiz, int el);
void emordem(struct BSTNode *raiz);
void preordem(struct BSTNode *raiz);
void posordem(struct BSTNode *raiz);
//crie uma função que conte os elementos de uma arvore binaria de pesquisa
void contador(int cont, struct BSTNode *raiz);
void libera(struct BSTNode **p);
void remove(int el, struct BSTNode *raiz);

struct BSTNode *buscapai(int el, struct BSTNode *raiz);
struct BSTNode
{
	int chave;
	struct BSTNode *esquerda;
	struct BSTNode *direita;
};

struct BSTNode *reserva(int el)
{
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

void emordem(struct BSTNode *raiz)
{
	struct BSTNode *p=raiz;
	if(p!=NULL){
		emordem(p->esquerda);
		printf("%i ", p->chave);
		emordem(p->direita);
	}
}

void preordem(struct BSTNode *raiz)
{
	struct BSTNode *p=raiz;
	if(p!=NULL){
		printf("%i ", p->chave);
		preordem(p->esquerda);
		preordem(p->direita);
	}
}

void posordem(struct BSTNode *raiz)
{
	struct BSTNode *p=raiz;
	if(p!=NULL){
		posordem(p->esquerda);
		posordem(p->direita);
		printf("%i ", p->chave);
	}
}

int contador(struct BSTNode *raiz) 
{
  if(raiz == NULL)        
    return 0; 
  if(raiz->esquerda == NULL && esquerda->direita==NULL)       
    return 1;             
  else 
    return contador(raiz->esquerda) + contador(raiz->direita);       
} 

void libera(struct BSTNode **p)
{
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

struct BSTNode *buscapai(int el, struct BSTNode *raiz)
{
	struct BSTNode *p=raiz, *prev=NULL;
	while(p!=NULL && p->chave!=el){
		prev = p;
		if(p->chave<el) p = p->direita;
		else p = p->esquerda;
	}
	if (p!=NULL && p->chave==el) return prev;
	return NULL;
}

void remove(int el, struct BSTNode *raiz)
{
	struct BSTNode *nodo, *pai=NULL;
	nodo = busca(raiz, el); //encontra o elemento
	if(nodo != NULL) {
		if(nodo!=raiz) pai=buscapai(el, raiz); //encontra seu pai
		if(nodo->direita == NULL){ //possui um filho, ele esta a esquerda, ou folha
			if(nodo==raiz) raiz=nodo->esquerda;
			else if(pai->esquerda == nodo) 
				pai->esquerda = nodo->esquerda; //liga o pai com o filho do nodo esquerdo ou nulo
			 else  pai->direita = nodo->esquerda; //liga o pai com o filho do nodo esquerdo ou nulo
		free(nodo); nodo=NULL;
		}
		else if(nodo->esquerda == NULL){ //possui um filho, ele e o da direita
			if(nodo==raiz) raiz=nodo->direita;
			else if(pai->esquerda == nodo) 
				pai->esquerda = nodo->direita; //liga o pai com o filho do nodo direito 
			 else  pai->direita = nodo->direita; //liga o pai com o filho do nodo direito 
			 free(nodo); nodo=NULL;
		} else {  //se ele possui 2 filhos
		          struct BSTNode *tmp = nodo->esquerda; 
		          int maior;
		          while(tmp->direita!=NULL) tmp = tmp->direita; //acha o maior da subarvore esquerda
		          maior=tmp->chave;
		          remove(tmp->chave, raiz);
		          nodo->chave = maior; //copia chave para nodo
		}	
		
	}
	else if (raiz != NULL) printf("A chave %i nao esta na arvore!", el);
	       else printf("A arvore esta vazia!");
}
int main()
{
	struct BSTNode *raiz=NULL;
    
	insere(&raiz, 15);
	insere(&raiz, 12);
	insere(&raiz, 25);
	insere(&raiz, 7);
	insere(&raiz, 14);
	insere(&raiz, 31);
	insere(&raiz, 19);
	emordem(raiz); printf("\n");
	//preordem(raiz); printf("\n");
	posordem(raiz); printf("\n");
	remove(25,raiz);
	//emordem(raiz); printf("\n");
	contador(raiz)); 

	libera(&raiz);
	return 0;
}

