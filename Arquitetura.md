RazorProject/
│
├── RazorProject.Api/
│   ├── Controllers/
│   │   ├── ChamadosController.cs
│   │   └── CategoriasController.cs
│   │
│   ├── DTOs/
│   │   ├── ChamadoCreateDto.cs
│   │   ├── ChamadoUpdateDto.cs
│   │   ├── ChamadoListDto.cs
│   │   ├── ChamadoDetailsDto.cs
│   │   └── CategoriaDto.cs
│   │
│   ├── Models/
│   │   ├── Chamado.cs
│   │   ├── Categoria.cs
│   │   └── Enums/
│   │       ├── StatusChamado.cs
│   │       └── Prioridade.cs
│   │
│   ├── Services/
│   │   ├── Interfaces/
│   │   │   ├── IChamadoService.cs
│   │   │   └── ICategoriaService.cs
│   │   ├── ChamadoService.cs
│   │   └── CategoriaService.cs
│   │
│   ├── Repositories/
│   │   ├── Interfaces/
│   │   │   ├── IChamadoRepository.cs
│   │   │   └── ICategoriaRepository.cs
│   │   ├── ChamadoRepository.cs
│   │   └── CategoriaRepository.cs
│   │
│   ├── Data/
│   │   ├── AppDbContext.cs
│   │   └── SeedData.cs
│   │
│   ├── Migrations/
│   ├── appsettings.json
│   └── Program.cs
│
└── RazorProject.Front/
    ├── Controllers/
    │   └── ChamadosController.cs
    │
    ├── ViewModels/
    │   ├── ChamadoCreateViewModel.cs
    │   ├── ChamadoEditViewModel.cs
    │   ├── ChamadoListViewModel.cs
    │   ├── ChamadoDetailsViewModel.cs
    │   └── CategoriaViewModel.cs
    │
    ├── Services/
    │   ├── Interfaces/
    │   │   ├── IChamadoApiService.cs
    │   │   └── ICategoriaApiService.cs
    │   ├── ChamadoApiService.cs
    │   └── CategoriaApiService.cs
    │
    ├── Views/
    │   └── Chamados/
    │       ├── Index.cshtml
    │       ├── Create.cshtml
    │       ├── Edit.cshtml
    │       ├── Details.cshtml
    │       └── Delete.cshtml
    │
    ├── wwwroot/
    │   ├── css/
    │   │   └── site.css
    │   └── js/
    │       └── site.js
    │
    ├── appsettings.json
    └── Program.cs