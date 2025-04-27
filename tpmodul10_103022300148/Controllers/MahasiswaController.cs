using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_103022300148.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static readonly List<Mahasiswa> mahasiswa = new()
        {
            new Mahasiswa ( "Yappier Albertus Febriandi Krisna Putra", 103022300148 ),
            new Mahasiswa ( "Adrian Putra Perkasa", 103022300041 ),
            new Mahasiswa ( "Muhammad Arrayan Fikri", 103022300050 ),
            new Mahasiswa ( "Achmad Maulana Arief", 103022330157 ),
        };
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }
        [HttpGet("{id}")]
        public Mahasiswa GetId(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]
        public String Delete(int id) {
            mahasiswa.RemoveAt(id);
            return "Data berhasil dihapus";
        }
        [HttpPost]
        public String Post([FromBody] Mahasiswa mhs){
            mahasiswa.Add(mhs);
            return "Data berhasil ditambah";
        }
    }
}
