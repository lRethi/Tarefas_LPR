#include <iostream>
#include <iomanip>
#include <windows.h>
using namespace std;

int main(){
    SetConsoleOutputCP(65001);
    int qnt, num, sum = 0, cont = 0;

    cout << "Esse é um algoritmo que calcula a média aritmética de um conjunto de números pares que for fornecido." << endl;
    cout << "NÚMEROS ÍMPARES SERÃO IGNORADOS." << endl;
    cout << "" << endl;
    cout << "Entre com a quantidade de números que serão digitados." << endl;
    cin >> qnt;

    while (qnt > 0){
        cout << "Entre com um número par." << endl;
        cin >> num;

        if (num%2 == 0){
            sum += num;
            cont++;
        } 
        qnt--;
    }
    if (cont > 0){
        double med = (double)sum/cont;
        cout << "A média aritmética dos números fornecidos é " << fixed << setprecision(1) << med << endl;
    } else{
        cout << "Nenhum número par e/ou válido foi informado." << endl;
    }
    return 0;
}