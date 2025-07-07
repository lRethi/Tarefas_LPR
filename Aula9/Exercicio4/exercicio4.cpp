#include <iostream>
#include <string>
#include <iomanip>
#include <windows.h>
#include <map>
#include <algorithm>
#include <numeric>
using namespace std;

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

void CidadeMaisMenosPop(const map<string, int> &cidades)
{
    auto MenorPop = min_element(begin(cidades), end(cidades),
                                [](const auto &l, const auto &r)
                                { return l.second < r.second; });
    auto MaiorPop = max_element(begin(cidades), end(cidades),
                                [](const auto &l, const auto &r)
                                { return l.second < r.second; });
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

void CidadeRemoverPopIgualY(map<string, int> &cidades)
{
    cout << "Entre com o valor que deseja excluir das populações." << endl;
    int valorPopRemove;
    cin >> valorPopRemove;
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

void MostrarCidades(map<string, int> &cidades)
{
    for (const auto& cidade : cidades)
    {
        cout << "Cidade: " << cidade.first << ", População: " << cidade.second << endl;
    }
}

int main()
{
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);
    map<string, int> cidades;

    cout << "Entre com quantas cidades você vai adicionar." << endl;
    int qntCidades;
    cin >> qntCidades;
    for (int i = 0; i < qntCidades; i++)
    {
        cout << "Entre com o nome da cidade " << i + 1 << endl;
        string NomeCidade;
        getline(cin >> ws, NomeCidade);
        cout << "Entre com a população da cidade " << i + 1 << endl;
        int PopCidade;
        cin >> PopCidade;
        cidades.insert({NomeCidade, PopCidade});
    }
    int somaPop = 0;
    for (const auto& pair : cidades)
    {
        somaPop += pair.second;
    }
    int mediaPop = somaPop / qntCidades;
    CidadesAcimaMedia(mediaPop, cidades);
    CidadeMaisMenosPop(cidades);
    CidadeRemoverPopIgualY(cidades);
    MostrarCidades(cidades);
}