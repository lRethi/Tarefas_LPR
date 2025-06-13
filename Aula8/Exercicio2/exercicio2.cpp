#include <iostream>
#include <string>
#include <iomanip>
#include <windows.h>
#include <vector>
using namespace std;

struct Livro{
    string Titulo, Autor, AnoPublicacao;
    int NumeroPaginas, Preco;
};

int main(){
    SetConsoleOutputCP(65001);
    int precoTotal = 0, pagMedia = 0;
    vector<Livro> livros(3);
    for(int i = 0; i < livros.size(); i++){
        cout << "Entre com o título do livro " << (i+1) << "." << endl;
        cin.ignore();
        getline(cin, livros[i].Titulo);
        cout << "Entre com o autor do livro " << (i+1) << "." << endl;
        getline(cin, livros[i].Autor);
        cout << "Entre com o ano de publicação do livro " << (i+1) << "." << endl;
        cin >> livros[i].AnoPublicacao;
        cout << "Entre com o número de páginas do livro " << (i+1) << "." << endl;
        cin >> livros[i].NumeroPaginas;
        cout << "Entre com o preço do livro " << (i+1) << "." << endl;
        cin >> livros[i].Preco;
    }
    for(int i = 0; i < livros.size(); i++){
        precoTotal += livros[i].Preco;
        pagMedia += livros[i].NumeroPaginas;
    }
    pagMedia = pagMedia / livros.size();
    cout << "O total do preço dos livros cadastrados é de R$" << precoTotal << ",00 e eles tem uma média de " << pagMedia << " páginas!" << endl;
    return 0;
}