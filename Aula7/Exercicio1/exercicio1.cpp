#include <iostream>
#include <iomanip>
#include <windows.h>
#include <vector>
using namespace std;

vector<int> pares(10);
vector<int> impares(10);
vector<int> numeros(10);
int par; // variável contador para os pares
int imp; // variável contador para os impares

int CalcularPares(){
    par = 0;
    imp = 0;
    for (int i = 0; i < numeros.size(); i++){
        if(numeros[i] % 2 == 0){ //verifica se é par
            pares[par] = numeros[i];
            par++;
        }else{
            impares[imp] = numeros[i]; //logicamente vira impar se n for
            imp++;
        }
    }
    return 0;
}

int MostrarNum(){
    cout << "Para os números pares, temos os valores:" << endl;
    cout << " - ";
    for(int i = 0; i < par; i++){
        if(i < par-1){ // enquanto n tá na ultima posição
            cout << pares[i] << ", "; 
        }else{ // quando tá na última posição
            cout << "e " << pares[i] << "." << endl;
        }
    }
    cout << "Para os números impares, temos os valores:" << endl;
    cout << " - ";
    for(int i = 0; i < imp; i++){
        if(i < imp-1){ // mesmo de antes, antes da ultima
            cout << impares[i] << ", ";
        }else{ // na ultima
            cout << "e " << impares[i] << "." << endl;
        }
    }
    return 0;
}

int main(){
    SetConsoleOutputCP(65001); // pra mostrar acento !
    cout << "Esse é um programa que lê 10 valores inteiros, e então os organiza em pares e impares." << endl;
    cout << "Para iniciar, digite os números que deseja usar." << endl;
    for (int i = 0; i < numeros.size(); i++){ // coloca os numero
        cin >> numeros[i];
    }
    CalcularPares();
    cout << "Agora, organizando tudo..." << endl;
    MostrarNum();
    return 0;
}