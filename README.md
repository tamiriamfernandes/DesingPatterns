# DesingPatterns

## 1.1 - Abstract Factory
O Abstract Factory é um padrão de design (design pattern) pertencente ao grupo dos Padrões de Criação. Ele fornece uma maneira de criar famílias de objetos relacionados sem a necessidade de especificar suas classes concretas. Em vez disso, o Abstract Factory oferece uma interface comum para a criação de objetos, permitindo que você escolha uma fábrica concreta para criar objetos que compartilham uma interface comum.

## Por que usar o Abstract Factory?

- Promove a independência entre o código do cliente e as classes concretas dos objetos.
- Facilita a troca de famílias de objetos sem modificar o código do cliente.
- Útil em cenários onde você precisa criar conjuntos de objetos relacionados de forma coesa.

O Abstract Factory é particularmente útil em sistemas que envolvem várias famílias de objetos que devem ser criadas e usadas juntas de maneira consistente. Ele torna o código mais flexível e fácil de expandir.

## 1.2- Factory Method
O Factory Method é um padrão de design (design pattern) que faz parte do grupo de padrões conhecido como Padrões de Criação (Creational Patterns). Ele define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe concreta instanciar. Em outras palavras, o Factory Method delega a responsabilidade de criação de objetos para as subclasses, em vez de fazê-lo em uma classe base.

## Por que usar o Factory Method?

- Desacoplamento: ajuda a desacoplar o código do cliente das classes concretas. Isso significa que o código do cliente não precisa conhecer detalhes específicos sobre a classe concreta que está sendo criada. Esse desacoplamento torna o código mais flexível e menos propenso a erros.
- Extensibilidade: segue o princípio do aberto/fechado (Open/Closed Principle), o que significa que você pode adicionar novas classes de objetos (subclasses) sem modificar o código existente. Isso é particularmente útil em sistemas que precisam ser facilmente estendidos sem alterar código já existente.
- Reutilização: promove a reutilização de código. A lógica de criação de objetos é encapsulada em classes de fábrica, e essas fábricas podem ser compartilhadas entre diferentes partes do sistema.
- Polimorfismo: permite que o código do cliente trabalhe com objetos por meio de abstrações, o que promove o uso do polimorfismo. Isso facilita a substituição de objetos criados pela fábrica sem afetar o código do cliente.
- Inversão de Dependência: segue o princípio da inversão de dependência, permitindo que o código do cliente dependa de abstrações (interfaces) em vez de implementações concretas. Isso torna o sistema mais flexível e fácil de testar, já que você pode injetar diferentes fábricas ou implementações concretas conforme necessário.
- Gerenciamento de configuração: é útil quando você precisa criar objetos com base em alguma configuração ou lógica específica. As subclasses de fábrica podem implementar a lógica de criação de objetos de acordo com os requisitos do sistema.
- Facilidade de manutenção: Ao usar o Factory Method, você pode isolar a lógica de criação em um local central. Isso torna mais fácil fazer alterações na forma como os objetos são criados, sem afetar o restante do código.
