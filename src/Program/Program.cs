using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact owner = new Contact("Tomás");
            owner.Phone = "+14155238886";
            owner.Email = "<<Ingresar email>>";

            Phonebook ownerPB = new Phonebook(owner);

            // Agregar contactos a la lista
            Contact pablo = ownerPB.AddContact("Pablo");
            pablo.Phone = "+5989";
            pablo.Email = "<<Ingresar email>>";

            Contact guille = ownerPB.AddContact("Guille");
            guille.Phone = "+5989";
            guille.Email = "<<Ingresar email>>";

            // Enviar un correo a algunos contactos
            ownerPB.Send(new String[] { "Pablo","Guille" }, new ChannelEmail(), "Probando el envío de email :)");

            // Enviar un WhatsApp a algunos contactos
            ownerPB.Send(new String[] { "Pablo","Guille" }, new ChannelWhatsApp(), "Probando el envío de WhatsApp :)");
        }
    }
}
