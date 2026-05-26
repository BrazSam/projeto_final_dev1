Domain - OK
.
E o coracão do sistema, onde a logica de negocios e o conhecimento específico do domínio são
implementados.
. Esta camada deve ser isolada e livre de dependencias externas, focando na modelagem do problema de
negocio.
Contem as entidades, value objects, agregados e as interfaces dos repositórios.


Application
. Essa camada coordena as acões e fluxos de trabalho do sistema, atuando como mediadora entre a
camada de interface do usuario e a camada de domínio.
Ela executa casos de uso e orquestra o fluxo de informacoes entre as camadas superiores e inferiores.


Infrastructure - OK
Essa camada lida com detalhes tecnicos e de suporte, como acesso a banco de dados, comunicacao com
serviços externos, logging, etc.
E a camada de menor nível de abstracao e onde as tecnologias sao implementadas.


. Presentation
· É a camada responsável por interagir com o usuário, recebendo comandos e exibindo resultados.
· Ela não deve conter lógica de negócios, apenas a apresentação das informações e o tratamento de
interações do usuário.
. Por exemplo, Console App, ASP.NET Core, Windows Forms, WPF, API REST etc.
