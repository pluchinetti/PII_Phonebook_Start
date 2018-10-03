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
        public void AddContact (Contact contacto) {
            this.persons.Add (contacto);
        }

        /// <summary>
        /// Remueve un cotacto del directorio de contacto.
        /// </summary>
        /// <param name="contacto"></param>
        public void RemoveContact (Contact contacto) {
            this.persons.Remove (contacto);
        }

        /// <summary>
        /// Envía un email con un cuerpo que se pasa como parámetro, a uno o varios contactos de un directorio.
        /// </summary>
        /// <param name="toList">Lista con los nombres de cotactos.</param>
        /// <param name="email">Objeto Email para el envío.</param>
        /// <param name="message">Cuerpo del email.</param>
        public void SendEmail(string[] toList, Email email, string message)
        {
            List<Contact> contactsE = this.Search(toList);
            foreach (Contact contactE in contactsE) {
                MessageEmail messageE = new MessageEmail (this.Owner.Email, contactE.Email, message);
                email.Send (messageE);
            }
        }

        /// <summary>
        /// Envía un mensaje de Whatsapp con un cuerpo que se pasa como parámetro, a uno o varios contactos de un directorio.
        /// </summary>
        /// <param name="toList">Lista con los nombres de cotactos.</param>
        /// <param name="whatsApp">Objeto WhatsApp para el envío.</param>
        /// <param name="message">Cuerpo del email.</param>
        public void SendWhatsapp(string[] toList, WhatsApp whatsApp, string message)
        {
            List<Contact> contactsW = this.Search (toList);
            foreach (Contact contactW in contactsW) {
                MessageEmail messageW = new MessageEmail (this.Owner.Phone, contactW.Phone, message);
                whatsApp.Send (messageW);
            }
        }
    }
}