# 📋 Task Manager API - C# (.NET 8)

API REST para gerenciamento de tarefas desenvolvida em **C#** demonstrando **Programação Orientada a Objetos (POO)**.

[![C#](https://img.shields.io/badge/C%23-12-purple)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![SQLite](https://img.shields.io/badge/SQLite-3-green)](https://www.sqlite.org/)

---

## 🎯 Objetivo

Projeto desenvolvido para demonstrar conhecimentos em **POO usando C#** para vaga de **Estágio Backend - Claps**.

---

## 📚 Conceitos de POO Demonstrados

### 1. ✅ **Classes e Objetos**
```csharp
public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    // ...
}
```

### 2. ✅ **Encapsulamento**
```csharp
public class User : Person
{
    public string Role { get; set; } = "Developer";
    private List<Task> _tasks = new();
    
    public int GetPendingTasksCount()
    {
        return _tasks.Count(t => t.Status == TaskStatus.Pending);
    }
}
```

### 3. ✅ **Herança**
```csharp
public abstract class Person  // Classe base
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class User : Person  // User herda de Person
{
    public string Role { get; set; }
}
```

### 4. ✅ **Polimorfismo**
```csharp
public abstract class Person
{
    public virtual string GetInfo()  // Método virtual
    {
        return $"{Name} ({Email})";
    }
}

public class User : Person
{
    public override string GetInfo()  // Override
    {
        return $"{Name} - {Role} ({Email})";
    }
}
```

### 5. ✅ **Abstração (Interfaces)**
```csharp
public interface ITaskService
{
    Task<List<Task>> GetAllTasksAsync();
    Task<Task> CreateTaskAsync(Task task);
    // ...
}

public class TaskService : ITaskService
{
    // Implementação dos métodos
}
```

### 6. ✅ **Enums**
```csharp
public enum TaskStatus
{
    Pending,
    InProgress,
    Completed,
    Cancelled
}
```

---

## 🏗️ Estrutura do Projeto

```
TaskManager/
├── Models/
│   ├── Task.cs           # Entidade principal
│   └── User.cs           # Herança de Person
│
├── Services/
│   ├── ITaskService.cs   # Interface (abstração)
│   └── TaskService.cs    # Implementação
│
├── Controllers/
│   └── TasksController.cs  # REST API
│
├── Data/
│   └── AppDbContext.cs   # Entity Framework
│
├── Program.cs            # Entry point
└── TaskManager.csproj    # Projeto
```

---

## 🚀 Como Rodar

### Pré-requisitos
- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

### Passos

```bash
# 1. Navegue até a pasta
cd taskmanager-csharp

# 2. Restaure dependências
dotnet restore

# 3. Execute o projeto
dotnet run

# 4. Acesse a API
# Swagger UI: http://localhost:5000
```

---

## 📊 Endpoints da API

### Tasks

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| `GET` | `/api/tasks` | Lista todas as tarefas |
| `GET` | `/api/tasks/{id}` | Busca tarefa por ID |
| `POST` | `/api/tasks` | Cria nova tarefa |
| `PUT` | `/api/tasks/{id}` | Atualiza tarefa |
| `DELETE` | `/api/tasks/{id}` | Remove tarefa |
| `GET` | `/api/tasks/user/{userId}` | Tarefas de um usuário |
| `GET` | `/api/tasks/overdue` | Tarefas atrasadas |

---

## 📝 Exemplos de Uso

### Criar uma Tarefa

```bash
POST /api/tasks
Content-Type: application/json

{
  "title": "Estudar C# POO",
  "description": "Revisar conceitos de herança e polimorfismo",
  "priority": 2,
  "dueDate": "2024-03-15",
  "assignedUserId": 1
}
```

### Listar Todas as Tarefas

```bash
GET /api/tasks
```

**Resposta:**
```json
[
  {
    "id": 1,
    "title": "Implementar API de Usuários",
    "description": "Criar endpoints REST",
    "status": 1,
    "priority": 2,
    "createdAt": "2024-02-09T10:00:00",
    "dueDate": "2024-02-16T10:00:00",
    "assignedUser": {
      "id": 1,
      "name": "João Silva",
      "email": "joao@claps.com",
      "role": "Developer"
    }
  }
]
```

---

## 🎓 O que este projeto demonstra?

✅ **Conhecimento básico em POO usando C#**
- Classes, Objetos, Properties
- Herança (User herda Person)
- Polimorfismo (Override de métodos)
- Interfaces (ITaskService)
- Encapsulamento (Properties privadas)
- Abstração (Classes abstratas)

✅ **Organização de Código**
- Separação em camadas (Models, Services, Controllers)
- Código limpo e bem documentado
- Nomenclatura clara

✅ **Boas Práticas**
- Injeção de Dependência
- Async/Await
- DTOs para separar request/response
- Entity Framework (ORM)

✅ **API REST**
- Endpoints CRUD completos
- Swagger para documentação
- Status codes corretos

---

## 💡 Conceitos Extras

### Async/Await
```csharp
public async Task<List<Task>> GetAllTasksAsync()
{
    return await _context.Tasks.ToListAsync();
}
```

### LINQ (Query)
```csharp
public async Task<List<Task>> GetOverdueTasksAsync()
{
    return await _context.Tasks
        .Where(t => t.DueDate < DateTime.Now)
        .ToListAsync();
}
```

### Injeção de Dependência
```csharp
public class TaskService : ITaskService
{
    private readonly AppDbContext _context;
    
    public TaskService(AppDbContext context)
    {
        _context = context;  // Injetado
    }
}
```

---

## 📁 Arquivos Principais

### Models/Task.cs
- Entidade principal
- Demonstra: Classes, Properties, Métodos, Enums

### Models/User.cs
- Demonstra: Herança, Polimorfismo, Override

### Services/ITaskService.cs
- Demonstra: Interfaces, Abstração

### Services/TaskService.cs
- Demonstra: Implementação de Interface, Async/Await, LINQ

### Controllers/TasksController.cs
- Demonstra: REST API, HTTP Methods, DTOs

---

## 🚀 Próximos Passos (Melhorias Futuras)

- [ ] Adicionar autenticação JWT
- [ ] Implementar paginação
- [ ] Adicionar filtros avançados
- [ ] Criar testes unitários
- [ ] Adicionar validações com FluentValidation

---

## 📚 Tecnologias Utilizadas

- **C# 12** - Linguagem
- **.NET 8** - Framework
- **ASP.NET Core** - Web API
- **Entity Framework Core** - ORM
- **SQLite** - Banco de dados
- **Swagger** - Documentação da API

---

## 👤 Autor

**Yasmim Passos**  
📧 passosyasmim08@gmail.com  
💼 [LinkedIn](https://www.linkedin.com/in/yasmim-passos-037676212/)

---

## 📄 Licença

MIT License - Projeto educacional
