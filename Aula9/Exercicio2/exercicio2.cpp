#include <iostream>
#include <string>
#include <iomanip>
#include <windows.h>
#include <list>
#include <algorithm>
#include <ctime>
using namespace std;

// Função para gerar 100 números aleatórios, inserir na lista e ordenar
void gerarNumerosAleatorios(list<int> &numeros)
{
    srand(time(0)); // Inicializa o gerador de números aleatórios
    for (int i = 0; i < 100; i++)
    {
        numeros.push_back(rand());
    }
    numeros.sort(); // Ordena a lista
    return;
}

// Função para remover todos os números pares da lista
void retirarParesDaLista(list<int> &numeros)
{
    auto it = numeros.begin();
    for (auto it = numeros.begin(); it != numeros.end();)
    {
        if (*it % 2 == 0)
        {
            it = numeros.erase(it); // Remove e atualiza o iterador
        }
        else
        {
            ++it; // Avança o iterador apenas se não remover
        }
    }
    return;
}

// Função para encontrar números repetidos consecutivos na lista ordenada
void verNumerosIguais(list<int> &numeros, list<int> &repetidos)
{
    for (auto it = numeros.begin(); it != numeros.end(); it++)
    {
        auto proximoElemento = next(it);
        if (*it == *proximoElemento)
        {
            repetidos.push_back(*it);
        }
    }
    return;
}

int main()
{
    list<int> numeros;
    list<int> repetidos;
    SetConsoleOutputCP(65001);       // Configura o console para UTF-8 (acentuação)
    gerarNumerosAleatorios(numeros); // Gera e ordena os números aleatórios

    cout << "- A lista de números original é de:" << endl;
    for (auto it = numeros.begin(); it != numeros.end(); ++it)
    {
        cout << *it;
        if (next(it) == numeros.end())
        {
            cout << "." << endl; // Ponto final no último elemento
        }
        else
        {
            cout << ", "; // Vírgula nos outros
        }
    }
    cout << endl;

    retirarParesDaLista(numeros); // Remove os números pares

    cout << "- A lista de números que não são pares é de:" << endl;
    for (auto it = numeros.begin(); it != numeros.end(); ++it)
    {
        cout << *it;
        if (next(it) == numeros.end())
        {
            cout << "." << endl; // Ponto final no último elemento
        }
        else
        {
            cout << ", "; // Vírgula nos outros
        }
    }

    verNumerosIguais(numeros, repetidos); // Encontra números repetidos consecutivos

    cout << "- Os números que se repetem são:" << endl;
    for (auto it = repetidos.begin(); it != repetidos.end(); ++it)
    {
        cout << *it;
        if (next(it) == repetidos.end())
        {
            cout << "." << endl; // Ponto final no último elemento
        }
        else
        {
            cout << ", "; // Vírgula nos outros
        }
    }
    cout << endl;
    return 0;
}