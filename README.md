# BACK-END STREAMER TEST

Este é o desenvolvimento da API solicitada no teste [STREAMER TEST](https://github.com/jpmendonca/streamertest).
Este projeto foi executado utilizando a estrutura e versões de ferramentas conforme solicitado.

Após baixar / clonar o repositório, execute o arquivo `SS-API.sln` para abertura do projeto.

Para iniciar a aplicação utilize `SS_API` conforme imagem abaixo.

![server](https://user-images.githubusercontent.com/37385246/117552329-0806ba00-b021-11eb-8d5f-734a6334f10a.png)

No Package Manager Console, ou CLI, para criar uma nova _migration_ execute o comando `add-migration _nome_da_migration` e posteriormente execute `update-database` para atualizar o banco de dados e executar as configurações da _migration_.

## ESTRUTURA DO PROJETO
### Pastas
Conforme solicitado, a estrutura de pastas foi mantida

**./Data**
Contexto do banco de dados

**./Model**
Modelagem do banco de dados

**./Services**
Classes de serviços de acesso ao banco de dados

**./SS_DB.db**
Sqlite DB.

### Pastas criadas
No entanto para melhor organização, e de acordo com proposto na descrição do teste, foram criadas algumas pastas e subpastas no projeto.

**./Controllers**
Classes para expor os recursos para os usuários finais através de requisições Http.

**./Repositories**
Camada para acesso ao contexto, desacoplando este acesso da camada de serviço.

**./Data/Mappings**
Classes de mapeamento das entidades do dbContext.

**./Model/Enum**
Organização das classes da model e _enums_ utilizados nestas classes.

**./Services/DTO**
Classes para mapear informações da camada model e expor para visualização, para não expor diretamente o contexto.

**./Services/Interfaces**
Interfaces dos métodos da camada de serviço.

## IMAGENS DO PROJETO

![image](https://user-images.githubusercontent.com/37385246/117550040-5cf00380-b014-11eb-9983-30bbaab85a10.png)

![image](https://user-images.githubusercontent.com/37385246/117550083-9f194500-b014-11eb-9d0c-f105fac769a3.png)
