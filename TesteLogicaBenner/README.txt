Projeto de Conexões e Grafos/Árvores
=============================

Descrição:
-----------
Este projeto implementa uma rede de elementos interconectados utilizando o algoritmo Union-Find (DSU) para verificar a conectividade entre os elementos. A principal estratégia usada aqui é a união de conjuntos disjuntos, também conhecida como DSU (Disjoint Set Union), que utiliza duas otimizações:
- Compressão de Caminho: Melhora a eficiência de consultas, tornando a busca pela raiz dos conjuntos mais rápida.
- União por Rank: Equilibra as árvores de representação dos conjuntos, garantindo que as operações de união sejam mais eficientes.

Estrutura:
----------
- Network: Classe responsável por manter os elementos conectados e realizar consultas de conectividade.
- NegativeNumberException: Classe responsável por aplicar Exceções baseadas no input de números que não podem ter o valor de 0 ou menor.
- DSU: Implementação do algoritmo Union-Find que utiliza compressão de caminho e união por rank.

Tecnologias Usadas:
-------------------
- C#
- .NET Core

Estratégia:
-----------
O algoritmo DSU foi escolhido por sua eficiência na execução de múltiplas operações de união e consulta. Ele permite manter a complexidade das operações de união e consulta muito baixa.
