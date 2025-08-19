using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleRegistrationApi.Services
{
    public class PersonService
    {
        private readonly List<Person> _people = new List<Person>();

        public Person AddPerson(Person person)
        {
            person.CreatedAt = DateTime.UtcNow;
            person.UpdatedAt = DateTime.UtcNow;
            _people.Add(person);
            return person;
        }

        public Person UpdatePerson(int id, Person updatedPerson)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person == null) return null;

            person.Name = updatedPerson.Name;
            person.Gender = updatedPerson.Gender;
            person.Email = updatedPerson.Email;
            person.DateOfBirth = updatedPerson.DateOfBirth;
            person.Nationality = updatedPerson.Nationality;
            person.Identification = updatedPerson.Identification;
            person.UpdatedAt = DateTime.UtcNow;

            return person;
        }

        public bool DeletePerson(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person == null) return false;

            _people.Remove(person);
            return true;
        }

        public Person GetPerson(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _people;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            // Replace the following line with your actual data access logic
            return await Task.FromResult(new List<Person>());
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            // Replace with your actual data access logic
            // For example, if you have a DbContext:
            // return await _context.People.FindAsync(id);

            // Placeholder implementation:
            return await Task.FromResult<Person>(null);
        }

        public async Task<Person> AddAsync(Person person)
        {
            // Replace with your actual data persistence logic
            // For example, if using Entity Framework:
            // _context.People.Add(person);
            // await _context.SaveChangesAsync();
            // return person;

            // Placeholder implementation:
            await Task.CompletedTask;
            return person;
        }
    
        public static void UpdateAsync(Person person)
        {
            // TODO: Implement update logic here, e.g., update in database context and save changes
            // Example:
            // _people.People.Update(person);
            // await _people.SaveChangesAsync();
        }
    }
}