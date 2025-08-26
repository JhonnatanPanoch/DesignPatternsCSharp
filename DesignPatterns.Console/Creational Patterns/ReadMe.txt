- Factory Method → delega criação para subclasses.
- Abstract Factory → cria famílias de objetos relacionados.
- Builder → monta objetos complexos passo a passo.
- Prototype → clona objetos existentes.
- Singleton → garante uma única instância global.

____________________________________________________________________________________________________________________________________

Exemplos práticos de quando usar no dia a dia

Factory Method → quando seu código precisa criar objetos, mas a decisão depende de dados de entrada.
Ex: Se tipoArquivo = "CSV", retorna CsvReader; se "JSON", retorna JsonReader.

Abstract Factory → quando você tem que garantir que objetos combinam entre si.
Ex: Em uma tela de sistema, todos os componentes devem seguir o mesmo tema visual (não pode misturar botão moderno com menu antigo).

Builder → quando você precisa montar objetos diferentes a partir dos mesmos passos.
Ex: Um sistema de pedido online pode gerar: recibo simples, nota fiscal completa ou contrato de venda, dependendo do builder.

Prototype → quando criar é caro e você prefere copiar e ajustar.
Ex: Clonar um modelo de e-mail (com cabeçalho e rodapé fixos) e só trocar o corpo da mensagem.

Singleton → quando precisa de um ponto central de acesso.
Ex: Classe ConfigurationManager que lê do appsettings.json apenas uma vez e disponibiliza no sistema todo.

____________________________________________________________________________________________________________________________________

Fluxo de Decisão – Patterns de Criação

1. Precisa de apenas uma instância global no sistema?
✅ Sim → Use Singleton
❌ Não → Vá para o próximo.

2. Precisa criar objetos sem expor new e deixar a escolha para subclasses ou métodos fábricas?
✅ Sim → Use Factory Method
❌ Não → Próximo.

3. Precisa criar famílias de objetos relacionados (que funcionam juntos) sem depender das classes concretas?
✅ Sim → Use Abstract Factory
❌ Não → Próximo.

4. O objeto é complexo, precisa ser construído em etapas e pode ter diferentes representações?
✅ Sim → Use Builder
❌ Não → Próximo.

5. A criação do objeto é custosa e você prefere clonar um modelo já existente?
✅ Sim → Use Prototype
❌ Não → Talvez não precise de um pattern de criação.

____________________________________________________________________________________________________________________________________

Exemplo prático do fluxo (com C#):
Imagine que você está implementando relatórios no sistema:

- Se só pode ter um gerador global de relatórios → Singleton.
- Se o relatório pode ter diferentes layouts (PDF, Excel, HTML) e você quer delegar a criação → Factory Method.
- Se os relatórios vêm em famílias (TemaClaroPDF + TemaClaroExcel, TemaEscuroPDF + TemaEscuroExcel) → Abstract Factory.
- Se o relatório é complexo de montar (cabeçalho, rodapé, corpo, gráficos, assinatura) → Builder.
- Se você já tem um relatório base e quer criar uma cópia com pequenas alterações → Prototype.