//programa que permita visualizar los departamentos de nicaragua con
//su cantidad poblacional 
//Encuentra el mayor, menor, sumas y ordene los datos 
using Departamentos;
//Lista de departamentos
List<depto> isDeptos= new List<>();
{
    new depto("Boaco",185013);
    new depto("Carazo",197139);
    new depto("Chinandega",439906);
    new depto("Chontales",190863);
    new depto("Costa Caribe Norte",530586);
    new depto("Costa Caribe sur",414543);
    new depto("Esteli",229866);
    new depto("Granada",214317);
    new depto("Jinotega",475630);
    new depto("Leon",421050);
    new depto("Madrid",174744);
    new depto("Managua",1546939);
    new depto("Masaya",391903);
    new depto("Matagalpa",593503);
    new depto("Nueva Segovia",271581);
    new depto("Rio San Juan",135446);
    new depto("Rivas",182645);
}
//Encontrar el mayor y el menor (poblacion)
depto mindepto = IstDepto.OrderBy(d =>d.populacion).Fist();
depto maxdepto = IstDepto.OrderBy(d =>d.populacion).Last();
//Ordenar los departamentos 
var DeptOrdenado =isDeptos.OrderBy(d =>d.populacion);
//Mostrar departamentos ordenados
foreach (var item in DepOrdenado);
    Console.WriteLine($"{item.Name,-20}==>{item.population,10:NO}");
//
}
}

}
