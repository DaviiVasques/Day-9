[Day 9]
Olá pessoal, como vocês estão? 😊

Hoje fiz um exercício bem legal usando herança e, consequentemente, usei polimorfismo (os dois estão muito ligados). Não postei conteúdo ontem, pois ocorreram contratempos, mas estou seguindo nessa jornada.

Fiz um exercício onde criei três classes: ContaBanco, ContaCorrente e ContaPoupanca. ContaCorrente e ContaPoupanca herdam de ContaBanco, e cada uma dessas classes que herdaram de ContaBanco tem suas especificidades.

Na conta corrente, temos o atributo LimiteChequeEspecial. Mas afinal, o que é o Limite de Cheque Especial na conta corrente? "É uma linha de crédito que o banco disponibiliza aos clientes além do saldo disponível na conta corrente. Funciona como um empréstimo automático que o cliente pode usar quando o saldo da conta é insuficiente para cobrir uma transação" 💳.

E na conta poupança, temos a TaxaRendimento, que é definida como: "É uma porcentagem que determina o quanto uma quantia de dinheiro em uma conta de poupança ou investimento cresce ao longo do tempo. No contexto de uma conta poupança, a taxa de rendimento é a porcentagem de juros que o banco paga ao titular da conta sobre o saldo depositado" 📈.

Então, para esse exercício, criei a superclasse ContaBanco e duas classes filhas: ContaCorrente e ContaPoupanca. Agora explicando sobre cada classe: a ContaBanco tem seus atributos NumeroConta e Saldo. Após isso, temos o construtor que recebe como parâmetro dois argumentos e passa esses dois valores para os atributos NumeroConta e Saldo. Temos os métodos Depositar, onde poderá ser feito o depósito de uma quantia, e o método Sacar, que eu declarei como "virtual". Isso significa que a sua regra de negócio pode ser mudada pela classe que for herdar essa classe "Pai" 🏦.

Agora, na classe ContaCorrente, temos uma nova propriedade que é o LimiteChequeEspecial, que expliquei acima. Essa nova propriedade é adicionada como validação para o método Sacar(), pois ela dá um crédito pré-estabelecido pelo banco, e assim, quando precisar comprar algo que tenha um valor mais alto que o seu saldo, esse Limite de Cheque Especial entra e empresta esse dinheiro, onde depois você tem que pagar com juros 💸.

E na classe ContaPoupanca, é adicionada a propriedade TaxaRendimento, que é um aumento em determinada porcentagem do seu dinheiro que está na poupança ou investido. Essa validação é feita pelo método AplicarRendimento() 💵.
