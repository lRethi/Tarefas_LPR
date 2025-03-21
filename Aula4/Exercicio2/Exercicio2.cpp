#include <iostream>
#include <windows.h>
using namespace std;
int A,B;

int main(){
    SetConsoleOutputCP(65001);
    cout << "Esse programa serve para ler dois valores inteiros e verificar se eles são ou não múltiplos de si." << endl;
    cout << "Entre com o valor A." << endl;
    cin >> A;
    cout << "Entre com o valor B." << endl;
    cin >> B;
    if (A%B==0){
        cout << "O número " << A << " é múltiplo do número " << B << "!" << endl;
    } else if (B%A==0){
        cout << "O número " << A << " é múltiplo do número " << B << "!" << endl;
    } else {
        cout << "O número " << A << " não é múltiplo do número " << B << "!" << endl;
    }
    return 0;
}