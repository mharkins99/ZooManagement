using ZooManagement.Models;
using ZooManagement.Models.Request;

namespace ZooManagement.Repositories

{
    public interface IAnimalsRepo
    {
        Animal GetById(int id);
        Animal Create(AnimalRequest newAnimal);
        List<String> GetSpecies();

    }
    public class AnimalsRepo : IAnimalsRepo
    {
        private readonly ZooDbContext _context;
        public AnimalsRepo(ZooDbContext context)
        {
            _context = context;
        }

        public Animal GetById(int id)
        {
            return _context.Animal
                .Single(animal => animal.Id == id);
        }


        public Animal Create(AnimalRequest newAnimal)
        {
            var insertResponse = _context.Animal.Add(new Animal
            {
                //Id = newAnimal.Id,
                Species = newAnimal.Species,
                Classification = newAnimal.Classification,
                Name = newAnimal.Name,
                Sex = newAnimal.Sex,
                DOB = newAnimal.DOB,
                AcquisitionDate = newAnimal.AcquisitionDate

            });
            _context.SaveChanges();
            return insertResponse.Entity;
        }

        public List<String> GetSpecies()
        {
            return _context.Animal.Select(x => x.Species).Distinct().ToList();
        }
    }
}
