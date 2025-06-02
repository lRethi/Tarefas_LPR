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
        if(numeros[i] % 2 == 0){
            pares[par] = numeros[i];
            par++;
        }else{
            impares[imp] = numeros[i];
            imp++;
        }
    }
    return 0;
}

int MostrarNum(){
    cout << "Para os números pares, temos os valores:" << endl;
    cout << " - ";
    for(int i = 0; i < par; i++){
        if(i < par-1){
            cout << pares[i] << ", ";
        }else{
            cout << "e " << pares[i] << "." << endl;
        }
    }
    cout << "Para os números impares, temos os valores:" << endl;
    cout << " - ";
    for(int i = 0; i < imp; i++){
        if(i < imp-1){
            cout << impares[i] << ", ";
        }else{
            cout << "e " << impares[i] << "." << endl;
        }
    }
    return 0;
}

int main(){
    SetConsoleOutputCP(65001);
    cout << "Esse é um programa que lê 10 valores inteiros, e então os organiza em pares e impares." << endl;
    cout << "Para iniciar, digite os números que deseja usar." << endl;
    for (int i = 0; i < numeros.size(); i++){
        cin >> numeros[i];
    }
    CalcularPares();
    cout << "Agora, organizando tudo..." << endl;
    MostrarNum();
    return 0;
}