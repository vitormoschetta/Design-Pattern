
## Factory 

O padrão de fábrica é usado para abstrair a construção/instância de classes diferentes que estão em um mesmo contexto, e que executam um método/ação em comum. 

Permite a criação de familias de objetos relacionados ou dependentes, atraves de uma única interface e sem que a classe concreta seja especificada.

A fábrica pode retornar uma instância de uma das várias classes possíveis (em um hierarquia de subclasse), dependendo dos dados fornecidos a ela.


#### Onde Usar?

- Quando uma classe não pode antecipar que tipo de classe de objeto deve criar.
- Quando você tem classes que são derivadas das mesmas subclasses, ou eles podem na verdade ser classes não relacionadas que apenas compartilham a mesma interface. 


#### Benefícios

- O cliente não precisa conhecer todas as subclasses de objetos que deve criar. Ele só precisa de uma referência à classe / interface abstrata e à fábrica de objetos.
- A fábrica encapsula a criação de objetos. Isso pode ser útil se o processo de criação é muito complexo.
<br>
