# Verificaciones de entidades

Requiere .NET 10. Desde la raíz del repositorio:

```sh
dotnet build ObligatorioProgramacion3.slnx
dotnet run --project tests/Entidades.Checks/Entidades.Checks.csproj
```

El programa termina con un código distinto de cero si falla alguna comprobación.
Verifica las reglas de contraseña, el acceso restringido a su construcción,
las colecciones independientes y el mapeo de capítulos con y sin opciones.

Estas comprobaciones no prueban persistencia ni autenticación. El value object
valida la complejidad de la contraseña; no genera un hash.
