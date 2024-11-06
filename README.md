# Desafio ProSolutions API

## Descrição

Esta API foi desenvolvida como parte do desafio ProSolutions, com o objetivo de permitir o **upload** e **download** de arquivos. A solução foi construída com **ASP.NET Web API** e possui validações de tipo de arquivo, tamanho e caminho de armazenamento. O projeto usa o **Entity Framework** para interagir com o banco de dados.

## Funcionalidades

A API oferece os seguintes endpoints:

### 1. **Upload de Arquivo**
   - **Método HTTP**: `POST`
   - **Endpoint**: `/api/arquivos/upload`
   - **Descrição**: Envia um arquivo para o servidor.

   **Requisição**:
   - Tipo de corpo: `multipart/form-data`
   - Campo de chave: `file`
   - Valor: Selecione o arquivo desejado para upload.

   **Exemplo de Requisição** (Postman):
   - Método: `POST`
   - URL: `http://localhost:porta/api/arquivos/upload`
   - Tipo de corpo: `form-data`
   - Campo chave: `file`
   - Valor: Selecione um arquivo no seu computador.

   **Resposta**:
   ```json
   {
     "CaminhoArquivo": "/path/to/file"
   }
