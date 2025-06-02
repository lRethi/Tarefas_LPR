#include <iostream>
#include <iomanip>
#include <windows.h>
#include <vector>
using namespace std;

vector<int> lista(10);
int num; // variável para o número a ser verificado
int qnt; // variável para a quantidade de vezes que o número aparece
int ap; // variável para controlar a posição

int VerPos(){
    cout << "Digite o número que deseja verificar: ";
    cin >> num;
    int l;
    qnt = 0; // reinicia a quantidade
    ap = 0; // reinicia a posição
    for (int i = 0; i < lista.size(); i++){
        if(lista[i] == num){ // verifica se o número está na lista
            qnt++; // incrementa a quantidade
        }
    }
    cout << "O número " << num << " aparece " << qnt << " vezes." << endl;
    if (qnt > 0) {
        cout << "Ele aparece nas posições: ";
        for (int i = 0; i < lista.size(); i++) {
            if (lista[i] == num) { // verifica se a tem o número
                if (ap < qnt - 1) { // enquanto não é a última posição
                    cout << i+1 << ", ";
                } else { // quando é a última posição
                    cout << "e " << i+1 << ".";
                }
                ap++; // incrementa a posição
            }
        }
        cout << endl;
    } else {
        cout << "O número " << num << " não foi encontrado na lista." << endl;
    }
    return 0;
}

int Retry(){
    while(1){ // C++ se eu pudesse nunca mais olhar na sua cara eu nao olharia (é pra repetir o retry até dar o return 0)
    int l;
    cout << "Deseja verificar mais algum número? (1 - Sim, 2 - Não)" << endl;
    cin >> l;
    switch (l)
    {
    case 1:
        VerPos();
        break;
    case 2:
        cout << "Até depois então!" << endl;
        return 0;
    break;
    default:
        cout << "Número inválido. Tente novamente!" << endl;
        Retry(); // reinicia o programa
        break;
    }
    } 
}

int main(){
    SetConsoleOutputCP(65001); // pra mostrar acento !
    int l;
    cout << "Esse é um programa que armazena 10 valores inteiros, e então permite que você verifique se eles aparecem, e, onde aparecem." << endl;
    cout << "Para iniciar, digite os números que deseja usar." << endl;
    for (int i = 0; i < lista.size(); i++){ // coloca os numero
        cin >> lista[i];
    }
    cout << "Agora, deseja verificar algum número? (1 - Sim, 2 - Não)" << endl;
    cin >> l;
    switch (l)
    {
    case 1:
        VerPos();
        Retry();
        break;
    case 2:
        cout << "Eeh..? Ok? Até depois então!" << endl;
        return 0;
    break;
    default:
        cout << "Número inválido. Tente novamente!" << endl;
        main(); // reinicia o programa
        break;
    }
}