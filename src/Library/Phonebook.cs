using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Añade un nuevo contacto al directorio de contactos.
        /// </summary>
        /// <param name="contacto"></param>
        public Contact AddContact (string name)
        {
            Contact newContact = new Contact(name);
            this.persons.Add(newContact);
            return newContact;
        }

        /// <summary>
        /// Remueve un cotacto del directorio de contacto.
        /// </summary>
        /// <param name="contacto"></param>
        public void RemoveContact (Contact contacto)
        {
            this.persons.Remove (contacto);
        }

        /// <summary>
        /// Envía un email con un cuerpo que se pasa como parámetro, a uno o varios contactos de un directorio.
        /// </summary>
        /// <param name="toList">Lista con los nombres de cotactos.</param>
        /// <param name="channel">Canal para el envío del mensaje.</param>
        /// <param name="message">Cuerpo del email.</param>
        public void Send(string[] toList, IMessageChannel channel, string text)
        {
            Message message;
            List<Contact> sendTo = this.Search(toList);

            foreach (Contact person in sendTo)
            {
                if (channel != null)
                {
                    message = channel.CreateMessage(this.Owner, person, text);
                    message.Text = text;
                    channel.Send(message);
                }
            }
        }
    }
}