#include <iostream>
#include <iomanip>
#include <windows.h>
using namespace std;

int mediaAritmetica(){
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

int somaMultiplo3(){
    int sum = 0;
    cout << "Esse é um programa que calcula a soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 à 500." << endl;
    for (int num = 50; num < 500; num++){
        if(num % 2 != 0 && num%3 == 0){
            sum+=num;
        }
    }
    cout << "A soma de todos os números é " << sum << "!" << endl;
    return 0;
}

int vendaPeca(){
    int codigo_peca_1, codigo_peca_2, num_peca_1, num_peca_2;
    double valor_peca_1, valor_peca_2, valor_a_pagar;

    cout << "Digite o código da peça 1, a quantidade de peças e o valor unitário da peça, separados por um espaço" << endl;
    cin >> codigo_peca_1 >> num_peca_1 >> valor_peca_1;

    cout << "Digite o código da peça 2, a quantidade de peças e o valor unitário da peça, separados por um espaço" << endl;
    cin >> codigo_peca_2 >> num_peca_2 >> valor_peca_2;

    valor_a_pagar = num_peca_1*valor_peca_1 + num_peca_2*valor_peca_2;
    cout << fixed << setprecision(2) << "VALOR A PAGAR: R$ " << valor_a_pagar << endl;
    return 0;
}

int main(){
    SetConsoleOutputCP(65001);
    int init;
    cout << "Esse programa mantém 3 programas dentro dele, sendo eles:" << endl;
    cout << " 1 - Calculador de Média Aritmética de Número" << endl;
    cout << " 2 - Soma de Ímpares Múltiplos de 3 (50 - 500)" << endl;
    cout << " 3 - Calculador de Valor à Pagar por Peça" << endl;
    cout << "Entre com o número do programa que você desejar usar." << endl;
    cin >> init;
    switch(init){
        case 1:
        mediaAritmetica();
        break;
        case 2:
        somaMultiplo3();
        break;
        case 3:
        vendaPeca();
        break;
        default:
        cout << "Um valor inválido foi entrado, tente novamente." << endl;
        break;
    }
}