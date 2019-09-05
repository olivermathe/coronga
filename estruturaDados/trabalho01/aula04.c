#include <stdio.h>
#include <malloc.h>

int soma_nodos(struct bstnode *raiz)
{
    struct bstnode *p;
    if(raiz == NULL)
        return 0;
        /* data */  
    else{
        p=raiz;
        return p->chave + soma_nodos(p->esquerda)+soma_nodos(p->direita);
    }
}
int soma_maiores_raiz(struct bstnodo *raiz)
{
    int r=0;
    if(raiz!=NULL)
        r=soma_nodos(raiz->direita);
    return r;
}