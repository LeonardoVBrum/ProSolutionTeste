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

