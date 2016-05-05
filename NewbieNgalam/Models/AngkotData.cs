using System.Collections.Generic;

namespace NewbieNgalam.Models
{
    public class AngkotData
    {
        private static List<Angkot> _Angkot = new List<Angkot>()
        {
            new Angkot()
            {
                Id = 0,
                AngkotName = "ABB",
                AngkotTrayek = "Term. Arjosari – Polowijen – Jl. Borobudur – Bunul",
                AngkotOutPath = "APK Polowijen – Jl. Cakalan – Jl. Ikan Tombro Timur – Jl. Ikan Tombro – Jl. Ikana Piranha Atas – Jl. Ters Ikan Paus – Jl. Ikana Paus VI – Jl. Ikan Paus – Jl. Simpang Borobudur – Jl. A. Yani – Jl. Laksda Adisucipto – Jl. Simp LA Sucipto – Jl. Warinoi – Jl. Membrono – Jl. Sisingamanganraja – Jl. R. Patah – Jl. APK Pasar Bunul",
                AngkotInPath = "APK Pasar Bunul – Jl. Membrono – Jl. Wirinoi – Jl. Simp LA. Sucipto – Jl. Laksda Adi Sucipto – Jl. A. Yani – Jl. Borobudur – Jl. Ikan Paus – Jl. Ikan Paus VII – Jl. Ters Ikan Paus – Jl. Ikan Piranha Atas – Jl. Ikan Tombro Timur – Jl. Cakalan – Jl. APK Polowijen"
            },
            new Angkot()
            {
                Id = 1,
                AngkotName = "ABG",
                AngkotTrayek = "Term. Arjosari – Jl. Borobudur – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Term. Arjosari – Jl. Simp. RP Suroso – Jl. R. Intan – Jl. A. Yani – Jl. Borobudur – Jl. Soekarno-Hatta – Jl. Cengkeh – Jl. Kalpataru – Jl. Melati – Jl. Mawar – Jl. Saranagan – Jl. Tawangmangu – Jl. Kaliurang – Jl. WR. Supratman – Jl. P. Sudirman – Jl. Pattimuara – JL. Trunojoyo – Jl. Jembatan Pahlawan – Jl. Gatot Subroto – Jl. L. Martadinata – Jl. Kol. Sugiyono – Terminal Hamid Rusdi",
                AngkotInPath = "Terminal Hamid Rusdi – Jl. Kol Sugiyono – Jl. L. Martadinata – Jl. Gatot Subroto – Jl. Jembatan Pahlawan – Jl. Trunojoyo – Jl. Cokro Aminoto – Jl. Dr. Cipto – Jl. P. Sudirman – Jl. WR. Supratman – Jl. Kaliaurang – Jl. Tawangmangu – Jl. Sarangan – Jl. Mawar – Jl. Bungur – Jl. Kalpataru – Jl. Cengkeh – Jl. Soekarno-Hatta – Jl. Borobudur – Jl. A. yani – Jl. R. Intan – Term. Arjosari"
            },
            new Angkot()
            {
                Id = 2,
                AngkotName = "ABH",
                AngkotTrayek = "Term. Arjosari – Jl. Borobudur – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Term. Arjosari – Jl. Simp. RP Suroso – Jl. R. Intan – Jl. A. Yani – Jl. Borobudur – Jl. Soekarno-Hatta – Jl. Cengkeh – Jl. Kalpataru – Jl. Melati – Jl. Mawar – Jl. Saranagan – Jl. Tawangmangu – Jl. Kaliurang – Jl. WR. Supratman – Jl. P. Sudirman – Jl. Pattimuara – JL. Trunojoyo – Jl. Jembatan Pahlawan – Jl. Gatot Subroto – Jl. L. Martadinata – Jl. Kol. Sugiyono – Terminal Hamid Rusdi",
                AngkotInPath = "Terminal Hamid Rusdi – Jl. Kol Sugiyono – Jl. L. Martadinata – Jl. Gatot Subroto – Jl. Jembatan Pahlawan – Jl. Trunojoyo – Jl. Cokro Aminoto – Jl. Dr. Cipto – Jl. P. Sudirman – Jl. WR. Supratman – Jl. Kaliaurang – Jl. Tawangmangu – Jl. Sarangan – Jl. Mawar – Jl. Bungur – Jl. Kalpataru – Jl. Cengkeh – Jl. Soekarno-Hatta – Jl. Borobudur – Jl. A. yani – Jl. R. Intan – Term. Arjosari"
            },
            new Angkot()
            {
                Id = 3,
                AngkotName = "ADL",
                AngkotTrayek = "Term. Arjosari – Dinoyo – Term. Landungsari",
                AngkotOutPath = "Terminal Arjosari – Jl. Simpang R. Panji Suroso – Jl. Raden Intan – Jl. Jend. A. Yani – Jl. Letjen S. Parman – Jl. Letjen Sutoyo – Jl. W. R. Supratman – Jl. Panglima Sudirman – Jl. Patimura – Jl. Trunojoyo- Jl. Kertanegara – Jl. Kahuripan – Jl Semeru – Jl. Ijen – Jl. Bandung – Jl. Terusan Bogor – Jl. Mayjen Panjaitan – Jl. Mayjen Haryono – Jl. Tlogomas – Terminal Landung Sari",
                AngkotInPath = "Terminal Landung Sari – Jl. Tlogomas – Jl. Mayjen Haryono – Jl. Mayjen Panjaitan – Jl. Semeru – Jl. Kahuripan – Jl. Tugu – Jl. Kertanegara – Jl. Trunujoyo – cokro Aminoto – Jl. Dr. Cipto – Jl. Panglima Sudirman – Jl. W. R. Supratman – Jl. Letjen Sutoyo – Jl. Letjen S. Parman – Jl. Jend A Yani – Jl. Raden Intan – Terminal Arjosari"
            },
            new Angkot()
            {
                Id = 4,
                AngkotName = "AG",
                AngkotTrayek = "Term. Arjosari – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Terminal Arjosari – Jl. Simpang R. Panji Suroso – Jl. Raden Intan – Jl. Jend A. Yani – Jl. Letjen S. Parman – Jl. Letjen Sutoyo – Jl. Jakgung Suprapto – Jl. Basuki Rahmat – Merdeka Utara – Jl. Merdeka Timur – Jl. Sukarjowiryo Panoto – Jl. Pasar Besar – Jl. Sersan Harun – Jl. Prof. Moh. yamin – Jl. Sartono SH – Jl. Kol. Sugiono – Terminal Gadang",
                AngkotInPath = "Terminal Gadang – Jl. Kol. Sugiyono – Jl. Sartono SH – Jl. Irian Jaya – Jl. Tanimbar – Jl. Sulawesi – Jl. Yulius Usman – Jl. Syarif Al Qodri – Jl. Kauman – Jl. Hasyim Asy’ari – Jl. A. R. Hakim – Jl. Basuki Rahmat – Jl. Jakgung Suprapto – Jl. Letjen Sutoyo – Jl. Letjen S. Parman – Jl. Jend A. Yani – Jl. Raden Intan – Terminal Arjosari"
            },
            new Angkot()
            {
                Id = 5,
                AngkotName = "AH",
                AngkotTrayek = "Term. Arjosari – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Terminal Arjosari – Jl. Simpang R. Panji Suroso – Jl. Raden Intan – Jl. Jend A. Yani – Jl. Letjen S. Parman – Jl. Letjen Sutoyo – Jl. Jakgung Suprapto – Jl. Basuki Rahmat – Merdeka Utara – Jl. Merdeka Timur – Jl. Sukarjowiryo Panoto – Jl. Pasar Besar – Jl. Sersan Harun – Jl. Prof. Moh. yamin – Jl. Sartono SH – Jl. Kol. Sugiono – Terminal Gadang",
                AngkotInPath = "Terminal Gadang – Jl. Kol. Sugiyono – Jl. Sartono SH – Jl. Irian Jaya – Jl. Tanimbar – Jl. Sulawesi – Jl. Yulius Usman – Jl. Syarif Al Qodri – Jl. Kauman – Jl. Hasyim Asy’ari – Jl. A. R. Hakim – Jl. Basuki Rahmat – Jl. Jakgung Suprapto – Jl. Letjen Sutoyo – Jl. Letjen S. Parman – Jl. Jend A. Yani – Jl. Raden Intan – Terminal Arjosari"
            },
            new Angkot()
            {
                Id = 6,
                AngkotName = "AJG",
                AngkotTrayek = "Term. Arjosari – Janti – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Term. Arjosari – Jl. RP. Suroso – Jl. Adi Sucipto – Jl. A. Yani – Jl. S. Parman – Jl. Letjen Sutoyo – Jl. Indragiri – Jl. RT. Suryo – Jl. Hamid Rusdi – Jl. Kesatrian – Jl. Terusan Pahlawan – Jl. Urip Sumoharjo – Jl. Pattimura – Jl. Trunojoyo – Jl. Jembatan Pahlawan – Jl. Ir. Juanda – Jl. Zakse – Jl. RE. Martadinata – Jl. Kyai Tamin – Jl. Prof M. Yamin – JL. Peltu Sujono – Jl. Susanto – Jl. Niaga – Jl. Sonokeling – Jl. Janti – Jl. S. Supriyadi – Jl. Satsuit Tubun – Terminal Hamid Rusdi",
                AngkotInPath = "Terminal Hamid Rusdi – Jl. Satsuit Tubun – Jl. S. Supriayadi – Jl. Janti – Jl. Sonokeling – Jl. Niaga – Jl. Susanto – Jl. P. Sujono – Jl. Sartono SH – Jl. RE Martadinata – Jl. Kyai Tamin – Jl. Kopral Usman – Jl. Pasar Besar – Jl. . Arifin – Jl. Aris Munandar – Jl. Jembatan Pahlawan – Jl. Trunojoyo – = Jl. Cokro Aminoto – Jl. Dr. Cipto – Jl. P. Sudirman – Jl. RT. Suryo – JL. Barito – Jl. Mahakam – Jl. Karya Timur – Jl. Ciliwung – Jl. Letjend S. Parman – Jl. A. Yani – Jl. R. Intan – Term. Arjosari"
            },
            new Angkot()
            {
                Id = 7,
                AngkotName = "AJH",
                AngkotTrayek = "Term. Arjosari – Janti – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Term. Arjosari – Jl. RP. Suroso – Jl. Adi Sucipto – Jl. A. Yani – Jl. S. Parman – Jl. Letjen Sutoyo – Jl. Indragiri – Jl. RT. Suryo – Jl. Hamid Rusdi – Jl. Kesatrian – Jl. Terusan Pahlawan – Jl. Urip Sumoharjo – Jl. Pattimura – Jl. Trunojoyo – Jl. Jembatan Pahlawan – Jl. Ir. Juanda – Jl. Zakse – Jl. RE. Martadinata – Jl. Kyai Tamin – Jl. Prof M. Yamin – JL. Peltu Sujono – Jl. Susanto – Jl. Niaga – Jl. Sonokeling – Jl. Janti – Jl. S. Supriyadi – Jl. Satsuit Tubun – Terminal Hamid Rusdi",
                AngkotInPath = "Terminal Hamid Rusdi – Jl. Satsuit Tubun – Jl. S. Supriayadi – Jl. Janti – Jl. Sonokeling – Jl. Niaga – Jl. Susanto – Jl. P. Sujono – Jl. Sartono SH – Jl. RE Martadinata – Jl. Kyai Tamin – Jl. Kopral Usman – Jl. Pasar Besar – Jl. . Arifin – Jl. Aris Munandar – Jl. Jembatan Pahlawan – Jl. Trunojoyo – = Jl. Cokro Aminoto – Jl. Dr. Cipto – Jl. P. Sudirman – Jl. RT. Suryo – JL. Barito – Jl. Mahakam – Jl. Karya Timur – Jl. Ciliwung – Jl. Letjend S. Parman – Jl. A. Yani – Jl. R. Intan – Term. Arjosari"
            },
            new Angkot()
            {
                Id = 8,
                AngkotName = "AL",
                AngkotTrayek = "Term. Arjosari – Term. Landungsari",
                AngkotOutPath = "Terminal Arjosari – Jl. R. Panji Suroso – Jl. Laksda Adi Sucipto – Jl. Tenaga – Jl. Karya Timur – Jl. Mahakam – Jl. W. R. Supratman – Jl. Panglima Sudirman – Jl. Patimura – Jl. Trunojoyo – Jl. Kertanegara – Jl. Tugu – Jl. Kahuripan – Jl. Semeru – Jl. Ijen – Jl. Retawu – Jl. Bondowoso – Jl. Jombang – Jl. Surabaya – Jl. Jakarta – Jl. Bogor – Jl. Veteran – Jl. Sumbersari – Terminal Landung Sari",
                AngkotInPath = "Terminal Landung Sari – Jl. Tlogomas – Jl. Mayjen MT. Haryono Jl. Gajayana – Jl. Veteran – Jl. Bandung – Jl. Ijen – Jl. Semeru – Jl. Kahuripan – Jl. Tugu – Jl. Kertanegara – Jl. Trunojoyo – Jl. Pattimura – Jl. Panglima Sudirman – Jl. WR. Supratman – Jl. Mahakam – Jl. Karya Timur – Jl. Tenaga – Jl. Laksamana Adi Sucipto – Jl. R. Panji Suroso – Terminal Arjosari"
            },
            new Angkot()
            {
                Id = 9,
                AngkotName = "AMG",
                AngkotTrayek = "Term. Arjosari – Mergosono – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Term. Arjosari – Jl. Simp. Panji Suroso – Jl. S. Priyo Sudarmo – Jl. RT Suryo – Jl. Hamid Rusdi – Jl. Kesatriaan Terusan – Jl. Urip Sumoharjo – Jl. P. Sudirman – Jl. Ir Juanda – Jl. Kebalen – Jl. Kol Sugiyono – Terminal Hamid Rusdi",
                AngkotInPath = "Terminal Hamid Rusdi – Jl. Kol. Sugiyono – Jl. L. Martadinata – Jl. Kyai Tamin – Jl. Kopral Usman – Jl. Pasar Besar – Jl. Gatot Subroto – Jl. Jembatan Pahlawan – Jl. Trunojoyo – Jl. Cokroaminoto – Jl. Dr. Cipto – Jl. P. Sudirman – Jl. RT. Suryo – Jl. S. Priyo – Jl. Sudarmo – Jl. LA. Sucipto – Jl. R. Intan – Term. Arjosari"
            },
            new Angkot()
            {
                Id = 10,
                AngkotName = "AMH",
                AngkotTrayek = "Term. Arjosari – Mergosono – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Term. Arjosari – Jl. Simp. Panji Suroso – Jl. S. Priyo Sudarmo – Jl. RT Suryo – Jl. Hamid Rusdi – Jl. Kesatriaan Terusan – Jl. Urip Sumoharjo – Jl. P. Sudirman – Jl. Ir Juanda – Jl. Kebalen – Jl. Kol Sugiyono – Terminal Hamid Rusdi",
                AngkotInPath = "Terminal Hamid Rusdi – Jl. Kol. Sugiyono – Jl. L. Martadinata – Jl. Kyai Tamin – Jl. Kopral Usman – Jl. Pasar Besar – Jl. Gatot Subroto – Jl. Jembatan Pahlawan – Jl. Trunojoyo – Jl. Cokroaminoto – Jl. Dr. Cipto – Jl. P. Sudirman – Jl. RT. Suryo – Jl. S. Priyo – Jl. Sudarmo – Jl. LA. Sucipto – Jl. R. Intan – Term. Arjosari"
            },
            new Angkot()
            {
                Id = 11,
                AngkotName = "ASD",
                AngkotTrayek = "Term. Arjosari – Jl. Sarangan – Dieng",
                AngkotOutPath = "Term. Arjosari – Jl. Simp. PR. Suroso – JL. R. Panji Suroso – Jl. Plaosan Timur – Jl. Teluk Grajakan – Jl. LA. Sucipto – Jl. Simp. Batu Bara – Jl. Batu Bara – Jl. LA. Sucipto – Jl. Tembaga – Jl. Simp. Emas – Jl. Emas – Jl. Sulfat – Jl. RT. Suryo – Jl. Sanan – Jl. Barito – Jl. Mahakam – Jl. Indragiri – Jl. Letjend Sutoyo – Jl. Sarangan – Jl. Mawar – Jl. Bungur – Jl. Melati – Jl. Kalpataru – Jl. Cengkeh – Jl. Soekarno-Hatta – Jl. M. Panjaitan – Jl. Bandung – Jl. Garut – Jl. Jakarta – Jl. Surabaya – Jl. Gresik – Jl. Bondowoso – Jl. Klampok Kasri – Jl. Taman Wilis – Jl. Kawi Atas – Jl. Mundu – Jl. Raya Langsep – Jl. Ters Dieng – APK Puncak Dieng",
                AngkotInPath = "APK Puncak Dieng – Jl. Ters. Dieng – Jl. Raya Langsep – Jl. Mundu – Jl. Kawi Atas – Jl. Taman Wilis – Jl. Klampok Kasri – Jl. Bondowoso – Jl. Gresik – Jl. Surabaya – Jl. Jakarta – Jl. Simp. Bogor – Jl. Veteran – Jl. Bogor – Jl. Jl. M. Panjaitan – Jl. Soekarno-Hatta – Jl. Cengkeh – Jl. Kalpataru – Jl. Melati – Jl. Mawar – Jl. Sarangan – Jl. Letjend Sutoyo – Jl. Indragiri – Jl. Sanan – Jl. RT. Suryo – Jl. Sulfat – Jl. Emas – Jl. Simp. Emas – Jl. Tembaga – Jl. Batu Bara – Jl. Simp. Batu Bara – Jl. LA. Sucipto – Jl. TL Grajakan – Jl. Plaosan Timur – Jl. RP Suroso – Jl. R. Intan – Term. Arjosari"
            },
            new Angkot()
            {
                Id = 12,
                AngkotName = "AT",
                AngkotTrayek = "Term. Arjosari – Tidar",
                AngkotOutPath = "Terminal Arjosari – Jl.Raden Intan – JL. Jend.A Yani – Jl. Letjen S. Parman – Jl.Ciliwung – Jl. Sundandar Priyosudarmo – Jl. R. Tumenggung Suryo – Jl. P. Sudirman – Jl. Pattimura- Jl. Belakang RSU – Jl. Kahuripan – Jl. Semeru – Jl. Arjuno – Jl. Kawi – Jl. Panderman – Jl. Pandan – Jl. Wilis – Jl. Gading – Jl. Sangga Buana – Jl. Galunggung – Jl. Bukit Barisan – Jl. Lokon – Jl. Raya Tidar – Jl. Puncak Mandala – Terminal Perum Tidar",
                AngkotInPath = "Terminal Perum Tidar – Jl. Es. Berg – Jl. Puncak Mandala – Jl. Raya Tidar – Jl. Lokon – Jl. Bukit Barisan – Jl. Galunggung Sangga Buwana – Jl. Gading – Jl. Wilis – Jl. Pandan – Jl. Panderman – Jl. Kawi – Jl. Arjuno – Jl. Semeru – Jl. Kahuripan – Jl. Belakang RSU – Jl. Pattimura – Jl. Panglima Sudirman – Jl. R Tumenggung Suryo – Jl. Sunandar Priyosudarmo – Jl. Letjen. S. Parman – Jl. Jend. A. Yani – Jl. Raden Intan – Terminal Arjosari"
            },
            new Angkot()
            {
                Id = 13,
                AngkotName = "CKL",
                AngkotTrayek = "Cemorokandang – Term. Landungsari",
                AngkotOutPath = "APK Cemorokandang – Jl. Raya Cemorokandang – Jl. Raya Madyopuro – Jl. Sekarpuro – Jl. Komplek UNIDA – JL. D. Sentani – Jl. D. Tigi – Jl. D. Kerinci – Jl. D. Tondano – Jl. Limboto – Jl. Raya Sawojajar – Jl. Ranu Grati – Jl. M. Wiyono – Jl. Kesatrian – Jl. Hamid Rusdi – Jl. RT. Suryo – Jl. S. Priyo Sudarmo – Jl. Ciliwung – Jl. L. Sutoyo – Jl. Kedawung – Jl. Kalpataru – Jl. Cengkeh – Jl. Soekarno-Hatta – Jl. Simp Panggung – Jl. Vinolia – Jl. Keramik – Jl. MT. Haryono – Jl. Tlogomas – Term Landungsari",
                AngkotInPath = "Term Landungsari – Jl. Raya Tlogomas – Jl. M. Haryono – Jl. Keramik – Jl. Vinolia – Jl. Simp Panggung – Jl. Panggung – Jl.; Soekarno-Hatta – Jl. Cengkeh – Jl. Kalpataru – Jl. Kedawung – Jl. Sutoyo – Jl. Hamid Rusdi – Jl. Kesatrian – Jl. M. Wiyono – Jl. Ranu Grati – Jl. Raya Sawojajar – Jl. D. Limboto Barat Ters – Jl. D. Tandono – Jl. D.Paniai – Jl. Komp UNIDA – Jl. Sekar Puro – Jl. Tigi – Jl. D.Sentanu – Jl. Raya Madyopuro – Jl. Cemorokandang – APK Cemorokandang"
            },
            new Angkot()
            {
                Id = 14,
                AngkotName = "GA",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Term. Arjosari",
                AngkotOutPath = "Terminal Gadang – Jl. Satsuit Tubun – Jl. S Supriyadi – Jl. Arif Margono – Jl. Ade Irma Suryani – Jl. KH Wahid Hasyim – Jl. Kauman – Jl. Hasyim Asy’ari – Jl. AR Hakim – Jl. Merdeka Utara – Jl. S Wiryopranoto – Jl. Mojopahit – Jl. Tugu – Jl. Untung Suropati – Jl. Pajajaran – Jl. Truno Joyo – Jl. Cokroaminoto – Jl. Dr Cipto – Jl. Pang Sudirman – Jl. WR Supratman – Jl. Letjend Sutoyo – Jl. Letjend S. Parman – Jl. Jend Ayani – Jl. R Intan – Terminal Arjosari",
                AngkotInPath = "Terminal Arjosari – Jl. Simpang Panji Suroso – Jl. R Intan – Jl. Jend A Yani – Jl. Letjend S Parman – Jl. Letjend Sutoyo – Jl.Indragiri – Jl. Mahakam – Jl. WR Supratman – Jl. Pang Sudirrman – Jl. Patimura Jl. Truno Joyo – Jl. Kertanegara – Jl. Tugu – Jl. Mojopahit – JL. S Wiryopranoto – Jl. Sultan Syahrir – Jl. Halmahera – Jl. Tanimbar – Jl Arif Margono – Jl. S Supriyadi – Jl. Satsuit Tubun – Terminal Gadang"
            },
            new Angkot()
            {
                Id = 15,
                AngkotName = "GL",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Term. Landungsari",
                AngkotOutPath = "Term. Gadang – Jl. S Tubun – Jl. S. Supriadi – Jl. Janti – Sonokeling. – Jl. Niaga – Jl. Susanto – Jl. Halmahera – Jl. Sampo – Jl. Kalimantan – Jl. Sulawesi – Jl. Yulius Usman – Jl. Arief Margono – Jl. KH. Hasyim Asyari – Jl. Kawi – Jl. Ijen – Jl. Retawu – Jl. Gede – Jl. Jakarta – Jl. Garut – Jl. Bandung – Jl. Veteran – Jl. Sumbersari – Jl. Gajayana – Jl. MT. Hartono – Jl. Raya Tlogomas -Term Landungsari",
                AngkotInPath = "Term. Landungsari – Jl. Raya Tlogomas – Jl. MT. Haryono – Jl. Gajayana – Jl. Sumbersari – Jl. Veteran – Jl. Bnadung – Jl. Ijen – Jl. Semeru – Jl. Arjuno – Kawi – Jl. AR Hakim – Jl. Merdeka Utara – Jl. Merdeka Timur – Jl. Kauman – Jl. KH. Hasyim Asyari – Jl. Arief Margono – Jl. Yulius Usman – Jl. Sulawesi Jl. Nusakambangan – Jl. Halmahera – Jl. Susanto – Jl. Niaga – Jl. Sonokeling – Jl. Janti – Jl. S. Supriyadi – Jl. Satsuit Tubun – Terminal Hamid Rusdi"
            },
            new Angkot()
            {
                Id = 16,
                AngkotName = "GM",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Term. Madyopuro",
                AngkotOutPath = "Term. Gadang – Jl. Kol. Sugiono . – Jl. Susanto – Jl. Irian Jaya – Jl. Tanimbar. – Jl. Sulaesi. – Jl. Yulius Usman . – Jl. Syarief Al Qodri – Jl. A. I Suryani – Jl. B. Katamso – Jl. Ir Rais – Jl. Jupri – Jl. Bandulan – Jl. Raya Mulyrejo – Sub term Mulyorejo",
                AngkotInPath = "Term. Mulyorejo. – Jl. Raya Mulyorejo – Jl. Ds. Tebo Selatan – Jl. Raya Mulyo rejo. – Jl. Raya Bandulan . – Jl. Jupri. – Jl. IR. Rais – Jl. B. Katamso. – Jl. A. I. Suryani. – Jl. Sukarjowiryopranoto – Jl. Kyai Tamin – Jl. Prof. M. Yamin. – Jl. Susanto. – Jl. Kol. Sugiono – Jl. Term. Gadang"
            },
            new Angkot()
            {
                Id = 17,
                AngkotName = "GML",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Mergan – Term. Landungsari",
                AngkotOutPath = "Terminal Hamid Rusdi – Jl. Satsuit Tubun – Jl. S. Supriyadi – Jl. Janti – Jl. Sono Keling – Jl. Niaga – Jl. Susanto – Jl. Halmahera – Jl. Tanimbar – Jl. Sulawesi – Jl. Nusakambangan – Jl. Arief Margono – Jl. S. Supriyadi – Jl. Rajawali – Term Mergan Lori – Jl. Raya Langsep – Jl. Galunggunbg – Jl. Bukit Barisan – Jl. Tamboro – Jl. Tidar – Jl. Simpang Candi – Jl. Candi – Jl. Ters. Sigura-gura – Jl. Belakang UIN – Jl. Mertoijoyo Selatan – Jl. Mertojoyo – Jl. MT. Haryono Gg. XII- Jl. Raya Tlogomas – Term Landungsari",
                AngkotInPath = "Term Landungsari- Jl. Raya Tlogomas – Jl. MT. Haryono – Jl. MT.Haryono Gg XII – Jl. Mertojoyo – Jl. Mertojoyo Selatan – Jl. Belakang UIN – Jl. Ters Sigura-gura – Jl. Candi – Jl. Simp Candi – Jl. Tidar – Jl. Lokon – Jl. Bukit Barisan – Jl. Raya Langsep – Jl. Mergan Lori – Jl. Arief Margono – Jl. Yulius Usman – Jl. Sulawesi – Jl. Halmahera – Jl. Susanto – Jl. Niaga – Jl. Sono Keling – Jl. Janti – Jl. S. Supriyadi – Jl. S. Tubun – Terminal Hamid Rusdi"
            },
            new Angkot()
            {
                Id = 18,
                AngkotName = "HA",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Term. Arjosari",
                AngkotOutPath = "Terminal Gadang – Jl. Satsuit Tubun – Jl. S Supriyadi – Jl. Arif Margono – Jl. Ade Irma Suryani – Jl. KH Wahid Hasyim – Jl. Kauman – Jl. Hasyim Asy’ari – Jl. AR Hakim – Jl. Merdeka Utara – Jl. S Wiryopranoto – Jl. Mojopahit – Jl. Tugu – Jl. Untung Suropati – Jl. Pajajaran – Jl. Truno Joyo – Jl. Cokroaminoto – Jl. Dr Cipto – Jl. Pang Sudirman – Jl. WR Supratman – Jl. Letjend Sutoyo – Jl. Letjend S. Parman – Jl. Jend Ayani – Jl. R Intan – Terminal Arjosari",
                AngkotInPath = "Terminal Arjosari – Jl. Simpang Panji Suroso – Jl. R Intan – Jl. Jend A Yani – Jl. Letjend S Parman – Jl. Letjend Sutoyo – Jl.Indragiri – Jl. Mahakam – Jl. WR Supratman – Jl. Pang Sudirrman – Jl. Patimura Jl. Truno Joyo – Jl. Kertanegara – Jl. Tugu – Jl. Mojopahit – JL. S Wiryopranoto – Jl. Sultan Syahrir – Jl. Halmahera – Jl. Tanimbar – Jl Arif Margono – Jl. S Supriyadi – Jl. Satsuit Tubun – Terminal Gadang"
            },
            new Angkot()
            {
                Id = 19,
                AngkotName = "HL",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Term. Landungsari",
                AngkotOutPath = "Term. Gadang – Jl. S Tubun – Jl. S. Supriadi – Jl. Janti – Sonokeling. – Jl. Niaga – Jl. Susanto – Jl. Halmahera – Jl. Sampo – Jl. Kalimantan – Jl. Sulawesi – Jl. Yulius Usman – Jl. Arief Margono – Jl. KH. Hasyim Asyari – Jl. Kawi – Jl. Ijen – Jl. Retawu – Jl. Gede – Jl. Jakarta – Jl. Garut – Jl. Bandung – Jl. Veteran – Jl. Sumbersari – Jl. Gajayana – Jl. MT. Hartono – Jl. Raya Tlogomas -Term Landungsari",
                AngkotInPath = "Term. Landungsari – Jl. Raya Tlogomas – Jl. MT. Haryono – Jl. Gajayana – Jl. Sumbersari – Jl. Veteran – Jl. Bnadung – Jl. Ijen – Jl. Semeru – Jl. Arjuno – Kawi – Jl. AR Hakim – Jl. Merdeka Utara – Jl. Merdeka Timur – Jl. Kauman – Jl. KH. Hasyim Asyari – Jl. Arief Margono – Jl. Yulius Usman – Jl. Sulawesi Jl. Nusakambangan – Jl. Halmahera – Jl. Susanto – Jl. Niaga – Jl. Sonokeling – Jl. Janti – Jl. S. Supriyadi – Jl. Satsuit Tubun – Terminal Hamid Rusdi"
            },
            new Angkot()
            {
                Id = 20,
                AngkotName = "HM",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Term. Madyopuro",
                AngkotOutPath = "Term. Gadang – Jl. Kol. Sugiono . – Jl. Susanto – Jl. Irian Jaya – Jl. Tanimbar. – Jl. Sulaesi. – Jl. Yulius Usman . – Jl. Syarief Al Qodri – Jl. A. I Suryani – Jl. B. Katamso – Jl. Ir Rais – Jl. Jupri – Jl. Bandulan – Jl. Raya Mulyrejo – Sub term Mulyorejo",
                AngkotInPath = "Term. Mulyorejo. – Jl. Raya Mulyorejo – Jl. Ds. Tebo Selatan – Jl. Raya Mulyo rejo. – Jl. Raya Bandulan . – Jl. Jupri. – Jl. IR. Rais – Jl. B. Katamso. – Jl. A. I. Suryani. – Jl. Sukarjowiryopranoto – Jl. Kyai Tamin – Jl. Prof. M. Yamin. – Jl. Susanto. – Jl. Kol. Sugiono – Jl. Term. Gadang"
            },
            new Angkot()
            {
                Id = 21,
                AngkotName = "HML",
                AngkotTrayek = "Term. Hamid Rusdi – Gadang – Mergan – Term. Landungsari",
                AngkotOutPath = "Terminal Hamid Rusdi – Jl. Satsuit Tubun – Jl. S. Supriyadi – Jl. Janti – Jl. Sono Keling – Jl. Niaga – Jl. Susanto – Jl. Halmahera – Jl. Tanimbar – Jl. Sulawesi – Jl. Nusakambangan – Jl. Arief Margono – Jl. S. Supriyadi – Jl. Rajawali – Term Mergan Lori – Jl. Raya Langsep – Jl. Galunggunbg – Jl. Bukit Barisan – Jl. Tamboro – Jl. Tidar – Jl. Simpang Candi – Jl. Candi – Jl. Ters. Sigura-gura – Jl. Belakang UIN – Jl. Mertoijoyo Selatan – Jl. Mertojoyo – Jl. MT. Haryono Gg. XII- Jl. Raya Tlogomas – Term Landungsari",
                AngkotInPath = "Term Landungsari- Jl. Raya Tlogomas – Jl. MT. Haryono – Jl. MT.Haryono Gg XII – Jl. Mertojoyo – Jl. Mertojoyo Selatan – Jl. Belakang UIN – Jl. Ters Sigura-gura – Jl. Candi – Jl. Simp Candi – Jl. Tidar – Jl. Lokon – Jl. Bukit Barisan – Jl. Raya Langsep – Jl. Mergan Lori – Jl. Arief Margono – Jl. Yulius Usman – Jl. Sulawesi – Jl. Halmahera – Jl. Susanto – Jl. Niaga – Jl. Sono Keling – Jl. Janti – Jl. S. Supriyadi – Jl. S. Tubun – Terminal Hamid Rusdi"
            },
            new Angkot()
            {
                Id = 22,
                AngkotName = "JDM",
                AngkotTrayek = "Permh. Joyogrand – Dinoyo – Mergan",
                AngkotOutPath = "APK Perum Joyo Grand – Jl. Kanjuruan – Jl. Tlogosari – Jl. Tlogo Indah – Jl. Raya Tlogomas – Jl. MT. Haryono – Jl. MT Haryono Gg X – Jl. Joyoraharjo – Jl. Tambaksari – Jl. Simp Gajayana – Jl. Gajayana – Jl. Sumbersari – Jl. Bendungan Sutami – Jl. Galunggung – Jl. Raya Langsep – APK Mergan",
                AngkotInPath = "APK Mergan – Jl. Raya Langsep – Jl. Galunggung – Jl. Bendungan Sutami – Jl. Sumbersari – Jl. Gajayana – Jl. Simp Gajahyana – Jl. Tambaksari – Jl. Joyoraharjo – Jl. MT. Haryono Gg X – Jl. MT Haryono – Jl. Raya Tlogomas – Jl. Tlogo Indah – Jl. Tlogosari – Jl. Kanjuruan – APK Joyo Grand"
            },
            new Angkot()
            {
                Id = 23,
                AngkotName = "JPK",
                AngkotTrayek = "Permh. Joyogrand – Jl. Piranha – Karanglo",
                AngkotOutPath = "Perum Joyo Grand – Jl. Tamansari – Jl. Joyosuryo – Jl. Mertojoyo – Jl. Tambaksari – Jl. Simp GajaHyana – Jl. Gajahyana – Jl. MT. Haryono – Jl. Soekarno-Hatta – Jl. Pisang Kipas – Jl. Vinolia – Jl. Tunggul Wulung – Jl. Arkodion – Jl. Biola – Jl. Ikan Gurami – Jl. Ikan Kakap – Jl. Piranha Atas – Jl. Piranha – Jl. A. Yani – Jl. Cerme – Jl. BaleArjosari – Jl. Karang Asem – Jl. APK Karanglo Indah",
                AngkotInPath = "APK Karanglo Indah – Jl. Karang Asem – Jl. Cerme – Jl. A. Yani – Jl. Ikan Piranha – Jl. Piranha Atas – Jl. Ikan Kakap – Jl. Ikan Gurami – Jl. Biola – Jl. Arkodion – Jl. Tunggul Wulung – Jl. Bunga Vinolia – Jl. Pisang Kipas – Jl. Soekarno-Hatta – Jl. MT.Haryono – Jl. Gajahyana – Jl. Simp Gajahyana – Jl. Tambaksari – Jl. Mertojoyo – Jl. Joyo Suryo – Jl. Tamansari – APK Joyo Grand"
            },
            new Angkot()
            {
                Id = 24,
                AngkotName = "LDG",
                AngkotTrayek = "Term. Landungsari – Dinoyo – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Terminal Landung Sari – Jl. Mayjen MT. Haryono – Jl. Mayjen Panjaitan – Jl. Brigjen S. Riyadi – Jl. Jend Basuki Rahmat – Jl. Merdeka Barat – Jl. Kauman – Jl. Syarif al Qodri – Jl. Ade Irma Suryani – Jl. Pasar Besar – Jl. Sersan Harun – Jl. Prof. Moh. Yamin – Jl. Sartono SH – Jl. Kol. Sugiono – Terminal Gadang",
                AngkotInPath = "Terminal Gadang – Jl. Kol. Sugiono – Jl. Sartono SH – Jl. Irian Jaya – Jl. Tanimbar – Jl. Sulawesi – Jl. Yulius Usman – Jl. Syarif Al Qodri – Jl. Ade Irma Suryani – Jl. Hasyim Asy’ari – Jl. Kawi – Jl. Bromo – Jl. Buring – Jl. Ijen – Jl. Bandung – Jl. Veteran – Jl. Terusan Bogor – Jl. Mayjen Panjaitan – Jl. Mayjen haryono – Terminal Landung Sari"
            },
            new Angkot()
            {
                Id = 25,
                AngkotName = "LDH",
                AngkotTrayek = "Term. Landungsari – Dinoyo – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Terminal Landung Sari – Jl. Mayjen MT. Haryono – Jl. Mayjen Panjaitan – Jl. Brigjen S. Riyadi – Jl. Jend Basuki Rahmat – Jl. Merdeka Barat – Jl. Kauman – Jl. Syarif al Qodri – Jl. Ade Irma Suryani – Jl. Pasar Besar – Jl. Sersan Harun – Jl. Prof. Moh. Yamin – Jl. Sartono SH – Jl. Kol. Sugiono – Terminal Gadang",
                AngkotInPath = "Terminal Gadang – Jl. Kol. Sugiono – Jl. Sartono SH – Jl. Irian Jaya – Jl. Tanimbar – Jl. Sulawesi – Jl. Yulius Usman – Jl. Syarif Al Qodri – Jl. Ade Irma Suryani – Jl. Hasyim Asy’ari – Jl. Kawi – Jl. Bromo – Jl. Buring – Jl. Ijen – Jl. Bandung – Jl. Veteran – Jl. Terusan Bogor – Jl. Mayjen Panjaitan – Jl. Mayjen haryono – Terminal Landung Sari"
            },
            new Angkot()
            {
                Id = 26,
                AngkotName = "LG",
                AngkotTrayek = "Term. Landungsari – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Terminal Landungsari – Jl. Tlogo Mas – Jl. Mayjend Haryono Jl. Sumber Sari – Jl. Bendungan Sutami – Jl. Surabaya – Jl. Bondowoso – Jl. Gading – Jl. Wilis – Jl. Panderman – Jl. AR Hakim – Jl. Merdeka Utara – Jl. Merdeka Selatan – Jl. Wiryopranoto – Jl. Sultan Syahrir – Jl. Kyai Tamin – Jl. Sartono SH – Jl. Peltu Sujono – Jl. Susanto – Jl. Niaga – Jl. Sonokeling – Jl. Janti – Jl. S. Supriyadi – Jl. Satsuit Tubun – Terminal Gadang",
                AngkotInPath = "Terminal Gadang – Jl. Satsuit Tubun – Jl. S Supriyadi – Jl. Janti – Jl. Sonokeling – Jl. Niaga – Jl.Halmahera – Jl. Tanimbar – Jl. Nusa Kambangan – Jl. Terusan Halmahera – Jl. Kapten Piere Tendean – Jl. Arif Margono – Jl. KH Hasyim Asy’ari – Jl. Kawi – Jl. Gading – Jl. Jombang – Jl. Surabaya – Jl. Bendungan Sutami – Jl. Wonogiri – Jl. Bend Sengguruh – Bendungan Sigura-gura – Jl. Sumbersari – Jl. Gajayana – Jl. Mayjen Haryono – Terminal Landungsari"
            },
            new Angkot()
            {
                Id = 27,
                AngkotName = "LH",
                AngkotTrayek = "Term. Landungsari – Gadang – Term. Hamid Rusdi",
                AngkotOutPath = "Terminal Landungsari – Jl. Tlogo Mas – Jl. Mayjend Haryono Jl. Sumber Sari – Jl. Bendungan Sutami – Jl. Surabaya – Jl. Bondowoso – Jl. Gading – Jl. Wilis – Jl. Panderman – Jl. AR Hakim – Jl. Merdeka Utara – Jl. Merdeka Selatan – Jl. Wiryopranoto – Jl. Sultan Syahrir – Jl. Kyai Tamin – Jl. Sartono SH – Jl. Peltu Sujono – Jl. Susanto – Jl. Niaga – Jl. Sonokeling – Jl. Janti – Jl. S. Supriyadi – Jl. Satsuit Tubun – Terminal Gadang",
                AngkotInPath = "Terminal Gadang – Jl. Satsuit Tubun – Jl. S Supriyadi – Jl. Janti – Jl. Sonokeling – Jl. Niaga – Jl.Halmahera – Jl. Tanimbar – Jl. Nusa Kambangan – Jl. Terusan Halmahera – Jl. Kapten Piere Tendean – Jl. Arif Margono – Jl. KH Hasyim Asy’ari – Jl. Kawi – Jl. Gading – Jl. Jombang – Jl. Surabaya – Jl. Bendungan Sutami – Jl. Wonogiri – Jl. Bend Sengguruh – Bendungan Sigura-gura – Jl. Sumbersari – Jl. Gajayana – Jl. Mayjen Haryono – Terminal Landungsari"
            },
            new Angkot()
            {
                Id = 28,
                AngkotName = "MK",
                AngkotTrayek = "Term. Madyopuro – Karangbesuki",
                AngkotOutPath = "Term Madyopuro – Jl. Kiageng Gribik – Jl. Muharto – Jl. Z. Zakse – Jl. Pasar Besar – Jl. Zaenal Arifin – Jl. A Munandar – Jl. MGR Sugriwiryopranoto – Jl. Merdeka Timur – Jl. Merdeka Selatan – Jl. Kauman – Jl. KH. Hasyim Asy’ari – Jl. Kawi – Jl. Ijen – Jl. Pahlawan Trib – Jl. Surabaya – Jl. B. Sutami – Jl. Kleseman – APK Karang Besuki",
                AngkotInPath = "APK Karang Besuki – Jl. Klaseman – Jl. B Sutami – Jl. Surabaya – Jl. Pahlawan Trib – Jl. Guntur – Jl. BS. Riyadi – Jl. Buring – Jl. Merapi – Jl. Bromo – Jl. Semeru – Jl. Kahuripan – Jl. Tugu – Jl. Mojopahit – Jl. Basuki Rahmad – Jl. Merdeka Utara – Jl. Merdeka Timur – Jl. MGR Sugriwiryopranoto – Jl. S. Sah rir – Jl. Kyai Tamin – Jl. Kopral Ustman – Jl. Pasar Besar – Jl. Gatot Subroto – Jl. Ir. H. Juanda – Jl. Muharto – Jl. Ki Ageng Gribik – Term Madyopuro"
            },
            new Angkot()
            {
                Id = 29,
                AngkotName = "MKS",
                AngkotTrayek = "Term. Mulyorejo – Klayatan – Sukun",
                AngkotOutPath = "Term Mulyorejo – Jl. Raya Mulyorejo – Jl. Raya Bakalan Krajan – Jl. Kemantren Gg III – Jl. Klayatan Gg III – Jl. S. Supriyadi – Jl. APK Pasar Sukun",
                AngkotInPath = "APK Pasar Sukun – Jl. S. Supriyadi – Jl. Klayatan Gg III – Jl. KemaNtren Gg III – Jl. Raya Bakalan Krajan – Jl. Mulyorejo – Ter Mulyorejo"
            },
            new Angkot()
            {
                Id = 30,
                AngkotName = "MM",
                AngkotTrayek = "Term. Madyopuro – Term. Mulyorejo",
                AngkotOutPath = "Term Mulyorejo – Jl. Raya Bandulan – Jl. Jupri – Jl. Raya Langsep – Jl. Raya Dieng – Jl. Kawi Atas – Jl. Kawi – Jl. A.R. Hakim – Jl. Merdeka Utara – Jl. MGR. Sugriwiryopranoto – Jl. Mojopahit – Jl. Tugu – Jl. Kertanegara – Jl. Trunojoyo – Jl. Pattimura – Jl. Urip Sumoharjo – Jl. M. Wiyono – Jl. Ranu Grati – Jl. Danau Toba – Jl. Ki Ageng Gribig – Term Madyopuro",
                AngkotInPath = "Term Madyopuro – Jl. Ki Ageng Gribik – Jl. Danau Toba – Jl. Ranu Grati – Jl. M. Wiyono – Jl. Urip Sumoharjo – Jl. Pattimura – Jl. Trunojoyo – Jl. Kertanegara – Jl. Tugu – Jl. Mojopahit – Jl. Basuki Rahmad – Jl. Merdeka Barat – Jl. Kauman – Jl. KH Hasyim Asy’ari – Jl. Kawi – Jl. Kawi Atas – Jl. Raya Dieng – Jl. Raya Langsep – Jl. Jupri – Jl. Raya Bandulan – Term Mulyorejo"
            },
            new Angkot()
            {
                Id = 31,
                AngkotName = "MT",
                AngkotTrayek = "Term. Madyopuro – Tlogowaru",
                AngkotOutPath = "Term. Mulyorejo – Jl. Sutan Syahrir – Jl. Kyai Tamim – Jl. Laks. Martadinata – Jl. Gatot Subroto – Jl. Ir. H. Juanda – Jl. Muharto – Jl. Ki. Ageng Gribig – Jl. Mayjen Sungkono – Jl. Wonokoyo – Term. Tlogowaru",
                AngkotInPath = "Term. Tlogowaru – Jl. Wonokoyo – Jl. Mayjen Sungkonno – Jl. Ki. Ageng Gribig – Jl. Muharto – Jl. Ir. H. Juanda – Jl. Kebalen Wetan – Jl. Laks. Martadinata – Jl. Kyai Tamim – Jl. K. P. Tendean – Jl. Syarif Al Qodri – Jl. A.I. Suryani – Jl. Sutan syahrir – Terminal Mulyorejo"
            },
            new Angkot()
            {
                Id = 32,
                AngkotName = "TAT",
                AngkotTrayek = "Tlogowaru – Arjowinangun – Tirtosari",
                AngkotOutPath = "APK Tlogowaru – Jl. Raya Tlogowaru – Jl. Istiqomah – Jl. Raya Arjowilangun – Jl. Babatan V – Jl. Wonorejo – Jl. Jembatan lori – Jl. Kol Sugiono – Jl. Satsui Tubun – Jl. S. Supriyadi – Jl. APK Tirtosari",
                AngkotInPath = "APK Tirtosari – Jl. S. Supriayadi – Jl. S. Tubun – JL. Kol Sugiyono – Jl. Jembatan Lori – Jl. Wonorejo – Jl. Babatan V – Jl. Babatan – Jl. Raya Arjowilangun – Jl. Istiqomah – Jl. Raya Tlogowaru – APK Tlogowaru"
            },
            new Angkot()
            {
                Id = 33,
                AngkotName = "TSG",
                AngkotTrayek = "Psr. Tawangmangu – Jl. Soekarno-Hatta – Gasek",
                AngkotOutPath = "Pasar Tawangmangu – Jl. Gilimanuk – Tembalangan – Jl. Soekarno-Hatta – Jl. MT Haryono Jl. Gajayana – Jl. Bend Sigura – gura – APK Gasek",
                AngkotInPath = "APK Gasek – Jl. Bend Sigura-gura – Jl. Gajayana Jl. MT Haryono – Jl. Soekarno-Hatta – Tembalangan Jl. Gilimanuk – Pasar Tawangmangu"
            },
            new Angkot()
            {
                Id = 34,
                AngkotName = "TSH",
                AngkotTrayek = "Psr. Tawangmangu – Jl. Soekarno-Hatta – Gasek",
                AngkotOutPath = "Pasar Tawangmangu – Jl. Gilimanuk – Tembalangan – Jl. Soekarno-Hatta – Jl. MT Haryono Jl. Gajayana – Jl. Bend Sigura – gura – APK Gasek",
                AngkotInPath = "APK Gasek – Jl. Bend Sigura-gura – Jl. Gajayana Jl. MT Haryono – Jl. Soekarno-Hatta – Tembalangan Jl. Gilimanuk – Pasar Tawangmangu"
            },
            new Angkot()
            {
                Id = 35,
                AngkotName = "TST",
                AngkotTrayek = "Tlogowaru – Sarangan – Tasikmadu",
                AngkotOutPath = "Sub Term Tlogowaru – Jl. Perum Puri Cempaka Putih – Jl. Raya Arjowilangun – Jl. Wonorejo – Jl. K. Parseh Jaya – Jl. M. Sungkono – Jl. Muharto – Jl. Puntodewa – Jl. Kalimasada – Jl. M. Wiyono – Jl. Kesatrian – Jl. Untung Suropati – Jl. P. Sudirman – Jl. WR. Supratman – Jl. L. Sutoyo – Jl.; Sarangan – Jl. Sarangan Atas – Jl. Selorejo – Jl. Selorejo Blok A – Jl. Selorejo Blok B – Jl. Mawar – Jl. Setaman – Jl. Melati – Jl. Bungur – Jl. Cengger Ayam – Jl. Cengger Ayam I – Jl. Ters Kendalsari – Jl. Bukirsari – Jl. Ters Candi Mendut – Jl. C. Bima – Jl. C. Badut – Jl. C. Sari Utara – Jl. Sudimoro – Jl. Ikan Kakap – Jl. Ikan Tombro – Jl. Ikan Tombro Barat – JL. KH.Yuuf Timur – Jl. KH Yusuf Barat – Jl. Ds Jeruk – Jl. Joyo Utama – APK Tasik Madu",
                AngkotInPath = "APK Tasik Madu – Jl. Joyo utomo – Jl. KH.Yusuf Timur Jl. Ikan Tombro Barat – Jl. Ikan Tombro – Jl. Kakap – Jl. C. sari – Jl. C. Mendut – Jl. Ters .C. Mendut – Jl. Bukit Sari – Jl. Cengger Ayam I – Jl. Cengger Ayam – Jl. Melati – Jl. Setaman – Jl. Mawar – Jl. Selorejo Blok B – Jl. Selorejo Blok A Jl. Sarangan Atas – Jl. Sarangan – Jl. L. Sutoyo – Jl. WR. Supratman – Jl. P. Sudirman Utara . – Jl. P. Sudirman Utara – Jl. Untung Suropati Utara – Jl. Kesatrian – Jl. M. Wiyono – Jl. Kalimasodo – Jl. Puntodewo – Jl. Muharo – Jl. Jl. M.Sungkono – Jl. K. Parseh Jaya – Jl. Wonorejo – Jl. Arjowilangun – Jl. Perum. Putri Cempaka Putih – Sub . Term. Putri Cempaka Putih – Sub . Term . Tlogo waru"
            }
        };

        public static IList<Angkot> GetAllAngkot()
        {
            return _Angkot;
        }

        public static Angkot GetAngkotById(int id)
        {
            return _Angkot[id];
        }
    }
}
