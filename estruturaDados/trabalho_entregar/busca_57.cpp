/*De acordo com a lista de valores a seguir, na ordem apresentada, monte (desenhe) 
uma Arvore Binária de Pesquisa e, também, uma árvore balanceada com esses valores.
Suponha uma função de busca de elemento na árvore, conforme a função busca() da árvore BST.
 Mostre o teste de mesa desta função, tanto para a árvore BST criada, como para a árvore balanceada na busca pelo elemento 57. 
Apresente o número de testes necessários até encontrar o valor 57 em ambas as árvores.
Valores: 15, 10, 25, 8, 30, 37, 24, 45, 36, 57*/
/*Aldrin Jr, e Antonio Lago*/
#include <stdio.h>
#include <stdlib.h>
#include <malloc/malloc.h>

int main(){
    struct BSTNode *raiz=NULL;
    insere(&raiz, 15);
    insere(&raiz, 10);
    insere(&raiz, 25);
    insere(&raiz, 8);
    insere(&raiz, 30);
    insere(&raiz, 37);
    insere(&raiz, 24);
    insere(&raiz, 45);
    insere(&raiz, 36);
    insere(&raiz, 57);
    //emordem(raiz); printf("\n");  
    //preordem(raiz); printf("\n");
    //posordem(raiz); printf("\n");
    encontrar(57,raiz);
    //emordem(raiz); printf("\n");
    printf("numero de testes nescessários para encontrar o valor 57:");
    printf("%i", conta_nodos(raiz));
    libera(&raiz);
    return 0;
 }