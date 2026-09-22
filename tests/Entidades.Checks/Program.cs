using DTOs.Mappers;
using Obligatorio.LogicaNegocio.CustomExceptions.Genericas;
using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.ValueObjects.VOUsuario;

var verificaciones = 0;

void Verificar(bool condicion, string mensaje)
{
    if (!condicion) throw new Exception(mensaje);
    verificaciones++;
}

void Rechazar<T>(string? valor) where T : Exception
{
    try { _ = new UsuarioContrasenia(valor!); }
    catch (T) { verificaciones++; return; }
    throw new Exception($"Se esperaba {typeof(T).Name}.");
}

Rechazar<DatoVacioException>(null);
Rechazar<DatoVacioException>("");
Rechazar<DatoVacioException>("   ");
Rechazar<ContraseniaInvalidaException>("Ab1!");
Rechazar<ContraseniaInvalidaException>("abcdef1!");
Rechazar<ContraseniaInvalidaException>("ABCDEF1!");
Rechazar<ContraseniaInvalidaException>("Abcdefg!");
Rechazar<ContraseniaInvalidaException>("Abcdefg1");
var contrasenia = new UsuarioContrasenia("Abcdef1!");
Verificar(contrasenia.Valor == "Abcdef1!", "Una contraseña válida debe conservar su valor.");
Verificar(typeof(UsuarioContrasenia).GetConstructor(Type.EmptyTypes) is null,
    "No debe existir un constructor público que omita la validación.");
Verificar(typeof(UsuarioContrasenia).GetProperty("Valor")!.SetMethod!.IsPrivate,
    "No debe permitirse sobrescribir el valor validado desde afuera.");

var usuario = new Usuario { Contrasenia = contrasenia };
usuario.Lecturas.Add(new Lectura());
usuario.Auditorias.Add(new Auditoria());
Verificar(new Usuario().Lecturas.Count == 0 && new Usuario().Auditorias.Count == 0,
    "Las colecciones de usuarios no deben compartirse.");
var historia = new Historia();
historia.Categorias.Add(new Categoria());
historia.Capitulos.Add(new Final());
historia.Lecturas.Add(new Lectura());
historia.Auditorias.Add(new Auditoria());
Verificar(new Historia().Categorias.Count == 0 && new Historia().Capitulos.Count == 0
    && new Historia().Lecturas.Count == 0 && new Historia().Auditorias.Count == 0,
    "Las colecciones de historias no deben compartirse.");
var categoria = new Categoria();
categoria.Historias.Add(historia);
Verificar(new Categoria().Historias.Count == 0, "Las categorías necesitan listas independientes.");
var intermedio = new Intermedio();
var dtoVacio = MapperIntermedio.ToDtoIntermedio(intermedio);
Verificar(dtoVacio.Opciones.Count == 0, "Mapear un capítulo sin opciones no debe fallar.");
intermedio.Opciones.Add(new Opcion { Texto = "Continuar", CapituloOrigen = intermedio, CapituloDestino = new Final() });
Verificar(MapperIntermedio.ToDtoIntermedio(intermedio).Opciones.Count == 1,
    "El mapper debe conservar las opciones del capítulo.");
Verificar(new Intermedio().Opciones.Count == 0, "Las opciones no deben compartirse entre capítulos.");
Verificar(new Lectura().Final is null && new Lectura().FechaFinalizacion is null,
    "Una lectura nueva todavía no tiene final.");
Console.WriteLine($"{verificaciones} verificaciones correctas.");
