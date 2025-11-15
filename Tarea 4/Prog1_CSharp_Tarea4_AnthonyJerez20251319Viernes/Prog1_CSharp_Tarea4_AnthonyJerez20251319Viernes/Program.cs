//using Prog1_CSharp_Tarea4_AnthonyJerez20251319Viernes;
using TheAgendaClass;

Console.WriteLine("Mi Agenda Perrón");

Console.WriteLine("Bienvenido a tu lista de contactes");
AgendaClass TheRealAgenda = new AgendaClass();

bool running = true;
while (running)
{
    Console.Write("1. Agregar Contacto      ");
    Console.Write("2. Ver Contactos     ");
    Console.Write("3. Buscar Contactos      ");
    Console.Write("4. Modificar Contacto        ");
    Console.Write("5. Eliminar Contacto     ");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");

    int choice = 0;
    try
    {
         choice = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {

        Console.WriteLine("Escriba un numero");
    }
    

    switch (choice)
    {
        case 1:
            TheRealAgenda.AddContactES();
            break;
        case 2:
            TheRealAgenda.ViewContactES();
            break;
        case 4:
            TheRealAgenda.ModifyContactES();
            break;
        case 5:
            TheRealAgenda.RemoveContactES();
            break;
        case 3: //esto es intencional, no importa el orden en que pongan los cases, pero, traten de ser siempre lo mas ordenados posible
            TheRealAgenda.SearchContactES();
            break;
        case 6:
            Console.WriteLine("Pase buen dia, Usuario");
            running = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    
}

