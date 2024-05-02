using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220088.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private static List<Mahasiswa> DataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Irji","1302220088", new List<string>(new[]{"KPL","pbo","ux"}),2024),
            new Mahasiswa("Dafa","130812225", new List<string>(new[]{"KPL","pbo","ux"}),2024),
            new Mahasiswa("Mikail","081224567", new List<string>(new[]{"KPL","pbo","ux"}),2024),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {    
          return DataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id) {  return DataMahasiswa[id];}

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            DataMahasiswa.Add(mahasiswa);
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Mahasiswa mahasiswa) 
        {
            DataMahasiswa[id] = mahasiswa;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataMahasiswa.RemoveAt(id);
        }

    }
}
