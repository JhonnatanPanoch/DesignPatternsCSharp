Resumindo:
- Adapter → adapta interfaces incompatíveis.
- Bridge → separa abstração da implementação.
- Composite → estrutura em árvore.
- Decorator → adiciona comportamento dinamicamente.
- Facade → interface simples para subsistemas.
- Flyweight → compartilha objetos para economizar memória.
- Proxy → substituto que controla acesso.

____________________________________________________________________________________________________________________________________

Resumindo com metáforas rápidas
- Adapter → tomada universal (compatibiliza coisas diferentes).
- Bridge → controle remoto (separa controle de dispositivo).
- Composite → pastas/arquivos (parte e todo tratados iguais).
- Decorator → colocar cobertura no bolo (funcionalidade extra sem mudar a base).
- Facade → porta de entrada simplificada (esconde a bagunça dos bastidores).
- Flyweight → assentos de avião (mesma cadeira, só muda quem senta).
- Proxy → porteiro (controla quem entra e quando).

____________________________________________________________________________________________________________________________________

Exemplos Práticos dos Padrões Estruturais
1. Adapter → “Tomada universal”
👉 Quando usar: integrar sistemas que falam “idiomas diferentes”.

- Exemplo real:
	- Você consome uma API de terceiros que retorna datas em string ("2025-08-26") mas o seu sistema usa DateTime.
Em vez de mudar todo o seu código, você cria um Adapter que converte a resposta para o formato esperado.

2. Bridge → “Controle remoto”
👉 Quando usar: quando abstração e implementação mudam de forma independente.

- Exemplo real:
	- Sistema de notificações:
		- Abstração = tipo de mensagem (NotificacaoSimples, NotificacaoUrgente).
		- Implementação = canal de envio (Email, SMS, Push).
		- O Bridge permite combinar livremente → NotificacaoUrgentePorEmail, NotificacaoSimplesPorSMS etc., sem precisar criar dezenas de subclasses.

3. Composite → “Pasta de arquivos”
👉 Quando usar: trabalhar com hierarquias em árvore.

- Exemplo real:
	- Sistema de menus de um site (Menu → Submenu → Item).
	- Tanto um Item quanto um Menu com filhos são tratados da mesma forma.
	- Assim, o código que renderiza o menu não precisa saber se é folha ou nó.

4. Decorator → “Adicionar tempero”
👉 Quando usar: adicionar funcionalidades extras sem alterar a classe original.

- Exemplo real:
	- Serviço de armazenamento de arquivos.
		- ArmazenamentoLocal → salva em disco.
		- Decorador ComCompressao → comprime antes de salvar.
		- Decorador ComCriptografia → criptografa antes de salvar.
		- Você combina dinamicamente → new ComCriptografia(new ComCompressao(new ArmazenamentoLocal())).

5. Facade → “Porta de entrada simplificada”
👉 Quando usar: expor uma interface simples para subsistemas complexos.

- Exemplo real:
	- Sistema de compra online: para comprar, o cliente só chama:
		loja.Comprar(produtoId, clienteId);
	- Internamente, o Facade orquestra: Pedido, Estoque, Pagamento, Entrega.
	- O cliente não precisa conhecer os detalhes internos.

6. Flyweight → “Compartilhar para economizar”
👉 Quando usar: quando há milhares/milhões de objetos iguais e você precisa economizar memória.

- Exemplo real:
	- Sistema de edição de documentos:
		- Cada letra do texto (a, b, c) não precisa ser um objeto único.
		- Em vez disso, você compartilha os dados intrínsecos (forma da letra, fonte, tamanho) e só armazena as diferenças (posição no documento).
	- Outro uso comum → cache de objetos no banco (um produto acessado 1000x mas carregado 1x).

7. Proxy → “Porteiro/Representante”
👉 Quando usar: quando precisa controlar acesso a um recurso.

- Exemplo real:
	- Lazy Loading: só carregar uma imagem grande (ex: relatório em PDF) quando realmente for acessada.
	- Cache Proxy: interceptar chamadas para uma API externa e guardar em cache os resultados.
	- Segurança: um Proxy que verifica permissões antes de acessar o objeto real.

____________________________________________________________________________________________________________________________________

Fluxo de Decisão — Design Patterns Estruturais
Precisa integrar sistemas com interfaces diferentes?
 └──► SIM → Use **Adapter**

Precisa separar abstração da implementação para evoluírem separadas?
 └──► SIM → Use **Bridge**

Precisa representar hierarquias (parte-todo) como árvore?
 └──► SIM → Use **Composite**

Precisa adicionar funcionalidades extras em tempo de execução sem mudar a classe?
 └──► SIM → Use **Decorator**

Seu sistema é complexo e os clientes precisam de uma interface simples de uso?
 └──► SIM → Use **Facade**

Está criando MUITOS objetos iguais e quer economizar memória?
 └──► SIM → Use **Flyweight**

Precisa controlar o acesso a um objeto (lazy loading, cache, segurança, log)?
 └──► SIM → Use **Proxy**

 Exemplos rápidos dentro do fluxo

- Adapter → API externa retorna XML mas sua aplicação só entende JSON.
- Bridge → Notificações (abstração: tipo da mensagem, implementação: canal de envio).
- Composite → Menus e submenus de uma aplicação web.
- Decorator → Serviço de envio de arquivos (com compressão, criptografia, etc.).
- Facade → Serviço Checkout() que internamente chama estoque, pagamento, entrega.
- Flyweight → Editor de texto com milhões de caracteres.
- Proxy → Cache para chamadas caras a banco ou API externa.