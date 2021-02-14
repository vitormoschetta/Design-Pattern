## Command

Em uma API Web, por exemplo, ao invés de expormos vários _end-points_ (um para cada objeto), deixamos apenas um método recebendo um _Command_.

_Command_ seria um objeto que contém em suas propriedades identificadores suficientes para que possamos tomar decisões com base neles.

Exemplificando, observe o código abaixo:
```
public Customer GetCustomer(string doc)
{
    return repository.getCustomer(doc);
}

public Provider GetProvider(string doc)
{
    return repository.getProvider(doc);
}
``` 

No exemplo acima temos dois _end-points_, um para consultar um determinado cliente/customer, outro para consultar um determinado fornecedor/provider.

Utilizando o Pattern Command, poderíamos fazer assim:

```
public ICommandResult Get(ICommand command)
{
    if (command.type == "customer")
        return repository.getCustomer(command.doc);
    if (command.type == "provider")
        return repository.getProvider(command.doc);
}
``` 

E nossa classe _command_ poderia ter a seguinte estrutura:
```
public class Command
{
    string type;
    string doc;
}
``` 