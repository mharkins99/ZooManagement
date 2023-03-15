using ZooManagement.Models;

namespace ZooManagement.Models.Response
{
    public class AnimalResponse
    {
        private readonly Animal _animal;

        public AnimalResponse(Animal animal)
        {
            _animal = animal;
        }
        public int Id => _animal.Id;
        public string Species => _animal.Species;
        public string Classification => _animal.Classification;
        public string Name => _animal.Name;
        public string Sex => _animal.Sex;
        public DateTime DOB => _animal.DOB;
        public DateTime AcquisitionDate => _animal.AcquisitionDate;
    }
}

