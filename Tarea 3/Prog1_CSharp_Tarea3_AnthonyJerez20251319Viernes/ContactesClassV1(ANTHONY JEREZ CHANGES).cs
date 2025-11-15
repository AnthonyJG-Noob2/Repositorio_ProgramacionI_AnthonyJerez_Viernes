Console.WriteLine("Bienvenido a mi lista de Contactes");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            {
                AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 2:
            {
                WannaSeeContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 3:
            SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 4:
            ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 5:
            DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Tu eres o te haces el idiota?");
            break;
    }
}


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Digite la edad de la persona en números");
    int age = 0;
    try
    {
        age = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {

        Console.WriteLine("Es una edad numerica que debe escribir");
    }

    Console.WriteLine("Especifique si es mejor amigo: 0.No, 1.Yes");

    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);
}

static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Seleccione un ID");
    int idseleccionado = int.Parse(Console.ReadLine());
    Console.WriteLine("¿Esta seguro? 1.si, 2.no");
    int youroption = int.Parse(Console.ReadLine());

    int newages = 0;
    if (youroption == 1)
    {
        try
        {
            Console.WriteLine("Digite el nuevo nombre");
            string nuevonombre = Console.ReadLine();
            Console.WriteLine("Digite el nuevo apellido");
            string nuevolastname = Console.ReadLine();
            Console.WriteLine("Digite la nueva direccion");
            string nuevoaddress = Console.ReadLine();
            Console.WriteLine("Digite el nuevo telefono");
            string nuevonumerodecel = Console.ReadLine();
            Console.WriteLine("Digite el nuevo email/correo");
            string nuevoemail = Console.ReadLine();
            Console.WriteLine("Digite la nueva edad");
            newages = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool isitafriend = Convert.ToBoolean(Console.ReadLine());

            if (nuevonombre != "")
            {
                names[idseleccionado] = nuevonombre;
            }
            if (nuevolastname != "")
            {
                lastnames[idseleccionado] = nuevolastname;
            }
            if (nuevoaddress != "")
            {
                addresses[idseleccionado] = nuevoaddress;
            }
            if (nuevonumerodecel != "")
            {
                telephones[idseleccionado] = nuevonumerodecel;
            }
            if (nuevoemail != "")
            {
                emails[idseleccionado] = nuevoemail;
            }
            if (newages > 0)
            {
                ages[idseleccionado] = newages;
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine("Error");
            return;
        }
    }
    else
    {
        Console.WriteLine("ok");
    }

}

static void WannaSeeContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
    Console.WriteLine($"____________________________________________________________________________________________________________________________");
    foreach (var id in ids)
    {
        bool isBestFriend;
        if (!bestFriends.TryGetValue(id, out isBestFriend))
        {
            isBestFriend = false; // default value if the key was deleted
        }

        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
    }
}

static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{

    Console.WriteLine("Seleccione un ID");
    int idseleccionado = 0;
    try
    {
        idseleccionado = int.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {

        Console.WriteLine("Error");
    }

    Console.WriteLine("¿Esta seguro? 1.si, 2.no");
    int youroption = int.Parse(Console.ReadLine());

    if (youroption == 1)
    {
        ids.RemoveAt(idseleccionado - 1);
        names.Remove(idseleccionado);
        lastnames.Remove(idseleccionado);
        addresses.Remove(idseleccionado);
        telephones.Remove(idseleccionado);
        emails.Remove(idseleccionado);
        ages.Remove(idseleccionado);
        bestFriends.Remove(idseleccionado);
    }
    else
    {
        Console.WriteLine("Hubo un Problema");
    }

}

static void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("¿Por cual campo desea buscar?");
    Console.WriteLine("1.id, 2.nombre, 3.apellido, 4.direccion, 5.telefono, 6.email");
    int timetochose = 1;

    try
    {
        timetochose = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {

        Console.WriteLine("Usuario, escriba un numero");
    }

    if (timetochose == 1)
    {
        Console.WriteLine("Seleccione un ID");
        int idseleccionado = 0;
        try
        {
            idseleccionado = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {

            Console.WriteLine("Error");
        }
        try
        {
            Console.WriteLine("");
            string nameselected = names[idseleccionado];
            string lastnamesel = lastnames[idseleccionado];
            string adressesselected = addresses[idseleccionado];
            string selectedphone = telephones[idseleccionado];
            string emailselected = emails[idseleccionado];
            bool isfriend = bestFriends.ContainsKey(idseleccionado);
            Console.WriteLine("");


            Console.WriteLine($"Nombre : {nameselected}");
            Console.WriteLine($"Apellido :{lastnamesel}");
            Console.WriteLine($"Direccion :{adressesselected}");
            Console.WriteLine($"Telefono :{selectedphone}");
            Console.WriteLine($"Email :{emailselected}");
            Console.WriteLine($"¿Es amigo?:{isfriend}");
        }
        catch (Exception Ex2)
        {

            Console.WriteLine("Id o dato invalido");
        }

    }
    else if (timetochose == 2)
    {
        Console.WriteLine("Escriba un nombre");
        string selectedname = Console.ReadLine();

        var searchingproccess = names.FirstOrDefault(na =>
        string.Equals(na.Value, selectedname, StringComparison.OrdinalIgnoreCase));

        if (!searchingproccess.Equals(default(KeyValuePair<int, string>)))
        {
            int thereistheid = searchingproccess.Key;
            string nameis = searchingproccess.Value;
            Console.WriteLine($"nombre:{nameis}");
            Console.WriteLine($"apellido:{lastnames[thereistheid]}");
            Console.WriteLine($"Direccion :{addresses[thereistheid]}");
            Console.WriteLine($"Telefono :{telephones[thereistheid]}");
            Console.WriteLine($"Email :{emails[thereistheid]}");
            Console.WriteLine($"¿Es amigo?:{bestFriends[thereistheid]}");
        }
        else
        {
            Console.WriteLine("No se encontro el contacto");
        }
    }
    else if (timetochose == 3)
    {
        Console.WriteLine("Escriba un apellido");
        string selectedlastname = Console.ReadLine();

        var searchingproccessB = lastnames.FirstOrDefault(la =>
        string.Equals(la.Value, selectedlastname, StringComparison.OrdinalIgnoreCase));

        if (!searchingproccessB.Equals(default(KeyValuePair<int, string>)))
        {
            int thereistheid = searchingproccessB.Key;
            string lastnameis = searchingproccessB.Value;
            Console.WriteLine($"nombre:{names[thereistheid]}");
            Console.WriteLine($"apellido:{lastnameis}");
            Console.WriteLine($"Direccion :{addresses[thereistheid]}");
            Console.WriteLine($"Telefono :{telephones[thereistheid]}");
            Console.WriteLine($"Email :{emails[thereistheid]}");
            Console.WriteLine($"¿Es amigo?:{bestFriends[thereistheid]}");
        }
        else
        {
            Console.WriteLine("No se encontro el contacto");
        }
    }
    else if (timetochose == 4)
    {

        Console.WriteLine("Escriba una Direccion");
        string selectedaddress = Console.ReadLine();

        var searchingproccessC = lastnames.FirstOrDefault(la =>
        string.Equals(la.Value, selectedaddress, StringComparison.OrdinalIgnoreCase));

        if (!searchingproccessC.Equals(default(KeyValuePair<int, string>)))
        {
            int thereistheid = searchingproccessC.Key;
            string addressesis = searchingproccessC.Value;
            Console.WriteLine($"nombre:{names[thereistheid]}");
            Console.WriteLine($"apellido:{lastnames[thereistheid]}");
            Console.WriteLine($"Direccion :{addressesis}");
            Console.WriteLine($"Telefono :{telephones[thereistheid]}");
            Console.WriteLine($"Email :{emails[thereistheid]}");
            Console.WriteLine($"¿Es amigo?:{bestFriends[thereistheid]}");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado");
        }
    }
    else if (timetochose == 5)
    {

        Console.WriteLine("Escriba un telefono");
        string selectedphone = Console.ReadLine();

        var searchingproccessC2 = telephones.FirstOrDefault(ph =>
        string.Equals(ph.Value, selectedphone, StringComparison.OrdinalIgnoreCase));

        if (!searchingproccessC2.Equals(default(KeyValuePair<int, string>)))
        {
            int thereistheid = searchingproccessC2.Key;
            string telephonesis = searchingproccessC2.Value;
            Console.WriteLine($"nombre:{names[thereistheid]}");
            Console.WriteLine($"apellido:{lastnames[thereistheid]}");
            Console.WriteLine($"Direccion :{addresses[thereistheid]}");
            Console.WriteLine($"Telefono :{telephonesis}");
            Console.WriteLine($"Email :{emails[thereistheid]}");
            Console.WriteLine($"¿Es amigo?:{bestFriends[thereistheid]}");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado");
        }
    }
    else if (timetochose == 6)
    {

        Console.WriteLine("Escriba un Email");
        string selectedmail = Console.ReadLine();

        var searchingproccessD = emails.FirstOrDefault(ma =>
        string.Equals(ma.Value, selectedmail, StringComparison.OrdinalIgnoreCase));

        if (!searchingproccessD.Equals(default(KeyValuePair<int, string>)))
        {
            int thereistheid = searchingproccessD.Key;
            string emailsis = searchingproccessD.Value;
            Console.WriteLine($"nombre:{names[thereistheid]}");
            Console.WriteLine($"apellido:{lastnames[thereistheid]}");
            Console.WriteLine($"Direccion :{addresses[thereistheid]}");
            Console.WriteLine($"Telefono :{telephones[thereistheid]}");
            Console.WriteLine($"Email :{emailsis}");
            Console.WriteLine($"¿Es amigo?:{bestFriends[thereistheid]}");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado");
        }
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }

    // that`s it
    // Anthony Jerez (i just changed some stuff) (20251319)
}