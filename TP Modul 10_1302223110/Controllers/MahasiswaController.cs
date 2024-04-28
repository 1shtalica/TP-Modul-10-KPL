using Microsoft.AspNetCore.Mvc;

namespace TP_Modul_10_1302223110.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Adib Faizulhaq Armadhani", "1302223110"),
        new Mahasiswa(" Kevin Albany Junaidi", "1302223027"),
        new Mahasiswa(" Adrian Fahren Setiawan", "1302220018"),
        new Mahasiswa(" Muhammad Farhan Ismali Fentarto" , "1302220046"),
        new Mahasiswa(" Rindang Bani Isyan", "1302223023")
    };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}
