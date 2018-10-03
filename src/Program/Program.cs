using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact owner = new Contact("Tomás","+14155238886","tomasorindelafuente11@gmail.com");
            Phonebook ownerPB = new Phonebook(owner);

            // Crear la lista de contactos
            //Contact guille = new Contact("Guille","+59898242410","guillevogel11@gmail.com");
            Contact guille = new Contact("Pablo","+59894585797","pluchinetti@live.com");
            Contact julio = new Contact("Julio","+59891776197","jcsl19@hotmail.com");

            // Agregar contactos a la lista
            ownerPB.AddContact(guille);
            ownerPB.AddContact(julio);

            // Enviar un correo a algunos contactos
            ownerPB.SendEmail (new String[] { "Pablo" }, new Email (), "Probando el envío de email :)");

            // Enviar un WhatsApp a algunos contactos
            ownerPB.SendWhatsapp (new String[] { "Pablo" }, new WhatsApp (), "Probando el envío de WhatsApp :)");
            // Enviar un SMS a algunos contactos
        }
    }
}
