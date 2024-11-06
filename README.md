# Documentação da API - Desafio ProSolutions

## Descrição

Essa API foi desenvolvida para realizar upload e download de arquivos. Ela possui os seguintes dois endpoints:

1. **Upload de Arquivo**
2. **Download de Arquivo**

---

## Endpoints da API

### 1. **Upload de Arquivo**

- **Método HTTP**: `POST`
- **Endpoint**: `/api/arquivos/upload`
- **Descrição**: Envia um arquivo para o servidor, com validações de tipo e tamanho.
- **Requisição**: `multipart/form-data`
  
#### Parâmetros:
- **Campo de chave**: `file`
- **Valor**: Selecione o arquivo que deseja fazer upload.

#### Resposta:
Em caso de sucesso:
```json
{
  "CaminhoArquivo": "Caminho/do/arquivo/no/servidor"
}
Erros Comuns:
400 Bad Request:
Nenhum arquivo enviado.
Arquivo de tipo inválido (.exe, .bat).
Arquivo maior que 10MB.
2. Download de Arquivo
Método HTTP: GET
Endpoint: /api/arquivos/baixar/{id}
Descrição: Faz o download de um arquivo já enviado ao servidor, identificado pelo seu id.
Parâmetros:
id: O ID do arquivo no banco de dados.
Resposta:
Retorna o conteúdo do arquivo como um array de bytes, permitindo o download do arquivo.
Erros Comuns:
404 Not Found: Arquivo não encontrado.
Dependências do Projeto
.NET Framework 4.5 ou superior
Entity Framework: Para interação com o banco de dados.
System.Web: Para manipulação de arquivos e requisições HTTP.
System.IO: Para leitura e gravação de arquivos no sistema.
Como Rodar o Projeto
Clone este repositório para sua máquina local.
Abra o projeto no Visual Studio.
Restaure os pacotes NuGet necessários.
Execute o projeto em seu ambiente local.
A API estará disponível no URL configurado (geralmente http://localhost:5000 ou similar).
Use o Postman ou outro cliente HTTP para testar os endpoints.
Testando a API
Testando o Upload de Arquivo
No Postman, selecione o método POST.
Defina a URL como: http://localhost:5000/api/arquivos/upload.
Selecione a aba Body.
Selecione form-data.
No campo de chave, insira file.
No valor, clique em Choose Files e selecione o arquivo a ser enviado.
Envie a requisição.
Resposta esperada:

json
Copiar código
{
  "CaminhoArquivo": "Caminho/do/arquivo/no/servidor"
}
Testando o Download de Arquivo
No Postman, selecione o método GET.
Defina a URL como: http://localhost:5000/api/arquivos/baixar/{id}.
Substitua {id} pelo ID do arquivo que você deseja baixar.
Envie a requisição.
Resposta esperada:

O arquivo será retornado como um arquivo binário para download.
