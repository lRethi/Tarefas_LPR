#include <iostream>
#include <string>
#include <iomanip>
#include <windows.h>
#include <map>
#include <algorithm>
#include <numeric>
using namespace std;

// Função que exibe as cidades com população acima da média
void CidadesAcimaMedia(int mediaPop, const map<string, int> &cidades)
{
    cout << "A média de população é de " << mediaPop << " e as cidades que são acima dessa média são ";
    for (const auto &varCidade : cidades)
    {
        if (varCidade.second > mediaPop)
        {
            cout << varCidade.first << ", ";
        }
    }
    cout << "." << endl;
    return;
}

// Função que encontra e exibe a cidade com maior e menor população
void CidadeMaisMenosPop(const map<string, int> &cidades)
{
    // Encontra o iterador para a cidade com menor população
    auto MenorPop = min_element(begin(cidades), end(cidades),
                                [](const auto &l, const auto &r)
                                { return l.second < r.second; });
    // Encontra o iterador para a cidade com maior população
    auto MaiorPop = max_element(begin(cidades), end(cidades),
                                [](const auto &l, const auto &r)
                                { return l.second < r.second; });
    // Percorre o mapa para exibir as cidades com menor e maior população
    for (const auto& cidade : cidades)
    {
        if (cidade.second == MenorPop->second)
        {
            cout << "A cidade com menor população é " << cidade.first << " e ela tem " << cidade.second << " habitantes." << endl;
        }
        if (cidade.second == MaiorPop->second)
        {
            cout << "A cidade com maior população é " << cidade.first << " e ela tem " << cidade.second << " habitantes." << endl;
        }
    }
}

// Função que remove cidades cuja população seja igual ao valor informado pelo usuário
void CidadeRemoverPopIgualY(map<string, int> &cidades)
{
    cout << "Entre com o valor que deseja excluir das populações." << endl;
    int valorPopRemove;
    cin >> valorPopRemove;
    // Percorre o mapa e remove as cidades com população igual ao valor informado
    for (auto it = cidades.begin(); it != cidades.end();)
    {
        if (it->second == valorPopRemove)
        {
            it = cidades.erase(it);
        }
        else
        {
            ++it;
        }
    }
}

// Função que exibe todas as cidades e suas populações
void MostrarCidades(map<string, int> &cidades)
{
    for (const auto& cidade : cidades)
    {
        cout << "Cidade: " << cidade.first << ", População: " << cidade.second << endl;
    }
}

int main()
{
    // Configura o console para aceitar caracteres UTF-8
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);
    map<string, int> cidades;

    cout << "Entre com quantas cidades você vai adicionar." << endl;
    int qntCidades;
    cin >> qntCidades;
    // Lê os dados das cidades e populações do usuário
    for (int i = 0; i < qntCidades; i++)
    {
        cout << "Entre com o nome da cidade " << i + 1 << endl;
        string NomeCidade;
        getline(cin >> ws, NomeCidade); // Lê o nome da cidade (incluindo espaços)
        cout << "Entre com a população da cidade " << i + 1 << endl;
        int PopCidade;
        cin >> PopCidade;
        cidades.insert({NomeCidade, PopCidade});
    }
    // Calcula a soma das populações
    int somaPop = 0;
    for (const auto& pair : cidades)
    {
        somaPop += pair.second;
    }
    // Calcula a média da população
    int mediaPop = somaPop / qntCidades;
    // Exibe cidades acima da média
    CidadesAcimaMedia(mediaPop, cidades);
    // Exibe cidade com maior e menor população
    CidadeMaisMenosPop(cidades);
    // Remove cidades com população igual ao valor informado
    CidadeRemoverPopIgualY(cidades);
    // Exibe as cidades restantes
    MostrarCidades(cidades);
}