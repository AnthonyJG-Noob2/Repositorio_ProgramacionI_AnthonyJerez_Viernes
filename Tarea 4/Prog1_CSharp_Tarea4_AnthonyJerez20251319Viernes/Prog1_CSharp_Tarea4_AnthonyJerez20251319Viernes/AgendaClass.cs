using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactesClassLib;

namespace TheAgendaClass
{
    internal class AgendaClass
    {
        List<ContactesClassLib.Contactes> contact = new();

        public void AddContactES()
        {
            try
            {
                Console.WriteLine("Agregar Contacto");

                int idadded = contact.Count + 1;

                Console.WriteLine("Ingrese un Nombre");
                string nameadded = Console.ReadLine();

                Console.WriteLine("Ingrese un Email/Correo");
                string emailadded = Console.ReadLine();

                Console.WriteLine("Ingrese un Telefono");
                string phoneadded = Console.ReadLine();

                Console.WriteLine("Ingrese una direccion");
                string addressadded = Console.ReadLine();

                contact.Add(new Contactes(idadded, nameadded, emailadded, phoneadded, addressadded));
                Console.WriteLine("El contacto ha sido agregado usuario");
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
           
            
        }

        public void RemoveContactES()
        {
            Console.WriteLine("Escriba el ID que desea eliminar");
            int idseleccionado = 0;
            try
            {
                idseleccionado = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Usuario, Escriba un numero");
            }

            var godoitcon = contact.Find(con=> con.AId == idseleccionado);

            if (godoitcon == null)
            {
                Console.WriteLine("El contacto no esta en la agenda");
            }
            else
            {
                Console.WriteLine("Contacto Encontrado");
            }

            Console.WriteLine("¿Esta seguro segurisimo que desea eliminar este contacto?");
            Console.WriteLine("1: Si, 2:No, cualquier otro numero: No");
            int sureornot = 0;

            try
            {
                sureornot = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Escoga con un numero usuario");
            }

            if (sureornot == 1)
            {
                contact.Remove(godoitcon);
            }
            else
            {
                Console.WriteLine("Ok");
            }
            
        }

        public void ModifyContactES()
        {
            Console.WriteLine("Escriba el ID del que desea modificar los datos");
            int idseleccionado = 0;
            try
            {
                idseleccionado = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Usuario, Escriba un numero");
            }

            var idtomodify = contact.Find(con => con.AId == idseleccionado);

            if (idtomodify == null)
            {
                Console.WriteLine("El contacto no esta en la agenda");
            }

            Console.WriteLine("¿Esta seguro segurisimo que desea modificar este contacto?");
            Console.WriteLine("1: Si, 2:No, cualquier otro numero: No");
            int sureornotMO = 0;
            try
            {
                sureornotMO = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Escriba uno de los numeros que sea opcion");
            }


            if (sureornotMO == 1)
            {
                try
                {
                    Console.WriteLine("Escriba nuevo nombre");
                    string newname = Console.ReadLine();
                    
                    if(newname == "")
                    {
                        Console.WriteLine("Unchanged");
                    }
                    else
                    {
                        idtomodify.AName = newname;
                    }

                        Console.WriteLine("Escriba nuevo Email");
                   string newmail = Console.ReadLine();
                    if (newmail == "")
                    {
                        Console.WriteLine("Unchanged");
                    }
                    else
                    {
                        idtomodify.AEmail = newmail;
                    }

                    Console.WriteLine("Escriba nuevo telefono");
                    string newphone = Console.ReadLine();
                    if (newphone == "")
                    {
                        Console.WriteLine("Unchanged");
                    }
                    else
                    {
                        idtomodify.APhone = newphone;
                    }
                    Console.WriteLine("Escriba nueva Direccion");
                    string newAddress = Console.ReadLine();

                    if (newAddress == "")
                    {
                        Console.WriteLine("Unchanged");
                    }
                    else
                    {
                        idtomodify.AAddress = newAddress;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Usuario, no invente");
                }
                
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }

        public void SearchContactES()
        {

            Console.WriteLine("¿Que desea usar para la busqueda?");
            Console.WriteLine("1-id,  2-nombre,  3-email,  4-telefono");
            int choosenow = 0;
            try
            {
                choosenow = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Opcion o Dato invalido");
            }

            switch (choosenow)
            {
                case 1:

                    Console.WriteLine("Escriba el ID que desea buscar");
                    int idseleccionadoX = 0;
                    try
                    {
                        idseleccionadoX = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Usuario, Escriba un numero");
                    }

                    var idtolookfor = contact.Find(con => con.AId == idseleccionadoX);

                    if (idtolookfor == null)
                    {
                        Console.WriteLine("El contacto no esta en la agenda");
                    }
                    else
                    {
                        Console.WriteLine($"id:{idtolookfor.AId}");
                        Console.WriteLine($"Nombre:{idtolookfor.AName}");
                        Console.WriteLine($"Email:{idtolookfor.AEmail}");
                        Console.WriteLine($"Telefono: {idtolookfor.APhone}");
                        Console.WriteLine($"Direccion:{idtolookfor.AAddress}");
                    }
                    break;

                    case 2:
                    Console.WriteLine("Escriba el nombre que desea buscar");
                    string nameseleccionadoX = Console.ReadLine();
                   

                    var tolookforname = contact.Find(con => con.AName == nameseleccionadoX);

                    if (tolookforname == null)
                    {
                        Console.WriteLine("El contacto no esta en la agenda");
                    }
                    else
                    {
                        Console.WriteLine($"Id:{tolookforname.AId}");
                        Console.WriteLine($"Nombre:{tolookforname.AName}");
                        Console.WriteLine($"Email:{tolookforname.AEmail}");
                        Console.WriteLine($"Telefono: {tolookforname.APhone}");
                        Console.WriteLine($"Direccion:{tolookforname.AAddress}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Escriba el email que desea buscar");
                    string emailseleccionadoX = Console.ReadLine();


                    var tolookforemail = contact.Find(con => con.AName == emailseleccionadoX);

                    if (tolookforemail == null)
                    {
                        Console.WriteLine("El contacto no esta en la agenda");
                    }
                    else
                    {
                        Console.WriteLine($"Id:{tolookforemail.AId}");
                        Console.WriteLine($"Nombre:{tolookforemail.AName}");
                        Console.WriteLine($"Email:{tolookforemail.AEmail}");
                        Console.WriteLine($"Telefono: {tolookforemail.APhone}");
                        Console.WriteLine($"Direccion:{tolookforemail.AAddress}");
                    }
                        break;
                case 4:
                    Console.WriteLine("Escriba la direccion que desea buscar");
                    string phoneseleccionadoX = Console.ReadLine();


                    var tolookforphone = contact.Find(con => con.APhone == phoneseleccionadoX);

                    if (tolookforphone == null)
                    {
                        Console.WriteLine("El contacto no esta en la agenda");
                    }
                    else
                    {
                        Console.WriteLine($"Id:{tolookforphone.AId}");
                        Console.WriteLine($"Nombre:{tolookforphone.AName}");
                        Console.WriteLine($"Email:{tolookforphone.AEmail}");
                        Console.WriteLine($"Telefono: {tolookforphone.APhone}");
                        Console.WriteLine($"Direccion:{tolookforphone.AAddress}");
                    }

                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }

        
        }

        public void ViewContactES()
        {
            Console.WriteLine("Id           Nombre          Telefono            Email           Dirección");
            Console.WriteLine("___________________________________________________________________________");

            

            foreach (var con in contact)
            {
                Console.WriteLine($"{con.AId}    {con.AName}      {con.APhone}      {con.AEmail}     {con.AAddress}");
            }
        }

    }

}
