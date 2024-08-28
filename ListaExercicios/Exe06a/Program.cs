// 1- criar um vetor de valores inteiros
// 2- percorrer o vetor com um laço
// 3- gerar um valor aleatorio em C#
// 4- ordenar o vetor usando o bubble sort

int tamanho = 100;
int[] vetor = new int[tamanho];

//percorrer o vetor com laço
Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    //gerar um valor aleatorio
    vetor[i] = random.Next(1000);
}

//imprimir vetor com valores aleatorios
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

bool troca = false;
//ordenar usando bubble
do
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        if (vetor[i] > vetor[i + 1])
        {
            troca = true;
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
        }
    }
} while (troca == true);

Console.WriteLine("\n");

//imprimir vetor ordenado
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}