#include <iostream>
#include <string>
#include <iomanip>
#include <windows.h>
#include <vector>
using namespace std;

// Estrutura para armazenar informações de um livro
struct Livro{
    string Titulo, Autor, AnoPublicacao;
    int NumeroPaginas, Preco;
};

int main(){
    SetConsoleOutputCP(65001); // Configura o console para UTF-8 (acentuação)
    int precoTotal = 0, pagMedia = 0;
    vector<Livro> livros(3); // Vetor para armazenar 3 livros

    // Loop para entrada dos dados dos livros
    for(int i = 0; i < livros.size(); i++){
        cout << "Entre com o título do livro " << (i+1) << "." << endl;
        cin.ignore(); // Limpa o buffer do teclado antes de getline
        getline(cin, livros[i].Titulo); // Lê o título do livro

        cout << "Entre com o autor do livro " << (i+1) << "." << endl;
        getline(cin, livros[i].Autor); // Lê o autor do livro

        cout << "Entre com o ano de publicação do livro " << (i+1) << "." << endl;
        cin >> livros[i].AnoPublicacao; // Lê o ano de publicação

        cout << "Entre com o número de páginas do livro " << (i+1) << "." << endl;
        cin >> livros[i].NumeroPaginas; // Lê o número de páginas

        cout << "Entre com o preço do livro " << (i+1) << "." << endl;
        cin >> livros[i].Preco; // Lê o preço do livro
    }

    // Calcula o preço total e a soma das páginas
    for(int i = 0; i < livros.size(); i++){
        precoTotal += livros[i].Preco;
        pagMedia += livros[i].NumeroPaginas;
    }
    pagMedia = pagMedia / livros.size(); // Calcula a média de páginas

    // Exibe o resultado final
    cout << "O total do preço dos livros cadastrados é de R$" << precoTotal << ",00 e eles tem uma média de " << pagMedia << " páginas!" << endl;
    return 0;
}