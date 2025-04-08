using System;
 class Karyawan //membuat class Karyawan seperti yang diperintahkan pada soal 1. dimana membuat class Karyawan sebagai superclass lalu menambahkan attribut nama dengan type data string, id denga type data string, lalu gaji pokok dengan type data double. kenapa type data double? karena mengandung banyak unsur angka atau angka nya banyak
{
    private string Nama; //membuat attribut lalu di inisialisasi dengan private agar tidak bisa diakses diluar class Karyawan
    private string ID;
    private double Gaji_pokok;

    public string nama //membuat property nama dengan type data string. kenapa pakai property? karena property adalah cara untuk mengakses data private di dalam class. property juga bisa diakses diluar class Karyawan prperty ini membuat data atau attribute lebih aman karena tidak mudah diakses
    {
        get { return Nama; } //menambahkan get and set sesuai soal no 1 akhir. kenapa pakai set and get kenapa tidaklangsung oublic? karena penggunaan set and get dapat membuat data lebih aman karena disetiap perubahan selalu menyertakan property nya lalujuga sangat fleksible tidak seperti public yang harus merubah satu persatu
        set { Nama = value; }
    }
    public string id
    {
        get { return ID; } //return id menyimpan nilai ID yang diinputkan oleh user lalu set Id = value mengembalikan atau mengeluarkan nilai ID yang diinputkan oleh user
        set { ID = value; }
    }
    public double gaji_pokok
    {
        get { return Gaji_pokok; }
        set {
            if (value >= 0) //menambahkan validasi pada gaji pokok agar tidak negatif atau kurang dari 0 karena gaji tidak mungkin negatif 
                Gaji_pokok = value;
            else //jika gaji atau nominal yang dimasukkan 0 atau - maka perintah else akan dijalankan
            {
                Console.WriteLine("Gaji pokok tidak boleh negatif atau kurang");
            }
        }
    }

    public virtual double Hitung_gaji() //membuat method Hitung_gaji dengan type data double. kenapa double? karena gaji pokok bisa saja lebih dari 1 juta atau 1 miliar. jadi kita menggunakan type data double agar lebih fleksible lalu penggunaan virtual ditujukan supaya method ini bisa di override pada class Karyawan_tetap, Karyawan_kontrak, dan Karyawan_magang
    {
        return Gaji_pokok; //mengembalikan nilai gaji pokok yang diinputkan oleh user atau mengembalikan nilai gaji pokok yang sudah di validasi sebelumnya
    }
}
class Karyawan_tetap : Karyawan //membuat class Karyawan_tetap yang merupakan subclass dari class Karyawan. kenapa subclass? karena class ini merupakan turunan dari class Karyawan. jadi class ini bisa mengakses semua method dan property yang ada di class Karyawan seperti yang sudah di perintahkan pada soal no 2 diamana karyawan sebagai parents lalu magang,tetap dan lainnya sebagai sub class
{
    private double Bonus_tetap = 500000; //membuat attribut Bonus_tetap dengan type data double. kenapa double? karena bonus tetap bisa saja lebih dari 1 juta atau 1 miliar. jadi kita menggunakan type data double agar lebih fleksible lalu kita private supaya tidak dapat diakses dengan mudah dan lebih aman karena bonus sudah puna nilai tetap

    public override double Hitung_gaji() //mengoverride method Hitung_gaji yang ada di class Karyawan. kenapa override? karena kita ingin merubah method Hitung_gaji yang ada di class Karyawan agar sesuai dengan perhitungan gaji karyawan tetap karena karyawan tetap nanti akan mendapatkan bonus tetap
    {
        return gaji_pokok + Bonus_tetap; //mengembalikan nilai gaji pokok yang sudah di validasi sebelumnya lalu ditambah dengan bonus tetap yang sudah di sebutkan sebelumnya di awal kelas sebelumnya
    }
}

class Karyawan_kontrak : Karyawan //membuat class Karyawan_kontrak yang merupakan subclass dari class Karyawan. kenapa subclass? karena class ini merupakan turunan dari class Karyawan. jadi class ini bisa mengakses semua method dan property yang ada di class Karyawan seperti yang sudah di perintahkan pada soal no 2 diamana karyawan sebagai parents lalu magang,tetap dan lainnya sebagai sub class
{
    private double Potongan_kontrak = 200000; //membuat attribut Potongan_kontrak dengan type data double. kenapa double? karena potongan kontrak bisa saja lebih dari 1 juta atau 1 miliar. jadi kita menggunakan type data double agar lebih fleksible lalu kita private supaya tidak dapat diakses dengan mudah dan lebih aman karena potongan sudah punya nilai tetap
    public override double Hitung_gaji() //mengoverride method Hitung_gaji yang ada di class Karyawan. kenapa override? karena kita ingin merubah method Hitung_gaji yang ada di class Karyawan agar sesuai dengan perhitungan gaji karyawan kontrak karena karyawan kontrak nanti akan mendapatkan potongan tetap. setiapjenis karyawan memiliki perhitungannya masing2 atau sendiri2
    {
        return gaji_pokok - Potongan_kontrak; //mengembalikan nilai gaji pokok yang sudah di validasi sebelumnya lalu dikurangi dengan potongan tetap yang sudah di sebutkan sebelumnya di awal kelas sebelumnya. sesuai soal no 2 karena setiap karyawan punya perhitungan nya maisng2
    }
}

class Karyawan_magang : Karyawan //membuat class Karyawan_magang yang merupakan subclass dari class Karyawan. kenapa subclass? karena class ini merupakan turunan dari class Karyawan. jadi class ini bisa mengakses semua method dan property yang ada di class Karyawan seperti yang sudah di perintahkan pada soal no 2 diamana karyawan sebagai parents lalu magang,tetap dan lainnya sebagai sub class
{
    public override double Hitung_gaji() //mengoverride method Hitung_gaji yang ada di class Karyawan. kenapa override? karena kita ingin merubah method Hitung_gaji yang ada di class Karyawan agar sesuai dengan perhitungan gaji karyawan magang karena karyawan magang tidak mendapatkan potongan atau bonus apapun sesuai dengan soal no 3 yaitu menggunakan override
    {
        return gaji_pokok; //mengembalikan nilai gaji pokok yang sudah di validasi sebelumnya 
    }
}

class Program //membuat class Program sebagai class utama atau main class. kenapa perlu main class? karena class ini yang akan di jalankan pertama kali saat program di eksekusi
{
    static void Main(string[] args) //membuat sebuah methode yang akan dieksekusi pertama kali dan juga digunakan untuk menjalan kan atau mengeksekusi semua methode yang telah dibuat
    {
        Console.WriteLine("Masukkan Jenis Karyawan (Tetap/Kontrak/Magang) : "); //membuat sebuah console untuk meminta inputan dari user untuk memasukkan jenis karyawan. lalu tolower digunakan untuk mengubah menjadi huruf kecil semua agar tidak case sensitive seperti pada soal no 4
        string Jenis = Console.ReadLine().ToLower().Trim(); //mendeklarasikan bahwa jenis memiliki type data string dan console readline digunakan untukmembaca inputan dari user lalu mengembalikan nya. type data default pada readline adalah string. kenapa mengunakna trim()? supaya ketika usermenginputkan spasi maka spasi tersebut akan hilang ex input = ma gang jika trim maka akan "magang"

        Console.Write("Nama Karyawan : "); //membuat console untuk meminta inputan dari user untuk memasukkan nama karyawan
        string Nama = Console.ReadLine(); //mendeklarasikan bahwa nama memiliki type data string dan console readline digunakan untukmembaca inputan dari user lalu mengembalikan nya. type data default pada readline adalah string

        Console.Write("ID Karyawan : "); //membuat console untuk meminta inputan dari user untuk memasukkan id karyawan
        string ID = Console.ReadLine(); //mendeklarasikan bahwa id memiliki type data string dan console readline digunakan untukmembaca inputan dari user lalu mengembalikan nya. type data default pada readline adalah string

        Console.Write("Gaji Pokok : "); //membuat console untuk meminta inputan dari user untuk memasukkan gaji pokok karyawan
        string inputan_GajiPokok = Console.ReadLine();//mendeklarasikan bahwa gaji pokok memiliki type data string dan console readline digunakan untukmembaca inputan dari user lalu mengembalikan nya. type data default pada readline adalah string karena gaji pokok sebenarnya adalah double maka kita perlu mengkonversi string ke double

        if (double.TryParse(inputan_GajiPokok, out double Gajipokok)){ } //menggunakan tryparse untuk mengkonversi string ke double. kenapa pakai tryparse? karena kita ingin menghindari error jika user memasukkan inputan yang tidak valid seperti huruf atau karakter lain. jadi kita menggunakan tryparse agar lebih aman dan tidak error saat di eksekusi. jika berhasil maka gaji pokok akan di simpan di variabel Gajipokok
        else //jika gagal maka perintah else akan dijalankan
        {
            Console.WriteLine("Gaji pokok tidak valid");
            return; //menghentikan program jika gaji pokok yang dimasukkan tidak valid
        }

        Karyawan karyawan; //membuat variabel karyawan dengan type data Karyawan. kenapa type data Karyawan? karena kita ingin menggunakan polymorphism agar bisa menggunakan method yang ada di class Karyawan dan juga bisa mengakses method yang ada di subclass Karyawan_tetap, Karyawan_kontrak, dan Karyawan_magang. bia menggunakan nama lain tapi disini saya menggunkaan karyawan supaya lebih mudah untuk dipahami dan dimengerti

        if (Jenis == "tetap") //membuat kondisi jika jenis karyawan yang diinputkan adalah tetap maka akan membuat objek karyawan dengan type data Karyawan_tetap. kenapa pakai if? karena kita ingin memeriksa jenis karyawan yang diinputkan oleh user agar sesuai dengan jenis karyawan yang ada di class Karyawan. bisa juga menggunkan switch case dan honestly lebih simpel menggunakan switch case sebenarnya
        {
            karyawan = new Karyawan_tetap(); //membuat objek karyawan dengan type data Karyawan_tetap. kenapa pakai new? karena kita ingin membuat objek baru dari class Karyawan_tetap agar bisa mengakses method yang ada di class Karyawan_tetap
        }
        else if (Jenis == "kontrak") //membuat kondisi jika jenis karyawan yang diinputkan adalah kontrak maka akan membuat objek karyawan dengan type data Karyawan_kontrak. kenapa pakai else if? karena kita ingin memeriksa jenis karyawan yang diinputkan oleh user agar sesuai dengan jenis karyawan yang ada di class Karyawan
        {
            karyawan = new Karyawan_kontrak(); //membuat objek karyawan dengan type data Karyawan_kontrak. kenapa pakai new? karena kita ingin membuat objek baru dari class Karyawan_kontrak agar bisa mengakses method yang ada di class Karyawan_kontrak
        }
        else if (Jenis == "magang") //membuat kondisi jika jenis karyawan yang diinputkan adalah magang maka akan membuat objek karyawan dengan type data Karyawan_magang. kenapa pakai else if? karena kita ingin memeriksa jenis karyawan yang diinputkan oleh user agar sesuai dengan jenis karyawan yang ada di class Karyawan
        {
            karyawan = new Karyawan_magang(); //membuat objek karyawan dengan type data Karyawan_magang. kenapa pakai new? karena kita ingin membuat objek baru dari class Karyawan_magang agar bisa mengakses method yang ada di class Karyawan_magang
        }
        else //jika jenis karyawan yang diinputkan oleh user tidak sesuai dengan jenis karyawan yang ada di class Karyawan maka perintah else akan dijalankan
        {
            Console.WriteLine("Jenis Karyawan yang kamu masukkan salah"); //menampilkan pesan bahwa jenis karyawan yang diinputkan salah
            return; //menghentikan program jika jenis karyawan yang diinputkan salah
        }
        karyawan.nama = Nama; //mengisi property nama dengan nilai yang diinputkan oleh user. seperti yang sudah kita buat sebelumnya menggunakan console.write
        karyawan.id = ID; //mengisi property nama dan id dengan nilai yang diinputkan oleh user. seperti yang sudah kita buat sebelumnya menggunakan console.write
        karyawan.gaji_pokok = Gajipokok; //mengisi property gaji pokok dengan nilai yang diinputkan oleh user. seperti yang sudah kita buat sebelumnya menggunakan console.write

        double Total_gaji = karyawan.Hitung_gaji(); //menghitung total gaji dengan memanggil method Hitung_gaji yang ada di class Karyawan. kenapa pakai method? karena kita ingin menghitung total gaji sesuai dengan jenis karyawan yang diinputkan oleh user. jadi kita menggunakan method agar lebih fleksible dan bisa digunakan berulang kali jika diperlukan sesuai dengan soal no 5 dimana kita disuruh untuk menghitung total gaji keseluruhan 

        Console.WriteLine("\n\nInformasi tentang Karyawan Kantor \n"); //menampilkan informasi tentang karyawan kantor
        Console.WriteLine("Nama Karyawan : " + karyawan.nama); //menampilkan nama karyawan yang diinputkan oleh user
        Console.WriteLine("ID Karyawan : " + karyawan.id); //menampilkan id karyawan yang diinputkan oleh user
        Console.WriteLine("Total Keseluruhan Gaji Pokok : " + Total_gaji); //menampilkan total keseluruhan gaji pokok yang sudah di hitung sebelumnya
    }
}