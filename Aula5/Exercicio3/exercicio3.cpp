#include <iostream>
#include <iomanip>
#include <windows.h>
using namespace std;

int main(){
    SetConsoleOutputCP(65001);
    int sum = 0;
    cout << "Esse é um programa que calcula a soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 à 500." << endl;
    for (int num = 50; num < 500; num++){
        if(num % 2 != 0 && num%3 == 0){
            sum+=num;
        }
    }
    cout << "A soma de todos os números é " << sum << "!" << endl;
}