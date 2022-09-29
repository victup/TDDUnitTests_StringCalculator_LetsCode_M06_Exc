# TDD - String Calculator

Este projeto foi desenvolvido aplicando a técnica de TDD (Test Driven Development) ou Desenvolvimento guiado por testes em português.

O programa recebe uma string com dois valores separados por virgula. Busca atender basicamente os seguintes requisitos:

1. A Classe StringCalculator deve conter um métido chamado Add.
2. O método Add deve retornar um inteiro.
3. O método Add deve receber uma string como parâmetro.
4. Se o parâmetro passado for nulo ou string vazia, o método Add deve retornar 0.
5. O parâmetro passado para o método Add deve conter **até dois números** separados por vírgulas. 
Por exemplo: null, “”, “1”, “1,2”

Baseado nos requisitos acima, foi criado todos os casos de testes, e depois disso realizado a codificação na camada de Domain das regras de negócio.
