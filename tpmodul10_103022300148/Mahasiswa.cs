namespace tpmodul10_103022300148
{
    public class Mahasiswa
    {
        public string nama { get; set; }
        public long nim { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(string nama,long nim)
        {
            this.nama = nama;
            this.nim = nim;
        }
    }
}
