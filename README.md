## CSharp-app1-CRUD

# Descrição
Criar um algoritmo simples de cadastro de séries para praticar seus conhecimentos de orientação a objetos, o principal paradigma de programação utilizada no mercado. Nesse projeto você vai aprender: Como pensar orientado a objetos, como modelar o seu domínio, como utilizar recursos de coleção para salvar seus dados em memória.

# Objetivos do Projeto
1. Implementação de um CRUD de séries
2. Utilização de classes abstratas
3. Utilização de interfaces
4. Utilização de "Orientação a Objetos"
5. Utilização de ambiente .NET

# Crud
- Create / Criar
- Read / Ler
- Update / Atualizar
- Delete / Deletar

# Classes Abstratas

- As classes abstratas devem conter pelo menos um método abstrato, que não tem corpo.
- É um tipo especial de classe que **não** há como criar instâncias dela.
- É usada apenas para ser herdada, funciona como uma super classe.
- Uma grande vantagem é que força a hierarquia para todas as sub-classes.
- Exige subclasses que tenham implementação dos métodos abstratos.
- É um tipo de contrato que faz com que as sub-classes contemplem as mesmas hierarquias e/ou padrões.

# Interfaces

- Interface é muito semelhante a uma classe abstrata, mas não possui atributos e não pode definir como os métodos devem ser implementados.
- Uma interface não é considerada uma Classe e sim uma Entidade.
- Não possui implementação, apenas assinatura, ou seja, apenas a definição dos seus métodos sem o corpo.
- Todos os métodos são abstratos.
- Seus métodos são implicitamente Públicos e Abstratos.
- Não há como fazer uma instância de uma Interface e nem como criar um Construtor.
- Funcionam como um tipo de "contrato", onde são especificados os atributos, métodos e funções que as classes que implementem essa interface são obrigadas a implementar.
- Já que C# não suporta Heranças Múltiplas, as Interfaces são usadas para implementá-las.
