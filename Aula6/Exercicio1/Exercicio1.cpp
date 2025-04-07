#include <iostream>
#include <iomanip>
#include <windows.h>
using namespace std;

int inverterNumero(int numero){
    int inverso = 0;

    while (numero != 0){
        int digito = numero%10;
        inverso = inverso * 10 + digito;
        numero /= 10;
    }
    return inverso;
}

int escolha(){
    cout << "Para iniciar, digite o número desejado à ser invertido." << endl;
    int entrada = 0;
    cin >> entrada;

    int resultado = inverterNumero(entrada);
    cout << "O resultado inverso do número " << entrada << " é " << resultado << "!" << endl;
}

int main(){
    SetConsoleOutputCP(65001);
    cout << "Esse é um programa que, ao pegar um número digitado, dá o resultado reverso dele." << endl;
    escolha();
}